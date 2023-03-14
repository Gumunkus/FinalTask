/*
Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.*
*/


string[] sourceArray = GetArgsFromConsole("Введите несколько строк через запятую-->", ',');
int limiter = 3;

int size = GetCountLimited(sourceArray, limiter);
string[] resultArray = new string[size];
FillResultArray(ref sourceArray, ref resultArray, limiter);

WriteArray(sourceArray);
Console.Write(" -> ");
WriteArray(resultArray);


string[] GetArgsFromConsole(string label, char separator)
{
    Console.WriteLine(label);
    string value = Console.ReadLine()!;
    string[] arrgs = value.Split(separator);
    return arrgs;
}


void WriteArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length - 1]}\"]");
}


int GetCountLimited(string[] array, int limiter)
{
    int count = 0;
    foreach (string value in array)
    {
        if (value.Length <= limiter) count++;
    }
    return count;
}


void FillResultArray(ref string[] sourse, ref string[] result, int limiter)
{
    int i = 0;
    foreach (string value in sourse)
    {
        if (value.Length <= limiter)
        {
            result[i] = value;
            i++;
        }
    }
}