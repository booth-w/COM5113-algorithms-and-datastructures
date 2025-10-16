using System;
using System.Diagnostics;

class Test {
	public void Init() {
		Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
	}

	public void PushFront() {
		LinkedList list = new LinkedList();

		list.PushFront(1);
		list.PushFront(2);
		list.PushFront(3);

		string output = list.PrintList();
		Debug.Assert(output == "3, 2, 1", $"push front found: {output}, expected: 3, 2, 1");
	}

	public void PopFront() {
		LinkedList list = new LinkedList();

		list.PushFront(1);
		list.PushFront(2);
		list.PushFront(3);
		list.PopFront();

		string output = list.PrintList();
		Debug.Assert(output == "2, 1", $"pop front found: {output}, expected: 2, 1");
	}

	public void Count() {
		LinkedList list = new LinkedList();

		int count = list.Count();
		Debug.Assert(count == 0, $"count found: {count}, expected: 0");

		list.PushFront(1);
		count = list.Count();
		Debug.Assert(count == 1, $"count found: {count}, expected: 1");

		list.PushFront(2);
		list.PushFront(3);
		count = list.Count();
		Debug.Assert(count == 3, $"count found: {count}, expected: 3");
	}
}
