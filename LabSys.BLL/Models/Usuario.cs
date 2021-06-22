using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Usuario : IdentityUser<string>
    {
        public string DNI { get; set; }
        public string Fotografia { get; set; }
        public bool PrimerAcceso { get; set; }
        public StatusCuenta Status { get; set; }
        public virtual ICollection<Apartamento> InquilinosApartamentos { get; set; }
        public virtual ICollection<Apartamento> PropietariosApartamentos { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }

    public enum StatusCuenta
    {
        Verificando, Aprobado, Rechazado
    }
}
