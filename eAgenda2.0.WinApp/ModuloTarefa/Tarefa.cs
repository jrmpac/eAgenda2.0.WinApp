using eAgenda2._0.WinApp.Compartilhado;

namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public string titulo;
        public bool concluido;
    }

    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo;
        public PrioridadeTarefaEnum prioridade;
        public DateTime dataCriacao;
        public List<ItemTarefa> items;

        public Tarefa(int id, string titulo, PrioridadeTarefaEnum prioridade, DateTime dataCriacao)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.items = new List<ItemTarefa>();
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            this.id = registroAtualizado.id;
            this.titulo = registroAtualizado.titulo;
            this.prioridade = registroAtualizado.prioridade;
        }

        public override string? ToString()
        {
            return "Id: " + id + ", " + titulo + ", Prioridade: " + prioridade;
        }

        public override string[] Validar()
        {
            return new string[] { };
        }
    }
}
