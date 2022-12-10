namespace DoAnGiuaKy.GUI
{
    partial class Airport
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
            this.tieuChiCmbx = new System.Windows.Forms.ComboBox();
            this.timKiemTxtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tenThanhPhoTxtb = new System.Windows.Forms.TextBox();
            this.tenSanBayTxtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maSanBayTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lamRongBt = new System.Windows.Forms.Button();
            this.suaSanBayBt = new System.Windows.Forms.Button();
            this.xoaSanBayBt = new System.Windows.Forms.Button();
            this.themSanBayBt = new System.Windows.Forms.Button();
            this.luuBt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.airportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airportID,
            this.airportName,
            this.cityName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tieuChiCmbx
            // 
            this.tieuChiCmbx.FormattingEnabled = true;
            this.tieuChiCmbx.Location = new System.Drawing.Point(89, 208);
            this.tieuChiCmbx.Name = "tieuChiCmbx";
            this.tieuChiCmbx.Size = new System.Drawing.Size(95, 21);
            this.tieuChiCmbx.TabIndex = 1;
            this.tieuChiCmbx.Text = "--Chọn tiêu chí";
            this.tieuChiCmbx.SelectedIndexChanged += new System.EventHandler(this.tieuChiCmbx_SelectedIndexChanged);
            // 
            // timKiemTxtb
            // 
            this.timKiemTxtb.Location = new System.Drawing.Point(190, 209);
            this.timKiemTxtb.Name = "timKiemTxtb";
            this.timKiemTxtb.Size = new System.Drawing.Size(100, 20);
            this.timKiemTxtb.TabIndex = 2;
            this.timKiemTxtb.TextChanged += new System.EventHandler(this.timKiemTxtb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tenThanhPhoTxtb);
            this.groupBox1.Controls.Add(this.tenSanBayTxtb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maSanBayTxtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sân bay:";
            // 
            // tenThanhPhoTxtb
            // 
            this.tenThanhPhoTxtb.Location = new System.Drawing.Point(118, 89);
            this.tenThanhPhoTxtb.Name = "tenThanhPhoTxtb";
            this.tenThanhPhoTxtb.Size = new System.Drawing.Size(652, 26);
            this.tenThanhPhoTxtb.TabIndex = 9;
            // 
            // tenSanBayTxtb
            // 
            this.tenSanBayTxtb.Location = new System.Drawing.Point(118, 57);
            this.tenSanBayTxtb.Name = "tenSanBayTxtb";
            this.tenSanBayTxtb.Size = new System.Drawing.Size(652, 26);
            this.tenSanBayTxtb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên thành phố:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sân bay:";
            // 
            // maSanBayTxtb
            // 
            this.maSanBayTxtb.Location = new System.Drawing.Point(118, 25);
            this.maSanBayTxtb.Name = "maSanBayTxtb";
            this.maSanBayTxtb.Size = new System.Drawing.Size(652, 26);
            this.maSanBayTxtb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sân bay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Sân Bay";
            // 
            // lamRongBt
            // 
            this.lamRongBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamRongBt.Location = new System.Drawing.Point(651, 204);
            this.lamRongBt.Name = "lamRongBt";
            this.lamRongBt.Size = new System.Drawing.Size(131, 26);
            this.lamRongBt.TabIndex = 11;
            this.lamRongBt.Text = "Làm rỗng";
            this.lamRongBt.UseVisualStyleBackColor = true;
            this.lamRongBt.Click += new System.EventHandler(this.lamRongBt_Click);
            // 
            // suaSanBayBt
            // 
            this.suaSanBayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaSanBayBt.Location = new System.Drawing.Point(794, 164);
            this.suaSanBayBt.Name = "suaSanBayBt";
            this.suaSanBayBt.Size = new System.Drawing.Size(131, 26);
            this.suaSanBayBt.TabIndex = 10;
            this.suaSanBayBt.Text = "Sửa sân bay";
            this.suaSanBayBt.UseVisualStyleBackColor = true;
            this.suaSanBayBt.Click += new System.EventHandler(this.suaSanBayBt_Click);
            // 
            // xoaSanBayBt
            // 
            this.xoaSanBayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaSanBayBt.Location = new System.Drawing.Point(794, 124);
            this.xoaSanBayBt.Name = "xoaSanBayBt";
            this.xoaSanBayBt.Size = new System.Drawing.Size(131, 26);
            this.xoaSanBayBt.TabIndex = 9;
            this.xoaSanBayBt.Text = "Xóa sân bay";
            this.xoaSanBayBt.UseVisualStyleBackColor = true;
            this.xoaSanBayBt.Click += new System.EventHandler(this.xoaSanBayBt_Click);
            // 
            // themSanBayBt
            // 
            this.themSanBayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themSanBayBt.Location = new System.Drawing.Point(794, 84);
            this.themSanBayBt.Name = "themSanBayBt";
            this.themSanBayBt.Size = new System.Drawing.Size(131, 26);
            this.themSanBayBt.TabIndex = 8;
            this.themSanBayBt.Text = "Thêm sân bay";
            this.themSanBayBt.UseVisualStyleBackColor = true;
            this.themSanBayBt.Click += new System.EventHandler(this.themSanBayBt_Click);
            // 
            // luuBt
            // 
            this.luuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBt.Location = new System.Drawing.Point(794, 204);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(131, 26);
            this.luuBt.TabIndex = 7;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tìm kiếm:";
            // 
            // airportID
            // 
            this.airportID.HeaderText = "Mã Sân Bay";
            this.airportID.Name = "airportID";
            this.airportID.ReadOnly = true;
            this.airportID.Width = 200;
            // 
            // airportName
            // 
            this.airportName.HeaderText = "Tên Sân Bay";
            this.airportName.Name = "airportName";
            this.airportName.ReadOnly = true;
            this.airportName.Width = 200;
            // 
            // cityName
            // 
            this.cityName.HeaderText = "Tên Thành Phố";
            this.cityName.Name = "cityName";
            this.cityName.ReadOnly = true;
            this.cityName.Width = 200;
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 456);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lamRongBt);
            this.Controls.Add(this.suaSanBayBt);
            this.Controls.Add(this.xoaSanBayBt);
            this.Controls.Add(this.themSanBayBt);
            this.Controls.Add(this.luuBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timKiemTxtb);
            this.Controls.Add(this.tieuChiCmbx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Airport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sân Bay";
            this.Load += new System.EventHandler(this.Airport_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tieuChiCmbx;
        private System.Windows.Forms.TextBox timKiemTxtb;
        private System.Windows.Forms.TextBox maSanBayTxtb;
        private System.Windows.Forms.TextBox tenThanhPhoTxtb;
        private System.Windows.Forms.TextBox tenSanBayTxtb;
        private System.Windows.Forms.Button luuBt;
        private System.Windows.Forms.Button themSanBayBt;
        private System.Windows.Forms.Button xoaSanBayBt;
        private System.Windows.Forms.Button suaSanBayBt;
        private System.Windows.Forms.Button lamRongBt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityName;
    }
}