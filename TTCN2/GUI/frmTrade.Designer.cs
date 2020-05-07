namespace TTCN2
{
    partial class frmTrade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrade));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExportImporting = new System.Windows.Forms.Button();
            this.btnImportingFilter = new System.Windows.Forms.Button();
            this.dtpkImportingDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpkImportingDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtgvImportingBillList = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExportOrder = new System.Windows.Forms.Button();
            this.btnOrderFilter = new System.Windows.Forms.Button();
            this.dtpkOrderDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpkOrderDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtgvOrderList = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExportWarranty = new System.Windows.Forms.Button();
            this.btnWarrantyFilter = new System.Windows.Forms.Button();
            this.dtpkWarrantyDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpkWarrantyDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtgvWarrantyBillList = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportRepurchase = new System.Windows.Forms.Button();
            this.btnRepurchaseFilter = new System.Windows.Forms.Button();
            this.dtpkRepurchaseDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpkRepurchaseDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtgvRepurchaseList = new System.Windows.Forms.DataGridView();
            this.tpSales = new System.Windows.Forms.TabPage();
            this.btnExportSales = new System.Windows.Forms.Button();
            this.btnSalesFilter = new System.Windows.Forms.Button();
            this.dtpkSellingDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpkSellingDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtgvSellingBillList = new System.Windows.Forms.DataGridView();
            this.tcrlTrade = new System.Windows.Forms.TabControl();
            this.rdbFilterByOrder = new System.Windows.Forms.RadioButton();
            this.rdbFilterByReceive = new System.Windows.Forms.RadioButton();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImportingBillList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWarrantyBillList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRepurchaseList)).BeginInit();
            this.tpSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSellingBillList)).BeginInit();
            this.tcrlTrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnExportImporting);
            this.tabPage4.Controls.Add(this.btnImportingFilter);
            this.tabPage4.Controls.Add(this.dtpkImportingDate2);
            this.tabPage4.Controls.Add(this.dtpkImportingDate1);
            this.tabPage4.Controls.Add(this.dtgvImportingBillList);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(843, 458);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Nhập hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExportImporting
            // 
            this.btnExportImporting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportImporting.Location = new System.Drawing.Point(372, 420);
            this.btnExportImporting.Name = "btnExportImporting";
            this.btnExportImporting.Size = new System.Drawing.Size(98, 30);
            this.btnExportImporting.TabIndex = 44;
            this.btnExportImporting.Text = "Xuất Excel";
            this.btnExportImporting.UseVisualStyleBackColor = true;
            this.btnExportImporting.Click += new System.EventHandler(this.btnExportImporting_Click);
            // 
            // btnImportingFilter
            // 
            this.btnImportingFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImportingFilter.Location = new System.Drawing.Point(372, 7);
            this.btnImportingFilter.Name = "btnImportingFilter";
            this.btnImportingFilter.Size = new System.Drawing.Size(98, 30);
            this.btnImportingFilter.TabIndex = 43;
            this.btnImportingFilter.Text = "Lọc";
            this.btnImportingFilter.UseVisualStyleBackColor = true;
            this.btnImportingFilter.Click += new System.EventHandler(this.btnImportingFilter_Click);
            // 
            // dtpkImportingDate2
            // 
            this.dtpkImportingDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkImportingDate2.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkImportingDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkImportingDate2.Location = new System.Drawing.Point(643, 10);
            this.dtpkImportingDate2.Name = "dtpkImportingDate2";
            this.dtpkImportingDate2.Size = new System.Drawing.Size(192, 20);
            this.dtpkImportingDate2.TabIndex = 42;
            this.dtpkImportingDate2.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtpkImportingDate1
            // 
            this.dtpkImportingDate1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkImportingDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkImportingDate1.Location = new System.Drawing.Point(8, 10);
            this.dtpkImportingDate1.Name = "dtpkImportingDate1";
            this.dtpkImportingDate1.Size = new System.Drawing.Size(192, 20);
            this.dtpkImportingDate1.TabIndex = 41;
            this.dtpkImportingDate1.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtgvImportingBillList
            // 
            this.dtgvImportingBillList.AllowUserToAddRows = false;
            this.dtgvImportingBillList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvImportingBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvImportingBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvImportingBillList.Location = new System.Drawing.Point(8, 43);
            this.dtgvImportingBillList.MultiSelect = false;
            this.dtgvImportingBillList.Name = "dtgvImportingBillList";
            this.dtgvImportingBillList.ReadOnly = true;
            this.dtgvImportingBillList.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvImportingBillList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvImportingBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvImportingBillList.Size = new System.Drawing.Size(827, 371);
            this.dtgvImportingBillList.TabIndex = 40;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdbFilterByReceive);
            this.tabPage3.Controls.Add(this.rdbFilterByOrder);
            this.tabPage3.Controls.Add(this.btnExportOrder);
            this.tabPage3.Controls.Add(this.btnOrderFilter);
            this.tabPage3.Controls.Add(this.dtpkOrderDate2);
            this.tabPage3.Controls.Add(this.dtpkOrderDate1);
            this.tabPage3.Controls.Add(this.dtgvOrderList);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(843, 458);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Đặt hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExportOrder
            // 
            this.btnExportOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportOrder.Location = new System.Drawing.Point(372, 420);
            this.btnExportOrder.Name = "btnExportOrder";
            this.btnExportOrder.Size = new System.Drawing.Size(98, 30);
            this.btnExportOrder.TabIndex = 45;
            this.btnExportOrder.Text = "Xuất Excel";
            this.btnExportOrder.UseVisualStyleBackColor = true;
            this.btnExportOrder.Click += new System.EventHandler(this.btnExportOrder_Click);
            // 
            // btnOrderFilter
            // 
            this.btnOrderFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrderFilter.Location = new System.Drawing.Point(372, 7);
            this.btnOrderFilter.Name = "btnOrderFilter";
            this.btnOrderFilter.Size = new System.Drawing.Size(98, 30);
            this.btnOrderFilter.TabIndex = 43;
            this.btnOrderFilter.Text = "Lọc";
            this.btnOrderFilter.UseVisualStyleBackColor = true;
            this.btnOrderFilter.Click += new System.EventHandler(this.btnOrderFilter_Click);
            // 
            // dtpkOrderDate2
            // 
            this.dtpkOrderDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkOrderDate2.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkOrderDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkOrderDate2.Location = new System.Drawing.Point(643, 10);
            this.dtpkOrderDate2.Name = "dtpkOrderDate2";
            this.dtpkOrderDate2.Size = new System.Drawing.Size(192, 20);
            this.dtpkOrderDate2.TabIndex = 42;
            this.dtpkOrderDate2.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtpkOrderDate1
            // 
            this.dtpkOrderDate1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkOrderDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkOrderDate1.Location = new System.Drawing.Point(8, 10);
            this.dtpkOrderDate1.Name = "dtpkOrderDate1";
            this.dtpkOrderDate1.Size = new System.Drawing.Size(192, 20);
            this.dtpkOrderDate1.TabIndex = 41;
            this.dtpkOrderDate1.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtgvOrderList
            // 
            this.dtgvOrderList.AllowUserToAddRows = false;
            this.dtgvOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrderList.Location = new System.Drawing.Point(8, 43);
            this.dtgvOrderList.MultiSelect = false;
            this.dtgvOrderList.Name = "dtgvOrderList";
            this.dtgvOrderList.ReadOnly = true;
            this.dtgvOrderList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOrderList.Size = new System.Drawing.Size(827, 371);
            this.dtgvOrderList.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExportWarranty);
            this.tabPage1.Controls.Add(this.btnWarrantyFilter);
            this.tabPage1.Controls.Add(this.dtpkWarrantyDate2);
            this.tabPage1.Controls.Add(this.dtpkWarrantyDate1);
            this.tabPage1.Controls.Add(this.dtgvWarrantyBillList);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 458);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bảo hành";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExportWarranty
            // 
            this.btnExportWarranty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportWarranty.Location = new System.Drawing.Point(372, 420);
            this.btnExportWarranty.Name = "btnExportWarranty";
            this.btnExportWarranty.Size = new System.Drawing.Size(98, 30);
            this.btnExportWarranty.TabIndex = 45;
            this.btnExportWarranty.Text = "Xuất Excel";
            this.btnExportWarranty.UseVisualStyleBackColor = true;
            this.btnExportWarranty.Click += new System.EventHandler(this.btnExportWarranty_Click);
            // 
            // btnWarrantyFilter
            // 
            this.btnWarrantyFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWarrantyFilter.Location = new System.Drawing.Point(372, 7);
            this.btnWarrantyFilter.Name = "btnWarrantyFilter";
            this.btnWarrantyFilter.Size = new System.Drawing.Size(98, 30);
            this.btnWarrantyFilter.TabIndex = 43;
            this.btnWarrantyFilter.Text = "Lọc";
            this.btnWarrantyFilter.UseVisualStyleBackColor = true;
            this.btnWarrantyFilter.Click += new System.EventHandler(this.btnWarrantyFilter_Click);
            // 
            // dtpkWarrantyDate2
            // 
            this.dtpkWarrantyDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkWarrantyDate2.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkWarrantyDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkWarrantyDate2.Location = new System.Drawing.Point(643, 10);
            this.dtpkWarrantyDate2.Name = "dtpkWarrantyDate2";
            this.dtpkWarrantyDate2.Size = new System.Drawing.Size(192, 20);
            this.dtpkWarrantyDate2.TabIndex = 42;
            this.dtpkWarrantyDate2.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtpkWarrantyDate1
            // 
            this.dtpkWarrantyDate1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkWarrantyDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkWarrantyDate1.Location = new System.Drawing.Point(8, 10);
            this.dtpkWarrantyDate1.Name = "dtpkWarrantyDate1";
            this.dtpkWarrantyDate1.Size = new System.Drawing.Size(192, 20);
            this.dtpkWarrantyDate1.TabIndex = 41;
            this.dtpkWarrantyDate1.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtgvWarrantyBillList
            // 
            this.dtgvWarrantyBillList.AllowUserToAddRows = false;
            this.dtgvWarrantyBillList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvWarrantyBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvWarrantyBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWarrantyBillList.Location = new System.Drawing.Point(8, 43);
            this.dtgvWarrantyBillList.MultiSelect = false;
            this.dtgvWarrantyBillList.Name = "dtgvWarrantyBillList";
            this.dtgvWarrantyBillList.ReadOnly = true;
            this.dtgvWarrantyBillList.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvWarrantyBillList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvWarrantyBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvWarrantyBillList.Size = new System.Drawing.Size(827, 371);
            this.dtgvWarrantyBillList.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExportRepurchase);
            this.tabPage2.Controls.Add(this.btnRepurchaseFilter);
            this.tabPage2.Controls.Add(this.dtpkRepurchaseDate2);
            this.tabPage2.Controls.Add(this.dtpkRepurchaseDate1);
            this.tabPage2.Controls.Add(this.dtgvRepurchaseList);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mua lại";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportRepurchase
            // 
            this.btnExportRepurchase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportRepurchase.Location = new System.Drawing.Point(372, 420);
            this.btnExportRepurchase.Name = "btnExportRepurchase";
            this.btnExportRepurchase.Size = new System.Drawing.Size(98, 30);
            this.btnExportRepurchase.TabIndex = 45;
            this.btnExportRepurchase.Text = "Xuất Excel";
            this.btnExportRepurchase.UseVisualStyleBackColor = true;
            this.btnExportRepurchase.Click += new System.EventHandler(this.btnExportRepurchase_Click);
            // 
            // btnRepurchaseFilter
            // 
            this.btnRepurchaseFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRepurchaseFilter.Location = new System.Drawing.Point(372, 7);
            this.btnRepurchaseFilter.Name = "btnRepurchaseFilter";
            this.btnRepurchaseFilter.Size = new System.Drawing.Size(98, 30);
            this.btnRepurchaseFilter.TabIndex = 43;
            this.btnRepurchaseFilter.Text = "Lọc";
            this.btnRepurchaseFilter.UseVisualStyleBackColor = true;
            this.btnRepurchaseFilter.Click += new System.EventHandler(this.btnRepurchaseFilter_Click);
            // 
            // dtpkRepurchaseDate2
            // 
            this.dtpkRepurchaseDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkRepurchaseDate2.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkRepurchaseDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkRepurchaseDate2.Location = new System.Drawing.Point(643, 10);
            this.dtpkRepurchaseDate2.Name = "dtpkRepurchaseDate2";
            this.dtpkRepurchaseDate2.Size = new System.Drawing.Size(192, 20);
            this.dtpkRepurchaseDate2.TabIndex = 42;
            this.dtpkRepurchaseDate2.Value = new System.DateTime(2019, 6, 9, 0, 0, 0, 0);
            // 
            // dtpkRepurchaseDate1
            // 
            this.dtpkRepurchaseDate1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkRepurchaseDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkRepurchaseDate1.Location = new System.Drawing.Point(8, 10);
            this.dtpkRepurchaseDate1.Name = "dtpkRepurchaseDate1";
            this.dtpkRepurchaseDate1.Size = new System.Drawing.Size(192, 20);
            this.dtpkRepurchaseDate1.TabIndex = 41;
            this.dtpkRepurchaseDate1.Value = new System.DateTime(2019, 6, 9, 0, 0, 0, 0);
            // 
            // dtgvRepurchaseList
            // 
            this.dtgvRepurchaseList.AllowUserToAddRows = false;
            this.dtgvRepurchaseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRepurchaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvRepurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRepurchaseList.Location = new System.Drawing.Point(8, 43);
            this.dtgvRepurchaseList.MultiSelect = false;
            this.dtgvRepurchaseList.Name = "dtgvRepurchaseList";
            this.dtgvRepurchaseList.ReadOnly = true;
            this.dtgvRepurchaseList.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvRepurchaseList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvRepurchaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRepurchaseList.Size = new System.Drawing.Size(827, 371);
            this.dtgvRepurchaseList.TabIndex = 40;
            // 
            // tpSales
            // 
            this.tpSales.Controls.Add(this.btnExportSales);
            this.tpSales.Controls.Add(this.btnSalesFilter);
            this.tpSales.Controls.Add(this.dtpkSellingDate2);
            this.tpSales.Controls.Add(this.dtpkSellingDate1);
            this.tpSales.Controls.Add(this.dtgvSellingBillList);
            this.tpSales.Location = new System.Drawing.Point(4, 29);
            this.tpSales.Name = "tpSales";
            this.tpSales.Padding = new System.Windows.Forms.Padding(3);
            this.tpSales.Size = new System.Drawing.Size(843, 458);
            this.tpSales.TabIndex = 0;
            this.tpSales.Text = "Bán hàng";
            this.tpSales.UseVisualStyleBackColor = true;
            // 
            // btnExportSales
            // 
            this.btnExportSales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportSales.Location = new System.Drawing.Point(372, 421);
            this.btnExportSales.Name = "btnExportSales";
            this.btnExportSales.Size = new System.Drawing.Size(98, 30);
            this.btnExportSales.TabIndex = 50;
            this.btnExportSales.Text = "Xuất Excel";
            this.btnExportSales.UseVisualStyleBackColor = true;
            this.btnExportSales.Click += new System.EventHandler(this.btnExportSales_Click);
            // 
            // btnSalesFilter
            // 
            this.btnSalesFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalesFilter.Location = new System.Drawing.Point(372, 8);
            this.btnSalesFilter.Name = "btnSalesFilter";
            this.btnSalesFilter.Size = new System.Drawing.Size(98, 30);
            this.btnSalesFilter.TabIndex = 49;
            this.btnSalesFilter.Text = "Lọc";
            this.btnSalesFilter.UseVisualStyleBackColor = true;
            this.btnSalesFilter.Click += new System.EventHandler(this.btnSalesFilter_Click);
            // 
            // dtpkSellingDate2
            // 
            this.dtpkSellingDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkSellingDate2.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkSellingDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkSellingDate2.Location = new System.Drawing.Point(643, 11);
            this.dtpkSellingDate2.Name = "dtpkSellingDate2";
            this.dtpkSellingDate2.Size = new System.Drawing.Size(192, 20);
            this.dtpkSellingDate2.TabIndex = 48;
            this.dtpkSellingDate2.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtpkSellingDate1
            // 
            this.dtpkSellingDate1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpkSellingDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkSellingDate1.Location = new System.Drawing.Point(8, 11);
            this.dtpkSellingDate1.Name = "dtpkSellingDate1";
            this.dtpkSellingDate1.Size = new System.Drawing.Size(192, 20);
            this.dtpkSellingDate1.TabIndex = 47;
            this.dtpkSellingDate1.Value = new System.DateTime(2019, 4, 19, 8, 17, 19, 0);
            // 
            // dtgvSellingBillList
            // 
            this.dtgvSellingBillList.AllowUserToAddRows = false;
            this.dtgvSellingBillList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSellingBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvSellingBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSellingBillList.Location = new System.Drawing.Point(8, 44);
            this.dtgvSellingBillList.MultiSelect = false;
            this.dtgvSellingBillList.Name = "dtgvSellingBillList";
            this.dtgvSellingBillList.ReadOnly = true;
            this.dtgvSellingBillList.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvSellingBillList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvSellingBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSellingBillList.Size = new System.Drawing.Size(827, 371);
            this.dtgvSellingBillList.TabIndex = 46;
            // 
            // tcrlTrade
            // 
            this.tcrlTrade.Controls.Add(this.tpSales);
            this.tcrlTrade.Controls.Add(this.tabPage2);
            this.tcrlTrade.Controls.Add(this.tabPage1);
            this.tcrlTrade.Controls.Add(this.tabPage3);
            this.tcrlTrade.Controls.Add(this.tabPage4);
            this.tcrlTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcrlTrade.ItemSize = new System.Drawing.Size(58, 25);
            this.tcrlTrade.Location = new System.Drawing.Point(0, 0);
            this.tcrlTrade.Name = "tcrlTrade";
            this.tcrlTrade.SelectedIndex = 0;
            this.tcrlTrade.Size = new System.Drawing.Size(851, 491);
            this.tcrlTrade.TabIndex = 0;
            // 
            // rdbFilterByOrder
            // 
            this.rdbFilterByOrder.AutoSize = true;
            this.rdbFilterByOrder.Checked = true;
            this.rdbFilterByOrder.Location = new System.Drawing.Point(476, 5);
            this.rdbFilterByOrder.Name = "rdbFilterByOrder";
            this.rdbFilterByOrder.Size = new System.Drawing.Size(88, 17);
            this.rdbFilterByOrder.TabIndex = 46;
            this.rdbFilterByOrder.TabStop = true;
            this.rdbFilterByOrder.Text = "Lọc ngày đặt";
            this.rdbFilterByOrder.UseVisualStyleBackColor = true;
            // 
            // rdbFilterByReceive
            // 
            this.rdbFilterByReceive.AutoSize = true;
            this.rdbFilterByReceive.Location = new System.Drawing.Point(476, 25);
            this.rdbFilterByReceive.Name = "rdbFilterByReceive";
            this.rdbFilterByReceive.Size = new System.Drawing.Size(96, 17);
            this.rdbFilterByReceive.TabIndex = 47;
            this.rdbFilterByReceive.Text = "Lọc ngày nhận";
            this.rdbFilterByReceive.UseVisualStyleBackColor = true;
            // 
            // frmTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 491);
            this.Controls.Add(this.tcrlTrade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách giao dịch mua bán";
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImportingBillList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWarrantyBillList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRepurchaseList)).EndInit();
            this.tpSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSellingBillList)).EndInit();
            this.tcrlTrade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpSales;
        private System.Windows.Forms.TabControl tcrlTrade;
        private System.Windows.Forms.Button btnWarrantyFilter;
        private System.Windows.Forms.DateTimePicker dtpkWarrantyDate2;
        private System.Windows.Forms.DateTimePicker dtpkWarrantyDate1;
        private System.Windows.Forms.DataGridView dtgvWarrantyBillList;
        private System.Windows.Forms.Button btnRepurchaseFilter;
        private System.Windows.Forms.DateTimePicker dtpkRepurchaseDate2;
        private System.Windows.Forms.DateTimePicker dtpkRepurchaseDate1;
        private System.Windows.Forms.DataGridView dtgvRepurchaseList;
        private System.Windows.Forms.Button btnOrderFilter;
        private System.Windows.Forms.DateTimePicker dtpkOrderDate2;
        private System.Windows.Forms.DateTimePicker dtpkOrderDate1;
        private System.Windows.Forms.DataGridView dtgvOrderList;
        private System.Windows.Forms.Button btnImportingFilter;
        private System.Windows.Forms.DateTimePicker dtpkImportingDate2;
        private System.Windows.Forms.DateTimePicker dtpkImportingDate1;
        private System.Windows.Forms.DataGridView dtgvImportingBillList;
        private System.Windows.Forms.Button btnExportImporting;
        private System.Windows.Forms.Button btnExportRepurchase;
        private System.Windows.Forms.Button btnExportWarranty;
        private System.Windows.Forms.Button btnExportOrder;
        private System.Windows.Forms.Button btnExportSales;
        private System.Windows.Forms.Button btnSalesFilter;
        private System.Windows.Forms.DateTimePicker dtpkSellingDate2;
        private System.Windows.Forms.DateTimePicker dtpkSellingDate1;
        private System.Windows.Forms.DataGridView dtgvSellingBillList;
        private System.Windows.Forms.RadioButton rdbFilterByReceive;
        private System.Windows.Forms.RadioButton rdbFilterByOrder;
    }
}