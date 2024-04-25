namespace ParkingLotManagement
{
    partial class FrmParkingSpotList
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
            this.dtgvParkingSpotList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvParkingSpotList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvParkingSpotList
            // 
            this.dtgvParkingSpotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvParkingSpotList.Location = new System.Drawing.Point(37, 45);
            this.dtgvParkingSpotList.Name = "dtgvParkingSpotList";
            this.dtgvParkingSpotList.RowHeadersWidth = 51;
            this.dtgvParkingSpotList.RowTemplate.Height = 24;
            this.dtgvParkingSpotList.Size = new System.Drawing.Size(732, 322);
            this.dtgvParkingSpotList.TabIndex = 0;
            this.dtgvParkingSpotList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvParkingSpotList_CellDoubleClick);
            // 
            // FrmParkingSpotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvParkingSpotList);
            this.Name = "FrmParkingSpotList";
            this.Text = "Parking SpotList";
            this.Load += new System.EventHandler(this.FrmParkingSpotList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvParkingSpotList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvParkingSpotList;
    }
}