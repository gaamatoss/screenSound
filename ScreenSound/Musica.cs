public class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao
    {
        get
        {
            return $"A musica {Nome} pertence à {Artista}";
        }
    }

    public void ExibirFicaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição: {Descricao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano plus.");
        }
    }
}

