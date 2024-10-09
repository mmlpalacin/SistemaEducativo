namespace SistemaEducativo
{
    partial class InicioSesion
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
            pnl_inicio = new Panel();
            btn_ingresar = new Button();
            cb_mostrar = new CheckBox();
            txt_password = new TextBox();
            txt_usuario = new TextBox();
            lbl_password = new Label();
            lbl_usuario = new Label();
            lbl_sign = new Label();
            img_logo = new PictureBox();
            pnl_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_logo).BeginInit();
            SuspendLayout();
            // 
            // pnl_inicio
            // 
            pnl_inicio.BackColor = Color.White;
            pnl_inicio.Controls.Add(btn_ingresar);
            pnl_inicio.Controls.Add(cb_mostrar);
            pnl_inicio.Controls.Add(txt_password);
            pnl_inicio.Controls.Add(txt_usuario);
            pnl_inicio.Controls.Add(lbl_password);
            pnl_inicio.Controls.Add(lbl_usuario);
            pnl_inicio.Controls.Add(lbl_sign);
            pnl_inicio.Controls.Add(img_logo);
            pnl_inicio.Location = new Point(213, 22);
            pnl_inicio.Name = "pnl_inicio";
            pnl_inicio.Size = new Size(350, 400);
            pnl_inicio.TabIndex = 0;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.FromArgb(36, 92, 18);
            btn_ingresar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btn_ingresar.ForeColor = SystemColors.ButtonHighlight;
            btn_ingresar.Location = new Point(25, 331);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(300, 50);
            btn_ingresar.TabIndex = 7;
            btn_ingresar.Text = "LOGIN";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // cb_mostrar
            // 
            cb_mostrar.AutoSize = true;
            cb_mostrar.Location = new Point(163, 286);
            cb_mostrar.Name = "cb_mostrar";
            cb_mostrar.Size = new Size(162, 29);
            cb_mostrar.TabIndex = 6;
            cb_mostrar.Text = "Show Password";
            cb_mostrar.UseVisualStyleBackColor = true;
            cb_mostrar.CheckedChanged += cb_mostrar_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(25, 239);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(300, 31);
            txt_password.TabIndex = 5;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(25, 157);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(300, 31);
            txt_usuario.TabIndex = 4;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(25, 211);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(87, 25);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(25, 129);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(91, 25);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "Username";
            // 
            // lbl_sign
            // 
            lbl_sign.AutoSize = true;
            lbl_sign.Font = new Font("Tahoma", 16F);
            lbl_sign.Location = new Point(25, 53);
            lbl_sign.Name = "lbl_sign";
            lbl_sign.Size = new Size(118, 39);
            lbl_sign.TabIndex = 1;
            lbl_sign.Text = "Sing In";
            // 
            // img_logo
            // 
            img_logo.Image = Properties.Resources.favicon;
            img_logo.Location = new Point(199, 23);
            img_logo.Name = "img_logo";
            img_logo.Size = new Size(100, 101);
            img_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            img_logo.TabIndex = 0;
            img_logo.TabStop = false;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 31, 80);
            ClientSize = new Size(778, 444);
            Controls.Add(pnl_inicio);
            Name = "InicioSesion";
            Text = "Inicio de Sesion";
            pnl_inicio.ResumeLayout(false);
            pnl_inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_inicio;
        private PictureBox img_logo;
        private Label lbl_sign;
        private CheckBox cb_mostrar;
        private TextBox txt_password;
        private TextBox txt_usuario;
        private Label lbl_password;
        private Label lbl_usuario;
        private Button btn_ingresar;
    }
}