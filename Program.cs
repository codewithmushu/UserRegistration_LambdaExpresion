using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isValidFirstName = s => Regex.IsMatch(s, @"^[A-Z][a-z]*$");


            string firstName = "Muskan";
            if (isValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }



            Func<string, bool> isValidLastName = s => Regex.IsMatch(s, @"^[A-Z][a-z]*$");


            string lastName = "Shaikh";
            if (isValidLastName(lastName))
            {
                Console.WriteLine("Valid last name.");
            }
            else
            {
                Console.WriteLine("Invalid last name.");
            }


            Func<string, bool> isValidEmail = s => Regex.IsMatch(s, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            // Usage example:
            string email = "mushk1111shaikh@gmail.com";
            if (isValidEmail(email))
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            Func<string, bool> isValidMobile = s => Regex.IsMatch(s, @"^\d{10}$");

            // Usage example:
            string mobile = "9975001230";
            if (isValidMobile(mobile))
            {
                Console.WriteLine("Valid mobile number.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number.");
            }

            Func<string, bool> isValidPassword = s =>
                  s.Length >= 8 &&
                  s.Any(char.IsUpper) &&
                  s.Any(char.IsLower) &&
                  s.Any(char.IsDigit);


            string password = "Muskan@123";
            if (isValidPassword(password))
            {
                Console.WriteLine("Valid password.");
            }
            else
            {
                Console.WriteLine("Invalid password.");
            }
        }
    
    }
}
