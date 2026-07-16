using System;

namespace AulaPOO_02.Ativadades
{
    internal class Aluno
    {
         string nome;
         int idade;
         decimal notaFinal;

        public Aluno(string nome, int idade, decimal notaFinal)
        {
            this.nome = nome;
            this.idade = idade;
            this.notaFinal = notaFinal;
        }

        public void VerificarAprovacao()
        {
            if (notaFinal < 7)
            {
                Console.WriteLine(
                    $"Aluno {nome} reprovado. Nota: {notaFinal:F1}"
                );
            }
            else
            {
                Console.WriteLine(
                    $"Parabéns, {nome}! Aluno aprovado. Nota: {notaFinal:F1}"
                );
            }
        }
    }
}