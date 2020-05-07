namespace TTCN2
{
    partial class frmSalesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesManagement));
            this.mnsOptions = new System.Windows.Forms.MenuStrip();
            this.tsmiTrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnPromotions = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnWarehousing = new System.Windows.Forms.Button();
            this.btnExchangeRate = new System.Windows.Forms.Button();
            this.btnWarranty = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRepurchase = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnBalanceMoney = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCatalogue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ptbUsername = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnsOptions.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsername)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsOptions
            // 
            this.mnsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTrade,
            this.tsmiReport,
            this.tsmiPersonalInfo,
            this.tsmiUserManagement,
            this.tsmiSearch,
            this.tsmiInfo,
            this.tsmiExit});
            this.mnsOptions.Location = new System.Drawing.Point(0, 0);
            this.mnsOptions.Name = "mnsOptions";
            this.mnsOptions.Size = new System.Drawing.Size(1115, 24);
            this.mnsOptions.TabIndex = 0;
            this.mnsOptions.Text = "menuStrip1";
            // 
            // tsmiTrade
            // 
            this.tsmiTrade.Name = "tsmiTrade";
            this.tsmiTrade.Size = new System.Drawing.Size(69, 20);
            this.tsmiTrade.Text = "Giao dịch";
            this.tsmiTrade.Click += new System.EventHandler(this.tsmiTrade_Click);
            // 
            // tsmiReport
            // 
            this.tsmiReport.Name = "tsmiReport";
            this.tsmiReport.Size = new System.Drawing.Size(74, 20);
            this.tsmiReport.Text = "In báo cáo";
            this.tsmiReport.Click += new System.EventHandler(this.tsmiReport_Click);
            // 
            // tsmiPersonalInfo
            // 
            this.tsmiPersonalInfo.Name = "tsmiPersonalInfo";
            this.tsmiPersonalInfo.Size = new System.Drawing.Size(116, 20);
            this.tsmiPersonalInfo.Text = "Thông tin cá nhân";
            this.tsmiPersonalInfo.Click += new System.EventHandler(this.tsmiPersonalInfo_Click);
            // 
            // tsmiUserManagement
            // 
            this.tsmiUserManagement.Name = "tsmiUserManagement";
            this.tsmiUserManagement.Size = new System.Drawing.Size(60, 20);
            this.tsmiUserManagement.Text = "Quản lý";
            this.tsmiUserManagement.Click += new System.EventHandler(this.tsmiUser_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(58, 20);
            this.tsmiSearch.Text = "Tra cứu";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiInfo
            // 
            this.tsmiInfo.Name = "tsmiInfo";
            this.tsmiInfo.Size = new System.Drawing.Size(71, 20);
            this.tsmiInfo.Text = "Thông tin";
            this.tsmiInfo.Click += new System.EventHandler(this.tsmiInfo_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(50, 20);
            this.tsmiExit.Text = "Thoát";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOptions.Controls.Add(this.btnPromotions);
            this.pnlOptions.Controls.Add(this.btnCustomer);
            this.pnlOptions.Controls.Add(this.btnWarehousing);
            this.pnlOptions.Controls.Add(this.btnExchangeRate);
            this.pnlOptions.Controls.Add(this.btnWarranty);
            this.pnlOptions.Controls.Add(this.btnOrder);
            this.pnlOptions.Controls.Add(this.btnRepurchase);
            this.pnlOptions.Controls.Add(this.btnSales);
            this.pnlOptions.Controls.Add(this.btnBalanceMoney);
            this.pnlOptions.Controls.Add(this.btnLogout);
            this.pnlOptions.Controls.Add(this.btnCatalogue);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 24);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(1115, 50);
            this.pnlOptions.TabIndex = 1;
            // 
            // btnPromotions
            // 
            this.btnPromotions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPromotions.Image = ((System.Drawing.Image)(resources.GetObject("btnPromotions.Image")));
            this.btnPromotions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPromotions.Location = new System.Drawing.Point(490, 0);
            this.btnPromotions.Name = "btnPromotions";
            this.btnPromotions.Size = new System.Drawing.Size(70, 46);
            this.btnPromotions.TabIndex = 50;
            this.btnPromotions.Text = "Khuyến mãi";
            this.btnPromotions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPromotions.UseVisualStyleBackColor = true;
            this.btnPromotions.Click += new System.EventHandler(this.btnPromotions_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.Location = new System.Drawing.Point(420, 0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(70, 46);
            this.btnCustomer.TabIndex = 50;
            this.btnCustomer.Text = "Khách";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnWarehousing
            // 
            this.btnWarehousing.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWarehousing.Image = ((System.Drawing.Image)(resources.GetObject("btnWarehousing.Image")));
            this.btnWarehousing.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWarehousing.Location = new System.Drawing.Point(350, 0);
            this.btnWarehousing.Name = "btnWarehousing";
            this.btnWarehousing.Size = new System.Drawing.Size(70, 46);
            this.btnWarehousing.TabIndex = 50;
            this.btnWarehousing.Text = "Nhập kho";
            this.btnWarehousing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWarehousing.UseVisualStyleBackColor = true;
            this.btnWarehousing.Click += new System.EventHandler(this.btnWarehousing_Click);
            // 
            // btnExchangeRate
            // 
            this.btnExchangeRate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExchangeRate.Image = ((System.Drawing.Image)(resources.GetObject("btnExchangeRate.Image")));
            this.btnExchangeRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExchangeRate.Location = new System.Drawing.Point(901, 0);
            this.btnExchangeRate.Name = "btnExchangeRate";
            this.btnExchangeRate.Size = new System.Drawing.Size(70, 46);
            this.btnExchangeRate.TabIndex = 50;
            this.btnExchangeRate.Text = "Tỷ giá";
            this.btnExchangeRate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExchangeRate.UseVisualStyleBackColor = true;
            this.btnExchangeRate.Click += new System.EventHandler(this.btnExchangeRate_Click);
            // 
            // btnWarranty
            // 
            this.btnWarranty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWarranty.Image = ((System.Drawing.Image)(resources.GetObject("btnWarranty.Image")));
            this.btnWarranty.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWarranty.Location = new System.Drawing.Point(280, 0);
            this.btnWarranty.Name = "btnWarranty";
            this.btnWarranty.Size = new System.Drawing.Size(70, 46);
            this.btnWarranty.TabIndex = 50;
            this.btnWarranty.Text = "Bảo hành";
            this.btnWarranty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWarranty.UseVisualStyleBackColor = true;
            this.btnWarranty.Click += new System.EventHandler(this.btnWarranty_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrder.Location = new System.Drawing.Point(210, 0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(70, 46);
            this.btnOrder.TabIndex = 50;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRepurchase
            // 
            this.btnRepurchase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRepurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnRepurchase.Image")));
            this.btnRepurchase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRepurchase.Location = new System.Drawing.Point(140, 0);
            this.btnRepurchase.Name = "btnRepurchase";
            this.btnRepurchase.Size = new System.Drawing.Size(70, 46);
            this.btnRepurchase.TabIndex = 50;
            this.btnRepurchase.Text = "Mua lại";
            this.btnRepurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRepurchase.UseVisualStyleBackColor = true;
            this.btnRepurchase.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.Location = new System.Drawing.Point(70, 0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(70, 46);
            this.btnSales.TabIndex = 50;
            this.btnSales.Text = "Bán hàng";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnBalanceMoney
            // 
            this.btnBalanceMoney.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBalanceMoney.Image = ((System.Drawing.Image)(resources.GetObject("btnBalanceMoney.Image")));
            this.btnBalanceMoney.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBalanceMoney.Location = new System.Drawing.Point(971, 0);
            this.btnBalanceMoney.Name = "btnBalanceMoney";
            this.btnBalanceMoney.Size = new System.Drawing.Size(70, 46);
            this.btnBalanceMoney.TabIndex = 50;
            this.btnBalanceMoney.Text = "Dư Quầy";
            this.btnBalanceMoney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBalanceMoney.UseVisualStyleBackColor = true;
            this.btnBalanceMoney.Click += new System.EventHandler(this.btnBalanceMoney_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(1041, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 46);
            this.btnLogout.TabIndex = 50;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCatalogue.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalogue.Image")));
            this.btnCatalogue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCatalogue.Location = new System.Drawing.Point(0, 0);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Size = new System.Drawing.Size(70, 46);
            this.btnCatalogue.TabIndex = 50;
            this.btnCatalogue.Text = "Mục lục";
            this.btnCatalogue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCatalogue.UseVisualStyleBackColor = true;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 25);
            this.panel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblUsername);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(329, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 25);
            this.panel7.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(28, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username - Position";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblStatus);
            this.panel6.Controls.Add(this.ptbUsername);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(522, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 25);
            this.panel6.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Trạng thái quầy - User";
            // 
            // ptbUsername
            // 
            this.ptbUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbUsername.Image = ((System.Drawing.Image)(resources.GetObject("ptbUsername.Image")));
            this.ptbUsername.Location = new System.Drawing.Point(0, 0);
            this.ptbUsername.Name = "ptbUsername";
            this.ptbUsername.Size = new System.Drawing.Size(22, 21);
            this.ptbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUsername.TabIndex = 2;
            this.ptbUsername.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(862, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 25);
            this.panel5.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lblHour);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1002, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 25);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(31, 4);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(30, 13);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Time";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 25);
            this.panel3.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(0, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© Developing by AppleS";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 74);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1115, 504);
            this.pnlDisplay.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 603);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.mnsOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsOptions;
            this.Name = "frmSalesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management - Huy Thanh Jewelry";
            this.mnsOptions.ResumeLayout(false);
            this.mnsOptions.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsername)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrade;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiReport;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExchangeRate;
        private System.Windows.Forms.Button btnPromotions;
        private System.Windows.Forms.Button btnBalanceMoney;
        private System.Windows.Forms.Button btnWarranty;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnWarehousing;
        private System.Windows.Forms.Button btnCatalogue;
        private System.Windows.Forms.Button btnRepurchase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox ptbUsername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalInfo;
        private System.Windows.Forms.Button btnOrder;
    }
}