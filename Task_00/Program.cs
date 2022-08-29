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
    string[] arrayM = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        string element = Console.ReadLine(); //записываем в массив каждый элемент
        arrayM[i] = element;
    }
    return arrayM;
}


