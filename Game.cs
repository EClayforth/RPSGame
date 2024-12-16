using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    internal class Game
    { public static void Round(Player player1) {

            Dialog.RPSSelection();

            player1.Choice = GameMechanics.Pchoice();

            var cchoice = GameMechanics.Cchoice();
            
            Dialog.OMove(GameMechanics.CMove(cchoice));
            System.Threading.Thread.Sleep(700);

            var result = GameMechanics.GameResult(player1.Choice, cchoice);
            System.Threading.Thread.Sleep(700);

            GameMechanics.ResolveGame(result);
            System.Threading.Thread.Sleep(700);

            GameMechanics.DrawResolution(result, player1
                );
           


        }
    }
}
