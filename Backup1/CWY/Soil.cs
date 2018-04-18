// Decompiled with JetBrains decompiler
// Type: CWY.Soil
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System;

namespace CWY
{
  [Serializable]
  public class Soil
  {
    public double DblFieldCapacity;
    private double dblpermanentwilt;
    private double dblmaximumwater;
    public double dblAFactor;
    public double dblBFactor;
    public double dblCFactor;
    private string soilname;

    public double dblFieldCapacity
    {
      get
      {
        return this.DblFieldCapacity;
      }
      set
      {
        this.DblFieldCapacity = value;
      }
    }

    public double dblPermanentWilt
    {
      get
      {
        return this.dblpermanentwilt;
      }
      set
      {
        this.dblpermanentwilt = value;
      }
    }

    public double dblMaximumWater
    {
      get
      {
        return this.dblmaximumwater;
      }
      set
      {
        this.dblmaximumwater = value;
      }
    }

    public string SoilName
    {
      get
      {
        return this.soilname;
      }
      set
      {
        this.soilname = value;
      }
    }

    public Soil()
    {
      this.soilname = "";
    }

    public double GetRunoffFactor(double rain)
    {
      double num;
      switch (this.soilname.ToLower())
      {
        case "keith silt loam":
        case "richfield silt loam":
        case "ulysses silt loam":
          num = 0.106 + 6.2E-05 * rain * rain;
          break;
        case "valentine loamy sand":
          num = 0.038 + 4.3E-05 * rain * rain;
          break;
        default:
          num = 0.021 + 3.3E-05 * rain * rain;
          break;
      }
      return num;
    }
  }
}
