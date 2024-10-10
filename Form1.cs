namespace SistemaEducativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pnl_carga.Width += 6;
            if (pnl_carga.Width >= 750)
            {
                timer.Stop();

                InicioSesion Form = new InicioSesion();
                Form.Show();
                this.Hide();
            }
        }
    }
}
