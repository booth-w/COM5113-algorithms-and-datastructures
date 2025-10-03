using System;

class Program {
	static void Main(string[] args) {
		const int rows = 10;
		const int cols = 10;
		const int playerPosX = rows/2;
		const int playerPosY = cols/2;
		const char gridChar = '.';
		const char playerChar = '@';

		char[,] grid = new char[rows, cols];

		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++) {
				grid[row, col] = gridChar;
			}
		}
		grid[playerPosX, playerPosY] = playerChar;

		printRoom(grid);
	}

	static void printRoom(char[,] grid) {
		int rows = grid.GetLength(0);
		int cols = grid.GetLength(1);

		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++) {
				Console.Write(grid[row, col]);
			}
			Console.WriteLine();
		}
	}
}
