﻿namespace eAgenda2._0.WinApp.ModuloContato
{
    partial class ListagemContatoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listContato = new ListBox();
            SuspendLayout();
            // 
            // listContato
            // 
            listContato.Dock = DockStyle.Fill;
            listContato.FormattingEnabled = true;
            listContato.ItemHeight = 15;
            listContato.Location = new Point(0, 0);
            listContato.Name = "listContato";
            listContato.Size = new Size(645, 497);
            listContato.TabIndex = 1;
            listContato.SelectedIndexChanged += listContato_SelectedIndexChanged;
            // 
            // ListagemContatoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContato);
            Name = "ListagemContatoControl";
            Size = new Size(645, 497);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listContato;
    }
}
