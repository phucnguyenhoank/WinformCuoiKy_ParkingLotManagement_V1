using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ParkingLotManagement
{
    public partial class FrmJobSelector : Form
    {
        public List<string> SelectedJobNames { get; private set; }

        public FrmJobSelector()
        {
            InitializeComponent();
            this.SelectedJobNames = new List<string>();
        }

        private void ReloadForm()
        {
            try
            {
                AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
                List<string> jobNames = new List<string>();
                foreach (DataRow row in accessHelperDAL.GetTableData("Job").Rows)
                {
                    jobNames.Add((string)row["JobName"]);
                    
                }
                jobNames.Sort();

                clbJob.Items.AddRange(jobNames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ReloadForm:{ex.Message}");
            }
        }

        private void FrmJobSelector_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void btnAddJobDetails_Click(object sender, EventArgs e)
        {
            foreach (string jobName in clbJob.CheckedItems)
            {
                this.SelectedJobNames.Add(jobName);
            }

            this.Close();
        }
    }
}
