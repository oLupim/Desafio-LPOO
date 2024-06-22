public class Livro
{
    public string Titulo;
    public Autor AutorDoLivro;
    public double Preco;

    public Livro(string Titulo, Autor autor){
        this.Titulo = Titulo;
        this.AutorDoLivro = autor;
    }

    public Livro(string Titulo, Autor autor, double Preco){
        this.Titulo = Titulo;
        this.AutorDoLivro = autor;
        this.Preco = Preco;
    }

    public void MostrarInfo(){
        Console.WriteLine($"=====\n livro: {Titulo} \n Autor: {AutorDoLivro.Nome} \n Preço: R${Preco}\n=====\n");
    }

    public void AplicarDesconto(double porcentDesconto){
        Preco = Preco*(1-porcentDesconto/100);
        Console.WriteLine($"Você ganhou um desconto! {porcentDesconto}%");
    }

    public void AplicarDesconto(int valorDesconto){
        Preco = Preco-valorDesconto;
        Console.WriteLine($"Você ganhou um desconto! {valorDesconto}%\n");
    }
}