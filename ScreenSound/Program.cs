//Banda queen = new Banda("Queen");
//Album albumDoQueen = new Album("A night at the opera");
//Musica musica1 = new Musica(queen,"Love of my life");
//musica1.Duracao = 234;
//musica1.Disponivel = true;
//Musica musica2 = new Musica(queen, "Bohemin Rhapsody");
//musica2.Duracao = 334;
//musica2.Disponivel = false;
//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//albumDoQueen.ListarAlbum();
//queen.AddToAlbum(albumDoQueen);
//queen.ExibirDiscografia();
//Console.WriteLine("-----------");
//musica1.ExibirFicaTecnica();
//Console.WriteLine("-----------");
//musica2.ExibirFicaTecnica();

Episodio ep1 = new(1, 22,"teste");
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, 22, "teste1");
ep2.AdicionarConvidados("Maria");
ep2.AdicionarConvidados("Marcelo");

Episodio ep3 = new(3, 22, "teste2");
ep3.AdicionarConvidados("Maria");
ep3.AdicionarConvidados("Marcelo");

Episodio ep4 = new(4, 22, "teste3");
ep4.AdicionarConvidados("Maria");
ep4.AdicionarConvidados("Marcelo");

Podcast podcast = new("Gabriel", "PodTuco");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.AdicionarEpisodio(ep4);
podcast.ExibirDetalhes();

