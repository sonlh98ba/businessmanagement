namespace TTCN2
{
    partial class BuyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRepurchaseID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintRepurchaseBill = new System.Windows.Forms.Button();
            this.btnAddRepurchaseBill = new System.Windows.Forms.Button();
            this.btnListRepurchase = new System.Windows.Forms.Button();
            this.btnPayRepurchaseBill = new System.Windows.Forms.Button();
            this.btnDeleteRepurchaseBill = new System.Windows.Forms.Button();
            this.pnlListProduct = new System.Windows.Forms.Panel();
            this.grbRepurchaseInfo = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.nmrProductCount = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductIDInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSBIDInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRepurchaseIDInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvSellingBill = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtReasonInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlListProduct.SuspendLayout();
            this.grbRepurchaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSellingBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtRepurchaseID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSBID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 63);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã đơn mua lại:";
            // 
            // txtRepurchaseID
            // 
            this.txtRepurchaseID.BackColor = System.Drawing.SystemColors.Control;
            this.txtRepurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepurchaseID.ForeColor = System.Drawing.Color.Red;
            this.txtRepurchaseID.Location = new System.Drawing.Point(95, 29);
            this.txtRepurchaseID.Name = "txtRepurchaseID";
            this.txtRepurchaseID.ReadOnly = true;
            this.txtRepurchaseID.Size = new System.Drawing.Size(183, 20);
            this.txtRepurchaseID.TabIndex = 8;
            this.txtRepurchaseID.Text = "Tự động";
            this.txtRepurchaseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(658, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số HĐ:";
            // 
            // txtSBID
            // 
            this.txtSBID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSBID.BackColor = System.Drawing.SystemColors.Control;
            this.txtSBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBID.ForeColor = System.Drawing.Color.Red;
            this.txtSBID.Location = new System.Drawing.Point(469, 29);
            this.txtSBID.Name = "txtSBID";
            this.txtSBID.Size = new System.Drawing.Size(183, 20);
            this.txtSBID.TabIndex = 0;
            this.txtSBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MUA LẠI SẢN PHẨM";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnPrintRepurchaseBill);
            this.panel4.Controls.Add(this.btnAddRepurchaseBill);
            this.panel4.Controls.Add(this.btnListRepurchase);
            this.panel4.Controls.Add(this.btnPayRepurchaseBill);
            this.panel4.Controls.Add(this.btnDeleteRepurchaseBill);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1115, 39);
            this.panel4.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1016, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 29);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintRepurchaseBill
            // 
            this.btnPrintRepurchaseBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRepurchaseBill.Enabled = false;
            this.btnPrintRepurchaseBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRepurchaseBill.Image")));
            this.btnPrintRepurchaseBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintRepurchaseBill.Location = new System.Drawing.Point(918, 3);
            this.btnPrintRepurchaseBill.Name = "btnPrintRepurchaseBill";
            this.btnPrintRepurchaseBill.Size = new System.Drawing.Size(92, 29);
            this.btnPrintRepurchaseBill.TabIndex = 29;
            this.btnPrintRepurchaseBill.Text = "In";
            this.btnPrintRepurchaseBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintRepurchaseBill.UseVisualStyleBackColor = true;
            // 
            // btnAddRepurchaseBill
            // 
            this.btnAddRepurchaseBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRepurchaseBill.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRepurchaseBill.Image")));
            this.btnAddRepurchaseBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRepurchaseBill.Location = new System.Drawing.Point(3, 3);
            this.btnAddRepurchaseBill.Name = "btnAddRepurchaseBill";
            this.btnAddRepurchaseBill.Size = new System.Drawing.Size(92, 29);
            this.btnAddRepurchaseBill.TabIndex = 25;
            this.btnAddRepurchaseBill.Text = "Thêm mới";
            this.btnAddRepurchaseBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRepurchaseBill.UseVisualStyleBackColor = true;
            this.btnAddRepurchaseBill.Click += new System.EventHandler(this.btnAddRepurchaseBill_Click);
            // 
            // btnListRepurchase
            // 
            this.btnListRepurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListRepurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnListRepurchase.Image")));
            this.btnListRepurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListRepurchase.Location = new System.Drawing.Point(297, 3);
            this.btnListRepurchase.Name = "btnListRepurchase";
            this.btnListRepurchase.Size = new System.Drawing.Size(92, 29);
            this.btnListRepurchase.TabIndex = 24;
            this.btnListRepurchase.Text = "Danh sách";
            this.btnListRepurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListRepurchase.UseVisualStyleBackColor = true;
            this.btnListRepurchase.Click += new System.EventHandler(this.btnListRepurchase_Click);
            // 
            // btnPayRepurchaseBill
            // 
            this.btnPayRepurchaseBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPayRepurchaseBill.Enabled = false;
            this.btnPayRepurchaseBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPayRepurchaseBill.Image")));
            this.btnPayRepurchaseBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayRepurchaseBill.Location = new System.Drawing.Point(199, 3);
            this.btnPayRepurchaseBill.Name = "btnPayRepurchaseBill";
            this.btnPayRepurchaseBill.Size = new System.Drawing.Size(92, 29);
            this.btnPayRepurchaseBill.TabIndex = 19;
            this.btnPayRepurchaseBill.Text = "Thanh toán";
            this.btnPayRepurchaseBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayRepurchaseBill.UseVisualStyleBackColor = true;
            this.btnPayRepurchaseBill.Click += new System.EventHandler(this.btnPayRepurchaseBill_Click);
            // 
            // btnDeleteRepurchaseBill
            // 
            this.btnDeleteRepurchaseBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteRepurchaseBill.Enabled = false;
            this.btnDeleteRepurchaseBill.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRepurchaseBill.Image")));
            this.btnDeleteRepurchaseBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRepurchaseBill.Location = new System.Drawing.Point(101, 3);
            this.btnDeleteRepurchaseBill.Name = "btnDeleteRepurchaseBill";
            this.btnDeleteRepurchaseBill.Size = new System.Drawing.Size(92, 29);
            this.btnDeleteRepurchaseBill.TabIndex = 18;
            this.btnDeleteRepurchaseBill.Text = "Xoá HĐ";
            this.btnDeleteRepurchaseBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRepurchaseBill.UseVisualStyleBackColor = true;
            this.btnDeleteRepurchaseBill.Click += new System.EventHandler(this.btnDeleteRepurchaseBill_Click);
            // 
            // pnlListProduct
            // 
            this.pnlListProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlListProduct.Controls.Add(this.label2);
            this.pnlListProduct.Controls.Add(this.txtProductCount);
            this.pnlListProduct.Controls.Add(this.grbRepurchaseInfo);
            this.pnlListProduct.Controls.Add(this.label30);
            this.pnlListProduct.Controls.Add(this.label6);
            this.pnlListProduct.Controls.Add(this.txtProductID);
            this.pnlListProduct.Controls.Add(this.label5);
            this.pnlListProduct.Controls.Add(this.txtProductPrice);
            this.pnlListProduct.Controls.Add(this.dtgvSellingBill);
            this.pnlListProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListProduct.Enabled = false;
            this.pnlListProduct.Location = new System.Drawing.Point(0, 63);
            this.pnlListProduct.Name = "pnlListProduct";
            this.pnlListProduct.Size = new System.Drawing.Size(1115, 402);
            this.pnlListProduct.TabIndex = 9;
            // 
            // grbRepurchaseInfo
            // 
            this.grbRepurchaseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRepurchaseInfo.Controls.Add(this.label4);
            this.grbRepurchaseInfo.Controls.Add(this.txtReasonInfo);
            this.grbRepurchaseInfo.Controls.Add(this.btnOK);
            this.grbRepurchaseInfo.Controls.Add(this.nmrProductCount);
            this.grbRepurchaseInfo.Controls.Add(this.label12);
            this.grbRepurchaseInfo.Controls.Add(this.txtPrice);
            this.grbRepurchaseInfo.Controls.Add(this.label11);
            this.grbRepurchaseInfo.Controls.Add(this.label10);
            this.grbRepurchaseInfo.Controls.Add(this.txtProductIDInfo);
            this.grbRepurchaseInfo.Controls.Add(this.label9);
            this.grbRepurchaseInfo.Controls.Add(this.txtSBIDInfo);
            this.grbRepurchaseInfo.Controls.Add(this.label8);
            this.grbRepurchaseInfo.Controls.Add(this.txtRepurchaseIDInfo);
            this.grbRepurchaseInfo.Enabled = false;
            this.grbRepurchaseInfo.Location = new System.Drawing.Point(729, 29);
            this.grbRepurchaseInfo.Name = "grbRepurchaseInfo";
            this.grbRepurchaseInfo.Size = new System.Drawing.Size(379, 366);
            this.grbRepurchaseInfo.TabIndex = 31;
            this.grbRepurchaseInfo.TabStop = false;
            this.grbRepurchaseInfo.Text = "Thông tin mua lại";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(101, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(272, 34);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nmrProductCount
            // 
            this.nmrProductCount.Location = new System.Drawing.Point(101, 105);
            this.nmrProductCount.Name = "nmrProductCount";
            this.nmrProductCount.Size = new System.Drawing.Size(272, 20);
            this.nmrProductCount.TabIndex = 20;
            this.nmrProductCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Blue;
            this.txtPrice.Location = new System.Drawing.Point(101, 340);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(272, 20);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Số lượng SP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mã SP:";
            // 
            // txtProductIDInfo
            // 
            this.txtProductIDInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductIDInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductIDInfo.ForeColor = System.Drawing.Color.Black;
            this.txtProductIDInfo.Location = new System.Drawing.Point(101, 79);
            this.txtProductIDInfo.Name = "txtProductIDInfo";
            this.txtProductIDInfo.Size = new System.Drawing.Size(272, 20);
            this.txtProductIDInfo.TabIndex = 14;
            this.txtProductIDInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã hoá đơn bán:";
            // 
            // txtSBIDInfo
            // 
            this.txtSBIDInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSBIDInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBIDInfo.ForeColor = System.Drawing.Color.Black;
            this.txtSBIDInfo.Location = new System.Drawing.Point(101, 53);
            this.txtSBIDInfo.Name = "txtSBIDInfo";
            this.txtSBIDInfo.Size = new System.Drawing.Size(272, 20);
            this.txtSBIDInfo.TabIndex = 12;
            this.txtSBIDInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã ĐML:";
            // 
            // txtRepurchaseIDInfo
            // 
            this.txtRepurchaseIDInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtRepurchaseIDInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepurchaseIDInfo.ForeColor = System.Drawing.Color.Red;
            this.txtRepurchaseIDInfo.Location = new System.Drawing.Point(101, 27);
            this.txtRepurchaseIDInfo.Name = "txtRepurchaseIDInfo";
            this.txtRepurchaseIDInfo.Size = new System.Drawing.Size(272, 20);
            this.txtRepurchaseIDInfo.TabIndex = 10;
            this.txtRepurchaseIDInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã hàng:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(61, 29);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(135, 20);
            this.txtProductID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ĐƠN HÀNG ĐÃ MUA";
            // 
            // dtgvSellingBill
            // 
            this.dtgvSellingBill.AllowUserToAddRows = false;
            this.dtgvSellingBill.AllowUserToResizeRows = false;
            this.dtgvSellingBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSellingBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSellingBill.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSellingBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvSellingBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSellingBill.Location = new System.Drawing.Point(3, 55);
            this.dtgvSellingBill.MultiSelect = false;
            this.dtgvSellingBill.Name = "dtgvSellingBill";
            this.dtgvSellingBill.ReadOnly = true;
            this.dtgvSellingBill.RowHeadersVisible = false;
            this.dtgvSellingBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSellingBill.Size = new System.Drawing.Size(720, 313);
            this.dtgvSellingBill.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Giá mua lại";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Số lượng:";
            // 
            // txtProductCount
            // 
            this.txtProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProductCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductCount.Location = new System.Drawing.Point(61, 374);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.ReadOnly = true;
            this.txtProductCount.Size = new System.Drawing.Size(73, 20);
            this.txtProductCount.TabIndex = 32;
            this.txtProductCount.Text = "0";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(601, 378);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "Giá SP:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductPrice.Location = new System.Drawing.Point(650, 374);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(73, 20);
            this.txtProductPrice.TabIndex = 9;
            this.txtProductPrice.Text = "0";
            // 
            // txtReasonInfo
            // 
            this.txtReasonInfo.Location = new System.Drawing.Point(101, 131);
            this.txtReasonInfo.Multiline = true;
            this.txtReasonInfo.Name = "txtReasonInfo";
            this.txtReasonInfo.Size = new System.Drawing.Size(272, 81);
            this.txtReasonInfo.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lý do:";
            // 
            // BuyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlListProduct);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "BuyControl";
            this.Size = new System.Drawing.Size(1115, 504);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlListProduct.ResumeLayout(false);
            this.pnlListProduct.PerformLayout();
            this.grbRepurchaseInfo.ResumeLayout(false);
            this.grbRepurchaseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSellingBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRepurchaseID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSBID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintRepurchaseBill;
        private System.Windows.Forms.Button btnAddRepurchaseBill;
        private System.Windows.Forms.Button btnListRepurchase;
        private System.Windows.Forms.Button btnPayRepurchaseBill;
        private System.Windows.Forms.Button btnDeleteRepurchaseBill;
        private System.Windows.Forms.Panel pnlListProduct;
        private System.Windows.Forms.GroupBox grbRepurchaseInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nmrProductCount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductIDInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSBIDInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRepurchaseIDInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvSellingBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReasonInfo;
    }
}
