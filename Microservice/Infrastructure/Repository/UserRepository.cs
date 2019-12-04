using Dapper;
using Microservice.Infrastructure.Database;
using Microservice.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Infrastructure.Repository
{
    public class UserRepository : IuserRepository
    {
        private IConfiguration _configuration;
        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public EmployeeModel FetchUserInfo(EmployeeModel employee)
        {
            try
            {
                using (var db = new DatabaseContext(_configuration))
                {
                    //Method 1:Stored procedure

                    //const string sp =
                    //       @"UspSetMobileAppTS_TSAPP";

                    //db.Connection.Execute(sp, new { TimesheetId = timesheetId }, commandType: CommandType.StoredProcedure);

                    //Method 2:Inline Query

                    const string query =
                                @"SELECT * from Employee where Firstname = @firstname";

                    var employeeDetails = db.Connection.Query<EmployeeModel>(query, new { Firstname = employee.FirstName }).FirstOrDefault();

                    return employeeDetails;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
