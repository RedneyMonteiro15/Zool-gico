using System.Collections.Generic;
using System;
namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string nome, sexo, resp;
            int nasc, idade;
            int anoAtual = DateTime.Now.Year;
            while(loop){
                Console.WriteLine("--------------------");
                Console.WriteLine("     Zoológico      ");
                Console.WriteLine("--------------------");
                
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Sexo: ");
                sexo = Console.ReadLine();
                Console.Write("Quer continuar [S/N]? ");
                resp = Console.ReadLine();
                char respt = resp[0];
                if(respt == 'N' || respt == 'n'){
                    break;
                }
            }
            
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
    List<Animais> listaAnimais;
    List<Funcionarios> listaFuncionarios;
    List<Clientes> listaClientes;
    public Zoologico(string nome){
        this.nome = nome;
        listaAnimais = new List<Animais>();
        listaClientes = new List<Clientes>();
        listaFuncionarios = new List<Funcionarios>();
    }
    public void inserirAnimais(string nome, string especie, string descricao, int quantidade){
        Animais a = new Animais(nome, especie, descricao, quantidade);
        if(a == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao inserir!!!");
            Console.ResetColor();
            return;
        }
        listaAnimais.Add(a);
    }
    public void inserirFuncionarios(string nome, int numero, string sexo, int nasc, string departamento, string habilidades, double salario){
        Funcionarios f = new Funcionarios(nome, numero, sexo, nasc, departamento, habilidades, salario);
        if(f == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao inserir!!!");
            Console.ResetColor();
            return;
        }
        listaFuncionarios.Add(f);
    }
    public void inserirClientes(string nome, int numero, string sexo, int nasc,double saldo){
        Clientes c = new Clientes(nome, numero, sexo, nasc, saldo);
        if(c == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao inserir!!!");
            Console.ResetColor();
            return;
        }
        listaClientes.Add(c);
    }
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
