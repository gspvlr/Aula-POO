using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_02.Ativadades
{
    public class ContaBancaria
    {
         string titular;
         decimal saldo;
         int agencia;

        public ContaBancaria(string titular, decimal saldo, int agencia)
        {
            this.titular = titular;
            this.saldo = saldo;
            this.agencia = agencia;
        }

        public void ExibirCliente()
        {
            if (string.IsNullOrWhiteSpace(titular))
            {
                Console.WriteLine("Nome inválido!");
                return;
            }

            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Agência: {agencia}");
            Console.WriteLine($"Saldo atual: {saldo:C}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Digite um valor válido para o saque.");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine($"Saldo atual: {saldo:C}");
            }
        }
    }
}