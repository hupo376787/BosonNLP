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
    public class Classify
    {
        public static async Task<Contract.ClassifyModel> ClassifyNews(string originalText)
        {
            Contract.ClassifyModel res = null;

            try
            {
                string url = string.Format(ApiAddress.single_classify);
                originalText = originalText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                string json = await HttpHelper.SendPostAsync(url, originalText);
                string finalJson = "{\"area\":" + json.Replace("[", "").Replace("]", "") + "}";
                res = JsonConvert.DeserializeObject<Contract.ClassifyModel>(finalJson);
                return res;
            }
            catch { }

            return null;
        }
    }
}
