using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Controllers
{
    [EnableCors("any")]
    [Route("api/[controller]")]
    //ApiController 特性对get请求方式没有影响。
    //ApiController 可以自动推断参数的绑定模型。所以不需要[FromBody]或者[FromData]。
    //ApiController 可以自动验证模型状态，如果验证不通过，会自动返回400
    [ApiController]  
    public class HomeController : ControllerBase
    {
        [HttpGet] //使用swagger以后必须为方法标注请求方式
        public string Get() 
        {
            return "OK";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "OK";
        }


        [HttpPost]
        public string Post()
        {
            return "OK";
        }

        [HttpPut]
        public string Put()
        {
            return "OK";
        }

        [HttpDelete]
        public string Delete() 
        {
            return "OK";
        }
    }
}
