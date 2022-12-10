using DoAnGiuaKy.BUS;
using DoAnGiuaKy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGiuaKy.GUI
{
    public partial class Route : Form
    {
        public Route()
        {
            InitializeComponent();
        }

        private void LoadDataGridView(List<RouteDTO> routeList)
        {
            dataGridView1.Rows.Clear();

            for(int i = 0; i < routeList.Count; i++)
            {
                string RouteID = routeList[i].RouteID;
                string Diemxuatphat = routeList[i].departureLocation;
                string Diemden = routeList[i].arrivalLocation;

                dataGridView1.Rows.Add(RouteID, Diemxuatphat, Diemden);
            }
        }

        private void LoadCmbx()
        {
            string[] tieuChi = { "Id", "Điểm xuất phát", "Điểm đến" };
            TieuchiCmBx.Items.AddRange(tieuChi);
            TieuchiCmBx.SelectedIndex = -1;
        }

        private void ClearTextboxes()
        {
            txtMalotrinh.Text = "";
            txtDiemxuatphat.Text = "";
            txtDiemden.Text = "";
        }

        private void SetTextboxesState(bool state)
        {
            txtMalotrinh.Enabled = state;
            txtDiemxuatphat.Enabled = state;
            txtDiemden.Enabled = state;
        }

        public void Search()
        {
            dataGridView1.Rows.Clear();

            RouteBUS bus = new RouteBUS();
            var searchResult = bus.Search(txtMalotrinh.Text, txtDiemxuatphat.Text, txtDiemden.Text);
            LoadDataGridView(searchResult);
        }

        private void Route_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banvemaybay1DataSet.route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.banvemaybay1DataSet.route);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            
            LoadDataGridView(new RouteBUS().routeList);
            SetTextboxesState(false);
            Luubt.Enabled = false;
        }

        private void Thembt_Click(object sender, EventArgs e)
        {
            SetTextboxesState(true);
            ClearTextboxes();
            txtMalotrinh.Focus();
            Luubt.Enabled = true;
        }

        private void Xoabt_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Do you want to delete " + id + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new RouteBUS().Delete(id);

                MessageBox.Show($"Successfully Deleted {id}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView(new RouteBUS().routeList);
            }
        }

        private void Suabt_Click(object sender, EventArgs e)
        {
            SetTextboxesState(true);
            txtMalotrinh.Enabled = false;
            Luubt.Enabled = true;
        }

        private void Luubt_Click(object sender, EventArgs e)
        {
            string RouteID = txtMalotrinh.Text.Trim();
            string Diemxuatphat = txtDiemxuatphat.Text.Trim();
            string Diemden = txtDiemden.Text.Trim();

            RouteDTO route = new RouteDTO(RouteID,Diemxuatphat,Diemden);
            RouteBUS bus = new RouteBUS();

            if (bus.Get(RouteID) == null)
            {
                bus.Insert(route);
                MessageBox.Show($"Successfully Inserted Airplane {RouteID}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bus.Update(route);
                MessageBox.Show($"Successfully Updated Airplane {RouteID}!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearTextboxes();
            SetTextboxesState(false);
            LoadDataGridView(new RouteBUS().routeList);
            Luubt.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            RouteDTO selected = new RouteBUS().Get(id);

            txtMalotrinh.Text = selected.RouteID;
            txtDiemxuatphat.Text = selected.departureLocation;
            txtDiemden.Text = selected.arrivalLocation;    
        }

        
    }
}
