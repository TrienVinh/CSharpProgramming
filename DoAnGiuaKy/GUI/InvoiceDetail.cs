using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using DoAnGiuaKy.BUS;

namespace DoAnGiuaKy.GUI
{
    public partial class InvoiceDetail : Form
    {
        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void btaddCTHD_Click(object sender, EventArgs e)
        {
            tBMaHDCTHD.Focus();
            setStateTB(true);
            clearTB();

            btnQuaylai.Enabled = true;
            btloadCTHD.Enabled = true;

            btDeleteCTHD.Enabled = false;
            btFixCTHD.Enabled = false;
        }

        private void LoadDataGridview(List<InvoiceDetailDTO> ivd)
        {
            dataGridViewIVDetail.Rows.Clear();

            for(int i = 0; i < ivd.Count; i++)
            {
                string invoiceid = ivd[i].invoiceID;
                string typeid = ivd[i].typeID;
                string amount = ivd[i].amount.ToString();
                string total = ivd[i].total.ToString();

                dataGridViewIVDetail.Rows.Add(invoiceid, typeid, amount, total);
            }
        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            LoadDataGridview(invoiceDetailDao.getAll());
            setStateTB(false);
            btloadCTHD.Enabled = false;
            btnQuaylai.Enabled = false;
        }

        private void dataGridViewIVDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ivdid = dataGridViewIVDetail.CurrentRow.Cells[0].Value.ToString();
            string typeid = dataGridViewIVDetail.CurrentRow.Cells[1].Value.ToString();

            InvoiceDetailDTO ivd = new invoiceDetailBus().get(ivdid, typeid);

            tBMaHDCTHD.Text = ivd.invoiceID;
            tBMaKieuCTHD.Text = ivd.typeID;
            tBSLCTHD.Text = ivd.amount.ToString();
            tBTongCTHD.Text =  ivd.total.ToString();
        }

        public void setStateTB(bool state)
        {
            tBMaHDCTHD.Enabled = state;
            tBMaKieuCTHD.Enabled= state;
            tBSLCTHD.Enabled = state;
            tBTongCTHD.Enabled = state;
        }

        public void clearTB()
        {
            tBMaKieuCTHD.Clear();
            tBMaHDCTHD.Clear();
            tBSLCTHD.Clear();
            tBTongCTHD.Clear();
        }

        private void btFixCTHD_Click(object sender, EventArgs e)
        {
            setStateTB(true);
            
            tBMaHDCTHD.Enabled = false;
            tBMaKieuCTHD.Enabled = false;

            btaddCTHD.Enabled = false;
            btDeleteCTHD.Enabled = false;

            btloadCTHD.Enabled = true;
            btnQuaylai.Enabled = true;
        }

        private void btDeleteCTHD_Click(object sender, EventArgs e)
        {
            string id = dataGridViewIVDetail.CurrentRow.Cells[0].Value.ToString();
            string typeid = dataGridViewIVDetail.CurrentRow.Cells[1].Value.ToString();

            DialogResult dal = MessageBox.Show("Bạn có chắc muốn xoá?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dal == DialogResult.Yes)
            {
                new invoiceDetailBus().delete(id, typeid);

                MessageBox.Show("Xoá thành công", "Delete");

                LoadDataGridview(new invoiceDetailBus().list);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            setStateTB(false);

            btaddCTHD.Enabled = true;
            btFixCTHD.Enabled = true;
            btDeleteCTHD.Enabled = true;

            btnQuaylai.Enabled = false;
            btloadCTHD.Enabled = false;
         }

        private void btloadCTHD_Click(object sender, EventArgs e)
        {
            string invoiceid = tBMaHDCTHD.Text.Trim();
            string typeid = tBMaKieuCTHD.Text.Trim();

            if (invoiceid == "" || typeid == "" || tBSLCTHD.Text == "" || tBTongCTHD.Text == "" )
            {
                MessageBox.Show("Lỗi! Có dòng bạn chưa nhập");
                return;
            }

            int amount = int.Parse(tBSLCTHD.Text);
            float total = float.Parse(tBTongCTHD.Text);

            InvoiceDetailDTO ivd = new InvoiceDetailDTO(invoiceid, typeid, amount, total);

            if (tBMaHDCTHD.Enabled && tBMaKieuCTHD.Enabled)
            {
                new invoiceDetailBus().add(ivd);

                MessageBox.Show($"Thêm thành công CTHD", "Insert");

                btFixCTHD.Enabled = true;
            }
            else
            {
                new invoiceDetailBus().set(ivd);

                MessageBox.Show($"Sửa thành công {invoiceid}", "Insert");

                btaddCTHD.Enabled = true;
            }

            clearTB();
            setStateTB(false);

            LoadDataGridview(invoiceDetailDao.getAll());

            btloadCTHD.Enabled = false;
            btnQuaylai.Enabled = false;
            btDeleteCTHD.Enabled = true;
        }

        public void search()
        {
            dataGridViewIVDetail.Rows.Clear();

            List<InvoiceDetailDTO> result = new invoiceDetailBus().Search(tbTKCTHD.Text.Trim(), tBtkMaKieu.Text.Trim());

            LoadDataGridview(result);
        }

        private void tbTKCTHD_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void tBtkMaKieu_TextChanged(object sender, EventArgs e)
        {
            search();
        }

    }
}
