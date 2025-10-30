using System;
using System.Diagnostics;

class Test {
	public void Init() {
		Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
	}

	public void PushFront() {
		LinkedList<int> list = new LinkedList<int>();
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

	public void PushBack() {
		LinkedList<int> list = new LinkedList<int>();
		string output;

		Debug.WriteLine("push back to empty");
		list.PushBack(1);
		output = list.PrintList();
		Debug.Assert(output == "1", $"push back to empty. found: {output}, expected: 1");

		Debug.WriteLine("push back to non-empty");
		list.PushBack(2);
		output = list.PrintList();
		Debug.Assert(output == "1, 2", $"push back to non-empty. found: {output}, expected: 1, 2");
	}

	public void PopFront() {
		LinkedList<int> list = new LinkedList<int>();
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
		LinkedList<int> list = new LinkedList<int>();
		int output;

		Debug.WriteLine("count empty");
		output = list.Count();
		Debug.Assert(output == 0, $"count 0. found: {output}, expected: 0");

		Debug.WriteLine("count 1");
		list.PushFront(1);
		output = list.Count();
		Debug.Assert(output == 1, $"count 1. found: {output}, expected: 1");

		Debug.WriteLine("count 3");
		list.PushFront(2);
		list.PushFront(3);
		output = list.Count();
		Debug.Assert(output == 3, $"count 3. found: {output}, expected: 3");
	}

	public void RemoveFirst() {
		LinkedList<int> list = new LinkedList<int>();
		string output;

		Debug.WriteLine("remove first empty");
		list.RemoveFirst(1);
		output = list.PrintList();
		Debug.Assert(output == "", $"remove empty. found: {output}, expected: empty string");

		Debug.WriteLine("remove first does not exist");
		list.PushFront(1);
		list.PushFront(2);
		list.PushFront(3);
		list.PushFront(4);
		list.RemoveFirst(5);
		output = list.PrintList();
		Debug.Assert(output == "4, 3, 2, 1", $"remove first does not exist. found: {output}, expected: 4, 3, 2, 1");

		Debug.WriteLine("remove first middle");
		list.RemoveFirst(2);
		output = list.PrintList();
		Debug.Assert(output == "4, 3, 1", $"remove first middle. found: {output}, expected: 4, 3, 1");

		Debug.WriteLine("remove first head");
		list.RemoveFirst(4);
		output = list.PrintList();
		Debug.Assert(output == "3, 1", $"remove first head. found: {output}, expected: 3, 1");

		Debug.WriteLine("remove first tail");
		list.RemoveFirst(1);
		output = list.PrintList();
		Debug.Assert(output == "3", $"remove first tail. found: {output}, expected: 3");

		Debug.WriteLine("remove first last");
		list.RemoveFirst(3);
		output = list.PrintList();
		Debug.Assert(output == "", $"remove first last. found: {output}, expected: empty string");
	}
}
