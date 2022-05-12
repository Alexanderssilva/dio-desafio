using System;
using criando_um_jogo.src.Entities;

namespace criando_um_jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",42,"Knight",200,150,100,50);
            Wizard wizard = new Wizard("Jennica",42,"White Wizard",100,50,200,150);
            Ninja ninja = new Ninja("Wedge",42,"Ninja",150,100,150,100);
            BlackWizard blackWizard = new BlackWizard("Topapa",42,"Black Wizard",100,75,200,90);
           
            Console.WriteLine(arus.Attack(7));
            Console.WriteLine(wizard.Attack(3));
            Console.WriteLine(ninja.Attack(5));
            Console.WriteLine(blackWizard.Attack(7));
        }
    }
}
