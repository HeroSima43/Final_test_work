// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayA = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");
    arrayA[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массив: " + '[' + string.Join(", ", arrayA) + ']');

int sum = 0;
for (int i = 0; i < size; i++)
{
    if (arrayA[i].Length <= 3)
    {
        sum = sum + 1;
    }
}

string[] arrayB = new string[sum];
int j = 0;

for (int i = 0; i < size; i++)
{
    if (arrayA[i].Length <= 3)
    {
        arrayB[j] = arrayA[i];
        j++;
    }
}

Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: " + '[' + string.Join(", ", arrayB) + ']');
