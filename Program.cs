using System;
using System.Numerics;

Console.Write("Ingrese su nombre: ");
var nombre = Console.ReadLine();
Console.WriteLine($"Hola, {nombre}! Bienvenido a C# 14.0 en .NET 10.0.");


//Console.WriteLine("Hola Mundo!!");

//// Función para calcular el factorial de un número
//BigInteger Factorial(int n)
//{
//    if (n < 0) throw new ArgumentException("El factorial no está definido para números negativos.", nameof(n));
//    BigInteger result = 1;
//    for (int i = 2; i <= n; i++)
//        result *= i;
//    return result;
//}

//Console.Write("Introduce un entero no negativo: ");
//if (int.TryParse(Console.ReadLine(), out int n))
//{
//    try
//    {
//        BigInteger f = Factorial(n);
//        Console.WriteLine($"{n}! = {f}");
//    }
//    catch (ArgumentException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}
//else
//{
//    Console.WriteLine("Entrada no válida.");
//}

