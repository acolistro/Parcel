using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public string Contents { get; set; }
    public int DimensionsH { get; set; }
    public int DimensionsW { get; set; }
    public int DimensionsL { get; set; }
    public int Weight { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (string contents, int dimensionsH, int dimensionsW, int dimensionsL, int weight)
    {
      Contents = contents;
      DimensionsH = dimensionsH;
      DimensionsW = dimensionsW;
      DimensionsL = dimensionsL;
      Weight = weight;
      _instances.Add(this);
    }

    public static string Volume(dimensionsH, dimensionsW, dimensionsL)
    {
      int parcelVolume = (dimensionsH*dimensionsW*dimensionsL)
      
      return volume;
    }

    public static int CostToShip(dimensions, weight)
    {
      return weight;
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