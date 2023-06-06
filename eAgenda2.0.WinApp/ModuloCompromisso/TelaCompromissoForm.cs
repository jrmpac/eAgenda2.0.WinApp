﻿

using eAgenda2._0.WinApp.ModuloContato;

namespace eAgenda2._0.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            foreach (Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato);
            }
        }

        public Compromisso ObterCompromisso()
        {
            int id = Convert.ToInt32(txtId.Text);
            string assunto = txtAssunto.Text;
            DateTime data = txtData.Value;
            TimeSpan horarioInicio = txtHorarioInicio.Value.TimeOfDay;
            TimeSpan horarioFinal = txtHorarioFinal.Value.TimeOfDay;

            TipoLocalEnum tipo = rdbOnline.Checked ? TipoLocalEnum.Online : TipoLocalEnum.Presencial;

            Contato contato = (Contato)cmbContatos.SelectedItem;

            string local;
            if (rdbOnline.Checked)
                local = txtLocalOnline.Text;

            else
                local = txtLocalPresencial.Text;


            return new Compromisso(assunto, data, horarioInicio, horarioFinal, contato, local, tipo);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();

            string[] erros = compromisso.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        internal void ConfigurarTela(Compromisso compromissoSelecionado)
        {
            txtId.Text = compromissoSelecionado.id.ToString();
            txtAssunto.Text = compromissoSelecionado.assunto;
            txtData.Value = compromissoSelecionado.data;
            txtHorarioInicio.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioInicio);
            txtHorarioFinal.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioFinal);

            if(compromissoSelecionado.contato != null)
            {
                chkSelecionarContato.Checked = true;
                cmbContatos.SelectedItem = compromissoSelecionado.contato;
            }
            

            if (compromissoSelecionado.tipoLocal == TipoLocalEnum.Presencial)
            {
                rdbPresencial.Checked = true;
                txtLocalPresencial.Text = compromissoSelecionado.localPresencial;
            }
            else
            {
                rdbOnline.Checked = true;
                txtLocalOnline.Text = compromissoSelecionado.localOnline;
            }
        }

        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalPresencial.Enabled = true;
            txtLocalOnline.Enabled = false;
            txtLocalOnline.Text = "";
        }

        private void rdbOnline_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalOnline.Enabled = true;
            txtLocalPresencial.Enabled = false;
            txtLocalPresencial.Text = "";
        }

        private void chkSelecionarContato_CheckedChanged(object sender, EventArgs e)
        {
            cmbContatos.Enabled = !cmbContatos.Enabled;
        }
    }
}
