using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtnNumbers
{
    class Program
    {

        public static void Main()
        {

            int[] Num = new int[10];
            Num[0] = 1;
            Num[1] = 2;
            Num[2] = 3;
            Num[3] = 4;
            Num[4] = 5;
            Num[5] = 6;
            Num[6] = 7;
            Num[7] = 8;
            Num[8] = 9;
            Num[9] = 0;
            
            Random ramdom0 = new Random();
            Random ramdom1 = new Random();
            Random ramdom2 = new Random();
            Random ramdom3 = new Random();
            Random ramdom4 = new Random();
            Random ramdom5 = new Random();
            Random ramdom6 = new Random();
            Random ramdom7 = new Random();
            Random ramdom8 = new Random();
            Random ramdom9 = new Random();


            
            //int number0 = ramdom9.Next();
            //int number1 = ramdom8.Next();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                 MTN NUMBERS GENERATING MACHINE");
            Console.WriteLine("                ---------------------------------\n\n");
            Console.WriteLine("Enter P to Generate MTN Phone Numbers\n");
            Console.WriteLine("Enter R to Generate MTN Reachage Numbers\n");
            string UserAnswer = Console.ReadLine().ToUpper();
            switch (UserAnswer)
            {
                case "P":
                    goto PhoneNumbers;
                    
                case "R":
                    Program.RechargeNumbers();
                    break;
            }
        PhoneNumbers:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n");
            Console.WriteLine("How Many Numbers do you want to generate ?");
            int UserNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The first FOUR NUMBERS that you want");
            int FourNum = int.Parse(Console.ReadLine());

          
            for (int i = 0; i < UserNumber; i++)
            {
                int number0 = ramdom9.Next(0, 8);
                int number1 = ramdom8.Next(1, 5);
                int number2 = ramdom7.Next(Num.Length);
                int number3 = ramdom6.Next(1, 9);
                int number4 = ramdom5.Next(2, 7);
                int number5 = ramdom4.Next(3, 7);
                int number6 = ramdom3.Next(Num.Length);
                int number7 = ramdom2.Next(0, 9);
                int number8 = ramdom1.Next(2, 9);
                int number9 = ramdom0.Next(Num.Length);

                Console.WriteLine("{0}-{1}{2}{3}{4}{5}{6}{7}",FourNum, Num[number1], Num[number2], Num[number3], Num[number4], Num[number5], Num[number6], Num[number9]);
                
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n");
            Console.WriteLine("{0} Numbers Has been generated", UserNumber);
            Console.WriteLine("\n");
            Console.WriteLine("Press M to go back to the main MENU or E to END the program");
            string Udecision = Console.ReadLine().ToUpper();
            switch (Udecision)
            {
                case "M":
                    Program.Main();
                    break;
                case "E":
                    break;
            }

            //Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", Num[number0], Num[number1], Num[number2], Num[number3], Num[number4], Num[number5], Num[number6], Num[number7], Num[number8], Num[number9]);
        }
        public static void RechargeNumbers()
        {
            int[] Num = new int[12];
            Num[0] = 1;
            Num[1] = 2;
            Num[2] = 3;
            Num[3] = 4;
            Num[4] = 5;
            Num[5] = 6;
            Num[6] = 7;
            Num[7] = 8;
            Num[8] = 9;
            Num[9] = 0;
            Num[10] = 8;
            Num[11] = 4;
            
            Random ramdom0 = new Random();
            Random ramdom1 = new Random();
            Random ramdom2 = new Random();
            Random ramdom3 = new Random();
            Random ramdom4 = new Random();
            Random ramdom5 = new Random();
            Random ramdom6 = new Random();
            Random ramdom7 = new Random();
            Random ramdom8 = new Random();
            Random ramdom9 = new Random();
            Random ramdom10 = new Random();
            Random ramdom11 = new Random();



            //int number0 = ramdom9.Next();
            //int number1 = ramdom8.Next();


            Console.WriteLine("How Many Numbers do you want to generate ?");
            int UserNumber = int.Parse(Console.ReadLine());
            


            for (int i = 0; i < UserNumber; i++)
            {
                int number10 = ramdom11.Next(2, 9);
                int number11 = ramdom10.Next(Num.Length);
                int number0 = ramdom9.Next(0, 8);
                int number1 = ramdom8.Next(1, 5);
                int number2 = ramdom7.Next(Num.Length);
                int number3 = ramdom6.Next(1, 9);
                int number4 = ramdom5.Next(2, 7);
                int number5 = ramdom4.Next(3, 7);
                int number6 = ramdom3.Next(Num.Length);
                int number7 = ramdom2.Next(0, 9);
                int number8 = ramdom1.Next(2, 9);
                int number9 = ramdom0.Next(0, 9);
                

                Console.WriteLine("{0}{1}{2}{3}-{4}{5}{6}{7}-{8}{9}{10}{11}", Num[number1], Num[number0], Num[number2], Num[number3], Num[number4], Num[number5], Num[number6],Num[number7], Num[number8], Num[number9],Num[number10], Num[number11]);

            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n");
            Console.WriteLine("{0} Reacharge Numbers Has been generated", UserNumber);
            Console.WriteLine("\n");
            Console.WriteLine("Press M to go back to the main MENU or E to END the program");
            string Udecision = Console.ReadLine().ToUpper();
            switch (Udecision)
            {
                case "M":
                    Program.Main();
                    break;
                case "E":
                    break;
            }
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace MtnNumbers
//{
//    class Program
//    {

//        public static void Main()
//        {


//            int job = 10;
//            int[] Numgen = new int[job];
//            Random ramdom0 = new Random();


//            for (int i = 0; i <= Numgen.Length; i++)
//            {


//                Numgen[i] = (int)ramdom0.Next();
//                Console.WriteLine(Numgen[i]);

//            }


//        }
//    }
//}
