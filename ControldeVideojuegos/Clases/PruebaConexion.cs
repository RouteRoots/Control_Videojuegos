using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControldeVideojuegos
{
    class PruebaConexion
    {
        


        public static SqlConnection ObtenerConexion()
        {
            SqlConnection cn;
            
                cn  = new SqlConnection("Data Source=DESKTOP-0PCN940\\SQLEXPRESS;Initial Catalog=sisCVid;Integrated Security=True");
                cn.Open();
                
            
           

            return cn;
        }
        
   

    }                                                           

}
