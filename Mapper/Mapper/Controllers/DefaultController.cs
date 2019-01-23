using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMapper _mapper;
        public DefaultController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Info info)
        {
            return View();
        }
    }
}