using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class VehiculoMap : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.HasKey(v => v.VehiculoId);

            builder.Property(v => v.Nombre).IsRequired().HasMaxLength(40);
            builder.Property(v => v.Color).IsRequired().HasMaxLength(20);
            builder.Property(v => v.Marca).IsRequired().HasMaxLength(20);
            builder.Property(v => v.Placa).IsRequired().HasMaxLength(20);
            builder.HasIndex(v => v.Placa).IsUnique();
            builder.Property(v => v.UsuarioId).IsRequired();

            builder.HasOne(v => v.Usuario).WithMany(v => v.Vehiculos).HasForeignKey(v => v.UsuarioId);

            builder.ToTable("Vehiculos");

        }
    }
}
