using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Employee
    {

        // Connection string (typically retrieved from App.config or environment variables)
        static string connectionString = ConfigurationManager.ConnectionStrings["CompanyDBConnectionString"].ConnectionString;

        // Employee properties
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DateOfJoining { get; set; }

        // Constructor to initialize the Employee object
        public Employee(int employeeId, string firstName, string lastName, DateTime hireDate,DateTime dateOfJoining)
        {
            EmployeeID = employeeId;
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
            DateOfJoining = dateOfJoining;

        }
        public static List<Employee> GetAllEmployees()
        {
            // SQL query to select all employees
            string query = "SELECT * FROM Employees";
            List<Employee> employees = new List<Employee>();

            try
            {
                // Open the SQL connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create the SQL command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Execute the query and read data
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Reading data and adding to the employee list
                            while (reader.Read())
                            {
                                int employeeId = Convert.ToInt32(reader["EmployeeID"]);
                                string firstName = reader["FirstName"] as string ?? "N/A";  // Handle potential null value
                                string lastName = reader["LastName"] as string ?? "N/A";    // Handle potential null value
                                DateTime hireDate = reader["HireDate"] != DBNull.Value ? Convert.ToDateTime(reader["HireDate"]) : DateTime.MinValue;
                                DateTime dateOfJoining = reader["DateOfJoining"] != DBNull.Value ? Convert.ToDateTime(reader["DateOfJoining"]) : DateTime.MinValue;

                                // Create an Employee object and add it to the list
                                Employee employee = new Employee(employeeId, firstName, lastName, hireDate, dateOfJoining);
                                employees.Add(employee);
                                Console.WriteLine(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching employee data: " + ex.Message);
            }
            return employees;
        }
        public static bool AddNewEmployeeData(string firstName, string lastName, DateTime dateOfJoining)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, HireDate, DateOfJoining) VALUES (@FirstName, @LastName, @HireDate, @DateOfJoining)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DateTime currentDate=DateTime.Now;
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@HireDate", currentDate);
                        cmd.Parameters.AddWithValue("@DateOfJoining", dateOfJoining);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding new employee: " + ex.Message);
                return false;
            }
        }
    }
}
