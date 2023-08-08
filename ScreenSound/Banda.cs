public class Banda
{
	private List<Album> albuns = new List<Album>();

	public Banda(string nome)
	{
		Nome = nome;
	}

	public string Nome { get; }

	public void AddToAlbum(Album album)
	{
		albuns.Add(album);
	}

	public void ExibirDiscografia()
	{
		Console.WriteLine("-------");

        Console.WriteLine($"Discografia da banda: {Nome}");
		foreach(Album album in albuns)
		{
			Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal} segundos)");
		}
	}
}
