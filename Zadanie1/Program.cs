using System;

namespace Zadanie1{
    
    class Program{
        private static int[] array = new int[10];
        
        static void Main(string[] args){
            for (int i = 0; i < array.Length; i++){
                array[i] = i;
            }
            printArray(array);
        }
        
        public static void printArray(int[] array){
            Console.WriteLine(string.Join(" ", array));
        }
    }
}