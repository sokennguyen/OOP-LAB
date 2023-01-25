using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB.Ex6
{
    internal class Words
    {
        string word;
        public Words (string word)
        {
            this.word = word;
        }
        public void SetWord(string word)
        {
            this.word = word;
        }
        public int Count()
        {
            return word.Length;
        }
        public int Count (char target)
        {
            int count=0;
            for (int i = 0; i <= word.Length; i++)
                if (word[i] == target)
                    count++;
            return count;
        }
        public string Replace(char target, string replacement)
        {
            int index = word.IndexOf(word, target);
            int lastIndex = word.LastIndexOf(word, target);
            word = word.Remove(index,1);
            word = word.Insert(index,replacement);
            word = word.Remove(lastIndex, 1);
            word = word.Insert(lastIndex, replacement);
            return word;
        }
        public string ToString()
        {
            return word;
        }
        public string ThisIs()
        {
            string thisIs = "This is a good";
            StringBuilder strbld = new StringBuilder(thisIs);
            strbld.AppendLine(" start");
            strbld.AppendLine(thisIs + " end");
            strbld.AppendLine(thisIs + " end");
            strbld.Insert(52,"not ");
            return strbld.ToString();
        }
        
    }
}
