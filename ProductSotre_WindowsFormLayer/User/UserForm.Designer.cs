namespace ProductSotre_WindowsFormLayer.User
{
    partial class UserForm
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
            this.tbxMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblOrdersHeader = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tbxMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMain
            // 
            this.tbxMain.Controls.Add(this.tabPage1);
            this.tbxMain.Controls.Add(this.tabPage2);
            this.tbxMain.Location = new System.Drawing.Point(43, 139);
            this.tbxMain.Name = "tbxMain";
            this.tbxMain.SelectedIndex = 0;
            this.tbxMain.Size = new System.Drawing.Size(1388, 602);
            this.tbxMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCheckOut);
            this.tabPage1.Controls.Add(this.dgvProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1380, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.Info;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(1107, 133);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(254, 77);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(0, 216);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1374, 347);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvProducts_CellValidating_1);
            this.dgvProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblOrdersHeader);
            this.tabPage2.Controls.Add(this.dgvOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1380, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblOrdersHeader
            // 
            this.lblOrdersHeader.AutoSize = true;
            this.lblOrdersHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblOrdersHeader.Location = new System.Drawing.Point(517, 41);
            this.lblOrdersHeader.Name = "lblOrdersHeader";
            this.lblOrdersHeader.Size = new System.Drawing.Size(353, 46);
            this.lblOrdersHeader.TabIndex = 1;
            this.lblOrdersHeader.Text = "Your Orders Info !";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(21, 139);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(1337, 424);
            this.dgvOrders.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 899);
            this.Controls.Add(this.tbxMain);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tbxMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbxMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblOrdersHeader;
    }
}