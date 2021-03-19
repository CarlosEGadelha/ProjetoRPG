using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi
{
    class Mago : Heroi
    {
        public double Ataque { get; set; }
        public int Defesa { get; set; }

        public Mago(string nome, int idade, int level, Status status)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Level = level;
            this.Status = status;
        }
        public double DefesaFinal()
        {
            Random numAleatorio = new Random();
            int sorteio = numAleatorio.Next(0, this.Status.Sorte);
            this.Defesa = (this.Status.Defesa + this.Status.Agilidade) * (1 + (sorteio / 100));
            return this.Defesa;
        }

        public double AtaqueFinal()
        {
            Random numAleatorio = new Random();
            double sorteio = numAleatorio.Next(0, this.Status.Sorte);
            this.Ataque = ((this.Status.Forca + this.Status.Agilidade) * (1 + (sorteio / 100)));
            //Console.WriteLine("Ataque {0}", this.Ataque);
            return this.Ataque;
        }

        public void Cura() { 
            double cura = this.Status.Vida * 0.10;

            if (this.Status.Mana >= 10)
            {
                this.Status.Mana -= 10;
                this.Status.Vida += cura;
                Console.WriteLine("O mago {0} curou {1} de vida!", this.Nome, cura);
            }
            else
            {
                Console.WriteLine("O mago {0} está sem mana, não consegue se curar!", this.Nome);
            }
        }

        public void RecebeAtaque(double forcaInimigo)
        {
            double resultado = DefesaFinal() - forcaInimigo;
            if (resultado >= 0)
            {
                Console.WriteLine("Bloqueou o ataque!");
            }
            else
            {
                this.Status.Vida += resultado;
                if (this.Status.Vida <= 0)
                    Console.WriteLine("O mago {0} morreu!", this.Nome);
            }
        }
    }
}
