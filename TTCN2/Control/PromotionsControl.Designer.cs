namespace TTCN2
{
    partial class PromotionsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromotionsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvPromotionsList = new System.Windows.Forms.DataGridView();
            this.grbPromotionInfo = new System.Windows.Forms.GroupBox();
            this.nmrDiscount = new System.Windows.Forms.NumericUpDown();
            this.dtpkEndingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkStartingDate = new System.Windows.Forms.DateTimePicker();
            this.txtGift = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPromotionID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeletePromotion = new System.Windows.Forms.Button();
            this.btnEditPromotion = new System.Windows.Forms.Button();
            this.btnInsertPromotion = new System.Windows.Forms.Button();
            this.btnSaveInsert = new System.Windows.Forms.Button();
            this.btnUpdatePromotion = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPromotionsList)).BeginInit();
            this.grbPromotionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHƯƠNG TRÌNH KHUYẾN MÃI";
            // 
            // dtgvPromotionsList
            // 
            this.dtgvPromotionsList.AllowUserToAddRows = false;
            this.dtgvPromotionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPromotionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPromotionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPromotionsList.Location = new System.Drawing.Point(3, 43);
            this.dtgvPromotionsList.MultiSelect = false;
            this.dtgvPromotionsList.Name = "dtgvPromotionsList";
            this.dtgvPromotionsList.ReadOnly = true;
            this.dtgvPromotionsList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvPromotionsList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvPromotionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPromotionsList.Size = new System.Drawing.Size(748, 423);
            this.dtgvPromotionsList.TabIndex = 3;
            // 
            // grbPromotionInfo
            // 
            this.grbPromotionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPromotionInfo.Controls.Add(this.btnProductList);
            this.grbPromotionInfo.Controls.Add(this.nmrDiscount);
            this.grbPromotionInfo.Controls.Add(this.dtpkEndingDate);
            this.grbPromotionInfo.Controls.Add(this.dtpkStartingDate);
            this.grbPromotionInfo.Controls.Add(this.txtGift);
            this.grbPromotionInfo.Controls.Add(this.label6);
            this.grbPromotionInfo.Controls.Add(this.label5);
            this.grbPromotionInfo.Controls.Add(this.label4);
            this.grbPromotionInfo.Controls.Add(this.label3);
            this.grbPromotionInfo.Controls.Add(this.txtPromotionID);
            this.grbPromotionInfo.Controls.Add(this.label2);
            this.grbPromotionInfo.Enabled = false;
            this.grbPromotionInfo.Location = new System.Drawing.Point(757, 43);
            this.grbPromotionInfo.Name = "grbPromotionInfo";
            this.grbPromotionInfo.Size = new System.Drawing.Size(355, 423);
            this.grbPromotionInfo.TabIndex = 5;
            this.grbPromotionInfo.TabStop = false;
            this.grbPromotionInfo.Text = "Chương trình khuyến mãi";
            // 
            // nmrDiscount
            // 
            this.nmrDiscount.Location = new System.Drawing.Point(89, 113);
            this.nmrDiscount.Name = "nmrDiscount";
            this.nmrDiscount.Size = new System.Drawing.Size(260, 20);
            this.nmrDiscount.TabIndex = 3;
            this.nmrDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpkEndingDate
            // 
            this.dtpkEndingDate.Location = new System.Drawing.Point(89, 87);
            this.dtpkEndingDate.Name = "dtpkEndingDate";
            this.dtpkEndingDate.Size = new System.Drawing.Size(260, 20);
            this.dtpkEndingDate.TabIndex = 2;
            // 
            // dtpkStartingDate
            // 
            this.dtpkStartingDate.Location = new System.Drawing.Point(89, 61);
            this.dtpkStartingDate.Name = "dtpkStartingDate";
            this.dtpkStartingDate.Size = new System.Drawing.Size(260, 20);
            this.dtpkStartingDate.TabIndex = 2;
            // 
            // txtGift
            // 
            this.txtGift.Location = new System.Drawing.Point(89, 139);
            this.txtGift.Name = "txtGift";
            this.txtGift.Size = new System.Drawing.Size(260, 20);
            this.txtGift.TabIndex = 1;
            this.txtGift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quà:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khuyến mãi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // txtPromotionID
            // 
            this.txtPromotionID.Enabled = false;
            this.txtPromotionID.Location = new System.Drawing.Point(89, 35);
            this.txtPromotionID.Name = "txtPromotionID";
            this.txtPromotionID.Size = new System.Drawing.Size(260, 20);
            this.txtPromotionID.TabIndex = 1;
            this.txtPromotionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã CTKM:";
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(664, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeletePromotion
            // 
            this.btnDeletePromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletePromotion.Enabled = false;
            this.btnDeletePromotion.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePromotion.Image")));
            this.btnDeletePromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePromotion.Location = new System.Drawing.Point(195, 471);
            this.btnDeletePromotion.Name = "btnDeletePromotion";
            this.btnDeletePromotion.Size = new System.Drawing.Size(90, 31);
            this.btnDeletePromotion.TabIndex = 42;
            this.btnDeletePromotion.Text = "Xoá";
            this.btnDeletePromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePromotion.UseVisualStyleBackColor = true;
            this.btnDeletePromotion.Click += new System.EventHandler(this.btnDeletePromotion_Click);
            // 
            // btnEditPromotion
            // 
            this.btnEditPromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditPromotion.Enabled = false;
            this.btnEditPromotion.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPromotion.Image")));
            this.btnEditPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPromotion.Location = new System.Drawing.Point(291, 471);
            this.btnEditPromotion.Name = "btnEditPromotion";
            this.btnEditPromotion.Size = new System.Drawing.Size(90, 31);
            this.btnEditPromotion.TabIndex = 43;
            this.btnEditPromotion.Text = "Chỉnh sửa";
            this.btnEditPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditPromotion.UseVisualStyleBackColor = true;
            this.btnEditPromotion.Click += new System.EventHandler(this.btnEditPromotion_Click);
            // 
            // btnInsertPromotion
            // 
            this.btnInsertPromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsertPromotion.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertPromotion.Image")));
            this.btnInsertPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertPromotion.Location = new System.Drawing.Point(3, 471);
            this.btnInsertPromotion.Name = "btnInsertPromotion";
            this.btnInsertPromotion.Size = new System.Drawing.Size(90, 31);
            this.btnInsertPromotion.TabIndex = 41;
            this.btnInsertPromotion.Text = "Thêm mới";
            this.btnInsertPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertPromotion.UseVisualStyleBackColor = true;
            this.btnInsertPromotion.Click += new System.EventHandler(this.btnInsertPromotion_Click);
            // 
            // btnSaveInsert
            // 
            this.btnSaveInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveInsert.Enabled = false;
            this.btnSaveInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveInsert.Image")));
            this.btnSaveInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInsert.Location = new System.Drawing.Point(99, 471);
            this.btnSaveInsert.Name = "btnSaveInsert";
            this.btnSaveInsert.Size = new System.Drawing.Size(90, 31);
            this.btnSaveInsert.TabIndex = 45;
            this.btnSaveInsert.Text = "Lưu Mới";
            this.btnSaveInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInsert.UseVisualStyleBackColor = true;
            this.btnSaveInsert.Click += new System.EventHandler(this.btnSaveInsert_Click);
            // 
            // btnUpdatePromotion
            // 
            this.btnUpdatePromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdatePromotion.Enabled = false;
            this.btnUpdatePromotion.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePromotion.Image")));
            this.btnUpdatePromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePromotion.Location = new System.Drawing.Point(387, 471);
            this.btnUpdatePromotion.Name = "btnUpdatePromotion";
            this.btnUpdatePromotion.Size = new System.Drawing.Size(90, 31);
            this.btnUpdatePromotion.TabIndex = 46;
            this.btnUpdatePromotion.Text = "Cập nhật";
            this.btnUpdatePromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatePromotion.UseVisualStyleBackColor = true;
            this.btnUpdatePromotion.Click += new System.EventHandler(this.btnUpdatePromotion_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(89, 165);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(260, 23);
            this.btnProductList.TabIndex = 4;
            this.btnProductList.Text = "Danh sách sản phẩm";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // PromotionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveInsert);
            this.Controls.Add(this.btnUpdatePromotion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeletePromotion);
            this.Controls.Add(this.btnEditPromotion);
            this.Controls.Add(this.btnInsertPromotion);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbPromotionInfo);
            this.Controls.Add(this.dtgvPromotionsList);
            this.Controls.Add(this.label1);
            this.Name = "PromotionsControl";
            this.Size = new System.Drawing.Size(1115, 504);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPromotionsList)).EndInit();
            this.grbPromotionInfo.ResumeLayout(false);
            this.grbPromotionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPromotionsList;
        private System.Windows.Forms.GroupBox grbPromotionInfo;
        private System.Windows.Forms.NumericUpDown nmrDiscount;
        private System.Windows.Forms.DateTimePicker dtpkEndingDate;
        private System.Windows.Forms.DateTimePicker dtpkStartingDate;
        private System.Windows.Forms.TextBox txtGift;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPromotionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeletePromotion;
        private System.Windows.Forms.Button btnEditPromotion;
        private System.Windows.Forms.Button btnInsertPromotion;
        private System.Windows.Forms.Button btnSaveInsert;
        private System.Windows.Forms.Button btnUpdatePromotion;
        private System.Windows.Forms.Button btnProductList;
    }
}
