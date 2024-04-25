using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JobDAL
    {

        public int AddJob(Job job)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Job (JobID, SpecializationID, JobName, JobValue) VALUES (@JobID, @SpecializationID, @JobName, @JobValue)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobID", job.JobID);
                        command.Parameters.AddWithValue("@SpecializationID", job.SpecializationID);
                        command.Parameters.AddWithValue("@JobName", job.JobName);
                        command.Parameters.AddWithValue("@JobValue", job.JobValue);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddJob:{ex.Message}]");
                throw;
            }
        }

        public Job GetJobByID(string jobID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Job WHERE JobID = @JobID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Job
                                {
                                    JobID = reader["JobID"].ToString(),
                                    SpecializationID = reader["SpecializationID"].ToString(),
                                    JobName = reader["JobName"].ToString(),
                                    JobValue = Convert.ToInt32(reader["JobValue"])
                                };
                            }
                            else
                            {
                                return null; // Job not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetJobByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateJob(Job job)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Job SET SpecializationID = @SpecializationID, JobName = @JobName, JobValue = @JobValue WHERE JobID = @JobID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SpecializationID", job.SpecializationID);
                        command.Parameters.AddWithValue("@JobName", job.JobName);
                        command.Parameters.AddWithValue("@JobValue", job.JobValue);
                        command.Parameters.AddWithValue("@JobID", job.JobID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateJob:{ex.Message}]");
                throw;
            }
        }

        public int DeleteJob(string jobID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Job WHERE JobID = @JobID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteJob:{ex.Message}]");
                throw;
            }
        }



        public int GetValueJobs(List<string> jobNames = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string jobNamesString = string.Join(",", jobNames.Select(name => $"'{name}'"));
                    string sql = $"SELECT SUM(JobValue) FROM Job WHERE JobName IN ({jobNamesString})";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result == DBNull.Value ? 0 : Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetValueJobs:{ex.Message}]");
                throw;
            }
        }

        public string GetIDJob(string jobName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT JobID FROM Job WHERE JobName = @JobName";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@JobName", jobName);

                        object result = command.ExecuteScalar();
                        return result == null ? null : result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetIDJob:{ex.Message}]");
                throw;
            }
        }



    }
}
