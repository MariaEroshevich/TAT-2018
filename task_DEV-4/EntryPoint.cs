using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_4
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      string pathXMLFile = args[0];
      //string pathXMLFile = "D:/task_DEV-4/task_DEV-4/example.xml";
      XMLParser parser = new XMLParser();
      string XMLFile = parser.ReadXMLFile(pathXMLFile);
      Node node = new Node();
      node = parser.ParseXMLFile(XMLFile);
      OutputNode outputNode = new OutputNode();
      List<string> result = outputNode.PrintNode(node, XMLFile);
      Console.WriteLine(result);
    }
  }
}
