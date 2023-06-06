﻿using eAgenda2._0.WinApp.Compartilhado;
using eAgenda2._0.WinApp.ModuloContato;

namespace eAgenda2._0.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private RepositorioCompromisso repositorioCompromisso;
        ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioContato repositorioContato, RepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioContato = repositorioContato;
            this.repositorioCompromisso = repositorioCompromisso;
        }

        public override string ToolTipInserir => "Inserir novo Compromisso";

        public override string ToolTipEditar => "Editar Compromisso existente";

        public override string ToolTipExcluir => "Excluir Compromisso existente";

        public override void Inserir()
        {

            List<Contato> contatos = repositorioContato.SelecionarTodos();

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        

        public override void Editar()
        {
            Compromisso compromissoSelecionado = listagemCompromisso.ObterCompromissoSelecionado();

            if(compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Edicação de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            telaCompromisso.ConfigurarTela(compromissoSelecionado);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Editar(compromisso.id, compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            Compromisso compromissoSelecionado = listagemCompromisso.ObterCompromissoSelecionado();

            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o compromisso {compromissoSelecionado.assunto} ?", 
                "Exclusão de Compromissos",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);

                CarregarCompromissos();
            }
        }

        public override void Filtrar()
        {
            TelaFiltroCompromissoForm telaFiltro = new TelaFiltroCompromissoForm();
            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK )
            {
                StatusCompromissoEnum status = telaFiltro.ObterStatus();
                int quantidadeCompromissosSelecionado = 0;
                List<Compromisso> compromissos = null;

                if (status == StatusCompromissoEnum.Todos)
                {
                    compromissos = repositorioCompromisso.SelecionarTodos();
                }

                else if(status == StatusCompromissoEnum.Passados)
                {
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);
                }

                else if (status == StatusCompromissoEnum.Futuros)
                {
                    DateTime dataInicio = telaFiltro.ObterDataInicio();
                    DateTime dataFinal = telaFiltro.ObterDataFinal();

                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicio, dataFinal);
                }

                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromissos");
            }
        }

        private void CarregarCompromissos(List<Compromisso> compromissos)
        {
            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if(listagemCompromisso == null)
            {
                listagemCompromisso = new ListagemCompromissoControl();
            }

            CarregarCompromissos();

            return listagemCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listagemCompromisso.AtualizarRegistros(compromissos);
        }
    }
}
