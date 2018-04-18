// Decompiled with JetBrains decompiler
// Type: CWY.InputCost
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System;

namespace CWY
{
  [Serializable]
  public class InputCost
  {
    private double metricFactor;
    private string units;
    private string m_Units;
    private string label;
    private string labelF;
    private string name;
    private double amount;
    private string factor;
    private string factorunits;
    public bool isMetric;

    public double MetricFactor
    {
      get
      {
        return this.metricFactor;
      }
      set
      {
        this.metricFactor = value;
      }
    }

    public string Units
    {
      get
      {
        if (!this.IsMetric)
          return this.units;
        switch (this.units)
        {
          case "lb":
            this.MetricFactor = 0.45359;
            this.m_Units = "kg";
            break;
          case "acre":
            this.MetricFactor = 0.404685;
            this.m_Units = "ha";
            break;
          case "ac-in":
            this.MetricFactor = 10.2790153;
            this.m_Units = "ha-mm";
            break;
          case "$":
            this.MetricFactor = 10.2790153;
            this.m_Units = "$";
            break;
          case "feet":
            this.MetricFactor = 0.3048;
            this.m_Units = "meters";
            break;
          case "psi":
            this.MetricFactor = 6.89475729;
            this.m_Units = "kPa";
            break;
          default:
            this.MetricFactor = 1.0;
            this.m_Units = this.units;
            break;
        }
        return Convert.ToString(this.m_Units);
      }
      set
      {
        this.units = value;
      }
    }

    public string Label
    {
      get
      {
        return this.label;
      }
      set
      {
        this.label = value;
      }
    }

    public string LabelF
    {
      get
      {
        return this.label + " (" + this.Units + (this.FactorUnits != "" ? "/" + this.FactorUnits : "") + ")";
      }
      set
      {
      }
    }

    public string Name
    {
      get
      {
        return this.name;
      }
      set
      {
        this.name = value;
      }
    }

    public double Amount
    {
      get
      {
        if (this.IsMetric)
          return this.amount * this.MetricFactor;
        return this.amount;
      }
      set
      {
        if (this.isMetric)
          this.amount = value / this.MetricFactor;
        else
          this.amount = value;
      }
    }

    public string Factor
    {
      get
      {
        return this.factor;
      }
      set
      {
        this.factor = value;
      }
    }

    public string FactorUnits
    {
      get
      {
        if (!this.IsMetric)
          return this.factorunits;
        switch (this.factorunits)
        {
          case "lb":
            this.m_Units = "kg";
            break;
          case "acre":
            this.m_Units = "ha";
            break;
          case "ac-in":
            this.m_Units = "ha-mm";
            break;
          case "feet":
            this.m_Units = "meters";
            break;
          case "psi":
            this.m_Units = "kPa";
            break;
          case "yield":
            this.m_Units = "kg/ha";
            break;
          default:
            this.m_Units = "";
            break;
        }
        return Convert.ToString(this.m_Units);
      }
      set
      {
        this.factorunits = value;
      }
    }

    public string AmountFormatted
    {
      get
      {
        string format = "0.00";
        double num = this.Amount;
        if (this.name == "s")
        {
          num = this.Amount * 1000.0;
          this.Units = "seeds";
          format = "0";
        }
        switch (this.name)
        {
          case "totalhours":
          case "lift":
          case "psi":
            format = "0";
            break;
        }
        return num.ToString(format);
      }
      set
      {
        this.Amount = Convert.ToDouble(value);
      }
    }

    public string formattedValue()
    {
      return (this.Units == "$" ? this.Units : "") + this.AmountFormatted.ToString() + (this.Units != "$" ? " " + this.Units : "") + (this.FactorUnits != "" ? "/" + this.FactorUnits : "");
    }

    public bool IsMetric
    {
      get
      {
        return this.isMetric;
      }
      set
      {
        this.isMetric = value;
      }
    }

    public InputCost(string tlabel, string tname, string tamount, string tfactor, string tunits, string funits)
    {
      this.IsMetric = false;
      this.label = tlabel;
      this.name = tname;
      this.amount = tamount != "" ? Convert.ToDouble(tamount) : 0.0;
      this.factor = tfactor;
      this.units = tunits;
      this.FactorUnits = funits;
    }
  }
}
