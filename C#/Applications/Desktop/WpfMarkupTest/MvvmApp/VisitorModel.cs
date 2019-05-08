using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp
{
    using System.IO;
    using System.Xml.Serialization;

    public class Visitor
    {
        public string Name { get; set; }

        public int Frequency { get; set; } = 1;

        public DateTime Recent { get; set; } = DateTime.Now;

        public void Revisit()
        {
            Frequency += 1;
            Recent = DateTime.Now;
        }
    }

    public class VisitorModel
    {
        private List<Visitor> store;
        private static XmlSerializer serializer = new XmlSerializer(typeof(List<Visitor>));

        public VisitorModel()
        {
            if (File.Exists("appdoc.xml"))
            {
                using (var reader = new StreamReader("appdoc.xml"))
                    store = (List<Visitor>)serializer.Deserialize(reader);
            }
            else
                store = new List<Visitor>();
        }

        public Visitor[] ReadVisitors()
        {
            return store.ToArray();
        }

        public void WriteVisitor(string name)
        {
            var visitor = store.Find(entry => entry.Name == name);

            if (visitor == null)
                store.Add(new Visitor { Name = name });
            else
                visitor.Revisit();

            SaveChanges();
        }

        public void SaveChanges()
        {
            using (var writer = new StreamWriter("appdoc.xml"))
                serializer.Serialize(writer, store);
        }
    }
}
