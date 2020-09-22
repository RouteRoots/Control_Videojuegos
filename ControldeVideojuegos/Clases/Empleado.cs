using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeVideojuegos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public String Rfc { get; set; }
        public String Nombre { get; set; }
        public String Edad { get; set; }
        public String Direccion { get; set; }
        public String Correo  { get; set; }
        public String Telefono { get; set; }

        public Empleado() { }

        public Empleado(int reIdEmpleado, String reRfc, String reNombre, String reEdad, String reDireccion, String reCorreo, String reTelefono)
        {
            this.IdEmpleado = reIdEmpleado;
            this.Rfc = reRfc;
            this.Nombre = reNombre;
            this.Edad = reEdad;
            this.Direccion = reDireccion;
            this.Correo = reCorreo;
            this.Telefono = reTelefono;
        }
    }

}
