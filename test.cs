using System;
using System.Diagnostics;

class Test {
	public void Init() {
		Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
	}

	public void PushFront() {
		LinkedList list = new LinkedList();

		list.pushFront(1);
		list.pushFront(2);
		list.pushFront(3);

		string output = list.printList();
		Debug.Assert(output == "3, 2, 1", $"push front found: {output}, expected: 3, 2, 1");
	}

	public void PopFront() {
		LinkedList list = new LinkedList();

		list.pushFront(1);
		list.pushFront(2);
		list.pushFront(3);
		list.popFront();

		string output = list.printList();
		Debug.Assert(output == "2, 1", $"pop front found: {output}, expected: 2, 1");
	}

	public void count() {
		LinkedList list = new LinkedList();

		int count = list.count();
		Debug.Assert(count == 0, $"count found: {count}, expected: 0");

		list.pushFront(1);
		count = list.count();
		Debug.Assert(count == 1, $"count found: {count}, expected: 1");

		list.pushFront(2);
		list.pushFront(3);
		count = list.count();
		Debug.Assert(count == 3, $"count found: {count}, expected: 3");
	}
}
