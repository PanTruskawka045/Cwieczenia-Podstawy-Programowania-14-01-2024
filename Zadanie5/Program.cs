using System;
using System.Runtime.InteropServices;

namespace Zadanie5{
    class Program{
        
        private static int[,] matrixA = new int[10, 10];
        private static int[,] matrixB = new int[10, 10];
        
        static void Main(string[] args){

            fillMatricies();
            
            if(matrixA.GetLength(0) != matrixB.GetLength(0) || matrixA.GetLength(1) != matrixB.GetLength(1)){
                Console.WriteLine("Macierze nie są tego samego rozmiaru!");
                return;
            }
            int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            
            for (int i = 0; i < matrixA.GetLength(0); i++){
                for (int j = 0; j < matrixA.GetLength(1); j++){
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            
            Console.WriteLine("Macierz A:"); 
            printMatrix(matrixA);
            Console.WriteLine("Macierz B:");
            printMatrix(matrixB);
            Console.WriteLine("Macierz A+B:");
            printMatrix(matrixC);
        }

        private static void fillMatricies(){
            for (int i = 0; i < matrixA.GetLength(0); i++){
                for (int j = 0; j < matrixB.GetLength(1); j++){
                    matrixA[i, j] = 1;
                }
            }
            
            for (int i = 0; i < matrixB.GetLength(0); i++){
                for (int j = 0; j < matrixB.GetLength(1); j++){
                    matrixB[i, j] = 2;
                }
            }
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