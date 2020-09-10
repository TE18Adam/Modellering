using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {

           football theBall = new football();
           football ball2 = new football();

           Player p1 = new Player();
           Player p2 = new Player();

           goal score  = new goal();
           
           
           theBall.x = 40;
           ball2.x = 50;

           System.Console.WriteLine(score.score);

           Console.ReadLine();
        }
    }
}
