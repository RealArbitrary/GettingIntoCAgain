using System;

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

        private static string EncryptMessage(string input)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] secretMessage = input.ToCharArray();
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
