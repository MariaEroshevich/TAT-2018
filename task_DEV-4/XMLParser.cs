﻿using System.Linq;
using System.Text;
using System.IO;

namespace task_DEV_4
{
  /// <summary>
  /// This class parses XMLFile.
  /// </summary>
  public class XMLParser
  {
    private string movedNewLine = "\r\n";
    private char equalSign = '=';
    private char openedBreacket = '<';
    private char closedBreacket = '>';
    private char quote = '"';
    private char space = ' ';

    /// <summary>
    /// This method reads XMLFile.
    /// </summary>
    /// <param name="pathXMLFile"> The path to the XMLFile.</param>
    /// <returns>Returns the read file.</returns>
    public string ReadXMLFile(string pathXMLFile)
    {
      StreamReader reader = new StreamReader(pathXMLFile);
      return reader.ReadToEnd().Replace(movedNewLine, "");
    }

    /// <summary>
    /// This method parses XMLFile.
    /// </summary>
    /// <param name="XMLFile">Parsed file.</param>
    /// <returns>Returns node with it's elements.</returns>
    public Node ParseXMLFile(string XMLFile)
    {
      Node node = new Node();

      if (GetElementsLine(XMLFile).Contains(equalSign))
      {
        node = GetElementsInTag(node, XMLFile);
      }
      else
      {
        node.Tag = GetElementsLine(XMLFile);
      }

      string substring = XMLFile.Substring(XMLFile.IndexOf(closedBreacket) + 1, XMLFile.IndexOf(GetClosedTag(node.Tag)) - XMLFile.IndexOf(closedBreacket) - 1);

      if (!substring.Contains(openedBreacket))
      {
        node.Value = substring;
      }
      else
      {
        while (substring.Length != 0)
        {
          Node childrenNode = ParseXMLFile(substring);
          node.ChildrenNodes.Add(childrenNode);
          substring = substring.Remove(0, substring.IndexOf(GetClosedTag(childrenNode.Tag)) + GetClosedTag(childrenNode.Tag).Length).Remove(0, substring.IndexOf(openedBreacket));
        }
      }
      return node;
    }

    private string GetElementsLine(string line)
    {
      return line.Substring(line.IndexOf(openedBreacket) + 1, line.IndexOf(closedBreacket) - line.IndexOf(openedBreacket) - 1);
    }

    private string GetClosedTag(string tagName)
    {
      StringBuilder closedTag = new StringBuilder();
      closedTag.Append("</");
      closedTag.Append(tagName);
      closedTag.Append(closedBreacket);
      return closedTag.ToString();
    }

    private Node GetElementsInTag(Node node, string XMLFile)
    {
      string substring = XMLFile.Substring(XMLFile.IndexOf(openedBreacket), XMLFile.Length - XMLFile.IndexOf(openedBreacket));
      node.Tag = substring.Substring(substring.IndexOf(openedBreacket) + 1, substring.IndexOf(space) - substring.IndexOf(openedBreacket) - 1);
      node.Atributes.Add(substring.Substring(substring.IndexOf(space) + 1, substring.IndexOf(equalSign) - substring.IndexOf(space) - 1));
      node.AtributeValue.Add(substring.Substring(substring.IndexOf(quote) + 1, substring.IndexOf(closedBreacket) - substring.IndexOf(quote) - 2));
      return node;
    }
  }
}

