using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Pago
    {
        public int PagoID { get; set; }
        public string UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int DeudaID { get; set; }
        public Deuda Deuda { get; set; }
        public virtual Mes Mes { get; set; }
        public DateTime? FechaPago { get; set; }
        public StatusPago Status { get; set; }
    }

    public enum StatusPago
    {
        Pagado, Pendiente, Atrasado
    }
}
