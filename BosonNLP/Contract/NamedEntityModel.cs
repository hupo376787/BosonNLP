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
    public class NamedEntityModel
    {
        public List<string> word { get; set; }
        public List<string> tag { get; set; }
        public List<List<string>> entity { get; set; }
    }
}
