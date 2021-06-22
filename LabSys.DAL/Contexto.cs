using LabSys.BLL.Models;
using LabSys.DAL.Mapeamientos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.DAL
{
    public class Contexto : IdentityDbContext<Usuario, Funcion, string>
    {
        public DbSet<Deuda> Deudas { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Mes> Meses { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<ServicioPropiedad> ServicioPropiedades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DeudaMap());
            builder.ApplyConfiguration(new ApartamentoMap());
            builder.ApplyConfiguration(new EventoMap());
            builder.ApplyConfiguration(new FuncionMap());
            builder.ApplyConfiguration(new HistoricoMap());
            builder.ApplyConfiguration(new MesMap());
            builder.ApplyConfiguration(new ServicioMap());
            builder.ApplyConfiguration(new ServicioPropiedadMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new VehiculoMap());
        }

    }
}
