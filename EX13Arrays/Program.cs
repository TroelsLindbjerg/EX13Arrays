using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg.13
            
            //01.
            int[] ages = new int[5];
            ages[0] = 25;
            ages[1] = 28;
            ages[2] = 15;
            ages[3] = 35;
            ages[4] = 14;

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
            Console.WriteLine("");
            //02.
            string[] klasse = new string[] { "Rasmus", "Willian", "Troels", "Emil", "Niklas" };

            for (int k = 0; k < klasse.Length; k++)
            {
                Console.WriteLine(klasse[k]);
            }

            klasse[3] = "Kong Emil";
            for (int l = 0; l < klasse.Length; l++)
            {
                Console.WriteLine(klasse[l]);
            }
            Console.WriteLine("");

            //03.
            // hvis man har mange tal kan man skrive det sådan, så man ikke skal lave en int for hver.
            int[] numbers = new int[10] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };
            
            for (int p = 0; p < numbers.Length; p++)
            {
                Console.WriteLine(numbers[p]);
            }
            Console.WriteLine("");
            // Array.Sort kan man bruge for af sætte tal i rigtig rækkefølge fra lav til høj.
            Array.Sort(numbers);
            for (int p = 0; p < numbers.Length; p++)
            {
                Console.WriteLine(numbers[p]);
            }
            Console.WriteLine("");
            // Array.Reverse kan man bruge for at sætte tal i rigtig rækkefølge fra høj til lav.
            Array.Reverse(numbers);
            for (int p = 0; p < numbers.Length; p++)
            {
                Console.WriteLine(numbers[p]);
            }

            Console.WriteLine("");
            //0.4
            int[] number = new int[] { 32, 8, 74, 62, 86, 16, 76, 57, 46, 9 };

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = number[i] + 5;
                Console.WriteLine(number[i]);
            }
            

        }
    }
}
