using System;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {

                Console.WriteLine("Welcome to the Temp Converter! Please enter a temperature.");
                double temp = double.Parse(Console.ReadLine());

                Console.WriteLine("What unit is that? (F = Fahrenheit, C = Celsius)");
                string unit = Console.ReadLine();

                //Output for F
                if (unit == "Fahrenheit" || unit.ToUpper() == "F")
                {
                    Console.WriteLine(temp + " " + "degrees Fahrenheit is");
                    Console.WriteLine(Fahrenheit(temp) + " " + "degrees Celsius");
                   if (Fahrenheit(temp) > 26.7)
                    {
                    Console.WriteLine("Thats really warm!");
                    }

                }
                //Output for C
                else if (unit == "Celsius" || unit.ToUpper() == "C")
                {
                    Console.WriteLine(temp + " " + "degrees Celsuis is");
                    Console.WriteLine(Celsius(temp) + " " + "degrees Fahrenheit");
                  if (Celsius(temp) > 80.0)
                    {
                    Console.WriteLine("Thats really warm!");
                    }

                }
                


                //Continue Loop
                while (true)
                {
                    Console.WriteLine("Would you like to convert another temp? y/n");
                    string input = Console.ReadLine();
                    
                    if (input.ToLower() == "y")
                    {
                        goOn = true;
                        break;
                    }
                    else if (input.ToLower() == "n")
                    {
                        Console.WriteLine("Good Bye!");
                        goOn = false;
                       
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry I didnt understand that lets try again");
                    }
                }


            }
        }
            //Converts from F to C Method
            public static double Fahrenheit(double F)
            {
                double C = (F - 32.0) * (5.0 / 9.0);
               
                return C = (double)Math.Round(C, 1); //Round to one decimal place
            }
            //Converts from C to F Method
            public static double Celsius(double C)
            {
                double F = C * (9.0 / 5.0) + 32;
              
                return F = (double)Math.Round(F, 1); // Round to one decimal place
            }


        

        }
}
