namespace DoAnGiuaKy.GUI
{
	partial class Staff
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
            this.staffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieuChiCmbx = new System.Windows.Forms.ComboBox();
            this.timKiemTxtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuChbx = new System.Windows.Forms.CheckBox();
            this.namChbx = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dienThoaiTxtb = new System.Windows.Forms.TextBox();
            this.diaChiTxtb = new System.Windows.Forms.TextBox();
            this.ngaySinhTxtb = new System.Windows.Forms.TextBox();
            this.tenNhanVienTxtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hoNhanVienTxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maNhanVienTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timKiemNuChbx = new System.Windows.Forms.CheckBox();
            this.timKiemNamChbx = new System.Windows.Forms.CheckBox();
            this.quayLaiBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.lamRongBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.suaNhanVienBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.xoaNhanVienBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.themNhanVienBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.luuBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffID,
            this.staffLast,
            this.staffFirst,
            this.gender,
            this.birth,
            this.address,
            this.phone});
            this.dataGridView1.Location = new System.Drawing.Point(16, 448);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // staffID
            // 
            this.staffID.HeaderText = "Mã nhân viên";
            this.staffID.MinimumWidth = 6;
            this.staffID.Name = "staffID";
            this.staffID.ReadOnly = true;
            this.staffID.Width = 125;
            // 
            // staffLast
            // 
            this.staffLast.HeaderText = "Họ Nhân Viên";
            this.staffLast.MinimumWidth = 6;
            this.staffLast.Name = "staffLast";
            this.staffLast.ReadOnly = true;
            this.staffLast.Width = 125;
            // 
            // staffFirst
            // 
            this.staffFirst.HeaderText = "Tên Nhân Viên";
            this.staffFirst.MinimumWidth = 6;
            this.staffFirst.Name = "staffFirst";
            this.staffFirst.ReadOnly = true;
            this.staffFirst.Width = 150;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới Tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // birth
            // 
            this.birth.HeaderText = "Ngày Sinh";
            this.birth.MinimumWidth = 6;
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            this.birth.Width = 125;
            // 
            // address
            // 
            this.address.HeaderText = "Địa Chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 200;
            // 
            // phone
            // 
            this.phone.HeaderText = "Điện Thoại";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // tieuChiCmbx
            // 
            this.tieuChiCmbx.FormattingEnabled = true;
            this.tieuChiCmbx.Location = new System.Drawing.Point(113, 420);
            this.tieuChiCmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tieuChiCmbx.Name = "tieuChiCmbx";
            this.tieuChiCmbx.Size = new System.Drawing.Size(125, 24);
            this.tieuChiCmbx.TabIndex = 1;
            this.tieuChiCmbx.Text = "--Chọn tiêu chí";
            this.tieuChiCmbx.SelectedIndexChanged += new System.EventHandler(this.tieuChiCmbx_SelectedIndexChanged);
            // 
            // timKiemTxtb
            // 
            this.timKiemTxtb.Location = new System.Drawing.Point(424, 420);
            this.timKiemTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timKiemTxtb.Name = "timKiemTxtb";
            this.timKiemTxtb.Size = new System.Drawing.Size(132, 22);
            this.timKiemTxtb.TabIndex = 2;
            this.timKiemTxtb.TextChanged += new System.EventHandler(this.timKiemTxtb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuChbx);
            this.groupBox1.Controls.Add(this.namChbx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dienThoaiTxtb);
            this.groupBox1.Controls.Add(this.diaChiTxtb);
            this.groupBox1.Controls.Add(this.ngaySinhTxtb);
            this.groupBox1.Controls.Add(this.tenNhanVienTxtb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hoNhanVienTxtb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maNhanVienTxtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 313);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên:";
            // 
            // nuChbx
            // 
            this.nuChbx.AutoSize = true;
            this.nuChbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuChbx.Location = new System.Drawing.Point(261, 151);
            this.nuChbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuChbx.Name = "nuChbx";
            this.nuChbx.Size = new System.Drawing.Size(59, 29);
            this.nuChbx.TabIndex = 17;
            this.nuChbx.Text = "Nữ";
            this.nuChbx.UseVisualStyleBackColor = true;
            this.nuChbx.CheckedChanged += new System.EventHandler(this.nuChbx_CheckedChanged);
            // 
            // namChbx
            // 
            this.namChbx.AutoSize = true;
            this.namChbx.Checked = true;
            this.namChbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.namChbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namChbx.Location = new System.Drawing.Point(157, 151);
            this.namChbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namChbx.Name = "namChbx";
            this.namChbx.Size = new System.Drawing.Size(75, 29);
            this.namChbx.TabIndex = 16;
            this.namChbx.Text = "Nam";
            this.namChbx.UseVisualStyleBackColor = true;
            this.namChbx.CheckedChanged += new System.EventHandler(this.namChbx_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Địa chỉ:";
            // 
            // dienThoaiTxtb
            // 
            this.dienThoaiTxtb.Location = new System.Drawing.Point(157, 267);
            this.dienThoaiTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dienThoaiTxtb.Name = "dienThoaiTxtb";
            this.dienThoaiTxtb.Size = new System.Drawing.Size(868, 30);
            this.dienThoaiTxtb.TabIndex = 13;
            // 
            // diaChiTxtb
            // 
            this.diaChiTxtb.Location = new System.Drawing.Point(157, 228);
            this.diaChiTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diaChiTxtb.Name = "diaChiTxtb";
            this.diaChiTxtb.Size = new System.Drawing.Size(868, 30);
            this.diaChiTxtb.TabIndex = 12;
            // 
            // ngaySinhTxtb
            // 
            this.ngaySinhTxtb.Location = new System.Drawing.Point(157, 188);
            this.ngaySinhTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngaySinhTxtb.Name = "ngaySinhTxtb";
            this.ngaySinhTxtb.Size = new System.Drawing.Size(868, 30);
            this.ngaySinhTxtb.TabIndex = 11;
            // 
            // tenNhanVienTxtb
            // 
            this.tenNhanVienTxtb.Location = new System.Drawing.Point(157, 110);
            this.tenNhanVienTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenNhanVienTxtb.Name = "tenNhanVienTxtb";
            this.tenNhanVienTxtb.Size = new System.Drawing.Size(868, 30);
            this.tenNhanVienTxtb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày sinh:";
            // 
            // hoNhanVienTxtb
            // 
            this.hoNhanVienTxtb.Location = new System.Drawing.Point(157, 70);
            this.hoNhanVienTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoNhanVienTxtb.Name = "hoNhanVienTxtb";
            this.hoNhanVienTxtb.Size = new System.Drawing.Size(868, 30);
            this.hoNhanVienTxtb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ nhân viên:";
            // 
            // maNhanVienTxtb
            // 
            this.maNhanVienTxtb.Location = new System.Drawing.Point(157, 31);
            this.maNhanVienTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maNhanVienTxtb.Name = "maNhanVienTxtb";
            this.maNhanVienTxtb.Size = new System.Drawing.Size(868, 30);
            this.maNhanVienTxtb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // timKiemNuChbx
            // 
            this.timKiemNuChbx.AutoSize = true;
            this.timKiemNuChbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemNuChbx.Location = new System.Drawing.Point(352, 417);
            this.timKiemNuChbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timKiemNuChbx.Name = "timKiemNuChbx";
            this.timKiemNuChbx.Size = new System.Drawing.Size(59, 29);
            this.timKiemNuChbx.TabIndex = 19;
            this.timKiemNuChbx.Text = "Nữ";
            this.timKiemNuChbx.UseVisualStyleBackColor = true;
            this.timKiemNuChbx.CheckedChanged += new System.EventHandler(this.timKiemNuChbx_CheckedChanged);
            // 
            // timKiemNamChbx
            // 
            this.timKiemNamChbx.AutoSize = true;
            this.timKiemNamChbx.Checked = true;
            this.timKiemNamChbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timKiemNamChbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemNamChbx.Location = new System.Drawing.Point(248, 417);
            this.timKiemNamChbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timKiemNamChbx.Name = "timKiemNamChbx";
            this.timKiemNamChbx.Size = new System.Drawing.Size(75, 29);
            this.timKiemNamChbx.TabIndex = 18;
            this.timKiemNamChbx.Text = "Nam";
            this.timKiemNamChbx.UseVisualStyleBackColor = true;
            this.timKiemNamChbx.CheckedChanged += new System.EventHandler(this.timKiemNamChbx_CheckedChanged);
            // 
            // quayLaiBt
            // 
            this.quayLaiBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLaiBt.Location = new System.Drawing.Point(1059, 322);
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
            this.lamRongBt.Location = new System.Drawing.Point(1059, 273);
            this.lamRongBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lamRongBt.Name = "lamRongBt";
            this.lamRongBt.Size = new System.Drawing.Size(175, 32);
            this.lamRongBt.TabIndex = 11;
            this.lamRongBt.Text = "Làm rỗng";
            this.lamRongBt.UseVisualStyleBackColor = true;
            this.lamRongBt.Click += new System.EventHandler(this.lamRongBt_Click);
            // 
            // suaNhanVienBt
            // 
            this.suaNhanVienBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaNhanVienBt.Location = new System.Drawing.Point(1059, 175);
            this.suaNhanVienBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suaNhanVienBt.Name = "suaNhanVienBt";
            this.suaNhanVienBt.Size = new System.Drawing.Size(175, 32);
            this.suaNhanVienBt.TabIndex = 10;
            this.suaNhanVienBt.Text = "Sửa nhân viên";
            this.suaNhanVienBt.UseVisualStyleBackColor = true;
            this.suaNhanVienBt.Click += new System.EventHandler(this.suaNhanVienBt_Click);
            // 
            // xoaNhanVienBt
            // 
            this.xoaNhanVienBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaNhanVienBt.Location = new System.Drawing.Point(1059, 126);
            this.xoaNhanVienBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoaNhanVienBt.Name = "xoaNhanVienBt";
            this.xoaNhanVienBt.Size = new System.Drawing.Size(175, 32);
            this.xoaNhanVienBt.TabIndex = 9;
            this.xoaNhanVienBt.Text = "Xóa nhân viên";
            this.xoaNhanVienBt.UseVisualStyleBackColor = true;
            this.xoaNhanVienBt.Click += new System.EventHandler(this.xoaNhanVienBt_Click);
            // 
            // themNhanVienBt
            // 
            this.themNhanVienBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themNhanVienBt.Location = new System.Drawing.Point(1059, 76);
            this.themNhanVienBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.themNhanVienBt.Name = "themNhanVienBt";
            this.themNhanVienBt.Size = new System.Drawing.Size(175, 32);
            this.themNhanVienBt.TabIndex = 8;
            this.themNhanVienBt.Text = "Thêm nhân viên";
            this.themNhanVienBt.UseVisualStyleBackColor = true;
            this.themNhanVienBt.Click += new System.EventHandler(this.themNhanVienBt_Click);
            // 
            // luuBt
            // 
            this.luuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBt.Location = new System.Drawing.Point(1059, 224);
            this.luuBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(175, 32);
            this.luuBt.TabIndex = 7;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tìm kiếm:";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 720);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timKiemNuChbx);
            this.Controls.Add(this.quayLaiBt);
            this.Controls.Add(this.timKiemNamChbx);
            this.Controls.Add(this.lamRongBt);
            this.Controls.Add(this.suaNhanVienBt);
            this.Controls.Add(this.xoaNhanVienBt);
            this.Controls.Add(this.themNhanVienBt);
            this.Controls.Add(this.luuBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timKiemTxtb);
            this.Controls.Add(this.tieuChiCmbx);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Staff";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Staff_Load);
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox tieuChiCmbx;
		private System.Windows.Forms.TextBox timKiemTxtb;
		private System.Windows.Forms.TextBox maNhanVienTxtb;
		private System.Windows.Forms.TextBox tenNhanVienTxtb;
		private System.Windows.Forms.TextBox hoNhanVienTxtb;
		private System.Windows.Forms.TextBox dienThoaiTxtb;
		private System.Windows.Forms.TextBox diaChiTxtb;
		private System.Windows.Forms.TextBox ngaySinhTxtb;
		private System.Windows.Forms.CheckBox nuChbx;
		private System.Windows.Forms.CheckBox namChbx;
		private System.Windows.Forms.CheckBox timKiemNuChbx;
		private System.Windows.Forms.CheckBox timKiemNamChbx;
		private NoFocusCueButton luuBt;
		private NoFocusCueButton themNhanVienBt;
		private NoFocusCueButton xoaNhanVienBt;
		private NoFocusCueButton suaNhanVienBt;
		private NoFocusCueButton lamRongBt;
		private NoFocusCueButton quayLaiBt;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffLast;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffFirst;
		private System.Windows.Forms.DataGridViewTextBoxColumn gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn birth;
		private System.Windows.Forms.DataGridViewTextBoxColumn address;
		private System.Windows.Forms.DataGridViewTextBoxColumn phone;
		private System.Windows.Forms.Label label9;
	}
}