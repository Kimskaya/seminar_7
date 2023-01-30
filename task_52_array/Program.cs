
//task 52. Create 2-dimension array filled with integers 
//find arithmetic average in each column
//Example:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// Arithmetic average of each column is: 4,6; 5,6; 3,6; 3.
int [,] GetRandomArray (int rowLength, int colLength, int start, int end)
{
    int [,] array = new int [rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}
int [,] Array = GetRandomArray (3, 4, -10, 10);

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

double [] GetAverage (int [,] Array)
{  
    double sum= 0;
    double [] result = new double [Array.GetLength(1)];
for (int j = 0; j < Array.GetLength(1); j++)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
     sum = sum + Array [i,j];
    } 
    double columnAverage = sum/Array.GetLength(0);
    Console.WriteLine($"Arithmetic average of the columns is : {columnAverage}"!);
    sum = 0; 
}
}
GetAverage(Array);
