namespace ProductSotre_WindowsFormLayer.User
{
    partial class CheckOutForm
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtShippingAddress = new System.Windows.Forms.TextBox();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblTotalPriceCount = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 181);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(868, 332);
            this.dgvProducts.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(37, 34);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(178, 32);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // txtShippingAddress
            // 
            this.txtShippingAddress.Location = new System.Drawing.Point(346, 121);
            this.txtShippingAddress.Multiline = true;
            this.txtShippingAddress.Name = "txtShippingAddress";
            this.txtShippingAddress.Size = new System.Drawing.Size(280, 42);
            this.txtShippingAddress.TabIndex = 3;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingAddress.Location = new System.Drawing.Point(37, 121);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(271, 32);
            this.lblShippingAddress.TabIndex = 2;
            this.lblShippingAddress.Text = "Shipping Address :";
            // 
            // lblTotalPriceCount
            // 
            this.lblTotalPriceCount.AutoSize = true;
            this.lblTotalPriceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceCount.Location = new System.Drawing.Point(250, 34);
            this.lblTotalPriceCount.Name = "lblTotalPriceCount";
            this.lblTotalPriceCount.Size = new System.Drawing.Size(48, 32);
            this.lblTotalPriceCount.TabIndex = 2;
            this.lblTotalPriceCount.Text = "0$";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(617, 548);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(263, 73);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 660);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtShippingAddress);
            this.Controls.Add(this.lblShippingAddress);
            this.Controls.Add(this.lblTotalPriceCount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.dgvProducts);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtShippingAddress;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.Label lblTotalPriceCount;
        private System.Windows.Forms.Button btnConfirm;
    }
}