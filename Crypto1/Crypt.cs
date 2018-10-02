using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto1
{
    class Crypt
    {
        public char[,] tableVigener;
        public char[,] tableTrisemus;
        AlphaBet alp;
        /// <summary>
        /// создание объекта класса crypt с размером таблицы по умолчанию
        /// </summary>
        public Crypt()
        {
            alp = new AlphaBet();
            tableTrisemus = new char[6, 6];
            tableVigener = new char[alp.russian.Count, alp.russian.Count];
            #region запись символов в таблицу виженера
            for (int i = 0; i < alp.russian.Count; i++)
            {
                int ind = i;
                for (int j = 0; j < alp.russian.Count; j++)
                {
                    tableVigener[i, j] = alp.russian[ind];
                    if (ind < alp.russian.Count - 1)
                    {
                        ind++;
                    }
                    else
                    {
                        ind = 0;
                    }
                }

            }
            #endregion
        }

        public string cryptTrisemus(string keyWord, string word)
        {
            string modifyKeyWord = dupDel(keyWord);
            string modifyAlpha = string.Empty;
            List<char> found = new List<char>();
            string newString = string.Empty;
            if (word != string.Empty)
            {
                word = word.ToUpper();
            }


            #region отбор лишних символов в строке и алфавите
            foreach (char c in modifyKeyWord)
            {
                if (found.Contains(c))
                    continue;
                modifyAlpha += c.ToString();
                found.Add(c);
            }

            #region работа с основным листом
            modifyAlpha = modifyAlpha.ToUpper();
            found.Clear();
            for (int i = 0; i < modifyAlpha.Length; i++)
            {
                found.Add(modifyAlpha[i]);
            }
            #endregion

            //требуется удаление дублирования кода
            foreach (char c in alp.russian)
            {
                if (found.Contains(c))
                    continue;
                modifyAlpha += c.ToString();
                found.Add(c);
            }
            #endregion

            int indexAlpha = 0;
            #region заполнение символов в таблицу
            for (int i = 0; i < tableTrisemus.GetLength(0); i++)
            {
                for (int j = 0; j < tableTrisemus.GetLength(1); j++)
                {
                    if (indexAlpha < modifyAlpha.Length)
                    {
                        tableTrisemus[i, j] = modifyAlpha[indexAlpha];
                        indexAlpha++;
                    }

                }
            }
            #endregion

            foreach (char sym in word)
            {
                int X = 0;
                int Y = 0;
                bool alarm = false;
                for (int i = 0; i < tableTrisemus.GetLength(0) && !alarm; i++)
                {
                    for (int j = 0; j < tableTrisemus.GetLength(1); j++)
                    {
                        if (sym == tableTrisemus[i, j])
                        {
                            alarm = true;
                            X = i;
                            Y = j;
                            break;
                        }

                    }
                }
                if (X < (tableTrisemus.GetLength(1)) - 1 && tableTrisemus[X + 1, Y] != ((char)0))
                {
                    newString += tableTrisemus[X + 1, Y];
                }
                else
                {
                    newString += tableTrisemus[0, Y];
                }
            }
            return newString;
        }
        public string decryptTrisemus(string cryptWord)
        {
            if (tableTrisemus.Length == 0)
            {
                throw new ArgumentException();
            }
            string newString = string.Empty;

            foreach (char sym in cryptWord)
            {
                int X = 0;
                int Y = 0;
                bool alarm = false;
                for (int i = 0; i < tableTrisemus.GetLength(0) && !alarm; i++)
                {
                    for (int j = 0; j < tableTrisemus.GetLength(1); j++)
                    {
                        if (sym == tableTrisemus[i, j])
                        {
                            alarm = true;
                            X = i;
                            Y = j;
                            break;
                        }
                    }
                }

                if (X != 0)
                {
                    newString += tableTrisemus[X - 1, Y];
                }
                else if (tableTrisemus[tableTrisemus.GetLength(0) - 1, Y] != ((char)0))
                {
                    newString += tableTrisemus[tableTrisemus.GetLength(0) - 1, Y];
                }
                else
                {
                    newString += tableTrisemus[tableTrisemus.GetLength(0) - 2, Y];
                }
            }

            return newString;
        }
        public string cryptVigener(string keyWord, string word)
        {
            word = word.ToUpper();
            string newString = string.Empty;
            string loopKey = createLoopKey(dupDel(keyWord.ToUpper()), word.Length); 
            #region шифрование

            List<char> bufKey = generateBufer(false);
            List<char> bufword = generateBufer(true);

            for (int i = 0; i < word.Length; i++)
            {
                newString += tableVigener[bufKey.IndexOf(loopKey[i]), bufword.IndexOf(word[i])];
            }

            #endregion
            return newString;
        }
        public string decryptVigener(string keyWord, string cryptWord)
        {
            string newString = string.Empty;
            cryptWord = cryptWord.ToUpper();
            keyWord = keyWord.ToUpper();
            string loopkey = createLoopKey(dupDel(keyWord), cryptWord.Length);
            List<char> bufKey = generateBufer(false);
            List<char> bufword = generateBufer(true);
            
            for (int i = 0; i < cryptWord.Length; i++)
            {
                int Y = bufKey.IndexOf(loopkey[i]);
                for (int k = 0; k < tableVigener.GetLength(1); k++)
                {
                    if (cryptWord[i] == tableVigener[Y, k])
                    {
                        newString += tableVigener[0, k];
                        break;
                    }
                }
                
            }
            return newString;
        }
        #region вспомогательные функции
        /// <summary>
        /// операция удаления повторяющихся символов в слове
        /// </summary>
        /// <param name="keyWord">ключевое слово</param>
        /// <returns>строка без повторяющихся символов</returns>
        private string dupDel(string keyWord)
        {
            string NotDupKeyWord = string.Empty;
            List<char> found = new List<char>();
            foreach (char c in keyWord)
            {
                if (found.Contains(c))
                    continue;
                NotDupKeyWord += c.ToString();
                found.Add(c);
            }
            return NotDupKeyWord;
        }
        List<char> generateBufer(bool isColumns)
        {
            List<char> buf = new List<char>();
            for (int i = 0; i < tableVigener.GetLength(0); i++)
            {
                if (isColumns == true)
                {
                    buf.Add(tableVigener[0, i]);
                }
                else
                {
                    buf.Add(tableVigener[i, 0]);
                }
            }

            return buf;
        }
        string createLoopKey(string key, int length)
        {
            string _Key = string.Empty;

             int count = 0;
            int lenghtCount = 0;
            
            while (count < length)
            {
                _Key += key[lenghtCount];
                if (lenghtCount < key.Length - 1)
                {
                    lenghtCount++;
                }
                else
                {
                    lenghtCount = 0;
                }
                count++;
            }

            return _Key;
        }
        #endregion
    }
}