using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaPOO_02.Ativadades;

namespace AulaPOO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funcionario funcionario = new Funcionario("Glauber","Desenvolvedora",4000m);

            //funcionario.ExibirDados();
            //Console.WriteLine();
            //funcionario.AumentarSalario(10);
            //Console.WriteLine();
            //funcionario.ExibirDados();

            //-----------------------------------------------------------------//

            //Livro livro = new Livro("Dom Casmurro","Machado de Assis",1899);
            //livro.ExibirInfo();

            //------------------------------------------------------------------//


            //Produto produto = new Produto("Teclado",150m,10);

            //produto.ExibirInfo();
            //Console.WriteLine();
            //produto.AtualizarEstoque(10);
            //Console.WriteLine();
            //produto.ExibirInfo();

            //------------------------------------------------------------------//

            Aluno aluno1 = new Aluno("Carlos", 18, 8.5m);
            Aluno aluno2 = new Aluno("Ana", 17, 6.0m);

            aluno1.VerificarAprovacao();
            aluno2.VerificarAprovacao();
        }
    }
}
