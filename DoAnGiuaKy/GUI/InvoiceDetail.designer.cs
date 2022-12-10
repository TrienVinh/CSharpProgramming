namespace DoAnGiuaKy.GUI
{
    partial class InvoiceDetail
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
            this.InvoiDetailmenupanel = new System.Windows.Forms.Panel();
            this.lbnhapCTHD = new System.Windows.Forms.Label();
            this.tbTKCTHD = new System.Windows.Forms.TextBox();
            this.lbtkCTHD = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbMaHDCTHD = new System.Windows.Forms.Label();
            this.lbMaKieuCTHD = new System.Windows.Forms.Label();
            this.lbSLCTHD = new System.Windows.Forms.Label();
            this.lbTongCTHD = new System.Windows.Forms.Label();
            this.tBMaHDCTHD = new System.Windows.Forms.TextBox();
            this.tBMaKieuCTHD = new System.Windows.Forms.TextBox();
            this.tBSLCTHD = new System.Windows.Forms.TextBox();
            this.tBTongCTHD = new System.Windows.Forms.TextBox();
            this.btaddCTHD = new System.Windows.Forms.Button();
            this.btFixCTHD = new System.Windows.Forms.Button();
            this.btDeleteCTHD = new System.Windows.Forms.Button();
            this.btloadCTHD = new System.Windows.Forms.Button();
            this.dataGridViewIVDetail = new System.Windows.Forms.DataGridView();
            this.tBtkMaKieu = new System.Windows.Forms.TextBox();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InvoiDetailmenupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiDetailmenupanel
            // 
            this.InvoiDetailmenupanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.InvoiDetailmenupanel.Controls.Add(this.label2);
            this.InvoiDetailmenupanel.Controls.Add(this.label1);
            this.InvoiDetailmenupanel.Controls.Add(this.tBtkMaKieu);
            this.InvoiDetailmenupanel.Controls.Add(this.lbnhapCTHD);
            this.InvoiDetailmenupanel.Controls.Add(this.tbTKCTHD);
            this.InvoiDetailmenupanel.Controls.Add(this.lbtkCTHD);
            this.InvoiDetailmenupanel.Controls.Add(this.button2);
            this.InvoiDetailmenupanel.Location = new System.Drawing.Point(1, 0);
            this.InvoiDetailmenupanel.Name = "InvoiDetailmenupanel";
            this.InvoiDetailmenupanel.Size = new System.Drawing.Size(168, 570);
            this.InvoiDetailmenupanel.TabIndex = 1;
            // 
            // lbnhapCTHD
            // 
            this.lbnhapCTHD.AutoSize = true;
            this.lbnhapCTHD.BackColor = System.Drawing.Color.Yellow;
            this.lbnhapCTHD.Location = new System.Drawing.Point(8, 125);
            this.lbnhapCTHD.Name = "lbnhapCTHD";
            this.lbnhapCTHD.Size = new System.Drawing.Size(49, 13);
            this.lbnhapCTHD.TabIndex = 3;
            this.lbnhapCTHD.Text = "Tìm kiếm";
            // 
            // tbTKCTHD
            // 
            this.tbTKCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTKCTHD.Location = new System.Drawing.Point(11, 160);
            this.tbTKCTHD.Name = "tbTKCTHD";
            this.tbTKCTHD.Size = new System.Drawing.Size(131, 20);
            this.tbTKCTHD.TabIndex = 2;
            this.tbTKCTHD.TextChanged += new System.EventHandler(this.tbTKCTHD_TextChanged);
            // 
            // lbtkCTHD
            // 
            this.lbtkCTHD.BackColor = System.Drawing.Color.Yellow;
            this.lbtkCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtkCTHD.Location = new System.Drawing.Point(0, 79);
            this.lbtkCTHD.Name = "lbtkCTHD";
            this.lbtkCTHD.Padding = new System.Windows.Forms.Padding(30, 9, 0, 0);
            this.lbtkCTHD.Size = new System.Drawing.Size(168, 33);
            this.lbtkCTHD.TabIndex = 1;
            this.lbtkCTHD.Text = "Tìm kiếm CTHD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbMaHDCTHD
            // 
            this.lbMaHDCTHD.AutoSize = true;
            this.lbMaHDCTHD.Location = new System.Drawing.Point(205, 45);
            this.lbMaHDCTHD.Name = "lbMaHDCTHD";
            this.lbMaHDCTHD.Size = new System.Drawing.Size(65, 13);
            this.lbMaHDCTHD.TabIndex = 4;
            this.lbMaHDCTHD.Text = "Mã hoá đơn";
            // 
            // lbMaKieuCTHD
            // 
            this.lbMaKieuCTHD.AutoSize = true;
            this.lbMaKieuCTHD.Location = new System.Drawing.Point(205, 81);
            this.lbMaKieuCTHD.Name = "lbMaKieuCTHD";
            this.lbMaKieuCTHD.Size = new System.Drawing.Size(45, 13);
            this.lbMaKieuCTHD.TabIndex = 5;
            this.lbMaKieuCTHD.Text = "Mã kiểu";
            // 
            // lbSLCTHD
            // 
            this.lbSLCTHD.AutoSize = true;
            this.lbSLCTHD.Location = new System.Drawing.Point(205, 119);
            this.lbSLCTHD.Name = "lbSLCTHD";
            this.lbSLCTHD.Size = new System.Drawing.Size(49, 13);
            this.lbSLCTHD.TabIndex = 6;
            this.lbSLCTHD.Text = "Số lượng";
            // 
            // lbTongCTHD
            // 
            this.lbTongCTHD.AutoSize = true;
            this.lbTongCTHD.Location = new System.Drawing.Point(205, 160);
            this.lbTongCTHD.Name = "lbTongCTHD";
            this.lbTongCTHD.Size = new System.Drawing.Size(32, 13);
            this.lbTongCTHD.TabIndex = 7;
            this.lbTongCTHD.Text = "Tổng";
            // 
            // tBMaHDCTHD
            // 
            this.tBMaHDCTHD.Location = new System.Drawing.Point(276, 42);
            this.tBMaHDCTHD.Name = "tBMaHDCTHD";
            this.tBMaHDCTHD.Size = new System.Drawing.Size(170, 20);
            this.tBMaHDCTHD.TabIndex = 8;
            // 
            // tBMaKieuCTHD
            // 
            this.tBMaKieuCTHD.Location = new System.Drawing.Point(276, 78);
            this.tBMaKieuCTHD.Name = "tBMaKieuCTHD";
            this.tBMaKieuCTHD.Size = new System.Drawing.Size(170, 20);
            this.tBMaKieuCTHD.TabIndex = 9;
            // 
            // tBSLCTHD
            // 
            this.tBSLCTHD.Location = new System.Drawing.Point(276, 116);
            this.tBSLCTHD.Name = "tBSLCTHD";
            this.tBSLCTHD.Size = new System.Drawing.Size(170, 20);
            this.tBSLCTHD.TabIndex = 10;
            // 
            // tBTongCTHD
            // 
            this.tBTongCTHD.Location = new System.Drawing.Point(276, 157);
            this.tBTongCTHD.Name = "tBTongCTHD";
            this.tBTongCTHD.Size = new System.Drawing.Size(170, 20);
            this.tBTongCTHD.TabIndex = 11;
            // 
            // btaddCTHD
            // 
            this.btaddCTHD.Location = new System.Drawing.Point(474, 56);
            this.btaddCTHD.Name = "btaddCTHD";
            this.btaddCTHD.Size = new System.Drawing.Size(75, 23);
            this.btaddCTHD.TabIndex = 13;
            this.btaddCTHD.Text = "Thêm";
            this.btaddCTHD.UseVisualStyleBackColor = true;
            this.btaddCTHD.Click += new System.EventHandler(this.btaddCTHD_Click);
            // 
            // btFixCTHD
            // 
            this.btFixCTHD.Location = new System.Drawing.Point(474, 99);
            this.btFixCTHD.Name = "btFixCTHD";
            this.btFixCTHD.Size = new System.Drawing.Size(75, 23);
            this.btFixCTHD.TabIndex = 14;
            this.btFixCTHD.Text = "Sửa";
            this.btFixCTHD.UseVisualStyleBackColor = true;
            this.btFixCTHD.Click += new System.EventHandler(this.btFixCTHD_Click);
            // 
            // btDeleteCTHD
            // 
            this.btDeleteCTHD.Location = new System.Drawing.Point(474, 140);
            this.btDeleteCTHD.Name = "btDeleteCTHD";
            this.btDeleteCTHD.Size = new System.Drawing.Size(75, 23);
            this.btDeleteCTHD.TabIndex = 15;
            this.btDeleteCTHD.Text = "Xoá";
            this.btDeleteCTHD.UseVisualStyleBackColor = true;
            this.btDeleteCTHD.Click += new System.EventHandler(this.btDeleteCTHD_Click);
            // 
            // btloadCTHD
            // 
            this.btloadCTHD.Location = new System.Drawing.Point(578, 75);
            this.btloadCTHD.Name = "btloadCTHD";
            this.btloadCTHD.Size = new System.Drawing.Size(75, 23);
            this.btloadCTHD.TabIndex = 16;
            this.btloadCTHD.Text = "Lưu";
            this.btloadCTHD.UseVisualStyleBackColor = true;
            this.btloadCTHD.Click += new System.EventHandler(this.btloadCTHD_Click);
            // 
            // dataGridViewIVDetail
            // 
            this.dataGridViewIVDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIVDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKieu,
            this.SL,
            this.Tong});
            this.dataGridViewIVDetail.Location = new System.Drawing.Point(185, 198);
            this.dataGridViewIVDetail.Name = "dataGridViewIVDetail";
            this.dataGridViewIVDetail.Size = new System.Drawing.Size(468, 336);
            this.dataGridViewIVDetail.TabIndex = 17;
            this.dataGridViewIVDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIVDetail_CellClick);
            // 
            // tBtkMaKieu
            // 
            this.tBtkMaKieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtkMaKieu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tBtkMaKieu.Location = new System.Drawing.Point(11, 208);
            this.tBtkMaKieu.Name = "tBtkMaKieu";
            this.tBtkMaKieu.Size = new System.Drawing.Size(131, 20);
            this.tBtkMaKieu.TabIndex = 10;
            this.tBtkMaKieu.TextChanged += new System.EventHandler(this.tBtkMaKieu_TextChanged);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(578, 120);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 23);
            this.btnQuaylai.TabIndex = 18;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.Name = "MaHD";
            // 
            // MaKieu
            // 
            this.MaKieu.HeaderText = "Mã Kiểu Vé";
            this.MaKieu.Name = "MaKieu";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // Tong
            // 
            this.Tong.HeaderText = "Tổng";
            this.Tong.Name = "Tong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã hoá đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã loại vé";
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 562);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.dataGridViewIVDetail);
            this.Controls.Add(this.btloadCTHD);
            this.Controls.Add(this.btDeleteCTHD);
            this.Controls.Add(this.btFixCTHD);
            this.Controls.Add(this.btaddCTHD);
            this.Controls.Add(this.tBTongCTHD);
            this.Controls.Add(this.tBSLCTHD);
            this.Controls.Add(this.tBMaKieuCTHD);
            this.Controls.Add(this.tBMaHDCTHD);
            this.Controls.Add(this.lbTongCTHD);
            this.Controls.Add(this.lbSLCTHD);
            this.Controls.Add(this.lbMaKieuCTHD);
            this.Controls.Add(this.lbMaHDCTHD);
            this.Controls.Add(this.InvoiDetailmenupanel);
            this.Name = "InvoiceDetail";
            this.Text = "InvoiceDetail";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            this.InvoiDetailmenupanel.ResumeLayout(false);
            this.InvoiDetailmenupanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel InvoiDetailmenupanel;
        private System.Windows.Forms.Label lbnhapCTHD;
        private System.Windows.Forms.TextBox tbTKCTHD;
        private System.Windows.Forms.Label lbtkCTHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbMaHDCTHD;
        private System.Windows.Forms.Label lbMaKieuCTHD;
        private System.Windows.Forms.Label lbSLCTHD;
        private System.Windows.Forms.Label lbTongCTHD;
        private System.Windows.Forms.TextBox tBMaHDCTHD;
        private System.Windows.Forms.TextBox tBMaKieuCTHD;
        private System.Windows.Forms.TextBox tBSLCTHD;
        private System.Windows.Forms.TextBox tBTongCTHD;
        private System.Windows.Forms.Button btaddCTHD;
        private System.Windows.Forms.Button btFixCTHD;
        private System.Windows.Forms.Button btDeleteCTHD;
        private System.Windows.Forms.Button btloadCTHD;
        private System.Windows.Forms.DataGridView dataGridViewIVDetail;
        private System.Windows.Forms.TextBox tBtkMaKieu;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}