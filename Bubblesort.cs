using System.Diagnostics;

class Program
{
    static void Main(string [] args)
    {

    var clock = new Stopwatch();
    clock.Start();
    bubblesort();
    clock.Stop();

    Console.WriteLine(clock.Elapsed.TotalSeconds);
    Console.WriteLine(clock.Elapsed.TotalMilliseconds);
    Console.WriteLine(clock.Elapsed.ToString());
    }
    public static void bubblesort()
    {

int numero=1000;
            int[] array=new int[numero];
            Random random = new Random();

            for (int j =0; j < numero; j++)
            {
                array[j]=random.Next();
            }

             for (int j = 0; j <= array.Length - 2; j++) {

            for (int i = 0; i <= array.Length - 2; i++) {

               if (array[i] > array[i + 1]) {
                  int temporal= array[i + 1];
                  array[i + 1] = array[i];
                  array[i] = temporal;

               }
            }
         }
    }
}
 


