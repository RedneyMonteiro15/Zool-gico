using System.Collections.Generic;
using System;
namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Animais a = new Animais("Cão", "Domestico","Latir", 8);
            Funcionarios f = new Funcionarios("Redney", 76, "M", 2002, "Limpeza", "Fazer limpesa", 650.98);
            Clientes c = new Clientes("Monteiro", 89, "M", 2013, 50);
            a.listarAnimais();
            f.listarFuncionarios();
            c.listarClientes();
        }
    }
}

class Zoologico{
    string nome;
}
class Animais{
    string nome, especie, descricao;
    int quantidade;
    public Animais(string nome, string especie, string descricao, int quantidade){
        this.nome = nome;
        this.especie = especie;
        this.descricao = descricao;
        this.quantidade = quantidade;
    }
    public void listarAnimais(){
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
class Funcionarios{
    string nome, departamento, habilidades, sexo;
    int numero, nasc;
    double salario;
    public Funcionarios(string nome, int numero, string sexo, int nasc, string departamento, string habilidades, double salario){
        this.nome = nome;
        this.numero = numero;
        this.departamento = departamento;
        this.sexo = sexo;
        this.habilidades = habilidades;
    }
    public void listarFuncionarios(){
        int anoAtual = DateTime.Now.Year;
        int idade;
        idade = (anoAtual - nasc);
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista dos Funcionarios");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("Número: {0}",this.numero);
        Console.WriteLine("Sexo: {0}", this.sexo);
        Console.WriteLine("Idade: {0}", idade);
        Console.WriteLine("Departamento: {0}", this.departamento);
        Console.WriteLine("Habilidades: {0}", this.habilidades);
        
    }
}
class Clientes{
    string nome, sexo;
    int numero, nasc;
    double saldo;
    int anoAtual = DateTime.Now.Year;
    public Clientes(string nome, int numero, string sexo, int nasc,double saldo){
        this.nome = nome;
        this.numero = numero;
        this.saldo = saldo;
        this.sexo = sexo;
        this.saldo = saldo;
    }
    public void listarClientes(){
        int idade = anoAtual - this.nasc;
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" Lista dos Clientes  ");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("Número: {0}", this.numero);
        Console.WriteLine("Sexo: {0}", this.sexo);
        Console.WriteLine("Idade: {0}", idade);
        Console.WriteLine("Saldo: {0}", this.saldo);
        
    }
}

