namespace P235
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,12,15,20 };

            FilterEvenNumbers(ref numbers);

            Console.WriteLine("Yeni Array (Cut Reqemler):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        static void FilterEvenNumbers(ref int[] array)
        {
            int evenCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[evenCount] = array[i];
                    evenCount++;
                }
            }

            Array.Resize(ref array, evenCount);
        }






    }





    }
    





