///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosonNLP.Helpers
{
    public class StringHelper
    {
        public static string GetUnicodeString(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!(('0' <= c && c <= '9') || ('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z')) && "-_.~".IndexOf(c) == -1)
                {
                    sb.Append("\\u");
                    sb.Append(String.Format("{0:x4}", (int)c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
