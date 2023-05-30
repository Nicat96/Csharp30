namespace P235
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numbers1 = { 4, 5, 2, 6, 4, 3 };
            int[] numbers2 = { 7, 4, 2, 76, 45, 65 };

            List<int> uniqueElements = GetUniqueElements(numbers1, numbers2);

            Console.WriteLine("2-ci arrayda olmuyan reqemler");
            foreach (int element in uniqueElements)
            {
                Console.WriteLine(element);
            }
        }

        static List<int> GetUniqueElements(int[] array1, int[] array2)
        {
            List<int> uniqueElements = new List<int>();

            foreach (int num in array1)
            {
                if (!ArrayContains(array2, num) && !uniqueElements.Contains(num))
                {
                    uniqueElements.Add(num);
                }
            }

            return uniqueElements;
        }

        static bool ArrayContains(int[] array, int num)
        {
            foreach (int element in array)
            {
                if (element == num)
                {
                    return true;
                }
            }
            return false;
        }




    }






    }











