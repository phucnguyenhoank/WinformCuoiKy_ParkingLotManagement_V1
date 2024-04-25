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
    public class CustomerDAL
    {
        public int AddCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Customer (CustomerID, Name, CitizenNumber, PhoneNumber, Address) " +
                                   "VALUES (@CustomerID, @Name, @CitizenNumber, @PhoneNumber, @Address)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                        command.Parameters.AddWithValue("@Name", customer.Name);
                        command.Parameters.AddWithValue("@CitizenNumber", customer.CitizenNumber);
                        command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", customer.Address);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddCustomer:{ex.Message}]");
                throw;
            }
        }

        public Customer GetCustomerByID(string customerID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Customer
                                {
                                    CustomerID = reader["CustomerID"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    CitizenNumber = reader["CitizenNumber"].ToString(),
                                    PhoneNumber = reader["PhoneNumber"].ToString(),
                                    Address = reader["Address"].ToString()
                                };
                            }
                            else
                            {
                                return null; // Customer not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetCustomerByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Customer SET Name = @Name, " +
                                   "CitizenNumber = @CitizenNumber, PhoneNumber = @PhoneNumber, " +
                                   "Address = @Address WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", customer.Name);
                        command.Parameters.AddWithValue("@CitizenNumber", customer.CitizenNumber);
                        command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", customer.Address);
                        command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateCustomer:{ex.Message}]");
                throw;
            }
        }

        public int DeleteCustomer(string customerID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteCustomer:{ex.Message}]");
                throw;
            }
        }
    }


}
