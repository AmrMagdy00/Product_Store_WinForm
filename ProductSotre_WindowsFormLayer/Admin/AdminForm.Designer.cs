namespace ProductSotre_WindowsFormLayer.Admin
{
    partial class AdminForm
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
            this.tpxMain = new System.Windows.Forms.TabControl();
            this.tPProducts = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cxsProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tpxMain.SuspendLayout();
            this.tPProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cxsProducts.SuspendLayout();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tpxMain
            // 
            this.tpxMain.Controls.Add(this.tPProducts);
            this.tpxMain.Controls.Add(this.tpOrders);
            this.tpxMain.Location = new System.Drawing.Point(45, 40);
            this.tpxMain.Name = "tpxMain";
            this.tpxMain.SelectedIndex = 0;
            this.tpxMain.Size = new System.Drawing.Size(1517, 710);
            this.tpxMain.TabIndex = 0;
            this.tpxMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tPProducts
            // 
            this.tPProducts.BackColor = System.Drawing.Color.Transparent;
            this.tPProducts.Controls.Add(this.dgvProducts);
            this.tPProducts.Location = new System.Drawing.Point(4, 29);
            this.tPProducts.Name = "tPProducts";
            this.tPProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tPProducts.Size = new System.Drawing.Size(1509, 677);
            this.tPProducts.TabIndex = 0;
            this.tPProducts.Text = "Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.cxsProducts;
            this.dgvProducts.Location = new System.Drawing.Point(54, 214);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1402, 445);
            this.dgvProducts.TabIndex = 0;
            // 
            // cxsProducts
            // 
            this.cxsProducts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cxsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.cxsProducts.Name = "cxsProducts";
            this.cxsProducts.Size = new System.Drawing.Size(143, 132);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 32);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 32);
            this.toolStripMenuItem2.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.dgvOrders);
            this.tpOrders.Location = new System.Drawing.Point(4, 29);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(1509, 677);
            this.tpOrders.TabIndex = 1;
            this.tpOrders.Text = "Orders";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(15, 201);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(1474, 470);
            this.dgvOrders.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 762);
            this.Controls.Add(this.tpxMain);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tpxMain.ResumeLayout(false);
            this.tPProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cxsProducts.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpxMain;
        private System.Windows.Forms.TabPage tPProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.ContextMenuStrip cxsProducts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}