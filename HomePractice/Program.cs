using System;

namespace HomePractice {
    class Program {
        static void Main(string[] args) {
            var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
            for (var idx = 0; idx < ints1.Length; idx++) {
                Console.WriteLine($"idx is {idx} and ints1[idx] is {ints1[idx]}");


            }

            var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
            for (var idx = 0; idx < ints2.Length; idx++) {
                Console.WriteLine($"idx is {idx} and ints2[idx] is {ints2[idx]}");
            }

            var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };
            for (var idx = 0; idx < ints3.Length; idx++) {
                Console.WriteLine($"idx is {idx} and ints 3[idx] is {ints3[idx]}");
            }

            var total = 0;
            for (var idx = 0; idx < ints3.Length; idx++) {

                if (ints3[idx] % 2 == 1) {
                    total = total + ints3[idx];
                }
                
            }
            Console.WriteLine($"Total of ints3 is {total}");

            var total2 = 0;
            for (var idx = 0; idx < ints1.Length; idx++) {
                
                if(ints1[idx] % 2 == 0) {
                    total2 = total2 + ints1[idx];
                }
                
            }
            Console.WriteLine($"Total of ints1 is {total2}");

            //var total2 = 0;
            //for(var idx = 0; idx < ints1.Length; idx++) {
            //    total2 = total2 + ints1[idx];
            //}
            //Console.WriteLine($"Total of ints1 is {total2}");


        }       


    }
}
