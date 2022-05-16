using System;
using System.Collections.Generic;
using System.Linq;

namespace OVNING2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ShowMainMeny();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        upprepaInput();
                        break;
                    case "3":
                        SplitSentence();
                        break;
                    default:
                        break;

                }
            }
            while (true);

        }

        private static void SplitSentence()
        {
            Console.WriteLine("write a sentence at least three words: ");
            var sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
               
            }
            Console.WriteLine("the third word is: "+words[2]);
        }

        private static void upprepaInput()
        {    int i;
            Console.WriteLine("write text that you to repeat 10 ");
            string input = Console.ReadLine();  
            for ( i = 0; i <= 10; i++)
            {
            Console.WriteLine($"output:{i}.{input}");
            }
          
        }

        private static void AddPerson()
        {    int age=0;
            int i = 0;
            List<double>  price= new List<double>() {80,90,120};
            List<double> totalPrice = new List<double>() { 0, 0, 0 };            
            do
            { 
                Console.WriteLine("write your age: , write -1 for Total Price");
                  
                    age = int.Parse(Console.ReadLine());
              

                if (age > 0&&age < 20)
                {
                    totalPrice[0] += price[0];
                    i++;
                }
                else if (age > 64)
                {
                    totalPrice[1] += price[1] ;
                   i++;
                }
                else if(age <= 64 && age>=20)
                {
                    totalPrice[2] += price[2] ;
                    i++;
                }
                else if(age==-1)
                { 
             
                Console.WriteLine("total price for child are :\n" + totalPrice[0]);
                Console.WriteLine("total price for old persons are :\n" + totalPrice[1]);
                Console.WriteLine("total price for adult are :\n" + totalPrice[2]);
                Console.WriteLine("numers of persons is: "+i);
                Console.WriteLine("total price  are :\n" +( totalPrice[0]+ totalPrice[1]+ totalPrice[2]));
                    break;
                }
               
            }
            while (true);  

        }

    private static void ShowMainMeny()
        {
            Console.WriteLine("0: quit");
            Console.WriteLine("1: book a ticket");
            Console.WriteLine("2: repreat the sentence 10 times");
            Console.WriteLine("3: SplitSentence");
        }
    }
}
