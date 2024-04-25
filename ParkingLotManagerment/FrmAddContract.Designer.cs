namespace ParkingLotManagement
{
    partial class FrmAddContract
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
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMaintenanceContract = new System.Windows.Forms.RadioButton();
            this.rbRentalContract = new System.Windows.Forms.RadioButton();
            this.lblRenter = new System.Windows.Forms.Label();
            this.lblWarrantyDurationInMonths = new System.Windows.Forms.Label();
            this.dtpRentalStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentalEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtRentalDurationInDays = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbRenter = new System.Windows.Forms.ComboBox();
            this.txtWarrantyDurationInMonths = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.clbVehicle = new System.Windows.Forms.CheckedListBox();
            this.btnVehicleMoreDetail = new System.Windows.Forms.Button();
            this.cbCustomerIDAddContract = new System.Windows.Forms.ComboBox();
            this.btnCustomerMoreDetail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxJobDetail = new System.Windows.Forms.ListBox();
            this.btnAddJobDetail = new System.Windows.Forms.Button();
            this.btnRemoveJobDetail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(197, 105);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(100, 22);
            this.txtContractID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rental Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rental End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rental Duration In Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Payment Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMaintenanceContract);
            this.groupBox1.Controls.Add(this.rbRentalContract);
            this.groupBox1.Controls.Add(this.lblRenter);
            this.groupBox1.Controls.Add(this.cbRenter);
            this.groupBox1.Controls.Add(this.lblWarrantyDurationInMonths);
            this.groupBox1.Controls.Add(this.txtWarrantyDurationInMonths);
            this.groupBox1.Location = new System.Drawing.Point(56, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of contract";
            // 
            // rbMaintenanceContract
            // 
            this.rbMaintenanceContract.AutoSize = true;
            this.rbMaintenanceContract.Location = new System.Drawing.Point(254, 32);
            this.rbMaintenanceContract.Name = "rbMaintenanceContract";
            this.rbMaintenanceContract.Size = new System.Drawing.Size(157, 20);
            this.rbMaintenanceContract.TabIndex = 1;
            this.rbMaintenanceContract.TabStop = true;
            this.rbMaintenanceContract.Text = "Maintenance Contract";
            this.rbMaintenanceContract.UseVisualStyleBackColor = true;
            // 
            // rbRentalContract
            // 
            this.rbRentalContract.AutoSize = true;
            this.rbRentalContract.Location = new System.Drawing.Point(25, 32);
            this.rbRentalContract.Name = "rbRentalContract";
            this.rbRentalContract.Size = new System.Drawing.Size(119, 20);
            this.rbRentalContract.TabIndex = 0;
            this.rbRentalContract.TabStop = true;
            this.rbRentalContract.Text = "Rental Contract";
            this.rbRentalContract.UseVisualStyleBackColor = true;
            this.rbRentalContract.CheckedChanged += new System.EventHandler(this.rbRentalContract_CheckedChanged);
            // 
            // lblRenter
            // 
            this.lblRenter.AutoSize = true;
            this.lblRenter.Location = new System.Drawing.Point(22, 81);
            this.lblRenter.Name = "lblRenter";
            this.lblRenter.Size = new System.Drawing.Size(47, 16);
            this.lblRenter.TabIndex = 8;
            this.lblRenter.Text = "Renter";
            // 
            // lblWarrantyDurationInMonths
            // 
            this.lblWarrantyDurationInMonths.AutoSize = true;
            this.lblWarrantyDurationInMonths.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWarrantyDurationInMonths.Location = new System.Drawing.Point(238, 83);
            this.lblWarrantyDurationInMonths.Name = "lblWarrantyDurationInMonths";
            this.lblWarrantyDurationInMonths.Size = new System.Drawing.Size(173, 16);
            this.lblWarrantyDurationInMonths.TabIndex = 9;
            this.lblWarrantyDurationInMonths.Text = "Warranty Duration In Months";
            // 
            // dtpRentalStartDate
            // 
            this.dtpRentalStartDate.Location = new System.Drawing.Point(197, 161);
            this.dtpRentalStartDate.Name = "dtpRentalStartDate";
            this.dtpRentalStartDate.Size = new System.Drawing.Size(241, 22);
            this.dtpRentalStartDate.TabIndex = 10;
            // 
            // dtpRentalEndDate
            // 
            this.dtpRentalEndDate.Enabled = false;
            this.dtpRentalEndDate.Location = new System.Drawing.Point(197, 204);
            this.dtpRentalEndDate.Name = "dtpRentalEndDate";
            this.dtpRentalEndDate.Size = new System.Drawing.Size(241, 22);
            this.dtpRentalEndDate.TabIndex = 11;
            // 
            // txtRentalDurationInDays
            // 
            this.txtRentalDurationInDays.Location = new System.Drawing.Point(197, 247);
            this.txtRentalDurationInDays.Name = "txtRentalDurationInDays";
            this.txtRentalDurationInDays.Size = new System.Drawing.Size(100, 22);
            this.txtRentalDurationInDays.TabIndex = 12;
            this.txtRentalDurationInDays.TextChanged += new System.EventHandler(this.txtRentalDurationInDays_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(197, 306);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Location = new System.Drawing.Point(197, 351);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(121, 24);
            this.cbPaymentStatus.TabIndex = 14;
            // 
            // cbRenter
            // 
            this.cbRenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenter.FormattingEnabled = true;
            this.cbRenter.Location = new System.Drawing.Point(25, 100);
            this.cbRenter.Name = "cbRenter";
            this.cbRenter.Size = new System.Drawing.Size(121, 24);
            this.cbRenter.TabIndex = 15;
            // 
            // txtWarrantyDurationInMonths
            // 
            this.txtWarrantyDurationInMonths.Location = new System.Drawing.Point(241, 102);
            this.txtWarrantyDurationInMonths.Name = "txtWarrantyDurationInMonths";
            this.txtWarrantyDurationInMonths.Size = new System.Drawing.Size(100, 22);
            this.txtWarrantyDurationInMonths.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Customer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(574, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Service list";
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(727, 510);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(121, 37);
            this.btnAddContract.TabIndex = 24;
            this.btnAddContract.Text = "Add";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // clbVehicle
            // 
            this.clbVehicle.FormattingEnabled = true;
            this.clbVehicle.Location = new System.Drawing.Point(698, 161);
            this.clbVehicle.Name = "clbVehicle";
            this.clbVehicle.Size = new System.Drawing.Size(121, 72);
            this.clbVehicle.TabIndex = 25;
            // 
            // btnVehicleMoreDetail
            // 
            this.btnVehicleMoreDetail.Location = new System.Drawing.Point(833, 210);
            this.btnVehicleMoreDetail.Name = "btnVehicleMoreDetail";
            this.btnVehicleMoreDetail.Size = new System.Drawing.Size(103, 23);
            this.btnVehicleMoreDetail.TabIndex = 26;
            this.btnVehicleMoreDetail.Text = "more detail";
            this.btnVehicleMoreDetail.UseVisualStyleBackColor = true;
            this.btnVehicleMoreDetail.Click += new System.EventHandler(this.btnVehicleMoreDetail_Click);
            // 
            // cbCustomerIDAddContract
            // 
            this.cbCustomerIDAddContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerIDAddContract.FormattingEnabled = true;
            this.cbCustomerIDAddContract.Location = new System.Drawing.Point(698, 90);
            this.cbCustomerIDAddContract.Name = "cbCustomerIDAddContract";
            this.cbCustomerIDAddContract.Size = new System.Drawing.Size(121, 24);
            this.cbCustomerIDAddContract.TabIndex = 27;
            this.cbCustomerIDAddContract.SelectedIndexChanged += new System.EventHandler(this.cbCustomerIDAddContract_SelectedIndexChanged);
            // 
            // btnCustomerMoreDetail
            // 
            this.btnCustomerMoreDetail.Location = new System.Drawing.Point(833, 93);
            this.btnCustomerMoreDetail.Name = "btnCustomerMoreDetail";
            this.btnCustomerMoreDetail.Size = new System.Drawing.Size(103, 23);
            this.btnCustomerMoreDetail.TabIndex = 28;
            this.btnCustomerMoreDetail.Text = "more detail";
            this.btnCustomerMoreDetail.UseVisualStyleBackColor = true;
            this.btnCustomerMoreDetail.Click += new System.EventHandler(this.btnCustomerMoreDetail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Attended vehicle list";
            // 
            // lbxJobDetail
            // 
            this.lbxJobDetail.FormattingEnabled = true;
            this.lbxJobDetail.ItemHeight = 16;
            this.lbxJobDetail.Location = new System.Drawing.Point(656, 291);
            this.lbxJobDetail.Name = "lbxJobDetail";
            this.lbxJobDetail.Size = new System.Drawing.Size(280, 84);
            this.lbxJobDetail.TabIndex = 30;
            // 
            // btnAddJobDetail
            // 
            this.btnAddJobDetail.Location = new System.Drawing.Point(656, 390);
            this.btnAddJobDetail.Name = "btnAddJobDetail";
            this.btnAddJobDetail.Size = new System.Drawing.Size(115, 23);
            this.btnAddJobDetail.TabIndex = 31;
            this.btnAddJobDetail.Text = "add job";
            this.btnAddJobDetail.UseVisualStyleBackColor = true;
            this.btnAddJobDetail.Click += new System.EventHandler(this.btnAddJobDetail_Click);
            // 
            // btnRemoveJobDetail
            // 
            this.btnRemoveJobDetail.Location = new System.Drawing.Point(821, 390);
            this.btnRemoveJobDetail.Name = "btnRemoveJobDetail";
            this.btnRemoveJobDetail.Size = new System.Drawing.Size(115, 23);
            this.btnRemoveJobDetail.TabIndex = 32;
            this.btnRemoveJobDetail.Text = "remove job detail";
            this.btnRemoveJobDetail.UseVisualStyleBackColor = true;
            this.btnRemoveJobDetail.Click += new System.EventHandler(this.btnRemoveJobDetail_Click);
            // 
            // FrmAddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 850);
            this.Controls.Add(this.btnRemoveJobDetail);
            this.Controls.Add(this.btnAddJobDetail);
            this.Controls.Add(this.lbxJobDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCustomerMoreDetail);
            this.Controls.Add(this.cbCustomerIDAddContract);
            this.Controls.Add(this.btnVehicleMoreDetail);
            this.Controls.Add(this.clbVehicle);
            this.Controls.Add(this.btnAddContract);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPaymentStatus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRentalDurationInDays);
            this.Controls.Add(this.dtpRentalEndDate);
            this.Controls.Add(this.dtpRentalStartDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContractID);
            this.Name = "FrmAddContract";
            this.Text = "Add Contract";
            this.Load += new System.EventHandler(this.FrmAddContract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMaintenanceContract;
        private System.Windows.Forms.RadioButton rbRentalContract;
        private System.Windows.Forms.Label lblRenter;
        private System.Windows.Forms.Label lblWarrantyDurationInMonths;
        private System.Windows.Forms.DateTimePicker dtpRentalStartDate;
        private System.Windows.Forms.DateTimePicker dtpRentalEndDate;
        private System.Windows.Forms.TextBox txtRentalDurationInDays;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbRenter;
        private System.Windows.Forms.TextBox txtWarrantyDurationInMonths;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.CheckedListBox clbVehicle;
        private System.Windows.Forms.Button btnVehicleMoreDetail;
        private System.Windows.Forms.ComboBox cbCustomerIDAddContract;
        private System.Windows.Forms.Button btnCustomerMoreDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxJobDetail;
        private System.Windows.Forms.Button btnAddJobDetail;
        private System.Windows.Forms.Button btnRemoveJobDetail;
    }
}