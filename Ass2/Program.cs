using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;
using System.Numerics;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;

namespace Ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1 
            /*1.given an array  consists of  numbers with size n and
                        number of queries, in each query you will be given
                        an integer x, and you should print how many numbers
                        in array that is greater than  X ?*/

            //    int size = 3;
            //    int query = 3;
            //    int[] numbers={ 11, 5, 3 }; 
            //    int[] queries = { 1, 5, 13 }; 


            //    for (int i = 0; i < query; i++)
            //    {
            //        int x = queries[i]; 
            //        int count = 0;
            //        for (int j = 0; j < size; j++)
            //        {
            //            if (numbers[j] > x)
            //            {
            //                count++;
            //            }
            //        }


            //        Console.WriteLine(count);
            //    }
            //} 
            #endregion

            #region Question2
            /*2)Given a number N and an array of N numbers. 
                      Determine if it's palindrome or not.

                  int[] arr = { 1, 2, 3, 2, 1 };

                  int[] Copy = new int[arr.Length];
                  arr.CopyTo(Copy, 0);
                  Array.Reverse(arr);
                  bool isPlindrome = true;
                  for (int i = 0; i < arr.Length; i++)
                  {
                      if (arr[i] != Copy[i])
                      {
                          isPalindrome = false;

                      }
                  }
                  if (isPalindrome)
                  {
                      Console.WriteLine("YES");
                  }
                  else
                  {
                      Console.WriteLine("NO");
                  }*/
            #endregion

            #region Question3
            /*3)Given a Queue, implement a function to reverse
                   the elements of a queue using a stack.*/

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //Stack<int> stack = new Stack<int>();
            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}
            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}


            //Console.WriteLine("Revers Queue:");
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Question6
            //6)Given an array list, implement a function to remove
            //  all odd numbers from it.
            // static void RemoveOddNumber(ArrayList array)
            // {
            //    if (array is not null)
            //    {
            //        for (int i = 0; i < array.Count; i++)
            //        {
            //            if ((int)array[i] % 2 != 0)
            //            {
            //                array.RemoveAt(i);
            //            }
            //        }

            //    }
            //}
            //ArrayList arraylist = new ArrayList(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9 }

            //RemoveOddNumber(arraylist);
            //foreach(int i in arraylist)
            //{
            //    Console.WriteLine(i);
            //}  
            #endregion

            #region Question7
            /*7)Implement a queue that can hold different data types.
               And insert the following data:
                 queue.Enqueue(1)
                 queue.Enqueue(“Apple”)
                 queue.Enqueue(5.28)*/

            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);           
            //queue.Enqueue("Apple");     
            //queue.Enqueue(5.28);       


            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Question9
            /*8)Given two arrays, find their intersection.Each element in the 
               result should appear as many times as it shows in both arrays*/

            //int[] array1 = { 1, 2, 3, 4, 4 };
            //int[] array2 = { 10, 4, 4 };
            //int[] result;
            //int index = 0;
            //Console.WriteLine($"Array 1:{array1} ");
            //Console.WriteLine($"Array 2:{array2}");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    for (int j = 0; j < array2.Length; j++)
            //    {
            //        if (array1[i] == array2[j])
            //        {
            //            result[index] = array1[i];
            //            index++;
            //        }

            //    }
            //} 
            #endregion

            #region Question10
            /*10)Given an ArrayList of integers and a target sum, 
               find if there is a contiguous sub list that sums up to the target.*/

            //static ArrayList FindSub(ArrayList arr, int target)
            //{
            //    int currentSum = 0;
            //    int start = 0;


            //    for (int i = 0; i < arr.Count; i++)
            //    {

            //        currentSum += (int)arr[i];

            //        // إذا كان المجموع أكبر من الـ target، نبدأ في تقليص النطاق من البداية
            //        while (currentSum > target && start <= i)
            //        {
            //            currentSum -= (int)arr[start];
            //            start++;
            //        }


            //    }
            //} 
            #endregion

            #region Question11
            /*11)Given a queue reverse first K elements of a queue, 
                 keeping the remaining elements in the same order*/

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //int K = 3;
            //Stack<int> stack = new Stack<int>();


            //for (int i = 0; i < K; i++)
            //{
            //    stack.Push(queue.Dequeue());
            //}
            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //foreach (int i in queue)
            //{
            //    Console.Write(i);
            //} 
            #endregion

        }
    }
    }



        
 
    

