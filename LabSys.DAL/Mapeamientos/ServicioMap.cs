using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class ServicioMap : IEntityTypeConfiguration<Servicio>
    {
        public void Configure(EntityTypeBuilder<Servicio> builder)
        {
            builder.Property(s => s.ServicioId).IsRequired();
            builder.Property(s => s.Nombre).IsRequired().HasMaxLength(30);
            builder.Property(s => s.Monto).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.UsuarioId).IsRequired();

            builder.HasOne(s => s.Usuario).WithMany(s => s.Servicios).HasForeignKey(s => s.UsuarioId);
            builder.HasMany(s => s.ServicioPropiedades).WithOne(s => s.Servicio);

            builder.ToTable("Servicios");
        }
    }
}
