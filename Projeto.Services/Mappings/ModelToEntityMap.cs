using AutoMapper;
using Projeto.Data.Entities;
using Projeto.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Services.Mappings
{
    public class ModelToEntityMap : Profile
    {
        //ctor
        public ModelToEntityMap()
        {
            CreateMap<CompromissoCadastroModel, Compromisso>();
            CreateMap<CompromissoEdicaoModel, Compromisso>();
        }
    }
}
