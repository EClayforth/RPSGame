using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    internal class Play
    { public static void Round() {

            Dialog.RPSSelection();

            var pchoice = GameMechanics.Pchoice();

            var cchoice = GameMechanics.Cchoice();

            Dialog.OMove(GameMechanics.CMove(cchoice));

            var result = GameMechanics.GameResult(pchoice, cchoice);

            if (result == "w" ){ Dialog.WinMessage(); }

            else if (result == "d") { Dialog.DrawMessage(); }

            else {
                Dialog.LossMessage();

            }

            bool again = GameMechanics.AskPlayAgain();
            GameMechanics.CheckPlayAgain(again);
           


        }
    }
}
