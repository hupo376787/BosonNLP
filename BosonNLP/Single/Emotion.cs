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
    public class Emotion
    {
        public static async Task<Contract.EmotionModel> EmotionAnalysis(string originalText, string area = "")
        {
            Contract.EmotionModel res = null;

            try
            {
                string url = string.Format(ApiAddress.single_emotion + "?" + area);
                originalText = originalText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                string json = await HttpHelper.SendPostAsync(url, originalText);
                List<string> list = new List<string>();
                list = json.Substring(2, json.Length - 4).Split(',').ToList();
                string finalJson = "{\"positive\":" + list[0] + ",\"negtive\":" + list[1] + "}";
                res = JsonConvert.DeserializeObject<Contract.EmotionModel>(finalJson);
                return res;
            }
            catch { }

            return null;
        }
    }
}
