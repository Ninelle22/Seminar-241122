// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]





void Fillarray (int[]arg)
{
    for (int i = 0; i<arg.Length; i++)
        arg [i] = new Random ().Next(-9, 10);
}

void PrintSumm (int[]arg)
{
    int summin = 0;
    int summax = 0;
    for (int i = 0; i<arg.Length; i++)
        {
            if (arg [i] > 0) 
                summax = summax + arg [i];
            else 
                summin = summin + arg [i];
        }
        Console.WriteLine ($"{summin} {summax}");
}

void Change (int[]arg)
{
    for (int i = 0; i<arg.Length; i++)
        arg [i] = - arg [i];
}  
int[] array = new int [12];
Fillarray (array);
Console.WriteLine (String.Join(", ", array));
Change (array); 
Console.WriteLine (String.Join(", ", array));