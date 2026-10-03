using System;
using System.Globalization;

Console.WriteLine("Salario base (ex.: 1500.00): ");
double salario = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
Console.WriteLine("Comissão (%): ");
double percentual = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

if (salario < 0 || percentual < 0) {
    Console.WriteLine("Valores inválidos.");
} else {
    double comissão = salario * percentual / 100;
    Console.WriteLine($"Comissão: R$ {comissão:F2}");
    Console.WriteLine($"Total: R$ {salario + comissão:F2}");
}
