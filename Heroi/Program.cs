using System;

namespace Heroi
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro carlos = new Guerreiro("Carlos", 19, 5, new Status(55, 40, 10, 20, 175, 0));
            Arqueiro andre = new Arqueiro("André", 20, 10, new Status(35, 20, 25, 20, 170, 30));
            Mago caio = new Mago("Caio", 18, 15, new Status(40, 20, 15, 20, 155, 50));
            Goblin goblin = new Goblin(1, new Status(30, 15, 20, 10, 50, 0));
            Aranha aranha = new Aranha(1, new Status(15, 5, 35, 10, 40, 0));
            BebeDragao bebeDragao = new BebeDragao(1, new Status(40, 10, 25, 10, 80, 0));

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("GUERREIRO");
            Console.WriteLine("Nome: {0}", carlos.Nome);
            Console.WriteLine("Idade: {0}", carlos.Idade);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("STATUS - GUERREIRO");
            Console.WriteLine("Força: {0}", carlos.Status.Forca);
            Console.WriteLine("Defesa: {0}", carlos.Status.Defesa);
            Console.WriteLine("Agilidade: {0}", carlos.Status.Agilidade);
            Console.WriteLine("Sorte: {0}", carlos.Status.Sorte);
            Console.WriteLine("Vida: {0}", carlos.Status.Vida);
            Console.WriteLine("Mana: {0}", carlos.Status.Mana);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Vida inicial Goblin: {0}", goblin.Status.Vida);
            Console.WriteLine("Vida inicial Aranha: {0}", aranha.Status.Vida);
            Console.WriteLine("Vida inicial Bebê Dragão: {0}", bebeDragao.Status.Vida);

            Console.WriteLine("Vida inicial Guerreiro: {0}", carlos.Status.Vida);
            Console.WriteLine("Vida inicial Arqueiro: {0}", andre.Status.Vida);
            Console.WriteLine("Vida inicial Mago: {0}", caio.Status.Vida);

            Console.WriteLine("---------------------------------------------------");

            goblin.RecebeAtaque(carlos.AtaqueFinal());
            aranha.RecebeAtaque(andre.AtaqueFinal());
            bebeDragao.RecebeAtaque(caio.AtaqueFinal());
            
            carlos.RecebeAtaque(goblin.AtaqueFinal());
            andre.RecebeAtaque(aranha.AtaqueFinal());
            caio.RecebeAtaque(bebeDragao.AtaqueFinal());

            Console.WriteLine("Vida final Goblin: {0}", goblin.Status.Vida);
            Console.WriteLine("Vida final Aranha: {0}", aranha.Status.Vida);
            Console.WriteLine("Vida final Bebê Dragão: {0}", bebeDragao.Status.Vida);

            Console.WriteLine("Vida final Guerreiro: {0}", carlos.Status.Vida);
            Console.WriteLine("Vida final Arqueiro: {0}", andre.Status.Vida);
            Console.WriteLine("Vida final Mago: {0}", caio.Status.Vida);

            Console.WriteLine("---------------------------------------------------");

            caio.Cura();
            Console.WriteLine("Vida Final Mago: {0} e Mana: {1}", caio.Status.Vida, caio.Status.Mana);
        }
    }
}
