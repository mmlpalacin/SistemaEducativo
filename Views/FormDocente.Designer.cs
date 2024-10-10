namespace SistemaEducativo.Views
{
    partial class FormDocente
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
            grid_docentes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_docentes).BeginInit();
            SuspendLayout();
            // 
            // grid_docentes
            // 
            grid_docentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_docentes.Dock = DockStyle.Fill;
            grid_docentes.Location = new Point(0, 0);
            grid_docentes.Name = "grid_docentes";
            grid_docentes.RowHeadersWidth = 62;
            grid_docentes.Size = new Size(800, 450);
            grid_docentes.TabIndex = 0;
            // 
            // FormDocente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grid_docentes);
            Name = "FormDocente";
            Text = "FormDocente";
            ((System.ComponentModel.ISupportInitialize)grid_docentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid_docentes;
    }
}