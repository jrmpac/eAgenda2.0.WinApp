namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public partial class TelaCadastroItensTarefaForm : Form
    {
        public TelaCadastroItensTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            txtId.Text = tarefa.id.ToString();

            txtTitulo.Text = tarefa.titulo;

            listItems.Items.AddRange(tarefa.items.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloItem.Text;

            ItemTarefa itemTarefa = new ItemTarefa(titulo);

            listItems.Items.Add(itemTarefa);
        }

        public List<ItemTarefa> ObterItensCadastrados()
        {
            return listItems.Items.Cast<ItemTarefa>().ToList();
        }
    }
}
