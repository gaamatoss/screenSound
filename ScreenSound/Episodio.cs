public class Episodio
{
	public Episodio(int ordem, int duracao, string titulo)
	{
		Ordem = ordem;
		Duracao = duracao;
		Titulo = titulo;
	}
	public List<String> convidados = new();
	public int Ordem { get; }
	public string Titulo { get; }
	public int Duracao { get; }
	public string Resumo { get
		{
			return $"Ordem: {Ordem} Titulo: {Titulo} Duração: {Duracao}:  - Convidados: {string.Join(", ", convidados)}";
		}
	}

	public void AdicionarConvidados(string convidado)
	{
		convidados.Add(convidado);
	}
}