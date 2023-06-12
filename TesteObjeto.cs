using System;
namespace SintaxePOO
{
  public class Saldo
  {
  //Declaração dos atributos
  public int numero;
  public string nome;
  public double saldo; 

    //construtor
    Saldo(int numero, string nome, double saldo)
   {

    this.numero = numero;
    this.nome = nome;
    this.saldo = saldo;

    }

    //Destrutor
    ~Saldo()
    {

    }
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite o número da conta: ");
      int numero = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o seu nome: ");
      string nome = Console.ReadLine();

      Console.WriteLine("Digite o saldo da Conta: ");
      double saldo = double.Parse(Console.ReadLine());

      Saldo c = new Saldo(numero,nome, saldo);
      Console.WriteLine("{0}, {1}, {2}", c.numero, c.nome, c.saldo);

    }
    
  }
}
