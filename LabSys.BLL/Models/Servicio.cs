using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public StatusServicio Status { get; set; }
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public ICollection<ServicioPropiedad> ServicioPropiedades { get; set; }
    }

    public enum StatusServicio
    {
        Pendiente, Rechazado, Aprobado
    }

}
