Console.WriteLine("Ejercicio 1");
byte edad;
Console.Write("¿Cuál es su edad?: ");
edad = Convert.ToByte(Console.ReadLine());
Console.WriteLine("No aparentas {0} años",edad);
Console.Write("Presione enter para continuar");
Console.ReadKey();

Console.WriteLine("\nEjercicio 2");
byte numero1, numero2;
ushort resultado;
Console.WriteLine("Ingrese 2 numeros de 2 crifas");
Console.Write("Primer número: ");
numero1 = Convert.ToByte(Console.ReadLine());
Console.Write("Segundo número: ");
numero2 = Convert.ToByte(Console.ReadLine());
resultado = (ushort)(Convert.ToInt16(numero1) * Convert.ToInt16(numero2));
Console.WriteLine("El resultado de la multipicación es: "+resultado);
Console.Write("Presione enter para continuar");
Console.ReadKey();

Console.WriteLine("\nEjercicio 3");
long num1, num2, suma, resta, producto;
Console.Write("Ingresa un número entero largo: ");
num1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Ingresa otro número entero largo: ");
num2 = Convert.ToInt64(Console.ReadLine());
suma = num1 + num2;
resta = num1 - num2;
producto = num1 * num2;
Console.WriteLine("La suma de los números es : "+suma);
Console.WriteLine("La resta de los números es : "+resta);
Console.WriteLine("El producto de los números es : "+producto);



