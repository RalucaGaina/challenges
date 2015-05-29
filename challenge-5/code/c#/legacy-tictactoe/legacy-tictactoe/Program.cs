using System;
using System.IO;

namespace legacytictactoe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            var ticTacToeAppFactory = new TicTacToe.TicTacToeApplicationFactory();
            var ticTacToeApp = ticTacToeAppFactory.BuildApplication();
			try {
                ticTacToeApp.StartGame();
			} catch (IOException exc){
				Console.WriteLine (exc.StackTrace);
			}
		}
	}
}
