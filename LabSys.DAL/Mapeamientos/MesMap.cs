using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.MesId);
            builder.Property(m => m.MesId).ValueGeneratedNever();
            
            builder.Property(m => m.Nombre).IsRequired().HasMaxLength(30);
            builder.HasIndex(m => m.Nombre).IsUnique();

            builder.HasMany(m => m.Deudas).WithOne(m => m.Mes);
            builder.HasMany(m => m.Historicos).WithOne(m => m.Mes);

            builder.HasData(
                new Mes
                {
                    MesId = 1,
                    Nombre = "Enero"
                },
                new Mes
                {
                    MesId = 2,
                    Nombre = "Febrero"
                },
                new Mes
                {
                    MesId = 3,
                    Nombre = "Marzo"
                },
                new Mes
                {
                    MesId = 4,
                    Nombre = "Abril"
                },
                new Mes
                {
                    MesId = 5,
                    Nombre = "Mayo"
                },
                new Mes
                {
                    MesId = 6,
                    Nombre = "Junio"
                },
                new Mes
                {
                    MesId = 7,
                    Nombre = "Julio"
                },
                new Mes
                {
                    MesId = 8,
                    Nombre = "Agosto"
                },
                new Mes
                {
                    MesId = 9,
                    Nombre = "Septiembre"
                },
                new Mes
                {
                    MesId = 10,
                    Nombre = "Octubre"
                },
                new Mes
                {
                    MesId = 11,
                    Nombre = "Noviembre"
                },
                new Mes
                {
                    MesId = 12,
                    Nombre = "Diciembre"
                }
            );

            builder.ToTable("Meses");

        }
    }
}
