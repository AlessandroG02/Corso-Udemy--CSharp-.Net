using System;

namespace Corso_02
{
   class MainClass
   {
     public static void Main(string[] args)
     {
            const string RESULT_CHARGE_LABEL = "carica batteria al";
            int batteryLevel;
            bool incharge;
            Random rnd;
            Random rndCharge;

            Console.WriteLine("Recupero valore batteria...");
             
            rnd = new Random(DateTime.Now.Second);
            batteryLevel = rnd.Next(0, 100);

            rndCharge = new Random(DateTime.Now.Second);
            incharge = rndCharge.Next(0, 1) <= 5;

            Console.Write($"Valore letto: {batteryLevel} ({ ( incharge ? "In carica" : "Non in carica") })");
            if ((batteryLevel >= 0) && (batteryLevel < 25))
                Console.ForegroundColor = ConsoleColor.Red;  
            else if ((batteryLevel >= 25) && (batteryLevel < 50))
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if ((batteryLevel >= 50) && (batteryLevel < 75))  
                Console.ForegroundColor = ConsoleColor.Green;       
            else         
                Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.WriteLine($" {RESULT_CHARGE_LABEL} {batteryLevel} %");
            if (incharge)
                Console.WriteLine("Caricamento in corso...");

            Console.ResetColor();
        }
   }
}
