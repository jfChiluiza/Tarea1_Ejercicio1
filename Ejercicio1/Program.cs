using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Números pares (sin "if")
        Console.WriteLine("1. Números pares (sin 'if'):");
        for (int i = 0; i <= 100; i += 2) Console.WriteLine(i);

        // 2. Números pares (con "if")
        Console.WriteLine("\n2. Números pares:");
        for (int i = 0; i <= 100; i++) if (i % 2 == 0) Console.WriteLine(i);

        // 3. FizzBuzz
        Console.WriteLine("\n3. FizzBuzz:");
        for (int i = 1; i <= 50; i++)
            Console.WriteLine(i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());

        // 4. Números del 1 al 10 (while)
        Console.WriteLine("\n4. Números del 1 al 10:");
        int n = 1;
        while (n <= 10) Console.WriteLine(n++);

        // 5. Suma de los primeros 100 números
        Console.WriteLine("\n5. Suma de los primeros 100 números:");
        int suma = 0, contador = 1;
        while (contador <= 100) suma += contador++;
        Console.WriteLine(suma);

        // 6. Números pares (while)
        Console.WriteLine("\n6. Números pares (while):");
        int num = 0;
        while (num <= 100) { Console.WriteLine(num); num += 2; }
    }
}
