using System;

class Program {
	static void Main(string[] args) {
		#if DEBUG
			Test.Init();
			Test.Run();
		#endif
	}
}
