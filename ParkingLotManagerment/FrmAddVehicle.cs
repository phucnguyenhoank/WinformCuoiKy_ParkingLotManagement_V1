using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using ParkingLotManagement;

namespace ParkingLotManagement
{
    public partial class FrmAddVehicle : Form
    {
        public FrmAddVehicle()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle vehicle = new Vehicle(txtVehicleID.Text, txtLicensePlate.Text, int.Parse(txtOccupancy.Text), cbTypeOfVehicle.Text, cbCustomerIDAddVehicle.Text, cbParkingSpotIDAddVehicle.Text);

                VehicleDAL vehicleDAL = new VehicleDAL();
                vehicleDAL.AddVehicle(vehicle);
                MessageBox.Show("Add vehicle successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnAddVehicle_Click:{ex.Message}");
            }
        }

        private void FrmAddVehicle_Load(object sender, EventArgs e)
        {
            List<string> vehicleTypes = new List<string> { "Car", "Motorcycle", "Bicycle" };
            cbTypeOfVehicle.DataSource = vehicleTypes;

            AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
            cbCustomerIDAddVehicle.DataSource = accessHelperDAL.GetIDs("Customer");
            cbParkingSpotIDAddVehicle.DataSource = accessHelperDAL.GetIDs("ParkingSpot");

        }

        private void btnCustomerMoreDetail_Click(object sender, EventArgs e)
        {
            FrmCustomerList frmCustomerList = new FrmCustomerList();
            frmCustomerList.ShowDialog(this);

            string selectedCellValue = frmCustomerList.SelectedCellValue;
            if (!string.IsNullOrEmpty(selectedCellValue))
            {
                cbCustomerIDAddVehicle.SelectedItem = selectedCellValue;
            }
        }

        private void btnParkingSpotMoreDetail_Click(object sender, EventArgs e)
        {
            FrmParkingSpotList frmParkingSpotList = new FrmParkingSpotList();
            frmParkingSpotList.ShowDialog(this);

            string selectedCellValue = frmParkingSpotList.SelectedCellValue;
            if (!string.IsNullOrEmpty(selectedCellValue))
            {
                cbParkingSpotIDAddVehicle.SelectedItem = selectedCellValue;
            }
        }


    }
}
