using Json_bilan_ishlash_homework;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Hometask;

///////////////////////////////////////// 3333333333333333333 ////////////////////////////////////////
//string s = @"[
//  {
//    ""name"": ""Meowsy"",
//    ""species"" : ""cat"",
//    ""foods"": {
//      ""likes"": [""tuna"", ""catnip""],
//      ""dislikes"": [""ham"", ""zucchini""]
//    }
//  },
//  {
//    ""name"": ""Barky"",
//    ""species"" : ""dog"",
//    ""foods"": {
//      ""likes"": [""bones"", ""carrots""],
//      ""dislikes"": [""tuna""]
//    }
//  },
//  {
//    ""name"": ""Purrpaws"",
//    ""species"" : ""cat"",
//    ""foods"": {
//      ""likes"": [""mice""],
//      ""dislikes"": [""cookies""]
//    }
//  }
//]";

//List<Animal> JsongaOlish = JsonConvert.DeserializeObject<List<Animal>>(s);
//foreach (var i in JsongaOlish)
//{
//    Console.WriteLine(i.foods.likes[0]);
//}
///////////////////////////////////////// 4444444444444444444 /////////////////////////////////////////
//string s = @"
//{ ""speakers"": [
//	{ ""firstname"": ""Ray"",
//		""lastname"": ""Villalobos"",
//		""category"": ""Front End"",
//		""title"": ""Bootstrap & CSS Preprocessors"",
//		""image"": ""http://barcampdeland.org/images/speaker_rayvillalobos.jpg"",
//		""link"": ""http://iviewsource.com"",
//		""bio"": ""Ray Villalobos is a full-time author and teacher at lynda.com. He is author of the book, Exploring Multimedia for Designers. He has more than 20 years experience in developing and programming multimedia projects. Previously at Entravision Communications, he designed and developed a network of radio station and TV web sites. As a senior producer for Tribune Interactive, he was responsible for designing orlandosentinel.com and for creating immersive multimedia projects and Flash games for the site."",
//		""description"": ""As responsive design continues to take over the web, front-end developers and designers have turned to preprocessors and layout systems that simplify their workflow. Lynda.com staff author Ray Villalobos will talk about using the Bootstrap framework from Twitter to scaffold and fast track your responsive design. He'll talk about how you can use CodeKit and LESS to put together designs in hours instead of days.""
//	}
//]}";
//FourthTask task4 = JsonConvert.DeserializeObject<FourthTask>(s);
//Console.WriteLine(task4);

//////////////////////////////////////////////////// 5555555555555555 ////////////////////////////////
using (HttpClient client  =new HttpClient())
{
    string path = "https://gist.githubusercontent.com/gcollazo/884a489a50aec7b53765405f40c6fbd1/raw/49d1568c34090587ac82e80612a9c350108b62c5/sample.json";
    HttpResponseMessage responce = await client.GetAsync(path);
    string Data = await responce.Content.ReadAsStringAsync();
    Console.WriteLine(Data);
    List<HtmlResponse> AllData = JsonConvert.DeserializeObject<List<HtmlResponse>>(Data); 
}