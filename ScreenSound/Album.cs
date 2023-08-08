public class Album
{
	private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
	public int DuracaoTotal => musicas.Sum(m => m.Duracao);

	public void AdicionarMusica(Musica musica)
	{
		musicas.Add(musica);
	}

	public void ListarAlbum()
	{
		foreach(var musica in musicas)
		{
			Console.WriteLine(musica.Nome);
		}

		Console.WriteLine($"Para ouvir o album inteiro voce precisa de {DuracaoTotal} segundos.");
	}
}