using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Infrastructure.Repository;
using Microservice.Infrastructure.Services;

namespace Microservice.Infrastructure.Services
{
    public class UserService: IuserService
    {
        private readonly IuserRepository _iuserRepository;
        public UserService(IuserRepository iuserRepository)
        {
            _iuserRepository = iuserRepository;
        }
        public object FetchUserInfo(object value)
        {
            return _iuserRepository.FetchUserInfo(value);
        }
    }
}
