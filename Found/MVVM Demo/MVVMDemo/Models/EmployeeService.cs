using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace MVVMDemo.Models
{
    class EmployeeService
    {
        SqlConnection objSqlConnection;
        SqlCommand objSqlCommand;
        //private static List<Employee> objEmployeeList;
        public EmployeeService()
        {

            objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnection"].ConnectionString);
            objSqlCommand = new SqlCommand();
            objSqlCommand.Connection = objSqlConnection;
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            /*objEmployeeList = new List<Employee>()
            {
                new Employee { Id = 101, Name = "Seif", Age = 25 }
            };*/
        }

        public List<Employee> GetAll()
        {
            //return objEmployeeList;
            List<Employee> objEmployeeList = new List<Employee>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "upd_SelectAllEmployees";
                objSqlConnection.Open();
                var objSqlDataReader = objSqlCommand.ExecuteReader();
                if (objSqlDataReader.HasRows) 
                {
                    Employee ObjEmployee = null;
                    while (objSqlDataReader.Read())
                    {
                        ObjEmployee = new Employee();
                        ObjEmployee.Id = objSqlDataReader.GetInt32(0);
                        ObjEmployee.Name = objSqlDataReader.GetString(1);
                        ObjEmployee.Age = objSqlDataReader.GetInt32(2);
                        objEmployeeList.Add(ObjEmployee);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                objSqlConnection.Close();
            }
            return objEmployeeList;
        }
        public bool Add(Employee objNewEmployee)
        {
            bool IsAdded = false;
            //age must be between 21 and 58
            if (objNewEmployee.Age < 21 || objNewEmployee.Age > 58)
                throw new ArgumentException("Invalid age limit for employee");
            //objEmployeeList.Add(objNewEmployee);
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "upd_InsertEmployees";
                objSqlCommand.Parameters.AddWithValue("@Id", objNewEmployee.Id);
                objSqlCommand.Parameters.AddWithValue("@Name", objNewEmployee.Name);
                objSqlCommand.Parameters.AddWithValue("@Age", objNewEmployee.Age);
                objSqlConnection.Open();
                int NoOfRowsAffected=objSqlCommand.ExecuteNonQuery();
                IsAdded = NoOfRowsAffected > 0;
                //var objSqlDataReader = objSqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                objSqlConnection.Close();

            }
            return IsAdded;
        }

        public bool Update(Employee objEmployeeToUpdate)
        {
            bool isUpdated = false;
            /*for (int index = 0; index < objEmployeeList.Count; index++)
            {
                if (objEmployeeList[index].Id == objEmployeeToUpdate.Id)
                {
                    objEmployeeList[index].Name = objEmployeeToUpdate.Name;
                    objEmployeeList[index].Age = objEmployeeToUpdate.Age;
                    isUpdated = true;
                    break;
                }
            }*/

            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "upd_UpdateEmployee";
                objSqlCommand.Parameters.AddWithValue("@Id", objEmployeeToUpdate.Id);
                objSqlCommand.Parameters.AddWithValue("@Name", objEmployeeToUpdate.Name);
                objSqlCommand.Parameters.AddWithValue("@Age", objEmployeeToUpdate.Age);
                objSqlConnection.Open();
                int NoOfRowsAffected = objSqlCommand.ExecuteNonQuery();
                isUpdated = NoOfRowsAffected > 0;
                //var objSqlDataReader = objSqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                objSqlConnection.Close();

            }
            return isUpdated;
        }

        public bool Delete(int id)
        {
            bool isDeleted = false;
            /*for (int index = 0; index < objEmployeeList.Count; index++)
            {
                if (objEmployeeList[index].Id == id)
                {
                    objEmployeeList.RemoveAt(index);
                    isDeleted = true;
                    break;
                }

            }*/

            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "upd_DeleteEmployee";
                objSqlCommand.Parameters.AddWithValue("@Id", id);
                objSqlConnection.Open();
                int NoOfRowsAffected = objSqlCommand.ExecuteNonQuery();
                isDeleted = NoOfRowsAffected > 0;
                //var objSqlDataReader = objSqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                objSqlConnection.Close();

            }
            return isDeleted;
        }

        public Employee Search(int id)
        {
            Employee objEmployee;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText= "upd_SelectAllEmployeesById";
                objSqlCommand.Parameters.AddWithValue("@Id",id);
                objSqlConnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    ObjSqlDataReader.Read();
                    objEmployee = new Employee();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {

            }
            return objEmployee;
            //return objEmployeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
