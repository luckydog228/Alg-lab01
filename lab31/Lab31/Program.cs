﻿using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Минимальные и максимальные значения для предопределенных типов данных CTS:");

        Console.WriteLine($"bool: {false}, {true}");
        Console.WriteLine($"byte: {byte.MinValue}, {byte.MaxValue}");
        Console.WriteLine($"sbyte: {sbyte.MinValue}, {sbyte.MaxValue}");
        Console.WriteLine($"short: {short.MinValue}, {short.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue}, {ushort.MaxValue}");
        Console.WriteLine($"int: {int.MinValue}, {int.MaxValue}");
        Console.WriteLine($"uint: {uint.MinValue}, {uint.MaxValue}");
        Console.WriteLine($"long: {long.MinValue}, {long.MaxValue}");
        Console.WriteLine($"ulong: {ulong.MinValue}, {ulong.MaxValue}");
        Console.WriteLine($"float: {float.MinValue}, {float.MaxValue}");
        Console.WriteLine($"double: {double.MinValue}, {double.MaxValue}");
        Console.WriteLine($"decimal: {decimal.MinValue}, {decimal.MaxValue}");
        Console.WriteLine($"char: {char.MinValue}, {char.MaxValue}");

        Console.ReadLine();
    }
}