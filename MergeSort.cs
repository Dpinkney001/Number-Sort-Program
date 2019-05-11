using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 
 * Author: Duvall Pinkney 5/8/2019
 * email: duvall.Pinkney@gmail.com
 */
namespace Number_Sort_Program_Version_3
{
    class MergeSort : Number_Sort_Main 
    {
        public mergeSort(int[] anArray)
        {
            int[] mergeSortArray = null;
            public void merge(int[] bigArray, int[] firstHalf, int[] lastHalf)
            {
                //need 3 vars
                int indexLH = 0;
                int indexFH = 0;
                int indexBigArray = 0;

                //while index of FH < FH.length && INDEX OF LH < LH length
                // compare value at current index AGAINST VALUE AT CURR INDEX OF LH
                // copy the lesser of the two into the larger array and increment index
                // increment index

                while ((indexFH < firstHalf.Length) && (indexLH < lastHalf.Length))
                {
                    if (indexFH < firstHalf[indexFH])
                    {
                        bigArray[indexFH] += bigArray[indexFH++];
                    }
                }

                // let's just say one of hte arrays hit the end.. no more values to compare
                // while FH index < FH length.....
                //copy all FH values incrementing indexes along the way

            }

        // recursive method merge sort... that use split and merge to accomplish sorting
        public void mergeSort(int[] anArray)
        {
            if (anArray.Length >= 2)
            {
                int halfLength = anArray.Length / 2;
                int[] firstHalf = new int[halfLength];
                int[] lastHalf = new int[anArray.Length - halfLength];
                mergeSortArray = merge(anArray, firstHalf, lastHalf);
                mergeSort(firstHalf);
            }

        }
    }
                return mergeSortArray;
            }// end mergesort Array

        }
    }
}
