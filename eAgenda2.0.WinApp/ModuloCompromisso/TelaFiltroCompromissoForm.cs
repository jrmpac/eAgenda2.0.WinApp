﻿

namespace eAgenda2._0.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromissoForm : Form
    {
        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        public StatusCompromissoEnum ObterStatus()
        {
            if (rdbFuturos.Checked)
            {
                return StatusCompromissoEnum.Futuros;
            }

            else if (rdbPassados.Checked)
            {
                return StatusCompromissoEnum.Passados;
            }
            else
            {
                return StatusCompromissoEnum.Todos;
            }
        }

        public DateTime ObterDataInicio()
        {
            return txtDataInicio.Value;
        }

        public DateTime ObterDataFinal()
        {
            return txtDataFinal.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}