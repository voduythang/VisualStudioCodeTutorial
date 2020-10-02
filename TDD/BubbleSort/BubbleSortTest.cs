using System;
using System.Collections;
using NUnit.Framework;

namespace BubbleSort
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new []{2,1,3,4,5},new[]{1,2,3,4,5})]
        public void Test_BubbleSort(int[] startingArray, int[] expectedArray)
        {
            CollectionAssert.AreEqual(expectedArray, BubbleSort(startingArray));
        }

        public int[] BubbleSort(int[] arr)
        {
            for(int i = 0; i< arr.Length-1; i++)
            {
                if(arr[i]> arr[i+1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                }
            }   
            return arr;
        }
    }
}