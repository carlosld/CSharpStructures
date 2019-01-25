using System;

namespace ConsoleTest 
{
    public static class Arrays
    {
        public static void ArrayUnidimensional()
        {
            Console.WriteLine("Arrays de una dimensión");
            Console.WriteLine("=======================");

            int[] impares = new int[] { 1, 3, 5, 7, 9 };
            int[] pares = { 2, 4, 6, 8 };

            var listaNumerosImpares = string.Empty;
            foreach (int impar in impares)
            {
                listaNumerosImpares += $"{impar}, ";
            }
            listaNumerosImpares = listaNumerosImpares.Substring(0, listaNumerosImpares.Length - 2);
            Console.WriteLine($"Números impares: {{ {listaNumerosImpares} }}");
            Console.WriteLine();
            
            Console.WriteLine($"Números pares: {{ {string.Join(", ", pares)} }}");
            Console.WriteLine();
        }

        public static void ArrayMultiDimensional()
        {
            Console.WriteLine("Arrays de varias dimensiones");
            Console.WriteLine("============================");

            int[,] numerosPares = new int[3,2];
            numerosPares[0,0] = 2;
            numerosPares[0,1] = 4;
            numerosPares[1,0] = 6;
            numerosPares[1,1] = 8;
            numerosPares[2,0] = 10;
            numerosPares[2,1] = 12;

            Console.WriteLine($"Matriz de números pares:");
            for (var i = 0; i < numerosPares.GetLength(0); i++)
            {
                var listaNumeros = string.Empty;
                for (var j = 0; j < numerosPares.GetLength(1); j++)
                {
                    listaNumeros += $"{numerosPares[i,j]}, ";
                }
                listaNumeros = listaNumeros.Substring(0, listaNumeros.Length - 2);
                Console.WriteLine($"{{ {listaNumeros} }}");
            }
            Console.WriteLine();

            int[,] numeros = new int[,]
                { 
                    { 9, 5, -9 }, 
                    { -11, 4, 0 }, 
                    { 6, 115, 3 }, 
                    { -12, -9, 71 }, 
                    { 1, -6, -1 } 
                };

            Console.WriteLine($"Matriz de números aleatorios:");
            for (var i = 0; i < numeros.GetLength(0); i++)
            {
                var listaNumeros = string.Empty;
                for (var j = 0; j < numeros.GetLength(1); j++)
                {
                    listaNumeros += $"{numeros[i,j]}, ";
                }
                listaNumeros = listaNumeros.Substring(0, listaNumeros.Length - 2);
                Console.WriteLine($"{{ {listaNumeros} }}");
            }
            Console.WriteLine();
        }
    }
}