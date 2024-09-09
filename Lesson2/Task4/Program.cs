// Задача №3
// Дано N гирь с разным весом в случайном порядке. Определить вес самой тяжелой гири.


int n = 5;
int[] array = { 2, 3, 10, 7, 8 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);