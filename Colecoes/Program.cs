﻿using Colecoes.Helper;

OperacoesArray op = new OperacoesArray();

int[] array = new int[5] {6, 3, 8, 1, 9};
int [] arrayCopia = new int[10];

int valorProcurado = 9;
int valorAchado = op.ObterValor(array, valorProcurado);

if(valorAchado > 0)
{
    System.Console.WriteLine("Encontrei o valor");
}
else
{
    System.Console.WriteLine("Não encontrei o valor");
}

// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (todosMaiorQue)
// {
//     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Existe(m) valores que não são maiores que {0}", valorProcurado);
// }

// bool existe = op.Existe(array, valorProcurado);

// if(existe)
// {
//     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
// }
// System.Console.WriteLine("Array original: ");
// op.ImprimirArray(array);

// // op.OrdenarBubbleSort(ref array);
// // op.Ordenar(ref array);

// System.Console.WriteLine("Array ordenado:");
// op.ImprimirArray(array);

// System.Console.WriteLine("Array antes da cópia: ");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// System.Console.WriteLine("Array após a cópia: ");
// op.ImprimirArray(arrayCopia);

// int[,] matriz = new int [4, 2] 
// {
//     {8, 8},
//     {10, 200},
//     {50, 100},
//     {90, 200}
// };

// for (int i = 0; i < matriz.GetLength(0); i++) // Este for é para linha
// {
//     for (int j = 0; j < matriz.GetLength(1); j++) // Este for é para coluna
//     {
//         System.Console.WriteLine(matriz[i,j]); //Percorre linha e coluna
//     }
// }


//int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");

// arrayInteiros[3] = 30; // Esta linha irá retornar um erro por tentar acessar um elemento que não existe

// System.Console.WriteLine("Percorrendo pelo for");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo pelo foreach");
// foreach (int item in arrayInteiros)
// {
//     System.Console.WriteLine(item);
// }
