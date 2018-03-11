using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_DEV_4
{
  /// <summary>
  /// This class parses XMLFile.
  /// </summary>
  public class XMLParser
  {
    private string pathXMLFile;
    private string XMLFile;

    public XMLParser(string pathXMLFile)
    {
      this.pathXMLFile = pathXMLFile;
    }
    
    /// <summary>
    /// This method parses XMLFIle.
    /// </summary>
    /// <returns>Returns XMLFiles nodes.</returns>
    public Node ParseXMLFile()
    {
      ReadXMLFile();
      Node node = new Node();
      //node.Tag = GetTagName(XMLFile);
      if (XMLFile.Contains('='))
      {
        node.Atrubutes.Add(GetAtribute(XMLFile));
        node.AtributeValue.Add(GetAtributeValue(XMLFile));
        node.Tag = XMLFile.Substring(XMLFile.IndexOf('<') + 1, XMLFile.IndexOf(' ') - XMLFile.IndexOf('<') - 1);
      }
      else
      {
        node.Tag = GetTagName(XMLFile);
      }
        string substring = XMLFile.Substring(XMLFile.IndexOf('>') + 1, XMLFile.IndexOf(GetClosedTag(XMLFile)) - XMLFile.IndexOf('>') - 1);
      
      if (!substring.Contains('<'))
      {
        node.Value = substring;
      }
      else
      {
        node.ChildrenNodes.Add(GetChildNode(substring));
      }
      return node;
    }

    private void ReadXMLFile()
    {
      StreamReader reader = new StreamReader(pathXMLFile);
      XMLFile = reader.ReadToEnd();
    }

    private string GetTagName(string line)
    {
      string tagName = line.Substring(line.IndexOf('<') + 1, line.IndexOf('>') - line.IndexOf('<') - 1);
      if (tagName.Contains('='))
      {
        tagName = line.Substring(line.IndexOf('<') + 1, line.IndexOf(' ') - line.IndexOf('<') - 1);
      }
      return tagName;
    }

    private string GetClosedTag(string line)
    {
      StringBuilder closedTag = new StringBuilder();
      closedTag.Append("</");
      closedTag.Append(GetTagName(line));
      closedTag.Append('>');
      return closedTag.ToString();
    }

    private Node GetChildNode(string line)
    {
      Node childNode = new Node();
      if (line.Contains('='))
      {
        childNode.Atrubutes.Add(GetAtribute(line));
        childNode.AtributeValue.Add(GetAtributeValue(line));
        childNode.Tag = line.Substring(line.IndexOf('<') + 1, line.IndexOf(' ') - line.IndexOf('<') - 1);
      }
      else
      {
        childNode.Tag = GetTagName(line);
      }
      string substring = line.Substring(line.IndexOf('>') + 1, line.IndexOf(GetClosedTag(line)) - line.IndexOf('>') - 1);
      if (!substring.Contains('<'))
      {
        childNode.Value = substring;
      }
      else
      {
        childNode.ChildrenNodes.Add(GetChildNode(substring));
      }
      return childNode;
    }

    private string GetAtribute(string line)
    {
      /*Node node = new Node():
      if (line.Contains('='))
      {
        node.Atrubutes.Add(line.Substring(line.IndexOf(' ') + 1, line.IndexOf('=') - line.IndexOf(' ') - 1));
      }*/
      return line.Substring(line.IndexOf(' ') + 1, line.IndexOf('=') - line.IndexOf(' ') - 1);
    }

    private string GetAtributeValue(string line)
    {
      return line.Substring(line.IndexOf('"') + 1, line.IndexOf('>') - line.IndexOf('"') - 2);
    }
  }
}

