﻿using eAgenda2._0.WinApp.Compartilhado;

namespace eAgenda2._0.WinApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public string titulo;
        public bool concluido;

        public ItemTarefa(string titulo)
        {
            this.titulo = titulo;
        }

        public override string ToString()
        {
            return titulo;
        }

        public void Concluir()
        {
            concluido = true;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   concluido == tarefa.concluido;
        }

        public void Desmarcar()
        {
            concluido = false;
        }
    }

    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo;
        public PrioridadeTarefaEnum prioridade;
        public DateTime dataCriacao;
        public List<ItemTarefa> items;
        public decimal percentualConcluido;

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
            return "Id: " + id + ", " + titulo + ", Prioridade: " + prioridade + ", Percentual Concluído" + percentualConcluido;
        }

        public override string[] Validar()
        {
            return new string[] { };
        }

        public void AdicionarItem(ItemTarefa item)
        {
            items.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = items.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Concluir();

            CalcularPercentualConcluido();
        }
        public void DesmarcarItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = items.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Desmarcar();

            CalcularPercentualConcluido();
        }

        private void CalcularPercentualConcluido()
        {
            decimal qtdConcluidos = items.Count(x => x.concluido == true);

            decimal qtItens = items.Count();

            decimal resultado = (qtdConcluidos / qtItens) * 100;

            percentualConcluido = Math.Round(resultado, 2);
        }
    }
}
