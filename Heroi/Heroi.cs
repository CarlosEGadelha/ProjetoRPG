using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi
{
    class Heroi 
    {
        public Status Status { get;  set; }
        public string Nome{ get; set; }
        public int Idade { get; set; }
        public int Level { get; set; }

        public void falarONome()
        {
            Console.WriteLine("Meu nome é {0}", this.Nome);
        }

        public void recebeDano()
        {
            Console.WriteLine("Recebeu dano\n\n");
        }
    }
}
