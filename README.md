# BosonNLP

Get your token at http://static.bosonnlp.com/dev/center

And replace in Constant.cs, then you can call api like 

Word Seg And Tag
var resBosonSegTag = await BosonAIHelper.WordSegAndTag("A long text");

Named Entity Recognize
var resBosonNamedEntity = await BosonAIHelper.NamedEntityRecognize("A long text");

Emotion Analysis
var resBosonEmotion = await BosonAIHelper.EmotionAnalysis("A long text");

Classify News
var resBosonClassify = await BosonAIHelper.ClassifyNews("A long text");

Summary Analysis
string res = await BosonAIHelper.SummaryAnalysis("A long text");

Get Suggest
List<string> list = await BosonAIHelper.GetSuggest("A long text");

Get Keywords
List<string> list = await BosonAIHelper.GetKeywords("A long text");
