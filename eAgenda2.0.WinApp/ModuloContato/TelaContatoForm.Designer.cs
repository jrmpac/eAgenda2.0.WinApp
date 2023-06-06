namespace eAgenda2._0.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCargo = new TextBox();
            txtEmail = new TextBox();
            txtEmpresa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(461, 232);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 36);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(542, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 32);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 3;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            txtId.Text = "0";
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 81);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(114, 78);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(503, 23);
            txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(114, 131);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(182, 23);
            txtTelefone.TabIndex = 7;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(114, 171);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(182, 23);
            txtCargo.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(429, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(429, 170);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(188, 23);
            txtEmpresa.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 134);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 11;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 178);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 12;
            label4.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 139);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 13;
            label5.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 174);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 14;
            label6.Text = "Empresa:";
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 280);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(txtCargo);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCargo;
        private TextBox txtEmail;
        private TextBox txtEmpresa;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}