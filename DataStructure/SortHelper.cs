using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SortHelper
    {
        // Bubble Sort
        public static int[] BubbleSort(int[] inputList)
        {
            if (inputList == null || inputList.Count() == 0)
                throw new Exception("Invalid input");

            // If list count is 1, return the same list
            if (inputList.Count() == 1) return inputList;

            bool swaped;
            for (int i = 0; i < inputList.Count()-1; i++)
            {
                swaped = false;
                for (int j = 0; j < inputList.Count() - 1; j++)
                {
                    // Compare the element with next element
                    if (inputList[j] > inputList[i + 1])
                    {
                        var temp = inputList[j];
                        inputList[j] = inputList[i + 1];
                        inputList[i + 1] = temp;
                        swaped = true;
                    }
                }
                // There is no swapping happned in iteration, which means all the elements are already sorted
                if (!swaped) return inputList;
            }
            
            return inputList;
        }
    }
}
