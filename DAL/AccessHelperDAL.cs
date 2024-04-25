using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AccessHelperDAL
    {

        public DataTable GetTableData(string tableName, string condition = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {tableName}";
                    if (!string.IsNullOrEmpty(condition))
                    {
                        query += " WHERE " + condition;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetTableData:{ex.Message}]");
                throw;
            }
        }

        public bool ExistingIn(string tableName, string id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE {tableName}ID = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ExistingIn:{ex.Message}]");
                throw;
            }
        }

        public List<string> GetIDs(string tableName, string condition = "")
        {
            List<string> ids = new List<string>();
            string idColumnName = tableName + "ID";

            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    // Xây dựng câu truy vấn SQL dựa trên sự có mặt của điều kiện
                    string query = $"SELECT {idColumnName} FROM {tableName}";
                    if (!string.IsNullOrEmpty(condition))
                    {
                        query += $" WHERE {condition}";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ids.Add(reader[idColumnName].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetIDs:{ex.Message}]");
                throw;
            }

            return ids;
        }

        public DataTable GetTableDetails(string tableName, List<string> keyValues)
        {
            DataTable tableDetails = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {tableName} WHERE {tableName}ID IN ({string.Join(",", keyValues.Select(id => "'" + id + "'"))})";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(tableDetails);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetTableDetails:{ex.Message}]");
                throw;
            }

            return tableDetails;
        }


    }
}
