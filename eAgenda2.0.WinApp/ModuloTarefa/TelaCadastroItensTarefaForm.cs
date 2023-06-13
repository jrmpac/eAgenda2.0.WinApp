namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public partial class TelaCadastroItensTarefaForm : Form
    {
        private Tarefa tarefa;

        public TelaCadastroItensTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.tarefa = tarefa;

            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            txtId.Text = tarefa.id.ToString();

            txtTitulo.Text = tarefa.titulo;
        }
    }
}
