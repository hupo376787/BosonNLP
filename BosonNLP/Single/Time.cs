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
    public class Time
    {
        public static async Task<Contract.TimeModel> TimeConvertor(string time_desc, string basetime = null)
        {
            Contract.TimeModel res = null;

            try
            {
                string url = "";
                if (basetime == null)
                    url = string.Format(ApiAddress.single_time + "?pattern={0}", time_desc);
                else
                    url = string.Format(ApiAddress.single_time + "?pattern={0}&basetime={1}", time_desc, basetime);
                string json = await HttpHelper.SendPostAsync(url, "");
                res = JsonConvert.DeserializeObject<Contract.TimeModel>(json.Substring(1, json.Length - 2));
                return res;
            }
            catch { }

            return null;
        }
    }
}
