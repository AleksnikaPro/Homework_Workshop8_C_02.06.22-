// 4.Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();


for (int i = 0; i < rows; i++)
{ 
    int number = 1;
    Console.Write( new String(' ', (rows - i) * 2));;
    for (int j = 0; j <= i; j++)
    {
       Console.Write(" ");
       Console.Write("{0,2}", + number);
       Console.Write(" ");
       number = number * (i - j) / (j + 1);
    }
    Console.WriteLine();

} 
Console.WriteLine();



