using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SpecializationDAL
    {
        public int AddSpecialization(Specialization specialization)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Specialization (SpecializationID, SpecializationName) " +
                                 "VALUES (@SpecializationID, @SpecializationName)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SpecializationID", specialization.SpecializationID);
                        command.Parameters.AddWithValue("@SpecializationName", specialization.SpecializationName);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddSpecialization:{ex.Message}]");
                throw;
            }
        }

        public Specialization GetSpecializationByID(string specializationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Specialization WHERE SpecializationID = @SpecializationID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SpecializationID", specializationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Specialization
                                {
                                    SpecializationID = reader["SpecializationID"].ToString(),
                                    SpecializationName = reader["SpecializationName"].ToString()
                                };
                            }
                            else
                            {
                                return null; // Specialization not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetSpecializationByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateSpecialization(Specialization specialization)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE Specialization SET SpecializationName = @SpecializationName " +
                                 "WHERE SpecializationID = @SpecializationID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SpecializationName", specialization.SpecializationName);
                        command.Parameters.AddWithValue("@SpecializationID", specialization.SpecializationID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateSpecialization:{ex.Message}]");
                throw;
            }
        }

        public int DeleteSpecialization(string specializationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Specialization WHERE SpecializationID = @SpecializationID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SpecializationID", specializationID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteSpecialization:{ex.Message}]");
                throw;
            }
        }
    }

}
