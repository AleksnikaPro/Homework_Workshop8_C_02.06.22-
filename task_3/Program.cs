// 3.Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.

Console.Clear();                    
int[,,] myThreeDimensionalArray = new int [3,3,3]; 
for (int z = 0; z < myThreeDimensionalArray.GetLength(0); z++)// перебираем страницы
{   
    for (int i = 0; i < myThreeDimensionalArray.GetLength(1); i++)//перебираем строки
    {
        for (int j = 0; j < myThreeDimensionalArray.GetLength(2); j++)//перебираем столбцы
        {
            myThreeDimensionalArray[z,i,j] = new Random().Next(10,99);
            
            
        }
    }
 Console.WriteLine(); 
}

for (int z = 0; z < myThreeDimensionalArray.GetLength(0); z++)
{   
    Console.WriteLine("Страница № "+ (z + 1));
    Console.WriteLine();
    for (int i = 0; i < myThreeDimensionalArray.GetLength(1); i++)
    {
        Console.Write($"Строка {i+1}  ");
        for (int j = 0; j < myThreeDimensionalArray.GetLength(2); j++)
        {
           Console.Write($"{myThreeDimensionalArray[z,i,j]} [{z},{i},{j}] "); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine("========================================================");
}

