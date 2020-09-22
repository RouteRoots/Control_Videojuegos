using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeVideojuegos
{
    class Combos
    {
        public int IdCombo { get; set; }
        public String Nombre { get; set; }
        public String NoControles { get; set; }
        public String RefAg { get; set; }
        public String PalPas { get; set; }
        public String NoHoras { get; set; }
        public String Costo { get; set; }

        public Combos() { }

        public Combos(int reIdCombo, String reNombre, String reNoControles, String reRefAg, String rePalPas, String reNoHoras, String reCosto)
        {
            this.IdCombo = reIdCombo;
            this.Nombre = reNombre;
            this.NoControles = reNoControles;
            this.RefAg = reRefAg;
            this.PalPas = rePalPas;
            this.NoHoras = reNoHoras;
            this.Costo = reCosto;
        }
    }
}
