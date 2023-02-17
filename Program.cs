// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых 
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении обойтись исключительно массивами.

using static System.Console;
Clear();
string[] arr = {"GB", "Geek", "Brains", "git", "5-4", "5 -4", "4к7н", ";)"};
printArray(arr);
Write(" -> ");
printArray(arrayFormation(arr));




string[] arrayFormation(string[] array2)
{
    int n = 0; 
    for (int i = 0; i < array2.Length; i++) {n += (array2[i].Length<4?1:0);} // определяем количество строк, длинна которых меньше 4
    string[] arrf = new string[n];
    int m = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i].Length < 4)
        {
            arrf[m] = array2[i];
            m++;
        }
    }
    return arrf;
}


void printArray(string[] array1)
{
    Write("[");
    for (int i = 0; i < array1.Length; i++)
    {   
        Write(i!=array1.Length-1?$"'{array1[i]}', ":$"'{array1[i]}'");
    }
    Write("]");
}

// P.S. В python всю красоту метода arrayFormation, скорее всего реализовал бы
// одной строкой: arrf = [i for i in arr if len(i) < 4]