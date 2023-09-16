// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3


int inputSize(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] array;

int Kolichestvo (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count +=1;
    } return count;
}

void PrintArray(int[] newArray)
{   Console.WriteLine("Ваш массив:");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i]+" ");
    } 
}


int size = inputSize("Введите количество чисел");
array = new int[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите число {i+1}");
    array[i]= int.Parse(Console.ReadLine()!);
    
}

int count = Kolichestvo(array);
PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine($"Количество положительных чисел: {count}");