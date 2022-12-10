using DoAnGiuaKy.BUS;
using DoAnGiuaKy.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnGiuaKy.GUI
{
	public partial class Invoice : Form
	{
		public Invoice()
		{
			InitializeComponent();
		}

		private void LoadDataGridView(List<InvoiceDTO> invoiceList)
		{
			dataGridView1.Rows.Clear();

			for (int i = 0; i < invoiceList.Count; i++)
			{
				string invoiceID = invoiceList[i].invoiceID;
				string staffID = invoiceList[i].staffID;
				string customerID = invoiceList[i].customerID;
				int total = invoiceList[i].invoiceTotal;
				string datetime = invoiceList[i].invoiceDateTime;

				dataGridView1.Rows.Add(invoiceID, staffID, customerID, total, datetime);
			}
		}

		private void LoadInputCmbx()
		{
			nhanVienCmbx.DataSource = new InvoiceBUS().GetStaff();
			nhanVienCmbx.DisplayMember = "staffID";
			nhanVienCmbx.ValueMember = "staffID";

			khachHangCmbx.DataSource = new InvoiceBUS().GetCustomer();
			khachHangCmbx.DisplayMember = "customerID";
			khachHangCmbx.ValueMember = "customerID";

			string[] tieuChi = {"Mã hóa đơn", "Nhân viên nhập", "Khách hàng", "Tổng tiền", "Thời gian"};
			tieuChiCmbx.Items.AddRange(tieuChi);
			tieuChiCmbx.SelectedIndex = -1;
		}

		private void SetTextboxesState(bool state)
		{
			maHoaDonTxtb.Enabled = state;
			nhanVienCmbx.Enabled = state;
			khachHangCmbx.Enabled = state;
			tongTienTxtb.Enabled = state;
			thoiGianTxtb.Enabled = state;
		}

		private void ClearTextboxes()
		{
			maHoaDonTxtb.Text = "";
			nhanVienCmbx.SelectedIndex = 0;
			khachHangCmbx.SelectedIndex = 0;
			tongTienTxtb.Text = "";
			thoiGianTxtb.Text = "";
		}

		private void Search()
		{
			dataGridView1.Rows.Clear();
			var searchResult = new InvoiceBUS().Search(tieuChiCmbx.SelectedIndex, timKiemTxtb.Text);
			LoadDataGridView(searchResult);
		}

		private void Invoice_Load(object sender, EventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadInputCmbx();
			LoadDataGridView(new InvoiceBUS().invoiceList);
			SetTextboxesState(false);
			luuBt.Enabled = false;
		}

		private void xoaHoaDonBt_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			DialogResult result = MessageBox.Show("Do you want to delete " + id + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				InvoiceBUS bus = new InvoiceBUS();
				bus.Delete(id);

				MessageBox.Show($"Successfully Deleted {id}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDataGridView(bus.invoiceList);
			}
		}
		
		private void suaHoaDonBt_Click(object sender, EventArgs e)
		{
			SetTextboxesState(true);
			maHoaDonTxtb.Enabled = false;
			luuBt.Enabled = true;
		}
		
		private void luuBt_Click(object sender, EventArgs e)
		{
			string invoiceID = maHoaDonTxtb.Text.Trim();
			string staffID = nhanVienCmbx.SelectedValue.ToString().Trim();
			string customerID = khachHangCmbx.SelectedValue.ToString().Trim();
			int total = Convert.ToInt32(tongTienTxtb.Text);
			string datetime = thoiGianTxtb.Text.Trim();

			InvoiceDTO invoice = new InvoiceDTO(invoiceID, staffID, customerID, total, datetime);

			new InvoiceBUS().Update(invoice);
			MessageBox.Show($"Successfully Updated Invoice {invoiceID}!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

			ClearTextboxes();
			SetTextboxesState(false);
			LoadDataGridView(new InvoiceBUS().invoiceList);
			luuBt.Enabled = false;
		}
		
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

			InvoiceDTO selected = new InvoiceBUS().Get(id);

			maHoaDonTxtb.Text = selected.invoiceID;
			nhanVienCmbx.SelectedValue = selected.staffID;
			khachHangCmbx.SelectedValue = selected.customerID;
			tongTienTxtb.Text = selected.invoiceTotal.ToString();
			thoiGianTxtb.Text = selected.invoiceDateTime;
		}
		
		private void lamRongBt_Click(object sender, EventArgs e)
		{
			ClearTextboxes();
		}
		
		private void quayLaiBt_Click(object sender, EventArgs e)
		{
			
		}
		
		private void timKiemTxtb_TextChanged(object sender, EventArgs e)
		{
			Search();
		}

		private void tieuChiCmbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			Search();
		}
	}
}
