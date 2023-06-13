namespace eAgenda2._0.WinApp.ModuloTarefa
{
    partial class TelaCadastroItensTarefaForm
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
            listItems = new ListBox();
            txtDescricaoItem = new TextBox();
            label2 = new Label();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(85, 63);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(480, 23);
            txtTitulo.TabIndex = 14;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(34, 71);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(40, 15);
            Titulo.TabIndex = 13;
            Titulo.Text = "Titulo:";
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 25);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 33);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 11;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(493, 479);
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
            btnGravar.Location = new Point(412, 479);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 36);
            btnGravar.TabIndex = 15;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // listItems
            // 
            listItems.FormattingEnabled = true;
            listItems.ItemHeight = 15;
            listItems.Location = new Point(13, 157);
            listItems.Name = "listItems";
            listItems.Size = new Size(552, 304);
            listItems.TabIndex = 17;
            // 
            // txtDescricaoItem
            // 
            txtDescricaoItem.Location = new Point(85, 106);
            txtDescricaoItem.Name = "txtDescricaoItem";
            txtDescricaoItem.Size = new Size(332, 23);
            txtDescricaoItem.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 114);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 18;
            label2.Text = "Descrição:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(449, 106);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 20;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroItensTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 527);
            Controls.Add(btnAdicionar);
            Controls.Add(txtDescricaoItem);
            Controls.Add(label2);
            Controls.Add(listItems);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(Titulo);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaCadastroItensTarefaForm";
            Text = "Cadastro de Item da Tarefa";
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
        private ListBox listItems;
        private TextBox txtDescricaoItem;
        private Label label2;
        private Button btnAdicionar;
    }
}