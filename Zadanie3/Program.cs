using System;

namespace Zadanie3{
    class Program{
        private static int[] tablica = new int[100];

        static void Main(string[] args){
            for (int i = 0; i < tablica.Length; i++){
                tablica[i] = i + 1;
            }

            int evenSum = 0;
            int oddSum = 0;
            
            foreach (int i in tablica){
                if (i % 2 == 0){
                    evenSum += i;
                    continue;
                }
                oddSum += i;
            }
            
            Console.WriteLine("Suma liczb parzystych: " + evenSum);
            Console.WriteLine("Suma liczb nieparzystych: " + oddSum);
            
            
        }
    }
}