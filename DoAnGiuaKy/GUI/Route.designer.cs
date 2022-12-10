namespace DoAnGiuaKy.GUI
{
    partial class Route
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Suabt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.Luubt = new System.Windows.Forms.Button();
            this.txtDiemden = new System.Windows.Forms.TextBox();
            this.txtDiemxuatphat = new System.Windows.Forms.TextBox();
            this.txtMalotrinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TieuchiCmBx = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.banvemaybay1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banvemaybay1DataSet = new DoAnGiuaKy.banvemaybay1DataSet();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new DoAnGiuaKy.banvemaybay1DataSetTableAdapters.routeTableAdapter();
            this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý lộ trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Suabt);
            this.groupBox1.Controls.Add(this.Xoabt);
            this.groupBox1.Controls.Add(this.Thembt);
            this.groupBox1.Controls.Add(this.Luubt);
            this.groupBox1.Controls.Add(this.txtDiemden);
            this.groupBox1.Controls.Add(this.txtDiemxuatphat);
            this.groupBox1.Controls.Add(this.txtMalotrinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lộ trình";
            // 
            // Suabt
            // 
            this.Suabt.Location = new System.Drawing.Point(618, 107);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(97, 23);
            this.Suabt.TabIndex = 8;
            this.Suabt.Text = "Sửa";
            this.Suabt.UseVisualStyleBackColor = true;
            this.Suabt.Click += new System.EventHandler(this.Suabt_Click);
            // 
            // Xoabt
            // 
            this.Xoabt.Location = new System.Drawing.Point(618, 78);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(97, 23);
            this.Xoabt.TabIndex = 7;
            this.Xoabt.Text = "Xóa";
            this.Xoabt.UseVisualStyleBackColor = true;
            this.Xoabt.Click += new System.EventHandler(this.Xoabt_Click);
            // 
            // Thembt
            // 
            this.Thembt.Location = new System.Drawing.Point(618, 49);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(97, 23);
            this.Thembt.TabIndex = 6;
            this.Thembt.Text = "Thêm ";
            this.Thembt.UseVisualStyleBackColor = true;
            this.Thembt.Click += new System.EventHandler(this.Thembt_Click);
            // 
            // Luubt
            // 
            this.Luubt.Location = new System.Drawing.Point(618, 20);
            this.Luubt.Name = "Luubt";
            this.Luubt.Size = new System.Drawing.Size(97, 23);
            this.Luubt.TabIndex = 3;
            this.Luubt.Text = "Lưu";
            this.Luubt.UseVisualStyleBackColor = true;
            this.Luubt.Click += new System.EventHandler(this.Luubt_Click);
            // 
            // txtDiemden
            // 
            this.txtDiemden.Location = new System.Drawing.Point(105, 87);
            this.txtDiemden.Name = "txtDiemden";
            this.txtDiemden.Size = new System.Drawing.Size(349, 20);
            this.txtDiemden.TabIndex = 5;
            // 
            // txtDiemxuatphat
            // 
            this.txtDiemxuatphat.Location = new System.Drawing.Point(105, 54);
            this.txtDiemxuatphat.Name = "txtDiemxuatphat";
            this.txtDiemxuatphat.Size = new System.Drawing.Size(349, 20);
            this.txtDiemxuatphat.TabIndex = 4;
            // 
            // txtMalotrinh
            // 
            this.txtMalotrinh.Location = new System.Drawing.Point(105, 17);
            this.txtMalotrinh.Name = "txtMalotrinh";
            this.txtMalotrinh.Size = new System.Drawing.Size(349, 20);
            this.txtMalotrinh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm xuất phát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lộ trình";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quay lại menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tìm kiếm";
            // 
            // TieuchiCmBx
            // 
            this.TieuchiCmBx.FormattingEnabled = true;
            this.TieuchiCmBx.Location = new System.Drawing.Point(74, 198);
            this.TieuchiCmBx.Name = "TieuchiCmBx";
            this.TieuchiCmBx.Size = new System.Drawing.Size(97, 21);
            this.TieuchiCmBx.TabIndex = 10;
            this.TieuchiCmBx.Text = "Không";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(346, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeIDDataGridViewTextBoxColumn,
            this.departureLocationDataGridViewTextBoxColumn,
            this.arrivalLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 199);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "route";
            this.routeBindingSource.DataSource = this.banvemaybay1DataSetBindingSource;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "routeID";
            this.routeIDDataGridViewTextBoxColumn.HeaderText = "routeID";
            this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            // 
            // departureLocationDataGridViewTextBoxColumn
            // 
            this.departureLocationDataGridViewTextBoxColumn.DataPropertyName = "departureLocation";
            this.departureLocationDataGridViewTextBoxColumn.HeaderText = "departureLocation";
            this.departureLocationDataGridViewTextBoxColumn.Name = "departureLocationDataGridViewTextBoxColumn";
            // 
            // arrivalLocationDataGridViewTextBoxColumn
            // 
            this.arrivalLocationDataGridViewTextBoxColumn.DataPropertyName = "arrivalLocation";
            this.arrivalLocationDataGridViewTextBoxColumn.HeaderText = "arrivalLocation";
            this.arrivalLocationDataGridViewTextBoxColumn.Name = "arrivalLocationDataGridViewTextBoxColumn";
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TieuchiCmBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Route";
            this.Text = "Route";
            this.Load += new System.EventHandler(this.Route_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banvemaybay1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.Button Luubt;
        private System.Windows.Forms.TextBox txtDiemden;
        private System.Windows.Forms.TextBox txtDiemxuatphat;
        private System.Windows.Forms.TextBox txtMalotrinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TieuchiCmBx;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource banvemaybay1DataSetBindingSource;
        private banvemaybay1DataSet banvemaybay1DataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private banvemaybay1DataSetTableAdapters.routeTableAdapter routeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalLocationDataGridViewTextBoxColumn;
    }
}