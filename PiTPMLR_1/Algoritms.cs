using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiTPMLR_1
{
    public class Algoritms
    {
        public static string ShellSort(int[] input, bool asc)
        {
            int[] arr = input;
            bool ascending = asc;

            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    if (ascending)
                    {
                        for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        {
                            arr[j] = arr[j - gap];
                        }
                    }
                    else
                    {
                        for (j = i; j >= gap && arr[j - gap] < temp; j -= gap)
                        {
                            arr[j] = arr[j - gap];
                        }
                    }
                    arr[j] = temp;
                }
                gap /= 2;
            }
            return string.Join(",", arr);
        }
        public static string SwapSort(int[] input, bool asc)
        {
            int[] arr = input;
            bool ascending = asc;

            int n = arr.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (ascending && arr[i - 1] > arr[i] || !ascending && arr[i - 1] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
            return string.Join(",", arr);
        }

        public static string SelectSort(int[] input, bool asc)
        {
            int[] arr = input;
            bool ascending = asc;

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minOrMaxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    bool swap = ascending ? arr[j] < arr[minOrMaxIndex] : arr[j] > arr[minOrMaxIndex];
                    if (swap)
                    {
                        minOrMaxIndex = j;
                    }
                }
                if (minOrMaxIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minOrMaxIndex];
                    arr[minOrMaxIndex] = temp;
                }
            }
            return string.Join(",", arr);
        }
    }
}
