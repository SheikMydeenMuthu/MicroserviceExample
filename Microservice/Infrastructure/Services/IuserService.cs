using Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Infrastructure.Services
{
    public interface IuserService
    {
        public EmployeeModel FetchUserInfo(EmployeeModel value);
    }
}
