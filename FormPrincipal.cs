using SistemaEducativo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEducativo
{
    public partial class FormPrincipal : BaseForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("¿Estas seguro que quieres salir del sistema?", "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                InicioSesion Form = new();
                Form.Show();
                this.Close();
            }
        }
        private void Btn_profesor_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormDocente());
        }
        private void MostrarFormulario(Form formulario)
        {
            pnl_contenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Size = pnl_contenido.Size;
            formulario.Location = new Point(0, 0);
            pnl_contenido.Controls.Add(formulario);
            formulario.Show();
        }

    }
}
