using System.Diagnostics;

namespace ArrayWorkerLibrary
{
    public class ArrayWorker
    {
        public int[] MyArray { get; set; }

        public ArrayWorker(int[] myArray) { 
        
            this.MyArray = myArray;
        }

        public int[] InvertArray(int[] myArray) {
        int length = myArray.Length;
            int[] invertedArray = new int[length];

            for(int i = 0; i < length; i++)
            {
                invertedArray[i] = myArray[length - 1 - i];
            }
            return invertedArray;
        }
    }
}