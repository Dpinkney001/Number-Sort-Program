using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Sort_Program_version_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());




            
                    public int [] multiplyArray(int array[],int multiplierValue)
                    {

                        int newArray [] = null;
                        for (int item = 0; item < array.length; item++)
                        {
                            array[item] = item * multiplierValue; 
                            newArray[item] = array[item];
                        }
                        return newArray;
                    }

                    public mergeSort(int array [])
                    {
                        private static void merge(int [] bigArray, int [] firstHalf, int [] lastHalf)
                        {
                            //need 3 vars
                             int indexLH = 0;
                             int indexFH = 0;
                             int indexBigArray = 0;



                            //while index of FH < FH.length && INDEX OF LH < LH length
                            // compare value at current index AGAINST VALUE AT CURR INDEX OF LH
                            // copy the lesser of the two into the larger array and increment index
                            // increment index

                             while ((indexFH < firstHalf.length) && (indexLH < lastHalf.length))
                             {
                                 if(indexFH < firstHalf[indexFH])
                                 {

                                 }
                             }

                            // let's just say one of hte arrays hit the end.. no more values to compare
                            // while FH index < FH length.....
                            //copy all FH values incrementing indexes along the way

                        }

                        // recursive method merge sort... that use split and merge to accomplish sorting
                        public statyic void mergeSort(int [] anArray)
                        {
                            if(anArray.length >= 2)
                            {
                                int halfLength = anArray.length/2;
                                int[] firstHalf = new int[halfLength];
                                int[] lastHalf = new int[anArray.length - halfLength];
                                split(anArray, firstHalf, lastHalf);
                                mergeSort(firstHalf);
                            }
                        }
                    }


                        return mergeSortArray;
                    }
                    public bubbleSort(int array [] )
                    {

                        private static int sweap(int array, int a, int b)
                        {
                            int temp = array[a];
                            array[a] = array[b];
                            array[b] = temp;
                        }
                        //bubble s ort
                        public static void bubblesort(int [] array)
                        {
                            boolean notSorted;
                            {
                                for(int i=0; i<array.length-1; i++)
                                {
                                    int j = i+1;
                                    if ( (array[i] > array[j] )){
                                        swap(array, i, j);
                                        notSorted=true;

                                    }
                                }
                            }
                        return bubbleSortArray;
                    }
                    public linearSearch( int array [])
                    {
                        return linearSearchArray;
                    }

                         public static int  binarySearch(int array [], int startI, int match, int endI)
                            {
                                int midpoint =(startI + endI)/2;
                                if (startI > endI)
                                {
                                    return -1;
                                }
                                // midpoint is start + end divided by tw
                                else if(match == arr[midpoint])
                                {
                                    return midpoint;// found the value... reurn index;
                                }
                                else if(match > arr[midpoint])
                                {
                                    return binarySearch(arr, match, (midpoint+1), endI);
                                }
                                else{
                                    return binarySearch(arr, match, startI, (midpoint -1));

            
        }
    }
}
