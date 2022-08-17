void FillArrayDouble(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            //array[i,j] = random.Next(5,6);
            array[i,j] = Math.Round(random.NextDouble()*15-5, 2);
        }
    }
}
void PrintArrayDouble(double[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = random.Next(0,9);
        }
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void Zadacha47()
{
Random random = new Random();
int rows = random.Next(4,6);
int colums = random.Next(4,6);
double[,] array = new double[rows, colums];
FillArrayDouble(array);
PrintArrayDouble(array);
}
void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(4,5);
    int colums = random.Next(4,5);
    double[,] array = new double[rows, colums];
    FillArrayDouble(array);
    PrintArrayDouble(array);
    Console.WriteLine("Введите позицию элемента");
    Console.Write("Строчка:");
    int i = int.Parse(Console.ReadLine());
    Console.Write("Столбец:");
    int j = int.Parse(Console.ReadLine());
    if (i > rows || j > colums) Console.WriteLine("В этой матрици нет такой позиции.");
    else Console.WriteLine($"В этой позиции {i}, {j} стоит число: " + array[i,j]);
}
void Zadacha52()
{
    Random random = new Random();
    double sum = 0;
    int rows = random.Next(4,5);
    int colums = random.Next(4,5);
    int[,] array = new int[rows, colums];
    FillArray(array);
    PrintArray(array);
    for (int j = 0; j < colums; j++)
    {
        sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i,j];
        }
        Console.WriteLine($"В столбце {j} среднее арифметическое: " + (sum/rows));
    }
}
Zadacha52();