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
            for(var i = 0; i < arr.Length - 1; i++)
            {
                for (var k = 0; k < arr.Length - 1 - i; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        var temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
        }

        public static void Selection(int[] arr)
        {
            throw new NotImplementedException();
        }

        public static void Insertion(int[] arr)
        {
            throw new NotImplementedException();
        }

        public static void MergeSort(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
