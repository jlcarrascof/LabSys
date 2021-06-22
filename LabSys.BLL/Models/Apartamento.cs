using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Apartamento
    {
        public int ApartamentoId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(0, 1000, ErrorMessage = "Número inválido")]
        [Display(Name = "Número")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(0, 10, ErrorMessage = "Piso inválido")]
        public int Piso { get; set; }
        public string Foto { get; set; }
        public string InquilinoId { get; set; }
        public virtual Usuario  Inquilino { get; set; }
        public string PropietarioId { get; set; }
        public virtual Usuario Propietario { get; set; }
    }
}
