using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkSkillDAL
    {
        public int AddWorkSkill(WorkSkill workSkill)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO WorkSkill (EmployeeID, JobID) " +
                                 "VALUES (@EmployeeID, @JobID)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", workSkill.EmployeeID);
                        command.Parameters.AddWithValue("@JobID", workSkill.JobID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddWorkSkill:{ex.Message}]");
                throw;
            }
        }

        public WorkSkill GetWorkSkillByID(string employeeID, string jobID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM WorkSkill WHERE EmployeeID = @EmployeeID AND JobID = @JobID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@JobID", jobID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new WorkSkill
                                {
                                    EmployeeID = reader["EmployeeID"].ToString(),
                                    JobID = reader["JobID"].ToString()
                                };
                            }
                            else
                            {
                                return null; // WorkSkill not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetWorkSkillByID:{ex.Message}]");
                throw;
            }
        }

        public int DeleteWorkSkill(string employeeID, string jobID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM WorkSkill WHERE EmployeeID = @EmployeeID AND JobID = @JobID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@JobID", jobID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteWorkSkill:{ex.Message}]");
                throw;
            }
        }
    }

}
