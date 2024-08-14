using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodigo2024.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}