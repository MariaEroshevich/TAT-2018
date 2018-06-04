
namespace task_2
{
  /// <summary>
  /// This class gets method for calculating the square.
  /// </summary>
  public class Rectangle
  {
    private double length;
    private double wedth;
    public delegate double Calculate(double length, double wedth);

    public Rectangle(double length, double wedth)
    {
      this.length = length;
      this.wedth = wedth;
    }

    /// <summary>
    /// This method gets method for calculating the square.
    /// </summary>
    /// <param name="del">Delegate.</param>
    /// <returns>Returns delegate.</returns>
    public double GetSquare(Calculate del)
    {
      return del(length, wedth);
    }
  }
}
