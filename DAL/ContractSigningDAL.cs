using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ContractSigningDAL
    {
        public int AddContractSigning(ContractSigning contractSigning)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ContractSigning (VehicleID, ContractID) VALUES (@VehicleID, @ContractID)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", contractSigning.VehicleID);
                        command.Parameters.AddWithValue("@ContractID", contractSigning.ContractID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddContractSigning:{ex.Message}]");
                throw;
            }
        }

        public ContractSigning GetContractSigningByID(string vehicleID, string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM ContractSigning WHERE VehicleID = @VehicleID AND ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", vehicleID);
                        command.Parameters.AddWithValue("@ContractID", contractID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ContractSigning
                                {
                                    VehicleID = reader["VehicleID"].ToString(),
                                    ContractID = reader["ContractID"].ToString()
                                };
                            }
                            else
                            {
                                return null; // ContractSigning not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetContractSigningByID:{ex.Message}]");
                throw;
            }
        }

        public int DeleteContractSigning(string vehicleID, string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM ContractSigning WHERE VehicleID = @VehicleID AND ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", vehicleID);
                        command.Parameters.AddWithValue("@ContractID", contractID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteContractSigning:{ex.Message}]");
                throw;
            }
        }
    }

}
