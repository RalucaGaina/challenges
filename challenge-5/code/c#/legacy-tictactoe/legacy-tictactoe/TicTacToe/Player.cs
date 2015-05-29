using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace legacytictactoe.TicTacToe
{
    internal class Player
    {
        internal string Name { get; set; }

        internal char Signature { get; set; }

        internal bool IsTheWinner(char[] playersChoices)
        {
            return IsWinnerOnLines(playersChoices) || IsWinnerOnColumns(playersChoices) || IsWinnerOnDiagonals(playersChoices);
        }

        private bool IsWinnerOnLines(char[] playersChoices)
        {
            var lines = playersChoices.Where((player, index) => index == 1 || index == 2 || index == 3).Where(p => p == Signature).Count() == 3 ||
                 playersChoices.Where((player, index) => index == 4 || index == 5 || index == 6).Where(p => p == Signature).Count() == 3 ||
                 playersChoices.Where((player, index) => index == 7 || index == 8 || index == 9).Where(p => p == Signature).Count() == 3;
            return lines;
        }

        private bool IsWinnerOnColumns(char[] playersChoices)
        {
            var columns = playersChoices.Where((player, index) => index == 1 || index == 4 || index == 7).Where(p => p == Signature).Count() == 3 ||
                 playersChoices.Where((player, index) => index == 2 || index == 5 || index == 8).Where(p => p == Signature).Count() == 3 ||
                 playersChoices.Where((player, index) => index == 3 || index == 6 || index == 9).Where(p => p == Signature).Count() == 3;
            return columns;
        }

        private bool IsWinnerOnDiagonals(char[] playersChoices)
        {
            var diagonal = playersChoices.Where((player, index) => index == 1 || index == 5 || index == 9).Where(p => p == Signature).Count() == 3 ||
                 playersChoices.Where((player, index) => index == 3 || index == 5 || index == 7).Where(p => p == Signature).Count() == 3;
            return diagonal;
        }
            

        internal void Display()
        {
            Console.WriteLine(string.Format("\nthe winner is : {0}\n", Name));
        }

    }
}
