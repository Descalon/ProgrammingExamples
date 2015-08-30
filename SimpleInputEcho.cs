using System;
using static System.Console;

public class SimpleInputEcho{
	public static void Main(){
		WriteLine("What's your name?");
		Write("Write your name here: ");
		var name = ReadLine();
		WriteLine($"Hello, {name}");
	}
}