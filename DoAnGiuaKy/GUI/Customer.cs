using DoAnGiuaKy.BUS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoAnGiuaKy.DTO;
using DoAnGiuaKy.DAO;

namespace DoAnGiuaKy.GUI
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }


        private void loadDataGridView(List<CustomerDTO> customerlist)
        {
            danhsachkhachhang.Rows.Clear();

            for (int i = 0; i < customerlist.Count; i++)
            {
                string CustomerId = customerlist[i].CustomerId;
                string CustomerLast = customerlist[i].CustomerLast;
                string CustomerFirst = customerlist[i].CustomerFirst;
                string CustomerGender = customerlist[i].CustomerGender;
                int CustomerBirthday = customerlist[i].CustomerBirthday;
                string CustomerTelephone = customerlist[i].CustomerTelephone;
                string CustomerAddress = customerlist[i].CustomerAddress;


                danhsachkhachhang.Rows.Add(CustomerId, CustomerLast, CustomerFirst, CustomerGender,CustomerBirthday,CustomerTelephone,CustomerAddress);
            }
        }

        
        private void LoadCustomerCmbx()
        {
            string[] gioitinh = { "Nam", "Nữ" };
            gioitinhCmbx.Items.AddRange(gioitinh);
            gioitinhCmbx.SelectedIndex = -1;
        }

        public void setTextBoxstate(bool state)
        {
            txtID.Enabled=state;
            txtHo.Enabled=state;
            txtTen.Enabled=state;
            gioitinhCmbx.Enabled=state;
            txtBirth.Enabled=state;
            txtTel.Enabled=state;
            txtAddress.Enabled=state;
        }

        public void cleartextbox()
        {
            txtID.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            gioitinhCmbx.SelectedIndex = 0;
            txtBirth.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
        }


        private void Customer_Load(object sender, EventArgs e)
        {
            danhsachkhachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhsachkhachhang.MultiSelect = false;

            LoadCustomerCmbx();
            loadDataGridView(new CustomerBUS().customerList);

            setTextBoxstate(false);
            Loadlist.Enabled=false;

        }




        private void danhsachkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = danhsachkhachhang.CurrentRow.Cells[0].Value.ToString();
            
            CustomerDTO customer = new CustomerBUS().Get(id);

            txtID.Text = customer.CustomerId;
            txtHo.Text = customer.CustomerLast;
            txtTen.Text = customer.CustomerFirst;
            gioitinhCmbx.SelectedValue = customer.CustomerGender;
            txtBirth.Text = customer.CustomerBirthday.ToString();
            txtAddress.Text = customer.CustomerAddress;
            txtTel.Text = customer.CustomerTelephone;
        }

        

        
        private void addbtn_Click(object sender, EventArgs e)
        {
            
            setTextBoxstate(true);
            cleartextbox();
            txtID.Focus();
            Loadlist.Enabled=true;
        }
        private void delbtn_Click_1(object sender, EventArgs e)
                {
                    string id = danhsachkhachhang.CurrentRow.Cells[0].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn thật sự muốn xoá", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        new CustomerBUS().Delete(id);
                        MessageBox.Show($"Successfully Deleted {id}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataGridView(new CustomerBUS().customerList);
                
                    }
                }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            setTextBoxstate(true);
            txtID.Enabled = false;
            Loadlist.Enabled = true;
        }

        private void Loadlist_Click(object sender, EventArgs e)
        {
            string customerId = txtID.Text.Trim();
            string customerLast = txtHo.Text.Trim();
            string customerFirst = txtTen.Text.Trim();
            string customerGender = gioitinhCmbx.SelectedValue.ToString().Trim();
            int customerBirthday = Convert.ToInt32(txtBirth.Text.Trim());
            string customerTelephone = txtTel.Text.Trim();
            string customerAddress = txtAddress.Text.Trim();

            CustomerDTO customer = new CustomerDTO(customerId, customerLast, customerFirst, customerGender, customerBirthday, customerTelephone, customerAddress);
            CustomerBUS bus = new CustomerBUS();

            if (bus.Get(customerId) == null)
            {
                bus.Insert(customer);
                MessageBox.Show($"Successfully Inserted Airplane {customerId}!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bus.Update(customer);
                MessageBox.Show($"Successfully Updated Airplane {customerId}!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cleartextbox();
            setTextBoxstate(false);
            loadDataGridView(new CustomerBUS().customerList);
            Loadlist.Enabled = false;
        }

        public void search()
        {
            danhsachkhachhang.Rows.Clear();

            CustomerBUS bus = new CustomerBUS();
            var result = bus.Search(txtSearchHo.Text, txtSearchTen.Text,gioitinhCmbx.SelectedValue.ToString(),txtSearchNamsinh.Text);
            loadDataGridView(result);
        }

        private void txtSearchHo_Textchanged(object sender, EventArgs e)
        {
            search();
        }
        private void txtSearchTen_Textchanged(object sender, EventArgs e)
        {
            search();
        }
        private void gioitinhCmbx_SelectedIndexChanged(Object sender, EventArgs e)
        {
            search();
        }
        private void txtSearchNamsinh_Textchanged(object sender, EventArgs e)
        {
            search();
        }
        

        
    }
}
