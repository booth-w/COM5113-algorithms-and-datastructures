using System;

public class LinkedList {
	private Element? _head;

	public LinkedList() {
		_head = null;
	}

	public void pushFront(int data) {
		Element newElement = new Element(data);
		newElement.Next = _head;
		_head = newElement;
	}

	public void popFront() {
		Element? oldHead = _head;
		if (oldHead != null) {
			_head = oldHead.Next;
		}
	}

	public bool getFront(ref int data) {
		bool listNotEmpty = _head != null;
		if (listNotEmpty) {
			data = _head.Data;
		} else {
			Console.WriteLine("Cannot get front of an empty list");
		}

		return listNotEmpty;
	}

	public bool contains(int data) {
		Element? current = _head;

		while (current != null) {
			if (current.Data == data) {
				return true;
			}
			current = current.Next;
		}

		return false;
	}

	public void printList() {
		Element? current = _head;

		while (current != null) {
			Console.Write(current.Data + ", ");
			current = current.Next;
		}
		Console.WriteLine("\b\b ");
	}
}
