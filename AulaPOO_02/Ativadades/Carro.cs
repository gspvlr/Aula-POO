using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_02.Ativadades
{
    internal class Carro
    {
        string marca;
        string modelo;
        int ano;

        public Carro(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public void Acelerar()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano: {ano+2}");

        }
    }
}
