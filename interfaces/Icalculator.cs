public interface ICalculator
{
    /// <summary>
    /// Legger sammen to tall.
    /// </summary>
    /// <param name="a">Første tall.</param>
    /// <param name="b">Andre tall.</param>
    /// <returns>Summen av to tall.</returns>
    public double Add(double a, double b);
    /// <summary>
    /// Trekker det andre tallet fra det første.
    /// </summary>
    /// <param name="a">Første tall.</param>
    /// <param name="b">Andre tall.</param>
    /// <returns>Forskjellen mellom to tall.</returns>
    public double Subtract(double a, double b);
    /// <summary>
    /// Multipliserer to tall.
    /// </summary>
    /// <param name="a">Første tall.</param>
    /// <param name="b">Andre tall.</param>
    /// <returns>Produktet av to tall.</returns>
 
}