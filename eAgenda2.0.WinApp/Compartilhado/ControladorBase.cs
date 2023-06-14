using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Filtrar()
        {
        }

        public virtual void Adicionar()
        {
        }

        public virtual void ConcluirItens()
        {
        }

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
        
    }
}
