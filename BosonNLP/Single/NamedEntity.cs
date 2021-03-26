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
    public class NamedEntity
    {
        public static async Task<Contract.NamedEntityModel> NamedEntityRecognize(string originalText, string sensitivity = "3")
        {
            Contract.NamedEntityModel res = null;

            try
            {
                string url = string.Format(ApiAddress.single_namedentityrecognize + "?sensitivity={0}", sensitivity);
                originalText = originalText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                string json = await HttpHelper.SendPostAsync(url, originalText);
                res = JsonConvert.DeserializeObject<Contract.NamedEntityModel>(json.Substring(1, json.Length - 2));
                return res;
            }
            catch { }

            return null;
        }
    }
}
