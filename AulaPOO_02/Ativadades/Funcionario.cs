using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_02.Ativadades
{
    public class Funcionario
    {
         string nome;
         string cargo;
         decimal salario;

        public Funcionario(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public void AumentarSalario(decimal percentual)
        {
            if (percentual <= 0)
            {
                Console.WriteLine("O percentual deve ser maior que zero");
                return;
            }

            salario += salario * percentual / 100;

            Console.WriteLine("Salário aumentado com sucesso");
            Console.WriteLine($"Novo salário: {salario:C}");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Salário: {salario:C}");
        }
    }
}
