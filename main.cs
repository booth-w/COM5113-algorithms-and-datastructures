using System;

class Program {
	static void Main(string[] args) {
		#if DEBUG
			Test();
		#endif
	}

	static void Test() {
		Test test = new Test();
		test.Init();

		test.PushFront();
		test.PushBack();
		test.PopFront();
		test.Count();
		test.RemoveFirst();
	}
}
