using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace legacytictactoe.TicTacToe
{
    public class TicTacToeApplicationFactory
    {
        public TicTacToeApplication BuildApplication()
        {
            var playersFactory = new PlayerFactory();
            var players = playersFactory.BuildPlayers();
            var choices = new Choices();
            return new TicTacToeApplication(players, choices);
        }
    }
}
