using System;
using System.Diagnostics;

static partial class Test {
	static public void Init() {
		Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
	}

	static public void Run() {
		PushFront();
		PushBack();
		PushSorted();
		PopFront();
		Count();
		RemoveFirst();
	}
}
