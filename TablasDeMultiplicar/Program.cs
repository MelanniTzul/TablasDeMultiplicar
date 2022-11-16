/*Realizar un programa que muestre las tablas de multiplicar con parámetros ingresados ejemplo:
5 , 7
deberá mostrar las tablas del 5 6 y 7.*/

// DO WHILE
int numero;//Variable para las opciones 
int num1, num2; //rangos
do
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("-----------------------");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("TABLAS DE MULTIPLICAR ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("1 . Operar tablas:  ");
    Console.WriteLine("0 . Salir");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Ingrese la opcion que desea: ");
    numero =Convert.ToInt32(Console.ReadLine());//Almacenamos la opcion
    
    if (numero == 1)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine("Ingrese el rango 1");//Pedimos rango 1
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Ingrese el rango 2");//Pedimos rango 2
        num2 = Convert.ToInt32(Console.ReadLine());
        
        //Verifico  que numero es mayor para asi poder recorrerlo correctamente
        if (num1 < num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine(i + " * 1 = " + (i * 1));
                Console.WriteLine(i + " * 2 = " + (i * 2));
                Console.WriteLine(i + " * 3 = " + (i * 3));
                Console.WriteLine(i + " * 4 = " + (i * 4));
                Console.WriteLine(i + " * 5 = " + (i * 5));
                Console.WriteLine(i + " * 6 = " + (i * 6));
                Console.WriteLine(i + " * 7 = " + (i * 7));
                Console.WriteLine(i + " * 8 = " + (i * 8));
                Console.WriteLine(i + " * 9 = " + (i * 9));
                Console.WriteLine(i + " * 10 = " + (i * 10));
                Console.WriteLine(i + " * 11 = " + (i * 11));
                Console.WriteLine(i + " * 12 = " + (i * 12));
                Console.WriteLine();

            }

        }
        else if (num1 > num2)//Si nos ingresan el rango del mayor al menor
        {
            for (int j = num2; j <= num1; j++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine(j + " * 1 = " + (j * 1));
                Console.WriteLine(j + " * 2 = " + (j * 2));
                Console.WriteLine(j + " * 3 = " + (j * 3));
                Console.WriteLine(j + " * 4 = " + (j * 4));
                Console.WriteLine(j + " * 5 = " + (j * 5));
                Console.WriteLine(j + " * 6 = " + (j * 6));
                Console.WriteLine(j + " * 7 = " + (j * 7));
                Console.WriteLine(j + " * 8 = " + (j * 8));
                Console.WriteLine(j + " * 9 = " + (j * 9));
                Console.WriteLine(j + " * 10 = " + (j * 10));
                Console.WriteLine(j + " * 11 = " + (j * 11));
                Console.WriteLine(j + " * 12 = " + (j * 12));
                Console.WriteLine();
            }

        }

    }else if (numero == 0)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("El programa a finalizado ");
    }
} while (numero!=0);
 








