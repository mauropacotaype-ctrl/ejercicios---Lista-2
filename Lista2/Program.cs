using System;
using System.Collections.Generic;


class Program ()
{
   static void Main()
    {
    Console.WriteLine("Ejercicios de la lista 2");
    Console.WriteLine("Ingrese el numero del ejercicio que desea ejecutar");
    int n = int.Parse(Console.ReadLine()!);

    switch (n)
    {
        case 1:
            new Ejercicio1().Ejercicio();
            break;
        case 2:
            new Ejercicio2().Ejercicio();
            break;
        case 3:
            new Ejercicio3().Ejercicio();
            break;
        case 4:
            new Ejercicio4().Ejercicio();
            break;
        case 5:
            new Ejercicio5().Ejercicio();
            break;
        case 6:
            new Ejercicio6().Ejercicio();
            break;
        case 7:
            new Ejercicio7().Ejercicio();
            break;
        case 8:
            new Ejercicio8().Ejercicio();
            break;
        case 9:
            new Ejercicio9().Ejercicio();
            break;
        case 10:
            new Ejercicio10().Ejercicio();
            break;
        case 11:
            new Ejercicio11().Ejercicio();
            break;
        case 12:
            new Ejercicio12().Ejercicio();
            break;
        case 13:
            new Ejercicio13().Ejercicio();
            break;
        case 14:
            new Ejercicio14().Ejercicio();
            break;
        case 15:
            new Ejercicio15().Ejercicio();
            break;
        case 16:
            new Ejercicio16().Ejercicio();
            break;
        case 17:
            new Ejercicio17().Ejercicio();
            break;
        case 18:
            new Ejercicio18().Ejercicio();
            break;
        case 19:
            new Ejercicio19().Ejercicio();
            break;
        case 20:
            new Ejercicio20().Ejercicio();
            break;
        case 21:
            new Ejercicio21().Ejercicio();
            break;
        case 22:
            new Ejercicio22().Ejercicio();
            break;
        case 23:
            new Ejercicio23().Ejercicio();
            break;
        case 24:
            new Ejercicio24().Ejercicio();
            break;
        case 25:
            new Ejercicio25().Ejercicio();
            break;
        default:
            Console.WriteLine("Ejercicio no encontrado ( 1)");
            break;

    }



}
}


class Ejercicio1
{
    public void Ejercicio()
    {
    Console.WriteLine("Ejercicio 1");
    Console.Write( "introduce un numero entero positivo para calcular sufactorial: " );
    int numero = int.Parse( Console.ReadLine()! );
    int i =1;
    int j =1;
    int factorial = 1;
        if ( numero < 0)
        {
        Console.WriteLine( " valor no calido ( debe ser positivo y entero )" );
        return;
        }
        else{
        for ( i = 1 ; i <= numero ; i++ )
        {
        factorial = 1;
    for ( j= 1 ;j<= i ; j++)
    {
    factorial = factorial*j;
    }
    Console.WriteLine( "el factorial de " + i +" es: " + factorial );
    }
    }
    
       
    }

}
class Ejercicio2
{
    public void Ejercicio()
    {

        Console.WriteLine("Ejercicio 2");
        double numero;
        int numerador;
        int denominador;

        Console.Write("Ingrese la base: ");
        numero = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el numerador: ");
        numerador = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el denominador: ");
        denominador = int.Parse(Console.ReadLine()!);

        double potencia = 1;

        for (int i = 1; i <= numerador; i++)
        {
            potencia = potencia * numero;
        }
        double x = 1; 
        for (int p = 1; p <= 400; p++)
        {
            double aux = 1;
            for (int i = 1; i <= denominador - 1; i++)
            {
                aux = aux * x;
            }
            x = ((denominador - 1) * x + (potencia / aux)) / denominador;
        }
        Console.WriteLine("Resultado aproximado: " + x);

    }

}
class Ejercicio3
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 3");
        int numero = 0;
       for (int i = 1; i <= 100; i++)
       {
        numero += i*i;
       }
       Console.WriteLine($"{numero}");

    }

}   
class Ejercicio4
{       
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 4");
        int n;  
        int cantidadGemelos = 0;
    
    Console.Write("¿Cuántos números desea ingresar?: ");
    n = int.Parse(Console.ReadLine()!);

    for (int i = 1; i <= n; i++)
    {
    Console.Write("Ingrese un número: ");
    string numero = Console.ReadLine()!;

    int longitud = numero.Length;
    int mitad = longitud / 2;

    string primeraMitad, segundaMitad;

    if (longitud % 2 == 0)
    {
        primeraMitad = numero.Substring(0, mitad);
        segundaMitad = numero.Substring(mitad, mitad);
    }
    else
    {
        primeraMitad = numero.Substring(0, mitad);
        segundaMitad = numero.Substring(mitad + 1, mitad);
    }

    if (primeraMitad == segundaMitad)
    {
        cantidadGemelos++;
    }
}

Console.WriteLine("Cantidad de números gemelos: " + cantidadGemelos);
    }

}
class Ejercicio5
{
    public void Ejercicio()
    {



        
        Console.WriteLine("Ejercicio 5");
                Console.WriteLine("Operacion de suma y productos de dos fracciones");
        Console.WriteLine("Fraccion 1:");
        Console.WriteLine("Inserte un numero para el numerador:");
        int A = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserte un numero para el denominador:");
        int B = int.Parse(Console.ReadLine()!);
        if (A < 0 || B <= 0)
        {
            Console.WriteLine("Error: Numerador debe ser mayor o igual a 0 y denominador debe ser mayor a 0.");
            return;
        }
        Console.WriteLine("Fraccion 2:");
        Console.WriteLine("Inserte un numero para el numerador:");
        int C = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserte un numero para el denominador:");
        int D = int.Parse(Console.ReadLine()!);
        double Suma ;
        double Producto ;
    if (A >= 0 && B > 0 && C >= 0 && D > 0)
        {
            Suma = (double)((A * D) + (C * B)) / (B * D);
            Producto = (double)(A * C) / (B * D);
            Console.WriteLine("El resultado de la suma es: " + Suma);
            Console.WriteLine("El resultado del producto es: " + Producto);
        }
        else
        {
            Console.WriteLine("Error: Numeradores deben ser mayores o iguales a 0 y denominadores deben ser mayores a 0."); 





    }

}
}
class Ejercicio6
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 6 ");

while (true)
        {
            Console.WriteLine("Primera fecha");

            Console.Write("Dia: ");
            int d1 = int.Parse(Console.ReadLine()!);

            if (d1 == 0)
            {
                break;
            }

            Console.Write("Mes: ");
            int m1 = int.Parse(Console.ReadLine()!);

            Console.Write("Año: ");
            int a1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Segunda fecha");

            Console.Write("Dia: ");
            int d2 = int.Parse(Console.ReadLine()!);

            Console.Write("Mes: ");
            int m2 = int.Parse(Console.ReadLine()!);

            Console.Write("Año: ");
            int a2 = int.Parse(Console.ReadLine()!);

            if (a1 < a2)
            {
                Console.WriteLine("La primera fecha es anterior");
            }
            else if (a1 > a2)
            {
                Console.WriteLine("La segunda fecha es anterior");
            }
            else
            {
                if (m1 < m2)
                {
                    Console.WriteLine("La primera fecha es anterior");
                }
                else if (m1 > m2)
                {
                    Console.WriteLine("La segunda fecha es anterior");
                }
                else
                {
                    if (d1 < d2)
                    {
                        Console.WriteLine("La primera fecha es anterior");
                    }
                    else if (d1 > d2)
                    {
                        Console.WriteLine("La segunda fecha es anterior");
                    }
                    else
                    {
                        Console.WriteLine("Las fechas son iguales");
                    }
                }
            }

            Console.WriteLine();
        }




    }

}
class Ejercicio7
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 7  ");
        const int MAXINTENTOS = 3;

        int intentos = 0;

        while (intentos < MAXINTENTOS)
        {
            Console.WriteLine("Primera fecha");

            Console.Write("Dia: ");
            int d1 = int.Parse(Console.ReadLine()!);

            if (d1 == 0)
            {
                break;
            }
            Console.Write("Mes: ");
            int m1 = int.Parse(Console.ReadLine()!);

            Console.Write("Año: ");
            int a1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Segunda fecha");

            Console.Write("Dia: ");
            int d2 = int.Parse(Console.ReadLine()!);

            Console.Write("Mes: ");
            int m2 = int.Parse(Console.ReadLine()!);

            Console.Write("Año: ");
            int a2 = int.Parse(Console.ReadLine()!);

            if (a1 < a2)
            {
                Console.WriteLine("La primera fecha es anterior");
            }
            else if (a1 > a2)
            {
                Console.WriteLine("La segunda fecha es anterior");
            }
            else
            {
                if (m1 < m2)
                {
                    Console.WriteLine("La primera fecha es anterior");
                }
                else if (m1 > m2)
                {
                    Console.WriteLine("La segunda fecha es anterior");
                }
                else
                {
                    if (d1 < d2)
                    {
                        Console.WriteLine("La primera fecha es anterior");
                    }
                    else if (d1 > d2)
                    {
                        Console.WriteLine("La segunda fecha es anterior");
                    }
                    else
                    {
                        Console.WriteLine("Las fechas son iguales");
                    }
                }
            }
            intentos++;
            Console.WriteLine("Intentos usados: " + intentos);
            Console.WriteLine();
        }
        if (intentos == MAXINTENTOS)
        {
            Console.WriteLine("Lo siento, ha perdido");
        }


    }

}   
class Ejercicio8
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 8  ");
    const int MAXINTENTOS = 3;

        int intentos = 0;

        while (intentos < MAXINTENTOS)
        {
            Console.WriteLine("Primera fecha");

            Console.Write("Dia: ");
            int d1 = int.Parse(Console.ReadLine()!);

            if (d1 == 0)
            {
                break;
            }
            Console.Write("Mes: ");
            int m1 = int.Parse(Console.ReadLine()!);

            Console.Write("Año: ");
            int a1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Segunda fecha");

            Console.Write("Dia: ");
            int d2 = int.Parse(Console.ReadLine()!);

            Console.Write("Mes: ");
            int m2 = int.Parse(Console.ReadLine()!);

            Console.Write("Año: ");
            int a2 = int.Parse(Console.ReadLine()!);

            if (a1 < a2)
            {
                Console.WriteLine("La primera fecha es anterior");
            }
            else if (a1 > a2)
            {
                Console.WriteLine("La segunda fecha es anterior");
            }
            else
            {
                if (m1 < m2)
                {
                    Console.WriteLine("La primera fecha es anterior");
                }
                else if (m1 > m2)
                {
                    Console.WriteLine("La segunda fecha es anterior");
                }
                else
                {
                    if (d1 < d2)
                    {
                        Console.WriteLine("La primera fecha es anterior");
                    }
                    else if (d1 > d2)
                    {
                        Console.WriteLine("La segunda fecha es anterior");
                    }
                    else
                    {
                        Console.WriteLine("Las fechas son iguales");
                    }
                }
            }
            intentos++;
            Console.WriteLine("Intentos usados: " + intentos);
            Console.WriteLine();
        }
        if (intentos == MAXINTENTOS)
        {
            Console.WriteLine("Lo siento, ha perdido");
        }



    }

}
class Ejercicio9
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 9  ");
                    for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Tabla del " + i);

            for (int j = 1; j <= 10; j++)
            {
                int resultado = i * j;

                Console.WriteLine(i + " x " + j + " = " + resultado);
            }

            Console.WriteLine();
        }



    }

}
class Ejercicio10
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 10");
        Console.Write( "introduce un numero entero positivo para calcular su factorial: " );
            int numero = int.Parse( Console.ReadLine()!);

            if ( numero < 0)
            { 
                Console.WriteLine( " valor no calido ( debe ser positivo y entero )" );
                return;
            }

            else{
            int factorial = 1;
            for ( int i = 1 ; i <= numero ; i++ )
                        {
                            factorial = factorial *i;
                        }
            Console.WriteLine( "el factorial de " + numero + " es: " + factorial );         
                    }

    }

}
class Ejercicio11
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 11");
        Console.Write("Ingrese la cantidad de puntos: ");
        int n = int.Parse(Console.ReadLine()!);

        int contador = 0;

        // Datos de las circunferencias
        double x1 = 5, y1 = 4, r1 = 2;
        double x2 = -5, y2 = -4, r2 = 3;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nPunto {i}:");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine()!);
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine()!);

            // Distancia al cuadrado respecto a cada centro
            double d1 = Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2);
            double d2 = Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2);

            // Dentro o sobre la frontera de alguna circunferencia
            if (d1 <= r1 * r1 || d2 <= r2 * r2)
            {
                contador++;
            }
        }
        Console.WriteLine($"\nCantidad de puntos dentro de las circunferencias: {contador}");
    }

}
class Ejercicio12
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 12");
        Console.Write("Ingrese un número de 4 dígitos: ");
        int numero = int.Parse(Console.ReadLine()!);

        // Separar los dígitos
        int d1 = numero / 1000;
        int d2 = (numero / 100) % 10;
        int d3 = (numero / 10) % 10;
        int d4 = numero % 10;

        // Cifrar cada dígito
        d1 = (d1 + 7) % 10;
        d2 = (d2 + 7) % 10;
        d3 = (d3 + 7) % 10;
        d4 = (d4 + 7) % 10;

        // Intercambiar 1° con 3° y 2° con 4°
        int temp;

        temp = d1;
        d1 = d3;
        d3 = temp;

        temp = d2;
        d2 = d4;
        d4 = temp;

        Console.WriteLine("Número cifrado: {0}{1}{2}{3}", d1, d2, d3, d4);

    }

}
class Ejercicio13
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 13");
        Console.WriteLine ("la Suma de números pares e impares del 1 al 100");
        int par = 0;
        int impar =0;
        for  ( int i = 0; i <=100 ; i++)
        {
            if (i % 2 == 0)
            {
                par += i;
            }
            else
            {
                impar += i;
            }
        }
        Console.WriteLine("La suma de los números pares es: " + par);
        Console.WriteLine("La suma de los números impares es: " + impar);

    }

}
class Ejercicio14
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 14");
        Console.WriteLine("La suma de los cuadrados de los primeros 100 números enteros naturales es:\n ");
        Console.WriteLine("La formula empleada es: n(n+1)(2n+1)/6 "  );
        int a = 100;
        int resultado = (a*(a+1)*(2*a+1))/6;
        Console.WriteLine("El resultado es: " + resultado);   

    }

}
class Ejercicio15
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 15");
        Console.WriteLine(" [a , b]");

        Console.Write("valor inferior: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("valor superior: ");
        int b = int.Parse(Console.ReadLine()!);
            if (a > b)
            {
                Console.WriteLine("El valor inferior no es válido.");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(" [c , d]");
                Console.Write("valor inferior: ");
                int c = int.Parse(Console.ReadLine()!);
                Console.Write("valor superior: ");
                int d = int.Parse(Console.ReadLine()!);
                
                    if (a < b && c < d)
                    {
                        int inicio = Math.Max(a, c);                
                        int fin = Math.Min(b, d);

                        if (inicio > fin)
                        {
                            Console.WriteLine("Los intervalos no se intersectan.");
                            return;
                        }
                        else 
                        {
                            Console.WriteLine("El intervalo [a, b] y [c, d] es válido."); 
                            Console.WriteLine("la intereseccion de los intervalos es: [" + inicio + "," + fin + "]" );

                        }
                    }

                    else
                    {      
                        Console.WriteLine("El valor inferior no puede ser mayor que el valor superior.");
                    }
            }



    }

}
class Ejercicio16
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 16");
        Console.Write("Ingrese un número positivo: ");
        int n = int.Parse(Console.ReadLine()!);

        int contador = 0;

        while (n > 0)
        {
            n = n / 10;
            contador++;
        }

        Console.WriteLine("Cantidad de dígitos: " + contador);
 


    }

}
class Ejercicio17
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 17");
        double a,b,c,d;
        double x ;
        double resultado = 0;
        Console.WriteLine("Ingrese el valor de a");
        a = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingrese el valor de b");
        b = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingrese el valor de c");
        c = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingrese el valor de d");
        d = double.Parse(Console.ReadLine()!);

        for ( int i = 8 ; i <= 100; i++)
        {
            x = i;
        resultado = d - Math.Pow(x, 1) + 2*c*Math.Pow(x, 2) - b*Math.Pow(x, 3) + a*Math.Pow(x, 4);
        Console.WriteLine("El valor de la función es: " + resultado);
        }

    }

}
class Ejercicio18
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 18");
        Console.WriteLine("Ingrese el numero del mes [1-12]:");
        int mes = int.Parse(Console.ReadLine()!);

        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("Mes no valido");
            return;
        }

        int dias = 0;
        string nombre = "";

        switch (mes)
        {
            case 1: nombre = "Enero"; dias = 31; break;

            case 2:
                nombre = "Febrero";

                Console.WriteLine("Ingrese el año:");
                int año = int.Parse(Console.ReadLine()!);

                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                    dias = 29;
                else
                    dias = 28;

                break;

            case 3: nombre = "Marzo"; dias = 31; break;
            case 4: nombre = "Abril"; dias = 30; break;
            case 5: nombre = "Mayo"; dias = 31; break;
            case 6: nombre = "Junio"; dias = 30; break;
            case 7: nombre = "Julio"; dias = 31; break;
            case 8: nombre = "Agosto"; dias = 31; break;
            case 9: nombre = "Septiembre"; dias = 30; break;
            case 10: nombre = "Octubre"; dias = 31; break;
            case 11: nombre = "Noviembre"; dias = 30; break;
            case 12: nombre = "Diciembre"; dias = 31; break;
        }

        Console.WriteLine(nombre + " tiene " + dias + " dias");

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }

}
class Ejercicio19
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 19");
        Console.WriteLine("Calcular el MCD de 49 y 70");
        int a = 49;
        int b = 70;
          while (b != 0)
        {
            int resto = a % b;
            a = b;
            b = resto;
        }

        Console.WriteLine("el MCD de 49 - 70 es: " + a);

    }

}
class Ejercicio20
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 20");
        int num;
        string binario = "";
        Console.Write("Ingrese un número decimal: ");
        num = int.Parse(Console.ReadLine()!);
        if (num < 0)
        {
            Console.WriteLine("Por favor, ingrese un número decimal positivo.");
            return;
        }
        while (num > 0)
        {
            int residuo = num % 2;
            binario = residuo + binario;
            num = num / 2;
        }
        Console.WriteLine("Número en binario: " + binario);

    }

}
class Ejercicio21
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 21");
               int num;
        int invertido = 0;
        Console.Write("Ingrese un número entero: ");
        num = int.Parse(Console.ReadLine()!);
    if (num < 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo.");
            return;
        }
        while (num > 0)
        {
            int cifra = num % 10;
            invertido = invertido * 10 + cifra;
            num = num / 10;
        }
        Console.WriteLine("Número invertido: " + invertido);

    }

}
class Ejercicio22
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 22");
        Console.Write("Introduce el número de filas (n): ");
        int n = int.Parse(Console.ReadLine()!);    
        for (int i = 1; i <= n; i++)
        {
            int cantidadNumeros = 2 * i - 1;
            int pico = 2 * i - 1; 
            for (int j = 0; j < cantidadNumeros; j++)
            {
                int valor;
                if (j < i)
                {
                    valor = (i + j);
                }
                else
                {
                    valor = (2 * i - 2 - j + i);
                }
                Console.Write((valor % 10) + " ");
            }            
            Console.WriteLine();

    }

}
}
class Ejercicio23
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 23");
        // Método que calcula el seno usando n términos
    static double Seno(double x, int n)
    {
        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            double termino = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
            suma += termino;
        }

        return suma;
    }

    // Método factorial
    static double Factorial(int n)
    {
        double fact = 1;

        for (int i = 2; i <= n; i++)
            fact *= i;

        return fact;
    }

    
    {
        int n = 10;

        Console.WriteLine("Ángulo\t\tTangente");
        Console.WriteLine("-------------------------");

        for (int i = 0; i <= 16; i++)
        {
            double angulo = i * Math.PI / 8;

            double seno = Seno(angulo, n);
            double coseno = Math.Sqrt(1 - seno * seno);

            Console.Write($"{i}π/8\t\t");

            if (Math.Abs(coseno) < 1e-10)
            {
                Console.WriteLine("infinito");
            }
            else
            {
                double tangente = seno / coseno;
                Console.WriteLine($"{tangente:F6}");
            }
        }
    }

    }

}
class Ejercicio24
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 24");
        int num;
        Console.Write("Ingrese un número primo: ");
        num = int.Parse(Console.ReadLine()!);

        // Verificar si es primo
        int divisores = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                divisores++;
            }
        }
        if (divisores != 2)
        {
            Console.WriteLine("El número no es primo");
        }
        else
        {
            int a = 1;
            int b = 1;
            int c;
            bool fibonacci = false;
            while (b <= num)
            {
                if (b == num)
                {
                    fibonacci = true;
                    c = a + b;
                    Console.WriteLine("El número sí pertenece a Fibonacci");
                    Console.WriteLine("Terna:");
                    Console.WriteLine(a + " - " + b + " - " + c);
                }
                c = a + b;
                a = b;
                b = c;
            }
            if (fibonacci == false)
            {
                Console.WriteLine("El número no pertenece a Fibonacci");
            }
        }

    }

}
class Ejercicio25
{
    public void Ejercicio()
    {
        Console.WriteLine("Ejercicio 25");
                Console.Write("Ingrese la cantidad de números: ");
        int m = int.Parse(Console.ReadLine()!);

        double sumaInversos = 0;
        double producto = 1;

        for (int i = 1; i <= m; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            double x = double.Parse(Console.ReadLine()!);

            sumaInversos += 1 / x;
            producto *= x;
        }

        double mediaArmonica = m / sumaInversos;
        double mediaGeometrica = Math.Pow(producto, 1.0 / m);

        double diferencia = mediaArmonica - mediaGeometrica;

        Console.WriteLine("Media armónica: " + mediaArmonica);
        Console.WriteLine("Media geométrica: " + mediaGeometrica);
        Console.WriteLine("Diferencia: " + diferencia);

    }

}