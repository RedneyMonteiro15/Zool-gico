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
            /*
            Console.WriteLine("------------------------------------------");
            z.inserirAnimais("Cão", "Domestico","Latir", 8);
            z.inserirAnimais("Gato", "Domestico","Latir", 5);
            z.inserirAnimais("Gato", "Herbivero","Latir", 5);
            Console.WriteLine("------------------------------------------");
            z.listarAnimais();
            Console.WriteLine("------------------------------------------");
            z.monstrarAnimalNome("Gato");
            Console.WriteLine("------------------------------------------");
            z.monstrarAnimalEspecie("Domestico");
            Console.WriteLine("------------------------------------------");
            z.RemoverAnimalNome("Gato");
            z.RemoverAnimalEspecie("Herbivero");
            Console.WriteLine("------------------------------------------");
            z.listarAnimais();
            Console.WriteLine("------------------------------------------");
            

            Console.WriteLine("------------------------------------------");
            z.inserirFuncionarios("Redney", 1, "M", 19, "Informatica", "Desenvolvimento de software", 808.97);
            z.inserirFuncionarios("Monteiro", 2, "M", 28, "Veteriano", "Cuidador de animais", 797.53);
            z.inserirFuncionarios("Spencer", 3, "F", 66, "Limpeza", "Faz a limpeza do zoologico", 605.99);
            Console.WriteLine("------------------------------------------");
            z.listarFuncionarios();
            Console.WriteLine("------------------------------------------");
            z.monstrarFuncionarioNome("Redney");
            Console.WriteLine("------------------------------------------");
            z.monstrarFuncionarioSexo("M");
            Console.WriteLine("------------------------------------------");
            z.monstrarFuncionarioSexo("F");
            Console.WriteLine("------------------------------------------");
            z.RemoverFuncionarioNome("Redney");
            Console.WriteLine("------------------------------------------");
            z.RemoverFuncionarioNumero(3);
            Console.WriteLine("------------------------------------------");
            z.listarFuncionarios();
            */
            z.inserirClientes("Redney", 1, "M", 17, 20.9);
            z.inserirClientes("Manuel", 2, "F", 11, 50.678);
            z.inserirClientes("Spencer", 3, "F", 27, 6.9);
            z.inserirClientes("Monteiro", 4, "M", 67, 30.2);
            Console.WriteLine("------------------------------------------");
            z.listarClientes();
            Console.WriteLine("------------------------------------------");
            z.monstrarClienteSexo("M");
            Console.WriteLine("------------------------------------------");
            z.monstrarClienteSexo("F");
            Console.WriteLine("------------------------------------------");
            z.monstrarClienteNome("Redney");
            Console.WriteLine("------------------------------------------");
            z.RemoverClienteNome("Monteiro");
            Console.WriteLine("------------------------------------------");
            z.RemoverClienteNumero(2);
            Console.WriteLine("------------------------------------------");
            z.listarClientes();
        }
    }
}
class Zoologico
{
    List<Animais> listaAnimais;
    List<Funcionarios> listaFuncionarios;
    List<Clientes> listaClientes;
    public Zoologico()
    {
        listaAnimais = new List<Animais>();
        listaFuncionarios = new List<Funcionarios>();
        listaClientes = new List<Clientes>();
    }
    public void inserirAnimais(string nome, string especie, string descricao, int quantidade)
    {
        Animais a = new Animais(nome, especie, descricao, quantidade);
        if(a == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao inserir, registro!!!");
            Console.ResetColor();
            return;
        }
        listaAnimais.Add(a);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro do animal, adicionado com sucesso.");
        Console.ResetColor();
    }
    public void listarAnimais(){
        foreach (Animais a in listaAnimais)
        {
            a.monstrarAnimais();
        }
    }
    public void monstrarAnimalNome(string nome){
        foreach(Animais a in listaAnimais)
        {
            if(nome == a.getNomeAnimal())
            {
                a.monstrarAnimais();
            }
        }
    }
    public void monstrarAnimalEspecie(string especie){
        foreach (Animais a in listaAnimais)
        {
            if (especie == a.getEspecie())
            {
                a.monstrarAnimais();
            }
        }
    }
    public Animais pesquisaAnimaisNome(string nome)
    {
        foreach (Animais a in listaAnimais)
        {
            if (nome == a.getNomeAnimal())
            {
                return a;
            }
        }
        return null;
    }
    public void RemoverAnimalNome(string nome)
    {   
        Animais a = this.pesquisaAnimaisNome(nome);
        if(a == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro, não foi possível encontrar o animal.");
            Console.ResetColor();
            return;
        }
        listaAnimais.Remove(a);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro animal, removido com sucesso!");
        Console.ResetColor();
    }
    public Animais pesquisaAnimaisEspecie(string especie)
    {
        foreach (Animais a in listaAnimais)
        {
            if (especie == a.getEspecie())
            {
                return a;
            }
        }
        return null;
    }
    public void RemoverAnimalEspecie(string especie)
    {
        Animais a = this.pesquisaAnimaisEspecie(especie);
        if (a == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao remover animal.");
            Console.ResetColor();
        }
        listaAnimais.Remove(a);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro animal, removido com sucesso!");
        Console.ResetColor();
    }
    public void inserirFuncionarios(string nome, int numero, string sexo, int nasc, string departamento, string habilidades, double salario)
    {
        Funcionarios f = new Funcionarios(nome, numero, sexo, nasc, departamento, habilidades, salario);
        if(f == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao inserir, registro!!!");
            Console.ResetColor();
            return;
        }
        listaFuncionarios.Add(f);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro do funcionario, adicionado com sucesso.");
        Console.ResetColor();
    }
    public void listarFuncionarios(){
        foreach (Funcionarios f in listaFuncionarios)
        {
            f.monstrarFuncionarios();
        }
    }
    public void monstrarFuncionarioNome(string nome){
        foreach(Funcionarios f in listaFuncionarios)
        {
            if(nome == f.getNomeFuncionario())
            {
                f.monstrarFuncionarios();
            }
        }
    }
    public void monstrarFuncionarioSexo(string sexo){
        foreach (Funcionarios f in listaFuncionarios)
        {
            if (sexo == f.getSexoFuncionario())
            {
                f.monstrarFuncionarios();
            }
        }
    }
    public Funcionarios pesquisaFuncionarioNome(string nome)
    {
        foreach (Funcionarios f in listaFuncionarios)
        {
            if (nome == f.getNomeFuncionario())
            {
                return f;
            }
        }
        return null;
    }

    public void RemoverFuncionarioNome(string nome)
    {   
        Funcionarios f = this.pesquisaFuncionarioNome(nome);
        if(f == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro, não foi possível encontrar o registro funcionario.");
            Console.ResetColor();
            return;
        }
        listaFuncionarios.Remove(f);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro funcionario, removido com sucesso!");
        Console.ResetColor();
    }
    public Funcionarios pesquisaFuncionarioNumero(int numero)
    {
        foreach (Funcionarios f in listaFuncionarios)
        {
            if (numero == f.getNumeroFuncionario())
            {
                return f;
            }
        }
        return null;
    }
    public void RemoverFuncionarioNumero(int numero)
    {
        Funcionarios f = this.pesquisaFuncionarioNumero(numero);
        if (f == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao remover registro funcionario.");
            Console.ResetColor();
        }
        listaFuncionarios.Remove(f);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro funcionario, removido com sucesso!");
        Console.ResetColor();
    }
    public void inserirClientes(string nome, int numero, string sexo, int nasc, double salario)
    {
        Clientes c = new Clientes(nome, numero, sexo, nasc, salario);
        if(c == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao inserir, registro cliente!!!");
            Console.ResetColor();
            return;
        }
        listaClientes.Add(c);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro do cliente, adicionado com sucesso!!!");
        Console.ResetColor();
    }
    public void listarClientes(){
        foreach (Clientes c in listaClientes)
        {
            c.monstrarClientes();
        }
    }
    public void monstrarClienteNome(string nome){
        foreach(Clientes c in listaClientes)
        {
            if(nome == c.getNomeCliente())
            {
                c.monstrarClientes();
            }
        }
    }
    public void monstrarClienteSexo(string sexo){
        foreach (Clientes c in listaClientes)
        {
            if (sexo == c.getSexoCliente())
            {
                c.monstrarClientes();
            }
        }
    }
    public Clientes pesquisaClienteNome(string nome)
    {
        foreach (Clientes c in listaClientes)
        {
            if (nome == c.getNomeCliente())
            {
                return c;
            }
        }
        return null;
    }

    public void RemoverClienteNome(string nome)
    {   
        Clientes c = this.pesquisaClienteNome(nome);
        if(c == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro, não foi possível encontrar o registro cliente!!!");
            Console.ResetColor();
            return;
        }
        listaClientes.Remove(c);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro cliente, removido com sucesso!");
        Console.ResetColor();
    }
    public Clientes pesquisaClienteNumero(int numero)
    {
        foreach (Clientes c in listaClientes)
        {
            if (numero == c.getNumeroCliente())
            {
                return c;
            }
        }
        return null;
    }
    public void RemoverClienteNumero(int numero)
    {
        Clientes c = this.pesquisaClienteNumero(numero);
        if (c == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao remover registro Cliente!!!");
            Console.ResetColor();
        }
        listaClientes.Remove(c);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro cliente, removido com sucesso!");
        Console.ResetColor();
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
    public string getNomeAnimal()
    {
        return this.nome;
    }
    public string getEspecie()
    {
        return this.especie;
    }
}
class Funcionarios
{
    string nome, departamento, habilidades, sexo;
    int numero, nasc;
    double salario;
    public Funcionarios(string nome, int numero, string sexo, int nasc, string departamento, string habilidades, double salario)
    {
        this.nome = nome;
        this.numero = numero;
        this.sexo = sexo;
        this.nasc = nasc;
        this.departamento = departamento;
        this.habilidades = habilidades;
        this.salario = salario;
    }
    public void monstrarFuncionarios()
    {
        Console.WriteLine("----------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista dos Funcionarios");
        Console.ResetColor();
        Console.WriteLine("----------------------");
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("Número: {0}",this.numero);
        Console.WriteLine("Sexo: {0}", this.sexo);
        Console.WriteLine("Idade: {0}", this.nasc);
        Console.WriteLine("Departamento: {0}", this.departamento);
        Console.WriteLine("Habilidades: {0}",this.habilidades);
        Console.WriteLine("Salario: {0}", this.salario);
    }
    public string getNomeFuncionario(){
        return this.nome;
    }
    public int getNumeroFuncionario(){
        return this.numero;
    }
    public string getSexoFuncionario(){
        return this.sexo;
    }
}
class Clientes
{
    string nome, sexo;
    int numero, nasc;
    double saldo;
    public Clientes(string nome, int numero, string sexo, int nasc, double saldo)
    {
        this.nome = nome;
        this.numero = numero;
        this.sexo = sexo;
        this.nasc = nasc;
        this.saldo = saldo;
    }
    public void monstrarClientes()
    {
        Console.WriteLine("----------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista dos Clientes");
        Console.ResetColor();
        Console.WriteLine("----------------------");
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("Número: {0}",this.numero);
        Console.WriteLine("Sexo: {0}", this.sexo);
        Console.WriteLine("Idade: {0}", this.nasc);
        Console.WriteLine("Saldo: {0}", this.saldo);
    }
    public string getNomeCliente(){
        return this.nome;
    }
    public int getNumeroCliente(){
        return this.numero;
    }
    public string getSexoCliente(){
        return this.sexo;
    }
}