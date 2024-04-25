using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContractDAL
    {
        public int AddContract(Contract contract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Contract (ContractID, RentalStartDate, RentalEndDate, RentalDurationInDays, Price, PaymentStatus) " +
                                   "VALUES (@ContractID, @RentalStartDate, @RentalEndDate, @RentalDurationInDays, @Price, @PaymentStatus)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contract.ContractID);
                        command.Parameters.AddWithValue("@RentalStartDate", contract.RentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", contract.RentalEndDate);
                        command.Parameters.AddWithValue("@RentalDurationInDays", contract.RentalDurationInDays);
                        command.Parameters.AddWithValue("@Price", contract.Price);
                        command.Parameters.AddWithValue("@PaymentStatus", contract.PaymentStatus);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddContract:{ex.Message}]");
                throw;
            }
        }

        public Contract GetContractByID(string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Contract WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Contract
                                {
                                    ContractID = reader["ContractID"].ToString(),
                                    RentalStartDate = Convert.ToDateTime(reader["RentalStartDate"]),
                                    RentalEndDate = Convert.ToDateTime(reader["RentalEndDate"]),
                                    RentalDurationInDays = Convert.ToInt32(reader["RentalDurationInDays"]),
                                    Price = Convert.ToInt32(reader["Price"]),
                                    PaymentStatus = Convert.ToInt32(reader["PaymentStatus"])
                                };
                            }
                            else
                            {
                                return null; // Contract not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetContractByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateContract(Contract contract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Contract SET RentalStartDate = @RentalStartDate, " +
                                   "RentalEndDate = @RentalEndDate, RentalDurationInDays = @RentalDurationInDays, " +
                                   "Price = @Price, PaymentStatus = @PaymentStatus " +
                                   "WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RentalStartDate", contract.RentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", contract.RentalEndDate);
                        command.Parameters.AddWithValue("@RentalDurationInDays", contract.RentalDurationInDays);
                        command.Parameters.AddWithValue("@Price", contract.Price);
                        command.Parameters.AddWithValue("@PaymentStatus", contract.PaymentStatus);
                        command.Parameters.AddWithValue("@ContractID", contract.ContractID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateContract:{ex.Message}]");
                throw;
            }
        }

        public int DeleteContract(string contractID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Contract WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteContract:{ex.Message}]");
                throw;
            }
        }

    }
}
