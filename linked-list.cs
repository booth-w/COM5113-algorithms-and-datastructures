using System;

public class LinkedList<T> {
	private Element<T>? _head;

	public LinkedList() {
		_head = null;
	}

	public int Count() {
		int count = 0;
		Element<T>? current = _head;

		while (current != null) {
			count++;
			current = current.Next;
		}

		return count;
	}

	public void PushFront(T data, bool toBack = false) {
		Element<T> newElement = new Element<T>(data);

		if (!toBack) {
			newElement.Next = _head;
			_head = newElement;
		} else {
			if (_head == null) {
				_head = newElement;
			} else {
				Element<T>? current = _head;
				while (current.Next != null) {
					current = current.Next;
				}
				current.Next = newElement;
			}
		}
	}

	public void PushBack(T data) {
		PushFront(data, true);
	}

	public void PopFront() {
		Element<T>? oldHead = _head;
		if (oldHead != null) {
			_head = oldHead.Next;
		}
	}

	public bool GetFront(ref T data) {
		bool listNotEmpty = _head != null;
		if (listNotEmpty) {
			data = _head.Data;
		} else {
			Console.WriteLine("Cannot get front of an empty list");
		}

		return listNotEmpty;
	}

	public void RemoveFirst(T data) {
		if (_head == null) {
			return;
		}

		if (_head.Data.Equals(data)) {
			_head = _head.Next;
			return;
		}

		Element<T>? current = _head;
		while (current.Next != null) {
			if (current.Next.Data.Equals(data)) {
				current.Next = current.Next.Next;
				return;
			}
			current = current.Next;
		}
	}

	public bool Contains(T data) {
		Element<T>? current = _head;

		while (current != null) {
			if (current.Data.Equals(data)) {
				return true;
			}
			current = current.Next;
		}

		return false;
	}

	public void Copy(Element<T>? newList) {
		// TODO
		if (_head == null) {
			return;
		}

		Element<T>? current = _head;
		while (current != null) {

		}
	}

	public string PrintList() {
		Element<T>? current = _head;

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

	private Element RoutineA(int val, Element list) {
		if (list == null) {
			return new Element(val);
		} else if (list.Data >= val) {
			Element newElem = new Element(val);
			newElem.Next = list;
			return newElem;
		} else {
			list.Next = RoutineA(val, list.Next);
			return list;
		}
	}

	private Element RoutineB(int val, Element list) {
		if (list == null) {
			return null;
		} else if (list.Data == val) {
			return list.Next;
		} else {
			List.Next = RoutineB(val, list.Next);
			return list;
		}
	}

	private Element RoutineC(int val, Element list) {
		if (list == null) {
			return null;
		} else if (list.Data == val) {
			return RoutineC(val, list.Next);
		} else {
			List.Next = RoutineC(val, list.Next);
			return list;
		}
	}
}
