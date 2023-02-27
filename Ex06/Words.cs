using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
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
        public void ThisIs()
        {
            string thisIs = "This is a good";
            StringBuilder strbld = new StringBuilder(thisIs);
            strbld.Append(" start");
            strbld.Remove(14, 6);
            strbld.AppendLine(" end");
            strbld.Insert(8, "not ");
            Console.WriteLine(strbld.ToString(8, 3));
            strbld.Remove(8, 4);
            strbld.Replace('a', 'A');
            Console.WriteLine(strbld.ToString()[8]);
            Console.WriteLine(strbld.ToString());
        }
        public bool IsAnagram(string word2)
        {
            if (word2.Length != this.word.Length) return false;
            string str = this.word;
            while (word2!="")
            {
                while (str!="")
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (word2[0] == str[i])
                        {
                            word2 = word2.Remove(0, 1);
                            str = str.Remove(i, 1);
                            break;
                        }
                        else if (i+1 == str.Length) return false;
                    }
                }
            }
            return true;
        }
        public bool IsAnagramIgnoreCase(string word2)
        {
            if (word2.Length != this.word.Length) return false;
            string str = this.word.ToLower();
            word2 = word2.ToLower();
            while (word2 != "")
            {
                while (str != "")
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (word2[0] == str[i])
                        {
                            word2 = word2.Remove(0, 1);
                            str = str.Remove(i, 1);
                            break;
                        }
                        else if (i + 1 == str.Length) return false;
                    }
                }
            }
            return true;
        }
        public bool IsAnagramIgnoreCaseNSpace(string word2)
        {
            string str = Regex.Replace(this.word.ToLower(), "[^0-9A-Za-z _-]", "");
            word2 = Regex.Replace(word2.ToLower(), "[^0-9A-Za-z _-]", "");
            str= String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
            word2 = String.Concat(word2.Where(c => !Char.IsWhiteSpace(c)));
            if (word2.Length != str.Length) return false;
            while (word2 != "")
            {
                while (str != "")
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (word2[0] == str[i])
                        {
                            word2 = word2.Remove(0, 1);
                            str = str.Remove(i, 1);
                            break;
                        }
                        else if (i + 1 == str.Length) return false;
                    }
                }
            }
            return true;
        }
        
    }
}
