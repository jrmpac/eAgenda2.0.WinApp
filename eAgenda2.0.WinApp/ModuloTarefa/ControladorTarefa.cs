using eAgenda2._0.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            telaTarefa.ShowDialog();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            
        }

        public override UserControl ObterListagem()
        {
            return new ListagemTarefaControl();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }
    }
}
