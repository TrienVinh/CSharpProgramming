using DoAnGiuaKy.BUS;
using DoAnGiuaKy.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnGiuaKy.GUI
{
	public partial class Staff : Form
	{
		private string searchGender = "Nam";

		public Staff()
		{
			InitializeComponent();
		}

		private void LoadDataGridView(List<StaffDTO> staffList)
		{			
			dataGridView1.Rows.Clear();

			for (int i = 0; i < staffList.Count; i++)
			{
				string id = staffList[i].staffID;
				string last = staffList[i].staffLast;
				string first = staffList[i].staffFirst;
				string gender = staffList[i].staffGender;
				string birth = staffList[i].staffBirth;
				string address = staffList[i].staffAddress;
				string phone = staffList[i].staffTelephone;

				dataGridView1.Rows.Add(id, last, first, gender, birth, address, phone);
			}
		}

		private void LoadCmbx()
		{
			string[] tieuChi = { "Mã nhân viên", "Họ nhân viên", "Tên nhân viên", "Ngày sinh", "Địa chỉ", "Điện thoại" };
			tieuChiCmbx.Items.AddRange(tieuChi);
			tieuChiCmbx.SelectedIndex = -1;
		}

		private void SetTextboxesState(bool state)
		{
			maNhanVienTxtb.Enabled = state;
			hoNhanVienTxtb.Enabled = state;
			tenNhanVienTxtb.Enabled = state;
			namChbx.Enabled = state;
			nuChbx.Enabled = state;
			ngaySinhTxtb.Enabled = state;
			diaChiTxtb.Enabled = state;
			dienThoaiTxtb.Enabled = state;
		}

		private void ClearTextboxes()
		{
			maNhanVienTxtb.Text = "";
			hoNhanVienTxtb.Text = "";
			tenNhanVienTxtb.Text = "";
			namChbx.Checked = false;
			nuChbx.Checked = false;
			ngaySinhTxtb.Text = "";
			diaChiTxtb.Text = "";
			dienThoaiTxtb.Text = "";
		}

		private void Search()
		{
			dataGridView1.Rows.Clear();
			var searchResult = new StaffBUS().Search(tieuChiCmbx.SelectedIndex, timKiemTxtb.Text, searchGender);
			LoadDataGridView(searchResult);
		}

		private void Staff_Load(object sender, EventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadCmbx();
			LoadDataGridView(new StaffBUS().staffList);
			SetTextboxesState(false);
			luuBt.Enabled = false;
		}

		private void namChbx_CheckedChanged(object sender, EventArgs e)
		{
			nuChbx.CheckedChanged -= nuChbx_CheckedChanged;
			nuChbx.Checked = !nuChbx.Checked;
			nuChbx.CheckedChanged += new EventHandler(nuChbx_CheckedChanged);
		}

		private void nuChbx_CheckedChanged(object sender, EventArgs e)
		{
			namChbx.CheckedChanged -= namChbx_CheckedChanged;
			namChbx.Checked = !namChbx.Checked;
			namChbx.CheckedChanged += new EventHandler(namChbx_CheckedChanged);
		}

		private void timKiemNamChbx_CheckedChanged(object sender, EventArgs e)
		{
			searchGender = timKiemNamChbx.Text;
			
			// Disable the female search check box without triggering the event.
			timKiemNuChbx.CheckedChanged -= timKiemNuChbx_CheckedChanged;
			timKiemNuChbx.Checked = !timKiemNuChbx.Checked;
			timKiemNuChbx.CheckedChanged += new EventHandler(timKiemNuChbx_CheckedChanged);

			// Trigger an search event as if the search textbox's text is changed.
			timKiemTxtb_TextChanged(sender, e);

		}

		private void timKiemNuChbx_CheckedChanged(object sender, EventArgs e)
		{
			searchGender = timKiemNuChbx.Text;

			// Disable the male search check box without triggering the event.
			timKiemNamChbx.CheckedChanged -= timKiemNamChbx_CheckedChanged;
			timKiemNamChbx.Checked = !timKiemNamChbx.Checked;
			timKiemNamChbx.CheckedChanged += new EventHandler(timKiemNamChbx_CheckedChanged);

			// Trigger an search event as if the search textbox's text is changed.
			timKiemTxtb_TextChanged(sender, e);
		}

		private void tieuChiCmbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			timKiemTxtb_TextChanged(sender, e);
		}
		
		private void timKiemTxtb_TextChanged(object sender, EventArgs e)
		{
			if (timKiemTxtb.Text != "")
				Search();
			else
				LoadDataGridView(new StaffBUS().staffList);
		}
		

		private void themNhanVienBt_Click(object sender, EventArgs e)
		{
			SetTextboxesState(true);
			ClearTextboxes();
			maNhanVienTxtb.Focus();
			luuBt.Enabled = true;
		}

		private void xoaNhanVienBt_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			DialogResult result = MessageBox.Show("Do you want to delete " + id + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				StaffBUS bus = new StaffBUS();
				bus.Delete(id);

				MessageBox.Show($"Successfully Deleted {id}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDataGridView(bus.staffList);
			}
		}

		private void suaNhanVienBt_Click(object sender, EventArgs e)
		{
			SetTextboxesState(true);
			maNhanVienTxtb.Enabled = false;
			luuBt.Enabled = true;
		}

		private void luuBt_Click(object sender, EventArgs e)
		{
			string id = maNhanVienTxtb.Text.Trim();
			string last = hoNhanVienTxtb.Text.Trim();
			string first = tenNhanVienTxtb.Text.Trim();
			string gender = namChbx.Checked ? "Nam" : "Nữ";
			string birth = ngaySinhTxtb.Text.Trim();
			string address = diaChiTxtb.Text.Trim();
			string phone = dienThoaiTxtb.Text.Trim();

			StaffDTO staff = new StaffDTO(id, last, first, gender, birth, address, phone);
			StaffBUS bus = new StaffBUS();
			
			if (bus.Get(id) == null)
			{
				bus.Insert(staff);
				MessageBox.Show($"Successfully Inserted Staff {id}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				bus.Update(staff);
				MessageBox.Show($"Successfully Updated Staff {id}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			ClearTextboxes();
			SetTextboxesState(false);
			LoadDataGridView(new StaffBUS().staffList);
			luuBt.Enabled = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

			StaffDTO selected = new StaffBUS().Get(id);

			maNhanVienTxtb.Text = selected.staffID;
			hoNhanVienTxtb.Text = selected.staffLast;
			tenNhanVienTxtb.Text = selected.staffFirst;
			namChbx.Checked = selected.staffGender.ToLower().EndsWith("m");
			nuChbx.Checked = namChbx.Checked ? false : true;
			ngaySinhTxtb.Text = selected.staffBirth;
			diaChiTxtb.Text = selected.staffAddress;
			dienThoaiTxtb.Text = selected.staffTelephone;
		}

		private void lamRongBt_Click(object sender, EventArgs e)
		{
			ClearTextboxes();
		}

		private void quayLaiBt_Click(object sender, EventArgs e)
		{

		}

	}
}
