using System;
using System.Collections.Generic;
using System.Text;

namespace MaxMin
{
    public class Solution
    {
        public int[] orderNumbersBySeclectionSort(int[] numbers)
        {

            for(int i = 0; i < numbers.Length ; i++)
            {
                int indexMin = i;
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[j] < numbers[indexMin])
                    {
                        indexMin = j;
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[indexMin];
                numbers[indexMin] = temp;

            }
            return numbers;
        }
    }
}
