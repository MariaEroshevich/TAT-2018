using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_4
{
  /// <summary>
  /// This class gets and sets elements from nodes.
  /// </summary>
  public class Node
  {
    private string tag;
    private string value;
    private string attributes;
    private string attributeValue;
    private List<Node> childrenNodes = new List<Node>();

    public string Tag { get { return tag; } set { tag = value;} }

    public string Value { get { return value; } set { this.value = value; } }

    public string Attributes { get { return attributes; } set { attributes = value; } }

    public string AttributeValue { get { return attributeValue; } set { attributeValue = value; } }

    public List<Node> ChildrenNodes { get { return childrenNodes; } set { childrenNodes = value; } }
  }
}
