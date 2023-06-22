using System;

namespace UOU
{
    public abstract class Heroi
    {
        protected string Nome;
        protected float PtsVida;
        protected int UTHeroi;
        
        //Construtor Herói

        public Heroi(string nome, float ptsVida)
        {
            this.Nome = nome;
            this.PtsVida = ptsVida;
            this.UTHeroi = 7;
        }

        //Método Lançar Magia
        public abstract void LancarMagia(Heroi alvo);
        //Método Atacar com Arma
        public abstract void AtacarComArma(Heroi alvo);

        //Método Reduzir Vida
        public virtual void ReduzirVida(float dano)
        {
            this.PtsVida -= dano;
        }

        //Método GetHerói
        public string GetNome()
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

        //Método Aumentar UT
        public void AumentarUT(int valor = 3)
        {
            this.UTHeroi += valor;
        }

        //Método Reduzir UT
        public void ReduzirUT(int valor)
        {
            this.UTHeroi -= valor;
        }
    }

    //Classe Herói da Aliança
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
                Console.WriteLine("\n");
                Console.WriteLine(this.Nome + " lançou a magia " + this.magia.Nome + " em " + alvo.GetNome());
                float dano = this.magia.Lancar();
                alvo.ReduzirVida(dano);
                Console.WriteLine("Dano causado: " + dano);
                Console.WriteLine("Pts de vida restantes de " + alvo.GetNome() + ": " + alvo.GetPtsVida());
                this.ReduzirUT(this.magia.CustoUT);
                this.AumentarUT(this.magia.CustoUT);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(this.Nome + " não possui unidades de tempo suficientes para lançar a magia.");
            }
        }

        public override void AtacarComArma(Heroi alvo)
        {
            if (this.UTHeroi >= this.arma.CustoUT)
            {   
                Console.WriteLine("\n");
                Console.WriteLine(this.Nome + " atacou com a arma " + this.arma.Nome + " em " + alvo.GetNome());
                float dano = this.arma.Atacar();
                alvo.ReduzirVida(dano);
                Console.WriteLine("Dano causado: " + dano);
                Console.WriteLine("Pts de vida restantes de " + alvo.GetNome() + ": " + alvo.GetPtsVida());
                this.ReduzirUT(this.arma.CustoUT);
                this.AumentarUT(this.arma.CustoUT);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(this.Nome + " não possui unidades de tempo suficientes para atacar com arma.");
            }
        }
    }

    //Classe Herói da Horda
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

                this.AumentarUT(this.magia.CustoUT);
          
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
                Console.WriteLine("Pts de vida restantes de " + alvo.GetNome() + ": " + alvo.GetPtsVida());
                this.ReduzirUT(this.arma.CustoUT);
                this.AumentarUT(this.arma.CustoUT);
              
            }
            else
            {
                Console.WriteLine(this.Nome + " não possui unidades de tempo suficientes para atacar com a arma.");
            }
        }
    }

     //Classe Magia
    public class Magia
    {
        public string Nome { get; }
        public int CustoUT { get; }
        public int Dano { get; }

        //Construto Magia
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

     //Classe Arma
    public class Arma
    {
        public string Nome { get; }
        public int CustoUT { get; }
        public int Dano { get; }

        //Construtor Arma
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
    }

    //Classe Uou
    public class UoU
    {
        private static readonly short STARTING = 0;
        private static readonly short RUNNING = 1;
        private static readonly short GAMEOVER = 2;
        private static readonly short VIDA = 80;

        private short Status{get; set;}

        public UoU()
        {
            this.Status = UoU.STARTING;
        }

        public void Print()
        {
            Console.WriteLine(this.Status);
        }

        //Classe Programa Principal
        public class ProgramaPrincipal
        {
            public static void Main(string[] args)
            {
                HeroiAlianca HeroAlianca = new HeroiAlianca("Zydu", 80); //Herói da Aliança
                Console.WriteLine("\n ---- HERÓI DA ALIANÇA ----\n");
                Console.WriteLine("Herói da Aliança : " + HeroAlianca.GetNome());
                Console.WriteLine("Pontos de vida: " + HeroAlianca.GetPtsVida());

                HeroiHorda HeroHorda = new HeroiHorda("Brand", 80); //Herói da Horda
                Console.WriteLine(" ---- HERÓI DA HORDA ----\n");
                Console.WriteLine("Herói da Horda : " + HeroHorda.GetNome());
                Console.WriteLine("Pontos de vida : " + HeroHorda.GetPtsVida());

                // Inicialização

                UoU game = new UoU();
                game.Status = UoU.RUNNING;
                game.Print();

                string ataque = string.Empty;
                 
                while (game.Status == UoU.RUNNING)
                {
                    Console.WriteLine("Ataque da Aliança:");
                    Console.WriteLine("Digite M para Magia e A para arma...");
                     ataque = Console.ReadLine();
                     Console.WriteLine("\n");

                    // Batalha entre Horda e Aliança

                    if (ataque.Equals("M") || ataque.Equals("m"))
                        HeroAlianca.LancarMagia(HeroHorda);
                  
                    else if (ataque.Equals("A") || ataque.Equals("a"))
                        HeroAlianca.AtacarComArma(HeroHorda);

                    if (HeroHorda.GetPtsVida() <= 0)
                    {
                        Console.WriteLine("\n");
                        game.Status = UoU.GAMEOVER;
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("\n");
                        break;
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Ataque da Horda:");
                    Console.WriteLine("Digite M para Magia e A para arma...");
                    ataque = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (ataque.Equals("M") || ataque.Equals("m"))
                        HeroHorda.LancarMagia(HeroAlianca);
                    else if (ataque.Equals("A") || ataque.Equals("a"))
                        HeroHorda.AtacarComArma(HeroAlianca);

                    if (HeroAlianca.GetPtsVida() <= 0)
                    {
                        Console.WriteLine("\n");
                        game.Status = UoU.GAMEOVER;
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("\n");
                        break;
                    }

                }

                // Fim de jogo
                if (HeroAlianca.GetPtsVida() > 0 && HeroHorda.GetPtsVida() <= 0){
                    Console.WriteLine("\n");
                   Console.WriteLine("Herói da Aliança venceu!");
                   Console.WriteLine("Vida restante: " + HeroAlianca.GetPtsVida());
                }
                 else
                   if (HeroAlianca.GetPtsVida() <= 0 && HeroHorda.GetPtsVida() > 0){
                    Console.WriteLine("\n");
                    Console.WriteLine("Herói da Horda venceu!");
                    Console.WriteLine("Vida restante: " + HeroHorda.GetPtsVida());
                    
                }
                
            }
        }
    }
}
