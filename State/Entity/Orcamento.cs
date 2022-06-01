using State.Interface;
using State.Repository;
using System.Collections.Generic;

namespace State.Entity
{
    public class Orcamento
    {       

        public IEstadosOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento (double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }


    }
}
