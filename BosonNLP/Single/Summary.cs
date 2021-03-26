///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using BosonNLP.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosonNLP.Single
{
    public class Summary
    {
        public static async Task<string> SummaryAnalysis(string originalText, double percentageA = 0.3, int not_exceedA = 0)
        {
            try
            {
                string url = string.Format(ApiAddress.single_summary);
                originalText = originalText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                string unicodeContent = StringHelper.GetUnicodeString(originalText);

                Contract.SummaryModel sm = new Contract.SummaryModel
                {
                    percentage = percentageA,
                    not_exceed = not_exceedA,
                    title = "",
                    content = unicodeContent,
                };
                string jsonPost = JsonConvert.SerializeObject(sm).Replace("\\\\", "\\");

                string json = await HttpHelper.SendPostAsync1(url, jsonPost);
                return json;
            }
            catch { }

            return null;
        }
    }
}
