// 2.В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// Вариант 1
Console.Clear();
Console.WriteLine("Исходная матрица: ");

int[,] myArray = 
{
    {2,8,6,3},
    {9,4,0,7},
    {5,1,8,3},
};
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j <  myArray.GetLength(1); j++)
    {
        Console.Write($"{ myArray[i,j]} ");
    }
    Console.WriteLine();
}


int minElement = myArray[0,0];
int rowNumber = 0;
int columnNumber = 0;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        if(minElement > myArray[i,j])
        {
            minElement = myArray[i,j];
            rowNumber = i;
            columnNumber = j;
            Console.Write($" Минимальный элемент в массиве равен {minElement}, строка: {rowNumber+1}, столбец: {columnNumber+1}.");
        }      
    }
    Console.WriteLine();
}

Console.WriteLine($" Массив после удаления строки {rowNumber+1} и столбца {columnNumber+1} :  ");
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j <  myArray.GetLength(1); j++)
    {
        
        if (i == rowNumber || j == columnNumber)
            continue;
        else
            Console.Write($"{ myArray[i,j]} ");
        
    }
    Console.WriteLine();
}


// Вариант 2

/*int [,] myArray = new int [3,3];
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {        
        Console.Write($"{myArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {        
        myArray[i,j] = new Random().Next(0,10);
        Console.Write($"{myArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int minElement = myArray[0,0];
int rowNumber = 0;
int columnNumber = 0;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        if(minElement > myArray[i,j])
        {
            minElement = myArray[i,j];
            rowNumber = i;
            columnNumber = j;
            Console.Write($" Минимальный элемент в массиве равен {minElement}, строка: {rowNumber+1}, столбец: {columnNumber+1}.");
        }      
    }
    Console.WriteLine();
}

Console.WriteLine($" Массив после удаления строки {rowNumber+1} и столбца {columnNumber+1} :  ");
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j <  myArray.GetLength(1); j++)
    {
        
        if (i == rowNumber || j == columnNumber)
            continue;
        else
            Console.Write($"{ myArray[i,j]} ");
        
    }
    Console.WriteLine();
}
*/




























