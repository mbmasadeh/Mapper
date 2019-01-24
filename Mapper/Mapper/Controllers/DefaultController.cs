using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mapper.Models;
using Mapper.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Controllers
{
    [Area("api")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        private readonly IMapper _mapper;
        public DefaultController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get([FromBody] Info info)
        {
            var service = new InfoService(_mapper);//The Constructer in "InfoService" required _mapper
            var mapping = service.MapData(info);
            if(mapping.Equals(true))
                return Ok(mapping);//Mapping went good
            return BadRequest(false);//There is something Wrong
        }
    }
}