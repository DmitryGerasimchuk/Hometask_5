// Задача № 1: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Проверка:
// [345, 897, 568, 234] -> 2

// Метод получения числа от пользователя 
int InputUser(string message)
{
    System.Console.Write($"{message} > ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

// Метод заполнения массива случайными трехзначными числами 
int[] FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    System.Console.WriteLine(); // Отступ строки (для красоты)
    return array;
}

// Метода, который показывает количество четных чисел в массиве
int ShowEvanNumbers(int[] array)
{
    int result = 0; // Инициализация переменной, в которой будем складывать результат
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + 1; // result++
        }
    }
    return result;
}

// Метод вывода на экран массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}

int userNumber = InputUser("Введите количество элементов в массиве");
int[] myArray = new int[userNumber];
FillArray(myArray);
PrintArray(myArray);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных чисел в массиве равно {ShowEvanNumbers(myArray)}.");