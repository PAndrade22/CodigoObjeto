using System;

namespace UOU
{
    public abstract class Heroi
    {
        protected string Nome;
        protected float PtsVida;
        protected int UTHeroi;

        public Heroi(string nome, float ptsVida)
        {
            this.Nome = nome;
            this.PtsVida = ptsVida;
            this.UTHeroi = 7;
        }

        public abstract void LancarMagia(Heroi alvo);
        public abstract void AtacarComArma(Heroi alvo);

        public virtual void ReduzirVida(float dano)
        {
            this.PtsVida -= dano;
        }

        public virtual void AumentarVida()
        {
            this.PtsVida++;
        }

        public String GetNome()
        {
            return this.Nome;
        }

        public float GetPtsVida()
        {
            return this.PtsVida;
        }

        public int GetUTHeroi()
        {
            return this.UTHeroi;
        }

        public void AumentarUT(int valor)
        {
            this.UTHeroi += valor;
        }

        public void ReduzirUT(int valor)
        {
            this.UTHeroi -= valor;
        }
    }

    public class HeroiAlianca : Heroi
    {
        public Magia magia;
        public Arma arma;
        public HeroiAlianca(string nome, int ptsVida) : base(nome, ptsVida)
        {
            this.magia = new Magia("Força Rutilante", 4, 20);
            this.arma = new Arma("Espada", 2, 10);
        }

        public override void LancarMagia(Heroi alvo)
        {
            if (this.UTHeroi >= this.magia.CustoUT)
            {
                Console.WriteLine(this.Nome + " lançou a magia " + this.magia.Nome + " em " + alvo.GetNome());
                float dano = this.magia.Lancar();
                alvo.ReduzirVida(dano);
                Console.WriteLine("Dano causado: " + dano);
                Console.WriteLine("Pts de vida restantes de " + alvo.GetNome() + ": " + alvo.GetPtsVida());
                this.ReduzirUT(this.magia.CustoUT);
            }
            else
            {
                Console.WriteLine(this.Nome + " não possui unidades de tempo suficientes para lançar a magia.");
            }
        }

        public override void AtacarComArma(Heroi alvo)
        {
            if(this.UTHeroi >= this.arma.CustoUT)
            {
                Console.WriteLine(this.Nome + "atacou com a arma"+ this.arma.Nome + " em " + alvo.GetNome());
                float dano = this.arma.Atacar();
                alvo.ReduzirVida(dano);
                Console.WriteLine("Dano causado:" + dano);
                Console.WriteLine("Pts de vida restante de " + alvo.GetNome() + ": " + alvo.GetPtsVida());
                this.ReduzirUT(this.arma.CustoUT);
            }
             else
            {
                Console.WriteLine(this.Nome + " não possui unidades de tempo suficientes para atacar com arma.");
            }
        }
    }

    public class HeroiHorda : Heroi
    {
        public Magia magia;
        public Arma arma;

        public HeroiHorda(string nome, int ptsVida) : base(nome, ptsVida)
        {
            this.magia = new Magia("Caminho de Chamas", 6, 30);
            this.arma = new Arma("Machado", 4, 20);
        }

        public override void LancarMagia(Heroi alvo)
        {
            if (this.UTHeroi >= this.magia.CustoUT)
            {
               Console.WriteLine(this.Nome + " lançou a magia " + this.magia.Nome + " em " + alvo.GetNome());
                float dano = this.magia.Lancar();
                alvo.ReduzirVida(dano);
                Console.WriteLine("Dano causado: " + dano);
                Console.WriteLine("Pts de vida restantes de " + alvo.GetNome() + ": " + alvo.GetPtsVida());
                this.ReduzirUT(this.magia.CustoUT);
            }
        }

        public override void AtacarComArma(Heroi alvo)
        {
            if (this.UTHeroi >= this.arma.CustoUT)
            {
                Console.WriteLine(this.Nome + " atacou " + alvo.GetNome() + " com o(a) " + this.arma.Nome);
                float dano = this.arma.Atacar();
                alvo.ReduzirVida(dano);
                Console.WriteLine("Dano causado: " + dano);
                Console.WriteLine("Pts de vida restantes de " + alvo.GetNome() + ": " + alvo.GetPtsVida());this.ReduzirUT(this.arma.CustoUT);
            }
            else{  
             Console.WriteLine(this.Nome + " não possui unidades de tempo suficientes para atacar com a arma.");
      }
    }
  }   

        
public class Magia
    {
        
    
       
public string Nome { get; }
        
       
public int CustoUT { get; }
        
       
public int Dano { get; }

        public Magia(string nome, int custoUT, int dano)
        {
            this.Nome = nome;
            this.CustoUT = custoUT;
            this.Dano = dano;
        }

        public float Lancar()
        {
            Console.WriteLine("Magia " + this.Nome + " lançada!");
            return this.Dano;
        }
    
  }
    
public class Arma
    {
        public string Nome { get; }
        
        public int CustoUT { get; }
        public int Dano { get; }

public Arma(string nome, int custoUT, int dano)
        {
            this.Nome = nome;
            this.CustoUT = custoUT;
            this.Dano = dano;
        }

        
        public float Atacar()
        {
            Console.WriteLine("Ataque com " + this.Nome + " realizado!");
            return this.Dano;
        }

         public class ProgramaPrincipal
   {
    public static void Main(string[] args)
    {

        HeroiAlianca HeroAlianca = new HeroiAlianca("Zydu", 80);
        Console.WriteLine()
        HeroiHorda HeroHorda = new HeroiHorda("Brand", 80);



    }
   } 
  }   
}


    

    
  
