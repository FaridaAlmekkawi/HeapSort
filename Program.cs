namespace Heap_sort
{
    internal class Program
    {


        class HeapSort
        {
         
            static void Heaped(int[] arr, int n, int i)
            {
                int largest = i; 
                int left = 2 * i + 1;  
                int right = 2 * i + 2;   
                if (left < n && arr[left] > arr[largest])
                    largest = left;

                if (right < n && arr[right] > arr[largest])
                    largest = right;

                // If largest is not root
                if (largest != i)
                {
                    // Swap arr[i] and arr[largest]
                    int temp = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = temp;

                    // Recursively heaped the affected subtree
                    Heaped(arr, n, largest);
                }
            }

           
            static void BuildMaxHeap(int[] arr, int n)
            {
                
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    Heaped(arr, n, i);
                }
            }

        
            static void HeapSortAlgorithm(int[] arr)
            {
                int n = arr.Length;
                BuildMaxHeap(arr, n);
                for (int i = n - 1; i > 0; i--)
                {
                    // Swap the current root (maximum element) with the last element
                    int temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;
                    Heaped(arr, i, 0);
                }
            }
            static void PrintArray(int[] arr)
            {
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            static void Main()
            {
                Console.WriteLine("Enter the number of elements in the array:");
                int n = int.Parse(Console.ReadLine());


                int[] arr = new int[n];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Original Array:");
                PrintArray(arr);

                HeapSortAlgorithm(arr);

                Console.WriteLine("Sorted Array:");
                PrintArray(arr);
            }
        }

    }
}
