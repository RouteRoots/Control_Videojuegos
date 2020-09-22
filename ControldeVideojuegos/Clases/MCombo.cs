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
    class MCombo
    {
        public static int Agregar(Combos reCombo)
        {

            int retorno = 0;
            using (SqlConnection cn = PruebaConexion.ObtenerConexion())
            {

                SqlCommand Comando = new SqlCommand(string.Format("Insert into Combo (IdCombo , Nombre , NoControles , RefAg, PalPas, NoHoras, Costo) values ({0}, '{1}','{2}','{3}','{4}','{5}','{6}')",
                    reCombo.IdCombo, reCombo.Nombre, reCombo.NoControles, reCombo.RefAg, reCombo.PalPas, reCombo.NoHoras, reCombo.Costo), cn);

                retorno = Comando.ExecuteNonQuery();
                cn.Close();

            }
            return retorno;
        }

        // este metodo es para llenar el datagriview del form Buscar Cliente

        public static List<Combos> BuscarCombo(int pIdCombo)
        {

            List<Combos> Lista = new List<Combos>();
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select IdCombo , Nombre, NoControles, RefAg, PalPas, NoHoras, Costo from Combo where IdCombo= {0} ", pIdCombo), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Combos pCombo = new Combos();
                    pCombo.IdCombo = reader.GetInt32(0);
                    pCombo.Nombre = reader.GetString(1);
                    pCombo.NoControles = reader.GetString(2);
                    pCombo.RefAg = reader.GetString(3);
                    pCombo.PalPas= reader.GetString(4);
                    pCombo.NoHoras = reader.GetString(5);
                    pCombo.Costo = reader.GetString(6);

                    Lista.Add(pCombo);

                }
                conexion.Close();
                return Lista;

            }

        }

        public static int Modificar(Combos bCombo, int pIdCombo)
        {
            int retorno = 0;
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Combo set IdCombo={0}, Nombre='{1}', NoControles='{2}', RefAg='{3}', PalPas='{4}', NoHoras='{5}', Costo='{6}' where IdCombo={7}",
                    bCombo.IdCombo, bCombo.Nombre, bCombo.NoControles, bCombo.RefAg, bCombo.PalPas, bCombo.NoHoras, bCombo.Costo, pIdCombo), conexion);


                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }


        public static int Eliminar(Int32 bIdCombo)
        {
            int retorno = 0;
            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from Combo where IdCombo={0}", bIdCombo), conexion);
                retorno = comando.ExecuteNonQuery();

            }
            return retorno;

        }

        //metodo para obtener un cliente por su NumCliente
        public static Combos ObtenerCombo(Int32 pIdCombo)
        {

            using (SqlConnection conexion = PruebaConexion.ObtenerConexion())
            {

                Combos pdCombo = new Combos();
                SqlCommand comando = new SqlCommand(string.Format(
                     "Select IdCombo, Nombre, NoControles, RefAg, PalPas, NoHoras, Costo from Combo where IdCombo= {0} ", pIdCombo), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    pdCombo.IdCombo = reader.GetInt32(0);
                    pdCombo.Nombre = reader.GetString(1);
                    pdCombo.NoControles = reader.GetString(2);
                    pdCombo.RefAg = reader.GetString(3);
                    pdCombo.PalPas = reader.GetString(4);
                    pdCombo.NoHoras = reader.GetString(5);
                    pdCombo.Costo = reader.GetString(6);
                  


                }
                conexion.Close();
                return pdCombo;

            }

        }
    }
}
