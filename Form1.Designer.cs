namespace SistemaEducativo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            img_logo = new PictureBox();
            label1 = new Label();
            pnl_principal = new Panel();
            pnl_carga = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)img_logo).BeginInit();
            pnl_principal.SuspendLayout();
            SuspendLayout();
            // 
            // img_logo
            // 
            img_logo.Image = Properties.Resources.favicon;
            img_logo.Location = new Point(252, 32);
            img_logo.Margin = new Padding(4, 5, 4, 5);
            img_logo.Name = "img_logo";
            img_logo.Size = new Size(256, 255);
            img_logo.SizeMode = PictureBoxSizeMode.AutoSize;
            img_logo.TabIndex = 0;
            img_logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F);
            label1.ForeColor = Color.Ivory;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(182, 312);
            label1.Name = "label1";
            label1.Size = new Size(390, 49);
            label1.TabIndex = 1;
            label1.Text = "Escuela Tecnica N°3";
            // 
            // pnl_principal
            // 
            pnl_principal.Controls.Add(pnl_carga);
            pnl_principal.Dock = DockStyle.Bottom;
            pnl_principal.Location = new Point(0, 414);
            pnl_principal.Margin = new Padding(4, 5, 4, 5);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(778, 30);
            pnl_principal.TabIndex = 3;
            // 
            // pnl_carga
            // 
            pnl_carga.BackColor = Color.FromArgb(36, 92, 18);
            pnl_carga.Location = new Point(0, 0);
            pnl_carga.Name = "pnl_carga";
            pnl_carga.Size = new Size(80, 30);
            pnl_carga.TabIndex = 4;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 31, 80);
            ClientSize = new Size(778, 444);
            Controls.Add(pnl_principal);
            Controls.Add(label1);
            Controls.Add(img_logo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)img_logo).EndInit();
            pnl_principal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox img_logo;
        private Label label1;
        private Panel pnl_principal;
        private Panel pnl_carga;
        private System.Windows.Forms.Timer timer;
    }
}
