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
    private List<string> atributes = new List<string>();
    private List<string> atributeValue = new List<string>();
    private List<Node> childrenNodes = new List<Node>();

    public string Tag { get { return tag; } set { tag = value;} }

    public string Value { get { return value; } set { this.value = value; } }

    public List<string> Atributes { get { return atributes; } set { atributes = value; } }

    public List<string> AtributeValue { get { return atributeValue; } set { atributeValue = value; } }

    public List<Node> ChildrenNodes { get { return childrenNodes; } set { childrenNodes = value; } }
  }
}
