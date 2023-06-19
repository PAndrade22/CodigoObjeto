using System;
namespace UordiofUorcrefiti
{
  public class Heroi 
  {
    private string nomeHeroi;
    private int pontosDeVida;

    //Construtor Herói
    Heroi(string nomeHeroi, int pontosDeVida)
    {
      this.nomeHeroi = nomeHeroi;
      this.pontosDeVida = pontosDeVida;
    }
    //Método Get
    public string getnomeHeroi(){
      return (nomeHeroi);
    }
    public int getpontosDeVida(){
      return (pontosDeVida);
    }
    //Método Set
    public void setnomeHeroi(string nomeHeroi){
      this.nomeHeroi = nomeHeroi;
    }
    public void setpontosDeVida(int pontosDeVida){
      this.pontosDeVida = pontosDeVida;
    }
    //Método Reduzir pontos de vida
    public double reduzirVida(int pontosDeVida)
    {
      int reduzirPontosDeVida = 5;
      this.pontosDeVida -= reduzirPontosDeVida;
      return pontosDeVida;
    }
     public double aumentarVida(int pontosDeVida)
    {
      int aumentarPontosDeVida = 8;
      this.pontosDeVida += aumentarPontosDeVida;
      return pontosDeVida;
    }
    public class HeroiAlianca : Heroi
    {

    }
    
    public class ProgramaPrincipal
    {
  
    public static void Main(string[] args)
    {
      string nomeHeroi = "";
      int pontosDeVida = 100;

      Heroi Hero = new Heroi(nomeHeroi = "Zymmax", pontosDeVida);
      Console.WriteLine("O nome do herói é {0}", Hero.getnomeHeroi());
      Console.WriteLine("Os pontos de vida do 'Herói' {0} é {1} pontos ", Hero.getnomeHeroi(), Hero.getpontosDeVida());
      
      Hero.reduzirVida(pontosDeVida);
      Console.WriteLine("Os pontos de vida do 'Heóri' foi reduzido para {0}", Hero.getpontosDeVida());
      Hero.aumentarVida(pontosDeVida);
      Console.WriteLine("Os pontos de vida do 'Herói' foi aumentado para {0}.", Hero.getpontosDeVida());
   }
  } 
 }
}
