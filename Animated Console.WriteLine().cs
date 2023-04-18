using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        AnimatedWriteLine("Hello World!", 50); // Text to animate
    }

    static void AnimatedWriteLine(string text, int speed)
    {
        Console.ForegroundColor = ConsoleColor.Green; // Set the text color
        int originalLeft = Console.CursorLeft; // Save the original cursor position
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Console.Beep(1000 + i * 50, 50); // Add a frequency change to the sound effect
            Thread.Sleep(speed);
            Console.ForegroundColor = Console.ForegroundColor == ConsoleColor.Green ? ConsoleColor.Yellow : ConsoleColor.Green; // Gradient effect
        }
        Console.CursorLeft = originalLeft; // Return to the original cursor position
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(" ");
            Console.Beep(1000 - i * 20, 50); // Add a frequency change to the sound effect
            Thread.Sleep(speed);
        }
        Console.CursorLeft = originalLeft; // Return to the original cursor position
        Console.ResetColor(); // Restore the console color
        Thread.Sleep(500); // Delay before writing the complete message
        Console.WriteLine(text); // Write the complete message
    }
}