namespace DoAnGiuaKy.GUI
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gioitinhCmbx = new System.Windows.Forms.ComboBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.Loadlist = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchHo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchNamsinh = new System.Windows.Forms.TextBox();
            this.txtSearchNamsinh2 = new System.Windows.Forms.TextBox();
            this.txtSearchTen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.danhsachkhachhang = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banvemaybay1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banvemaybay1DataSet = new DoAnGiuaKy.banvemaybay1DataSet();
            this.customerTableAdapter = new DoAnGiuaKy.banvemaybay1DataSetTableAdapters.customerTableAdapter();
            this.airplaneTicketMngmtDBDataSet = new DoAnGiuaKy.AirplaneTicketMngmtDBDataSet();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneTicketMngmtDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(676, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quay lại menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gioitinhCmbx);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.delbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.Loadlist);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtBirth);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // gioitinhCmbx
            // 
            this.gioitinhCmbx.FormattingEnabled = true;
            this.gioitinhCmbx.Location = new System.Drawing.Point(159, 115);
            this.gioitinhCmbx.Name = "gioitinhCmbx";
            this.gioitinhCmbx.Size = new System.Drawing.Size(121, 21);
            this.gioitinhCmbx.TabIndex = 16;
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(642, 148);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(112, 23);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "Sửa";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(642, 118);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(112, 23);
            this.delbtn.TabIndex = 14;
            this.delbtn.Text = "Xóa";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click_1);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(642, 89);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(112, 23);
            this.addbtn.TabIndex = 13;
            this.addbtn.Text = "Thêm";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Loadlist
            // 
            this.Loadlist.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadlist.Location = new System.Drawing.Point(642, 60);
            this.Loadlist.Name = "Loadlist";
            this.Loadlist.Size = new System.Drawing.Size(112, 23);
            this.Loadlist.TabIndex = 3;
            this.Loadlist.Text = "Xem danh sách";
            this.Loadlist.UseVisualStyleBackColor = true;
            this.Loadlist.Click += new System.EventHandler(this.Loadlist_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(159, 204);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(449, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(159, 174);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(449, 20);
            this.txtTel.TabIndex = 11;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(159, 145);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(449, 20);
            this.txtBirth.TabIndex = 10;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(159, 81);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(449, 20);
            this.txtTen.TabIndex = 9;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(159, 51);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(449, 20);
            this.txtHo.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(159, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(449, 20);
            this.txtID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh (dd-mm-yy)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ho";
            // 
            // txtSearchHo
            // 
            this.txtSearchHo.Location = new System.Drawing.Point(36, 276);
            this.txtSearchHo.Name = "txtSearchHo";
            this.txtSearchHo.Size = new System.Drawing.Size(44, 20);
            this.txtSearchHo.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Giới tính";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "customerGender";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox2.Location = new System.Drawing.Point(221, 274);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "customerGender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Năm sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Từ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(518, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Đến";
            // 
            // txtSearchNamsinh
            // 
            this.txtSearchNamsinh.Location = new System.Drawing.Point(408, 275);
            this.txtSearchNamsinh.Name = "txtSearchNamsinh";
            this.txtSearchNamsinh.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNamsinh.TabIndex = 22;
            // 
            // txtSearchNamsinh2
            // 
            this.txtSearchNamsinh2.Location = new System.Drawing.Point(548, 275);
            this.txtSearchNamsinh2.Name = "txtSearchNamsinh2";
            this.txtSearchNamsinh2.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNamsinh2.TabIndex = 23;
            // 
            // txtSearchTen
            // 
            this.txtSearchTen.Location = new System.Drawing.Point(118, 276);
            this.txtSearchTen.Name = "txtSearchTen";
            this.txtSearchTen.Size = new System.Drawing.Size(44, 20);
            this.txtSearchTen.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Tên";
            // 
            // danhsachkhachhang
            // 
            this.danhsachkhachhang.AutoGenerateColumns = false;
            this.danhsachkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerLastDataGridViewTextBoxColumn,
            this.customerFirstDataGridViewTextBoxColumn,
            this.customerGenderDataGridViewTextBoxColumn,
            this.customerBirthDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerTelephoneDataGridViewTextBoxColumn});
            this.danhsachkhachhang.DataSource = this.customerBindingSource1;
            this.danhsachkhachhang.Location = new System.Drawing.Point(12, 302);
            this.danhsachkhachhang.Name = "danhsachkhachhang";
            this.danhsachkhachhang.Size = new System.Drawing.Size(776, 136);
            this.danhsachkhachhang.TabIndex = 26;
            this.danhsachkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachkhachhang_CellClick);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.banvemaybay1DataSetBindingSource;
            // 
            // banvemaybay1DataSetBindingSource
            // 
            this.banvemaybay1DataSetBindingSource.DataSource = this.banvemaybay1DataSet;
            this.banvemaybay1DataSetBindingSource.Position = 0;
            // 
            // banvemaybay1DataSet
            // 
            this.banvemaybay1DataSet.DataSetName = "banvemaybay1DataSet";
            this.banvemaybay1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // airplaneTicketMngmtDBDataSet
            // 
            this.airplaneTicketMngmtDBDataSet.DataSetName = "AirplaneTicketMngmtDBDataSet";
            this.airplaneTicketMngmtDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.airplaneTicketMngmtDBDataSet;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerLastDataGridViewTextBoxColumn
            // 
            this.customerLastDataGridViewTextBoxColumn.DataPropertyName = "customerLast";
            this.customerLastDataGridViewTextBoxColumn.HeaderText = "customerLast";
            this.customerLastDataGridViewTextBoxColumn.Name = "customerLastDataGridViewTextBoxColumn";
            // 
            // customerFirstDataGridViewTextBoxColumn
            // 
            this.customerFirstDataGridViewTextBoxColumn.DataPropertyName = "customerFirst";
            this.customerFirstDataGridViewTextBoxColumn.HeaderText = "customerFirst";
            this.customerFirstDataGridViewTextBoxColumn.Name = "customerFirstDataGridViewTextBoxColumn";
            // 
            // customerGenderDataGridViewTextBoxColumn
            // 
            this.customerGenderDataGridViewTextBoxColumn.DataPropertyName = "customerGender";
            this.customerGenderDataGridViewTextBoxColumn.HeaderText = "customerGender";
            this.customerGenderDataGridViewTextBoxColumn.Name = "customerGenderDataGridViewTextBoxColumn";
            // 
            // customerBirthDataGridViewTextBoxColumn
            // 
            this.customerBirthDataGridViewTextBoxColumn.DataPropertyName = "customerBirth";
            this.customerBirthDataGridViewTextBoxColumn.HeaderText = "customerBirth";
            this.customerBirthDataGridViewTextBoxColumn.Name = "customerBirthDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "customerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "customerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // customerTelephoneDataGridViewTextBoxColumn
            // 
            this.customerTelephoneDataGridViewTextBoxColumn.DataPropertyName = "customerTelephone";
            this.customerTelephoneDataGridViewTextBoxColumn.HeaderText = "customerTelephone";
            this.customerTelephoneDataGridViewTextBoxColumn.Name = "customerTelephoneDataGridViewTextBoxColumn";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.danhsachkhachhang);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSearchTen);
            this.Controls.Add(this.txtSearchNamsinh2);
            this.Controls.Add(this.txtSearchNamsinh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearchHo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneTicketMngmtDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox gioitinhCmbx;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Loadlist;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchHo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchNamsinh;
        private System.Windows.Forms.TextBox txtSearchNamsinh2;
        private System.Windows.Forms.TextBox txtSearchTen;
        private System.Windows.Forms.Label label14;
        private banvemaybay1DataSet banvemaybay1DataSet;
        private banvemaybay1DataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource banvemaybay1DataSetBindingSource;
        private System.Windows.Forms.DataGridView danhsachkhachhang;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private AirplaneTicketMngmtDBDataSet airplaneTicketMngmtDBDataSet;
    }
}