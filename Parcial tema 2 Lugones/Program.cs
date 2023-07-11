double area, volumen, altura, Base, lado, arista, contador=0;

do
{
    do
    {
        Console.WriteLine("ingrese el valor de la altura de la piramide cuadrada");
        var str = Console.ReadLine();
        if (double.TryParse(str, out altura))
        {
            break;
        }
        Console.WriteLine("Número no válido");

    } while (true);

    do
    {
        Console.WriteLine("ingrese el valor de la base de la piramide cuadrada");
        var str = Console.ReadLine();
        if (double.TryParse(str, out Base))
        {
            break;
        }
        Console.WriteLine("Número no válido");

    } while (true);

    if (altura < 0 || Base < 0)
    {
        Console.WriteLine("Los Datos no pueden ser inferior a 0 (negativos)");
        break;
    }

    if(altura ==0 && Base == 0)
    {
        break;

    }

    contador++;

    lado = Base / 4;
    area = lado * (lado + Math.Sqrt(4 * Math.Pow(altura, 2) + Math.Pow(lado, 2)));
    volumen = (Math.Pow(lado, 2) * altura) / 3;
    arista = Math.Sqrt(Math.Pow(altura, 2) + (Math.Pow(lado, 2) / 2));

    Console.WriteLine($"el valor volumen de la piramdie cuadrada es: {volumen}");
    Console.WriteLine($"el valor area de la piramide cuadrada es: {area}");
    Console.WriteLine($"el valor arista de la piramide cuadrada es: {arista}");
} while(true);

Console.WriteLine($"se ingresaron {contador} piramides");