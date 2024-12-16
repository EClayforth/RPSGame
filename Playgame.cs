using System;
using System.Buffers;
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
            System.Threading.Thread.Sleep(700);

            var result = GameMechanics.GameResult(pchoice, cchoice);
            System.Threading.Thread.Sleep(700);

            GameMechanics.ResolveGame(result);
            System.Threading.Thread.Sleep(700);

            GameMechanics.DrawResolution(result);
           


        }
    }
}
