using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DoAnGiuaKy.GUI;
using System.Windows.Forms;

namespace DoAnGiuaKy
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}
		private void Others_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Show();
		}

		private void mayBayBt_Click(object sender, EventArgs e)
		{
			Airplane airplaneForm = new Airplane();
			airplaneForm.FormClosed += new FormClosedEventHandler(Others_FormClosed);
			airplaneForm.Show();
			this.Hide();
		}

		private void nhanVienBt_Click(object sender, EventArgs e)
		{
			Staff staffForm = new Staff();
			staffForm.FormClosed += new FormClosedEventHandler(Others_FormClosed);
			staffForm.Show();
			this.Hide();
		}

		private void hoaDonBt_Click(object sender, EventArgs e)
		{
			Invoice invoiceForm = new Invoice();
			invoiceForm.FormClosed += new FormClosedEventHandler(Others_FormClosed);
			invoiceForm.Show();
			this.Hide();
		}

		private void khachHangBt_Click(object sender, EventArgs e)
		{
			Customer customerForm = new Customer();
			customerForm.FormClosed += new FormClosedEventHandler(Others_FormClosed);
			customerForm.Show();
			this.Hide();
		}

		private void chuyenBayBt_Click(object sender, EventArgs e)
		{
			Flight flightForm = new Flight();
			flightForm.FormClosed += new FormClosedEventHandler(Others_FormClosed);
			flightForm.Show();
			this.Hide();
        }

		private void loTrinhBt_Click(object sender, EventArgs e)
		{
			Route routeForm = new Route();
			routeForm.FormClosed += new FormClosedEventHandler(Others_FormClosed);
			routeForm.Show();
			this.Hide();
        }

        private void veLoaiVeBt_Click(object sender, EventArgs e)
        {
            Ticket TicketForm = new Ticket();
            TicketForm.FormClosed += new FormClosedEventHandler(Others_FormClosed);
            TicketForm.Show();
            this.Hide();
        }



        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
