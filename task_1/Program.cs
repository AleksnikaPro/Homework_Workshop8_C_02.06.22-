// 1.Найти произведение двух матриц.

Console.Clear();
Console.WriteLine("Первая матрица: ");
int[,] firstArray = 
{
    {2,-2,3},
    {0,2,6},
    {5,1,0},
};
for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
        Console.Write($"{firstArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
int[,] secondArray = 
{
    {0,2,5},
    {4,-1,7},
    {1,-2,0},
};
for (int i = 0; i < secondArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        Console.Write($"{secondArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Произведение двух матриц: ");
int[,] multiplicationOfArrays = new int [firstArray.GetLength(0),secondArray.GetLength(1)];
for (int i = 0; i < firstArray.GetLength(0); i++)
{   
    for (int j = 0; j < secondArray.GetLength(0); j++)
    {   
        
        for (int k = 0; k < secondArray.GetLength(1); k++)
        {
            multiplicationOfArrays[i,k] += (firstArray[i,j] * secondArray[j,k]);
        }
        Console.WriteLine(); 
             
    }
    
}
for (int i = 0; i < multiplicationOfArrays.GetLength(0); i++)
{
   for (int j = 0; j < multiplicationOfArrays.GetLength(1); j++)
   {
       Console.Write($"{ multiplicationOfArrays[i,j]} ");
   } 
   Console.WriteLine(); 
}



// Вариант 2

/*Console.Clear();
Console.WriteLine("Первая матрица: ");
int[,] firstArray = new int [3,3];
for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
        firstArray[i,j] = new Random().Next(0,10);
        Console.Write($"{firstArray[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Вторая матрица: "); 
int[,] secondArray = new int [3,3];
for (int i = 0; i < secondArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        secondArray[i,j] = new Random().Next(0,10);
        Console.Write($"{secondArray[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Произведение двух матриц: ");
int[,] multiplicationOfArrays = new int [firstArray.GetLength(0),secondArray.GetLength(1)];
for (int i = 0; i < firstArray.GetLength(0); i++)
{   
    for (int j = 0; j < secondArray.GetLength(0); j++)
    {   
        for (int k = 0; k < secondArray.GetLength(1); k++)
        {
            multiplicationOfArrays[i,k] += (firstArray[i,j] * secondArray[j,k]);
        }
        Console.WriteLine();    
    }
    
}
for (int i = 0; i < multiplicationOfArrays.GetLength(0); i++)
{
   for (int j = 0; j < multiplicationOfArrays.GetLength(1); j++)
   {
       Console.Write($"{ multiplicationOfArrays[i,j]} ");
   } 
   Console.WriteLine(); 
}
*/