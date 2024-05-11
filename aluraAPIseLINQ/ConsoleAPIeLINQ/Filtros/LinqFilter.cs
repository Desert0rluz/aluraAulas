using System.Linq;
using ConsoleAPIeLINQ.Modelos;

namespace ConsoleAPIeLINQ.Filtros;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
            var musicasEmCSharp = musicas
                .Where(musica => musica.Tonalidade.Equals("C#"))
                .Select(musica => musica.Nome)
                .ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
