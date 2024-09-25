// Задача №1
// Создать двумерный массив с размерами 3 x 5, состоящий из целых чисел
// Вывести его элементы на экран


// int[,] matrix = new int[3, 5];

// Random rnd = new Random();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }


// создаем функцию для рандомного заполнения двумерного массива от 1 до 11

int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

// создаем функцию для вывода в консоль созданного выше двумерного массива

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

// ввод команд для вывода двумерного массива состоящих из 4 строк, заполнего 5 рандомными числами

int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);