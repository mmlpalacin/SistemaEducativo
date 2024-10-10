using System;
using System.Windows.Forms;


namespace SistemaEducativo
{
    public class BaseForm : Form
    {
        private bool confirmadoSalir = false;
        private static int openFormCount = 0;

        public BaseForm()
        {
            openFormCount++;
            this.FormClosed += BaseForm_FormClosed;
            this.FormClosing += BaseForm_FormClosing;
        }

        private void BaseForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            openFormCount--;
        }

        private void BaseForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (openFormCount == 1 && !confirmadoSalir)
            {
                var result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancela el cierre del formulario
                }
                else
                {
                    confirmadoSalir = true; // Se confirma la salida
                    Application.Exit();
                }
            }
        }
    }
}
