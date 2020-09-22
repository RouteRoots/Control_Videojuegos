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
    class MConputadora
    {
        public static int Agregar(Computadora reComputadora)
        {

            int retorno = 0;
            using (SqlConnection cn = PruebaConexion.ObtenerConexion())
            {

                SqlCommand Comando = new SqlCommand(string.Format("Insert into Computadora (IdComputadora , Marca , Capasidad , MemoriaRam, Procesador, Año, Estado, Disponibilidad) values ({0}, '{1}','{2}','{3}','{4}','{5}','{6}', '{7}')",
                    reComputadora.IdComputadora, reComputadora.Marca, reComputadora.Capasidad, reComputadora.MemoriaRam, reComputadora.Procesador, reComputadora.Año, reComputadora.Estado, reComputadora.Disponibilidad), cn);

                retorno = Comando.ExecuteNonQuery();
                cn.Close();

            }
            return retorno;
        }

        internal static int Modificar(Computadora pComputadora, object idComputadora)
        {
            throw new NotImplementedException();
        }

        // este metodo es para llenar el datagriview del form Buscar Cliente

        public static List<Computadora> BuscarComputadora(int pIdComputadora)
        {

            List<Computadora> Lista = new List<Computadora>();
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select IdComputadora , Marca , Capasidad , MemoriaRam, Procesador, Año, Estado, Disponibilidad from Computadora where IdComputadora= {0} ", pIdComputadora), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Computadora pComputadora = new Computadora();
                    pComputadora.IdComputadora = reader.GetInt32(0);
                    pComputadora.Marca = reader.GetString(1);
                    pComputadora.Capasidad = reader.GetString(2);
                    pComputadora.MemoriaRam = reader.GetString(3);
                    pComputadora.Procesador = reader.GetString(4);
                    pComputadora.Año = reader.GetString(5);
                    pComputadora.Estado = reader.GetString(6);
                    pComputadora.Disponibilidad = reader.GetString(7);

                    Lista.Add(pComputadora);

                }
                conexion.Close();
                return Lista;

            }

        }

        internal static int Eliminar(object idComputadora)
        {
            throw new NotImplementedException();
        }

        public static int Modificar(Computadora bComputadora, int pIdComputadora)
        {
            int retorno = 0;
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Computadora set IdComputadora={0}, Marca='{1}', Capasidad='{2}', MemoriaRam='{3}', Procesador='{4}', Año='{5}', Estado='{6}', Disponibilidad='{7}' where IdComputadora={8}",
                    bComputadora.IdComputadora, bComputadora.Marca, bComputadora.Capasidad, bComputadora.MemoriaRam, bComputadora.Procesador, bComputadora.Año, bComputadora.Estado, bComputadora.Disponibilidad, pIdComputadora), conexion);


                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }


        public static int Eliminar(Int32 bIdComputadora)
        {
            int retorno = 0;
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from Computadora where IdComputadora={0}", bIdComputadora), conexion);
                retorno = comando.ExecuteNonQuery();

            }
            return retorno;

        }

        //metodo para obtener un cliente por su NumCliente
        public static Computadora ObtenerCombo(Int32 pIdComputadora)
        {

            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {

                Computadora pdComputadora = new Computadora();
                SqlCommand comando = new SqlCommand(string.Format(
                     "Select IdComputadora , Marca , Capasidad , MemoriaRam, Procesador, Año, Estado, Disponibilidad from Computadora where IdComputadora= {0} ", pIdComputadora), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    pdComputadora.IdComputadora = reader.GetInt32(0);
                    pdComputadora.Marca = reader.GetString(1);
                    pdComputadora.Capasidad = reader.GetString(2);
                    pdComputadora.MemoriaRam = reader.GetString(3);
                    pdComputadora.Procesador = reader.GetString(4);
                    pdComputadora.Año = reader.GetString(5);
                    pdComputadora.Estado = reader.GetString(6);
                    pdComputadora.Disponibilidad = reader.GetString(6);



                }
                conexion.Close();
                return pdComputadora;

            }

        }
    }
}
