using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class MaintenanceContractDAL
    {
        public int AddMaintenanceContract(MaintenanceContract maintenanceContract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO MaintenanceContract (ContractID, WarrantyDurationInMonths) VALUES (@ContractID, @WarrantyDurationInMonths)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", maintenanceContract.ContractID);
                        command.Parameters.AddWithValue("@WarrantyDurationInMonths", maintenanceContract.WarrantyDurationInMonths);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddMaintenanceContract:{ex.Message}]");
                throw;
            }
        }

        public MaintenanceContract GetMaintenanceContractByID(string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM MaintenanceContract WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new MaintenanceContract
                                {
                                    ContractID = reader["ContractID"].ToString(),
                                    WarrantyDurationInMonths = Convert.ToInt32(reader["WarrantyDurationInMonths"])
                                };
                            }
                            else
                            {
                                return null; // MaintenanceContract not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetMaintenanceContractByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateMaintenanceContract(MaintenanceContract maintenanceContract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE MaintenanceContract SET WarrantyDurationInMonths = @WarrantyDurationInMonths " +
                                 "WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@WarrantyDurationInMonths", maintenanceContract.WarrantyDurationInMonths);
                        command.Parameters.AddWithValue("@ContractID", maintenanceContract.ContractID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateMaintenanceContract:{ex.Message}]");
                throw;
            }
        }

        public int DeleteMaintenanceContract(string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM MaintenanceContract WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteMaintenanceContract:{ex.Message}]");
                throw;
            }
        }

    }
}
