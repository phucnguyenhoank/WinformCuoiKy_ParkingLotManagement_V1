namespace ParkingLotManagement
{
    partial class FrmAddVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtOccupancy = new System.Windows.Forms.TextBox();
            this.cbTypeOfVehicle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.cbCustomerIDAddVehicle = new System.Windows.Forms.ComboBox();
            this.cbParkingSpotIDAddVehicle = new System.Windows.Forms.ComboBox();
            this.btnCustomerMoreDetail = new System.Windows.Forms.Button();
            this.btnParkingSpotMoreDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Plate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occupancy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type Of Vehicle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parking Spot ID";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(254, 103);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleID.TabIndex = 6;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(268, 148);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(100, 22);
            this.txtLicensePlate.TabIndex = 7;
            // 
            // txtOccupancy
            // 
            this.txtOccupancy.Location = new System.Drawing.Point(268, 198);
            this.txtOccupancy.Name = "txtOccupancy";
            this.txtOccupancy.Size = new System.Drawing.Size(100, 22);
            this.txtOccupancy.TabIndex = 8;
            // 
            // cbTypeOfVehicle
            // 
            this.cbTypeOfVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfVehicle.FormattingEnabled = true;
            this.cbTypeOfVehicle.Location = new System.Drawing.Point(313, 244);
            this.cbTypeOfVehicle.Name = "cbTypeOfVehicle";
            this.cbTypeOfVehicle.Size = new System.Drawing.Size(121, 24);
            this.cbTypeOfVehicle.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Có thể thêm nút chọn Customer (tạo một button hiển thị ds Customer và chọn)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(579, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tương tự với Parking Spot, nhưng cân nhắc việc có cần phải có chức năng thêm bãi " +
    "đỗ hay không";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(500, 525);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddVehicle.TabIndex = 14;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // cbCustomerIDAddVehicle
            // 
            this.cbCustomerIDAddVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerIDAddVehicle.FormattingEnabled = true;
            this.cbCustomerIDAddVehicle.Location = new System.Drawing.Point(253, 304);
            this.cbCustomerIDAddVehicle.Name = "cbCustomerIDAddVehicle";
            this.cbCustomerIDAddVehicle.Size = new System.Drawing.Size(121, 24);
            this.cbCustomerIDAddVehicle.TabIndex = 15;
            // 
            // cbParkingSpotIDAddVehicle
            // 
            this.cbParkingSpotIDAddVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParkingSpotIDAddVehicle.FormattingEnabled = true;
            this.cbParkingSpotIDAddVehicle.Location = new System.Drawing.Point(254, 361);
            this.cbParkingSpotIDAddVehicle.Name = "cbParkingSpotIDAddVehicle";
            this.cbParkingSpotIDAddVehicle.Size = new System.Drawing.Size(121, 24);
            this.cbParkingSpotIDAddVehicle.TabIndex = 16;
            // 
            // btnCustomerMoreDetail
            // 
            this.btnCustomerMoreDetail.Location = new System.Drawing.Point(391, 305);
            this.btnCustomerMoreDetail.Name = "btnCustomerMoreDetail";
            this.btnCustomerMoreDetail.Size = new System.Drawing.Size(110, 23);
            this.btnCustomerMoreDetail.TabIndex = 17;
            this.btnCustomerMoreDetail.Text = "more detail";
            this.btnCustomerMoreDetail.UseVisualStyleBackColor = true;
            this.btnCustomerMoreDetail.Click += new System.EventHandler(this.btnCustomerMoreDetail_Click);
            // 
            // btnParkingSpotMoreDetail
            // 
            this.btnParkingSpotMoreDetail.Location = new System.Drawing.Point(391, 362);
            this.btnParkingSpotMoreDetail.Name = "btnParkingSpotMoreDetail";
            this.btnParkingSpotMoreDetail.Size = new System.Drawing.Size(110, 23);
            this.btnParkingSpotMoreDetail.TabIndex = 18;
            this.btnParkingSpotMoreDetail.Text = "more detail";
            this.btnParkingSpotMoreDetail.UseVisualStyleBackColor = true;
            this.btnParkingSpotMoreDetail.Click += new System.EventHandler(this.btnParkingSpotMoreDetail_Click);
            // 
            // FrmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 658);
            this.Controls.Add(this.btnParkingSpotMoreDetail);
            this.Controls.Add(this.btnCustomerMoreDetail);
            this.Controls.Add(this.cbParkingSpotIDAddVehicle);
            this.Controls.Add(this.cbCustomerIDAddVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTypeOfVehicle);
            this.Controls.Add(this.txtOccupancy);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddVehicle";
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.FrmAddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtOccupancy;
        private System.Windows.Forms.ComboBox cbTypeOfVehicle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.ComboBox cbCustomerIDAddVehicle;
        private System.Windows.Forms.ComboBox cbParkingSpotIDAddVehicle;
        private System.Windows.Forms.Button btnCustomerMoreDetail;
        private System.Windows.Forms.Button btnParkingSpotMoreDetail;
    }
}