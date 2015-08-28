using System;

public class SimpleInputEcho{
	public static void Main(){
		Console.WriteLine("What's your name?");
		Console.Write("Write your name here: ");
		var name = Console.ReadLine();
		Console.WriteLine($"Hello, {name}");
	}
}