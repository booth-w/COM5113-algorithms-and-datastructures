using System;

public class LinkedQueue<T> {
	private LinkedList<T> _list;

	public void Enqueue(T data, bool toBack = false) {
		_list.PushFront(data, toBack);
	}

	public void Dequeue() {
		_list.PopFront();
	}

	public LinkedList<T> Peek() {
		return _list.GetFront();
	}

	public int Length() {
		return _list.Count();
	}

	public void Clear() {
		_list = new LinkedList<T>();
	}
}
