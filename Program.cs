// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// // Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNumbersMN(int start, int end)
{
    if (end > start)
    {
        PrintNumbersMN(start, end - 1);
    }
    Console.WriteLine(end);
}

Console.WriteLine("Задача 1");
Console.WriteLine("Введите 2 числа:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Числа от {m} до {n}:");
if (m < n)
{
    PrintNumbersMN(m, n);
}
else
{
    PrintNumbersMN(n, m);
}


// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// A(m,n) = n+1, если m=0
// A(m,n) = A(m-1,1), если m>0 и n=0
// A(m,n) = A(m-1,A(m,n-1)), если m>0 и n>0
int CountAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return CountAkkermanFunction(m - 1, 1);
    }
    return CountAkkermanFunction(m - 1, CountAkkermanFunction(m, n - 1));
}

Console.WriteLine("Задача 2");
Console.WriteLine("Введите 2 числа для вычисления функции Аккермана:");
int m2 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция А({m2},{n2}) = {CountAkkermanFunction(m2, n2)}");

// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
Console.WriteLine("Задача 3");

int[] CreateArray(int size)
{
    int[] matrix = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        matrix[i] = rnd.Next(100);// от 0 до 100
    }
    return matrix;
}

int arraySize = 10;
int[] array = CreateArray(arraySize);

Console.WriteLine($"Исходный массив [{string.Join(';', array)}]");

void PrintArrayElement(int[] arr, int i = 0)
{

    if (i < arr.Length - 1)
    {
        PrintArrayElement(arr, i + 1);
    }
    Console.Write(arr[i] + " ");
}
Console.WriteLine("Элементы массива с конца");
PrintArrayElement(array);
