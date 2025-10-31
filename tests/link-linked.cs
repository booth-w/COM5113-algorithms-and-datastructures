using System;
using System.Diagnostics;

static partial class Test {
	static void PushFront() {
		GenerateTest("push front to empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			return list.PrintList();
		}, "1");

		GenerateTest("push front to non-empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PushFront(2);
			return list.PrintList();
		}, "2, 1");
	}

	static void PushBack() {
		GenerateTest("push back to empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushBack(1);
			return list.PrintList();
		}, "1");

		GenerateTest("push back to non-empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushBack(1);
			list.PushBack(2);
			return list.PrintList();
		}, "1, 2");
	}

	static void PushSorted() {
		GenerateTest("push sorted to empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushSorted(2);
			return list.PrintList();
		}, "2");

		GenerateTest("push sorted to front", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushSorted(2);
			list.PushSorted(1);
			return list.PrintList();
		}, "1, 2");

		GenerateTest("push sorted to back", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushSorted(1);
			list.PushSorted(2);
			list.PushSorted(4);
			return list.PrintList();
		}, "1, 2, 4");

		GenerateTest("push sorted to middle", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushSorted(1);
			list.PushSorted(2);
			list.PushSorted(4);
			list.PushSorted(3);
			return list.PrintList();
		}, "1, 2, 3, 4");
	}

	static void PopFront() {
		GenerateTest("pop front from empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PopFront();
			return list.PrintList();
		}, "");

		GenerateTest("pop front from non-empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PushFront(2);
			list.PopFront();
			return list.PrintList();
		}, "1");

		GenerateTest("pop front last element", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PopFront();
			return list.PrintList();
		}, "");
	}

	}

	static void RemoveFirst() {
		GenerateTest("remove first from empty", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.RemoveFirst(1);
			return list.PrintList();
		}, "");

		GenerateTest("remove first does not exist", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PushFront(2);
			list.PushFront(3);
			list.RemoveFirst(4);
			return list.PrintList();
		}, "3, 2, 1");

		GenerateTest("remove first only element", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.RemoveFirst(1);
			return list.PrintList();
		}, "");

		GenerateTest("remove first middle", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PushFront(2);
			list.PushFront(3);
			list.RemoveFirst(2);
			return list.PrintList();
		}, "3, 1");

		GenerateTest("remove first head", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PushFront(2);
			list.PushFront(3);
			list.RemoveFirst(3);
			return list.PrintList();
		}, "2, 1");

		GenerateTest("remove first tail", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PushFront(2);
			list.PushFront(3);
			list.RemoveFirst(1);
			return list.PrintList();
		}, "3, 2");

		GenerateTest("remove first multiple", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(2);
			list.PushFront(1);
			list.PushFront(2);
			list.PushFront(3);
			list.RemoveFirst(2);
			return list.PrintList();
		}, "3, 1, 2");

		GenerateTest("remove first last", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.RemoveFirst(1);
			return list.PrintList();
		}, "");
	}

	static void Count() {
		GenerateTest("count 0", () => {
			LinkedList<int> list = new LinkedList<int>();
			return list.Count();
		}, 0);

		GenerateTest("count 1", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			return list.Count();
		}, 1);

		GenerateTest("count 3", () => {
			LinkedList<int> list = new LinkedList<int>();
			list.PushFront(1);
			list.PushFront(2);
			list.PushFront(3);
			return list.Count();
		}, 3);
	}
}
