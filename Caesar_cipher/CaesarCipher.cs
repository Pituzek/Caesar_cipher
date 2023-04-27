using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public static class CaesarCipher
    {
        public static Dictionary<char, int> charArray = new Dictionary<char, int>() {
            { 'A', 0},
            { 'B', 1},
            { 'C', 2},
            { 'D', 3},
            { 'E', 4},
            { 'F', 5},
            { 'G', 6},
            { 'H', 7},
            { 'I', 8},
            { 'J', 9},
            { 'K', 10},
            { 'L', 11},
            { 'M', 12},
            { 'N', 13},
            { 'O', 14},
            { 'P', 15},
            { 'Q', 16},
            { 'R', 17},
            { 'S', 18},
            { 'T', 19},
            { 'U', 20},
            { 'V', 21},
            { 'W', 22},
            { 'X', 23},
            { 'Y', 24},
            { 'Z', 25}
        };

        public static string Encode(int key, string text)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];

                var encodedChar = cipher(ch, key);

                sb.Append(encodedChar);
            }

            return sb.ToString();
        }

        private static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            int index = charArray[ch];

            char encodedChar = charArray.ElementAt((index + key) % 26).Key;

            return encodedChar;
        }
    }
}
