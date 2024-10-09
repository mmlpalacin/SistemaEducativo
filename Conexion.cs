using System;
using System.Data.SqlClient;

namespace SistemaEducativo
{
    public class Conexion
    {
        string cadena = "Data Source=MILUCHI\\SQLEXPRESS; database=SistemaEscolar3;Integrated Security=True;Connect Timeout=30";
        SqlConnection conexion = new SqlConnection();
        public Conexion()
        {
            conexion.ConnectionString = cadena;
        }

        public SqlConnection abrir()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return conexion;
        }
        public void cerrar()
        {
            conexion.Close();
        }
    }
}
