using eAgenda2._0.WinApp.Compartilhado;
using eAgenda2._0.WinApp.ModuloCompromisso;

namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private RepositorioTarefa repositorioTarefa;
        private ListagemTarefaControl listagemTarefas;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }
        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override void Inserir()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            TelaTarefaForm telaTarefa = new TelaTarefaForm(edicaoDeTarefa : false);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Tarefa novaTarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Inserir(novaTarefa);

                CarregarTarefas();
            }
        }
        public override void Editar()
        {
            Tarefa tarefaSelecionada = listagemTarefas.ObterTarefaSelecionada();

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm(edicaoDeTarefa: true);

            telaTarefa.ConfigurarTela(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Editar(tarefa.id, tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefaSelecionada = listagemTarefas.ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Exclusão de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefaSelecionada.titulo}", 
                "Exclusão de Tarefa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.OK )
            {
                repositorioTarefa.Excluir(tarefaSelecionada);

                CarregarTarefas();
            }
        }
        public override void Adicionar()
        {
            Tarefa tarefaSelecionada = listagemTarefas.ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroItensTarefaForm telaCadastroItensTarefa = new TelaCadastroItensTarefaForm(tarefaSelecionada);

            telaCadastroItensTarefa.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefas == null)
            {
                listagemTarefas = new ListagemTarefaControl();
            }

            CarregarTarefas();

            return listagemTarefas;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listagemTarefas.AtualizarRegistros(tarefas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)");
        }
    }
}
