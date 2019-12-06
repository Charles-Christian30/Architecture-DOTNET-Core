using AutoMapper;
using le_site.Data.Dto;
using le_site.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace le_site.web.Mapping
{
    public class PersonneMapping : Profile
    {
        public PersonneMapping()
        {
            CreateMap<Personne, PersonneDto>();
            CreateMap<PersonneDto, Personne>()
                .ForMember(v => v.Id, opt => opt.Ignore());
        }
    }
}
