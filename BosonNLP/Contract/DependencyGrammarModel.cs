﻿///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosonNLP.Contract
{
    public class DependencyGrammarModel
    {
        public List<int> head { get; set; }
        public List<string> role { get; set; }
        public List<string> tag { get; set; }
        public List<string> word { get; set; }
    }
}
