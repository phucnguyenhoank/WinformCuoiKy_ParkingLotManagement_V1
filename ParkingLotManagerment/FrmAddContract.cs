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
    public partial class FrmAddContract : Form
    {
        public FrmAddContract()
        {
            InitializeComponent();
        }

        private void ReloadForm()
        {
            try
            {
                AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
                cbPaymentStatus.Items.AddRange(new string[] { "Unexecuted", "Executed" });
                cbPaymentStatus.SelectedIndex = 0;

                rbRentalContract.Checked = true;
                cbRenter.Items.AddRange(new string[] { "Customer", "Business" });
                cbRenter.SelectedIndex = 0;

                cbCustomerIDAddContract.Items.AddRange(accessHelperDAL.GetIDs("Customer").ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ReloadForm:{ex.Message}");
            }
            
        }

        private void FrmAddContract_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            try
            {
                Contract contract = new Contract(txtContractID.Text, dtpRentalStartDate.Value, dtpRentalEndDate.Value, int.Parse(txtRentalDurationInDays.Text), int.Parse(txtPrice.Text), (cbPaymentStatus.Text == "Unexecuted")? 0: 1);

                ContractDAL contractDAL = new ContractDAL();
                contractDAL.AddContract(contract);

                if (rbRentalContract.Checked)
                {
                    RentalContract rentalContract = new RentalContract(txtContractID.Text, (string)cbRenter.SelectedItem);
                    RentalContractDAL rentalContractDAL = new RentalContractDAL();
                    rentalContractDAL.AddRentalContract(rentalContract);
                }
                else
                {
                    MaintenanceContract maintenanceContract = new MaintenanceContract(txtContractID.Text, int.Parse(txtWarrantyDurationInMonths.Text));
                    MaintenanceContractDAL maintenanceContractDAL = new MaintenanceContractDAL();
                    maintenanceContractDAL.AddMaintenanceContract(maintenanceContract);

                }
                
                JobDAL jobDAL = new JobDAL();
                ContractDetailDAL contractDetailDAL = new ContractDetailDAL();
                foreach (string jobName in GetCurrentJobNames())
                {
                    string jobID = jobDAL.GetIDJob(jobName);
                    // 3.3333 là số lương cứng mặc định để chạy code, thực tế sẽ cần tính lương phải trả cho thợ, mặc định là 10% giá trị công việc
                    ContractDetail contractDetail = new ContractDetail(txtContractID.Text, jobID, cbCustomerIDAddContract.Text, (decimal)3.3333);
                    contractDetailDAL.AddContractDetail(contractDetail);
                }

                
                ContractSigningDAL contractSigningDAL = new ContractSigningDAL();
                foreach (string vehicleID in GetCurrentVehicleIDs())
                {
                    ContractSigning contractSigning = new ContractSigning(vehicleID, txtContractID.Text);
                    contractSigningDAL.AddContractSigning(contractSigning);
                }
                

                MessageBox.Show("Successfully add contract");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnAddContract_Click:{ex.Message}");
            }
            
        }

        private void txtRentalDurationInDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtpRentalEndDate.Value = dtpRentalStartDate.Value.AddDays(int.Parse(txtRentalDurationInDays.Text));
            }
            catch (Exception ex )
            {
                MessageBox.Show($"txtRentalDurationInDays_TextChanged:{ex.Message}");
            }
            
        }

        private void btnCustomerMoreDetail_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCustomerList frmCustomerList = new FrmCustomerList();
                frmCustomerList.ShowDialog(this);

                string selectedCellValue = frmCustomerList.SelectedCellValue;
                if (!string.IsNullOrEmpty(selectedCellValue))
                {
                    cbCustomerIDAddContract.SelectedItem = selectedCellValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnCustomerMoreDetail_Click:{ex.Message}");
            }
        }

        private void rbRentalContract_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRentalContract.Checked)
            {
                cbRenter.Enabled = true;
                lblRenter.ForeColor = Color.Black;

                lblWarrantyDurationInMonths.ForeColor = Color.Gray;
                txtWarrantyDurationInMonths.Enabled = false;
                
            }
            else
            {
                cbRenter.Enabled = false;
                lblRenter.ForeColor = Color.Gray;

                lblWarrantyDurationInMonths.ForeColor = Color.Black;
                txtWarrantyDurationInMonths.Enabled = true;
            }
        }

        private void btnVehicleMoreDetail_Click(object sender, EventArgs e)
        {
            try
            {
                AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
                FrmVehicleList frmVehicleList = new FrmVehicleList(accessHelperDAL.GetTableDetails("Vehicle", accessHelperDAL.GetIDs("Vehicle", $"CustomerID = \'{cbCustomerIDAddContract.SelectedItem}\'")));
                frmVehicleList.ShowDialog(this);

                string selectedCellValue = frmVehicleList.SelectedCellValue;
                if (!string.IsNullOrEmpty(selectedCellValue))
                {
                    for (int i = 0; i < clbVehicle.Items.Count; i++)
                    {
                        if (clbVehicle.Items[i].ToString() == selectedCellValue)
                        {
                            clbVehicle.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnVehicleMoreDetail_Click:{ex.Message}");
            }
            
        }

        private void cbCustomerIDAddContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
                clbVehicle.Items.Clear();
                clbVehicle.Items.AddRange(accessHelperDAL.GetIDs("Vehicle", $"CustomerID = \'{cbCustomerIDAddContract.Text}\'").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"cbCustomerIDAddContract_SelectedIndexChanged:{ex.Message}");
            }

        }

        private List<string> GetCurrentVehicleIDs()
        {
            List<string> vehicleIDs = new List<string>();

            foreach (string item in clbVehicle.CheckedItems)
            {
                vehicleIDs.Add(item);
            }

            return vehicleIDs;
        }

        private List<string> GetCurrentJobNames()
        {
            List<string> jobNames = lbxJobDetail.Items.Cast<string>().ToList();
            for (int i = 0; i < jobNames.Count; i++)
            {
                string[] split = jobNames[i].Split(new char[] { '.' }, 2);
                string jobName = split[1].Trim();

                jobNames[i] = jobName;
            }
            return jobNames;
        }

        private void UpdatePrice()
        {
            List<string> jobNames = GetCurrentJobNames();
            JobDAL jobDAL = new JobDAL();
            int totalJobValue = jobDAL.GetValueJobs(jobNames);
            txtPrice.Text = totalJobValue.ToString();
        }

        private void RemoveJobDetailsForListBox(ListBox lbx, string jobName)
        {
            if (!string.IsNullOrEmpty(jobName))
            {
                int index = lbx.Items.IndexOf(jobName);

                lbx.Items.Remove(jobName);

                for (int i = index; i < lbx.Items.Count; i++)
                {
                    string[] split = lbx.Items[i].ToString().Split(new char[] { '.' }, 2);
                    string jobDetailName = split[1].Trim();

                    lbx.Items[i] = $"{i + 1}. {jobDetailName}";
                }
                UpdatePrice();
            }

        }

        private void AddJobDetailsForListBox(ListBox lbx, List<string> jobDetailNames)
        {
            lbx.Items.Clear();
            jobDetailNames.Sort();

            int count = 1;
            foreach (string jobDetailName in jobDetailNames)
            {
                lbxJobDetail.Items.Add($"{count}. {jobDetailName}");
                count++;
            }
            UpdatePrice();
        }

        private void btnAddJobDetail_Click(object sender, EventArgs e)
        {
            try
            {
                FrmJobSelector frmJobSelector = new FrmJobSelector();
                frmJobSelector.ShowDialog(this);

                if (frmJobSelector.SelectedJobNames.Count > 0)
                {
                    AddJobDetailsForListBox(lbxJobDetail, frmJobSelector.SelectedJobNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnAddJobDetail_Click:{ex.Message}");
            }
            
        }

        private void btnRemoveJobDetail_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveJobDetailsForListBox(lbxJobDetail, (string)lbxJobDetail.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnRemoveJobDetail_Click:{ex.Message}");
            }
            
        }
    }
}
