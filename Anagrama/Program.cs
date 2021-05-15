using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrama
{
    public class Program
    {
        public class Anagrama {


            public static bool FuncionAnagrama (string word1, string word2){

                char[] char1 = word1.ToLower().ToCharArray();
                char[] char2 = word2.ToLower().ToCharArray();

                Array.Sort(char1);
                Array.Sort(char2);

                word1 = new string(char1);
                word2 = new string(char2);


                if (word1 != word2) {
                    return false;
                }
                if (word1.Length != word1.Length)
                {
                    return false;
                }
                return true;
            } 

        }
        static void Main(string[] args)
        {
        }
    }
}
