Console.WriteLine("Ingrese el primer numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicación");
Console.WriteLine("4 - División");

Console.WriteLine("Introduce una opción: ");
string opcion = Console.ReadLine();

double resultado = 0;

switch (opcion)
{
    case "1":
        Console.WriteLine("Suma");
        resultado = num1 + num2;
        break;
    case "2":
        Console.WriteLine("Resta");
        resultado = num1 - num2;
        break;
    case "3":
        Console.WriteLine("Multiplicación");
        resultado = num1 * num2;
        break;
    case "4" when num2 != 0:
        Console.WriteLine("División");
        resultado = num1 / num2;
        break;
    default:
        Console.WriteLine("Opción incorrecta");
        break;
}

Console.WriteLine($"El resultado es: {resultado}");
