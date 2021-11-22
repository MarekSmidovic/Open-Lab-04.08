using System;
using System.Linq;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
             for (int i = 0; i < strings.Lenght; i++)
			{
                int dlzkaSlova = strings[i].Lenght;
                if (dlzkaSlova == 4)
	            {
                    strings[i] = strings[i];
	            }
			}
            return strings;
        }
    }
}
