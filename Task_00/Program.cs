// Задача
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int siezeOfArray = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int size)
{
    string[] array1 = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        string element = Console.ReadLine();
        array1[i] = element;
    }
    return array1;
}

string[] ChangeArray(string[] arr3, int counter)
{
    string[] Newarray1 = new string[counter];
    int j = 0;
    for (int i = 0; i < counter; i++)
    {
        if (arr3[i] != null)
        {
            Newarray1[j] = arr3[i];
            j++;
        }
    }
    return Newarray1;
}

string[] LengthOfArrayForThree(string[] arr)
{
    int count = 0;
    string[] Newarray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Newarray[count] = arr[i];
            count++;
        }
    }
    string[] ArrayResultt = ChangeArray(Newarray, count);
    return ArrayResultt;
}

void PrintArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array2.Length - 1) Console.Write(array2[i] + " ");
        else Console.Write(array2[i] + "]");
    }
}

string[] array = CreateArray(siezeOfArray);
Console.WriteLine("Ваш исходный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Ваш новый массив: ");
string[] arrayNew = LengthOfArrayForThree(array);
PrintArray(arrayNew);