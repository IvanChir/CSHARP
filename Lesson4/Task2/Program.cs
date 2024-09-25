// Задача №2
// • Назовём число «интересным» если его сумма цифр чётная
// • Создать двумерный массив, состоящий из целых чисел. Вывести на экран «интересные» элементы массива



// скопировали функцию из предыдущего задания для создания двумерного массива из рандомных чисел и последующим выводом его. 
// изменили выборку: от 1 до 1000

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

// команда для ввывода двумерного массива состоящего из 3 строк и 4 цифр

int[,] matrix = CreateMatrix(3, 4);

// вывод массива в консоль

ShowMatrix(matrix);

// создаем цикл для перебора элементов массива для выявления "интересности"

foreach (int e in matrix)
{
    if (IsInteresting(e) == true) // функция IsInterestin создана ниже
    {
        Console.WriteLine(e);
    }
}

// создаем функцию IsInteresting для выявления суммы цифр числа (int value) на четность 

bool IsInteresting(int value)
{
    int sumOfDigit = GetSumOfDigit(value); // сумма цифр числа (int value) определяется функцией GetSumOfDigit (создана ниже)
    if (sumOfDigit % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}

// создаем функцию GetSumOfDigit 

int GetSumOfDigit(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10; // нахождение первой части числа
        value = value / 10; // нахождение следующей части числа
    }
    return sum;
}

