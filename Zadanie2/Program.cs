using System;

namespace Zadanie2{
    
    class Program{

        private static int[,] matrix = new int[10, 10];

        static void Main(string[] args){
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++){
                matrix[i, i] = i;
                sum += i;
            }
            
            printMatrix(matrix);
            Console.WriteLine(sum);
        }
        
        
        public static void printMatrix(int[,] matrix){
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}