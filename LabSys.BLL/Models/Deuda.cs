using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Deuda
    {
        public int DeudaId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Monto inválido")]
        public decimal Monto { get; set; }
        [Display(Name = "Mes")]
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1990, 2025, ErrorMessage = "Año inválido")]
        public int Anio { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
