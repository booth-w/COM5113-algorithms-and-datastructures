using System;

public class Element {
	private Element? _next;
	public Element? Next {
		get { return _next; }
		set { _next = value; }
	}

	public Element(int data) {
		_data = data;
	}

	private int _data;
	public int Data {
		get { return _data; }
	}
}
