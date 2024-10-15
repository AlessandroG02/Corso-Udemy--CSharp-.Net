using System;

namespace Corso_03
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            string myFirstName = "Alessandro";
            String myLastName = "Ganzit";
            DateTime myBirthday = new DateTime(2002, 4, 23);
            float myHeight = 1.83123F;
            byte myAge = Convert.ToByte(DateTime.Now.Year - myBirthday.Year);
            decimal myBigValue = 1231234124312.23234M;

            string text1 = "Ciao ! Mi chiamo " + myFirstName + " " + myLastName + ", tu come ti chiami?";

            string text2 = String.Format("Ciao ! Mi chiamo {0} {1}, tu come ti chiami?", myFirstName, myLastName);

            string text3 = $"Ciao! Mi chiamo {myFirstName}{myLastName}, tu come ti chiami?";

            string text4 = String.Format("Sono nato il {0:dd MMM} del {0: yyyy}", myBirthday);

            string text5 = $"Sono nato il {myBirthday: dd MMM} del {myBirthday: yyyy}";

            string text6 = $" Sono alto {myHeight:N2} cm";

            string text7 = $"Ho {myAge}";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
            Console.WriteLine(text5);
            Console.WriteLine(text6);
            Console.WriteLine(text7);


            Console.WriteLine($"Valore grande {myBigValue:###:000}");
            Console.WriteLine($"Valore grande {myBigValue:###:0}");
            Console.WriteLine($"Valore grande {myBigValue:E}");
            Console.WriteLine($"Valore grande {myBigValue:C2}");


            int index = text3.IndexOf("Mi");
            Console.WriteLine($"La posizione di \"Mi\" è {index}");
            Console.WriteLine($"Risultato: {text3.Substring(index, 2)}");

            Console.WriteLine($"{text3.Replace("Mi", "Ti")}");



        }
    }
}
