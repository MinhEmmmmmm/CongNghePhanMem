namespace QLshopmohinh
{
    partial class FrmTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAcout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBill = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnToltalmoney = new System.Windows.Forms.Button();
            this.txtToltalmoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectPhonenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNameOfItem = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSelectItem = new System.Windows.Forms.NumericUpDown();
            this.dgvListItemToTransaction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItemToTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAcout,
            this.tsmiStaffs,
            this.tsmiClients,
            this.tsmiInventory,
            this.tsmiContact,
            this.tsmiBill});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(972, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAcout
            // 
            this.tsmiAcout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiAcout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInformation,
            this.tsmiLogout});
            this.tsmiAcout.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAcout.Image")));
            this.tsmiAcout.Name = "tsmiAcout";
            this.tsmiAcout.Size = new System.Drawing.Size(105, 24);
            this.tsmiAcout.Text = "Tài khoản";
            // 
            // tsmiInformation
            // 
            this.tsmiInformation.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInformation.Image")));
            this.tsmiInformation.Name = "tsmiInformation";
            this.tsmiInformation.Size = new System.Drawing.Size(224, 26);
            this.tsmiInformation.Text = "Thông tin tài khoản";
            this.tsmiInformation.Click += new System.EventHandler(this.tsmiInformation_Click);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLogout.Image")));
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(224, 26);
            this.tsmiLogout.Text = "Đăng xuất";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiStaffs
            // 
            this.tsmiStaffs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStaffs.Image")));
            this.tsmiStaffs.Name = "tsmiStaffs";
            this.tsmiStaffs.Size = new System.Drawing.Size(160, 24);
            this.tsmiStaffs.Text = "Quản lý nhân viên";
            this.tsmiStaffs.Click += new System.EventHandler(this.tsmiStaffs_Click);
            // 
            // tsmiClients
            // 
            this.tsmiClients.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClients.Image")));
            this.tsmiClients.Name = "tsmiClients";
            this.tsmiClients.Size = new System.Drawing.Size(172, 24);
            this.tsmiClients.Text = "Quản lý khách hàng";
            this.tsmiClients.Click += new System.EventHandler(this.tsmiClients_Click);
            // 
            // tsmiInventory
            // 
            this.tsmiInventory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInventory.Image")));
            this.tsmiInventory.Name = "tsmiInventory";
            this.tsmiInventory.Size = new System.Drawing.Size(160, 24);
            this.tsmiInventory.Text = "Quản lý mặt hàng";
            this.tsmiInventory.Click += new System.EventHandler(this.tsmiInventory_Click);
            // 
            // tsmiContact
            // 
            this.tsmiContact.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiContact.Image = ((System.Drawing.Image)(resources.GetObject("tsmiContact.Image")));
            this.tsmiContact.Name = "tsmiContact";
            this.tsmiContact.Size = new System.Drawing.Size(90, 24);
            this.tsmiContact.Text = "Liên hệ";
            this.tsmiContact.Click += new System.EventHandler(this.tsmiContact_Click);
            // 
            // tsmiBill
            // 
            this.tsmiBill.Name = "tsmiBill";
            this.tsmiBill.Size = new System.Drawing.Size(132, 24);
            this.tsmiBill.Text = "Quản lý hóa đơn";
            this.tsmiBill.Click += new System.EventHandler(this.tsmiBill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindClient);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 107);
            this.panel1.TabIndex = 1;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindClient.Location = new System.Drawing.Point(72, 57);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(112, 32);
            this.btnFindClient.TabIndex = 3;
            this.btnFindClient.Text = "Tìm kiếm";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(51, 20);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(175, 22);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SĐT:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(684, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 540);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnToltalmoney);
            this.groupBox1.Controls.Add(this.txtToltalmoney);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancle);
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSelectPhonenumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserFullname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(120, 236);
            this.txtDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDay.Name = "txtDay";
            this.txtDay.ReadOnly = true;
            this.txtDay.Size = new System.Drawing.Size(107, 24);
            this.txtDay.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(17, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày mua:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(120, 169);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(143, 24);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(17, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giảm giá:";
            // 
            // btnToltalmoney
            // 
            this.btnToltalmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnToltalmoney.Location = new System.Drawing.Point(84, 297);
            this.btnToltalmoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToltalmoney.Name = "btnToltalmoney";
            this.btnToltalmoney.Size = new System.Drawing.Size(112, 32);
            this.btnToltalmoney.TabIndex = 4;
            this.btnToltalmoney.Text = "Tính tiền";
            this.btnToltalmoney.UseVisualStyleBackColor = true;
            this.btnToltalmoney.Click += new System.EventHandler(this.btnToltalmoney_Click);
            // 
            // txtToltalmoney
            // 
            this.txtToltalmoney.Location = new System.Drawing.Point(104, 345);
            this.txtToltalmoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToltalmoney.Name = "txtToltalmoney";
            this.txtToltalmoney.ReadOnly = true;
            this.txtToltalmoney.Size = new System.Drawing.Size(175, 24);
            this.txtToltalmoney.TabIndex = 5;
            this.txtToltalmoney.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(1, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng tiền:";
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancle.Location = new System.Drawing.Point(152, 390);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(112, 64);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(20, 390);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(112, 64);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtAddress.Location = new System.Drawing.Point(104, 114);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(173, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtSelectPhonenumber
            // 
            this.txtSelectPhonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtSelectPhonenumber.Location = new System.Drawing.Point(104, 70);
            this.txtSelectPhonenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectPhonenumber.Name = "txtSelectPhonenumber";
            this.txtSelectPhonenumber.ReadOnly = true;
            this.txtSelectPhonenumber.Size = new System.Drawing.Size(156, 22);
            this.txtSelectPhonenumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "SĐT:";
            // 
            // txtUserFullname
            // 
            this.txtUserFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtUserFullname.Location = new System.Drawing.Point(104, 25);
            this.txtUserFullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserFullname.Name = "txtUserFullname";
            this.txtUserFullname.ReadOnly = true;
            this.txtUserFullname.Size = new System.Drawing.Size(156, 22);
            this.txtUserFullname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbNameOfItem);
            this.panel3.Controls.Add(this.cmbClass);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.nudSelectItem);
            this.panel3.Location = new System.Drawing.Point(251, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 110);
            this.panel3.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDelete.Location = new System.Drawing.Point(292, 77);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(4, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tên mô hình:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(4, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Loại mô hình:";
            // 
            // cmbNameOfItem
            // 
            this.cmbNameOfItem.FormattingEnabled = true;
            this.cmbNameOfItem.Location = new System.Drawing.Point(116, 64);
            this.cmbNameOfItem.Name = "cmbNameOfItem";
            this.cmbNameOfItem.Size = new System.Drawing.Size(121, 24);
            this.cmbNameOfItem.TabIndex = 6;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(116, 25);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 24);
            this.cmbClass.TabIndex = 5;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Location = new System.Drawing.Point(292, 41);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(248, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng:";
            // 
            // nudSelectItem
            // 
            this.nudSelectItem.Location = new System.Drawing.Point(325, 9);
            this.nudSelectItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSelectItem.Name = "nudSelectItem";
            this.nudSelectItem.Size = new System.Drawing.Size(79, 22);
            this.nudSelectItem.TabIndex = 0;
            // 
            // dgvListItemToTransaction
            // 
            this.dgvListItemToTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListItemToTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvListItemToTransaction.Location = new System.Drawing.Point(3, 150);
            this.dgvListItemToTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListItemToTransaction.Name = "dgvListItemToTransaction";
            this.dgvListItemToTransaction.RowHeadersWidth = 51;
            this.dgvListItemToTransaction.RowTemplate.Height = 24;
            this.dgvListItemToTransaction.Size = new System.Drawing.Size(677, 370);
            this.dgvListItemToTransaction.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thể loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(972, 522);
            this.Controls.Add(this.dgvListItemToTransaction);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý ";
            this.Load += new System.EventHandler(this.FrmTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItemToTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffs;
        private System.Windows.Forms.ToolStripMenuItem tsmiClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiInventory;
        private System.Windows.Forms.ToolStripMenuItem tsmiAcout;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSelectPhonenumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtToltalmoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnToltalmoney;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSelectItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvListItemToTransaction;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem tsmiContact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNameOfItem;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem tsmiBill;
        private System.Windows.Forms.Button btnDelete;
    }
}