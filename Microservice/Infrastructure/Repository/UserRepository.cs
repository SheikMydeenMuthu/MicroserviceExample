using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Infrastructure.Repository
{
    public class UserRepository:IuserRepository
    {
        public UserRepository()
        {

        }
        public object FetchUserInfo(object value)
        {
            return value;
        }
    }
}
