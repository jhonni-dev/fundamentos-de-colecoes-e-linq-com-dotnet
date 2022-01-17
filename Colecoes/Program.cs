﻿int[] arrayNumeros = new int[7] {100,1,4,0,8,15,19};

var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();

System.Console.WriteLine($"Mínimo: {minimo}");
System.Console.WriteLine($"Máximo: {maximo}");
System.Console.WriteLine($"Médio: {medio}");


// // Query Syntax
// var numerosParesQuery =
//         from num in arrayNumeros
//         where num % 2 == 0
//         orderby num
//         select num;

// // Method Syntax
// var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

// System.Console.WriteLine("Números Pares Query: " + string.Join(", ", numerosParesQuery));
// System.Console.WriteLine("Números Pares Método: " + string.Join(", ", numerosParesMetodo));

// Dictionary<string,string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     // System.Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}");
// }


// string valorProcurado = "SC";
// // var teste = estados["SC"]; // linha para gerar erro proposital

// if (estados.TryGetValue(valorProcurado, out string? estadoEncontrado))
// {
//      System.Console.WriteLine(estadoEncontrado);
// }
// else
// {
//     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário.");
// }

// System.Console.WriteLine($"Removendo a chave {valorProcurado}");

// estados.Remove(valorProcurado);

// foreach (KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}");
// }


// System.Console.WriteLine("Valor original:");
// System.Console.WriteLine(estados[valorProcurado]);

// estados[valorProcurado] = "BA - teste de atualização";

// System.Console.WriteLine("Valor atualizado:");
// System.Console.WriteLine(estados[valorProcurado]);

// Stack<string> pilhaLivros = new Stack<string>();

// pilhaLivros.Push(".NET");
// pilhaLivros.Push(".DDD");
// pilhaLivros.Push("Código Limpo");

// System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

// while (pilhaLivros.Count > 0)
// {
//      System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
//      System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
// }

// System.Console.WriteLine($"Livros para leitura {pilhaLivros.Count}");


// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Jhonatas");
// fila.Enqueue("Eduardo");
// fila.Enqueue("Gabriel");

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

// while (fila.Count > 0)
// {
//      System.Console.WriteLine($"Vez de: {fila.Peek()}");
//      System.Console.WriteLine($"{fila.Dequeue()} atendido.");
// }

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

// using Colecoes.Helper;

// OperacoesLista opLista = new OperacoesLista();
// List<string> estados = new List<string> {"SP", "MG", "BA"};
// string[] estadosArray = new string[2] {"SC", "MT"};

// System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

// opLista.ImprimirListaString(estados);

// // System.Console.WriteLine("Removendo o elemento:");
// // estados.Remove("MG");

// //estados.AddRange(estadosArray);
// estados.Insert(1, "RJ");

// opLista.ImprimirListaString(estados);

// using Colecoes.Helper;

// OperacoesArray op = new OperacoesArray();

// int[] array = new int[5] {6, 3, 8, 1, 9};
// int [] arrayCopia = new int[10];
// string[] arrayString = op.ConverterParaArrayString(array);

// // int valorProcurado = 8;

// System.Console.WriteLine($"Capaciade atual do array: {array.Length}");
// op.RedimensionarArray(ref array, array.Length * 2);

// System.Console.WriteLine($"Capaciade do array após redimensionamento: {array.Length}");
// System.Console.WriteLine("Array redimensionado:");
// op.ImprimirArray(array);

// int indice = op.ObterIndice(array, valorProcurado);

// if (indice > -1)
// {
//     System.Console.WriteLine($"O índice do elemento {valorProcurado} é {indice}");
// }
// else
// {
//     System.Console.WriteLine("Valor inexistente no array");
// }

// int valorAchado = op.ObterValor(array, valorProcurado);

// if(valorAchado > 0)
// {
//     System.Console.WriteLine("Encontrei o valor");
// }
// else
// {
//     System.Console.WriteLine("Não encontrei o valor");
// }

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
