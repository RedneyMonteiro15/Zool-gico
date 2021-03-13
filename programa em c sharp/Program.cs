using System.Collections.Generic;
using System;
namespace zoologico
{
    class Program
    {
        static void Main(string[] args){
            Zoologico z = new Zoologico();
            int ano = DateTime.Now.Year;
            while (true){
                int op, opA, opC, opF, numero, quantidade, nasc, idade;
                string nome, departamento, habilidades, especie, descricao;
                char sexo;
                double saldo, salario;
                Cabecalho("Zoologico CV-SV");
                Menu("Animais", "Clientes", "Funcionarios");
                Linha();
                op = LeiaOp(6);
                if(op == 1){
                    Cabecalho("Animais");
                    Menu("Inserir aAnimais", "listar animais", "Monstrar por nome", "Monstrar por especie", "Remover por nome", "Remover por especie");
                    Linha();
                    opA = LeiaOp(3);
                    if (opA == 1){
                        Cabecalho("Inserir Animais");
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
                        Cabecalho("Listar Animais");
                        z.listarAnimais();
                    }else if(opA == 3){
                        Cabecalho("Monstrar Animais por Nome");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.monstrarAnimalNome(nome);
                    }else if(opA == 4){
                        Cabecalho("Monstrar Animais por Especie");
                        Console.Write("Especie: ");
                        especie = Console.ReadLine();
                        z.monstrarAnimalEspecie(especie);
                    }else if(opA == 3){
                        Cabecalho("Remover Animais por Nome");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.RemoverAnimalNome(nome);
                    }else if(opA == 4){
                    Cabecalho("Remover Animais por Especie");
                        Console.Write("Especie: ");
                        especie = Console.ReadLine();
                        z.RemoverAnimalEspecie(especie);
                    }
                }
                if(op == 2){
                    Cabecalho("Clientes");
                    Menu("Inserir clientes", "Listar clientes", "Monstrar por nome", "Monstrar por especie", "Remover por nome", "Remover por especie");
                    Linha();
                    opC = LeiaOp(6);
                    if (opC == 1){
                        Cabecalho("Inserir Clientes");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine(); 
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        sexo = VerificarSexo("Sexo: ");
                        Console.Write("Ano nascimento: ");
                        nasc = int.Parse(Console.ReadLine());
                        Console.Write("Saldo: ");
                        saldo = double.Parse(Console.ReadLine());
                        idade = ano - nasc;
                        z.inserirClientes(nome, numero, sexo, idade, saldo);
                    }else if(opC == 2){
                        Cabecalho("Listar Clientes");
                        z.listarClientes();
                    }else if(opC == 3){
                        Cabecalho("Monstrar Clientes por Nome");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.monstrarClienteNome(nome);
                    }else if(opC == 4){
                        Cabecalho("Monstrar Clientes por Sexo");
                        sexo = VerificarSexo("Sexo: ");
                        z.monstrarClienteSexo(sexo);
                    }else if(opC == 3){
                        Cabecalho("Remover Clientes por Nome");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.RemoverClienteNome(nome);
                    }else if(opC == 4){
                        Cabecalho("Remover Clientes por Número");
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        z.RemoverClienteNumero(numero);
                    }
                }
                if(op == 3){
                    Cabecalho("Funcionarios");
                    Menu("Inserir funcionarios", "Listar funcionarios", "Monstrar por nome", "Monstrar por especie", "Remover por nome", "Remover por Numero");
                    Linha();
                    opF = LeiaOp(6);
                    if (opF == 1){
                        Cabecalho("Inserir Funcionarios");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine(); 
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        sexo = VerificarSexo("Sexo: ");
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
                        Cabecalho("Listar Funcionarios");
                        z.listarFuncionarios();
                    }else if(opF == 3){
                        Cabecalho("Monstrar Funcionarios por Nome");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.monstrarFuncionarioNome(nome);
                    }else if(opF == 4){
                        Cabecalho("Monstrar Funcionarios por Sexo");
                        sexo = VerificarSexo("Sexo: ");
                        z.monstrarFuncionarioSexo(sexo);
                    }else if(opF == 3){
                        Cabecalho("Remover Funcionarios por Nome");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        z.RemoverFuncionarioNome(nome);
                    }else if(opF == 4){
                        Cabecalho("Remover Funcionarios por Sexo");
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        z.RemoverFuncionarioNumero(numero);
                    }
                }
                Linha();
                char teste = VerificarOp("Quer continuar: ");
                if(teste == 'N'){
                    Cabecalho("Fim do programa!!!");
                    break;
                }
                Console.Clear();
            }
        }
        static void Linha(){
            Console.WriteLine("------------------------------");
        }
        static void Cabecalho(string msg){
            Linha();
            Console.ForegroundColor = ConsoleColor.Blue;
            Center(msg, 30);
            Console.ResetColor();
            Linha();
        }
        static void Menu(params string[]texto){
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", "Escolha sua opção:".PadRight(30));
            int c = 1;
            string aux;
            foreach (var item in texto)
            {
                aux = "[" + c + "]" + " - " + item;
                Console.WriteLine("{0}", aux.PadRight(30));
                c += 1;
            }
            Console.ResetColor();
        }
        static int LeiaOp(int op){
            int opc;
            while(true){
                Console.Write("Sua Opção: ");
                opc = int.Parse(Console.ReadLine());
                if(opc > 0 && opc <= op){
                    return opc;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Invalida!!! \nDigite um número entre 1 e {0}", op);
                Console.ResetColor();
            }
        }
        static char VerificarOp(string texto){
            while(true){
                Console.Write("{0}", texto);
                string op = (Console.ReadLine()).ToUpper();
                char res = op[0];
                if(res == 'S' || res == 'N'){
                    return res;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Invalida!!! \nDigite um apenas S/N.");
                Console.ResetColor();
            }
        }
        static void Center(string teste, int num){
            int total, esquerda, direita;
            string test = "";
            total = num - teste.Length;
            direita = (total / 2) + teste.Length;
            esquerda = num - direita;
            Console.WriteLine("{0}{1}", teste.PadLeft(direita, ' '), test.PadRight(esquerda-1, ' '));
        }
        static char VerificarSexo(string msg){
            string op;
            while (true){
                Console.Write(msg);
                op = (Console.ReadLine()).ToUpper();
                if(op[0] == 'M' || op[0] == 'F'){
                    return op[0];
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! Digite um sexo válido [M/F].");
                Console.ResetColor();
            }
        }
    }
}
class Estrutura{
    
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
    public void inserirFuncionarios(string nome, int numero, char sexo, int nasc, string departamento, string habilidades, double salario)
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
    public void monstrarFuncionarioSexo(char sexo){
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
    public void inserirClientes(string nome, int numero, char sexo, int nasc, double salario)
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
    public void monstrarClienteSexo(char sexo){
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
    public void Reforma(){
        foreach (Funcionarios f in listaFuncionarios)
        {
            if(f.getIdadeFuncionario() > 65){
                f.alterarEstado("REFORMADO");
            }
        }
    }
    public void listarFuncionariosReformado(){
        foreach (Funcionarios f in listaFuncionarios)
        {
            if (f.getEstadoFuncionario() == "REFORMADO"){
                f.monstrarFuncionarios();
            }
        }
    }
    public void listarFuncionariosSexo(char sexo){
        foreach (Funcionarios f in listaFuncionarios)
        {
            if(f.getSexoFuncionario() == sexo){
                f.monstrarFuncionarios();
            }
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
    string nome, departamento, habilidades, estado;
    char sexo;
    int numero, idade;
    double salario;
    public Funcionarios(string nome, int numero, char sexo, int idade, string departamento, string habilidades, double salario)
    {
        this.nome = nome;
        this.numero = numero;
        this.sexo = sexo;
        this.idade = idade;
        this.departamento = departamento;
        this.habilidades = habilidades;
        this.salario = salario;
        this.estado = "ATIVO";
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
        Console.WriteLine("Idade: {0}", this.idade);
        Console.WriteLine("Departamento: {0}", this.departamento);
        Console.WriteLine("Habilidades: {0}",this.habilidades);
        Console.WriteLine("Salario: {0}", this.salario);
        Console.WriteLine("Estado: {0}", this.estado);
    }
    public string getNomeFuncionario(){
        return this.nome;
    }
    public int getNumeroFuncionario(){
        return this.numero;
    }
    public char getSexoFuncionario(){
        return this.sexo;
    }
    public int getIdadeFuncionario(){
        return this.idade;
    }
    public string getEstadoFuncionario(){
        return this.estado;
    }
    public void alterarEstado(string estado){
        this.estado = estado;
    }
}
class Clientes
{
    string nome;
    char sexo;
    int numero, nasc;
    double saldo;
    public Clientes(string nome, int numero, char sexo, int nasc, double saldo){
        this.nome = nome;
        this.numero = numero;
        this.sexo = sexo;
        this.nasc = nasc;
        this.saldo = saldo;
    }
    public void monstrarClientes(){
        Console.WriteLine("----------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Lista dos Clientes");
        Console.ResetColor();
        Console.WriteLine("----------------------");
        Console.WriteLine($"Nome: {this.nome}");
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
    public char getSexoCliente(){
        return this.sexo;
    }
}
