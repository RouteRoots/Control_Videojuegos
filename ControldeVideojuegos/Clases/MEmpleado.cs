using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Input;

namespace ControldeVideojuegos
{
    class MEmpleado
    {
       
        public static int Agregar(Empleado reEpleado)
        {
            
            int retorno = 0;
            using (SqlConnection cn = PruebaConexion.ObtenerConexion())
            {
                
                SqlCommand Comando = new SqlCommand(string.Format("Insert into Empleado (IdEmpleado , Rfc , Nombre , Edad, Direccion, Correo, Telefono) values ({0}, '{1}','{2}','{3}','{4}','{5}','{6}')",
                    reEpleado.IdEmpleado, reEpleado.Rfc, reEpleado.Nombre, reEpleado.Edad, reEpleado.Direccion, reEpleado.Correo, reEpleado.Telefono), cn);
               
                retorno = Comando.ExecuteNonQuery();
                cn.Close();

            }
            return retorno;
        }

        // este metodo es para llenar el datagriview del form Buscar Cliente

        public static List<Empleado> BuscarEmpleado(int pIdEmpleado)
        {

            List<Empleado> Lista = new List<Empleado>();
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select IdEmpleado , Rfc , Nombre, Edad, Direccion, Correo, Telefono from Empleado where IdEmpleado= {0} ", pIdEmpleado), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado pEmpleado = new Empleado();
                    pEmpleado.IdEmpleado = reader.GetInt32(0);
                    pEmpleado.Rfc = reader.GetString(1);
                    pEmpleado.Nombre = reader.GetString(2);
                    pEmpleado.Edad = reader.GetString(3);
                    pEmpleado.Direccion = reader.GetString(4);
                    pEmpleado.Correo = reader.GetString(5);
                    pEmpleado.Telefono = reader.GetString(6);

                    Lista.Add(pEmpleado);

                }
                conexion.Close();
                return Lista;

            }

        }

        public static int Modificar(Empleado bEpleado, int pIdEmpleado)
        {
            int retorno = 0;
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Empleado set IdEmpleado={0}, Rfc='{1}', Nombre='{2}', Edad='{3}', Direccion='{4}', Correo='{5}', Telefono='{6}' where IdEmpleado={7}",
                    bEpleado.IdEmpleado, bEpleado.Rfc, bEpleado.Nombre, bEpleado.Edad, bEpleado.Direccion, bEpleado.Correo, bEpleado.Telefono, pIdEmpleado), conexion);
                

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }


        public static int Eliminar(Int32 bIdEmpleado)
        {
            int retorno = 0;
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {
                
                SqlCommand comando = new SqlCommand(string.Format("Delete from Empleado where IdEmpleado={0}", bIdEmpleado), conexion);
                retorno = comando.ExecuteNonQuery();
                
            }
            return retorno;

        }

        //metodo para obtener un cliente por su NumCliente
        public static Empleado ObtenerEmpleado(Int32 pIdEmpleado)
        {

            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {

                Empleado pdEmpleado = new Empleado();
                SqlCommand comando = new SqlCommand(string.Format(
                     "Select IdEmpleado , Rfc , Nombre , Edad, Direccion, Correo, Telefono from Empleado where IdEmpleado= {0} ", pIdEmpleado), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    pdEmpleado.IdEmpleado = reader.GetInt32(0);
                    pdEmpleado.Rfc = reader.GetString(1);
                    pdEmpleado.Nombre = reader.GetString(2);
                    pdEmpleado.Edad = reader.GetString(3);
                    pdEmpleado.Direccion = reader.GetString(4);
                    pdEmpleado.Correo = reader.GetString(5);
                    pdEmpleado.Telefono = reader.GetString(6);



                }
                conexion.Close();
                return pdEmpleado;

            }

        }

    }
}
