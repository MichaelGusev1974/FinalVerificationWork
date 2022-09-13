// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = new string[] {"1" , "22" , "333" , "4444" , "55555" , "666666"}; 
string[] newArray = new string[array.Length];


void FormingArrayOfThreeOrFewerRows(string[] array1, string[] array2) // Метод, формирующий из имеющегося массива строк  новый массив из строк, длина которых меньше, либо равна 3 символам.
{
    int count = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array) // Метод, печатающий наш массив.
{
     int count = array.Length;
     for(int i = 0; i < count; i++)
     {
         Console.Write($"{array[i]} ");
     }
     Console.WriteLine();
}  
PrintArray(array);
FormingArrayOfThreeOrFewerRows(array, newArray);
PrintArray(newArray);