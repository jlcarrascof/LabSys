using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class DeudaMap : IEntityTypeConfiguration<Deuda>
    {
        public void Configure(EntityTypeBuilder<Deuda> builder)
        {
            builder.HasKey(d => d.DeudaId);
            builder.Property(d => d.Monto).IsRequired();
            builder.Property(d => d.MesId).IsRequired();
            builder.Property(d => d.Anio).IsRequired();

            builder.HasOne(d => d.Mes).WithMany(d => d.Deudas).HasForeignKey(d => d.MesId);
            builder.HasMany(d => d.Pagos).WithOne(d => d.Deuda);

            builder.ToTable("Deudas");
        }
    }
}
