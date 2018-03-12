using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_4
{
  /// <summary>
  /// This class to output nodes elements.
  /// </summary>
  public class OutputNode
  {
    /// <summary>
    /// This method to output nodes elements.
    /// </summary>
    /// <param name="node">Node with element.</param>
    /// <param name="XMLFile">Parsed XMLFile.</param>
    /// <returns>Returns string with nodes elements.</returns>
    public List<string> PrintNode(Node node, string XMLFile)
    {
      //StringBuilder stringBuilder = new StringBuilder();
      //if (node.Value != null)
      //{
      //  stringBuilder.Append(node.Tag);
      //  stringBuilder.Append('-');
      //  stringBuilder.Append(node.Value);
      //}

      //for (int i = 0; i < node.Atributes.Count; i++)
      //{
      //  stringBuilder.Append(node.Tag);
      //  stringBuilder.Append('-');
      //  stringBuilder.Append(node.Atributes[i]);
      //  stringBuilder.Append('-');
      //  for (int j = 0; j < node.AtributeValue.Count; j++)
      //  {
      //    stringBuilder.Append(node.AtributeValue[j]);
      //  }
      //}

      //for (int i = 0; i < node.ChildrenNodes.Count; i++)
      //{
      //  PrintNode(node.ChildrenNodes[i], XMLFile);
      //}
      //return stringBuilder.ToString();

      List<string> result = new List<string>();
      if (node.Value != null)
      {
        result.Add(node.Tag);
        result.Add("-");
        result.Add(node.Value);
      }
      for (int i = 0; i < node.Atributes.Count; i++)
      {
        result.Add(node.Tag);
        result.Add("-");
        result.Add(node.Atributes[i]);
        result.Add("-");
        for (int j = 0; j < node.AtributeValue.Count; j++)
        {
          result.Add(node.AtributeValue[j]);
        }
      }

      for (int i = 0; i < node.ChildrenNodes.Count; i++)
      {
        PrintNode(node.ChildrenNodes[i], XMLFile);
      }
      return result;
    }
  }
}
