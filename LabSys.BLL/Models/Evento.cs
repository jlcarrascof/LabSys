using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Evento
   {
        public int EventoId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "Se permite un máximo de 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime Fecha { get; set; }
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
