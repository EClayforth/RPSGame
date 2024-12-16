using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    internal class Dialog
    { public static void Intro() {
            Console.WriteLine("Welcome To Rock, Paper Scissors");
            System.Threading.Thread.Sleep(700);


        }

        public static void RPSSelection() {
            Console.WriteLine("Would You like to play Rock(r), Paper(p) or Scissor(s)");

        }

        public static void WinMessage() { Console.WriteLine("You have won!"); }

        public static void LossMessage() { Console.WriteLine("You have lost!"); }

        public static void DrawMessage() { Console.WriteLine("This was a Draw, You must play again!!!" ); }

        public static void PlayAgain() { Console.WriteLine("Play again? (y/n)"); }

        public static void OMove(string omove) { Console.WriteLine("The opponent used " + omove); }

        public static void EndGame() { Console.WriteLine("Thank you playing");  }

        public static void Hardmode() { Console.WriteLine("Would you like to play hard mode? y/n"); }

    }
}
