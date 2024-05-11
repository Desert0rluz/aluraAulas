using System.Linq;
using ConsoleAPIeLINQ.Modelos;

namespace ConsoleAPIeLINQ.Filtros;

internal class LinqOrder
{
    public static void OrdenaListadeArtista(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
