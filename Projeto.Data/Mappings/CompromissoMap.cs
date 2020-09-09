using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Mappings
{
    public class CompromissoMap : IEntityTypeConfiguration<Compromisso>
    {
        public void Configure(EntityTypeBuilder<Compromisso> builder)
        {
            builder.ToTable("Compromisso");
            builder.HasKey(c => c.IdCompromisso);

            builder.Property(c => c.IdCompromisso)
                .HasColumnName("IdCompromisso");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(c => c.Local)
                .HasColumnName("Local")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.DataHora)
                .HasColumnName("DataHora")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnName("Descricao")
                .IsRequired();
        }
    }
}
