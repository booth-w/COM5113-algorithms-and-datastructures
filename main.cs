using System;
using System.Linq;

class Program {
	static char[,] grid;
	static bool gameOver;
	static char playerChar;
	static char gridChar;

	static void Main(string[] args) {
		Init();

		while (!gameOver) {
			GameLoop();
		}

		// exit with a new line
		Console.WriteLine();
	}

	static void Init() {
		const int rows = 15;
		const int cols = 15;
		gridChar = '.';

		// centre player
		const int playerPosX = rows/2;
		const int playerPosY = cols/2;
		playerChar = 'P';

		gameOver = false;

		grid = new char[rows, cols];

		// fill grid with gridChar
		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++) {
				grid[row, col] = gridChar;
			}
		}
		grid[playerPosX, playerPosY] = playerChar;
	}

	static void GameLoop() {
		Console.Clear();
		PrintRoom();
		char input = GetUserKey("Quit: q\n", new char[] {'q'});
		if (input == 'q') {
			gameOver = true;
		}
	}

	static void PrintRoom() {
		int rows = grid.GetLength(0);
		int cols = grid.GetLength(1);

		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++) {
				Console.Write(grid[row, col]);
			}
			Console.WriteLine();
		}
	}

	static char GetUserKey(string prompt, char[] validKeys) {
		Console.Write(prompt);

		// place cursor between brackets
		Console.Write("[ ]");
		Console.SetCursorPosition(1, Console.CursorTop);

		char input = Console.ReadKey(true).KeyChar;

		// validate input
		if (validKeys.Contains(input)) {
			return input;
		} else {
			Console.WriteLine("\n\nInvalid input");
			return GetUserKey(prompt, validKeys);
		}
	}
}
