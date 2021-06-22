using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.BLL.Models
{
    public class ServicioPropiedad
    {
        public int ServicioPropiedadId { get; set; }
        public int ServicioId { get; set; }
        public virtual Servicio Servicio { get; set; }
        public DateTime FechaEjecutada { get; set; }
    }
}
