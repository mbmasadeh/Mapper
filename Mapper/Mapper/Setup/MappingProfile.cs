using AutoMapper;
using Mapper.Models;
using Mapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mapper.Setup
{
    public class MappingProfile : Profile
    {
        //Add the mapping classes togather
        public MappingProfile()
        {
            CreateMap<Info, InfoViewModel>();
        }
    }
}
