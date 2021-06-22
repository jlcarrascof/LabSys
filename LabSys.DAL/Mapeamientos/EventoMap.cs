using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(e => e.EventoId);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Fecha).IsRequired();
            builder.Property(e => e.UsuarioId).IsRequired();

            builder.HasOne(e => e.Usuario).WithMany(e => e.Eventos).HasForeignKey(e => e.UsuarioId);

            builder.ToTable("Eventos");
        }
    }
}
