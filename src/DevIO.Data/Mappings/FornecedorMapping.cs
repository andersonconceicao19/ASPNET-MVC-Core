﻿using DevIO.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");
            builder.Property(f => f.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.HasMany(f => f.Produtos)
                .WithOne(p => p.Fornecedor)
                .HasForeignKey(x => x.FornecedorId);

            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Fornecedor);
                
        }
    }
}
