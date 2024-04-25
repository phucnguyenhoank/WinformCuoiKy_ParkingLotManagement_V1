namespace ParkingLotManagement
{
    partial class FrmVehicleList
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
            this.dtgvVehicleList = new System.Windows.Forms.DataGridView();
            this.btnResetVehicleList = new System.Windows.Forms.Button();
            this.btnNewVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVehicleList
            // 
            this.dtgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVehicleList.Location = new System.Drawing.Point(57, 94);
            this.dtgvVehicleList.Name = "dtgvVehicleList";
            this.dtgvVehicleList.RowHeadersWidth = 51;
            this.dtgvVehicleList.RowTemplate.Height = 24;
            this.dtgvVehicleList.Size = new System.Drawing.Size(656, 272);
            this.dtgvVehicleList.TabIndex = 0;
            this.dtgvVehicleList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVehicleList_CellDoubleClick);
            // 
            // btnResetVehicleList
            // 
            this.btnResetVehicleList.Location = new System.Drawing.Point(312, 394);
            this.btnResetVehicleList.Name = "btnResetVehicleList";
            this.btnResetVehicleList.Size = new System.Drawing.Size(75, 23);
            this.btnResetVehicleList.TabIndex = 1;
            this.btnResetVehicleList.Text = "reset";
            this.btnResetVehicleList.UseVisualStyleBackColor = true;
            this.btnResetVehicleList.Click += new System.EventHandler(this.btnResetVehicleList_Click);
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Location = new System.Drawing.Point(600, 372);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(100, 23);
            this.btnNewVehicle.TabIndex = 2;
            this.btnNewVehicle.Text = "new vehicle";
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // FrmVehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewVehicle);
            this.Controls.Add(this.btnResetVehicleList);
            this.Controls.Add(this.dtgvVehicleList);
            this.Name = "FrmVehicleList";
            this.Text = "Vehicle List";
            this.Load += new System.EventHandler(this.FrmVehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVehicleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVehicleList;
        private System.Windows.Forms.Button btnResetVehicleList;
        private System.Windows.Forms.Button btnNewVehicle;
    }
}