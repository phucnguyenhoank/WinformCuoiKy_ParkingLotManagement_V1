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
    public class VehicleDAL
    {
        public int AddVehicle(Vehicle vehicle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Vehicle (VehicleID, LicensePlate, Occupancy, TypeOfVehicle, CustomerID, ParkingSpotID) VALUES (@VehicleID, @LicensePlate, @Occupancy, @TypeOfVehicle, @CustomerID, @ParkingSpotID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);
                        command.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                        command.Parameters.AddWithValue("@Occupancy", vehicle.Occupancy);
                        command.Parameters.AddWithValue("@TypeOfVehicle", vehicle.TypeOfVehicle);
                        command.Parameters.AddWithValue("@CustomerID", vehicle.CustomerID);
                        command.Parameters.AddWithValue("@ParkingSpotID", vehicle.ParkingSpotID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddVehicle:{ex.Message}]");
                throw;
            }
        }

        public Vehicle GetVehicleByID(string vehicleID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Vehicle WHERE VehicleID = @VehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", vehicleID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Vehicle
                                {
                                    VehicleID = reader["VehicleID"].ToString(),
                                    LicensePlate = reader["LicensePlate"].ToString(),
                                    Occupancy = Convert.ToInt32(reader["Occupancy"]),
                                    TypeOfVehicle = reader["TypeOfVehicle"].ToString(),
                                    CustomerID = reader["CustomerID"].ToString(),
                                    ParkingSpotID = reader["ParkingSpotID"].ToString()
                                };
                            }
                            else
                            {
                                return null; // Vehicle not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetVehicleByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateVehicle(Vehicle vehicle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Vehicle SET LicensePlate = @LicensePlate, Occupancy = @Occupancy, TypeOfVehicle = @TypeOfVehicle, CustomerID = @CustomerID, ParkingSpotID = @ParkingSpotID WHERE VehicleID = @VehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                        command.Parameters.AddWithValue("@Occupancy", vehicle.Occupancy);
                        command.Parameters.AddWithValue("@TypeOfVehicle", vehicle.TypeOfVehicle);
                        command.Parameters.AddWithValue("@CustomerID", vehicle.CustomerID);
                        command.Parameters.AddWithValue("@ParkingSpotID", vehicle.ParkingSpotID);
                        command.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateVehicle:{ex.Message}]");
                throw;
            }
        }

        public int DeleteVehicle(string vehicleID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Vehicle WHERE VehicleID = @VehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", vehicleID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteVehicle:{ex.Message}]");
                throw;
            }
        }
        



    }
}
