using Microsoft.EntityFrameworkCore;
using Projeto.Data.Entities;
using Projeto.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Context
{
    public class DataContext : DbContext
    {
        //construtor para receber a string de conexão que será
        //enviada pela classe Startup.cs
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //sobrescrita do método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento do EntityFramework
            modelBuilder.ApplyConfiguration(new CompromissoMap());
        }

        //declarar uma propriedade DbSet para cada entidade
        public DbSet<Compromisso> Compromisso { get; set; }
    }
}
