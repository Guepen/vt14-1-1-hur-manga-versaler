using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versaler.Model
{
    static class TextAnalyzer
    {
        public static int GetNumberOfCapitals (this string text)
        {
            var count = 0;
           
            foreach(char inputString in text )
            {
                if (Char.IsUpper(inputString))
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}