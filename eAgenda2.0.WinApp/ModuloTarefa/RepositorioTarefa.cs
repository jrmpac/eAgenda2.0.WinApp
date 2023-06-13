using eAgenda2._0.WinApp.Compartilhado;

namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public RepositorioTarefa(List<Tarefa> tarefas)
        {
            listaRegistros = tarefas;
        }
    }
}
