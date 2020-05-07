namespace TTCN2
{
    partial class frmCatalogueOptions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogueOptions));
            this.dtgvCatalogueList = new System.Windows.Forms.DataGridView();
            this.btnSaveInsert = new System.Windows.Forms.Button();
            this.btnUpdateCatalogue = new System.Windows.Forms.Button();
            this.btnDeleteCatalogue = new System.Windows.Forms.Button();
            this.btnEditCatalogue = new System.Windows.Forms.Button();
            this.btnInsertCatalogue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbCatalogueInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCatalogueCount = new System.Windows.Forms.Label();
            this.txtCatalogueID = new System.Windows.Forms.TextBox();
            this.txtCatalogueName = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatalogueList)).BeginInit();
            this.grbCatalogueInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCatalogueList
            // 
            this.dtgvCatalogueList.AllowUserToAddRows = false;
            this.dtgvCatalogueList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCatalogueList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCatalogueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCatalogueList.Location = new System.Drawing.Point(12, 57);
            this.dtgvCatalogueList.MultiSelect = false;
            this.dtgvCatalogueList.Name = "dtgvCatalogueList";
            this.dtgvCatalogueList.ReadOnly = true;
            this.dtgvCatalogueList.RowHeadersVisible = false;
            this.dtgvCatalogueList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCatalogueList.Size = new System.Drawing.Size(474, 351);
            this.dtgvCatalogueList.TabIndex = 0;
            // 
            // btnSaveInsert
            // 
            this.btnSaveInsert.Enabled = false;
            this.btnSaveInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveInsert.Image")));
            this.btnSaveInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInsert.Location = new System.Drawing.Point(108, 20);
            this.btnSaveInsert.Name = "btnSaveInsert";
            this.btnSaveInsert.Size = new System.Drawing.Size(90, 31);
            this.btnSaveInsert.TabIndex = 16;
            this.btnSaveInsert.Text = "Lưu Mới";
            this.btnSaveInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInsert.UseVisualStyleBackColor = true;
            this.btnSaveInsert.Click += new System.EventHandler(this.btnSaveInsert_Click);
            // 
            // btnUpdateCatalogue
            // 
            this.btnUpdateCatalogue.Enabled = false;
            this.btnUpdateCatalogue.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCatalogue.Image")));
            this.btnUpdateCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCatalogue.Location = new System.Drawing.Point(396, 20);
            this.btnUpdateCatalogue.Name = "btnUpdateCatalogue";
            this.btnUpdateCatalogue.Size = new System.Drawing.Size(90, 31);
            this.btnUpdateCatalogue.TabIndex = 19;
            this.btnUpdateCatalogue.Text = "Cập nhật";
            this.btnUpdateCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCatalogue.UseVisualStyleBackColor = true;
            this.btnUpdateCatalogue.Click += new System.EventHandler(this.btnUpdateCatalogue_Click);
            // 
            // btnDeleteCatalogue
            // 
            this.btnDeleteCatalogue.Enabled = false;
            this.btnDeleteCatalogue.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCatalogue.Image")));
            this.btnDeleteCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCatalogue.Location = new System.Drawing.Point(204, 20);
            this.btnDeleteCatalogue.Name = "btnDeleteCatalogue";
            this.btnDeleteCatalogue.Size = new System.Drawing.Size(90, 31);
            this.btnDeleteCatalogue.TabIndex = 17;
            this.btnDeleteCatalogue.Text = "Xoá ";
            this.btnDeleteCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCatalogue.UseVisualStyleBackColor = true;
            this.btnDeleteCatalogue.Click += new System.EventHandler(this.btnDeleteCatalogue_Click);
            // 
            // btnEditCatalogue
            // 
            this.btnEditCatalogue.Enabled = false;
            this.btnEditCatalogue.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCatalogue.Image")));
            this.btnEditCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCatalogue.Location = new System.Drawing.Point(300, 20);
            this.btnEditCatalogue.Name = "btnEditCatalogue";
            this.btnEditCatalogue.Size = new System.Drawing.Size(90, 31);
            this.btnEditCatalogue.TabIndex = 18;
            this.btnEditCatalogue.Text = "Chỉnh sửa";
            this.btnEditCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCatalogue.UseVisualStyleBackColor = true;
            this.btnEditCatalogue.Click += new System.EventHandler(this.btnEditCatalogue_Click);
            // 
            // btnInsertCatalogue
            // 
            this.btnInsertCatalogue.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertCatalogue.Image")));
            this.btnInsertCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCatalogue.Location = new System.Drawing.Point(12, 20);
            this.btnInsertCatalogue.Name = "btnInsertCatalogue";
            this.btnInsertCatalogue.Size = new System.Drawing.Size(90, 31);
            this.btnInsertCatalogue.TabIndex = 15;
            this.btnInsertCatalogue.Text = "Thêm mới";
            this.btnInsertCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertCatalogue.UseVisualStyleBackColor = true;
            this.btnInsertCatalogue.Click += new System.EventHandler(this.btnInsertCatalogue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(701, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(701, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 29);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbCatalogueInfo
            // 
            this.grbCatalogueInfo.Controls.Add(this.label4);
            this.grbCatalogueInfo.Controls.Add(this.label3);
            this.grbCatalogueInfo.Controls.Add(this.label2);
            this.grbCatalogueInfo.Controls.Add(this.txtMaterial);
            this.grbCatalogueInfo.Controls.Add(this.txtCatalogueName);
            this.grbCatalogueInfo.Controls.Add(this.txtCatalogueID);
            this.grbCatalogueInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbCatalogueInfo.Enabled = false;
            this.grbCatalogueInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCatalogueInfo.Location = new System.Drawing.Point(492, 57);
            this.grbCatalogueInfo.Name = "grbCatalogueInfo";
            this.grbCatalogueInfo.Size = new System.Drawing.Size(296, 351);
            this.grbCatalogueInfo.TabIndex = 33;
            this.grbCatalogueInfo.TabStop = false;
            this.grbCatalogueInfo.Text = "THÔNG TIN LOẠI SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "TỔNG SỐ LOẠI:";
            // 
            // lblCatalogueCount
            // 
            this.lblCatalogueCount.AutoSize = true;
            this.lblCatalogueCount.ForeColor = System.Drawing.Color.Black;
            this.lblCatalogueCount.Location = new System.Drawing.Point(104, 414);
            this.lblCatalogueCount.Name = "lblCatalogueCount";
            this.lblCatalogueCount.Size = new System.Drawing.Size(13, 13);
            this.lblCatalogueCount.TabIndex = 35;
            this.lblCatalogueCount.Text = "0";
            // 
            // txtCatalogueID
            // 
            this.txtCatalogueID.Enabled = false;
            this.txtCatalogueID.Location = new System.Drawing.Point(84, 30);
            this.txtCatalogueID.Name = "txtCatalogueID";
            this.txtCatalogueID.Size = new System.Drawing.Size(206, 22);
            this.txtCatalogueID.TabIndex = 0;
            // 
            // txtCatalogueName
            // 
            this.txtCatalogueName.Location = new System.Drawing.Point(84, 58);
            this.txtCatalogueName.Name = "txtCatalogueName";
            this.txtCatalogueName.Size = new System.Drawing.Size(206, 22);
            this.txtCatalogueName.TabIndex = 1;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(84, 86);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(206, 22);
            this.txtMaterial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chất liệu:";
            // 
            // frmCatalogueOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.lblCatalogueCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbCatalogueInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveInsert);
            this.Controls.Add(this.btnUpdateCatalogue);
            this.Controls.Add(this.btnDeleteCatalogue);
            this.Controls.Add(this.btnEditCatalogue);
            this.Controls.Add(this.btnInsertCatalogue);
            this.Controls.Add(this.dtgvCatalogueList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCatalogueOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân loại sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatalogueList)).EndInit();
            this.grbCatalogueInfo.ResumeLayout(false);
            this.grbCatalogueInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCatalogueList;
        private System.Windows.Forms.Button btnSaveInsert;
        private System.Windows.Forms.Button btnUpdateCatalogue;
        private System.Windows.Forms.Button btnDeleteCatalogue;
        private System.Windows.Forms.Button btnEditCatalogue;
        private System.Windows.Forms.Button btnInsertCatalogue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbCatalogueInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCatalogueCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtCatalogueName;
        private System.Windows.Forms.TextBox txtCatalogueID;
    }
}