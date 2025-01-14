namespace HW_2;

class Program
{
    public static void Main(string[] args)
    {
        int[,] Arr = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        Console.WriteLine("Исходный массив\n");
        PrintArray(Arr);

        int y = Arr.GetLength(0);
        int x = Arr.GetLength(1);
        int[] sortArr = new int[x * y];

        int count = 0;

        foreach (var item in Arr)
        {
            sortArr[count] = item;
            count++;
        }

        count = 0;

        Array.Sort(sortArr);

        for (int n = 0; n < y; n++)
        {
            for (int m = 0; m < x; m++)
            {
                Arr[n, m] = sortArr[count];
                count++;
            }
        }

        Console.WriteLine("Сортированный массив\n");
        PrintArray(Arr);

    }
    static void PrintArray(int[,] tmpArr)
    {
        int i = 0;

        foreach (var item in tmpArr)
        {
            Console.Write(item + " ");
            i++;
            if (i % tmpArr.GetLength(1) == 0)
            {
                Console.WriteLine();
                i = 0;
            }
        }
        Console.WriteLine();
    }
}