using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto_compiladores
{
    class db_conexion
    {
        MySqlConnection cn = new MySqlConnection();
        static string servidor = "localhost";
        static string database = "db_proyecto_compiladores";
        static string usuario = "root";
        static string password = "$Jm@b78%!Uf@";
        static string puerto = "3306";

        string cadena_conexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + database + ";";

        public MySqlConnection conexion_db()
        {
            try 
            {
                cn.ConnectionString = cadena_conexion;
                return cn;
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error de conexión: "+e.ToString());
            }
            return cn;
        }
        
    }
}
