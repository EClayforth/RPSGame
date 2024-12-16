using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    internal class GameMechanics
    {
        public static string Pchoice()
        {
            string pchoice = Console.ReadLine();
            return pchoice;
        }

        public static string Cchoice()
        {

            Random rnd = new Random();

            int Num = rnd.Next(1, 3);

            if (Num == 1)
            {
                string cchoice = "r";

                return cchoice;

            }

            else if (Num == 2)
            {
                string cchoice = "p";

                return cchoice;
            }

            else
            {
                string cchoice = "S";

                return cchoice;
            }


        }
        public static string GameResult(string pchoice, string cchoice
            )
        {
            if (pchoice == cchoice)
            {
                string result = "d";
                return result;
            }
            else if (pchoice == "r" & cchoice == "s")
            {
                string result = "w";
                return result;
            }

            else if (pchoice == "p" & cchoice == "r")
            {
                string result = "w";
                return result;
            }
            else if (pchoice == "s" & cchoice == "p")
            {
                string result = "w";
                return result;

            }

            else
            {
                string result = "l";
                return result;
            }


        }
        public static string CMove(string cchoice)
        {
            if (cchoice == "r")
            {
                return "Rock";
            }

            else if (cchoice == "p")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
        public static bool AskPlayAgain()
        {
            Dialog.PlayAgain();
            string again = Console.ReadLine();

            if (again == "y" || again == "Y")
            {

                return true;
            }
            else { return false; }
        }
        public static void CheckPlayAgain(bool ans, Player player1
            )
        {
            if (ans)
            {
                Game.Round(player1);
                return;
            }
            else
            {
                Dialog.EndGame();
                return;
            }


        }
        public static void ResolveGame(string result)
        {
            if (result == "w") { Dialog.WinMessage(); }

            else if (result == "d")
            {
                Dialog.DrawMessage();
            }

            else
            {
                Dialog.LossMessage();

            }
        }

        public static void DrawResolution(string result, Player player1)
        {
            if (result == "d") { Game.Round(player1); }
            else
            {
                bool again = GameMechanics.AskPlayAgain();
                GameMechanics.CheckPlayAgain(again, player1);

            }
        }
    }
}
