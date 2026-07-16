using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_02.Ativadades
{
    internal class Livro
    {
         string titulo;
         string autor;
         int anoPublicacao;

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao +2;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ano de publicação: {anoPublicacao}");
        }
    }
}
