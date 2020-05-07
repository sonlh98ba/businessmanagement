namespace TTCN2
{
    partial class CatalogueControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pcbProductPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductInventory = new System.Windows.Forms.TextBox();
            this.cbbCatalogue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcessFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtGemWeight = new System.Windows.Forms.TextBox();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.fpnlCatalogue = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgvProductList = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblCountdtgv = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnCatalogueOptions = new System.Windows.Forms.Button();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnSaveInsert = new System.Windows.Forms.Button();
            this.lblTotalProductCount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCatalogueOptions2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProductPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductList)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbProductPic
            // 
            this.pcbProductPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbProductPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbProductPic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbProductPic.ErrorImage")));
            this.pcbProductPic.InitialImage = null;
            this.pcbProductPic.Location = new System.Drawing.Point(912, 53);
            this.pcbProductPic.Name = "pcbProductPic";
            this.pcbProductPic.Size = new System.Drawing.Size(200, 200);
            this.pcbProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbProductPic.TabIndex = 0;
            this.pcbProductPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH MẪU MÃ SẢN PHẨM";
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductID.Location = new System.Drawing.Point(81, 14);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(219, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kí hiệu(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã loại(*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên SP(*):";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductName.Location = new System.Drawing.Point(81, 67);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(219, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tồn kho:";
            // 
            // txtProductInventory
            // 
            this.txtProductInventory.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductInventory.Location = new System.Drawing.Point(81, 93);
            this.txtProductInventory.Name = "txtProductInventory";
            this.txtProductInventory.Size = new System.Drawing.Size(219, 20);
            this.txtProductInventory.TabIndex = 4;
            this.txtProductInventory.Text = "0";
            // 
            // cbbCatalogue
            // 
            this.cbbCatalogue.BackColor = System.Drawing.SystemColors.Control;
            this.cbbCatalogue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCatalogue.FormattingEnabled = true;
            this.cbbCatalogue.Location = new System.Drawing.Point(81, 40);
            this.cbbCatalogue.Name = "cbbCatalogue";
            this.cbbCatalogue.Size = new System.Drawing.Size(192, 21);
            this.cbbCatalogue.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Công thợ:";
            // 
            // txtProcessFee
            // 
            this.txtProcessFee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProcessFee.BackColor = System.Drawing.SystemColors.Control;
            this.txtProcessFee.Location = new System.Drawing.Point(389, 93);
            this.txtProcessFee.Name = "txtProcessFee";
            this.txtProcessFee.Size = new System.Drawing.Size(182, 20);
            this.txtProcessFee.TabIndex = 8;
            this.txtProcessFee.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "TL 1 SP:";
            // 
            // txtProductWeight
            // 
            this.txtProductWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProductWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductWeight.Location = new System.Drawing.Point(389, 67);
            this.txtProductWeight.Name = "txtProductWeight";
            this.txtProductWeight.Size = new System.Drawing.Size(182, 20);
            this.txtProductWeight.TabIndex = 7;
            this.txtProductWeight.Text = "0.000";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "TL Đá:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Giá SP:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProductPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductPrice.Location = new System.Drawing.Point(389, 14);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(182, 20);
            this.txtProductPrice.TabIndex = 5;
            this.txtProductPrice.Text = "0";
            // 
            // txtGemWeight
            // 
            this.txtGemWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGemWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtGemWeight.Location = new System.Drawing.Point(389, 40);
            this.txtGemWeight.Name = "txtGemWeight";
            this.txtGemWeight.Size = new System.Drawing.Size(182, 20);
            this.txtGemWeight.TabIndex = 6;
            this.txtGemWeight.Text = "0.000";
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertProduct.Image")));
            this.btnInsertProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertProduct.Location = new System.Drawing.Point(6, 162);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(90, 31);
            this.btnInsertProduct.TabIndex = 10;
            this.btnInsertProduct.Text = "Thêm mới";
            this.btnInsertProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Enabled = false;
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(294, 162);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(90, 31);
            this.btnEditProduct.TabIndex = 13;
            this.btnEditProduct.Text = "Chỉnh sửa";
            this.btnEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(816, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(198, 162);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(90, 31);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Xoá SP";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Enabled = false;
            this.btnUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.Image")));
            this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProduct.Location = new System.Drawing.Point(390, 162);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(90, 31);
            this.btnUpdateProduct.TabIndex = 14;
            this.btnUpdateProduct.Text = "Cập nhật";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(165, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Số lượng sản phẩm:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1020, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 29);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fpnlCatalogue
            // 
            this.fpnlCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpnlCatalogue.AutoScroll = true;
            this.fpnlCatalogue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fpnlCatalogue.Location = new System.Drawing.Point(6, 212);
            this.fpnlCatalogue.Name = "fpnlCatalogue";
            this.fpnlCatalogue.Size = new System.Drawing.Size(156, 225);
            this.fpnlCatalogue.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Danh sách phân loại:";
            // 
            // dtgvProductList
            // 
            this.dtgvProductList.AllowUserToAddRows = false;
            this.dtgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvProductList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductList.Location = new System.Drawing.Point(168, 212);
            this.dtgvProductList.MultiSelect = false;
            this.dtgvProductList.Name = "dtgvProductList";
            this.dtgvProductList.ReadOnly = true;
            this.dtgvProductList.RowHeadersVisible = false;
            this.dtgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductList.Size = new System.Drawing.Size(738, 225);
            this.dtgvProductList.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Danh sách sản phẩm:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(638, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.SystemColors.Control;
            this.txtNote.Location = new System.Drawing.Point(698, 14);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(199, 74);
            this.txtNote.TabIndex = 9;
            // 
            // lblCountdtgv
            // 
            this.lblCountdtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountdtgv.AutoSize = true;
            this.lblCountdtgv.Location = new System.Drawing.Point(272, 445);
            this.lblCountdtgv.Name = "lblCountdtgv";
            this.lblCountdtgv.Size = new System.Drawing.Size(13, 13);
            this.lblCountdtgv.TabIndex = 40;
            this.lblCountdtgv.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(577, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Carat";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(577, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Gram";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(577, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "VNĐ";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(577, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "VNĐ";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.Controls.Add(this.btnCatalogueOptions);
            this.pnlInfo.Controls.Add(this.btnAddPic);
            this.pnlInfo.Controls.Add(this.label13);
            this.pnlInfo.Controls.Add(this.txtNote);
            this.pnlInfo.Controls.Add(this.txtProductID);
            this.pnlInfo.Controls.Add(this.label17);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label16);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label15);
            this.pnlInfo.Controls.Add(this.txtProductName);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.txtProductInventory);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.cbbCatalogue);
            this.pnlInfo.Controls.Add(this.txtProductPrice);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.txtProductWeight);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.txtProcessFee);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.txtGemWeight);
            this.pnlInfo.Enabled = false;
            this.pnlInfo.Location = new System.Drawing.Point(6, 39);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(900, 117);
            this.pnlInfo.TabIndex = 43;
            // 
            // btnCatalogueOptions
            // 
            this.btnCatalogueOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalogueOptions.Image")));
            this.btnCatalogueOptions.Location = new System.Drawing.Point(279, 40);
            this.btnCatalogueOptions.Name = "btnCatalogueOptions";
            this.btnCatalogueOptions.Size = new System.Drawing.Size(21, 21);
            this.btnCatalogueOptions.TabIndex = 44;
            this.btnCatalogueOptions.UseVisualStyleBackColor = true;
            this.btnCatalogueOptions.Click += new System.EventHandler(this.btnCatalogueOptions_Click);
            // 
            // btnAddPic
            // 
            this.btnAddPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPic.Location = new System.Drawing.Point(822, 91);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(75, 23);
            this.btnAddPic.TabIndex = 43;
            this.btnAddPic.Text = "Ảnh SP";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnSaveInsert
            // 
            this.btnSaveInsert.Enabled = false;
            this.btnSaveInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveInsert.Image")));
            this.btnSaveInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInsert.Location = new System.Drawing.Point(102, 162);
            this.btnSaveInsert.Name = "btnSaveInsert";
            this.btnSaveInsert.Size = new System.Drawing.Size(90, 31);
            this.btnSaveInsert.TabIndex = 11;
            this.btnSaveInsert.Text = "Lưu Mới";
            this.btnSaveInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInsert.UseVisualStyleBackColor = true;
            this.btnSaveInsert.Click += new System.EventHandler(this.btnSaveInsert_Click);
            // 
            // lblTotalProductCount
            // 
            this.lblTotalProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalProductCount.AutoSize = true;
            this.lblTotalProductCount.Location = new System.Drawing.Point(272, 464);
            this.lblTotalProductCount.Name = "lblTotalProductCount";
            this.lblTotalProductCount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalProductCount.TabIndex = 45;
            this.lblTotalProductCount.Text = "0";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(165, 464);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Tổng SP trong kho:";
            // 
            // btnCatalogueOptions2
            // 
            this.btnCatalogueOptions2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCatalogueOptions2.Location = new System.Drawing.Point(6, 443);
            this.btnCatalogueOptions2.Name = "btnCatalogueOptions2";
            this.btnCatalogueOptions2.Size = new System.Drawing.Size(156, 32);
            this.btnCatalogueOptions2.TabIndex = 46;
            this.btnCatalogueOptions2.Text = "Phân loại";
            this.btnCatalogueOptions2.UseVisualStyleBackColor = true;
            this.btnCatalogueOptions2.Click += new System.EventHandler(this.btnCatalogueOptions2_Click);
            // 
            // CatalogueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCatalogueOptions2);
            this.Controls.Add(this.lblTotalProductCount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnSaveInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pcbProductPic);
            this.Controls.Add(this.lblCountdtgv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgvProductList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fpnlCatalogue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnInsertProduct);
            this.Name = "CatalogueControl";
            this.Size = new System.Drawing.Size(1115, 504);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProductPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductList)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbProductPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductInventory;
        private System.Windows.Forms.ComboBox cbbCatalogue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcessFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtGemWeight;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel fpnlCatalogue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgvProductList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblCountdtgv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnSaveInsert;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnCatalogueOptions;
        private System.Windows.Forms.Label lblTotalProductCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCatalogueOptions2;
    }
}
