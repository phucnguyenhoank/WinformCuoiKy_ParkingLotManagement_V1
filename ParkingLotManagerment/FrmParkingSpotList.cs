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
    public partial class FrmParkingSpotList : Form
    {
        public string SelectedCellValue { get; private set; }

        public FrmParkingSpotList()
        {
            InitializeComponent();
        }

        private void LoadDataToParkingSpotList()
        {
            try
            {
                AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
                dtgvParkingSpotList.DataSource = accessHelperDAL.GetTableData("ParkingSpot");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadDataToParkingSpotList:{ex.Message}");
            }
        }

        private void FrmParkingSpotList_Load(object sender, EventArgs e)
        {
            LoadDataToParkingSpotList();
        }

        private void dtgvParkingSpotList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = this.dtgvParkingSpotList.Rows[e.RowIndex];
            SelectedCellValue = (string)selectedRow.Cells[0].Value;
            this.Close();
            
        }
    }
}
