// Задача: Написать программу, которая из имеющегося массива строк формирует массив из сторк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры.

string[] GetArray(string text)
{
    System.Console.Write(text);
    var array = Array.ConvertAll(Console.ReadLine().Split(", "), Convert.ToString);
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int CountElements(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result++;
        }
    }
    return result;
}

string[] FindNewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] myArray = GetArray("Введите строки, разделяя их запятой и пробелом: ");
int sizeNewArray = CountElements(myArray);
string[] newArray = FindNewArray(myArray, sizeNewArray);
System.Console.WriteLine();
System.Console.Write("Строки, длина которых меньше или равна 3 символа: ");
PrintArray(newArray);