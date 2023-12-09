//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
//с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System.Reflection.Metadata.Ecma335;

void PrintArray(string[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
    if (i < array.Length-1 )
    {
        System.Console.Write($"{array[i]} ");
    }
    }
    System.Console.WriteLine();
}


string[] CreateArray(string[] array)
{
    string[] newArray = new string[array.Length];
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
string[] arr1 = {"1234", "1567", "-2", "computer science", "12", "2","123"} ;
PrintArray(arr1);
string[] arr2 = CreateArray(arr1);
PrintArray(arr2);