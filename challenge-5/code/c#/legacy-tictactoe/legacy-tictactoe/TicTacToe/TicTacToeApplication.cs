using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace legacytictactoe.TicTacToe
{
    public class TicTacToeApplication
    {
        private List<Player> players;
        private Choices playerChoice;

        internal TicTacToeApplication(List<Player> players, Choices playerChoice)
        {
            this.players = players;
            this.playerChoice = playerChoice;
        }

        public void StartGame()
        {
            Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            double tirage = random.NextDouble();

            var firstPlayer = tirage < 0.5 ? players.First(p => p.Signature == 'x') : players.First(p => p.Signature == 'o');
            var secondPlayer = players.First(p => p.Signature != firstPlayer.Signature);

            for (var i = 1; i <= 9; i++)
            {
                var currentPlayer = i % 2 != 0 ? firstPlayer : secondPlayer;
                var currentPlayerChoice = playerChoice.GetPlayerChoice(currentPlayer);
                playerChoice.SetPlayerChoice(currentPlayer, currentPlayerChoice);
            }
            
            playerChoice.Display(players);
        }
    }
}
