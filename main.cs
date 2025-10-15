using System;

class Program {
	static void Main(string[] args) {
		LinkedList list = new LinkedList();

		list.pushFront(1);
		list.pushFront(2);
		list.pushFront(3);
		list.printList();

		list.popFront();
		list.printList();
		Console.WriteLine(list.contains(2));
		Console.WriteLine(list.contains(3));
	}
}
