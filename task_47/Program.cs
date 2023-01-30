//task 47. Create a 2-dimension array m×n, 
// filled with rational numbers
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int GetArraySizeFromUserRows(string message)
{
    Console.WriteLine(message);
    int rows = int.Parse(Console.ReadLine()!); 
    return rows;
}
int row= GetArraySizeFromUserRows("Input the quantity of rows");

int GetArraySizeFromUserCols(string message)
{
    Console.WriteLine(message);
    int columns = int.Parse(Console.ReadLine()!); 
    return columns;
}
int col= GetArraySizeFromUserCols("Input the quantity of columns");

double [,] GetRealNumbersArray (int rowLength, int colLength, int start, int end)
{
    double [,] array = new double [rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
        }
    }
    return array;
}
double [,] Array = GetRealNumbersArray (row, col, -100, 100);

void Printarray (double [,] Array)
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