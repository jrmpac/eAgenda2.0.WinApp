
namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        public ListagemTarefaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefa.Items.Clear();
            
            listTarefa.Items.AddRange(tarefas.ToArray());
        }

        public Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listTarefa.SelectedItem;
        }
    }
}
