namespace eAgenda2._0.WinApp.ModuloTarefa
{
    partial class TelaAtualizacaoItensTarefaForm
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
            txtTitulo = new TextBox();
            Titulo = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            listItensTarefa = new CheckedListBox();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(63, 62);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(480, 23);
            txtTitulo.TabIndex = 14;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(12, 70);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(40, 15);
            Titulo.TabIndex = 13;
            Titulo.Text = "Titulo:";
            // 
            // txtId
            // 
            txtId.Location = new Point(63, 24);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 11;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(472, 479);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(391, 479);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 36);
            btnGravar.TabIndex = 15;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // listItensTarefa
            // 
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.Location = new Point(12, 111);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(534, 346);
            listItensTarefa.TabIndex = 18;
            // 
            // TelaAtualizacaoItensTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 527);
            Controls.Add(listItensTarefa);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(Titulo);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaAtualizacaoItensTarefaForm";
            Text = "Atualização de Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label Titulo;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private CheckedListBox listItensTarefa;
    }
}
