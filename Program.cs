using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Estudio estudio1 = new Estudio();
    estudio1.adicionarAtor("Redney", "redneymonteiro15@gmail.com");
    estudio1.adicionarAtor("Monteiro", "ere@");
    estudio1.adicionarAtor("Redney", "redneymonteiro15@gmail.com");
    estudio1.adiconadarFime(23, "Operações especias");
    estudio1.adiconadarFime(11, "Liberdade");
    estudio1.adiconadarFime(23, "N«Tes");
    estudio1.listarAtor();
    estudio1.listarFilme();
  }
}

class Estudio
{
    List<Filme> listaFilme;
    List<Ator> listaAtor;
    public Estudio()
    {
        listaAtor = new List<Ator>();
        listaFilme = new List<Filme>();
    }
    public void adicionarAtor(string nome, string email)
    {
        if(pesquisarAtor(nome) is Ator)
        {
            Console.WriteLine("ERRO! Ator já existe.");
            return;
        }
        Ator ator = new Ator(nome, email);
        listaAtor.Add(ator);
        Console.WriteLine($"Ator {nome} adiconado com suceso.");
    }
    public Ator pesquisarAtor(string nome)
    {
        foreach(Ator ator in listaAtor)
        {
            if(nome == ator.getAtor())
            {
                return ator;
            }
        }
        return null;
    }
    public void listarAtor()
    {
        linha();
        Console.WriteLine("Lista dos Atores");
        linha();
        foreach(Ator ator in listaAtor)
        {
            ator.monstrarAtor();
            linha();
        }
    }
    public void adiconadarFime(int numero, string titulo)
    {
        if(pesquisarFime(numero) is Filme)
        {
            Console.WriteLine("ERRO! Filme já existido.");
            return;
        }
        Filme filme = new Filme(numero, titulo);
        listaFilme.Add(filme);
        Console.WriteLine($"Filme {titulo} adicionado com sucesso.");
    }
    public Filme pesquisarFime(int numero)
    {
        foreach(Filme filme in listaFilme)
        {
            if(numero == filme.getNumero())
            {
                return filme;
            }
        }
        return null;
    }
    public void listarFilme()
    {
        linha();
        Console.WriteLine("Lista dos Filmes");
        linha();
        foreach(Filme filme in listaFilme)
        {
            filme.monstrarFime();
            linha();
        }
    }
    static void linha()
    {
        Console.WriteLine("---------------------------------");
    }
}

class Filme
{
    string titulo;
    int numero;
    public Filme(int numero, string titulo)
    {
        this.titulo = titulo;
        this.numero = numero;
    }
    public int getNumero()
    {
        return this.numero;
    }
    public void monstrarFime()
    {
        Console.WriteLine($"Número: {numero}");
        Console.WriteLine($"Título: {titulo}");
    }
}

class Ator
{
    string nome, email;
    public Ator(string nome, string email)
    {
        this.nome = nome;
        this.email = email;
    }
    public void monstrarAtor()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
    }
    public string getAtor()
    {
        return this.nome;
    }
}

class Personagem
{
    string papel, tipo;
    public Personagem(string papel, string tipo)
    {
        this.papel = papel;
        this.tipo = tipo;
    }
    public void monstrarPersonagem()
    {
        Console.WriteLine($"Papel: {papel}");
        Console.WriteLine($"Tipo: {tipo}");
    }
}
