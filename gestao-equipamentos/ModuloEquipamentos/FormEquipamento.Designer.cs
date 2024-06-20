namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    partial class FormEquipamento
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
            lblNumero = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNumero = new TextBox();
            txtNome = new TextBox();
            dateTimePickerFabricacao = new DateTimePicker();
            dateTimePickermanutencao = new DateTimePicker();
            txtFabricante = new TextBox();
            txtNumeroSerie = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelErros = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 9);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Fabricação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 99);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 3;
            label3.Text = "Data ultima manutenção";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 129);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 4;
            label4.Text = "Fabricante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 158);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 5;
            label5.Text = "Número de serie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 187);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 6;
            label6.Text = "Preço";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.Moccasin;
            txtNumero.Location = new Point(165, 6);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(254, 23);
            txtNumero.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Moccasin;
            txtNome.Location = new Point(165, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 8;
            // 
            // dateTimePickerFabricacao
            // 
            dateTimePickerFabricacao.Location = new Point(165, 64);
            dateTimePickerFabricacao.Name = "dateTimePickerFabricacao";
            dateTimePickerFabricacao.Size = new Size(254, 23);
            dateTimePickerFabricacao.TabIndex = 9;
            // 
            // dateTimePickermanutencao
            // 
            dateTimePickermanutencao.Location = new Point(165, 93);
            dateTimePickermanutencao.Name = "dateTimePickermanutencao";
            dateTimePickermanutencao.Size = new Size(254, 23);
            dateTimePickermanutencao.TabIndex = 10;
            // 
            // txtFabricante
            // 
            txtFabricante.BackColor = Color.Moccasin;
            txtFabricante.Location = new Point(165, 126);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(254, 23);
            txtFabricante.TabIndex = 11;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.BackColor = Color.Moccasin;
            txtNumeroSerie.Location = new Point(165, 155);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(254, 23);
            txtNumeroSerie.TabIndex = 12;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.Moccasin;
            txtPreco.Location = new Point(165, 184);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(254, 23);
            txtPreco.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(344, 222);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Adicionar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelErros });
            statusStrip1.Location = new Point(0, 250);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(433, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelErros
            // 
            toolStripStatusLabelErros.ForeColor = Color.Red;
            toolStripStatusLabelErros.Name = "toolStripStatusLabelErros";
            toolStripStatusLabelErros.Size = new Size(36, 17);
            toolStripStatusLabelErros.Text = "Erros:";
            // 
            // FormEquipamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 272);
            Controls.Add(statusStrip1);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtNumeroSerie);
            Controls.Add(txtFabricante);
            Controls.Add(dateTimePickermanutencao);
            Controls.Add(dateTimePickerFabricacao);
            Controls.Add(txtNome);
            Controls.Add(txtNumero);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNumero);
            MaximizeBox = false;
            Name = "FormEquipamento";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEquipamento";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumero;
        private TextBox txtNome;
        private DateTimePicker dateTimePickerFabricacao;
        private DateTimePicker dateTimePickermanutencao;
        private TextBox txtFabricante;
        private TextBox txtNumeroSerie;
        private TextBox txtPreco;
        private Button btnSalvar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelErros;
    }
}