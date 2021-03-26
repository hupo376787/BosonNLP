///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BosonNLP.Contract
{
    public class RateLimitModel
    {
        public int status { get; set; }
        public Limits limits { get; set; }
    }

    public class Limits
    {
        public Sentimentr sentiment { get; set; }
        public Keywordsr keywords { get; set; }
        public Tagr tag { get; set; }
        public Reviewr review { get; set; }
        public Classifyr classify { get; set; }
        public Nerr ner { get; set; }
        public Summaryr summary { get; set; }
        public Suggestr suggest { get; set; }
        public Clusterr cluster { get; set; }
        public Timer time { get; set; }
        public Depparserr depparser { get; set; }
        public Commentsr comments { get; set; }
    }

    public class Sentimentr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Keywordsr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Tagr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Reviewr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Classifyr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Nerr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Summaryr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Suggestr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Clusterr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Timer
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Depparserr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }

    public class Commentsr
    {
        public long quota_limit { get; set; }
        public long quota_remaining { get; set; }
        public long rate_limit_limit { get; set; }
        public long count_limit_remaining { get; set; }
        public long count_limit_reset { get; set; }
        public long count_limit_limit { get; set; }
        public long rate_limit_reset { get; set; }
        public long rate_limit_remaining { get; set; }
    }
}
