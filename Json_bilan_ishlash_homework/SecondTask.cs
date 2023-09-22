using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Json_bilan_ishlash_homework
{
    public class SecondTask
    {


    }
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Root));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Root)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "internal")]
    public class Internal
    {

        [XmlElement(ElementName = "data")]
        public List<string> Data { get; set; }

        [XmlElement(ElementName = "unique")]
        public string Unique { get; set; }

    }

    [XmlRoot(ElementName = "child")]
    public class Child
    {

        [XmlElement(ElementName = "internal")]
        public Internal Internal { get; set; }
    }

    [XmlRoot(ElementName = "result")]
    public class Result
    {

        [XmlElement(ElementName = "child")]
        public List<string> Child { get; set; }
    }

    [XmlRoot(ElementName = "root")]
    public class Root
    {

        [XmlElement(ElementName = "result")]
        public Result Result { get; set; }

        [XmlAttribute(AttributeName = "testAttr")]
        public string TestAttr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}