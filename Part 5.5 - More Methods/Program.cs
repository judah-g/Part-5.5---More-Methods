using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5._5___More_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //big j

            Die die1 = new Die(), die2 = new Die();

            die1.RollDie(); die2.RollDie(); die2.RollDie();
            die1.DrawDie(); die2.DrawDie();

            if (die1.Roll + die2.Roll == 7)
            { Console.WriteLine("Your dice have a sum of 7"); }
            if (die1.Roll + die2.Roll == 2)
            { Console.WriteLine("You rolled snake eyes"); }
            if ((die1.Roll + die2.Roll) % 2 == 0)
            { Console.WriteLine("Your numbers have even sum"); }
            if (die1.Roll + 1 == die2.Roll || die2.Roll + 1 == die1.Roll)
            { Console.WriteLine("You have sequential dice"); }

            if (die1.Roll == die2.Roll)
            { Console.WriteLine("You rolled doubles"); }
            else if (die1.Roll > die2.Roll)
            { Console.WriteLine("Die 1 is bigger than die 2"); }
            else { Console.WriteLine("Die 2 is bigger than die 1"); }

            Console.WriteLine();
            Console.Write("Press enter to exit:\t");
            Console.Read();
        }
    }
}
