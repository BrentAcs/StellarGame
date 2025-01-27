// See https://aka.ms/new-console-template for more information

using System.Text;

// Console.OutputEncoding = Encoding.UTF8;

Console.OutputEncoding = Encoding.Unicode;
// Console.BackgroundColor = ConsoleColor.Gray;
var test = Console.LargestWindowHeight;
// Console.WindowWidth = 80;
// Console.WindowHeight = 40;

var renderer = new ScreenRenderer();

renderer.Clear();
renderer.Render();

// test....
Console.SetCursorPosition(10,10);
// Console.Write("screen renderer done. ");
Console.WriteLine(Console.OutputEncoding);


// Console.WriteLine("Hello, World!");
// Console.WriteLine("\u250F");
Console.ReadKey();
