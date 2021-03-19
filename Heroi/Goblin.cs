using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi
{
    class Goblin : Monstro
    {
        public double Ataque { get; set; }
        public int Defesa { get; set; }

        public Goblin(int level, Status status)
        {
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
                    Console.WriteLine("O Goblin morreu!");
            }
        }
    }
}
