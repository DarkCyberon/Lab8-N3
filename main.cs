using System;
using System.Collections.Generic;

namespace Lab_N3 {
    class Program {
        static void Main() {
            string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
            List<string> newArray = ClearAnagrams(array);
            newArray.Sort();

            string words = String.Join("', '", newArray);
            Console.Write("result = ['{0}']", words);
            Console.ReadKey();
        }

        static List<string> ClearAnagrams(string[] array)  {
            var arrayWithoutAnagrams = new List<string>();
            var arraySortedByChar = new List<string>();

            foreach(var word in array) {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string value = string.Join("", charArray);

                if (!arraySortedByChar.Contains(value)) {
                    arrayWithoutAnagrams.Add(word);
                    arraySortedByChar.Add(value);
                }
            }

            return arrayWithoutAnagrams;
        }
    }
}
