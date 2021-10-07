using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Escuela
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int anio { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        //public TipoEscuela listTipoEscuela = new TipoEscuela();
    }
}
