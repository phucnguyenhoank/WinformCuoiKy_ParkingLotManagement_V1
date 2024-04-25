using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ParkingSpotDAL
    {
        public int AddParkingSpot(ParkingSpot parkingSpot)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ParkingSpot (ParkingSpotID, BeingOccupied, DesignatedFor, Capacity) " +
                                 "VALUES (@ParkingSpotID, @BeingOccupied, @DesignatedFor, @Capacity)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ParkingSpotID", parkingSpot.ParkingSpotID);
                        command.Parameters.AddWithValue("@BeingOccupied", parkingSpot.BeingOccupied);
                        command.Parameters.AddWithValue("@DesignatedFor", parkingSpot.DesignatedFor);
                        command.Parameters.AddWithValue("@Capacity", parkingSpot.Capacity);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddParkingSpot:{ex.Message}]");
                throw;
            }
        }

        public ParkingSpot GetParkingSpotByID(string parkingSpotID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM ParkingSpot WHERE ParkingSpotID = @ParkingSpotID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ParkingSpotID", parkingSpotID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ParkingSpot
                                {
                                    ParkingSpotID = reader["ParkingSpotID"].ToString(),
                                    BeingOccupied = Convert.ToInt32(reader["BeingOccupied"]),
                                    DesignatedFor = reader["DesignatedFor"].ToString(),
                                    Capacity = Convert.ToInt32(reader["Capacity"])
                                };
                            }
                            else
                            {
                                return null; // ParkingSpot not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetParkingSpotByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateParkingSpot(ParkingSpot parkingSpot)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE ParkingSpot SET BeingOccupied = @BeingOccupied, " +
                                 "DesignatedFor = @DesignatedFor, Capacity = @Capacity " +
                                 "WHERE ParkingSpotID = @ParkingSpotID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BeingOccupied", parkingSpot.BeingOccupied);
                        command.Parameters.AddWithValue("@DesignatedFor", parkingSpot.DesignatedFor);
                        command.Parameters.AddWithValue("@Capacity", parkingSpot.Capacity);
                        command.Parameters.AddWithValue("@ParkingSpotID", parkingSpot.ParkingSpotID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateParkingSpot:{ex.Message}]");
                throw;
            }
        }

        public int DeleteParkingSpot(string parkingSpotID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM ParkingSpot WHERE ParkingSpotID = @ParkingSpotID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ParkingSpotID", parkingSpotID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteParkingSpot:{ex.Message}]");
                throw;
            }
        }
    }

}
