public class Podcast
{
	public Podcast(string host, string nome)
	{
		Host = host;
		Nome = nome;
	}
	private List<Episodio> episodios = new List<Episodio>();
	public string Host { get; }
	public string Nome { get; }
	public int TotalEpisodios => episodios.Count();

	public void AdicionarEpisodio(Episodio episodio)
	{
		episodios.Add(episodio);
	}

	public void ExibirDetalhes()
	{
		Console.WriteLine($"Podcast {Nome}, apresentado por {Host} \n");
		foreach (Episodio item in episodios)
		{
			Console.WriteLine(item.Resumo);
		}
		Console.WriteLine($"\n\n Este podcast possui {TotalEpisodios} episódio.");
	}
}