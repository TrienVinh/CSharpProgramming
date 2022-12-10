namespace DoAnGiuaKy.GUI
{
	partial class Invoice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieuChiCmbx = new System.Windows.Forms.ComboBox();
            this.timKiemTxtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.khachHangCmbx = new System.Windows.Forms.ComboBox();
            this.nhanVienCmbx = new System.Windows.Forms.ComboBox();
            this.thoiGianTxtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tongTienTxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maHoaDonTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quayLaiBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.lamRongBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.suaHoaDonBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.xoaHoaDonBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.luuBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.xemChiTietBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceID,
            this.staffID,
            this.customerID,
            this.total,
            this.datetime});
            this.dataGridView1.Location = new System.Drawing.Point(16, 364);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // invoiceID
            // 
            this.invoiceID.HeaderText = "Mã hóa đơn";
            this.invoiceID.MinimumWidth = 6;
            this.invoiceID.Name = "invoiceID";
            this.invoiceID.ReadOnly = true;
            this.invoiceID.Width = 120;
            // 
            // staffID
            // 
            this.staffID.HeaderText = "Nhân Viên Lập";
            this.staffID.MinimumWidth = 6;
            this.staffID.Name = "staffID";
            this.staffID.ReadOnly = true;
            this.staffID.Width = 120;
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Khách Hàng";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Width = 120;
            // 
            // total
            // 
            this.total.HeaderText = "Tổng Tiền";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Thời Gian Lập";
            this.datetime.MinimumWidth = 6;
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            this.datetime.Width = 200;
            // 
            // tieuChiCmbx
            // 
            this.tieuChiCmbx.FormattingEnabled = true;
            this.tieuChiCmbx.Location = new System.Drawing.Point(105, 334);
            this.tieuChiCmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tieuChiCmbx.Name = "tieuChiCmbx";
            this.tieuChiCmbx.Size = new System.Drawing.Size(197, 24);
            this.tieuChiCmbx.TabIndex = 1;
            this.tieuChiCmbx.Text = "--Chọn tiêu chí";
            this.tieuChiCmbx.SelectedIndexChanged += new System.EventHandler(this.tieuChiCmbx_SelectedIndexChanged);
            // 
            // timKiemTxtb
            // 
            this.timKiemTxtb.Location = new System.Drawing.Point(311, 334);
            this.timKiemTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timKiemTxtb.Name = "timKiemTxtb";
            this.timKiemTxtb.Size = new System.Drawing.Size(132, 22);
            this.timKiemTxtb.TabIndex = 2;
            this.timKiemTxtb.TextChanged += new System.EventHandler(this.timKiemTxtb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.khachHangCmbx);
            this.groupBox1.Controls.Add(this.nhanVienCmbx);
            this.groupBox1.Controls.Add(this.thoiGianTxtb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tongTienTxtb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maHoaDonTxtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn:";
            // 
            // khachHangCmbx
            // 
            this.khachHangCmbx.FormattingEnabled = true;
            this.khachHangCmbx.Location = new System.Drawing.Point(157, 112);
            this.khachHangCmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khachHangCmbx.Name = "khachHangCmbx";
            this.khachHangCmbx.Size = new System.Drawing.Size(868, 33);
            this.khachHangCmbx.TabIndex = 11;
            // 
            // nhanVienCmbx
            // 
            this.nhanVienCmbx.FormattingEnabled = true;
            this.nhanVienCmbx.Location = new System.Drawing.Point(157, 70);
            this.nhanVienCmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nhanVienCmbx.Name = "nhanVienCmbx";
            this.nhanVienCmbx.Size = new System.Drawing.Size(868, 33);
            this.nhanVienCmbx.TabIndex = 10;
            // 
            // thoiGianTxtb
            // 
            this.thoiGianTxtb.Location = new System.Drawing.Point(157, 193);
            this.thoiGianTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thoiGianTxtb.Name = "thoiGianTxtb";
            this.thoiGianTxtb.Size = new System.Drawing.Size(868, 30);
            this.thoiGianTxtb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thời gian:";
            // 
            // tongTienTxtb
            // 
            this.tongTienTxtb.Location = new System.Drawing.Point(157, 154);
            this.tongTienTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tongTienTxtb.Name = "tongTienTxtb";
            this.tongTienTxtb.Size = new System.Drawing.Size(868, 30);
            this.tongTienTxtb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên lập:";
            // 
            // maHoaDonTxtb
            // 
            this.maHoaDonTxtb.Location = new System.Drawing.Point(157, 31);
            this.maHoaDonTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maHoaDonTxtb.Name = "maHoaDonTxtb";
            this.maHoaDonTxtb.Size = new System.Drawing.Size(868, 30);
            this.maHoaDonTxtb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Hóa Đơn";
            // 
            // quayLaiBt
            // 
            this.quayLaiBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLaiBt.Location = new System.Drawing.Point(1059, 250);
            this.quayLaiBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quayLaiBt.Name = "quayLaiBt";
            this.quayLaiBt.Size = new System.Drawing.Size(175, 32);
            this.quayLaiBt.TabIndex = 12;
            this.quayLaiBt.Text = "Quay lại";
            this.quayLaiBt.UseVisualStyleBackColor = true;
            this.quayLaiBt.Click += new System.EventHandler(this.quayLaiBt_Click);
            // 
            // lamRongBt
            // 
            this.lamRongBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamRongBt.Location = new System.Drawing.Point(1059, 210);
            this.lamRongBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lamRongBt.Name = "lamRongBt";
            this.lamRongBt.Size = new System.Drawing.Size(175, 32);
            this.lamRongBt.TabIndex = 10;
            this.lamRongBt.Text = "Làm rỗng thông tin";
            this.lamRongBt.UseVisualStyleBackColor = true;
            this.lamRongBt.Click += new System.EventHandler(this.lamRongBt_Click);
            // 
            // suaHoaDonBt
            // 
            this.suaHoaDonBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaHoaDonBt.Location = new System.Drawing.Point(1059, 112);
            this.suaHoaDonBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suaHoaDonBt.Name = "suaHoaDonBt";
            this.suaHoaDonBt.Size = new System.Drawing.Size(175, 32);
            this.suaHoaDonBt.TabIndex = 9;
            this.suaHoaDonBt.Text = "Sửa hóa đơn";
            this.suaHoaDonBt.UseVisualStyleBackColor = true;
            this.suaHoaDonBt.Click += new System.EventHandler(this.suaHoaDonBt_Click);
            // 
            // xoaHoaDonBt
            // 
            this.xoaHoaDonBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaHoaDonBt.Location = new System.Drawing.Point(1059, 63);
            this.xoaHoaDonBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoaHoaDonBt.Name = "xoaHoaDonBt";
            this.xoaHoaDonBt.Size = new System.Drawing.Size(175, 32);
            this.xoaHoaDonBt.TabIndex = 8;
            this.xoaHoaDonBt.Text = "Xóa hóa đơn";
            this.xoaHoaDonBt.UseVisualStyleBackColor = true;
            this.xoaHoaDonBt.Click += new System.EventHandler(this.xoaHoaDonBt_Click);
            // 
            // luuBt
            // 
            this.luuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBt.Location = new System.Drawing.Point(1059, 161);
            this.luuBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(175, 32);
            this.luuBt.TabIndex = 7;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // xemChiTietBt
            // 
            this.xemChiTietBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemChiTietBt.Location = new System.Drawing.Point(451, 334);
            this.xemChiTietBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xemChiTietBt.Name = "xemChiTietBt";
            this.xemChiTietBt.Size = new System.Drawing.Size(120, 25);
            this.xemChiTietBt.TabIndex = 4;
            this.xemChiTietBt.Text = "Xem chi tiết";
            this.xemChiTietBt.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tìm kiếm:";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quayLaiBt);
            this.Controls.Add(this.lamRongBt);
            this.Controls.Add(this.suaHoaDonBt);
            this.Controls.Add(this.xoaHoaDonBt);
            this.Controls.Add(this.luuBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xemChiTietBt);
            this.Controls.Add(this.timKiemTxtb);
            this.Controls.Add(this.tieuChiCmbx);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Invoice";
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox timKiemTxtb;
		private System.Windows.Forms.TextBox maHoaDonTxtb;
		private System.Windows.Forms.TextBox thoiGianTxtb;
		private System.Windows.Forms.TextBox tongTienTxtb;
		private System.Windows.Forms.ComboBox tieuChiCmbx;
		private System.Windows.Forms.ComboBox nhanVienCmbx;
		private System.Windows.Forms.ComboBox khachHangCmbx;
		private NoFocusCueButton xemChiTietBt;
		private NoFocusCueButton luuBt;
		private NoFocusCueButton xoaHoaDonBt;
		private NoFocusCueButton suaHoaDonBt;
		private NoFocusCueButton lamRongBt;
		private NoFocusCueButton quayLaiBt;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceID;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
		private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
		private System.Windows.Forms.Label label7;
	}
}

