using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class ServicioPropiedadMap : IEntityTypeConfiguration<ServicioPropiedad>
    {
        public void Configure(EntityTypeBuilder<ServicioPropiedad> builder)
        {
            builder.HasKey(sp => sp.ServicioPropiedadId);
            builder.Property(sp => sp.ServicioId).IsRequired();
            builder.Property(sp => sp.FechaEjecutada).IsRequired();

            builder.HasOne(sp => sp.Servicio).WithMany(sp => sp.ServicioPropiedades).HasForeignKey(sp => sp.ServicioId);

            builder.ToTable("ServicioPropiedades");
        }
    }
}
