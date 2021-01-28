using System;

namespace Alder_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast dit navn");    //udskriver en besked til brugeren
            String navn = Console.ReadLine();         /* erklærer en variabel og giver den brugerens input som værdi
                                                       * her skal der ikke konverteres da den erklærede variabel er en string*/
            Console.WriteLine("Indtast din alder");
            int alder = int.Parse(Console.ReadLine());

            AlderTest(navn, alder);

            
        }
        public static void AlderTest(string navn, int alder)
        {
            if (alder < 3)
            {
                Console.WriteLine("{0}, du må gå med ble", navn); //hvis alderen er mindre end 3 udføres denne linje kode
            }
            else if (alder <= 15)
            {
                Console.WriteLine("{0} du må ingenting", navn);
            }
            else if (alder < 18) //behøver ikke sætte grænsen til 3 da der allerede er tjekket for mindre end 3 ovenfor
            {
                Console.WriteLine("{0}, du må drikke", navn);
            }
            else if (alder >= 18)
            {
                Console.WriteLine("{0}, du må stemme og køre bil", navn);
            }

        }
    }
}
