using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingIntoCAgain.CodeCademyApplications
{
    public class CaesarCipher
    {
        public static void CallMe()
        {
            bool isCaesarCipherRunning = true;
            while (isCaesarCipherRunning)
            {
                Console.WriteLine("1. Encrypt Something\n" +
                "2. Main Menu\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Please provide a secret message to encript: ");
                        Console.WriteLine(EncryptMessage(Console.ReadLine().ToLower()));
                        break;
                    case "2":
                        isCaesarCipherRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please type \"1\" or \"2\"");
                        break;
                }
            }
        }

        //The app doesn’t work with symbols, like ! or?. Skip any symbols in your loop so that they are not encrypted.
        //Rewrite the loop as a method Encrypt() which takes a character array and key and returns an encrypted character array.
        //Write a Decrypt() method which takes a character array and key and returns a decrypted character array.
        private static string EncryptMessage(string input)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //Confused me at first for some reason.. Remember the reason this is an array is because you are breaking apart the input
            char[] secretMessage = input.ToCharArray();
            //Same as above, array because you are storing the broken down string (now an array of chars) one by one
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                //+3 because we are encrypting
                int encryptedLetterPosition = (Array.IndexOf(alphabet, letter) + 3) % alphabet.Length;
                encryptedMessage[i] = alphabet[encryptedLetterPosition];
            }

            string stringMessage = String.Join("", encryptedMessage);

            return stringMessage;
        }
    }
}
