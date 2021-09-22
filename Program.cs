using System;

namespace bubble_sort_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = {8,22,5,14,4,32};

            for (int adim = 1; adim < 6; adim++)
            {
                for (int j = 0; j < 6-adim; j++)
                {
                    if (dizi[j] > dizi[j+1])
                    {
                        int araciEleman=dizi[j];
                        dizi[j] = dizi[j+1];
                        dizi[j+1] = araciEleman;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
