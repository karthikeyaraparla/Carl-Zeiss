 using System;
 //Insert at Position
 
 class  Array
 {
     static void Main()
     {
         int[] arr = { 1, 2, 3, 4 };
         int value = 5;
         int pos = 4;
         int[] newArr = new int[arr.Length + 1];
         for (int i = 0; i < newArr.Length; i++)
         {
             if (i < pos)
             {
                 newArr[i] = arr[i];
             }
             else if (i == pos)
             {
                 newArr[i] = value;
             }
             else if (i > pos)
             {
                 newArr[i] = arr[i - 1];
             }
         }

         foreach (int x in newArr)
         {
             Console.Write(x+" ");
         }
     }
 }

 //Delete an element in an array
 using System;

 class Del
 {
     public static void Main()
     {
         int[] array = { 1, 2, 3, 4, 5 };
         int pos = 4;
         int value = 5;
         int[] newArr = new int[array.Length - 1];
         for (int i = 0,j = 0; i < array.Length; i++)
         {
             if (i == pos)
             {
                 continue;
             }

             newArr[j] = array[i];
             j++;
         }

         foreach (int x in newArr)
         {
             Console.Write(x + " ");
         }
     }
     
 }
 //Search an Element
 using System;

 class Search
 {
     public static void Main()
     {
         int[] arr = { 1, 2, 3, 4 };
         int val = 5;
         bool found = false;
         for (int i = 0; i < arr.Length; i++)
         {
             if (val == arr[i])
             {
                 found = true;
                 break;
             }
         }

         if (found)
         {
             Console.WriteLine("Element found");
         }
         else
         {
             Console.WriteLine("Element not found");
         }

     }
 }

//Find Max and Min element

 int[] arr = { 1, 2, 3, 4 };

 int max = arr[0];
 int min = arr[0];
 for (int i = 1; i < arr.Length; i++)
 {
     if (arr[i] < min)
     {
         min = arr[i];
     }
     else if (arr[i] > max)
     {
         max = arr[i];
     }
 }
 Console.WriteLine("Maximum: " + max);
 Console.WriteLine("Minimum " + min);

//Reverse an Array
 using System;

 class Rev
 {
     public static void Main()
     {
         int[] arr = {1, 2, 3, 4};
         int start = 0;
         int end = arr.Length - 1;
         foreach (int x in arr)
         {
             Console.Write(x+ " ");
         }
         while (start < end)
         {
             int temp = arr[start];
             arr[start] = arr[end];
             arr[end] = temp;
             start++;
             end--;
         }

         foreach (int x in arr)
         {
             Console.Write(x+ " ");
         }
     }
 }