using System;
using System.Linq;

class Program {
	static bool gameOver;

	struct Grid {
		public char[,] grid;
		public int rows;
		public int cols;
		public char gridChar;
	}

	struct Player {
		public int x;
		public int y;
		public char playerChar;
	}

	static void Main(string[] args) {
		(Grid grid, Player player) = Init();

		while (!gameOver) {
			(grid, player) = GameLoop(grid, player);
		}

		// exit with a new line
		Console.WriteLine();
	}

	static (Grid, Player) Init() {
		Grid grid = new Grid();
		grid.rows = 15;
		grid.cols = 15;
		grid.grid = new char[grid.rows, grid.cols];
		grid.gridChar = '.';

		Player player = new Player();
		player.x = grid.rows / 2;
		player.y = grid.cols / 2;
		player.playerChar = 'P';

		gameOver = false;


		// fill grid with gridChar
		for (int row = 0; row < grid.rows; row++) {
			for (int col = 0; col < grid.cols; col++) {
				grid.grid[row, col] = grid.gridChar;
			}
		}
		grid.grid[player.x, player.y] = player.playerChar;

		return (grid, player);
	}

	static (Grid, Player) GameLoop(Grid grid, Player player) {
		Console.Clear();
		PrintRoom(grid);
		(grid, player) = MovePlayer(grid, player);
		return (grid, player);
	}

	static void PrintRoom(Grid grid) {
		int rows = grid.grid.GetLength(0);
		int cols = grid.grid.GetLength(1);

		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++) {
				Console.Write(grid.grid[row, col]);
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

	static (Grid, Player) MovePlayer(Grid grid, Player player) {
		char input = GetUserKey("Move: wasd\nQuit: q\n", new char[] {'w', 'a', 's', 'd', 'q'});
		int newX = player.x;
		int newY = player.y;

		switch (input) {
			case 'q':
				gameOver = true;
				break;
			case 'w':
				newY--;
				break;
			case 'a':
				newX--;
				break;
			case 's':
				newY++;
				break;
			case 'd':
				newX++;
				break;
		}

		if (newX >= 0 && newX < grid.rows && newY >= 0 && newY < grid.cols) {
			// move player
			grid.grid[player.y, player.x] = grid.gridChar;
			player.x = newX;
			player.y = newY;
			grid.grid[player.y, player.x] = player.playerChar;
		}

		return (grid, player);
	}
}
