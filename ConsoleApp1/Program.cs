using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

class Program
{
    private static object i;

    public static void Main(string[] args)
    {

        //int RespuestasCorrectas = 0;
        //int NumerodePreguntas = 0;
        //Console.WriteLine("Escriba el numero de preguntas del examen: ");
        //NumerodePreguntas = int.Parse(Console.ReadLine());
        //Console.WriteLine("Escriba el numero de preguntas correctas: ");
        //RespuestasCorrectas = int.Parse(Console.ReadLine());

        //decimal score = (NumerodePreguntas * RespuestasCorrectas) / 100;
        //Console.WriteLine("Suporcentaje es de: " + score + "%");

        //if (score >= 90)
        //{
        //    Console.WriteLine("Nivel Maximo");
        //}
        //else if (score >= 75 && score < 90)
        //{
        //    Console.WriteLine("Nivel Medio");
        //}
        //if (score >= 50 && score < 75)
        //{
        //    Console.WriteLine("Nivel Regular");
        //}
        //else if (score < 50)
        //{
        //    Console.WriteLine("Fuera de Nivel");
        //}











        //int num = 1;
        //while (num <= 10)
        //{

        //   Console.WriteLine("{0} " + num);
        //    num++;
        //}








        //int angulo1 = 0;
        //int angulo2 = 0;
        //int angulo3 = 0;

        //Console.WriteLine("**LADOS DE UN TRIANGULO**");
        //Console.WriteLine("  ");

        //for (int total = 0; total != 180;)
        //{

        //    Console.WriteLine("Escriba la longitud del primer lado: ");
        //    angulo1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba la longitud del segundo angulo: ");
        //    angulo2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba la longitud del tercer lado: ");
        //    angulo3 = int.Parse(Console.ReadLine());

        //    total = (angulo1 + angulo2 + angulo3);

        //    if(total == 180)
        //    {
        //        Console.WriteLine("Su angulo es de: " + total);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Valor erroneo, el resultado debe de ser 180");
        //        Console.WriteLine("   ");
        //    }


        //}










        //int ContadorDivision3 = 0;
        //int ContadorDivision5 = 0;

        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);

        //    if (i % 3 == 0)
        //    {
        //        ContadorDivision3++;
        //    }
        //    else if (i % 5 == 0)
        //    {
        //        ContadorDivision5++;
        //    }
        //}

        //     Console.WriteLine("La cantidad de numeros que se pueden dividir entre 3 son: " + ContadorDivision3);
        //    Console.WriteLine("    ");
        //Console.WriteLine("La cantidad de numeros que se pueden dividir por 5 son: " + ContadorDivision5);




        //for (int i = 0; i < 10; i++)
        //{
        //    int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 = 0;
        //    #region numeros
        //    Console.WriteLine("Escriba el primer numero: ");
        //    n1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el segundo numero: ");
        //    n2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el tercer numero: ");
        //    n3 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el cuarto numero: ");
        //    n4 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el quinto numero: ");
        //    n5 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el sexto numero: ");
        //    n6 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el septimo numero");
        //    n7 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el octavo numero: ");
        //    n8 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el noveno numero: ");
        //    n9 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el decimo numero: ");
        //    n10 = int.Parse(Console.ReadLine());
        //    #endregion

        //    Console.WriteLine("   ");
        //    Console.WriteLine("la suma de los ultimos cinco numeros es: " + (n5 + n6 + n7 + n8 + n9 + n10));
        //}





        #region piezas de metal
        //float medida = 0;
        //double longitudMax = 25;
        //double LongitudMin = 15;
        //int contador = 1;
        //int piezasAceptadas = 0;
        //int piezasNoAceptadas = 0;

        //try
        //{
        //    Console.WriteLine("**PIEZAS DE METAL APTAS**");

        //    while (contador < 10)
        //    {
        //        Console.WriteLine($"Digite la Longitud de la pieza {contador}");
        //        medida = int.Parse(Console.ReadLine());
        //        contador++;

        //        if (medida <= longitudMax && medida >= LongitudMin)
        //        {
        //            piezasAceptadas++;
        //        }
        //        else
        //        {
        //            piezasNoAceptadas++;
        //        }


        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Las piezas aptas para el lote son: " + piezasAceptadas);
        //    Console.WriteLine();
        //    Console.WriteLine("Las piezas no aptas para el lote son: " + piezasNoAceptadas);
        //}
        //catch (Exception ex) 
        //{
        //    Console.WriteLine("Error compañero");
        //}

        #endregion

        #region ejemplo1cap8
        //int[] arreglo = new int[10];
        //Console.WriteLine("{0}{1,8}", "inice", "valor");

        //for (int contador = 0; contador < arreglo.Length; contador++)
        //{
        //    Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
        //}

        #endregion


        #region ejemplo2cap8
        //int[] arreglo = { 32, 37, 64, 18, 95, 14, 90, 70, 60, 37 };

        //Console.WriteLine("{0}{1,8}", "indice", "valor");

        //for (int contador = 0; contador < arreglo.Length; contador++)
        //{
        //    Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
        //}
        #endregion


        #region ejemplo3cap8

        //const int LONGITUD_ARREGLO = 10; //crear una constante con nombre
        //int[] arreglo = new int[LONGITUD_ARREGLO]; //crear un arreglo

        ////calcular el valor para cada elemnto del arreglo
        //for (int contador = 0; contador < arreglo.Length; contador++)
        //{
        //    arreglo[contador] = 2 + 2 * contador;

        //}
        //Console.WriteLine("{0}{1,8}", "indice", "valor"); //encabezados


        ////imprime en pantalla el valor de cada elemento del arreglo
        //for (int contador = 0; contador < arreglo.Length; contador++)
        //{
        //    Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
        //}

        #endregion

        #region ejemplo4cap8

        //int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
        //int total = 0;

        //for (int contador = 0; contador < arreglo.Length; contador++)
        //{
        //    total += arreglo[contador];
        //}

        //Console.WriteLine("EL total de la nota de los examenes es {0}: ", total);

        #endregion

        #region ejemplo5cap8

        //int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };
        //Console.WriteLine("Distribuicion de las calificaciones:");

        //for (int contador = 0; contador < arreglo.Length; contador++)
        //{
        //    if (contador == 10)
        //    {
        //        Console.Write("  100:  ");
        //    }
        //    else
        //    {
        //        Console.Write("{0:D2}-{1:D2}: ",
        //            contador * 10, contador * 10 + 9);
        //    }

        //    for (int estrellas = 0; estrellas < arreglo[contador]; estrellas++)
        //    {
        //        Console.Write("*");
        //    }

        //    Console.WriteLine();
        //}

        #endregion

        #region ejemplo6cap8

        //Random numerosAleatorios = new Random();
        //int[] frecuencia = new int[7];

        //for (int tiro = 1; tiro <= 6000; tiro++)
        //{
        //    ++frecuencia[numerosAleatorios.Next(1, 7)];
        //}

        //Console.WriteLine("{0}{1,10}", "cara", "Frecueancia");

        //for (int cara = 1; cara < frecuencia.Length; cara++)
        //{
        //    Console.WriteLine("{0,4}{1,10}", cara, frecuencia[cara]);
        //}

        #endregion

        #region ejemplo7cap8

        //int[] respuestas = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6, 10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7, 5, 6, 6, 5, 6, 7, 5, 6, 4, 8, 6, 8, 10 };
        //int[] frecuencia = new int[11];

        //for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
        //{
        //    ++frecuencia[respuestas[respuesta]];
        //}

        //Console.WriteLine("{0}{1,11}", "Calificacion", "Frecuencia");

        //for (int calificacion = 1; calificacion < frecuencia.Length; calificacion++)
        //{
        //    Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia[calificacion]);
        //}

        #endregion

        #region ejemplo8cap8

        //int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
        //int total = 0;


        //foreach (int numero in arreglo)
        //{
        //    total += numero;
        //}

        //Console.WriteLine("Total de elementos en el arreglo: {0}", total);


        #endregion




        #region triangulos
        //int numeroDeTriangulos = 0;
        //int baseDeTriangulo = 0;
        //int altura = 0;
        //int indice = 1;
        //int area = 0;
        //int triangulosMayores = 0;
        //try
        //{
        //    Console.Write("Digite el numero de triangulos que desea procesar: ");
        //    numeroDeTriangulos = int.Parse(Console.ReadLine());
        //    Console.WriteLine();

        //    while (indice <= numeroDeTriangulos)
        //    {
        //        Console.WriteLine();

        //        Console.WriteLine($"Escriba la base del triangulo {indice}");
        //        baseDeTriangulo = int.Parse(Console.ReadLine());
        //        Console.WriteLine($"Escriba la altura del triangulo {indice}");
        //        altura = int.Parse(Console.ReadLine());
        //        area = (baseDeTriangulo + altura) / 2;
        //        Console.WriteLine();
        //        Console.WriteLine("**BASE, ALTURA Y AREA**");


        //        Console.WriteLine($"La base del triangulo {indice} es: {baseDeTriangulo} ");
        //        Console.WriteLine($"La altura del triangulo {indice} es: {altura}");
        //        Console.WriteLine($"El area del triangulo {indice} es: {area}");


        //        if (area > 12)
        //        {
        //            triangulosMayores++;
        //        }
        //            indice++;
        //    }





        //        Console.WriteLine();

        //        Console.WriteLine($"La cantidad de triangulos que se pasan de 12 unidades cuadradas es de: {triangulosMayores}");




        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        #endregion

        #region sueldoDeempleados

        //int sueldoDeEmpleados = 0;
        //int SueldosEntre100y300 = 0;
        //int sueldosMayor300 = 0;
        //double total = 0;


        //try
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"Escriba el saldo del empleado {i}");
        //        sueldoDeEmpleados = int.Parse(Console.ReadLine());
        //        total += sueldoDeEmpleados;

        //        if (sueldoDeEmpleados >= 100 && sueldoDeEmpleados <= 300)
        //        {
        //            SueldosEntre100y300++;
        //        }
        //        else if (sueldoDeEmpleados > 300)
        //        {
        //            sueldosMayor300++;
        //        }
        //        if (sueldoDeEmpleados < 100)
        //        {
        //            Console.WriteLine("El sueldo de el empleado debe de ser entre 100 y 500");
        //            break;
        //        }
        //        if (sueldoDeEmpleados > 500)
        //        {
        //            Console.WriteLine("El sueldo de el empleado debe de ser entre 100 y 500");
        //            break;
        //        }



        //    }

        //    Console.WriteLine($"La cantidad de empleados que cobran estre 100 y 300 pesos son: {SueldosEntre100y300}");
        //    Console.WriteLine();
        //    Console.WriteLine($"La cantidad de empleados que cobran mas de 300 pesos son: {sueldosMayor300}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Los gastos totales de la compañia es de : {total}");

        //}
        //catch (Exception ex )
        //{
        //    Console.WriteLine(ex.Message);
        //}
        #endregion








        #region array1

        //int[] arreglo = new int[20];

        //for (int contador =  0;  contador < arreglo.Length; contador++)
        //{
        //    arreglo[contador] = contador * 5;
        //    Console.WriteLine("{0,5}{1,8}",contador, arreglo[contador]);
        //}

        #endregion

        #region array2

        //int[] arreglo1 = new int[5];
        //int[] arreglo2 = new int[5];
        //int similitudes = 0;



        //try
        //{
        //    Console.WriteLine("Escriba los 5 valores de la primera matriz: ");

        //    for (int i = 0; i < arreglo1.Length; i++)
        //    {
        //        arreglo1[i] = int.Parse(Console.ReadLine());
        //    }



        //    Console.WriteLine("Escriba los 5 valores de la segunda matriz: ");

        //    for (int j = 0; j < arreglo2.Length; j++)
        //    {
        //        arreglo2[j] = int.Parse(Console.ReadLine());
        //    }



        //    for (int i = 0; i < arreglo1.Length; i++)
        //    {
        //        for (int j = 0; j < arreglo2.Length; j++)

        //            if (arreglo1[i] == arreglo2[j])
        //            {
        //                similitudes++;
        //            }

        //    }



        //    Console.WriteLine($"Las similitudes son: {similitudes}");


        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.ToString());
        //}

        #endregion

        #region array3

        //int[] numeros = new int[5];
        //int numerosRepetidos = 0;
        //int numMenor = 0;

        //try
        //{
        //    Console.WriteLine("Escriba 5 numeros: ");

        //    for (int i = 0; i < numeros.Length; i++)
        //    {

        //        numeros[i] = int.Parse(Console.ReadLine());
        //        numMenor = numeros[i];
        //    }

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (numeros[i] < numMenor)
        //        {
        //            numMenor = numeros[i];
        //        }
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine($"EL numero de Menor valor es el de: {numMenor}");

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        int b = i + 1;

        //        for (int j = b; j < numeros.Length; j++)
        //        {
        //            if (numeros[i] == numeros[j])
        //            {
        //                numerosRepetidos++;
        //            }
        //        }

        //    }

        //    if (numerosRepetidos > 0)
        //    {
        //        Console.WriteLine("Un valor se repite por lo menos una vez");
        //    }
        //    else
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("No hay valores repetidos");
        //    }
        //}
        //catch (Exception m)
        //{
        //    Console.WriteLine(m.Message);
        //}

        #endregion










    }



}


