using System;
using System.Collections;
using System.Collections.Generic;

namespace Zadanie4{
    class Program{

        private static ArrayList lista = new ArrayList();
        
        static void Main(string[] args){
            lista.Add("Gdańsk");
            lista.Add("Warszawa");
            lista.Add("Katowice");
            lista.Add("Poznań");
            lista.Add("Kraków");
            lista.Add("Rzeszów");

            Console.WriteLine(string.Join(", ", lista.ToArray()));
            lista.Sort();
            Console.WriteLine(string.Join(", ", lista.ToArray()));
        }
    }
}