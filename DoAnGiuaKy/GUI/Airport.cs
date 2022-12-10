using DoAnGiuaKy.BUS;
using DoAnGiuaKy.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnGiuaKy.GUI
{
	public partial class Airport : Form
	{
		public Airport()
		{
			InitializeComponent();
		}

		private void LoadDataGridView(List<AirportDTO> airportList)
		{
			dataGridView1.Rows.Clear();

			for (int i = 0; i < airportList.Count; i++)
			{
				string id = airportList[i].airportID;
				string name = airportList[i].airportName;
				string city = airportList[i].airportCity;

				dataGridView1.Rows.Add(id, name, city);
			}
		}

		private void LoadCmbx()
		{
			string[] tieuChi = { "Mã sân bay", "Tên sân bay", "Tên thành phố" };
			tieuChiCmbx.Items.AddRange(tieuChi);
			tieuChiCmbx.SelectedIndex = -1;
		}

		private void SetTextboxesState(bool state)
		{
			maSanBayTxtb.Enabled = state;
			tenSanBayTxtb.Enabled = state;
			tenThanhPhoTxtb.Enabled = state;
		}

		private void ClearTextboxes()
		{
			maSanBayTxtb.Text = "";
			tenSanBayTxtb.Text = "";
			tenThanhPhoTxtb.Text = "";
		}

		private void Search()
		{
			dataGridView1.Rows.Clear();
			var searchResult = new AirportBUS().Search(tieuChiCmbx.SelectedIndex, timKiemTxtb.Text);
			LoadDataGridView(searchResult);
		}

		private void Airport_Load(object sender, EventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.MultiSelect = false;

			LoadCmbx();
			LoadDataGridView(new AirportBUS().airportList);
			SetTextboxesState(false);
			luuBt.Enabled = false;
		}

		private void tieuChiCmbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			timKiemTxtb_TextChanged(sender, e);
		}

		private void timKiemTxtb_TextChanged(object sender, EventArgs e)
		{
			Search();
		}

		private void themSanBayBt_Click(object sender, EventArgs e)
		{
			SetTextboxesState(true);
			ClearTextboxes();
			maSanBayTxtb.Focus();
			luuBt.Enabled = true;
		}

		private void xoaSanBayBt_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			DialogResult result = MessageBox.Show("Do you want to delete " + id + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				AirportBUS bus = new AirportBUS();
				bus.Delete(id);

				MessageBox.Show($"Successfully Deleted {id}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDataGridView(bus.airportList);
			}
		}

		private void suaSanBayBt_Click(object sender, EventArgs e)
		{
			SetTextboxesState(true);
			maSanBayTxtb.Enabled = false;
			luuBt.Enabled = true;
		}

		private void luuBt_Click(object sender, EventArgs e)
		{
			string id = maSanBayTxtb.Text.Trim();
			string name = tenSanBayTxtb.Text.Trim();
			string city = tenThanhPhoTxtb.Text.Trim();

			AirportDTO airport = new AirportDTO(id, name, city);
			AirportBUS bus = new AirportBUS();

			if (id.Equals("") || name.Equals("") || city.Equals(""))
			{
				MessageBox.Show("Please fill all the fields above before hit save!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			else if (bus.Get(id) == null)
			{
				bus.Insert(airport);
				MessageBox.Show($"Successfully Inserted Airport {id}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			else
			{
				bus.Update(airport);
				MessageBox.Show($"Successfully Updated Airport {id}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			ClearTextboxes();
			SetTextboxesState(false);
			LoadDataGridView(new AirportBUS().airportList);
			luuBt.Enabled = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

			AirportDTO selected = new AirportBUS().Get(id);

			maSanBayTxtb.Text = selected.airportID;
			tenSanBayTxtb.Text = selected.airportName;
			tenThanhPhoTxtb.Text = selected.airportCity;
		}

		private void lamRongBt_Click(object sender, EventArgs e)
		{
			ClearTextboxes();
		}
	}
}
