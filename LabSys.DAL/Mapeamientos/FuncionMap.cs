using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class FuncionMap : IEntityTypeConfiguration<Funcion>
    {
        public void Configure(EntityTypeBuilder<Funcion> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descripcion).IsRequired().HasMaxLength(30);

            builder.HasData(
                new Funcion
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Inquilino",
                    NormalizedName = "INQUILINO",
                    Descripcion = "Inquilino del Apartamento"
                },
                new Funcion
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Responsable",
                    NormalizedName = "Responsable",
                    Descripcion = "Responsable del Apartamento"
                },
                new Funcion
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                    Descripcion = "Administrador del Apartamento"
                }
                );

            builder.ToTable("Funciones");
        }
    }
}
