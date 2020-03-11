using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public string Contents { get; set; }
    public string Dimensions { get; set; }
    public int Weight { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (string contents, string dimensions, int weight)
    {
      Contents = contents;
      Dimensions = dimensions;
      Weight = weight;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}