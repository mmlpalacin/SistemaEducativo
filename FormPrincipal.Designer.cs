namespace SistemaEducativo
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            btn_salir = new Button();
            btn_preceptor = new Button();
            btn_auxiliar = new Button();
            btn_estudiante = new Button();
            btn_profesor = new Button();
            btn_control = new Button();
            pct_logo = new PictureBox();
            pnl_contenido = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pct_logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 31, 80);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(btn_preceptor);
            panel1.Controls.Add(btn_auxiliar);
            panel1.Controls.Add(btn_estudiante);
            panel1.Controls.Add(btn_profesor);
            panel1.Controls.Add(btn_control);
            panel1.Controls.Add(pct_logo);
            panel1.Location = new Point(-1, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 544);
            panel1.TabIndex = 0;
            // 
            // btn_salir
            // 
            btn_salir.AutoSize = true;
            btn_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_salir.BackColor = Color.FromArgb(11, 31, 80);
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_salir.ForeColor = Color.White;
            btn_salir.Image = Properties.Resources.ap;
            btn_salir.ImageAlign = ContentAlignment.TopLeft;
            btn_salir.Location = new Point(60, 456);
            btn_salir.Margin = new Padding(5);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(173, 36);
            btn_salir.TabIndex = 14;
            btn_salir.Text = "Cerrar Sesion";
            btn_salir.TextAlign = ContentAlignment.BottomRight;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += Btn_salir_Click;
            // 
            // btn_preceptor
            // 
            btn_preceptor.BackColor = Color.FromArgb(36, 92, 18);
            btn_preceptor.FlatAppearance.BorderSize = 0;
            btn_preceptor.FlatStyle = FlatStyle.Flat;
            btn_preceptor.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_preceptor.ForeColor = Color.White;
            btn_preceptor.Image = (Image)resources.GetObject("btn_preceptor.Image");
            btn_preceptor.ImageAlign = ContentAlignment.MiddleRight;
            btn_preceptor.Location = new Point(38, 330);
            btn_preceptor.Name = "btn_preceptor";
            btn_preceptor.Size = new Size(217, 46);
            btn_preceptor.TabIndex = 13;
            btn_preceptor.Text = "Añadir Preceptor";
            btn_preceptor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_preceptor.UseVisualStyleBackColor = false;
            // 
            // btn_auxiliar
            // 
            btn_auxiliar.BackColor = Color.FromArgb(36, 92, 18);
            btn_auxiliar.FlatAppearance.BorderSize = 0;
            btn_auxiliar.FlatStyle = FlatStyle.Flat;
            btn_auxiliar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_auxiliar.ForeColor = Color.White;
            btn_auxiliar.Image = (Image)resources.GetObject("btn_auxiliar.Image");
            btn_auxiliar.Location = new Point(38, 382);
            btn_auxiliar.Name = "btn_auxiliar";
            btn_auxiliar.Size = new Size(217, 46);
            btn_auxiliar.TabIndex = 12;
            btn_auxiliar.Text = "Añadir Auxiliar";
            btn_auxiliar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_auxiliar.UseVisualStyleBackColor = false;
            // 
            // btn_estudiante
            // 
            btn_estudiante.BackColor = Color.FromArgb(36, 92, 18);
            btn_estudiante.FlatAppearance.BorderSize = 0;
            btn_estudiante.FlatStyle = FlatStyle.Flat;
            btn_estudiante.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_estudiante.ForeColor = Color.White;
            btn_estudiante.Image = (Image)resources.GetObject("btn_estudiante.Image");
            btn_estudiante.ImageAlign = ContentAlignment.MiddleRight;
            btn_estudiante.Location = new Point(38, 226);
            btn_estudiante.Name = "btn_estudiante";
            btn_estudiante.Padding = new Padding(1);
            btn_estudiante.Size = new Size(217, 46);
            btn_estudiante.TabIndex = 11;
            btn_estudiante.Text = "Añadir Estudiante";
            btn_estudiante.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_estudiante.UseVisualStyleBackColor = false;
            // 
            // btn_profesor
            // 
            btn_profesor.BackColor = Color.FromArgb(36, 92, 18);
            btn_profesor.FlatAppearance.BorderSize = 0;
            btn_profesor.FlatStyle = FlatStyle.Flat;
            btn_profesor.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_profesor.ForeColor = Color.White;
            btn_profesor.Image = (Image)resources.GetObject("btn_profesor.Image");
            btn_profesor.Location = new Point(38, 278);
            btn_profesor.Name = "btn_profesor";
            btn_profesor.Size = new Size(217, 46);
            btn_profesor.TabIndex = 9;
            btn_profesor.Text = "Añadir Profesor";
            btn_profesor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_profesor.UseVisualStyleBackColor = false;
            btn_profesor.Click += Btn_profesor_Click;
            // 
            // btn_control
            // 
            btn_control.BackColor = Color.FromArgb(36, 92, 18);
            btn_control.FlatAppearance.BorderSize = 0;
            btn_control.FlatStyle = FlatStyle.Flat;
            btn_control.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_control.ForeColor = Color.White;
            btn_control.Image = (Image)resources.GetObject("btn_control.Image");
            btn_control.Location = new Point(38, 174);
            btn_control.Name = "btn_control";
            btn_control.Padding = new Padding(1);
            btn_control.Size = new Size(217, 46);
            btn_control.TabIndex = 4;
            btn_control.Text = "Centro de Control";
            btn_control.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_control.UseVisualStyleBackColor = false;
            // 
            // pct_logo
            // 
            pct_logo.Image = Properties.Resources.favicon;
            pct_logo.Location = new Point(78, 29);
            pct_logo.Name = "pct_logo";
            pct_logo.Size = new Size(136, 126);
            pct_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_logo.TabIndex = 0;
            pct_logo.TabStop = false;
            // 
            // pnl_contenido
            // 
            pnl_contenido.Location = new Point(295, -3);
            pnl_contenido.Name = "pnl_contenido";
            pnl_contenido.Size = new Size(793, 536);
            pnl_contenido.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 527);
            Controls.Add(pnl_contenido);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            Text = "Inicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pct_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_control;
        private PictureBox pct_logo;
        private Button btn_preceptor;
        private Button btn_auxiliar;
        private Button btn_estudiante;
        private Button btn_profesor;
        private Button btn_salir;
        private Panel pnl_contenido;
    }
}