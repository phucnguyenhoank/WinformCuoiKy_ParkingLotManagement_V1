namespace ParkingLotManagement
{
    partial class FrmJobSelector
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
            this.clbJob = new System.Windows.Forms.CheckedListBox();
            this.btnAddJobDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbJob
            // 
            this.clbJob.FormattingEnabled = true;
            this.clbJob.Location = new System.Drawing.Point(81, 118);
            this.clbJob.Name = "clbJob";
            this.clbJob.Size = new System.Drawing.Size(574, 140);
            this.clbJob.TabIndex = 0;
            // 
            // btnAddJobDetails
            // 
            this.btnAddJobDetails.Location = new System.Drawing.Point(499, 280);
            this.btnAddJobDetails.Name = "btnAddJobDetails";
            this.btnAddJobDetails.Size = new System.Drawing.Size(156, 23);
            this.btnAddJobDetails.TabIndex = 1;
            this.btnAddJobDetails.Text = "Add selections";
            this.btnAddJobDetails.UseVisualStyleBackColor = true;
            this.btnAddJobDetails.Click += new System.EventHandler(this.btnAddJobDetails_Click);
            // 
            // FrmJobSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddJobDetails);
            this.Controls.Add(this.clbJob);
            this.Name = "FrmJobSelector";
            this.Text = "Job Selector";
            this.Load += new System.EventHandler(this.FrmJobSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbJob;
        private System.Windows.Forms.Button btnAddJobDetails;
    }
}