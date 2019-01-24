using AutoMapper;
using Mapper.Models;
using Mapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mapper.Services
{
    public class InfoService
    {
        private readonly IMapper _mapper;
        public InfoService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool MapData(Info info)
        {
            try
            {
                var mappedinfo = new InfoViewModel();
                var doMapping = _mapper.Map<InfoViewModel>(info);//<Destination>(Source) Both of them must has the same columns name 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
