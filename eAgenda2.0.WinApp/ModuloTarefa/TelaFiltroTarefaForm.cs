

namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            if (rdbConcluidas.Checked == true)
                return StatusTarefaEnum.Concluidas;

            else if (rdbPendentes.Checked == true)
                return StatusTarefaEnum.Pendentes;

            else
                return StatusTarefaEnum.Todos;
        }
    }
}
