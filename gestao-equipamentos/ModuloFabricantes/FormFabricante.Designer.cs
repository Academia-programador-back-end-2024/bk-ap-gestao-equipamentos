namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{
    partial class FormFabricante
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
            dateTimePickerCadastro = new DateTimePicker();
            txtNome = new TextBox();
            txtFornecedor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblFornecedor = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelErros = new ToolStripStatusLabel();
            btnSalvar = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerCadastro
            // 
            dateTimePickerCadastro.Location = new Point(165, 76);
            dateTimePickerCadastro.Name = "dateTimePickerCadastro";
            dateTimePickerCadastro.Size = new Size(254, 23);
            dateTimePickerCadastro.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Moccasin;
            txtNome.Location = new Point(165, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 14;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.Moccasin;
            txtFornecedor.Location = new Point(165, 18);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(254, 23);
            txtFornecedor.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 82);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 12;
            label2.Text = "Data Cadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(12, 21);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(67, 15);
            lblFornecedor.TabIndex = 10;
            lblFornecedor.Text = "Fornecedor";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelErros });
            statusStrip1.Location = new Point(0, 204);
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
            btnSalvar.Location = new Point(346, 128);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Adicionar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormFabricante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 226);
            Controls.Add(statusStrip1);
            Controls.Add(btnSalvar);
            Controls.Add(dateTimePickerCadastro);
            Controls.Add(txtNome);
            Controls.Add(txtFornecedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFornecedor);
            Name = "FormFabricante";
            Text = "FormFabricante";
            Load += FormFabricante_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerCadastro;
        private TextBox txtNome;
        private TextBox txtFornecedor;
        private Label label2;
        private Label label1;
        private Label lblFornecedor;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelErros;
        private Button btnSalvar;
    }
}