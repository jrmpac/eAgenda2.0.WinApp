namespace eAgenda2._0.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            txtTitulo = new TextBox();
            Titulo = new Label();
            txtId = new TextBox();
            label1 = new Label();
            cmbPrioridade = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtDataCriacao = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(520, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(439, 262);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 36);
            btnGravar.TabIndex = 3;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(85, 80);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(503, 23);
            txtTitulo.TabIndex = 10;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(36, 88);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(40, 15);
            Titulo.TabIndex = 9;
            Titulo.Text = "Titulo:";
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 50);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 7;
            label1.Text = "Id:";
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(85, 117);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(121, 23);
            cmbPrioridade.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 12;
            label3.Text = "Prioridade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 125);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 13;
            label4.Text = "Data de Criação:";
            // 
            // txtDataCriacao
            // 
            txtDataCriacao.Location = new Point(345, 119);
            txtDataCriacao.Name = "txtDataCriacao";
            txtDataCriacao.Size = new Size(200, 23);
            txtDataCriacao.TabIndex = 14;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 310);
            Controls.Add(txtDataCriacao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbPrioridade);
            Controls.Add(txtTitulo);
            Controls.Add(Titulo);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtTitulo;
        private Label Titulo;
        private TextBox txtId;
        private Label label1;
        private ComboBox cmbPrioridade;
        private Label label3;
        private Label label4;
        private DateTimePicker txtDataCriacao;
    }
}