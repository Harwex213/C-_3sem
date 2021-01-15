using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Linq;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            var tablet = new Tablet();

            // Task 1.
            Console.WriteLine("------------------------------------- TASK 1 -------------------------------------");
            #region BiranyFormatter
            // Serialization.
            BinaryFormatter BinF = new BinaryFormatter();
            using (FileStream fstream = new FileStream(@"..\..\files\Tablet_bin.dat", FileMode.OpenOrCreate))
            { BinF.Serialize(fstream, tablet); }
            Console.WriteLine("Сериализация выполнена : бинарный формат");
            // Deserialization.
            using (FileStream fstream = new FileStream(@"..\..\files\Tablet_bin.dat", FileMode.Open))
            {
                var deserialTablet = (Tablet)BinF.Deserialize(fstream);
                Console.WriteLine(deserialTablet);
            }
            Console.WriteLine("Десериализация выполнена : бинарный формат");
            #endregion

            Console.WriteLine();
            #region SoapFormatter
            // Serialization.
            SoapFormatter soapF = new SoapFormatter();
            using (FileStream fstream = new FileStream(@"..\..\files\Tablet_soap.dat", FileMode.OpenOrCreate))
            { soapF.Serialize(fstream, tablet); }
            Console.WriteLine("Сериализация выполнена : SOAP формат");
            // Deserialization.
            using (FileStream fstream = new FileStream(@"..\..\files\Tablet_soap.dat", FileMode.Open))
            {
                var deserialTablet = (Tablet)soapF.Deserialize(fstream);
                Console.WriteLine(deserialTablet);
            }
            Console.WriteLine("Десериализация выполнена : SOAP формат");
            #endregion

            Console.WriteLine();
            #region JSON
            // Serialization.
            File.WriteAllText(@"..\..\files\Tablet_json.json", JsonConvert.SerializeObject(tablet));
            Console.WriteLine("Сериализация выполнена : Json формат");
            // Deserialization.
            var jsonTablet = JsonConvert.DeserializeObject<Tablet>(File.ReadAllText(@"..\..\files\Tablet_json.json"));
            Console.WriteLine(jsonTablet);
            Console.WriteLine("Десериализация выполнена : Json формат");
            #endregion

            Console.WriteLine();
            #region XML
            // Serialization.
            XmlSerializer xmlF = new XmlSerializer(typeof(Tablet));
            using (FileStream fstream = new FileStream(@"..\..\files\Tablet_xml.xml", FileMode.OpenOrCreate))
            { xmlF.Serialize(fstream, tablet); }
            Console.WriteLine("Сериализация выполнена : XML формат");
            // Deserialization.
            using (FileStream fstream = new FileStream(@"..\..\files\Tablet_xml.xml", FileMode.Open))
            {
                Tablet deserialTablet = (Tablet)xmlF.Deserialize(fstream);
                Console.WriteLine(deserialTablet);
            }
            Console.WriteLine("Десериализация выполнена : XML формат");
            #endregion

            // Task 2.
            Console.WriteLine();
            Console.WriteLine("------------------------------------- TASK 2 -------------------------------------");
            List<Tablet> tablets = new List<Tablet>
            {   new Tablet(1280, 720, 4, "Intel"), new Tablet(1024, 720, 2, "Intel"),
                new Tablet(1920, 1080, 6, "ARM"), new Tablet(1280, 720, 4, "AMD")
            };
            #region List
            // Serialization.
            XmlSerializer listXmlS = new XmlSerializer(typeof(List<Tablet>));
            using (FileStream fstream = new FileStream(@"..\..\files\TabletsList_xml.xml", FileMode.OpenOrCreate))
            { listXmlS.Serialize(fstream, tablets); }
            Console.WriteLine("Сериализация List выполнена : XML формат");
            // Deserialization.
            Console.WriteLine("Десериализация начата : xml формат");
            using (FileStream fstream = new FileStream(@"..\..\files\TabletsList_xml.xml", FileMode.Open))
            {
                List<Tablet> deserialTablets = (List<Tablet>)listXmlS.Deserialize(fstream);
                foreach (var item in tablets)
                    Console.WriteLine(item);
            }
            Console.WriteLine("Десериализация выполнена : xml формат");
            #endregion

            // Task 3.
            Console.WriteLine();
            Console.WriteLine("------------------------------------- TASK 3 -------------------------------------");
            #region XPath
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\files\TabletsList_xml.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);

            Console.WriteLine();

            XmlNodeList childnodesTwo = xRoot.SelectNodes("//Tablet/TypeOfCPU");
            foreach (XmlNode n in childnodesTwo)
                Console.WriteLine(n.InnerText);
            #endregion

            // Task 4.
            Console.WriteLine();
            Console.WriteLine("------------------------------------- TASK 4 -------------------------------------");
            #region LINQ_TO_XML
            XDocument xdoc = XDocument.Load(@"..\..\files\TabletsList_xml.xml");
            var items = from x in xdoc.Element("ArrayOfTablet").Elements("Tablet")
                        where x.Element("TypeOfCPU").Value == "Intel"
                        select x;
            foreach (XElement item in items)
                Console.WriteLine(item.Element("AmountOfRAM").Value + " " + item.Element("TypeOfCPU").Value);
            #endregion
        }
    }
}
