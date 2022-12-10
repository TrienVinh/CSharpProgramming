using DoAnGiuaKy.BUS;
using DoAnGiuaKy.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnGiuaKy.GUI
{
	public partial class Airplane : Form
	{
		public Airplane()
		{
			InitializeComponent();
		}

		private void LoadDataGridView(List<AirplaneDTO> airplaneList)
		{
			dataGridView1.Rows.Clear();

			for (int i = 0; i < airplaneList.Count; i++)
			{
				string airplaneID = airplaneList[i].airplaneID;
				string name = airplaneList[i].airplaneName;
				string brand = airplaneList[i].airplaneBrand;
				string airlineID = airplaneList[i].airlineID;
				int ECO = airplaneList[i].ECOSeats;
				int BUS = airplaneList[i].BUSSeats;

				dataGridView1.Rows.Add(airplaneID, name, brand, airlineID, ECO, BUS);
			}
		}

		private void LoadAirlineCmbx()
		{
			maHangHKCmbx.DataSource = new AirplaneBUS().GetAirline();
			maHangHKCmbx.DisplayMember = "airlineName";
			maHangHKCmbx.ValueMember = "airlineID";
		}

		private void ClearTextboxes()
		{
			maMayBayTxtb.Text = "";
			tenMayBayTxtb.Text = "";
			hangSanXuatTxtb.Text = "";
			maHangHKCmbx.SelectedIndex = 0;
			soGheECOTxtb.Text = "";
			soGheBUSTxtb.Text = "";
		}

		private void SetTextboxesState(bool state)
		{
			maMayBayTxtb.Enabled = state;
			tenMayBayTxtb.Enabled = state;
			hangSanXuatTxtb.Enabled = state;
			maHangHKCmbx.Enabled = state;
			soGheECOTxtb.Enabled = state;
			soGheBUSTxtb.Enabled = state;
		}

		public void Search()
		{
			dataGridView1.Rows.Clear();

			AirplaneBUS bus = new AirplaneBUS();
			var searchResult = bus.Search(tkTenHangTxtb.Text, tkSoGheECOTxtb.Text, tkSoGheBUSTxtb.Text);
			LoadDataGridView(searchResult);
		}

		private void Airplane_Load(object sender, EventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.MultiSelect = false;

			LoadAirlineCmbx();
			LoadDataGridView(new AirplaneBUS().airplaneList);
			SetTextboxesState(false);
			luuBt.Enabled = false;
		}

		private void themMayBayBt_Click(object sender, EventArgs e)
		{
			SetTextboxesState(true);
			ClearTextboxes();
			maMayBayTxtb.Focus();
			luuBt.Enabled = true;
		}

		private void xoaMayBayBt_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			DialogResult result = MessageBox.Show("Do you want to delete " + id + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if (result == DialogResult.Yes) {
				new AirplaneBUS().Delete(id);
				
				MessageBox.Show($"Successfully Deleted {id}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDataGridView(new AirplaneBUS().airplaneList);
			}
		}
		private void suaMayBayBt_Click(object sender, EventArgs e)
		{
			SetTextboxesState(true);
			maMayBayTxtb.Enabled = false;
			luuBt.Enabled = true;
		}

		private void luuBt_Click(object sender, EventArgs e)
		{
			string airplaneID = maMayBayTxtb.Text.Trim();
			string name = tenMayBayTxtb.Text.Trim();
			string brand = hangSanXuatTxtb.Text.Trim();
			string airlineID = maHangHKCmbx.SelectedValue.ToString().Trim();
			int ecoSeats = Convert.ToInt32(soGheECOTxtb.Text.Trim());
			int busSeats = Convert.ToInt32(soGheBUSTxtb.Text.Trim());

			AirplaneDTO airplane = new AirplaneDTO(airplaneID, name, brand, airlineID, ecoSeats, busSeats);
			AirplaneBUS bus = new AirplaneBUS();

			if (bus.Get(airplaneID) == null)
			{
				bus.Insert(airplane);
				MessageBox.Show($"Successfully Inserted Airplane {airplaneID}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				bus.Update(airplane);
				MessageBox.Show($"Successfully Updated Airplane {airplaneID}!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			ClearTextboxes();
			SetTextboxesState(false);
			LoadDataGridView(new AirplaneBUS().airplaneList);
			luuBt.Enabled = false;
		}
		
		private void quayLaiBt_Click(object sender, EventArgs e)
		{
			
		}
		
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

			AirplaneDTO selected = new AirplaneBUS().Get(id);

			maMayBayTxtb.Text = selected.airplaneID;
			tenMayBayTxtb.Text = selected.airplaneName;
			hangSanXuatTxtb.Text = selected.airplaneBrand;
			maHangHKCmbx.SelectedValue = selected.airlineID;
			soGheECOTxtb.Text = selected.ECOSeats.ToString();
			soGheBUSTxtb.Text = selected.BUSSeats.ToString();
		}
		
		private void tkTenHangTxtb_TextChanged(object sender, EventArgs e)
		{
			Search();
		}

		private void tkSoGheECOTxtb_TextChanged(object sender, EventArgs e)
		{
			Search();
		}

		private void tkSoGheBUSTxtb_TextChanged(object sender, EventArgs e)
		{
			Search();
		}

	}
}
