using System;
namespace SemmpreEmForma
{
  public class Pessoa
  {
    private int pesoDaPessoa;
    private float alturaDaPessoa;
    private string nomeDaPessoa;
    //Construtor Pessoa (THIS)
    Pessoa(int pesoDaPessoa, float alturaDaPessoa, string nomeDaPessoa)
    {
      this.pesoDaPessoa = pesoDaPessoa;
      this.alturaDaPessoa = alturaDaPessoa;
      this.nomeDaPessoa = nomeDaPessoa;
    }
    //Método Get
    public int getpesoDaPessoa(){
      return (pesoDaPessoa);
    }
    public float getalturaDaPessoa(){
      return (alturaDaPessoa);
    }
    public string getnomeDaPessoa(){
      return (nomeDaPessoa);
    }
    //Método Set
    public void setpesoDaPessoa(int pesoDaPessoa){
      this.pesoDaPessoa = pesoDaPessoa;
    }
    public void setalturaDaPessoa(float alturaDaPessoa){
      this.alturaDaPessoa = alturaDaPessoa;
    }
    public void setnomeDaPessoa(string nomeDaPessoa){
      this.nomeDaPessoa = nomeDaPessoa;
    }
    //Método para calcular o IMC da Pessoa
    public double calculaIMC()
    {
      double imcDaPessoa = ((pesoDaPessoa)/(alturaDaPessoa*alturaDaPessoa));
      return imcDaPessoa;
    }
    //método para avaliar o IMC da Pessoa
    public string avaliaIMC()
    {
      if (this.calculaIMC() < 18.5){
      return "BAIXO";
      }
      else{
          if (this.calculaIMC() >= 25){
          return "ALTO";
           }else {
            return "NORMAL";
        }
      }
    }
    //Método meta para emagrecer 
    public void metaEmagrecer (int meta)
    {
      Console.WriteLine("Meta para emagrecer é {0}kg", meta);
      this.pesoDaPessoa -= meta;
    }
    //Método meta para engordar 
    public void metaEngordar(int meta)
    {
      Console.WriteLine("Meta para encgorcar é {0}kg", meta);
      this.pesoDaPessoa += meta;
    }
    //Programa Principal 
    public static void Main(string[] args)
    {
      int pesoDaPessoa = 0;
      float alturaDaPessoa = 0f;
      string nomeDaPessoa = "";


      Console.WriteLine("Digite o seu nome: ");
      nomeDaPessoa = Console.ReadLine();
      
      Console.WriteLine("Digite o seu peso: ");
      pesoDaPessoa = int.Parse(Console.ReadLine ());

      Console.WriteLine("Digite a sua altura: ");
      alturaDaPessoa = float.Parse(Console.ReadLine ());

      Pessoa Paciente = new Pessoa (pesoDaPessoa, alturaDaPessoa, nomeDaPessoa);

      Console.WriteLine("O 'Nome' do paciente é {0}.", Paciente.getnomeDaPessoa());
      Console.WriteLine("O 'Peso' do paciente é {0}.", Paciente.getpesoDaPessoa());
      Console.WriteLine("A 'altura' do paciente é {0}", Paciente.getalturaDaPessoa());

      Console.WriteLine("\n ---------- \n");
      Console.WriteLine("     QUAL A SUA META      ");
      Console.WriteLine("\n ---------- \n");
      Console.WriteLine("1 - Emagrecer");
      Console.WriteLine("2 - Engordar");
      int opcaoDeMeta = int.Parse(Console.ReadLine());
      if (opcaoDeMeta == 1){
        Console.WriteLine("Quanto você quer emagrecer?");
        int meta = int.Parse(Console.ReadLine());
        Paciente.metaEmagrecer(meta);
        Console.WriteLine("Você conseguiu emagrecer {0}", Paciente.getpesoDaPessoa());
      }
      else{
        if (opcaoDeMeta == 2){
        Console.WriteLine("Quanto você quer engordar?");
        int meta = int.Parse(Console.ReadLine());
        Paciente.metaEngordar(meta);
        Console.WriteLine("Você conseguiu emagrecer {0}", Paciente.getpesoDaPessoa());
          
        }
      }
    }
  }
}
