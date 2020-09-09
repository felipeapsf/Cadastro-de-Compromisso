using Projeto.Data.Context;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Repositories
{
    public class CompromissoRepository : BaseRepository<Compromisso>, ICompromissoRepository
    {
        //atributo
        private readonly DataContext context;

        //construtor para injeção de dependência
        public CompromissoRepository(DataContext context) : base(context) //construtor da superclasse
        {
            this.context = context;
        }
    }
}
