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
    public class SegTag
    {
        public static async Task<Contract.SegTagModel> WordSegAndTag(string originalText,
            string spaceMode = "0", string oovLevel = "3", string t2s = "0", string specialCharConvert = "0")
        {
            Contract.SegTagModel res = null;

            try
            {
                string url = string.Format(ApiAddress.single_segtag + "?space_mode={0}&oov_level={1}&t2s={2}&special_char_conv={3}",
                    spaceMode, oovLevel, t2s, specialCharConvert);
                string json = await HttpHelper.SendPostAsync(url, originalText);
                res = JsonConvert.DeserializeObject<Contract.SegTagModel>(json.Substring(1, json.Length - 2));
                return res;
            }
            catch { }

            return null;
        }
    }
}
