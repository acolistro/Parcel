using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public string Contents { get; set; }
    public int DimensionsL { get; set; }
    public int DimensionsM { get; set; }
    public int DimensionsS { get; set; }
    public int Weight { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (string contents, int dimensionsL, int dimensionsM, int dimensionS, int weight)
    {
      Contents = contents;
      DimensionsL = dimensionsL;
      DimensionsM = dimensionsM;
      DimensionsS = dimensionsS;
      Weight = weight;
      _instances.Add(this);
    }

    public static string Volume(int dimensionsH, int dimensionsW, int dimensionsL)
    {
      int parcelVolume = (dimensionsH*dimensionsW*dimensionsL);
      string volume = "";
      if (parcelVolume < 175)
      {
        volume = "Small";
      }
      else if (parcelVolume >= 175 && parcelVolume < 1200)
      {
        volume = "Medium";
      }
      else if (parcelVolume >= 1200 && parcelVolume <= 3000)
      {
        volume = "Large";
      }
      else if (parcelVolume < 3001)
      {
        volume = "Your parcel is too large to ship.";
      }
      return volume;
    }

    public static int CostToShip(string volume, int weight)
    {
      int cost = 0;
      if (volume == "Small" && weight <= 20)
      {
        cost = 5;
      }
      else if (volume == "Meduim" && weight <= 20)
      {
        cost = 10;
      }
      else if (volume == "Large" && weight <= 20)
      {
        cost = 13;
      }
      else if (weight > 20)
      {
        cost = null;
      }
      return cost;
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