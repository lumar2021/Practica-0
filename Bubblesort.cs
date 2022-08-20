// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class Program
{
    static void Main(string [] args)
    {
      var timer = new Stopwatch();
    timer.Start();
    bubblesort();
    timer.Stop();



  
Console.WriteLine(timer.Elapsed.TotalSeconds);
Console.WriteLine(timer.Elapsed.TotalMilliseconds);
Console.WriteLine(timer.Elapsed.ToString());


    }

    public static void bubblesort()
    {
int numero=100000;
            int[] array=new int[numero];
            Random rnd = new Random();


            for (int j =0; j < numero; j++)
            {
                array[j]=rnd.Next();

            }

             for (int j = 0; j <= array.Length - 2; j++) {

            for (int i = 0; i <= array.Length - 2; i++) {

               if (array[i] > array[i + 1]) {
                  int temp= array[i + 1];
                  array[i + 1] = array[i];
                  array[i] = temp;

               }
            }
         }







    }
}


            
    

       
  //B: Run stuff you want timed

 


