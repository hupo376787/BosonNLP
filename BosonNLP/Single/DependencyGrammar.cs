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
    public class DependencyGrammar
    {
        public static async Task<Contract.DependencyGrammarModel> DependencyGrammarAnalysis(string originalText)
        {
            Contract.DependencyGrammarModel res = null;

            try
            {
                string url = string.Format(ApiAddress.single_depparser);
                originalText = originalText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                string json = await HttpHelper.SendPostAsync(url, originalText);
                res = JsonConvert.DeserializeObject<Contract.DependencyGrammarModel>(json.Substring(1, json.Length - 2));
                return res;
            }
            catch { }

            return null;
        }
    }
}
