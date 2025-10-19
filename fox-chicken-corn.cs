using System;
using System.Linq;

public class FCC {
	private enum Item {
		Fox,
		Chicken,
		Corn
	}

	private LinkedList<Item> _northItems = new LinkedList<Item>();
	private LinkedList<Item> _southItems = new LinkedList<Item>();

	private enum Bank {
		North,
		South
	}
	private Bank _farmerPos;

	public FCC() {
		_northItems.PushFront(Item.Corn);
		_northItems.PushFront(Item.Chicken);
		_northItems.PushFront(Item.Fox);
		_farmerPos = Bank.North;
	}

	public void GameLoop() {
		while (!isWon() && !isLost()) {
			Console.Clear();
			DisplayInstructions();
			DisplayBanks();
			char choice = GetUserKey("Choose an item to take:\nf: fox\nc: chicken\no: corn\nn: nothing\n", new char[] { 'f', 'c', 'o', 'n' });
		}
	}

	public void DisplayInstructions() {
		Console.WriteLine("The farmer can only carry one item with them on the boat at a time");
		Console.WriteLine("The fox cannot be left alone with the chicken");
		Console.WriteLine("The chicken cannot be left alone with the corn");
		Console.WriteLine("Bring all the items to the other side\n");
	}

	public void DisplayBanks() {
		Console.WriteLine($"North Bank: {_northItems.PrintList()}");
		Console.WriteLine($"South Bank: {_southItems.PrintList()}");
		Console.WriteLine($"Farmer: {_farmerPos}");
	}

	public bool isWon() {
		foreach (Item item in Enum.GetValues(typeof(Item))) {
			if (!_southItems.Contains(item)) {
				return false;
			}
		}
		return true;
	}

	public bool isLost() {
		return false;
	}

	private char GetUserKey(string prompt, char[] validKeys) {
		Console.Write(prompt);

		// place cursor between brackets
		Console.Write("[ ]");
		Console.SetCursorPosition(1, Console.CursorTop);

		char input = Console.ReadKey(true).KeyChar;

		// validate input
		if (validKeys.Contains(input)) {
			return input;
		} else {
			Console.WriteLine("\n\nInvalid input");
			return GetUserKey(prompt, validKeys);
		}
	}
}
