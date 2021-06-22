using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabSys.BLL.Models
{
    public class Funcion : IdentityRole<string>
    {
        public string Descripcion { get; set; }
    }
}
