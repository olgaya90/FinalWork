// =================================================================================================================================
//                                 Задача 1
// Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями лучше обойтись исключительно массивами.
// =================================================================================================================================

System.Random random = new Random();

//Генерируем массив
string[] GenArray(int a, int b, int c, int d)
{
    int i = 0;
    int n = random.Next(a, b + 1);
    string[] array = new string[n];

    string RandomString(int length)
    {
        string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    while (i < n)
    {
        array[i++] = RandomString(random.Next(c, d + 1));
    }

    return array;
}

//Модификация массива
string[] ModArr (string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }

    string[] outArray = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            outArray[j++] = arr[i];
        }
    }

    return outArray;
}

//Выводим на печать массив
void Print(string[] arr, string str)
{
    if (str.Length > 0)
    {
        Console.WriteLine();
        Console.WriteLine(str);
        Console.WriteLine(new string('-', str.Length));
    }
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + (i != arr.Length - 1 ? ", " : ""));
    }
    Console.Write("]");
    Console.WriteLine();
}

int arSizeMin = 10; //Минимально возможный размер массива
int arSizeMax = 99; //Масимально возможный размер массива
int stringSizeMin = 1; //Минимально возможная длинна элемента массива
int stringSizeMax = 9; //Масимально возможная длинна элемента массива

string[] intArr = GenArray(arSizeMin, arSizeMax, stringSizeMin, stringSizeMax);
Print(intArr, "Сгенерированный массив:");
string[] sortArray = ModArr(intArr);
Print(sortArray, "Массив из строк, длина которых меньше либо равна три символа:");