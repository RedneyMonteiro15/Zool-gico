using System.Collections.Generic;
using System;
namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoologico z = new Zoologico();
            int ano = 2021;
            while (true){
                int op, opA, opC, opF, numero, quantidade, nasc, idade;
                string nome, sexo, departamento, habilidades, especie, descricao;
                double saldo, salario;
                Console.WriteLine("------------------------------");
                Console.WriteLine("Zoologico CV-SV");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Escolhe a sua opção: ");
                Console.WriteLine(" [1] - Animais\n [2] - Clientes\n [3] - Funcionarios");
                Console.WriteLine("------------------------------");
                Console.Write("Escolhe a sua opção: ");
                op = int.Parse(Console.ReadLine());
                if(op == 1){
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Animais");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Escolhe a sua opção: ");
                    Console.WriteLine(" [1] - Inserir aAnimais\n [2] - listar animais\n [3] - Monstrar por nome\n [4] - Monstrar por especie\n [5] - Remover por nome\n [6] - Remover por especie");
                    Console.WriteLine("------------------------------");
                    Console.Write("Escolhe a sua opção: ");
                    opA = int.Parse(Console.ReadLine());
                    if (opA == 1){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Inserir Animais");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine(); 
                        Console.Write("Especie: ");
                        especie = Console.ReadLine();
                        Console.Write("Descrição: ");
                        descricao = Console.ReadLine();
                        Console.Write("Quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());
                        z.inserirAnimais(nome, especie, descricao, quantidade);
                    }else if(opA == 2){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Listar Animais");
                        Console.WriteLine("------------------------------");
                        z.listarAnimais();
                    }else if(opA == 3){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Monstrar Animal por Nome");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.monstrarAnimalNome(nome);
                    }else if(opA == 4){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Monstar Animal por Especie");
                        Console.WriteLine("------------------------------");
                        Console.Write("Especie: ");
                        especie = Console.ReadLine();
                        z.monstrarAnimalEspecie(especie);
                    }else if(opA == 3){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Remover Animal por Nome");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.RemoverAnimalNome(nome);
                    }else if(opA == 4){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Remover Animal por Especie");
                        Console.WriteLine("------------------------------");
                        Console.Write("Especie: ");
                        especie = Console.ReadLine();
                        z.RemoverAnimalEspecie(especie);
                    }
                }
                if(op == 2){
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Cliente");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Escolhe a sua opção: ");
                    Console.WriteLine(" [1] - Inserir clientes\n [2] - Listar clientes\n [3] - Monstrar por nome\n [4] - Monstrar por especie\n [5] - Remover por nome\n [6] - Remover por especie");
                    Console.WriteLine("------------------------------");
                    Console.Write("Escolhe a sua opção: ");
                    opC = int.Parse(Console.ReadLine());
                    if (opC == 1){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Inserir Clientes");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine(); 
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        Console.Write("Sexo: ");
                        sexo = Console.ReadLine();
                        Console.Write("Ano nascimento: ");
                        nasc = int.Parse(Console.ReadLine());
                        Console.Write("Saldo: ");
                        saldo = double.Parse(Console.ReadLine());
                        idade = ano - nasc;
                        z.inserirClientes(nome, numero, sexo, idade, saldo);
                    }else if(opC == 2){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Listar Clientes");
                        Console.WriteLine("------------------------------");
                        z.listarClientes();
                    }else if(opC == 3){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Monstrar Cliente por Nome");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.monstrarClienteNome(nome);
                    }else if(opC == 4){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Monstar Cliente por Especie");
                        Console.WriteLine("------------------------------");
                        Console.Write("Sexo: ");
                        sexo = Console.ReadLine();
                        z.monstrarClienteSexo(sexo);
                    }else if(opC == 3){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Remover Cliente por Nome");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.RemoverClienteNome(nome);
                    }else if(opC == 4){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Remover Cliente por Número");
                        Console.WriteLine("------------------------------");
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        z.RemoverClienteNumero(numero);
                    }
                }
                if(op == 3){
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Funcionarios");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Escolhe a sua opção: ");
                    Console.WriteLine(" [1] - Inserir funcionarios\n [2] - Listar funcionarios\n [3] - Monstrar por nome\n [4] - Monstrar por especie\n [5] - Remover por nome\n [6] - Remover por Numero");
                    Console.WriteLine("------------------------------");
                    Console.Write("Escolhe a sua opção: ");
                    opF = int.Parse(Console.ReadLine());
                    if (opF == 1){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Inserir Funcionarios");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine(); 
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        Console.Write("Sexo: ");
                        sexo = Console.ReadLine();
                        Console.Write("Ano nascimento: ");
                        nasc = int.Parse(Console.ReadLine());
                        Console.Write("Departamento: ");
                        departamento = Console.ReadLine(); 
                        Console.Write("Habilidades: ");
                        habilidades = Console.ReadLine();
                        Console.Write("Salario: ");
                        salario = double.Parse(Console.ReadLine());
                        idade = ano - nasc;
                        z.inserirFuncionarios(nome, numero, sexo, idade, departamento, habilidades, salario);
                    }else if(opF == 2){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Listar Funcionarios");
                        Console.WriteLine("------------------------------");
                        z.listarFuncionarios();
                    }else if(opF == 3){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Monstrar Funcionarios por Nome");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.monstrarFuncionarioNome(nome);
                    }else if(opF == 4){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Monstar Funcionarios por Sexo");
                        Console.WriteLine("------------------------------");
                        Console.Write("Sexo: ");
                        sexo = Console.ReadLine();
                        z.monstrarFuncionarioSexo(sexo);
                    }else if(opF == 3){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Remover Funcionario por Nome");
                        Console.WriteLine("------------------------------");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.RemoverFuncionarioNome(nome);
                    }else if(opF == 4){
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Remover Funcionario por Sexo");
                        Console.WriteLine("------------------------------");
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        z.RemoverFuncionarioNumero(numero);
                    }
                }
                
            }
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
