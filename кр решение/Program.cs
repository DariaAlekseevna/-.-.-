/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна трем символам. 
Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма. */

void FillArray(string[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите элемент массива:");
        array[index] = Console.ReadLine();
        index++;
    }
}

void PrintArray(string[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        if (position == 0 && (count - 1) == 0)
        {
            Console.WriteLine("[" + array[position] + "]");
        }
        else if (position == 0)
        {
            Console.Write("[" + array[position] + ", ");
        }
        else if (position == (count - 1))
        {
            Console.WriteLine(array[position] + "]");
        }
        else
        {
            Console.Write(array[position] + ", ");
        }
        position++;
    }
}

void CheckArray(string[] array, int length)
{
    int i = 0;
    string[] NewArray = new string[array.Length];

    while (i < array.Length)
    {
        if (array[i].Length <= length)
        {
            NewArray[i] = array[i];
        }

        i++;
    }
    NewArray = NewArray.Where(x => x != null).ToArray();
    PrintArray(NewArray);
}

ushort n;
Console.WriteLine("Введите количество элементов массива:");

while (!ushort.TryParse(Console.ReadLine(), out n))
{
    System.Console.WriteLine("Введите корректное значение:");
}

if (n == 0)
{
    Console.WriteLine("Задана строка с нулем символов (пустая строка).");
}
else
{
    string[] array = new string[n];
    FillArray(array);
    System.Console.WriteLine();
    Console.WriteLine("Массив заданный пользователем:");
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine("Массив из строк, длина которых меньше либо равна 3м символам:");
    CheckArray(array, 3);
    System.Console.WriteLine();
}

