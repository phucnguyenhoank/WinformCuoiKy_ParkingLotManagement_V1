namespace ParkingLotManagement
{
    partial class FrmCustomerList
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
            this.dtgvCustomerList = new System.Windows.Forms.DataGridView();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnResetCustomerList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCustomerList
            // 
            this.dtgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomerList.Location = new System.Drawing.Point(28, 47);
            this.dtgvCustomerList.Name = "dtgvCustomerList";
            this.dtgvCustomerList.RowHeadersWidth = 51;
            this.dtgvCustomerList.RowTemplate.Height = 24;
            this.dtgvCustomerList.Size = new System.Drawing.Size(864, 361);
            this.dtgvCustomerList.TabIndex = 0;
            this.dtgvCustomerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomerList_CellDoubleClick);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(755, 414);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(137, 23);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "New customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnResetCustomerList
            // 
            this.btnResetCustomerList.Location = new System.Drawing.Point(368, 497);
            this.btnResetCustomerList.Name = "btnResetCustomerList";
            this.btnResetCustomerList.Size = new System.Drawing.Size(137, 23);
            this.btnResetCustomerList.TabIndex = 2;
            this.btnResetCustomerList.Text = "Reset";
            this.btnResetCustomerList.UseVisualStyleBackColor = true;
            this.btnResetCustomerList.Click += new System.EventHandler(this.btnResetCustomerList_Click);
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 532);
            this.Controls.Add(this.btnResetCustomerList);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.dtgvCustomerList);
            this.Name = "FrmCustomerList";
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCustomerList;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnResetCustomerList;
    }
}