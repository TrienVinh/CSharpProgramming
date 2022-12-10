namespace DoAnGiuaKy.GUI
{
    partial class Ticket
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
            this.ticketmenupanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.TicketTap = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tieuchicbb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btdeleteticket = new System.Windows.Forms.Button();
            this.btaddticket = new System.Windows.Forms.Button();
            this.btfixticket = new System.Windows.Forms.Button();
            this.btLoadticket = new System.Windows.Forms.Button();
            this.tBmlv = new System.Windows.Forms.TextBox();
            this.tBmkh = new System.Windows.Forms.TextBox();
            this.tBmhd = new System.Windows.Forms.TextBox();
            this.tBmcb = new System.Windows.Forms.TextBox();
            this.tBMaVe = new System.Windows.Forms.TextBox();
            this.lbmlv = new System.Windows.Forms.Label();
            this.lbmkh = new System.Windows.Forms.Label();
            this.lbmhd = new System.Windows.Forms.Label();
            this.lbmcb = new System.Windows.Forms.Label();
            this.lbMaVe = new System.Windows.Forms.Label();
            this.typetab = new System.Windows.Forms.TabPage();
            this.btnQuaytt = new System.Windows.Forms.Button();
            this.btnLuutt = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tickettypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waittingroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxoaTickettype = new System.Windows.Forms.Button();
            this.btsuaTickettype = new System.Windows.Forms.Button();
            this.btthemTickettype = new System.Windows.Forms.Button();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbPhongcho = new System.Windows.Forms.TextBox();
            this.tbTenKieu = new System.Windows.Forms.TextBox();
            this.tbMaKieu = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbPhongcho = new System.Windows.Forms.Label();
            this.lbTenkieu = new System.Windows.Forms.Label();
            this.lbmakieu = new System.Windows.Forms.Label();
            this.tickettypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airplaneTicketMngmtDBDataSet = new DoAnGiuaKy.AirplaneTicketMngmtDBDataSet();
            this.tickettypeTableAdapter = new DoAnGiuaKy.AirplaneTicketMngmtDBDataSetTableAdapters.tickettypeTableAdapter();
            this.tBtimIDtype = new System.Windows.Forms.TextBox();
            this.tBtimNametype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketmenupanel.SuspendLayout();
            this.TicketTap.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.typetab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickettypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneTicketMngmtDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketmenupanel
            // 
            this.ticketmenupanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ticketmenupanel.Controls.Add(this.button2);
            this.ticketmenupanel.Location = new System.Drawing.Point(1, 0);
            this.ticketmenupanel.Name = "ticketmenupanel";
            this.ticketmenupanel.Size = new System.Drawing.Size(168, 616);
            this.ticketmenupanel.TabIndex = 0;
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
            // TicketTap
            // 
            this.TicketTap.AccessibleName = "";
            this.TicketTap.Controls.Add(this.tabPage1);
            this.TicketTap.Controls.Add(this.typetab);
            this.TicketTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketTap.Location = new System.Drawing.Point(167, 0);
            this.TicketTap.Name = "TicketTap";
            this.TicketTap.SelectedIndex = 0;
            this.TicketTap.Size = new System.Drawing.Size(776, 620);
            this.TicketTap.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLuu);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.tieuchicbb);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btdeleteticket);
            this.tabPage1.Controls.Add(this.btaddticket);
            this.tabPage1.Controls.Add(this.btfixticket);
            this.tabPage1.Controls.Add(this.btLoadticket);
            this.tabPage1.Controls.Add(this.tBmlv);
            this.tabPage1.Controls.Add(this.tBmkh);
            this.tabPage1.Controls.Add(this.tBmhd);
            this.tabPage1.Controls.Add(this.tBmcb);
            this.tabPage1.Controls.Add(this.tBMaVe);
            this.tabPage1.Controls.Add(this.lbmlv);
            this.tabPage1.Controls.Add(this.lbmkh);
            this.tabPage1.Controls.Add(this.lbmhd);
            this.tabPage1.Controls.Add(this.lbmcb);
            this.tabPage1.Controls.Add(this.lbMaVe);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ticket";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(480, 188);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(610, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 23);
            this.textBox5.TabIndex = 27;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(470, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 23);
            this.textBox4.TabIndex = 26;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(328, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 23);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tieuchicbb
            // 
            this.tieuchicbb.FormattingEnabled = true;
            this.tieuchicbb.Location = new System.Drawing.Point(42, 197);
            this.tieuchicbb.Name = "tieuchicbb";
            this.tieuchicbb.Size = new System.Drawing.Size(121, 24);
            this.tieuchicbb.TabIndex = 22;
            this.tieuchicbb.Text = "Tiêu chí chọn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketid,
            this.customerid,
            this.flightid,
            this.invoiceid,
            this.typeid});
            this.dataGridView1.Location = new System.Drawing.Point(42, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 264);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ticketid
            // 
            this.ticketid.HeaderText = "TicketID";
            this.ticketid.Name = "ticketid";
            // 
            // customerid
            // 
            this.customerid.HeaderText = "CustomerID";
            this.customerid.Name = "customerid";
            // 
            // flightid
            // 
            this.flightid.HeaderText = "FlightID";
            this.flightid.Name = "flightid";
            // 
            // invoiceid
            // 
            this.invoiceid.HeaderText = "InvoiceID";
            this.invoiceid.Name = "invoiceid";
            // 
            // typeid
            // 
            this.typeid.HeaderText = "TicketTypeID";
            this.typeid.Name = "typeid";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(648, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Xuất excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdeleteticket
            // 
            this.btdeleteticket.Location = new System.Drawing.Point(648, 143);
            this.btdeleteticket.Name = "btdeleteticket";
            this.btdeleteticket.Size = new System.Drawing.Size(75, 33);
            this.btdeleteticket.TabIndex = 18;
            this.btdeleteticket.Text = "Xoá";
            this.btdeleteticket.UseVisualStyleBackColor = true;
            this.btdeleteticket.Click += new System.EventHandler(this.btdeleteticket_Click);
            // 
            // btaddticket
            // 
            this.btaddticket.Location = new System.Drawing.Point(425, 143);
            this.btaddticket.Name = "btaddticket";
            this.btaddticket.Size = new System.Drawing.Size(75, 33);
            this.btaddticket.TabIndex = 17;
            this.btaddticket.Text = "Thêm";
            this.btaddticket.UseVisualStyleBackColor = true;
            this.btaddticket.Click += new System.EventHandler(this.btaddticket_Click);
            // 
            // btfixticket
            // 
            this.btfixticket.Location = new System.Drawing.Point(537, 143);
            this.btfixticket.Name = "btfixticket";
            this.btfixticket.Size = new System.Drawing.Size(75, 33);
            this.btfixticket.TabIndex = 16;
            this.btfixticket.Text = "Sửa";
            this.btfixticket.UseVisualStyleBackColor = true;
            this.btfixticket.Click += new System.EventHandler(this.btfixticket_Click);
            // 
            // btLoadticket
            // 
            this.btLoadticket.Location = new System.Drawing.Point(598, 188);
            this.btLoadticket.Name = "btLoadticket";
            this.btLoadticket.Size = new System.Drawing.Size(75, 33);
            this.btLoadticket.TabIndex = 15;
            this.btLoadticket.Text = "Quay lại";
            this.btLoadticket.UseVisualStyleBackColor = true;
            this.btLoadticket.Click += new System.EventHandler(this.btLoadticket_Click);
            // 
            // tBmlv
            // 
            this.tBmlv.Location = new System.Drawing.Point(537, 103);
            this.tBmlv.Name = "tBmlv";
            this.tBmlv.Size = new System.Drawing.Size(170, 23);
            this.tBmlv.TabIndex = 10;
            // 
            // tBmkh
            // 
            this.tBmkh.Location = new System.Drawing.Point(537, 48);
            this.tBmkh.Name = "tBmkh";
            this.tBmkh.Size = new System.Drawing.Size(170, 23);
            this.tBmkh.TabIndex = 9;
            // 
            // tBmhd
            // 
            this.tBmhd.Location = new System.Drawing.Point(184, 151);
            this.tBmhd.Name = "tBmhd";
            this.tBmhd.Size = new System.Drawing.Size(170, 23);
            this.tBmhd.TabIndex = 8;
            // 
            // tBmcb
            // 
            this.tBmcb.Location = new System.Drawing.Point(184, 101);
            this.tBmcb.Name = "tBmcb";
            this.tBmcb.Size = new System.Drawing.Size(170, 23);
            this.tBmcb.TabIndex = 7;
            // 
            // tBMaVe
            // 
            this.tBMaVe.Location = new System.Drawing.Point(184, 54);
            this.tBMaVe.Name = "tBMaVe";
            this.tBMaVe.Size = new System.Drawing.Size(170, 23);
            this.tBMaVe.TabIndex = 6;
            // 
            // lbmlv
            // 
            this.lbmlv.AutoSize = true;
            this.lbmlv.Location = new System.Drawing.Point(428, 101);
            this.lbmlv.Name = "lbmlv";
            this.lbmlv.Size = new System.Drawing.Size(72, 17);
            this.lbmlv.TabIndex = 5;
            this.lbmlv.Text = "Mã loại vé";
            // 
            // lbmkh
            // 
            this.lbmkh.AutoSize = true;
            this.lbmkh.Location = new System.Drawing.Point(425, 54);
            this.lbmkh.Name = "lbmkh";
            this.lbmkh.Size = new System.Drawing.Size(105, 17);
            this.lbmkh.TabIndex = 4;
            this.lbmkh.Text = "Mã khách hàng";
            // 
            // lbmhd
            // 
            this.lbmhd.AutoSize = true;
            this.lbmhd.Location = new System.Drawing.Point(69, 151);
            this.lbmhd.Name = "lbmhd";
            this.lbmhd.Size = new System.Drawing.Size(83, 17);
            this.lbmhd.TabIndex = 3;
            this.lbmhd.Text = "Mã hoá đơn";
            // 
            // lbmcb
            // 
            this.lbmcb.AutoSize = true;
            this.lbmcb.Location = new System.Drawing.Point(69, 101);
            this.lbmcb.Name = "lbmcb";
            this.lbmcb.Size = new System.Drawing.Size(104, 17);
            this.lbmcb.TabIndex = 2;
            this.lbmcb.Text = "Mã chuyến bay";
            // 
            // lbMaVe
            // 
            this.lbMaVe.AutoSize = true;
            this.lbMaVe.Location = new System.Drawing.Point(69, 54);
            this.lbMaVe.Name = "lbMaVe";
            this.lbMaVe.Size = new System.Drawing.Size(46, 17);
            this.lbMaVe.TabIndex = 1;
            this.lbMaVe.Text = "Mã vé";
            // 
            // typetab
            // 
            this.typetab.Controls.Add(this.label3);
            this.typetab.Controls.Add(this.label2);
            this.typetab.Controls.Add(this.label1);
            this.typetab.Controls.Add(this.tBtimNametype);
            this.typetab.Controls.Add(this.tBtimIDtype);
            this.typetab.Controls.Add(this.btnQuaytt);
            this.typetab.Controls.Add(this.btnLuutt);
            this.typetab.Controls.Add(this.dataGridView2);
            this.typetab.Controls.Add(this.btxoaTickettype);
            this.typetab.Controls.Add(this.btsuaTickettype);
            this.typetab.Controls.Add(this.btthemTickettype);
            this.typetab.Controls.Add(this.tbGia);
            this.typetab.Controls.Add(this.tbPhongcho);
            this.typetab.Controls.Add(this.tbTenKieu);
            this.typetab.Controls.Add(this.tbMaKieu);
            this.typetab.Controls.Add(this.lbGia);
            this.typetab.Controls.Add(this.lbPhongcho);
            this.typetab.Controls.Add(this.lbTenkieu);
            this.typetab.Controls.Add(this.lbmakieu);
            this.typetab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetab.Location = new System.Drawing.Point(4, 25);
            this.typetab.Name = "typetab";
            this.typetab.Padding = new System.Windows.Forms.Padding(3);
            this.typetab.Size = new System.Drawing.Size(768, 591);
            this.typetab.TabIndex = 1;
            this.typetab.Text = "TicketType";
            this.typetab.UseVisualStyleBackColor = true;
            // 
            // btnQuaytt
            // 
            this.btnQuaytt.Location = new System.Drawing.Point(614, 153);
            this.btnQuaytt.Name = "btnQuaytt";
            this.btnQuaytt.Size = new System.Drawing.Size(85, 28);
            this.btnQuaytt.TabIndex = 24;
            this.btnQuaytt.Text = "Quay lại";
            this.btnQuaytt.UseVisualStyleBackColor = true;
            this.btnQuaytt.Click += new System.EventHandler(this.btnQuaytt_Click);
            // 
            // btnLuutt
            // 
            this.btnLuutt.Location = new System.Drawing.Point(614, 96);
            this.btnLuutt.Name = "btnLuutt";
            this.btnLuutt.Size = new System.Drawing.Size(85, 28);
            this.btnLuutt.TabIndex = 23;
            this.btnLuutt.Text = "Lưu";
            this.btnLuutt.UseVisualStyleBackColor = true;
            this.btnLuutt.Click += new System.EventHandler(this.btnLuutt_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickettypeid,
            this.typename,
            this.waittingroom,
            this.price});
            this.dataGridView2.Location = new System.Drawing.Point(132, 256);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(596, 297);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tickettypeid
            // 
            this.tickettypeid.HeaderText = "ID";
            this.tickettypeid.Name = "tickettypeid";
            // 
            // typename
            // 
            this.typename.HeaderText = "Name";
            this.typename.Name = "typename";
            this.typename.Width = 150;
            // 
            // waittingroom
            // 
            this.waittingroom.HeaderText = "Waitting Room";
            this.waittingroom.Name = "waittingroom";
            this.waittingroom.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // btxoaTickettype
            // 
            this.btxoaTickettype.Location = new System.Drawing.Point(499, 181);
            this.btxoaTickettype.Name = "btxoaTickettype";
            this.btxoaTickettype.Size = new System.Drawing.Size(85, 31);
            this.btxoaTickettype.TabIndex = 20;
            this.btxoaTickettype.Text = "Xoá";
            this.btxoaTickettype.UseVisualStyleBackColor = true;
            this.btxoaTickettype.Click += new System.EventHandler(this.btxoaTickettype_Click);
            // 
            // btsuaTickettype
            // 
            this.btsuaTickettype.Location = new System.Drawing.Point(499, 125);
            this.btsuaTickettype.Name = "btsuaTickettype";
            this.btsuaTickettype.Size = new System.Drawing.Size(85, 29);
            this.btsuaTickettype.TabIndex = 19;
            this.btsuaTickettype.Text = "Sửa";
            this.btsuaTickettype.UseVisualStyleBackColor = true;
            this.btsuaTickettype.Click += new System.EventHandler(this.btsuaTickettype_Click);
            // 
            // btthemTickettype
            // 
            this.btthemTickettype.Location = new System.Drawing.Point(499, 63);
            this.btthemTickettype.Name = "btthemTickettype";
            this.btthemTickettype.Size = new System.Drawing.Size(85, 28);
            this.btthemTickettype.TabIndex = 18;
            this.btthemTickettype.Text = "Thêm";
            this.btthemTickettype.UseVisualStyleBackColor = true;
            this.btthemTickettype.Click += new System.EventHandler(this.btthemTickettype_Click);
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(237, 205);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(170, 26);
            this.tbGia.TabIndex = 11;
            // 
            // tbPhongcho
            // 
            this.tbPhongcho.Location = new System.Drawing.Point(237, 155);
            this.tbPhongcho.Name = "tbPhongcho";
            this.tbPhongcho.Size = new System.Drawing.Size(170, 26);
            this.tbPhongcho.TabIndex = 10;
            // 
            // tbTenKieu
            // 
            this.tbTenKieu.Location = new System.Drawing.Point(237, 101);
            this.tbTenKieu.Name = "tbTenKieu";
            this.tbTenKieu.Size = new System.Drawing.Size(170, 26);
            this.tbTenKieu.TabIndex = 9;
            // 
            // tbMaKieu
            // 
            this.tbMaKieu.Location = new System.Drawing.Point(237, 51);
            this.tbMaKieu.Name = "tbMaKieu";
            this.tbMaKieu.Size = new System.Drawing.Size(170, 26);
            this.tbMaKieu.TabIndex = 8;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(128, 208);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(34, 20);
            this.lbGia.TabIndex = 5;
            this.lbGia.Text = "Giá";
            // 
            // lbPhongcho
            // 
            this.lbPhongcho.AutoSize = true;
            this.lbPhongcho.Location = new System.Drawing.Point(128, 158);
            this.lbPhongcho.Name = "lbPhongcho";
            this.lbPhongcho.Size = new System.Drawing.Size(85, 20);
            this.lbPhongcho.TabIndex = 4;
            this.lbPhongcho.Text = "Phòng chờ";
            // 
            // lbTenkieu
            // 
            this.lbTenkieu.AutoSize = true;
            this.lbTenkieu.Location = new System.Drawing.Point(128, 104);
            this.lbTenkieu.Name = "lbTenkieu";
            this.lbTenkieu.Size = new System.Drawing.Size(69, 20);
            this.lbTenkieu.TabIndex = 3;
            this.lbTenkieu.Text = "Tên kiểu";
            // 
            // lbmakieu
            // 
            this.lbmakieu.AutoSize = true;
            this.lbmakieu.Location = new System.Drawing.Point(128, 54);
            this.lbmakieu.Name = "lbmakieu";
            this.lbmakieu.Size = new System.Drawing.Size(64, 20);
            this.lbmakieu.TabIndex = 2;
            this.lbmakieu.Text = "Mã kiểu";
            // 
            // tickettypeBindingSource
            // 
            this.tickettypeBindingSource.DataMember = "tickettype";
            this.tickettypeBindingSource.DataSource = this.airplaneTicketMngmtDBDataSet;
            // 
            // airplaneTicketMngmtDBDataSet
            // 
            this.airplaneTicketMngmtDBDataSet.DataSetName = "AirplaneTicketMngmtDBDataSet";
            this.airplaneTicketMngmtDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tickettypeTableAdapter
            // 
            this.tickettypeTableAdapter.ClearBeforeFill = true;
            // 
            // tBtimIDtype
            // 
            this.tBtimIDtype.Location = new System.Drawing.Point(6, 296);
            this.tBtimIDtype.Name = "tBtimIDtype";
            this.tBtimIDtype.Size = new System.Drawing.Size(111, 26);
            this.tBtimIDtype.TabIndex = 25;
            this.tBtimIDtype.TextChanged += new System.EventHandler(this.tBtimIDtype_TextChanged);
            // 
            // tBtimNametype
            // 
            this.tBtimNametype.Location = new System.Drawing.Point(6, 364);
            this.tBtimNametype.Name = "tBtimNametype";
            this.tBtimNametype.Size = new System.Drawing.Size(111, 26);
            this.tBtimNametype.TabIndex = 26;
            this.tBtimNametype.TextChanged += new System.EventHandler(this.tBtimNamtype_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên loại vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã loại vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tìm kiếm";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.ticketmenupanel);
            this.Controls.Add(this.TicketTap);
            this.Name = "Ticket";
            this.Text = "Vé và loại vé";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ticketmenupanel.ResumeLayout(false);
            this.TicketTap.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.typetab.ResumeLayout(false);
            this.typetab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickettypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneTicketMngmtDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ticketmenupanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage typetab;
        private System.Windows.Forms.TabControl TicketTap;
        private System.Windows.Forms.TextBox tBmlv;
        private System.Windows.Forms.TextBox tBmkh;
        private System.Windows.Forms.TextBox tBmhd;
        private System.Windows.Forms.TextBox tBmcb;
        private System.Windows.Forms.TextBox tBMaVe;
        private System.Windows.Forms.Label lbmlv;
        private System.Windows.Forms.Label lbmkh;
        private System.Windows.Forms.Label lbmhd;
        private System.Windows.Forms.Label lbmcb;
        private System.Windows.Forms.Label lbMaVe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btdeleteticket;
        private System.Windows.Forms.Button btaddticket;
        private System.Windows.Forms.Button btfixticket;
        private System.Windows.Forms.Button btLoadticket;
        private System.Windows.Forms.Button btxoaTickettype;
        private System.Windows.Forms.Button btsuaTickettype;
        private System.Windows.Forms.Button btthemTickettype;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbPhongcho;
        private System.Windows.Forms.TextBox tbTenKieu;
        private System.Windows.Forms.TextBox tbMaKieu;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbPhongcho;
        private System.Windows.Forms.Label lbTenkieu;
        private System.Windows.Forms.Label lbmakieu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox tieuchicbb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightid;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeid;
        private System.Windows.Forms.Button btnLuu;
        private DoAnGiuaKy.AirplaneTicketMngmtDBDataSet airplaneTicketMngmtDBDataSet;
        private System.Windows.Forms.BindingSource tickettypeBindingSource;
        private DoAnGiuaKy.AirplaneTicketMngmtDBDataSetTableAdapters.tickettypeTableAdapter tickettypeTableAdapter;
        private System.Windows.Forms.Button btnLuutt;
        private System.Windows.Forms.Button btnQuaytt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickettypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn waittingroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBtimNametype;
        private System.Windows.Forms.TextBox tBtimIDtype;
    }
}