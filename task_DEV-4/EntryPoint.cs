using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_4
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string XMLFile = "D:/task_DEV-4/task_DEV-4/example1.xml";
      XMLParser parser = new XMLParser(XMLFile);
      Node node = new Node();
      node = parser.ParseXMLFile();
    }
  }
}
