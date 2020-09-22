using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeVideojuegos
{
    class Computadora
    {
        public int IdComputadora { get; set; }
        public String Marca { get; set; }
        public String Capasidad { get; set; }
        public String MemoriaRam { get; set; }
        public String Procesador { get; set; }
        public String Año { get; set; }
        public String Estado { get; set; }
        public String Disponibilidad { get; set; }

        public Computadora() { }
        public Computadora ComputadoraActual { get; set; }
        
        public Computadora ComputadoraSeleccionado { get; set; }

        public Computadora(int reIdComputadora, String reMarca, String reCapasidad, String reMemoriaRam, String reProcesador, String reAño, String reEstado, String reDisponibilidad)
        {
            this.IdComputadora = reIdComputadora;
            this.Marca = reMarca;
            this.Capasidad = reCapasidad;
            this.MemoriaRam = reMemoriaRam;
            this.Procesador = reProcesador;
            this.Año = reAño;
            this.Estado = reEstado;
            this.Disponibilidad = reDisponibilidad;
        }
    }
}
