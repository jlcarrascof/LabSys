using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class HistoricoMap : IEntityTypeConfiguration<Historico>
    {
        public void Configure(EntityTypeBuilder<Historico> builder)
        {
            builder.HasKey(h => h.HistoricoId);
            builder.Property(h => h.Monto).IsRequired();
            builder.Property(h => h.Tipo).IsRequired();
            builder.Property(h => h.Dia).IsRequired();
            builder.Property(h => h.MesId).IsRequired(); 
            builder.Property(h => h.Anio).IsRequired(); 

            builder.HasOne(h => h.Mes).WithMany(e => e.Historicos).HasForeignKey(h => h.MesId);

            builder.ToTable("Historicos");
        }
    }
}
