using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPoC
{
    internal class DataAccessLayer
    {
        string connectionString = "Server=tcp:mayurtestserver.database.windows.net,1433;Initial Catalog=WinformPoCPracticeDB;Persist Security Info=False;User ID=mayurtest;Password=Space@#15;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public void AddEmployeeDetails(EmployeeDetailsModel emp)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("AddEmployeeDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", emp.Name);
                        cmd.Parameters.AddWithValue("@Surname", emp.Surname);
                        cmd.Parameters.AddWithValue("@DOB", emp.DOB);
                        cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                        cmd.Parameters.AddWithValue("@Address", emp.Address);
                        cmd.Parameters.AddWithValue("@MaritalStatus", emp.MaritalStatus);
                        cmd.Parameters.AddWithValue("@Nationality", emp.Nationality);
                        cmd.Parameters.AddWithValue("@Employer", emp.Employer);
                        cmd.Parameters.AddWithValue("@Designation", emp.Designation);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data saved successfully.");
            }
            catch (Exception)
            {
                throw new Exception("Unable to save details. Please contact system admin.");
            }
            
        }

        public List<EmployeeDetailsModel> GetAllEmpployeeDetails()
        {
            List<EmployeeDetailsModel> employees = new List<EmployeeDetailsModel>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("GetAllEmpployeeDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeDetailsModel emp = new EmployeeDetailsModel
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    Surname = reader["Surname"].ToString(),
                                    DOB = (DateTime)reader["DOB"],
                                    Gender = reader["Gender"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    MaritalStatus = reader["MaritalStatus"].ToString(),
                                    Nationality = reader["Nationality"].ToString(),
                                    Employer = reader["Employer"].ToString(),
                                    Designation = reader["Designation"].ToString(),
                                };

                                employees.Add(emp);
                            }
                        }
                    }
                }
                return employees;
            }
            catch (Exception)
            {
                throw new Exception("Unable to get details. Please contact system admin.");
            }
        }
    }
}
