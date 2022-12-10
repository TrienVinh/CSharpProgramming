using DoAnGiuaKy.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoAnGiuaKy.BUS;

namespace DoAnGiuaKy.GUI
{
    public partial class Flight : Form
    {
        public Flight()
        {
            InitializeComponent();
        }

        private void LoadDataGridView(List<FlightDTO> flightList)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < flightList.Count; i++)
            {
                string FlightID = flightList[i].FlightID;
                string RouteID = flightList[i].RouteID;
                string airplaneID = flightList[i].airplaneID;
                string FlightScheduleID = flightList[i].flightScheduleID;
                string DepartureDay = flightList[i].departureDay;
                string ArrivalDay = flightList[i].arrivalDay;
                int totalSeats = flightList[i].totalSeats;
                int ECO = flightList[i].ECOSeats;
                int BUS = flightList[i].BUSSeats;

                dataGridView1.Rows.Add(FlightID,RouteID,airplaneID,FlightScheduleID,DepartureDay,ArrivalDay,totalSeats,ECO,BUS);
            }
        }

        private void LoadCmbx()
        {
            string[] Tieuchi = { "Mã chuyến bay", "Lộ trình", "Máy bay", "Lịch bay", "Thời gian đi", "Thời gian đến", "Tống ghế", "Ghé thường", "Ghé VIP" };
            TieuchiCmbx.Items.AddRange(Tieuchi);
            TieuchiCmbx.SelectedIndex = -1;
        }

        private void SetTextboxesState(bool state)
        {
            txtMachuyenbay.Enabled = state;
            LotrinhCmbx.Enabled = state;
            MaybayCmbx.Enabled = state;
            LichbayCmbx.Enabled = state;
            txtThoigianden.Enabled = state;
            txtThoigiandi.Enabled = state;
            txtTongghe.Enabled = state;
            ECOnumberic.Enabled = state;
            BUSnumberic.Enabled = state;   
        }

        private void ClearTextboxes()
        {
            txtMachuyenbay.Text = "";
            LotrinhCmbx.SelectedIndex = 0;
            MaybayCmbx.SelectedIndex = 0;
            LichbayCmbx.SelectedIndex = 0;
            txtThoigiandi.Text = "";
            txtThoigianden.Text = "";
            txtTongghe.Text = "";
            ECOnumberic.Value = 0;
            BUSnumberic.Value = 0;
        }

        private void Search()
        {
            dataGridView1.Rows.Clear();
            var searchResult = new FlightBUS().Search(TieuchiCmbx.SelectedIndex, txtTimkiem.Text);
            LoadDataGridView(searchResult);
        }



        private void Flight_Load(object sender, EventArgs e)
        {
            this.flightTableAdapter.Fill(this.banvemaybay1DataSet.flight);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadCmbx();
            LoadDataGridView(new FlightBUS().flightList);
            SetTextboxesState(false);
            luuBt.Enabled = false;
        }

        private void TieuchiCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            SetTextboxesState(true);
            ClearTextboxes();
            txtMachuyenbay.Focus();
            luuBt.Enabled = true;
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Do you want to delete " + id + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FlightBUS bus = new FlightBUS();
                bus.Delete(id);

                MessageBox.Show($"Successfully Deleted {id}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView(bus.flightList);
            }
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            SetTextboxesState(true);
            txtMachuyenbay.Enabled = false;
            luuBt.Enabled = true;
        }

        private void luuBt_Click(object sender, EventArgs e)
        {
            string FlightID = txtMachuyenbay.Text.Trim();
            string RouteID = LotrinhCmbx.SelectedValue.ToString().Trim();
            string airplaneID = MaybayCmbx.SelectedValue.ToString().Trim();
            string FlightScheduleID = LichbayCmbx.SelectedValue.ToString().Trim();
            string DepartureDay = txtThoigiandi.Text.Trim();
            string ArrivalDay = txtThoigianden.Text.Trim();
            int totalSeats = Convert.ToInt32(txtTongghe.Text);
            int ECOSeats = Convert.ToInt32(ECOnumberic.Text);
            int BUSSeats = Convert.ToInt32(BUSnumberic.Text);

            FlightDTO flight = new FlightDTO(FlightID, RouteID, airplaneID, FlightScheduleID,DepartureDay,ArrivalDay,totalSeats,ECOSeats,BUSSeats);
            new FlightBUS().Update(flight);
            MessageBox.Show($"Successfully Updated Invoice {FlightID}!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearTextboxes();
            SetTextboxesState(false);
            LoadDataGridView(new FlightBUS().flightList);
            luuBt.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            FlightDTO selected = new FlightBUS().Get(id);

            txtMachuyenbay.Text = selected.FlightID;
            LotrinhCmbx.SelectedItem = selected.RouteID;
            MaybayCmbx.SelectedItem = selected.airplaneID;
            LichbayCmbx.SelectedItem= selected.flightScheduleID;
            txtThoigiandi.Text = selected.departureDay;
            txtThoigianden.Text = selected.arrivalDay;
            txtTongghe.Text = selected.totalSeats.ToString();

            
        }

        private void txtlamRong_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
        }

        
    }
}
