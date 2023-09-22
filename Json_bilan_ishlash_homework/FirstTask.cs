using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Json_bilan_ishlash_homework
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(EVENT));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (EVENT)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "SMT")]
    public class SMT
    {

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }
    }

    [XmlRoot(ElementName = "DDStatus")]
    public class DDStatus
    {

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }
    }

    [XmlRoot(ElementName = "Address")]
    public class Address
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }

        [XmlElement(ElementName = "QQ")]
        public QQ QQ { get; set; }

        [XmlElement(ElementName = "CC")]
        public CC CC { get; set; }

        [XmlElement(ElementName = "ZZ")]
        public string ZZ { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "QQ")]
    public class QQ
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }
    }

    [XmlRoot(ElementName = "CC")]
    public class CC
    {

        [XmlElement(ElementName = "CC_LAT")]
        public object CCLAT { get; set; }

        [XmlElement(ElementName = "CC_LONG")]
        public object CCLONG { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }
    }

    [XmlRoot(ElementName = "DD")]
    public class DD
    {

        [XmlElement(ElementName = "SMT")]
        public SMT SMT { get; set; }

        [XmlElement(ElementName = "DDStatus")]
        public DDStatus DDStatus { get; set; }

        [XmlElement(ElementName = "Address")]
        public List<Address> Address { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Phone")]
    public class Phone
    {

        [XmlElement(ElementName = "ZZ")]
        public string ZZ { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GG")]
    public class GG
    {

        [XmlElement(ElementName = "LL")]
        public bool LL { get; set; }

        [XmlElement(ElementName = "ZZ")]
        public string ZZ { get; set; }

        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }

        [XmlElement(ElementName = "Phone")]
        public Phone Phone { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OO")]
    public class OO
    {

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }
    }

    [XmlRoot(ElementName = "UCRCode")]
    public class UCRCode
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }
    }

    [XmlRoot(ElementName = "MM")]
    public class MM
    {

        [XmlElement(ElementName = "OO")]
        public OO OO { get; set; }

        [XmlElement(ElementName = "UCRCode")]
        public UCRCode UCRCode { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }
    }

    [XmlRoot(ElementName = "AA")]
    public class AA
    {

        [XmlElement(ElementName = "DD")]
        public DD DD { get; set; }

        [XmlElement(ElementName = "GG")]
        public GG GG { get; set; }

        [XmlElement(ElementName = "MM")]
        public MM MM { get; set; }

        [XmlAttribute(AttributeName = "siteKey")]
        public string SiteKey { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DATA")]
    public class DATA
    {

        [XmlElement(ElementName = "AA")]
        public AA AA { get; set; }
    }

    [XmlRoot(ElementName = "EVENT")]
    public class EVENT
    {

        [XmlElement(ElementName = "DATA")]
        public DATA DATA { get; set; }
    }



}
