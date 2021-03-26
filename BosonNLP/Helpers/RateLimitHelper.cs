///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosonNLP.Helpers
{
    public class RateLimitHelper
    {
        public static async Task<Contract.RateLimitModel> GetRateLimit()
        {
            Contract.RateLimitModel res = null;

            try
            {
                string url = string.Format(ApiAddress.rate_limit);
                string json = await HttpHelper.SendGetAsync(url);
                res = JsonConvert.DeserializeObject<Contract.RateLimitModel>(json);
                return res;
            }
            catch { }

            return null;
        }
    }
}
