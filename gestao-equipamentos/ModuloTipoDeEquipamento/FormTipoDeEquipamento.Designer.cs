namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    partial class FormTipoDeEquipamento
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelErros = new ToolStripStatusLabel();
            btnSalvar = new Button();
            richTxtDescricao = new RichTextBox();
            richTxtComponentes = new RichTextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            label1 = new Label();
            label2 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelErros });
            statusStrip1.Location = new Point(0, 315);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(441, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelErros
            // 
            toolStripStatusLabelErros.ForeColor = Color.Red;
            toolStripStatusLabelErros.Name = "toolStripStatusLabelErros";
            toolStripStatusLabelErros.Size = new Size(36, 17);
            toolStripStatusLabelErros.Text = "Erros:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(354, 289);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Adicionar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // richTxtDescricao
            // 
            richTxtDescricao.Location = new Point(12, 57);
            richTxtDescricao.Name = "richTxtDescricao";
            richTxtDescricao.Size = new Size(417, 93);
            richTxtDescricao.TabIndex = 18;
            richTxtDescricao.Text = "";
            // 
            // richTxtComponentes
            // 
            richTxtComponentes.Location = new Point(12, 181);
            richTxtComponentes.Name = "richTxtComponentes";
            richTxtComponentes.Size = new Size(417, 93);
            richTxtComponentes.TabIndex = 19;
            richTxtComponentes.Text = "";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(118, 13);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(311, 23);
            txtNome.TabIndex = 20;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 22;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 163);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 23;
            label2.Text = "Componentes:";
            // 
            // FormTipoDeEquipamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 337);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(richTxtComponentes);
            Controls.Add(richTxtDescricao);
            Controls.Add(statusStrip1);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            Name = "FormTipoDeEquipamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTipoDeEquipamento";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelErros;
        private Button btnSalvar;
        private RichTextBox richTxtDescricao;
        private RichTextBox richTxtComponentes;
        private TextBox txtNome;
        private Label lblNome;
        private Label label1;
        private Label label2;
    }
}