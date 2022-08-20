using System.Diagnostics;
class Program 
{
    public static void Main(string[] args)
    {

        int number=10000000;
            int[] array=new int[number];
            Random random = new Random();

            for (int j =0; j < number; j++)
            {
                array[j]=random.Next();

            }

        var clock = new Stopwatch();
    clock.Start();

        Quicksort(array, 0, number-1);
        clock.Stop();

Console.WriteLine(clock.Elapsed.TotalSeconds);
Console.WriteLine(clock.Elapsed.TotalMilliseconds);
Console.WriteLine(clock.Elapsed.ToString());
    }
    public static void Quicksort(int[] numbers, int left, int right)
{
    int i = left;
    int j = right;

    var pivot = numbers[(left + right) / 2];

    while(i <= j)
    {
        while (numbers[i] < pivot)
            i++;

        while (numbers[j] > pivot)
            j--;

        if(i <= j)
        {
            var temporal = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temporal;

            i++;
            j--;
        }
    }

    if (left < j)
        Quicksort(numbers, left, j);

    if (i < right)
        Quicksort(numbers, i, right);
    }
}
