using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Infrastructure.Repository
{
    public interface IuserRepository
    {
        public object FetchUserInfo(object value);
    }
}
