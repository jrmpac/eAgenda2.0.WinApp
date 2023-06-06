using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {

        List<Tarefa> tarefas = new List<Tarefa>();
        public ListagemTarefaControl()
        {
            InitializeComponent();

            tarefas.Add(new Tarefa(1, "Lavar o carro", "alta"));
            tarefas.Add(new Tarefa(2, "Lavar o cachorro", "media"));

            foreach (Tarefa tarefa in tarefas)
            {
                listTarefa.Items.Add(tarefa);
            }
        }
    }
}
