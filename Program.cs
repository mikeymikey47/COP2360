using System;
namespace DivisionConversionExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I must inquire thee. Shall thyself provide a first number?"); // number numero uno acquired
            string input1 = Console.ReadLine();

            Console.Write("I summon thee once more. Produce a second number, if thou may."); // number numero dos acquired
            string input2 = Console.ReadLine();

            try // here we go. scumbag detention protocol activated
            {
                int result = Divide(input1, input2);
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException) // uh oh, this number aint a number. uh uh, nope, not happening
            {
                Console.WriteLine("I must stop thee. Thy numbers mayhaps contain...corruption..");
            }
            catch (DivideByZeroException) // "911 whats ur emergency?" hi um this user is trying to divide by zero
            {
                Console.WriteLine("Dost thou believeth 0 a divisor? Thou art...wrong.");
            }
            catch (OverflowException) // the console is sickened by the user's greed. too many numbers!!!
            {
                Console.WriteLine("Thy number art as collosal as thy incompetence.");
            }
            catch (Exception ex) // what the hell happened here? w-what....wha? oh nah
            {
                Console.WriteLine($"Thou hast committed grave errors of calibers...unimagineable.");
                Console.WriteLine($"Thy punishment is...death. ");
            }
        }
        static int Divide(string a, string b)
        {
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            return num1 / num2;
        }
    }
}
            

