using System;

class Program {
	static void Main(string[] args) {
		LinkedList list = new LinkedList();

		Test test = new Test();
		test.Init();

		test.PushFront();
		test.PopFront();
		test.count();
	}
}
