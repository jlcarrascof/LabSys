using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Mes
    {
        public int MesId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Deuda> Deudas { get; set; }
        public virtual ICollection<Historico> Historicos { get; set; }

    }
}
