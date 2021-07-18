using System;
using System.Linq;

namespace RegexValidatePinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "-000";
            //Main()
            
            Kata kata = new Kata();
            Console.WriteLine(kata.ValidatePin(pin));
            
        }
    }

    public class Kata
    {
        public  bool ValidatePin(string pin)
        {
            string input = pin;
            if ((input.Length == 4 || input.Length == 6) && (input.All(char.IsDigit)))
            {
                return true;
            }
            else
                return false;
        }
    }
}
