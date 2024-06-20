Autor autor = new Autor("João Silva", "Brasil");
autor.MostrarInfo();

Livro livro1 = new Livro("Aprendendo C#", autor);


Livro livro2 = new Livro("Avançando em C#", autor, 100);
livro2.MostrarInfo();

livro2.AplicarDesconto(10);
livro2.MostrarInfo();
