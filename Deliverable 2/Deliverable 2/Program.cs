using System;

namespace Deliverable2 
{
  class Program
  {
   static void Main(string[] args)
        {
           
         Console.WriteLine("Hi. Welcome to our Buffet. " +
                           "All you can eat for $9.99! We only charge extra for tea. " +
                           "How many people are in your group? Please, parties of 6 or lower.");
            int partysize = int.Parse(Console.ReadLine());

            
                if (partysize <= 6)
                {
                    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat. " +
                                      "Let's get everyone started with some drinks. We've got water or tea.");
                }
                else
                {
                    Console.WriteLine("Sorry, we can only seat up to 6 people.  Have a nice day.");
                    return;
                }
            
            double buffetprice = 9.99 * partysize;
            double drinkprice = 0.00;
            int numtea = 0;
            int numwater = 0;
            int i = 1;

            while (i <= partysize)
                {
                 Console.WriteLine("\nAlright person number " + i + ", water or tea?");
                 string drinkorder = Console.ReadLine();
                
                    if (drinkorder == "tea")
                        {
                             drinkprice += 1.50;
                             numtea++;
                             Console.WriteLine("\nTea? Okay!");
                        }
                    else if (drinkorder == "water")
                        {     
                             numwater++; 
                             Console.WriteLine("\nWater?  Nice choice!");
                        }
                    else 
                        {                             
                             Console.WriteLine("\nSorry, we don't have " + drinkorder);
                        }      
                i++;
                }


            Console.WriteLine("\nYou ordered " + numtea + " teas and " + numwater + " waters?" +
                              "  Okay, I'll be right back. Feel free to grab your food!");

            
            double totalprice = buffetprice + drinkprice;

            Console.WriteLine("\nYour order total is : $" + totalprice);           
        }

  }

}