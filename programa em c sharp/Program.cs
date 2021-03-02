using System.Collections.Generic;
using System;
namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            Zoologico z = new Zoologico();
            z.inserirAnimais("Cão", "Domestico","Latir", 8);
            z.listarAnimais();
        }
    }
}
class Zoologico
{
    List<Animais> listaAnimais;
    public Zoologico()
    {
        listaAnimais = new List<Animais>();
    }
    public void inserirAnimais(string nome, string especie, string descricao, int quantidade)
    {
        Animais a = new Animais(nome, especie, descricao, quantidade);
        if(a == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao inserir!!!");
            Console.ResetColor();
            return;
        }
        listaAnimais.Add(a);
    }
    public void listarAnimais(){
        foreach (Animais a in listaAnimais)
        {
            a.monstrarAnimais();
        }
    }
}
class Animais
{
    string nome, especie, descricao;
    int quantidade;
    public Animais(string nome, string especie, string descricao, int quantidade)
    {
        this.nome = nome;
        this.especie = especie;
        this.descricao = descricao;
        this.quantidade = quantidade;
    }
    public void monstrarAnimais()
    {
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" Lista dos Animais  ");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("Especie: {0}",this.especie);
        Console.WriteLine("Descrição: {0}", this.descricao);
        Console.WriteLine("Quantidade: {0}", this.quantidade);
        
    }
}
