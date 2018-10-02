using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto1
{
    class AlphaBet
    {
       public List<char> russian;
       public List<char> english;

        public enum language
        {
            russian,
            english
        }
        
        public AlphaBet()
        {
            russian = new List<char>();
            for(int i= 1040; i < 1072; i++)
            {
                if (i == 1046)
                {
                    russian.Add('Ё');
                }
                russian.Add((char)i);
            }

            english = new List<char>();
            for(int i = 65; i < 91; i++)
            {
                english.Add((char)i);
            }
        }

        public string getSymbol(language lang, int index)
        {
            if(lang == language.russian)
            {
                return russian[index].ToString();
            }
            return english[index].ToString();
        }
    }
}
