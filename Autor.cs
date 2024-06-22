public class Autor
{
    //atributos
    public string Nome;
    public string Nacionalidade;

    //metodo construtor
    public Autor(string Nome, string Nacionalidade){
        this.Nome = Nome;
        this.Nacionalidade = Nacionalidade;
    }
    
    //metodos
    public void MostrarInfo(){
        Console.WriteLine($"O nome do autor é {Nome} e ele nasceu no {Nacionalidade}.\n");
    }
}