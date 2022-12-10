using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnGiuaKy.DTO;
using DoAnGiuaKy.DAO;
using DoAnGiuaKy.BUS;

namespace DoAnGiuaKy.GUI
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void loadDataGridView(List<TicketDTO> ticket)
        {
            dataGridView1.Rows.Clear();

            for(int i = 0; i < ticket.Count; i++)
            {
                string ticketid = ticket[i].ticketID;
                string typeid = ticket[i].typeID;
                string customerid = ticket[i].customerID;
                string flightid = ticket[i].flightID;
                string invoiceid = ticket[i].invoiceID;

                dataGridView1.Rows.Add(ticketid,customerid,flightid,invoiceid,typeid);
            }
        }

        public void setTexBoxstate(bool state)
        {
            tBMaVe.Enabled = state;
            tBmkh.Enabled = state;
            tBmhd.Enabled = state;
            tBmcb.Enabled = state;
            tBmlv.Enabled = state;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btLoadticket_Click(object sender, EventArgs e)
        {
            btaddticket.Enabled = true;
            btdeleteticket.Enabled = true;
            btfixticket.Enabled = true;
            btnLuu.Enabled = false;
            btLoadticket.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airplaneTicketMngmtDBDataSet.tickettype' table. You can move, or remove it, as needed.
            this.tickettypeTableAdapter.Fill(this.airplaneTicketMngmtDBDataSet.tickettype);
            loadDataGridView(TicketDao.getAll());
            
            setTexBoxstate(false);
            btnLuu.Enabled = false;
            btLoadticket.Enabled = false;

            LoaddataGridViewTicketType(TicketTypeDao.getAll());
            
            setstateTicketTypeTB(false);
            btnLuutt.Enabled = false;
            btnQuaytt.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            TicketDTO ticket = new TicketBus().get(id);

            tBMaVe.Text = ticket.ticketID;
            tBmcb.Text = ticket.flightID;
            tBmkh.Text = ticket.customerID;
            tBmhd.Text = ticket.invoiceID;
            tBmlv.Text = ticket.typeID;
        }

        public void cleartextbox()
        {
            tBMaVe.Clear();
            tBmcb.Clear();
            tBmkh.Clear();
            tBmhd.Clear();
            tBmlv.Clear();
        }

        private void btaddticket_Click(object sender, EventArgs e)
        {
            cleartextbox();
            setTexBoxstate(true);
            btnLuu.Enabled = true;
            btLoadticket.Enabled = true;
            btfixticket.Enabled = false;
            btdeleteticket.Enabled = false;
            tBMaVe.Focus();
        }

        private void btfixticket_Click(object sender, EventArgs e)
        {
            setTexBoxstate(true);
            btLoadticket.Enabled = true;
            tBMaVe.Enabled = false;
            btnLuu.Enabled = true;
            btaddticket.Enabled = false;
            btdeleteticket.Enabled = false;
        }

        private void btdeleteticket_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn thật sự muốn xoá","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                new TicketBus().delete(id);
                loadDataGridView(TicketDao.getAll());
                cleartextbox();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ticketid = tBMaVe.Text.Trim();
            string customerid = tBmkh.Text.Trim();
            string flightid = tBmcb.Text.Trim();
            string invoiceid = tBmhd.Text.Trim();
            string typeid = tBmlv.Text.Trim();

            if(ticketid=="" || customerid == "" || flightid == "" || invoiceid == "" || typeid == ""){
                MessageBox.Show("Lỗi! Chưa có gì để lưu!");
                return;
            }

            TicketDTO ticket = new TicketDTO(ticketid, customerid, flightid, typeid, invoiceid);
            TicketBus tb = new TicketBus();
            if (tBMaVe.Enabled)
            {
                tb.add(ticket);
                
                MessageBox.Show($"Thêm thành công ticket {ticketid}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btfixticket.Enabled = true;
            }
            else
            {
                tb.set(ticket);
                
                MessageBox.Show($"Sửa thành công {ticketid}", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                btaddticket.Enabled = true;
            }

            cleartextbox();
            setTexBoxstate(false);
            loadDataGridView(TicketDao.getAll());
            btnLuu.Enabled = false;
            btLoadticket.Enabled = false;
            btdeleteticket.Enabled = true;
        }

        public void search()
        {
            dataGridView1.Rows.Clear();

            List<TicketDTO> result = new TicketBus().Search(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            loadDataGridView(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        //Form tickettype
        public void setstateTicketTypeTB(bool state)
        {
            tbMaKieu.Enabled = state;
            tbTenKieu.Enabled=state;
            tbPhongcho.Enabled = state;
            tbGia.Enabled = state;
        } 

        public void cleartextboxtickettype()
        {
            tbMaKieu.Clear();
            tbTenKieu.Clear();
            tbPhongcho.Clear();
            tbGia.Clear();
        }
        private void btthemTickettype_Click(object sender, EventArgs e)
        {
            setstateTicketTypeTB(true);
            btnLuutt.Enabled = true;
            btnQuaytt.Enabled = true;
            btsuaTickettype.Enabled = false;
            btxoaTickettype.Enabled = false;
        }

        private void btsuaTickettype_Click(object sender, EventArgs e)
        {
            setstateTicketTypeTB(true);
            tbMaKieu.Enabled = false;
            btnLuutt.Enabled = true;
            btnQuaytt.Enabled = true;
            btthemTickettype.Enabled = false;
            btxoaTickettype.Enabled = false;
        }


        private void btxoaTickettype_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            DialogResult dal = MessageBox.Show("Bạn thật sự muốn xoá ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dal == DialogResult.Yes)
            {
                new TicketTypeBus().delete(id);

                MessageBox.Show($"Xoá thành công {id}!", "Delete");

                LoaddataGridViewTicketType(TicketTypeDao.getAll());

                cleartextboxtickettype();
            }
        }


        private void LoaddataGridViewTicketType(List<TicketTypeDTO> tt) 
        {
            dataGridView2.Rows.Clear();

            for(int i = 0; i < tt.Count; i++)
            {
                string typeid = tt[i].typeID;
                string typename = tt[i].typeName;
                string wattingroom = tt[i].waittingRoom.ToString();
                string typeprice = tt[i].typePrice.ToString();

                dataGridView2.Rows.Add(typeid, typename, wattingroom, typeprice);
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string typeid = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            TicketTypeDTO tt = new TicketTypeBus().get(typeid);

            tbMaKieu.Text = tt.typeID;
            tbTenKieu.Text = tt.typeName;
            tbPhongcho.Text = tt.waittingRoom.ToString();
            tbGia.Text = tt.typePrice.ToString();
        }

        private void btnQuaytt_Click(object sender, EventArgs e)
        {
            setstateTicketTypeTB(false);
            btthemTickettype.Enabled = true;
            btxoaTickettype.Enabled = true;
            btsuaTickettype.Enabled = true;
            btnQuaytt.Enabled = false;
            btnLuutt.Enabled = false;
        }

        private void btnLuutt_Click(object sender, EventArgs e)
        {
            string id = tbMaKieu.Text.Trim();
            string name = tbTenKieu.Text.Trim();
            
            if(id == "" || name == "" || tbPhongcho.Text == "" || tbGia.Text == "")
            {
                MessageBox.Show("Loi! Thiếu 1 trường chưa nhập!");
                return;
            }

            int waittingroom = int.Parse(tbPhongcho.Text.Trim());
            float gia = float.Parse(tbGia.Text.Trim());

            TicketTypeDTO tt = new TicketTypeDTO(id, name, waittingroom, gia);

            if (tbMaKieu.Enabled)
            {
                new TicketTypeBus().add(tt);

                MessageBox.Show($"Thêm thành công {id}", "Insert");

                btsuaTickettype.Enabled = true;
            }
            else
            {
                new TicketTypeBus().set(tt);

                MessageBox.Show($"Sửa thành công {id}", "Update");

                btthemTickettype.Enabled = true;
            }

            LoaddataGridViewTicketType(new TicketTypeBus().list);
            btnLuutt.Enabled = false;
            btnQuaytt.Enabled = false;
            btxoaTickettype.Enabled = true;
            setstateTicketTypeTB(false);
            cleartextboxtickettype();
        }

        public void searchtickettype()
        {
            dataGridView2.Rows.Clear();

            string id = tBtimIDtype.Text.Trim();
            string name = tBtimNametype.Text.Trim();
            
            List<TicketTypeDTO> result = new TicketTypeBus().Search(id,name);

            LoaddataGridViewTicketType(result);
        }
        private void tBtimIDtype_TextChanged(object sender, EventArgs e)
        {
            searchtickettype();
        }

        private void tBtimNamtype_TextChanged(object sender, EventArgs e)
        {
            searchtickettype();
        }
    }
}
