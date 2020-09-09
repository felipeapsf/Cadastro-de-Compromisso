using AutoMapper;
using Projeto.Data.Entities;
using Projeto.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Services.Mappings
{
    public class EntityToModelMap : Profile
    {
        //ctor
        public EntityToModelMap()
        {
            CreateMap<Compromisso, CompromissoConsultaModel>();
        }
    }
}
