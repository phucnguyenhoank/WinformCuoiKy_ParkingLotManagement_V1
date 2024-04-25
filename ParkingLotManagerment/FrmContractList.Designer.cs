namespace ParkingLotManagement
{
    partial class FrmContractList
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
            this.dtgvContractList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContractList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvContractList
            // 
            this.dtgvContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContractList.Location = new System.Drawing.Point(57, 42);
            this.dtgvContractList.Name = "dtgvContractList";
            this.dtgvContractList.RowHeadersWidth = 51;
            this.dtgvContractList.RowTemplate.Height = 24;
            this.dtgvContractList.Size = new System.Drawing.Size(840, 442);
            this.dtgvContractList.TabIndex = 0;
            // 
            // FrmContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 543);
            this.Controls.Add(this.dtgvContractList);
            this.Name = "FrmContractList";
            this.Text = "Contract List";
            this.Load += new System.EventHandler(this.FrmContractList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContractList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvContractList;
    }
}