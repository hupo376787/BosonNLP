///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using BosonNLP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosonNLP.Single
{
    public class Suggest
    {
        public static async Task<List<string>> GetSuggest(string originalText, int top_k = 10)
        {
            try
            {
                string url = string.Format(ApiAddress.single_suggest + "?top_k={0}", top_k);
                originalText = originalText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                string json = await HttpHelper.SendPostAsync(url, originalText);
                string finalJson = json.Substring(1, json.Length - 2).Replace("\"", "").Replace("], [", "*").Replace(" ", "").Replace("[", "").Replace("]", "");

                if (finalJson == "")
                    return null;
                return finalJson.Split('*').ToList();
            }
            catch { }

            return null;
        }
    }
}
