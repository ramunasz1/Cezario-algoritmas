using System;

class CaesarCipher
{
    static void Main()
    {
        // Prompt the user to enter the plain text
        Console.Write("Enter plain text: ");
        string plainText = Console.ReadLine();

        // Prompt the user to enter the key
        Console.Write("Enter key: ");
        int key = int.Parse(Console.ReadLine());

        // Prompt the user to choose between encryption or decryption
        Console.Write("Enter 'E' to encrypt or 'D' to decrypt: ");
        char choice = Console.ReadLine().ToUpper()[0];

        // Initialize variables for the cipher text and output text
        string cipherText = ""; // Output text
        string outputText = ""; // Encrypted/decrypted text

        // Encryption or Decryption
        foreach (char c in plainText)
        {
            int asciiCode = (int)c;

            // Check if the character is uppercase
            if (char.IsUpper(c))
            {
                // Encryption for uppercase letters
                if (choice == 'E')
                {
                    asciiCode = (asciiCode + key - 65) % 26 + 65;
                }
                // Decryption for uppercase letters
                else if (choice == 'D')
                {
                    asciiCode = (asciiCode - key - 65 + 26) % 26 + 65;
                }
            }
            // Check if the character is lowercase
            else if (char.IsLower(c))
            {
                // Encryption for lowercase letters
                if (choice == 'E')
                {
                    asciiCode = (asciiCode + key - 97) % 26 + 97;
                }
                // Decryption for lowercase letters
                else if (choice == 'D')
                {
                    asciiCode = (asciiCode - key - 97 + 26) % 26 + 97;
                }
            }

            // Append the encrypted/decrypted character to the output text
            outputText += (char)asciiCode;
        }

        // Print the input text and the resulting encrypted/decrypted text
        Console.WriteLine("Input Text: " + plainText);
        Console.WriteLine("Output Text: " + outputText);
    }
}