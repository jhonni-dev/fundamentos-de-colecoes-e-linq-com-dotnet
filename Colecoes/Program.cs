int[,] matriz = new int [4, 2] 
{
    {8, 8},
    {10, 200},
    {50, 100},
    {90, 200}
};

for (int i = 0; i < matriz.GetLength(0); i++) // Este for é para linha
{
    for (int j = 0; j < matriz.GetLength(1); j++) // Este for é para coluna
    {
        System.Console.WriteLine(matriz[i,j]); //Percorre linha e coluna
    }
}


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
