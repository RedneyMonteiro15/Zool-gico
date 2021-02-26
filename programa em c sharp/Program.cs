using System.Collections.Generic;
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
    List<Mamiferos> listaMamifero;
    List<Aves> listaAves;
    List<Peixes> listaPeixes;
    List<Repteis> listaRepteis;
    public Animais()
    {
        listaMamifero = new List<Mamiferos>();
        listaAves = new List<Aves>();
        listaPeixes = new List<Peixes>();
        listaRepteis = new List<Repteis>();    
    }
    public void inserirMamifero(string nome, string descricao, int quantidade, string alimento){
        listaMamifero.add(nome, descricao, quantidade, alimento);
    }
    public void inserirAves(string nome, string descricao, int quantidade, string alimento){
        listaAves.add(nome, descricao, quantidade, alimento);
    }
    public void inserirPeixes(string nome, string descricao, int quantidade, string alimento){
        listaPeixes.add(nome, descricao, quantidade, alimento);
    }
    public void inserirRepteis(string nome, string descricao, int quantidade, string alimento){
        listaRepteis.add(nome, descricao, quantidade, alimento);
    }
}
class Mamiferos
{
    string nome, descricao, alimento;
    int quantidade;
    public Mamiferos(string nome, string descricao, int quantidade, string alimento)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.alimento = alimento;
    }
    public void listarMamifero()
    {
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista dos Mamiferos");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Descrição: {0}" , descricao);
        Console.WriteLine("Quantidade: {0}", quantidade);
        Console.WriteLine("Alimento: {0}", alimento);
        Console.WriteLine("--------------------");
    }

}
class Aves
{
    string nome, descricao, alimento;
    int quantidade;
    public Aves(string nome, string descricao, int quantidade, string alimento)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.alimento = alimento;
    }
    public void listarAves()
    {
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista das Aves");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Descrição: {0}" , descricao);
        Console.WriteLine("Quantidade: {0}", quantidade);
        Console.WriteLine("Alimento: {0}", alimento);
        Console.WriteLine("--------------------");
    }
}
class Peixes
{
    string nome, descricao, alimento;
    int quantidade;
    public Peixes(string nome, string descricao, int quantidade, string alimento)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.alimento = alimento;
    }
    public void listarPeixes()
    {
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista das Peixes");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Descrição: {0}" , descricao);
        Console.WriteLine("Quantidade: {0}", quantidade);
        Console.WriteLine("Alimento: {0}", alimento);
        Console.WriteLine("--------------------");
    }
}
class Repteis
{
    string nome, descricao, alimento;
    int quantidade;
    public Repteis(string nome, string descricao, int quantidade, string alimento)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.alimento = alimento;
    }
    public void listarRepteis()
    {
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista dos Repteis");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Descrição: {0}" , descricao);
        Console.WriteLine("Quantidade: {0}", quantidade);
        Console.WriteLine("Alimento: {0}", alimento);
        Console.WriteLine("--------------------");
    }
}