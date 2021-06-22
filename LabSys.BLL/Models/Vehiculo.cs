using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, ErrorMessage = "Se permite un máximo de 20 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, ErrorMessage = "Se permite un máximo de 20 caracteres")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, ErrorMessage = "Se permite un máximo de 20 caracteres")]
        public string Color { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Placa { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
