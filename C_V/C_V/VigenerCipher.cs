using System;
using System.Collections.Generic;
using System.Text;

namespace C_V
{
    class VigenerCipher
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        readonly string letters;

        string tempKey = "";

        

        public VigenerCipher(string alphUser = null)
        {
            letters = string.IsNullOrEmpty(alphUser) ? alphabet : alphUser;
        }

        public string RepeatKey(string key, int n)
        {
            string tempKey = key;

            while (tempKey.Length < n)
            {
                tempKey += tempKey;
            }

            return tempKey.Substring(0, n);
        }

        public string EncryptText(string text, string key)
        {
            tempKey = RepeatKey(key, text.Length);

            string encryptedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                encryptedText += alphabet[(alphabet.Length + text[i] + tempKey[i]) % alphabet.Length];
            }

            return encryptedText;
        }

        public string DecryptedText(string encrText)
        {
            string decrText = "";

            for (int i = 0; i < encrText.Length; i++)
            {
                decrText += alphabet[(alphabet.Length + encrText[i] - tempKey[i]) % alphabet.Length]; 
            }

            return decrText;
        }


    }
}
