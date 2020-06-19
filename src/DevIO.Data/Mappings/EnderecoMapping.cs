using DevIO.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasColumnType("varchar(5)");
            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasColumnType("varchar(30)");
            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasColumnType("varchar(30)");
            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("varchar(2)");
        }
    }
}
