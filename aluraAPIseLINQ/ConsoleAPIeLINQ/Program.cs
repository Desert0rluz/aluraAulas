using ConsoleAPIeLINQ.Modelos;
using ConsoleAPIeLINQ.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //LinqFilter.FiltrarGenerosMusicais(musicas);
        //LinqOrder.OrdenaListadeArtista(musicas);
        //LinqFilter.FiltrarPorGenero(musicas, "rock");

        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasEmilly = new MusicasPreferidas("Emy");

        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);

        ////musicasPreferidasEmilly.ExibirMusicasFavoritas();

        //musicasPreferidasEmilly.GerarArquivoJson();

    }
    catch (Exception ex)
    { 
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}