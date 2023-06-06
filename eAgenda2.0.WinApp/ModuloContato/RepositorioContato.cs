using eAgenda2._0.WinApp.Compartilhado;

namespace eAgenda2._0.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }
    }
}
