namespace DoAnGiuaKy.GUI
{
	partial class Airplane
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
            this.airplaneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airplaneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airplaneBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkTenHangTxtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hangSanXuatTxtb = new System.Windows.Forms.TextBox();
            this.tenMayBayTxtb = new System.Windows.Forms.TextBox();
            this.maHangHKCmbx = new System.Windows.Forms.ComboBox();
            this.soGheBUSTxtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.soGheECOTxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maMayBayTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tkSoGheECOTxtb = new System.Windows.Forms.TextBox();
            this.tkSoGheBUSTxtb = new System.Windows.Forms.TextBox();
            this.quayLaiBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.themMayBayBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.suaMayBayBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.xoaMayBayBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.luuBt = new DoAnGiuaKy.GUI.NoFocusCueButton();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airplaneID,
            this.airplaneName,
            this.airplaneBrand,
            this.airlineID,
            this.eco,
            this.bus});
            this.dataGridView1.Location = new System.Drawing.Point(16, 394);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // airplaneID
            // 
            this.airplaneID.HeaderText = "Mã máy bay";
            this.airplaneID.MinimumWidth = 6;
            this.airplaneID.Name = "airplaneID";
            this.airplaneID.ReadOnly = true;
            this.airplaneID.Width = 125;
            // 
            // airplaneName
            // 
            this.airplaneName.HeaderText = "Tên Máy Bay";
            this.airplaneName.MinimumWidth = 6;
            this.airplaneName.Name = "airplaneName";
            this.airplaneName.ReadOnly = true;
            this.airplaneName.Width = 125;
            // 
            // airplaneBrand
            // 
            this.airplaneBrand.HeaderText = "Hãng Sản Xuất";
            this.airplaneBrand.MinimumWidth = 6;
            this.airplaneBrand.Name = "airplaneBrand";
            this.airplaneBrand.ReadOnly = true;
            this.airplaneBrand.Width = 120;
            // 
            // airlineID
            // 
            this.airlineID.HeaderText = "Mã Hãng Hàng Không";
            this.airlineID.MinimumWidth = 6;
            this.airlineID.Name = "airlineID";
            this.airlineID.ReadOnly = true;
            this.airlineID.Width = 200;
            // 
            // eco
            // 
            this.eco.HeaderText = "Số Ghế Phổ thông";
            this.eco.MinimumWidth = 6;
            this.eco.Name = "eco";
            this.eco.ReadOnly = true;
            this.eco.Width = 150;
            // 
            // bus
            // 
            this.bus.HeaderText = "Số Ghế Thương Gia";
            this.bus.MinimumWidth = 6;
            this.bus.Name = "bus";
            this.bus.ReadOnly = true;
            this.bus.Width = 150;
            // 
            // tkTenHangTxtb
            // 
            this.tkTenHangTxtb.Location = new System.Drawing.Point(233, 364);
            this.tkTenHangTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tkTenHangTxtb.Name = "tkTenHangTxtb";
            this.tkTenHangTxtb.Size = new System.Drawing.Size(132, 22);
            this.tkTenHangTxtb.TabIndex = 11;
            this.tkTenHangTxtb.TextChanged += new System.EventHandler(this.tkTenHangTxtb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.hangSanXuatTxtb);
            this.groupBox1.Controls.Add(this.tenMayBayTxtb);
            this.groupBox1.Controls.Add(this.maHangHKCmbx);
            this.groupBox1.Controls.Add(this.soGheBUSTxtb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.soGheECOTxtb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maMayBayTxtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1100, 278);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin máy bay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số ghế BUS:";
            // 
            // hangSanXuatTxtb
            // 
            this.hangSanXuatTxtb.Location = new System.Drawing.Point(217, 110);
            this.hangSanXuatTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hangSanXuatTxtb.Name = "hangSanXuatTxtb";
            this.hangSanXuatTxtb.Size = new System.Drawing.Size(868, 30);
            this.hangSanXuatTxtb.TabIndex = 3;
            // 
            // tenMayBayTxtb
            // 
            this.tenMayBayTxtb.Location = new System.Drawing.Point(217, 70);
            this.tenMayBayTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenMayBayTxtb.Name = "tenMayBayTxtb";
            this.tenMayBayTxtb.Size = new System.Drawing.Size(868, 30);
            this.tenMayBayTxtb.TabIndex = 2;
            // 
            // maHangHKCmbx
            // 
            this.maHangHKCmbx.FormattingEnabled = true;
            this.maHangHKCmbx.Location = new System.Drawing.Point(217, 149);
            this.maHangHKCmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maHangHKCmbx.Name = "maHangHKCmbx";
            this.maHangHKCmbx.Size = new System.Drawing.Size(868, 33);
            this.maHangHKCmbx.TabIndex = 4;
            // 
            // soGheBUSTxtb
            // 
            this.soGheBUSTxtb.Location = new System.Drawing.Point(217, 233);
            this.soGheBUSTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soGheBUSTxtb.Name = "soGheBUSTxtb";
            this.soGheBUSTxtb.Size = new System.Drawing.Size(868, 30);
            this.soGheBUSTxtb.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số ghế ECO:";
            // 
            // soGheECOTxtb
            // 
            this.soGheECOTxtb.Location = new System.Drawing.Point(217, 193);
            this.soGheECOTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soGheECOTxtb.Name = "soGheECOTxtb";
            this.soGheECOTxtb.Size = new System.Drawing.Size(868, 30);
            this.soGheECOTxtb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã hãng hàng không:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hãng sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên máy bay:";
            // 
            // maMayBayTxtb
            // 
            this.maMayBayTxtb.Location = new System.Drawing.Point(217, 31);
            this.maMayBayTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maMayBayTxtb.Name = "maMayBayTxtb";
            this.maMayBayTxtb.Size = new System.Drawing.Size(868, 30);
            this.maMayBayTxtb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã máy bay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Máy Bay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nhập tên hãng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(373, 365);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số ghế phổ thông:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(667, 365);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số ghế thương gia:";
            // 
            // tkSoGheECOTxtb
            // 
            this.tkSoGheECOTxtb.Location = new System.Drawing.Point(527, 364);
            this.tkSoGheECOTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tkSoGheECOTxtb.Name = "tkSoGheECOTxtb";
            this.tkSoGheECOTxtb.Size = new System.Drawing.Size(132, 22);
            this.tkSoGheECOTxtb.TabIndex = 12;
            this.tkSoGheECOTxtb.TextChanged += new System.EventHandler(this.tkSoGheECOTxtb_TextChanged);
            // 
            // tkSoGheBUSTxtb
            // 
            this.tkSoGheBUSTxtb.Location = new System.Drawing.Point(824, 364);
            this.tkSoGheBUSTxtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tkSoGheBUSTxtb.Name = "tkSoGheBUSTxtb";
            this.tkSoGheBUSTxtb.Size = new System.Drawing.Size(132, 22);
            this.tkSoGheBUSTxtb.TabIndex = 13;
            this.tkSoGheBUSTxtb.TextChanged += new System.EventHandler(this.tkSoGheBUSTxtb_TextChanged);
            // 
            // quayLaiBt
            // 
            this.quayLaiBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLaiBt.Location = new System.Drawing.Point(1137, 290);
            this.quayLaiBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quayLaiBt.Name = "quayLaiBt";
            this.quayLaiBt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quayLaiBt.Size = new System.Drawing.Size(175, 32);
            this.quayLaiBt.TabIndex = 10;
            this.quayLaiBt.Text = "Quay lại";
            this.quayLaiBt.UseVisualStyleBackColor = true;
            this.quayLaiBt.Click += new System.EventHandler(this.quayLaiBt_Click);
            // 
            // themMayBayBt
            // 
            this.themMayBayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themMayBayBt.Location = new System.Drawing.Point(1137, 94);
            this.themMayBayBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.themMayBayBt.Name = "themMayBayBt";
            this.themMayBayBt.Size = new System.Drawing.Size(175, 32);
            this.themMayBayBt.TabIndex = 7;
            this.themMayBayBt.Text = "Thêm máy bay";
            this.themMayBayBt.UseVisualStyleBackColor = true;
            this.themMayBayBt.Click += new System.EventHandler(this.themMayBayBt_Click);
            // 
            // suaMayBayBt
            // 
            this.suaMayBayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaMayBayBt.Location = new System.Drawing.Point(1137, 192);
            this.suaMayBayBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suaMayBayBt.Name = "suaMayBayBt";
            this.suaMayBayBt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.suaMayBayBt.Size = new System.Drawing.Size(175, 32);
            this.suaMayBayBt.TabIndex = 9;
            this.suaMayBayBt.Text = "Sửa máy bay";
            this.suaMayBayBt.UseVisualStyleBackColor = true;
            this.suaMayBayBt.Click += new System.EventHandler(this.suaMayBayBt_Click);
            // 
            // xoaMayBayBt
            // 
            this.xoaMayBayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaMayBayBt.Location = new System.Drawing.Point(1137, 143);
            this.xoaMayBayBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoaMayBayBt.Name = "xoaMayBayBt";
            this.xoaMayBayBt.Size = new System.Drawing.Size(175, 32);
            this.xoaMayBayBt.TabIndex = 8;
            this.xoaMayBayBt.Text = "Xóa máy bay";
            this.xoaMayBayBt.UseVisualStyleBackColor = true;
            this.xoaMayBayBt.Click += new System.EventHandler(this.xoaMayBayBt_Click);
            // 
            // luuBt
            // 
            this.luuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBt.Location = new System.Drawing.Point(1137, 241);
            this.luuBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.luuBt.Name = "luuBt";
            this.luuBt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.luuBt.Size = new System.Drawing.Size(175, 32);
            this.luuBt.TabIndex = 15;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tìm kiếm:";
            // 
            // Airplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 710);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.luuBt);
            this.Controls.Add(this.quayLaiBt);
            this.Controls.Add(this.tkSoGheBUSTxtb);
            this.Controls.Add(this.tkSoGheECOTxtb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.themMayBayBt);
            this.Controls.Add(this.suaMayBayBt);
            this.Controls.Add(this.xoaMayBayBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tkTenHangTxtb);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Airplane";
            this.Text = "Quản Lý Máy Bay";
            this.Load += new System.EventHandler(this.Airplane_Load);
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
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox maHangHKCmbx;
		private System.Windows.Forms.TextBox tkTenHangTxtb;
		private System.Windows.Forms.TextBox maMayBayTxtb;
		private System.Windows.Forms.TextBox soGheBUSTxtb;
		private System.Windows.Forms.TextBox soGheECOTxtb;
		private System.Windows.Forms.TextBox hangSanXuatTxtb;
		private System.Windows.Forms.TextBox tenMayBayTxtb;
		private System.Windows.Forms.TextBox tkSoGheECOTxtb;
		private System.Windows.Forms.TextBox tkSoGheBUSTxtb;
		private NoFocusCueButton themMayBayBt;
		private NoFocusCueButton xoaMayBayBt;
		private NoFocusCueButton suaMayBayBt;
		private NoFocusCueButton quayLaiBt;
		private NoFocusCueButton luuBt;
		private System.Windows.Forms.DataGridViewTextBoxColumn airplaneID;
		private System.Windows.Forms.DataGridViewTextBoxColumn airplaneName;
		private System.Windows.Forms.DataGridViewTextBoxColumn airplaneBrand;
		private System.Windows.Forms.DataGridViewTextBoxColumn airlineID;
		private System.Windows.Forms.DataGridViewTextBoxColumn eco;
		private System.Windows.Forms.DataGridViewTextBoxColumn bus;
		private System.Windows.Forms.Label label11;
	}
}