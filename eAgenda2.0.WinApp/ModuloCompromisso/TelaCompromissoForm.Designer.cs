﻿namespace eAgenda2._0.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            lblId = new Label();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            lblAssunto = new Label();
            lblData = new Label();
            lblHorarioInicio = new Label();
            txtData = new DateTimePicker();
            txtHorarioInicio = new DateTimePicker();
            txtHorarioFinal = new DateTimePicker();
            lblHorarioFinal = new Label();
            lblContato = new Label();
            cmbContatos = new ComboBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            txtLocalOnline = new TextBox();
            txtLocalPresencial = new TextBox();
            rdbPresencial = new RadioButton();
            rdbOnline = new RadioButton();
            chkSelecionarContato = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(44, 38);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(74, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(74, 78);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(401, 23);
            txtAssunto.TabIndex = 2;
            // 
            // lblAssunto
            // 
            lblAssunto.AutoSize = true;
            lblAssunto.Location = new Point(11, 81);
            lblAssunto.Name = "lblAssunto";
            lblAssunto.Size = new Size(53, 15);
            lblAssunto.TabIndex = 3;
            lblAssunto.Text = "Assunto:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(30, 119);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 4;
            lblData.Text = "Data:";
            // 
            // lblHorarioInicio
            // 
            lblHorarioInicio.Location = new Point(16, 153);
            lblHorarioInicio.Name = "lblHorarioInicio";
            lblHorarioInicio.Size = new Size(52, 41);
            lblHorarioInicio.TabIndex = 5;
            lblHorarioInicio.Text = "Horário Inicio:";
            lblHorarioInicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(74, 113);
            txtData.Name = "txtData";
            txtData.Size = new Size(136, 23);
            txtData.TabIndex = 8;
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.CustomFormat = "HH:mm";
            txtHorarioInicio.Format = DateTimePickerFormat.Custom;
            txtHorarioInicio.Location = new Point(74, 160);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.ShowUpDown = true;
            txtHorarioInicio.Size = new Size(136, 23);
            txtHorarioInicio.TabIndex = 9;
            // 
            // txtHorarioFinal
            // 
            txtHorarioFinal.CustomFormat = "HH:mm";
            txtHorarioFinal.Format = DateTimePickerFormat.Custom;
            txtHorarioFinal.Location = new Point(329, 160);
            txtHorarioFinal.Name = "txtHorarioFinal";
            txtHorarioFinal.ShowUpDown = true;
            txtHorarioFinal.Size = new Size(106, 23);
            txtHorarioFinal.TabIndex = 10;
            // 
            // lblHorarioFinal
            // 
            lblHorarioFinal.Location = new Point(257, 156);
            lblHorarioFinal.Name = "lblHorarioFinal";
            lblHorarioFinal.Size = new Size(66, 35);
            lblHorarioFinal.TabIndex = 11;
            lblHorarioFinal.Text = "Horário Final:";
            lblHorarioFinal.TextAlign = ContentAlignment.MiddleRight;
            lblHorarioFinal.Click += label5_Click;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(270, 218);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(53, 15);
            lblContato.TabIndex = 12;
            lblContato.Text = "Contato:";
            // 
            // cmbContatos
            // 
            cmbContatos.DisplayMember = "nome";
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Enabled = false;
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(329, 215);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(146, 23);
            cmbContatos.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(429, 461);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 38);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(349, 461);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(74, 38);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocalOnline);
            groupBox1.Controls.Add(txtLocalPresencial);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(rdbOnline);
            groupBox1.Location = new Point(30, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 143);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo do Local";
            // 
            // txtLocalOnline
            // 
            txtLocalOnline.Location = new Point(106, 84);
            txtLocalOnline.Name = "txtLocalOnline";
            txtLocalOnline.Size = new Size(339, 23);
            txtLocalOnline.TabIndex = 23;
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Location = new Point(106, 55);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(339, 23);
            txtLocalPresencial.TabIndex = 22;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(22, 55);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(78, 19);
            rdbPresencial.TabIndex = 14;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Location = new Point(40, 84);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(60, 19);
            rdbOnline.TabIndex = 16;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online";
            rdbOnline.UseVisualStyleBackColor = true;
            rdbOnline.CheckedChanged += rdbOnline_CheckedChanged;
            // 
            // chkSelecionarContato
            // 
            chkSelecionarContato.AutoSize = true;
            chkSelecionarContato.Location = new Point(24, 219);
            chkSelecionarContato.Name = "chkSelecionarContato";
            chkSelecionarContato.RightToLeft = RightToLeft.Yes;
            chkSelecionarContato.Size = new Size(186, 19);
            chkSelecionarContato.TabIndex = 25;
            chkSelecionarContato.Text = "?Deseja selecionar um contato\r\n";
            chkSelecionarContato.UseVisualStyleBackColor = true;
            chkSelecionarContato.CheckedChanged += chkSelecionarContato_CheckedChanged;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 512);
            Controls.Add(chkSelecionarContato);
            Controls.Add(groupBox1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbContatos);
            Controls.Add(lblContato);
            Controls.Add(lblHorarioFinal);
            Controls.Add(txtHorarioFinal);
            Controls.Add(txtHorarioInicio);
            Controls.Add(txtData);
            Controls.Add(lblHorarioInicio);
            Controls.Add(lblData);
            Controls.Add(lblAssunto);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaCompromissoForm";
            Text = "Cadastro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtAssunto;
        private Label lblAssunto;
        private Label lblData;
        private Label lblHorarioInicio;
        private DateTimePicker txtData;
        private DateTimePicker txtHorarioInicio;
        private DateTimePicker txtHorarioFinal;
        private Label lblHorarioFinal;
        private Label lblContato;
        private ComboBox cmbContatos;
        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox groupBox1;
        private TextBox txtLocalOnline;
        private TextBox txtLocalPresencial;
        private RadioButton rdbPresencial;
        private RadioButton rdbOnline;
        private CheckBox chkSelecionarContato;
    }
}