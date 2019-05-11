using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Sort_Program_version_2
{
    static class Number_Sort_Main : MainForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            createFile();

            // Take input from inputTextBox and feed it as incoming
            // array[] 
            int inputArray[] = null;
            inputArray = inputTextBox.Text;
            int number = multiplierTextBox.Text;

            multiplyArray(inputArray, number);


           }// end Main()

        public void createFile(){

         //open file and print to file
            String fileName = "Outputfile.txt";
            StreamReader stream = null;

            try{
                using(stream = new StreamReader(fileName));

                outputTextBox.AppendText();
                }
            catch{(IOException IOE);{
                 }
            }// end createFile method

            //method that multiplies elements in the array
            public class multiplyArray()
            {
                public multiplyArray(int array[], int multiplierValue)
                {
            int newArray[] = null;
            for (int item = 0; item < array.length; item++)
            {
                array[item] = item * multiplierValue;
                newArray[item] = array[item];
            }
            // print to file
            outputTextBox.AppendText(newArray);

            //return array to screen
            return newArray;
        }
                
            }// end multiply array

            //merge sort elements in the array
            //return result

           
            public class bubbleSort(int array [] )
            {

                public int sweap(int array, int a, int b)
                {
                    int temp = array[a];
                    array[a] = array[b];
                    array[b] = temp;
                }
                //bubble s ort
                public void bubblesort(int [] array)
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
            }// end bubblesortArray



            public linearSearch( int array [])
            {
                return linearSearchArray;
            }// end linear search

                    public int  binarySearch(int array [], int startI, int match, int endI)
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
                     }// end binary Search
