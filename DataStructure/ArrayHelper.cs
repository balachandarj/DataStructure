using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class ArrayHelper
    {
        // Remove duplecate character from string
        public static string RemoveDuplicateCharacter(string inputText)
        {
            // initialize array for 0-255
            bool[] charArray=new bool[256];

            string result=string.Empty;
            foreach (var character in inputText.ToArray())
            {
                if(charArray[character]) continue;
                charArray[character] = true;
                result = result + character;
            }
            return result;
        }
    }
}
