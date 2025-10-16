using System;

public class LinkedList {
	private Element? _head;

	public LinkedList() {
		_head = null;
	}

	public int Count() {
		int count = 0;
		Element? current = _head;

		while (current != null) {
			count++;
			current = current.Next;
		}

		return count;
	}

	public void PushFront(int data) {
		Element newElement = new Element(data);
		newElement.Next = _head;
		_head = newElement;
	}

	public void PopFront() {
		Element? oldHead = _head;
		if (oldHead != null) {
			_head = oldHead.Next;
		}
	}

	public bool GetFront(ref int data) {
		bool listNotEmpty = _head != null;
		if (listNotEmpty) {
			data = _head.Data;
		} else {
			Console.WriteLine("Cannot get front of an empty list");
		}

		return listNotEmpty;
	}

	public bool Contains(int data) {
		Element? current = _head;

		while (current != null) {
			if (current.Data == data) {
				return true;
			}
			current = current.Next;
		}

		return false;
	}

	public string PrintList() {
		Element? current = _head;

		string toPrint = "";
		while (current != null) {
			toPrint += current.Data + ", ";
			current = current.Next;
		}

		// remove last ", "
		if (toPrint.Length >= 2) {
			toPrint = toPrint[..^2];
		}

		return toPrint;
	}
}
