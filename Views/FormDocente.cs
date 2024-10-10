using SistemaEducativo.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEducativo.Views
{
    public partial class FormDocente : Form
    {
        public FormDocente()
        {
            InitializeComponent();
            DocentesController controller = new DocentesController();
            CargarDocentes(controller);
        }

        private void CargarDocentes(DocentesController controller)
        {
            var listaDocentes = controller.DatosDocentes();
            grid_docentes.DataSource = listaDocentes;
        }
    }
}
