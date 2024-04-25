using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptDAL
    {
        public int AddReceipt(Receipt receipt)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Receipt (ReceiptID, TotalCost, CustomerID, ContractID) " +
                                 "VALUES (@ReceiptID, @TotalCost, @CustomerID, @ContractID)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ReceiptID", receipt.ReceiptID);
                        command.Parameters.AddWithValue("@TotalCost", receipt.TotalCost);
                        command.Parameters.AddWithValue("@CustomerID", receipt.CustomerID);
                        command.Parameters.AddWithValue("@ContractID", receipt.ContractID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddReceipt:{ex.Message}]");
                throw;
            }
        }

        public Receipt GetReceiptByID(string receiptID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Receipt WHERE ReceiptID = @ReceiptID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ReceiptID", receiptID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Receipt
                                {
                                    ReceiptID = reader["ReceiptID"].ToString(),
                                    TotalCost = Convert.ToInt32(reader["TotalCost"]),
                                    CustomerID = reader["CustomerID"].ToString(),
                                    ContractID = reader["ContractID"].ToString()
                                };
                            }
                            else
                            {
                                return null; // Receipt not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetReceiptByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateReceipt(Receipt receipt)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE Receipt SET TotalCost = @TotalCost, " +
                                 "CustomerID = @CustomerID, ContractID = @ContractID " +
                                 "WHERE ReceiptID = @ReceiptID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TotalCost", receipt.TotalCost);
                        command.Parameters.AddWithValue("@CustomerID", receipt.CustomerID);
                        command.Parameters.AddWithValue("@ContractID", receipt.ContractID);
                        command.Parameters.AddWithValue("@ReceiptID", receipt.ReceiptID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateReceipt:{ex.Message}]");
                throw;
            }
        }

        public int DeleteReceipt(string receiptID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Receipt WHERE ReceiptID = @ReceiptID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ReceiptID", receiptID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteReceipt:{ex.Message}]");
                throw;
            }
        }
    }

}
