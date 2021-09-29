using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    var temp = 0;
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp = 0;
                int smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
                Console.WriteLine(arr[i]);
            }
        }
        public static void Insertion(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j].CompareTo(arr[j - 1]) < 0)
                {
                    Swap(arr, j, j - 1);
                    j--;
                }
            }
        }

        private static void Swap <T>(T[] arr, int first, int second)
        {
            T temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;  
        }


        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            decimal midpoint = arr.Length / 2;
            var mid = Convert.ToInt32(Math.Ceiling(midpoint));

            var bot = arr.Take(mid).ToArray();
            var top = arr.Skip(mid).ToArray();

            var botOut = MergeSort(bot);
            var topOut = MergeSort(top);

            var combined = Combine(botOut, topOut);

            return combined;
        }

        public static int[] Combine(int[] bottom, int[] top)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var arr = new int[bottom.Length + top.Length];

            while (i < bottom.Length && j < top.Length)
            {
                if (bottom[i] < top[j])
                {
                    arr[k] = bottom[i];
                    i++;
                }
                else
                {
                    arr[k] = top[j];
                    j++;
                }

                k++;
            }

            while (i < bottom.Length)
            {
                arr[k] = bottom[i];
                i++;
                k++;
            }
            while (j < top.Length)
            {
                arr[k] = top[j];
                j++;
                k++;
            }
            return arr;
        }
    }
}
