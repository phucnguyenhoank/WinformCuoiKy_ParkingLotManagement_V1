using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.AccessHelperDAL accessHelperDAL = new DAL.AccessHelperDAL();
                dtgvTableData.DataSource = accessHelperDAL.GetTableData(txtTableName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnLoad_Click:{ex.Message}");
            }
            
            
        }
    }
}
