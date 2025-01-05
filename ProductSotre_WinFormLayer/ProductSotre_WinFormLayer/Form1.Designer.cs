namespace ProductSotre_WinFormLayer
{
    partial class Form1
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
            this.TpAdminSide = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TpUserSide = new System.Windows.Forms.TabPage();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TpAdminSide.SuspendLayout();
            this.TpUserSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TpAdminSide
            // 
            this.TpAdminSide.Controls.Add(this.tabPage1);
            this.TpAdminSide.Controls.Add(this.TpUserSide);
            this.TpAdminSide.Location = new System.Drawing.Point(3, 12);
            this.TpAdminSide.Name = "TpAdminSide";
            this.TpAdminSide.SelectedIndex = 0;
            this.TpAdminSide.Size = new System.Drawing.Size(1613, 695);
            this.TpAdminSide.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1605, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TpUserSide
            // 
            this.TpUserSide.Controls.Add(this.dgvMain);
            this.TpUserSide.Location = new System.Drawing.Point(4, 29);
            this.TpUserSide.Name = "TpUserSide";
            this.TpUserSide.Padding = new System.Windows.Forms.Padding(3);
            this.TpUserSide.Size = new System.Drawing.Size(1605, 662);
            this.TpUserSide.TabIndex = 1;
            this.TpUserSide.Text = "tabPage2";
            this.TpUserSide.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Category,
            this.InStock,
            this.Title,
            this.Description,
            this.Price,
            this.Image,
            this.Quantity,
            this.Select});
            this.dgvMain.Location = new System.Drawing.Point(3, 110);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 28;
            this.dgvMain.Size = new System.Drawing.Size(1595, 159);
            this.dgvMain.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 150;
            // 
            // InStock
            // 
            this.InStock.HeaderText = "In Stock";
            this.InStock.MinimumWidth = 8;
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            this.InStock.Width = 150;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 8;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 774);
            this.Controls.Add(this.TpAdminSide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TpAdminSide.ResumeLayout(false);
            this.TpUserSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TpAdminSide;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TpUserSide;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
    }
}

