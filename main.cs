using System;

class Program {
	static void Main(string[] args) {
		LinkedList<int> list = new LinkedList<int>();

		Test test = new Test();
		test.Init();

		test.PushFront();
		test.PopFront();
		test.Count();
		test.RemoveFirst();
		test.PushSorted();
	}
}
