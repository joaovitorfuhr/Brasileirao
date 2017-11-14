using System;
using System.Collections.Generic;

namespace Brasileirao
{
    class TabelaBrasileirao
    {
        public List<Times> times = new List<Times>();
        public void tabela() {
            System.Console.WriteLine("Tabela Brasileirão");
            System.Console.WriteLine("Enter - Adiciona os times e a pontuação\n0 - Exibe o resultado da tabela");

            while (Console.ReadKey().Key == ConsoleKey.Enter) {
                System.Console.WriteLine("Nome Do Time: ");
                string times = Console.ReadLine();

                System.Console.WriteLine("Pontuação do time: ");
                int pontuacao = Convert.ToInt32(Console.ReadLine());
                this.times.Add(new Times(times, pontuacao));
            }

            for (int i = 0; i < times.Count; i++) {
                times[i].dados();
            }
        }
    }
}