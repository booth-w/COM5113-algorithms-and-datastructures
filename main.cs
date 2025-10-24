using System;

class Program {
	static void Main(string[] args) {
		#if DEBUG
			Test();
		#endif

		bool isPlaying = true;
		while (isPlaying) {
			FCC game = new FCC();
			game.GameLoop();
			isPlaying = game.PlayAgain();
		}

		Console.WriteLine();
	}

	static void Test() {
		Test test = new Test();
		test.Init();

		test.PushFront();
		test.PopFront();
		test.Count();
		test.RemoveFirst();
		// test.PushSorted();
	}
}
