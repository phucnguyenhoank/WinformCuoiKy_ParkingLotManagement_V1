using DAL;
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
    public partial class FrmTestDALFunction : Form
    {
        public FrmTestDALFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
            bool n = accessHelperDAL.ExistingIn("Vehicle", "V005");
            MessageBox.Show(n.ToString());
        }
    }
}
