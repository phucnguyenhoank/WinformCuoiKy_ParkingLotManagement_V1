using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ContractDetailDAL
    {
        public int AddContractDetail(ContractDetail contractDetail)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ContractDetail (ContractID, JobID, CustomerID, Wage) " +
                                 "VALUES (@ContractID, @JobID, @CustomerID, @Wage)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractDetail.ContractID);
                        command.Parameters.AddWithValue("@JobID", contractDetail.JobID);
                        command.Parameters.AddWithValue("@CustomerID", contractDetail.CustomerID);
                        command.Parameters.AddWithValue("@Wage", contractDetail.Wage);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddContractDetail:{ex.Message}]");
                throw;
            }
        }

        public ContractDetail GetContractDetailByID(string contractID, string jobID, string customerID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM ContractDetail WHERE ContractID = @ContractID AND JobID = @JobID AND CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractID);
                        command.Parameters.AddWithValue("@JobID", jobID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ContractDetail
                                {
                                    ContractID = reader["ContractID"].ToString(),
                                    JobID = reader["JobID"].ToString(),
                                    CustomerID = reader["CustomerID"].ToString(),
                                    Wage = Convert.ToDecimal(reader["Wage"])
                                };
                            }
                            else
                            {
                                return null; // ContractDetail not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetContractDetailByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateContractDetail(ContractDetail contractDetail)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE ContractDetail SET Wage = @Wage " +
                                 "WHERE ContractID = @ContractID AND JobID = @JobID AND CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Wage", contractDetail.Wage);
                        command.Parameters.AddWithValue("@ContractID", contractDetail.ContractID);
                        command.Parameters.AddWithValue("@JobID", contractDetail.JobID);
                        command.Parameters.AddWithValue("@CustomerID", contractDetail.CustomerID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateContractDetail:{ex.Message}]");
                throw;
            }
        }

        public int DeleteContractDetail(string contractID, string jobID, string customerID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM ContractDetail WHERE ContractID = @ContractID AND JobID = @JobID AND CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractID);
                        command.Parameters.AddWithValue("@JobID", jobID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteContractDetail:{ex.Message}]");
                throw;
            }
        }
    }

}
