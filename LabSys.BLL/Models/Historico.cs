using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Historico
    {
        public int HistoricoId { get; set; }
        public decimal Monto { get; set; }
        public Tipos Tipo { get; set; }
        public int Dia { get; set; }
        public int MesId { get; set; }
        public virtual Mes Mes { get; set; }
        public int Anio { get; set; }
    }

    public enum Tipos
    {
        Ingreso, Egreso
    }
}
