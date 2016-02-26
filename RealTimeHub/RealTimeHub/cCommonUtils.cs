using System;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RealTechHub
{
    public class cCommonUtils
    {

        public static string ConnectionString
        {
            get
            {
                if (ConfigurationManager.ConnectionStrings["DatabaseConnectionString"] == null)
                {
                    throw new Exception("DB Connection error");
                }
                return ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            }
        }

        public static string GetXML<T>(T list)
        {
            string str = string.Empty;
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, list);
                str = sw.ToString();
            }
            return str;
        }

        public static string GetInnerXml<T>(T list)
        {
            XmlDocument x = new XmlDocument();
            x.LoadXml(GetXML<T>(list));
            XmlDocument xDoc = GetXMLDoc(GetXML(list));
            if (xDoc != null)
            {
                return xDoc.DocumentElement.InnerXml;
            }
            return null;
        }

        public static XmlDocument GetXMLDoc(string xml)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(xml);
                return xDoc;
            }
            catch { }
            return null;
        }
    }
}