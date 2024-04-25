using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class RentalContractDAL
    {
        public int AddRentalContract(RentalContract rentalContract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO RentalContract (ContractID, Renter) " +
                                 "VALUES (@ContractID, @Renter)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", rentalContract.ContractID);
                        command.Parameters.AddWithValue("@Renter", rentalContract.Renter);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddRentalContract:{ex.Message}]");
                throw;
            }
        }

        public RentalContract GetRentalContractByID(string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM RentalContract WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new RentalContract
                                {
                                    ContractID = reader["ContractID"].ToString(),
                                    Renter = reader["Renter"].ToString()
                                };
                            }
                            else
                            {
                                return null; // RentalContract not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetRentalContractByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateRentalContract(RentalContract rentalContract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE RentalContract SET Renter = @Renter " +
                                 "WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Renter", rentalContract.Renter);
                        command.Parameters.AddWithValue("@ContractID", rentalContract.ContractID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateRentalContract:{ex.Message}]");
                throw;
            }
        }

        public int DeleteRentalContract(string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM RentalContract WHERE ContractID = @ContractID";

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
                Console.WriteLine($"[DeleteRentalContract:{ex.Message}]");
                throw;
            }
        }
        

    
    }

}
