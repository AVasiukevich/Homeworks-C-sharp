using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MailDispatch
{
    public class Repository
    {
        public static void SaveXML(List<TreeUsers> list)
        {
            using (FileStream file = new FileStream("TreeMyNodes.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<TreeUsers>));
                xmlFormat.Serialize(file, list);
            }
        }
        public static void LoadXML(ref List<TreeUsers> list)
        {

            if (File.Exists("TreeMyNodes.xml"))
            {
                using (FileStream file = new FileStream("TreeMyNodes.xml", FileMode.Open))
                {
                    XmlSerializer xmlFormat = new XmlSerializer(typeof(List<TreeUsers>));
                    list = (List<TreeUsers>)xmlFormat.Deserialize(file);
                }
            }
        }
    }
}
