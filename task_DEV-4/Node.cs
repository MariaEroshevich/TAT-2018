using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_4
{
  /// <summary>
  /// This class 
  /// </summary>
  public class Node
  {
    private string tag;
    private string value;
    private string atributeValue;
    private List<string> atributes = new List<string>();
    private List<Node> childrenNodes = new List<Node>();

    public string Tag { get { return tag; } set { tag = value;} }

    public string Value { get { return value; } set { this.value = value; } }

    public List<string> AtributeValue { get { return atributeValue; } set { atributeValue = value; } }

    public List<string> Atrubutes { get { return atributes; } set { atributes = value; } }

    public List<Node> ChildrenNodes { get { return childrenNodes; } set { childrenNodes = value; } }
  }
}
