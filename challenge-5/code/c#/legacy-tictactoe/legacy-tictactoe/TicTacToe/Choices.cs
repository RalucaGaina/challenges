using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace legacytictactoe.TicTacToe
{
    internal class Choices
    {
        private char[] choices {set; get;}

        internal Choices()
        {
            choices = new char[10]; 
        }
       
        internal string GetPlayerChoice(Player player)
        {
            Console.Write(string.Format("{0}:", player.Name));
            return Console.ReadLine();        
        }
     
        internal void SetPlayerChoice(Player player, string playerChoice)
        {
            var selectedPosition = int.Parse(playerChoice);
            choices[selectedPosition] = player.Signature;
        }           

        internal void Display(List<Player> players)
        {
            DisplayWinner(players);
            DisplayResultTable();
        }
        
        private void DisplayWinner(List<Player> players)
        {
            players.ForEach(player =>
            {
                if (player.IsTheWinner(choices))
                    player.Display();
            });
        }

        private void DisplayResultTable()
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(choices[i]);
                if (i % 3 == 0)
                    Console.Write("\n");
            }
        }

    }
}
