using C_V;
using System;

class Program
{
    static void Main(string[] args)
    {
        VigenerCipher cipher = new VigenerCipher();


        Console.Write("Enter text: ");
        string input = Console.ReadLine().ToUpper();
        Console.Write("\nEnter key: ");
        string key = Console.ReadLine().ToUpper();

        Console.WriteLine("Зашифрованный текст");
        string encryptedText = cipher.EncryptText(input, key);
        Console.WriteLine(encryptedText);

        Console.WriteLine("Расшифрованный текст");
        string decryptedText = cipher.DecryptedText(encryptedText);
        Console.WriteLine(decryptedText);
    }
}