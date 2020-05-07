namespace TTCN2
{
    partial class WarrantyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarrantyControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPWID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintSellingBill = new System.Windows.Forms.Button();
            this.btnAddWarrantyBill = new System.Windows.Forms.Button();
            this.btnListWarranty = new System.Windows.Forms.Button();
            this.btnPayWarrantyBill = new System.Windows.Forms.Button();
            this.btnDeleteWarrantyBill = new System.Windows.Forms.Button();
            this.pnlListProduct = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFreeWarrantyCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.grbWarrantyInfo = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.nmrProductCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductIDInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSBIDInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPWIDInfo = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.dtgvSellingBill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlListProduct.SuspendLayout();
            this.grbWarrantyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSellingBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPWID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSBID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 63);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã ĐBH:";
            // 
            // txtPWID
            // 
            this.txtPWID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPWID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWID.ForeColor = System.Drawing.Color.Red;
            this.txtPWID.Location = new System.Drawing.Point(63, 29);
            this.txtPWID.Name = "txtPWID";
            this.txtPWID.ReadOnly = true;
            this.txtPWID.Size = new System.Drawing.Size(183, 20);
            this.txtPWID.TabIndex = 8;
            this.txtPWID.Text = "Tự động";
            this.txtPWID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label1.Location = new System.Drawing.Point(473, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢO HÀNH SẢN PHẨM";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnPrintSellingBill);
            this.panel4.Controls.Add(this.btnAddWarrantyBill);
            this.panel4.Controls.Add(this.btnListWarranty);
            this.panel4.Controls.Add(this.btnPayWarrantyBill);
            this.panel4.Controls.Add(this.btnDeleteWarrantyBill);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1115, 39);
            this.panel4.TabIndex = 5;
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
            // btnPrintSellingBill
            // 
            this.btnPrintSellingBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintSellingBill.Enabled = false;
            this.btnPrintSellingBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintSellingBill.Image")));
            this.btnPrintSellingBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSellingBill.Location = new System.Drawing.Point(918, 3);
            this.btnPrintSellingBill.Name = "btnPrintSellingBill";
            this.btnPrintSellingBill.Size = new System.Drawing.Size(92, 29);
            this.btnPrintSellingBill.TabIndex = 29;
            this.btnPrintSellingBill.Text = "In";
            this.btnPrintSellingBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSellingBill.UseVisualStyleBackColor = true;
            // 
            // btnAddWarrantyBill
            // 
            this.btnAddWarrantyBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddWarrantyBill.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWarrantyBill.Image")));
            this.btnAddWarrantyBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWarrantyBill.Location = new System.Drawing.Point(3, 3);
            this.btnAddWarrantyBill.Name = "btnAddWarrantyBill";
            this.btnAddWarrantyBill.Size = new System.Drawing.Size(92, 29);
            this.btnAddWarrantyBill.TabIndex = 25;
            this.btnAddWarrantyBill.Text = "Thêm mới";
            this.btnAddWarrantyBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddWarrantyBill.UseVisualStyleBackColor = true;
            this.btnAddWarrantyBill.Click += new System.EventHandler(this.btnAddWarrantyBill_Click);
            // 
            // btnListWarranty
            // 
            this.btnListWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListWarranty.Image = ((System.Drawing.Image)(resources.GetObject("btnListWarranty.Image")));
            this.btnListWarranty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListWarranty.Location = new System.Drawing.Point(297, 3);
            this.btnListWarranty.Name = "btnListWarranty";
            this.btnListWarranty.Size = new System.Drawing.Size(92, 29);
            this.btnListWarranty.TabIndex = 24;
            this.btnListWarranty.Text = "Danh sách";
            this.btnListWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListWarranty.UseVisualStyleBackColor = true;
            this.btnListWarranty.Click += new System.EventHandler(this.btnListWarranty_Click);
            // 
            // btnPayWarrantyBill
            // 
            this.btnPayWarrantyBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPayWarrantyBill.Enabled = false;
            this.btnPayWarrantyBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPayWarrantyBill.Image")));
            this.btnPayWarrantyBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayWarrantyBill.Location = new System.Drawing.Point(199, 3);
            this.btnPayWarrantyBill.Name = "btnPayWarrantyBill";
            this.btnPayWarrantyBill.Size = new System.Drawing.Size(92, 29);
            this.btnPayWarrantyBill.TabIndex = 19;
            this.btnPayWarrantyBill.Text = "Thanh toán";
            this.btnPayWarrantyBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayWarrantyBill.UseVisualStyleBackColor = true;
            this.btnPayWarrantyBill.Click += new System.EventHandler(this.btnPayWarrantyBill_Click);
            // 
            // btnDeleteWarrantyBill
            // 
            this.btnDeleteWarrantyBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteWarrantyBill.Enabled = false;
            this.btnDeleteWarrantyBill.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteWarrantyBill.Image")));
            this.btnDeleteWarrantyBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteWarrantyBill.Location = new System.Drawing.Point(101, 3);
            this.btnDeleteWarrantyBill.Name = "btnDeleteWarrantyBill";
            this.btnDeleteWarrantyBill.Size = new System.Drawing.Size(92, 29);
            this.btnDeleteWarrantyBill.TabIndex = 18;
            this.btnDeleteWarrantyBill.Text = "Xoá HĐ";
            this.btnDeleteWarrantyBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteWarrantyBill.UseVisualStyleBackColor = true;
            this.btnDeleteWarrantyBill.Click += new System.EventHandler(this.btnDeleteWarrantyBill_Click);
            // 
            // pnlListProduct
            // 
            this.pnlListProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlListProduct.Controls.Add(this.label4);
            this.pnlListProduct.Controls.Add(this.txtFreeWarrantyCount);
            this.pnlListProduct.Controls.Add(this.label2);
            this.pnlListProduct.Controls.Add(this.txtProductCount);
            this.pnlListProduct.Controls.Add(this.grbWarrantyInfo);
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
            this.pnlListProduct.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Lượt BH miễn phí còn lại:";
            // 
            // txtFreeWarrantyCount
            // 
            this.txtFreeWarrantyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFreeWarrantyCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtFreeWarrantyCount.Location = new System.Drawing.Point(522, 374);
            this.txtFreeWarrantyCount.Name = "txtFreeWarrantyCount";
            this.txtFreeWarrantyCount.ReadOnly = true;
            this.txtFreeWarrantyCount.Size = new System.Drawing.Size(73, 20);
            this.txtFreeWarrantyCount.TabIndex = 34;
            this.txtFreeWarrantyCount.Text = "0";
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
            this.txtProductCount.TextChanged += new System.EventHandler(this.txtProductCount_TextChanged);
            // 
            // grbWarrantyInfo
            // 
            this.grbWarrantyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbWarrantyInfo.Controls.Add(this.btnOK);
            this.grbWarrantyInfo.Controls.Add(this.nmrProductCount);
            this.grbWarrantyInfo.Controls.Add(this.label12);
            this.grbWarrantyInfo.Controls.Add(this.txtPrice);
            this.grbWarrantyInfo.Controls.Add(this.label11);
            this.grbWarrantyInfo.Controls.Add(this.label10);
            this.grbWarrantyInfo.Controls.Add(this.txtProductIDInfo);
            this.grbWarrantyInfo.Controls.Add(this.label9);
            this.grbWarrantyInfo.Controls.Add(this.txtSBIDInfo);
            this.grbWarrantyInfo.Controls.Add(this.label8);
            this.grbWarrantyInfo.Controls.Add(this.txtPWIDInfo);
            this.grbWarrantyInfo.Enabled = false;
            this.grbWarrantyInfo.Location = new System.Drawing.Point(729, 29);
            this.grbWarrantyInfo.Name = "grbWarrantyInfo";
            this.grbWarrantyInfo.Size = new System.Drawing.Size(379, 366);
            this.grbWarrantyInfo.TabIndex = 31;
            this.grbWarrantyInfo.TabStop = false;
            this.grbWarrantyInfo.Text = "Thông tin bảo hành";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(298, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
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
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phí BH:";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
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
            this.label11.Location = new System.Drawing.Point(6, 109);
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
            this.label8.Text = "Mã ĐBH:";
            // 
            // txtPWIDInfo
            // 
            this.txtPWIDInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtPWIDInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWIDInfo.ForeColor = System.Drawing.Color.Red;
            this.txtPWIDInfo.Location = new System.Drawing.Point(101, 27);
            this.txtPWIDInfo.Name = "txtPWIDInfo";
            this.txtPWIDInfo.Size = new System.Drawing.Size(272, 20);
            this.txtPWIDInfo.TabIndex = 10;
            this.txtPWIDInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // dtgvSellingBill
            // 
            this.dtgvSellingBill.AllowUserToAddRows = false;
            this.dtgvSellingBill.AllowUserToResizeRows = false;
            this.dtgvSellingBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSellingBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSellingBill.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSellingBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // WarrantyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlListProduct);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "WarrantyControl";
            this.Size = new System.Drawing.Size(1115, 504);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlListProduct.ResumeLayout(false);
            this.pnlListProduct.PerformLayout();
            this.grbWarrantyInfo.ResumeLayout(false);
            this.grbWarrantyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSellingBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSBID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintSellingBill;
        private System.Windows.Forms.Button btnAddWarrantyBill;
        private System.Windows.Forms.Button btnListWarranty;
        private System.Windows.Forms.Button btnPayWarrantyBill;
        private System.Windows.Forms.Button btnDeleteWarrantyBill;
        private System.Windows.Forms.Panel pnlListProduct;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.DataGridView dtgvSellingBill;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPWID;
        private System.Windows.Forms.GroupBox grbWarrantyInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFreeWarrantyCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPWIDInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSBIDInfo;
        private System.Windows.Forms.NumericUpDown nmrProductCount;
        private System.Windows.Forms.TextBox txtProductIDInfo;
        private System.Windows.Forms.Button btnOK;
    }
}
