using System;

namespace Backend
{

  public class Pessoa
  {
    // Propriedades da classe
    public string Nome { get; set; }
    public int Idade { get; private set; }
    public int Resultado { get; private set; }

    //Construtor
    public Pessoa(string nome, int idade, int a, int b)
    {
      Nome = nome;
      Idade = idade;
      Resultado = a + b;
    }

    // Metodos
    public void Cumprimentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }

    public void FazConta()
    {
      Console.WriteLine($"O resultado é {Resultado}");
    }

    public void FazAniversaio()
    {
      Idade++;
      Console.WriteLine($"Parabens {Nome}, agora voce tem {Idade}");
    }
  }


  class Program
  {
    static void Main(string[] args)
    {

      Pessoa pessoa1 = new Pessoa("Murilo", 20, 10, 15);

      pessoa1.Cumprimentar();
      pessoa1.FazAniversaio();

    }
  }
}

