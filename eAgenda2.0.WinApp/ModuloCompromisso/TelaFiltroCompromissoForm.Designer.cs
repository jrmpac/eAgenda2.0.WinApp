namespace eAgenda2._0.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissoForm
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
            btnFiltrar = new Button();
            btnCancelar = new Button();
            rdbTodos = new RadioButton();
            rdbPassados = new RadioButton();
            rdbFuturos = new RadioButton();
            txtDataInicio = new DateTimePicker();
            txtDataFinal = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(316, 317);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(82, 38);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(404, 317);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 38);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Location = new Point(33, 21);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(206, 19);
            rdbTodos.TabIndex = 2;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todos os Compromissos";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbPassados
            // 
            rdbPassados.AutoSize = true;
            rdbPassados.Location = new Point(33, 56);
            rdbPassados.Name = "rdbPassados";
            rdbPassados.Size = new Size(208, 19);
            rdbPassados.TabIndex = 3;
            rdbPassados.TabStop = true;
            rdbPassados.Text = "Visualizar Compromissos Passados";
            rdbPassados.UseVisualStyleBackColor = true;
            rdbPassados.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbFuturos
            // 
            rdbFuturos.AutoSize = true;
            rdbFuturos.Location = new Point(33, 92);
            rdbFuturos.Name = "rdbFuturos";
            rdbFuturos.Size = new Size(200, 19);
            rdbFuturos.TabIndex = 4;
            rdbFuturos.TabStop = true;
            rdbFuturos.Text = "Visualizar Compromissos Futuros";
            rdbFuturos.UseVisualStyleBackColor = true;
            // 
            // txtDataInicio
            // 
            txtDataInicio.Location = new Point(111, 163);
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(200, 23);
            txtDataInicio.TabIndex = 5;
            // 
            // txtDataFinal
            // 
            txtDataFinal.Location = new Point(111, 201);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(200, 23);
            txtDataFinal.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 167);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 207);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 367);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDataFinal);
            Controls.Add(txtDataInicio);
            Controls.Add(rdbFuturos);
            Controls.Add(rdbPassados);
            Controls.Add(rdbTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Compromissos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton rdbTodos;
        private RadioButton rdbPassados;
        private RadioButton rdbFuturos;
        private DateTimePicker txtDataInicio;
        private DateTimePicker txtDataFinal;
        private Label label1;
        private Label label2;
    }
}