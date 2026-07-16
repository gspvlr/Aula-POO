using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_02.Ativadades
{
    internal class Produto
    {
         string nome;
         decimal preco;
         int quantidade;

        public Produto(string nome, decimal preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public void AtualizarEstoque(int quantidadeAdicionar)
        {
            if (quantidadeAdicionar <= 0)
            {
                Console.WriteLine("A quantidade deve ser maior que zero.");
                return;
            }

            quantidade += quantidadeAdicionar;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço: {preco:C}");
            Console.WriteLine($"Quantidade em estoque: {quantidade}");
        }
    }
}
