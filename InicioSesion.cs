using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEducativo
{
    public partial class InicioSesion : BaseForm
    {
        Conexion conexion = new();

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Tienes los campos en blanco, no te olvides de completarlos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                    using SqlConnection conn = conexion.abrir();
                    using SqlCommand comando = new(query, conn);
                    comando.Parameters.AddWithValue("@username", txt_usuario.Text.Trim());
                    comando.Parameters.AddWithValue("@password", txt_password.Text.Trim());
                    SqlDataAdapter adapter = new(comando);
                    DataTable table = new();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        FormPrincipal Form = new();
                        Form.Show();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Usuario/Contraseña incorrecta, revisa bien los campos!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cb_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cb_mostrar.Checked ? '\0' : '*';
        }
    }
}