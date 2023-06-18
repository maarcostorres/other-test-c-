using System;
using System.Collections.Generic;

class Filme
{
    public string Titulo { get; set; }
    public float Lucro { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Filme> filmes = new List<Filme>
        {
            new Filme { Titulo = "Avatar", Lucro = 2.847f },
            new Filme { Titulo = "Vingadores: Ultimato", Lucro = 2.798f },
            new Filme { Titulo = "Titanic", Lucro = 2.194f },
            new Filme { Titulo = "Star Wars: Episódio VII - O Despertar da Força", Lucro = 2.068f },
            new Filme { Titulo = "Vingadores: Guerra Infinita", Lucro = 2.048f }
        };

        // Classificar filmes pelo lucro
        filmes.Sort((filme1, filme2) => filme2.Lucro.CompareTo(filme1.Lucro));

        // Exibir tabela de classificação
        Console.WriteLine("{0,-4}{1,-40}{2,-20}", "Rank", "Título", "Lucro (em bilhões USD)");
        Console.WriteLine("======================================================");
        for (int i = 0; i < filmes.Count; i++)
        {
            Console.WriteLine("{0,-4}{1,-40}{2,-20}", i + 1, filmes[i].Titulo, filmes[i].Lucro.ToString("F2"));
        }
    }
}
