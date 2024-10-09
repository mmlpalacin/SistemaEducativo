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
    public partial class InicioSesion : Form
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
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

                    using (SqlConnection conn = conexion.abrir())
                    {
                        using (SqlCommand comando = new SqlCommand(query, conn))
                        {
                            comando.Parameters.AddWithValue("@username", txt_usuario.Text.Trim());
                            comando.Parameters.AddWithValue("@password", txt_password.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(comando);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                FormPrincipal Form = new FormPrincipal();
                                Form.Show();
                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("Usuario/Contraseña incorrecta, revisa bien los campos!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cb_mostrar.Checked ? '\0' : '*';
        }
    }
}