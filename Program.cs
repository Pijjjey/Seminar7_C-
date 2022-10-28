//Задача 47

/*int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"[{Array[i,j]}]");
        }
        Console.WriteLine();
    }
}

PrintArray(GetArray(3,6, 0,12));*/

//Задача 50

/*int[,] Array = GetArray(5,5,0,10);

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"[{Array[i,j]}]");
        }
        Console.WriteLine();
    }
}

PrintArray(Array);

Console.Write("Введите индекс столбца: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите индекс строки: ");
int j = int.Parse(Console.ReadLine());
CheckArray(Array, i, j);

void CheckArray (int[,] Array, int column, int line)
{
    if(column < Array.GetLength(0) && line < Array.GetLength(1))
    Console.WriteLine(Array[column, line]);
    else
    Console.WriteLine("Такого числа нет!");
}
*/

//Задача 52.


int[,] Array = GetArray(3,6, 0,12);

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"[{Array[i,j]}]");
        }
        Console.WriteLine();
    }
}

PrintArray(Array);

void SrednAri(int[,] Array)
{
    int SrednAri = 0;
    for(int i = 0; i < Array.GetLength(1); i++)
    {
        for(int j = 0; j < Array.GetLength(0); j++)
        {   
            SrednAri = SrednAri + Array[j,i];
        }
        SrednAri = SrednAri / Array.GetLength(0);
        Console.Write($"{SrednAri}; ");
        SrednAri = 0;
    }   
}

SrednAri(Array);
