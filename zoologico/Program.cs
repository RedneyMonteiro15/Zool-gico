using System;

namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mamiferos m = new Mamiferos("Cão", "Latir", 8, "Ração");
            m.listarMamifero();
        }
    }
}
class Animais
{
    string nome, descricao;
    int quantidade;

}
class Mamiferos
{
    string nome, descricao, alimento;
    int quantidade;
    public Mamiferos(string nome, string descricao, int quantidade, string alimento)
    {
        nome = this.nome;
        descricao = this.descricao;
        quantidade = this.quantidade;
        alimento = this.alimento;
    }
    public void listarMamifero()
    {
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista dos Mamiferos");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Descrição: {0}" + descricao);
        Console.WriteLine("Quantidade: {0}", quantidade);
        Console.WriteLine("Alimento: {0}", alimento);
        Console.WriteLine("--------------------");
    }

}
class Aves
{

}
class Peixes
{

}
class Repteis
{

}