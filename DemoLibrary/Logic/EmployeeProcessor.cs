using DemoLibrary.DataAcces;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Logic
{
  public static class EmployeeProcessor
    {
        public static int CreateEmplpyee(int employeeId, string firstname, string lastname, string emailadress, string confirmEmail, string password, string confirmpassword)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstname,
                LastName = lastname,
                EmailAdress = emailadress,
                ConfirmEmail = confirmEmail,
                Password = password,
                ConfirmPassword = confirmpassword

            };
            string sql = @"insert into dbo.EmployeeeTable (  EmployeeId, FirstName,  LastName, EmailAdress,  ConfirmEmail, Password,  ConfirmPassword)
                                values( @EmployeeId, @FirstName,  @LastName, @EmailAdress,  @ConfirmEmail, @Password,  @ConfirmPassword);";
            return SqlDataAccess.SaveData(sql, data);
        }
            
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id,EmployeeId, FirstName,  LastName, EmailAdress,  ConfirmEmail, Password,  ConfirmPassword;";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }

    }
}
