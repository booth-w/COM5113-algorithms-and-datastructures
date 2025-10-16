using System;
using System.Diagnostics;

class Test {
	public void Init() {
		Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
	}

	public void PushFront() {
		LinkedList list = new LinkedList();
		string output;

		Debug.WriteLine("push front to empty");
		list.PushFront(1);
		output = list.PrintList();
		Debug.Assert(output == "1", $"push front to empty. found: {output}, expected: 1");

		Debug.WriteLine("push front to non-empty");
		list.PushFront(2);
		output = list.PrintList();
		Debug.Assert(output == "2, 1", $"push front to non-empty. found: {output}, expected: 2, 1");
	}

	public void PopFront() {
		LinkedList list = new LinkedList();
		string output;

		Debug.WriteLine("pop front from empty");
		list.PopFront();
		output = list.PrintList();
		Debug.Assert(output == "", $"pop front empty. found: {output}, expected: empty string");

		Debug.WriteLine("pop front from non-empty");
		list.PushFront(1);
		list.PushFront(2);
		list.PushFront(3);
		list.PopFront();
		output = list.PrintList();
		Debug.Assert(output == "2, 1", $"pop front. found: {output}, expected: 2, 1");

		Debug.WriteLine("pop front last element");
		list.PopFront();
		list.PopFront();
		output = list.PrintList();
		Debug.Assert(output == "", $"pop front last. found: {output}, expected: empty string");
	}

	public void Count() {
		LinkedList list = new LinkedList();
		int output;

		output = list.Count();
		Debug.Assert(output == 0, $"count 0. found: {output}, expected: 0");

		list.PushFront(1);
		output = list.Count();
		Debug.Assert(output == 1, $"count 1. found: {output}, expected: 1");

		list.PushFront(2);
		list.PushFront(3);
		output = list.Count();
		Debug.Assert(output == 3, $"count 3. found: {output}, expected: 3");
	}
}
