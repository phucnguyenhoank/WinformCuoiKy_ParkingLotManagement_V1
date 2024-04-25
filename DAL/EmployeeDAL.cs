using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class EmployeeDAL
    {
        public int AddEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Employee (EmployeeID, EmployeeType, EmployeeName, BirthDay, Gender, Address, PhoneNumber) " +
                                   "VALUES (@EmployeeID, @EmployeeType, @EmployeeName, @BirthDay, @Gender, @Address, @PhoneNumber)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                        command.Parameters.AddWithValue("@EmployeeType", employee.EmployeeType);
                        command.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                        command.Parameters.AddWithValue("@BirthDay", employee.BirthDay);
                        command.Parameters.AddWithValue("@Gender", employee.Gender);
                        command.Parameters.AddWithValue("@Address", employee.Address);
                        command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddEmployee:{ex.Message}]");
                throw;
            }
        }

        public Employee GetEmployeeByID(string employeeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Employee
                                {
                                    EmployeeID = reader["EmployeeID"].ToString(),
                                    EmployeeType = reader["EmployeeType"].ToString(),
                                    EmployeeName = reader["EmployeeName"].ToString(),
                                    BirthDay = Convert.ToDateTime(reader["BirthDay"]),
                                    Gender = reader["Gender"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    PhoneNumber = reader["PhoneNumber"].ToString()
                                };
                            }
                            else
                            {
                                return null; // Employee not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetEmployeeByID:{ex.Message}]");
                throw;
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Employee SET EmployeeType = @EmployeeType, " +
                                   "EmployeeName = @EmployeeName, BirthDay = @BirthDay, " +
                                   "Gender = @Gender, Address = @Address, PhoneNumber = @PhoneNumber " +
                                   "WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeType", employee.EmployeeType);
                        command.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                        command.Parameters.AddWithValue("@BirthDay", employee.BirthDay);
                        command.Parameters.AddWithValue("@Gender", employee.Gender);
                        command.Parameters.AddWithValue("@Address", employee.Address);
                        command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                        command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateEmployee:{ex.Message}]");
                throw;
            }
        }

        public int DeleteEmployee(string employeeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteEmployee:{ex.Message}]");
                throw;
            }
        }
    }

}
