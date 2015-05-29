using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace legacytictactoe.TicTacToe
{
    internal class PlayerFactory
    {
        internal List<Player> BuildPlayers()
        {
            return new List<Player>{
                new Player{
                    Name = "player A",
                    Signature = 'x'
                },
                new Player {
                    Name="player B",
                    Signature = 'o'
                }
            };
        }
    }
}
