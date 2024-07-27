using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace cc1
{
        class Program
        {
        private static SqlConnection con;

        static void Main(string[] args)
            {
                string connectionString = "Data Source=ICS-LT-FV236D3\\SQLEXPRESS;Initial Catalog=EmployeeManagement;Integrated Security=True";

                string empName = "uha";
                decimal empsal = 30000;
                char emptype = 'F';

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("Add_Employees", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;


                            command.Parameters.Add(new SqlParameter("@EmpName", empName));
                            command.Parameters.Add(new SqlParameter("@Empsal", empsal));
                            command.Parameters.Add(new SqlParameter("@Emptype", emptype));


                            int newEmpno = Convert.ToInt32(command.ExecuteScalar());
                            Console.WriteLine($"New Employee added with Empno: {newEmpno}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
         
                using (SqlCommand command = new SqlCommand("SELECT * FROM EmployeeDetailss", con))
                {
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Empno: {reader["Empno"]}, EmpName: {reader["EmpName"]}, Empsal: {reader["Empsal"]}, Emptype: {reader["Emptype"]}");
                        }
                    }
                }
            }
        }
    }
