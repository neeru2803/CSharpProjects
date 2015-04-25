using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the phone number");
            var phoneWord = Console.ReadLine().ToUpper();
            var phoneNumber = "";
            string[] phonePad = new string[] { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUVW", "XYZ" };
            var ignoreChars = "-0123456789";
            foreach (var c in phoneWord)
            {
                if (ignoreChars.IndexOf(c) >= 0)
                {
                    phoneNumber = phoneNumber + c;

                }
                else
                {
                    var translatedCharacter = GetIndex(phonePad, c);
                    phoneNumber = phoneNumber + translatedCharacter;
                }

            }

            Console.WriteLine(phoneNumber);
        }

        private static int GetIndex(string[] phonePad, char c)
        {
            var translatedCharacter = 0;
            for (int i = 0; i < phonePad.Length; i++)
            {
                if (phonePad[i].IndexOf(c) >= 0)
                {
                    translatedCharacter = i + 2;
                    break;
                }
            }
            return translatedCharacter;
        }
    }
}
