using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.ApartamentoId);
            builder.Property(a => a.Numero).IsRequired();
            builder.Property(a => a.Piso).IsRequired();
            builder.Property(a => a.Foto).IsRequired();
            builder.Property(a => a.PropietarioId).IsRequired();
            builder.Property(a => a.InquilinoId).IsRequired();

            builder.HasOne(a => a.Propietario).WithMany(a => a.PropietariosApartamentos).HasForeignKey(a => a.PropietarioId);
            builder.HasOne(a => a.Inquilino).WithMany(a => a.InquilinosApartamentos).HasForeignKey(a => a.InquilinoId);

            builder.ToTable("Apartamentos");

        }
    }
}
