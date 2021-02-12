using System;

namespace HomePractice {
    class Program {
        static void Main(string[] args) {
            for (var idx = 1; idx < 31; idx++)
                if (idx % 3 == 0 && idx % 5 == 0)
                    Console.WriteLine($"{idx} is FIZZBUZZ");
                else if (idx % 3 == 0)
                    Console.WriteLine($"{idx} is FIZZ");
                else if (idx % 5 == 0)
                    Console.WriteLine($"{idx} is BUZZ");
                else
                    Console.WriteLine($"{idx}");
        }
            
            
            
            /* var trafficLight = "red";
            var command = (trafficLight == "red") ? "Stop" : "Go";
            Console.WriteLine($"The sign says {command}");
            */
            
            /*
            var stateCode = "OH";

                var stateName = stateCode switch {
                "OH" => "Ohio",
                "Ky" => "Kentucky",
                "IN" => "Indiana",
                _ => "not found"
        };
            Console.WriteLine($"stateCode is {stateCode}, Name is {stateName}");
            */
            
            
            
            
            
            
            
            
            /*var thriller = new Song {
                Title = "Thriller",
                Artist = "Michael Jackson",
                Genre = "Pop",
                Released = new DateTime(1984, 6, 1),
                Platinum = true
            };
            var thunderstruck = new Song { 
                Title = "Thunderstruck",
                Artist = "ACDC",
                Genre = "Rock",
                Released = new DateTime(1990, 1, 1),
                Platinum = true
            };
            var wastedOnTheWay = new Song {
                Title = "Wasted on the Way",
                Artist = "Crosby, Stills, and Nash",
                Genre = "Folk",
                Released = new DateTime(1982 ,12, 31),
                Platinum = false
            };

            var songs = new Song[] { thriller, thunderstruck, wastedOnTheWay };
            

            foreach(var Song in songs) {
                if (Song.Platinum == true) {
                    Console.WriteLine($"{Song.Title}");
                }
            }
            */
            /*
            var nbr = 1;
            while(nbr <= 25) {
                if(nbr % 2 != 0) {
                Console.WriteLine($"The number is {nbr * nbr * nbr}");

                }
                nbr++;
            }
            */
            /*
            var stateCode = "OH";
            var stateName = "";
            switch(stateCode) {
                case "IN": stateName = "Indiana"; break;
                case "KY": stateName = "Kentucky"; break;
                case "OH": stateName = "Ohio"; break;
                default: stateName = "not found"; break;
            }
            Console.WriteLine($"StateCode is {stateCode}, name is {stateName}");
            */
            /*
            var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
            var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
            var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };

            var sum = 0;
            foreach (var i in ints1) {
                sum += i;
            }
            Console.WriteLine($"sum is {sum}");

            var total = 0;
            foreach (var q in ints2) {
                if(q % 3 == 0) {
                    total += q;
                }
                
            }
            Console.WriteLine($"total is {total}");
            */
             
            
            
            //for (var idx = 0; idx < ints1.Length; idx++) {
            //    Console.WriteLine($"idx is {idx} and ints1[idx] is {ints1[idx]}");


        }

            
            //for (var idx = 0; idx < ints2.Length; idx++) {
            //    Console.WriteLine($"idx is {idx} and ints2[idx] is {ints2[idx]}");
            //}

           
            //for (var idx = 0; idx < ints3.Length; idx++) {
            //    Console.WriteLine($"idx is {idx} and ints 3[idx] is {ints3[idx]}");
            //}

            //var total = 0;
            //for (var idx = 0; idx < ints3.Length; idx++) {

            //    if (ints3[idx] % 2 == 1) {
            //        total = total + ints3[idx];
            //    }
                
            //}
            //Console.WriteLine($"Total of ints3 is {total}");

            //var total2 = 0;
            //for (var idx = 0; idx < ints1.Length; idx++) {
                
            //    if(ints1[idx] % 2 == 0) {
            //        total2 += ints1[idx];
            //    }
                
            //}
            //Console.WriteLine($"Total of ints1 is {total2}");

            //var total2 = 0;
            //for(var idx = 0; idx < ints1.Length; idx++) {
            //    total2 = total2 + ints1[idx];
            //}
            //Console.WriteLine($"Total of ints1 is {total2}");


    }       


  


