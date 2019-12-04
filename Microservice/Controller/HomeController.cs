using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Controller
{
    [Route("api/Home")]
    [ApiController]   
    public class HomeController : ControllerBase
    {
        #region Field

        private IuserService _iuserService;

        #endregion

        #region Constructor
        public HomeController(IuserService iuserService)
        {
            _iuserService = iuserService;
        }
        #endregion

        #region Api Methods
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("Getvalues/{value}")]
        public ActionResult<int> Getvalue(int value)
        {
            return value;
        }
        [HttpPost]
        public ActionResult<object> Postvalue(object value=null)
        {
            var result=_iuserService.FetchUserInfo(value);
            return result;
        }
        #endregion
    }
}