// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

Console.WriteLine($"Количество элементов массива: ");
int numberElements = int.Parse(Console.ReadLine());

int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.WriteLine("Массив: ");

    for (int i =0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);
        Console.WriteLine(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers = RandomNumbers(numberElements, 1, 10);
Console.WriteLine($"Сумма элементов на нечетных индексах: {randomNumbers}");