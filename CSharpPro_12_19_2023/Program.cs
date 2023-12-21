using System.Transactions;

namespace Lesson
{
    public class Program
    {
       public static void Main()
        {
            try
            {
                Console.WriteLine("Enter first number");
                double firstNuber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter first number");
                double secondNuber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter math acton");
                var mathAction = Console.ReadLine();


                switch (mathAction)
                {
                    case "+":
                        Console.WriteLine(firstNuber + secondNuber);
                        break;
                    case "-":
                        Console.WriteLine(firstNuber - secondNuber);
                        break;
                    case "*":
                        Console.WriteLine(firstNuber * secondNuber);
                        break;
                    case "/":
                        Console.WriteLine(firstNuber / secondNuber);
                        break;
                    default:
                        Console.WriteLine("You enter wrong math action");
                        break;

                }
            
            }
            catch (FormatException)
            { 
                Console.WriteLine("You need enter numbers");
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.ToString());
            }
           

        }
    }
    
}