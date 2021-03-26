///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosonNLP
{
    public class Constants
    {
        //Get token http://static.bosonnlp.com/dev/center
        public const string ApiToken = "your own token here";
    }

    public class ApiAddress
    {
        public const string single_segtag = "https://api.bosonnlp.com/tag/analysis";//?space_mode=0&oov_level=3&t2s=0&&special_char_conv=0
        public const string single_namedentityrecognize = "https://api.bosonnlp.com/ner/analysis";
        public const string single_depparser = "https://api.bosonnlp.com/depparser/analysis";
        public const string single_emotion = "https://api.bosonnlp.com/sentiment/analysis";
        public const string single_summary = "https://api.bosonnlp.com/summary/analysis";
        public const string single_classify = "https://api.bosonnlp.com/classify/analysis";
        public const string single_keywords = "https://api.bosonnlp.com/keywords/analysis";
        public const string single_suggest = "https://api.bosonnlp.com/suggest/analysis";
        public const string single_time = "https://api.bosonnlp.com/time/analysis";

        public const string rate_limit = "https://api.bosonnlp.com/application/rate_limit_status.json";
    }
}
