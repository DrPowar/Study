using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Test
{
    class MargeSort
    {
        public List<int> Sort(List<int> items)
        {
            if(items.Count == 1)
            { 
                return items;
            }
            var mid = items.Count / 2;
            var left = items.Take(mid).ToList(); 
            var right = items.Skip(mid).ToList();

            return Marge(Sort(left), Sort(right));
        }

        private List<int> Marge(List<int> left, List<int> right)
        {
            var len = left.Count + right.Count;
            var leftPointer = 0;
            var rightPointer = 0;
            var sortList = new List<int>();

            for (int i = 0; i < len; i++)
            {
                if (leftPointer < left.Count && rightPointer < right.Count)
                {
                    if (left[leftPointer] < right[rightPointer])
                    {
                        sortList.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        sortList.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if(rightPointer < right.Count)
                    {
                        sortList.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        sortList.Add(left[leftPointer]);
                        rightPointer++;
                    }
                }
            }
            return sortList;
        }
    }
}
