using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExcelsInDAL
    {
        public int AddExcelsIn(ExcelsIn excelsIn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ExcelsIn (EmployeeID, SpecializationID) VALUES (@EmployeeID, @SpecializationID)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", excelsIn.EmployeeID);
                        command.Parameters.AddWithValue("@SpecializationID", excelsIn.SpecializationID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddExcelsIn:{ex.Message}]");
                throw;
            }
        }

        public ExcelsIn GetExcelsInByID(string employeeID, string specializationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM ExcelsIn WHERE EmployeeID = @EmployeeID AND SpecializationID = @SpecializationID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@SpecializationID", specializationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ExcelsIn
                                {
                                    EmployeeID = reader["EmployeeID"].ToString(),
                                    SpecializationID = reader["SpecializationID"].ToString()
                                };
                            }
                            else
                            {
                                return null; // ExcelsIn record not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetExcelsInByID:{ex.Message}]");
                throw;
            }
        }

        public int DeleteExcelsIn(string employeeID, string specializationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM ExcelsIn WHERE EmployeeID = @EmployeeID AND SpecializationID = @SpecializationID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@SpecializationID", specializationID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteExcelsIn:{ex.Message}]");
                throw;
            }
        }
    }

}
