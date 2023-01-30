//task 50. Program takes element position in 2 D array  
// and returns the number in this position 
// or tells that there isn't such a number
//1 4 7 2
//5 9 2 3
// 8 4 2 4
//17 -> there isn't such a number

int [,] GetRandomArray (int rowLength, int colLength, int start, int end)
{
    int [,] array = new int [rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}
int [,] Array = GetRandomArray (5, 5, 0, 100);

void Printarray (int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}    ");
        }
        Console.WriteLine("    ");
    }
} 
Printarray(Array);

int GetElementPositionCol(string message)
{
    Console.WriteLine(message);
    int col = int.Parse(Console.ReadLine()!); 
    return col;
}
int colPosition = GetElementPositionCol ("Input element positions in a column");

int GetElementPositionRow(string message)
{
    Console.WriteLine(message);
    int row = int.Parse(Console.ReadLine()!); 
    return row;
}
int rowPosition = GetElementPositionRow ("Input element positions in a row");

void CheckElement (int [,] Array)
{
 if (rowPosition> Array.GetLength(0)-1||colPosition>Array.GetLength(1)-1)
   {
    Console.WriteLine ($"There is no element in column {colPosition} row {rowPosition}"!);
   }
   else
   {
    Console.WriteLine ($"There is number {Array[rowPosition, colPosition]} in column {colPosition} row {rowPosition}"!);
   }
}
CheckElement (Array);
