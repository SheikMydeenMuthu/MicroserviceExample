using Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Infrastructure.Repository
{
    public interface IuserRepository
    {
        public EmployeeModel FetchUserInfo(EmployeeModel value);
    }
}
