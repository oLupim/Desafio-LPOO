Autor autor1 = new Autor("João Silva", "Brasil");
autor1.MostrarInfo();

Livro livro1 = new Livro("Aprendendo C#", autor1, 50);
livro1.MostrarInfo();

Livro livro2 = new Livro("Avançando em C#", autor1, 100);
livro2.MostrarInfo();

livro2.AplicarDesconto(10);
livro2.MostrarInfo();
livro2.AplicarDesconto(5);
livro2.MostrarInfo();
