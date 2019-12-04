using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Infrastructure.Repository;
using Microservice.Infrastructure.Services;
using Microservice.Model;

namespace Microservice.Infrastructure.Services
{
    public class UserService: IuserService
    {
        private readonly IuserRepository _iuserRepository;
        public UserService(IuserRepository iuserRepository)
        {
            _iuserRepository = iuserRepository;
        }
        public EmployeeModel FetchUserInfo(EmployeeModel employee)
        {
            return _iuserRepository.FetchUserInfo(employee);
        }
    }
}
