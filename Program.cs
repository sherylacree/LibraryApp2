using MathLib;
using StringLib;
using System.Numerics;
using System.Security.Cryptography;


namespace LibraryApp2;

internal class Program {
    static void Main(string[] args) {

        var nbr = 5;
        var Fact = MathLib.Math.Fact(5);
        Console.WriteLine($"Factorial of {nbr} is {Fact}");

        var a = 17;
        var b = 2;
        var Mod = MathLib.Math.Mod(17, 2);
        Console.WriteLine($"Modulo of {a} and {b} is {Mod}");

        var c = 12;
        var d = 3;
        var Div = MathLib.Math.Div(12, 3);
        Console.WriteLine($"{ c}  {d} is {Div} ");

       var e = 5;   
        var f = 6;
        var X = MathLib.Math.X(6, 7);
        Console.WriteLine($" {e} multiplied by {f} equals {X}");

        var g = 9;
        var Square = MathLib.Math.Square(9);
        Console.WriteLine($"The Square of {g} is {Square}");

        var h = 12;
        var i = 8;        
        var Sub = MathLib.Math.Sub(12, 8);
        Console.WriteLine($" {h} minus {i}{Sub}");

        var sl = new StringLibrary();
        var newStr = sl.Concat("Hello", "World!");                
        Console.WriteLine(newStr);

        var j = 11;
        var k = 22;
        var Add = MathLib.Math.Add(11, 22);
        Console.WriteLine($" { j} plus {k} equals {Add}");

        var converted = sl.ToUpperEveryOther("a1B2Cd4eF6G7)");
        Console.WriteLine(converted);
    }
   
}
