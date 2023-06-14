namespace eAgenda2._0.WinApp.ModuloTarefa
{
    partial class TelaFiltroTarefaForm
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
            rdbPendentes = new RadioButton();
            rdbConcluidas = new RadioButton();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(111, 172);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(82, 38);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(199, 172);
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
            rdbTodos.Size = new Size(160, 19);
            rdbTodos.TabIndex = 2;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todas as Tarefas";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize = true;
            rdbPendentes.Location = new Point(33, 56);
            rdbPendentes.Name = "rdbPendentes";
            rdbPendentes.Size = new Size(171, 19);
            rdbPendentes.TabIndex = 3;
            rdbPendentes.TabStop = true;
            rdbPendentes.Text = "Visualizar Tarefas Pendentes";
            rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbConcluidas
            // 
            rdbConcluidas.AutoSize = true;
            rdbConcluidas.Location = new Point(33, 92);
            rdbConcluidas.Name = "rdbConcluidas";
            rdbConcluidas.Size = new Size(175, 19);
            rdbConcluidas.TabIndex = 4;
            rdbConcluidas.TabStop = true;
            rdbConcluidas.Text = "Visualizar Tarefas Concluidas";
            rdbConcluidas.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 222);
            Controls.Add(rdbConcluidas);
            Controls.Add(rdbPendentes);
            Controls.Add(rdbTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroTarefaForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton rdbTodos;
        private RadioButton rdbPendentes;
        private RadioButton rdbConcluidas;
        private DateTimePicker txtDataInicio;
        private DateTimePicker txtDataFinal;
    }
}