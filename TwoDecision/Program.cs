// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Введите данные через пробел");
string[] tempArray = Console.ReadLine().Split(' ').ToArray();
int count = 0;
for (int i = 0; i < tempArray.Length; i++)
{
    if (tempArray[i].Length <= 3) count++;
}
string[] result = new string[count];
for (int i = 0; i < result.Length; i++)
{
    for (int j = 0; j < tempArray.Length; j++)
    {
        if (tempArray[j].Length <= 3 && tempArray[j] != string.Empty)
        {
            result[i] = tempArray[j];
            tempArray[j] = string.Empty;
            break;
        }
    }
    Console.Write($"{result[i]} ");
}