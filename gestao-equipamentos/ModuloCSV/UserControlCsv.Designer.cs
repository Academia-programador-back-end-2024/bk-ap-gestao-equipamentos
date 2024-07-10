namespace GestaoEquipamentos.WinFormsApp.ModuloCSV
{
    partial class UserControlCsv
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExportar = new Button();
            btnImportar = new Button();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExportar.Location = new Point(101, 119);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(172, 131);
            btnExportar.TabIndex = 0;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += Exportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnImportar.Location = new Point(419, 119);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(172, 131);
            btnImportar.TabIndex = 1;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // UserControlCsv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnImportar);
            Controls.Add(btnExportar);
            Name = "UserControlCsv";
            Size = new Size(688, 389);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExportar;
        private Button btnImportar;
    }
}
