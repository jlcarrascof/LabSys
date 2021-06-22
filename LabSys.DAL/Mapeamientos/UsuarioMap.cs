using LabSys.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL.Mapeamientos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.DNI).IsRequired().HasMaxLength(12);
            builder.HasIndex(u => u.DNI).IsUnique();
            builder.Property(u => u.Fotografia).IsRequired();
            builder.Property(u => u.PrimerAcceso).IsRequired();
            builder.Property(u => u.Status).IsRequired();

            builder.HasMany(u => u.PropietariosApartamentos).WithOne(u => u.Propietario);
            builder.HasMany(u => u.InquilinosApartamentos).WithOne(u => u.Inquilino);
            builder.HasMany(u => u.Vehiculos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Eventos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Pagos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Servicios).WithOne(u => u.Usuario);

            builder.ToTable("Usuarios");
        }
    }
}
