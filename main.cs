using System;

class Program {
	static void Main(string[] args) {
		#if DEBUG
			Test();
		#endif

		FCC game = new FCC();
		game.GameLoop();
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
