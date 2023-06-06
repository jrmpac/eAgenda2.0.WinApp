using eAgenda2._0.WinApp.Compartilhado;

namespace eAgenda2._0.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemContatoControl listagemContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo Contato";

        public override string ToolTipEditar => "Editar Contato existente";

        public override string ToolTipExcluir => "Excluir Contato existente";             
        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);
                CarregarContatos();

            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);
        }

        public override void Editar()
        {
            Contato contato = listagemContato.ObterContatoSelecionado();

            if(contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edicação de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = listagemContato.ObterContatoSelecionado();


            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {                
                repositorioContato.Editar(telaContato.Contato.id, telaContato.Contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            
            Contato contato = listagemContato.ObterContatoSelecionado();

            if(contato == null )
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                   "Exclusão de Contatos",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome} ?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {                
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        public override UserControl ObterListagem()
        {
            if(listagemContato == null)
                listagemContato = new ListagemContatoControl();

            CarregarContatos();

            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        
    }
}
