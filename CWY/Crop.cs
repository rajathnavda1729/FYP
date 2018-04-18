

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CWY
{
  [Serializable]
  public class Crop
  {
    public BindingList<Measurement> arrCoefficients = new BindingList<Measurement>();
    public BindingList<Measurement> arrWF = new BindingList<Measurement>();
    public BindingList<Measurement> cIrrigation = new BindingList<Measurement>();
    public BindingList<Measurement> cIrrigation_display = new BindingList<Measurement>();
    public BindingList<InputCost> cCosts = new BindingList<InputCost>();
    public BindingList<InputCost> cIrrigationCosts = new BindingList<InputCost>();
    public BindingList<InputCost> cGeneralCosts = new BindingList<InputCost>();
    public BindingList<InputCost> cOperationCosts = new BindingList<InputCost>();
    public BindingList<InputCost> cReturns = new BindingList<InputCost>();
    public BindingList<InputCost> cMiscCosts = new BindingList<InputCost>();
    public ArrayList calcDates = new ArrayList();
    private double _price;
    public CWYModel model;
    private double _acres;
    private bool _optimalN;
    private bool _optimalP;
    private bool _optimalSeed;
    public double MaxYield;
    private string cropname;
    private string _units;
    public double EPRConstant;
    public double[,] iswa;
    public double[,] iswa_loamy_sand;
    public double calcYield;
    public double yieldA;
    public double yieldB;
    public int YeartStart;
    private double _dblMaxYieldDisplay;
    private double _dblMaxYield;
    public string modelunits;
    private double sumirrigation;

    public event UnitsChangedHandler UnitsChanged;

    protected virtual void OnUnitsChanged()
    {
      try
      {
        this.UnitsChanged();
      }
      catch
      {
      }
    }

    public double OptimalNutrient(string nutrient)
    {
      double num = 0.0;
      switch (this.cropname.ToLower())
      {
        case "corn":
          num = nutrient == "N" ? 1.35 : 0.43;
          break;
        case "grain sorghum":
          num = nutrient == "N" ? 1.25 : 0.44;
          break;
        case "soybean":
          num = nutrient == "N" ? 0.0 : 0.87;
          break;
        case "winter wheat":
          num = nutrient == "N" ? 1.75 : 0.55;
          break;
        case "sunflower":
          num = nutrient == "N" ? 0.05 : 0.018;
          break;
        case "alfalfa":
          num = nutrient == "N" ? 0.0 : 14.88;
          break;
      }
      return num;
    }

    public double OptimalSeed(double grossIrrig)
    {
      string lower = this.cropname.ToLower();
      double num = 0.0;
      switch (lower)
      {
        case "corn":
          if (grossIrrig >= 18.0)
            num = 32000.0;
          if (grossIrrig >= 15.0)
            num = 29000.0;
          if (grossIrrig >= 12.0)
            num = 26000.0;
          if (grossIrrig >= 9.0)
            num = 23000.0;
          if (grossIrrig >= 6.0)
            num = 20000.0;
          if (grossIrrig >= 0.0)
          {
            num = 17000.0;
            break;
          }
          break;
        case "soybean":
          if (grossIrrig >= 18.0)
            num = 200000.0;
          if (grossIrrig >= 15.0)
            num = 185000.0;
          if (grossIrrig >= 12.0)
            num = 170000.0;
          if (grossIrrig >= 9.0)
            num = 155000.0;
          if (grossIrrig >= 6.0)
            num = 140000.0;
          if (grossIrrig >= 0.0)
          {
            num = 125000.0;
            break;
          }
          break;
        case "grain sorghum":
          if (grossIrrig >= 18.0)
            num = 7.81;
          if (grossIrrig >= 15.0)
            num = 6.56;
          if (grossIrrig >= 12.0)
            num = 5.31;
          if (grossIrrig >= 9.0)
            num = 203.0 / 50.0;
          if (grossIrrig >= 6.0)
            num = 2.81;
          if (grossIrrig >= 0.0)
          {
            num = 1.56;
            break;
          }
          break;
        case "sunflower":
          if (grossIrrig >= 18.0)
            num = 25500.0;
          if (grossIrrig >= 15.0)
            num = 24000.0;
          if (grossIrrig >= 12.0)
            num = 22500.0;
          if (grossIrrig >= 9.0)
            num = 21000.0;
          if (grossIrrig >= 6.0)
            num = 19500.0;
          if (grossIrrig >= 0.0)
          {
            num = 18000.0;
            break;
          }
          break;
        case "Wheat":
          num = 90.0;
          break;
        case "Alfalfa":
          num = 3.0;
          break;
      }
      if (lower == "corn" || lower == "soybean" || lower == "sunflower")
        num /= 1000.0;
      return num;
    }

    public double price
    {
      get
      {
        if (this._price == 0.0)
        {
          switch (this.cropname.ToLower())
          {
            case "corn":
              this._price = 2.57;
              break;
            case "grain sorghum":
              this._price = 2.27;
              break;
            case "soybean":
              this._price = 5.62;
              break;
            case "winter wheat":
              this._price = 3.11;
              break;
            case "sunflower":
              this._price = 0.12;
              break;
            case "alfalfa":
              this._price = 71.0;
              break;
          }
        }
        return this._price;
      }
      set
      {
        this._price = value;
      }
    }

    public double acres
    {
      get
      {
        return this._acres;
      }
      set
      {
        this._acres = value;
      }
    }

    public bool optimalN
    {
      get
      {
        return this._optimalN;
      }
      set
      {
        this._optimalN = value;
      }
    }

    public bool optimalP
    {
      get
      {
        return this._optimalP;
      }
      set
      {
        this._optimalP = value;
      }
    }

    public bool optimalSeed
    {
      get
      {
        return this._optimalSeed;
      }
      set
      {
        this._optimalSeed = value;
      }
    }

    public string CropName
    {
      get
      {
        return this.cropname;
      }
      set
      {
        this.cropname = value;
      }
    }

    public string units
    {
      get
      {
        return this._units;
      }
      set
      {
        if (this._units != value)
        {
          this.cIrrigation.GetEnumerator();
          for (int index = 0; index < this.cIrrigation.Count; ++index)
            this.cIrrigation_display[index] = new Measurement((object) this.cIrrigation[index].Date, value == "english" ? this.cIrrigation[index].Amount / 25.4 : this.cIrrigation[index].Amount);
        }
        this._units = value;
        this.OnUnitsChanged();
      }
    }

    public double dblMaxYieldDisplay
    {
      get
      {
        if (this._dblMaxYield == 0.0)
        {
          switch (this.CropName.ToLower())
          {
            case "corn":
              return this.DisplayYield(220.0);
            case "grain sorghum":
              return this.DisplayYield(120.0);
            case "soybean":
              return this.DisplayYield(65.0);
            case "winter wheat":
              return this.DisplayYield(75.0);
            case "sunflower":
              return this.DisplayYield(3500.0);
            case "alfalfa":
              return this.DisplayYield(10.0);
          }
        }
        return this.DisplayYield(this._dblMaxYield);
      }
      set
      {
        this._dblMaxYield = this.modelunits == "english" ? value : this.EnglishYield(value);
      }
    }

    public double dblMaxYield
    {
      get
      {
        if (this._dblMaxYield == 0.0)
        {
          switch (this.CropName.ToLower())
          {
            case "corn":
              this._dblMaxYield = this.DisplayYield(220.0);
              break;
            case "grain sorghum":
              this._dblMaxYield = this.DisplayYield(120.0);
              break;
            case "soybean":
              this._dblMaxYield = this.DisplayYield(65.0);
              break;
            case "winter wheat":
              this._dblMaxYield = this.DisplayYield(75.0);
              break;
            case "sunflower":
              this._dblMaxYield = this.DisplayYield(3500.0);
              break;
            case "alfalfa":
              this._dblMaxYield = this.DisplayYield(10.0);
              break;
          }
        }
        return this._dblMaxYield;
      }
      set
      {
        this._dblMaxYield = this.model.Units == "english" ? value : this.EnglishYield(value);
      }
    }

    public double Density()
    {
      switch (this.cropname.ToLower())
      {
        case "corn":
        case "grain sorghum":
          return 56.0;
        case "soybean":
        case "winter wheat":
          return 60.0;
        case "sunflower":
          return 1.0;
        case "alfalfa":
          return 2000.0;
        default:
          return 56.0;
      }
    }

    public double MetricYield(double y)
    {
      return y * 2.47096614776378 * this.Density() * 0.45359237;
    }

    public double EnglishYield(double y)
    {
      return y * 2.20462262 * 0.404685643005079 * (1.0 / this.Density());
    }

    public double DisplayYield(double y)
    {
      y = this.modelunits == "english" ? y : this.MetricYield(y);
      return Convert.ToDouble(y.ToString("0"));
    }

    public string YieldUnits()
    {
      string str = "";
      switch (this.cropname.ToLower())
      {
        case "corn":
        case "grain sorghum":
        case "soybean":
        case "winter wheat":
          str = this.modelunits == "english" ? "bu/acre" : "kg/ha";
          break;
        case "sunflower":
          str = this.modelunits == "english" ? "lbs/acre" : "kg/ha";
          break;
        case "alfalfa":
          str = this.modelunits == "english" ? "tons/acre" : "kg/ha";
          break;
      }
      return str;
    }

    public string Units()
    {
      switch (this.cropname.ToLower())
      {
        case "corn":
        case "grain sorghum":
        case "soybean":
        case "winter wheat":
          return !(this.modelunits == "english") ? "kg" : "bu";
        case "sunflower":
          return !(this.modelunits == "english") ? "kg" : "lbs";
        case "alfalfa":
          return !(this.modelunits == "english") ? "kg" : "tons";
        default:
          return "bu";
      }
    }

    public Crop()
    {
      this.modelunits = "english";
      this.optimalN = true;
      this.optimalP = true;
      this.optimalSeed = true;
      this.cIrrigation_display.ListChanged += new ListChangedEventHandler(this.cIrrigation_display_ListChanged);
      this.acres = 150.0;
    }

    public void UpdateIrrigation()
    {
      this.cIrrigation.Clear();
      IEnumerator enumerator = (IEnumerator) this.cIrrigation_display.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Measurement current = (Measurement) enumerator.Current;
        Measurement measurement = new Measurement((object) current.Date, current.Amount);
        if (this.units == "english")
          measurement.Amount *= 25.4;
        this.cIrrigation.Add(measurement);
      }
      this.GetSumIrrigation();
    }

    public void cIrrigation_display_ListChanged(object sender, ListChangedEventArgs e)
    {
      this.UpdateIrrigation();
    }

    public double SumIrrigation
    {
      get
      {
        return this.sumirrigation;
      }
      set
      {
        this.sumirrigation = value;
      }
    }

    public double GetSumIrrigation()
    {
      double num = 0.0;
      IEnumerator enumerator = (IEnumerator) this.cIrrigation.GetEnumerator();
      while (enumerator.MoveNext())
        num += ((Measurement) enumerator.Current).Amount;
      this.SumIrrigation = num;
      return num;
    }

    public ArrayList ConvertToArrayList(BindingList<Measurement> bm)
    {
      ArrayList arrayList = new ArrayList();
      IEnumerator enumerator = (IEnumerator) bm.GetEnumerator();
      while (enumerator.MoveNext())
        arrayList.Add((object) (Measurement) enumerator.Current);
      return arrayList;
    }

    public ArrayList CalcDates(ArrayList simpledates)
    {
      ArrayList arrayList = new ArrayList();
      IEnumerator enumerator = simpledates.GetEnumerator();
      while (enumerator.MoveNext())
      {
        DateTime dateTime = Convert.ToDateTime(((Measurement) enumerator.Current).Date);
        if (this.arrCoefficients.IndexOf((Measurement) enumerator.Current) == 0)
        {
          arrayList.Add((object) new DateTime(this.YeartStart, dateTime.Month, dateTime.Day));
        }
        else
        {
          int num = dateTime.Month >= Convert.ToDateTime(arrayList[arrayList.Count - 1]).Month ? dateTime.DayOfYear - Convert.ToDateTime(arrayList[arrayList.Count - 1]).DayOfYear : 365 - Convert.ToDateTime(arrayList[arrayList.Count - 1]).DayOfYear + dateTime.DayOfYear;
          arrayList.Add((object) Convert.ToDateTime(arrayList[arrayList.Count - 1]).AddDays((double) num));
        }
      }
      return arrayList;
    }

    public void SortCoefficients()
    {
    }

    public DateTime GetDateFromString(string dateString)
    {
      DateTime dateTime = Convert.ToDateTime(dateString);
      return new DateTime(this.YeartStart, dateTime.Month, dateTime.Day);
    }

    public DateTime GetDateFromDOY(int doy)
    {
      int num = 0;
      if (doy < Convert.ToDateTime(this.arrCoefficients[0].Date).DayOfYear)
        num = 1;
      return new DateTime(this.YeartStart + num, 1, 1).AddDays((double) (doy - 1));
    }

    public ArrayList GetCoefficientCurveArray()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      IEnumerator enumerator = (IEnumerator) this.arrCoefficients.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Measurement current = (Measurement) enumerator.Current;
        arrayList2.Add((object) Convert.ToDateTime(current.Date).DayOfYear);
      }
      switch (this.cropname.ToLower())
      {
        case "corn":
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(arrayList2[0]), 0.26));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[0]) + 13.0 / 35.0 * (double) (Convert.ToInt32(arrayList2[1]) - Convert.ToInt32(arrayList2[0]))), 0.38));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[0]) + 27.0 / 35.0 * (double) (Convert.ToInt32(arrayList2[1]) - Convert.ToInt32(arrayList2[0]))), 1.06));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[1]) + 0.1 * (double) (Convert.ToInt32(arrayList2[2]) - Convert.ToInt32(arrayList2[1]))), 1.06));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[1]) + 19.0 / 30.0 * (double) (Convert.ToInt32(arrayList2[2]) - Convert.ToInt32(arrayList2[1]))), 0.76));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[2]) - 1), 0.35));
          break;
        case "grain sorghum":
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[0])), 0.22));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[0]) + 41.0 / 55.0 * (double) (Convert.ToInt32(arrayList2[1]) - Convert.ToInt32(arrayList2[0]))), 0.96));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[1]) + 7.0 / 54.0 * (double) (Convert.ToInt32(arrayList2[2]) - Convert.ToInt32(arrayList2[1]))), 0.96));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[1]) + 19.0 / 27.0 * (double) (Convert.ToInt32(arrayList2[2]) - Convert.ToInt32(arrayList2[1]))), 0.69));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[2])), 0.67));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[3]) - 1), 0.65));
          break;
        case "soybean":
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[0])), 0.25));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[1]) - 1), 0.81));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) (Convert.ToInt32(arrayList2[1]) - 1) + 3.0 / 7.0 * (double) (Convert.ToInt32(arrayList2[2]) - Convert.ToInt32(arrayList2[1]))), 0.96));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[2])), 1.02));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[3])), 0.59));
          break;
        case "sunflower":
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[0])), 0.22));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[0]) + 9.0 / 34.0 * (double) (Convert.ToInt32(arrayList2[1]) - Convert.ToInt32(arrayList2[0]))), 0.27));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[1]) + 0.2 * (double) (Convert.ToInt32(arrayList2[2]) - Convert.ToInt32(arrayList2[1]))), 1.16));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[3]) + 7.0 / 30.0 * (double) (Convert.ToInt32(arrayList2[4]) - Convert.ToInt32(arrayList2[3]))), 1.16));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[4])), 0.56));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[4]) + 10), 0.35));
          break;
        case "winter wheat":
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[0])), 0.3));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[0]) + 1.0 / 3.0 * (double) (Convert.ToInt32(arrayList2[1]) - Convert.ToInt32(arrayList2[0]))), 0.8));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[1]) - 1), 0.8));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[1])), 0.57));
          arrayList1.Add((object) new Measurement((object) 365, 0.59));
          arrayList1.Add((object) new Measurement((object) 1, 0.6));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[2]) - 3), 0.52));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[2]) + 0.18 * (double) (Convert.ToInt32(arrayList2[3]) - Convert.ToInt32(arrayList2[2]))), 0.85));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[3]) + 15.0 / 29.0 * (double) (Convert.ToInt32(arrayList2[4]) - Convert.ToInt32(arrayList2[3]))), 1.23));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[4]) + 24.0 / 35.0 * (double) (Convert.ToInt32(arrayList2[5]) - Convert.ToInt32(arrayList2[4]))), 1.23));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[5])), 0.65));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[5]) + 7), 0.19));
          break;
        case "alfalfa":
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[0]) - 1), 0.45));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[0]) + 11.0 / 64.0 * (double) (Convert.ToInt32(arrayList2[1]) - Convert.ToInt32(arrayList2[0]))), 0.85));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[0]) + 0.5 * (double) (Convert.ToInt32(arrayList2[1]) - Convert.ToInt32(arrayList2[0]))), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[1]) - 1), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[1])), 0.35));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[1]) + 0.5 * (double) (Convert.ToInt32(arrayList2[2]) - Convert.ToInt32(arrayList2[1]))), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[2]) - 1), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[2])), 0.35));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[2]) + 0.5 * (double) (Convert.ToInt32(arrayList2[3]) - Convert.ToInt32(arrayList2[2]))), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[3]) - 1), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[3])), 0.35));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[3]) + 0.5 * (double) (Convert.ToInt32(arrayList2[4]) - Convert.ToInt32(arrayList2[3]))), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[4]) - 1), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[4])), 0.35));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32((double) Convert.ToInt32(arrayList2[4]) + 26.0 / 53.0 * (double) (Convert.ToInt32(arrayList2[5]) - Convert.ToInt32(arrayList2[4]))), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[5])), 1.0));
          arrayList1.Add((object) new Measurement((object) Convert.ToInt32(Convert.ToInt32(arrayList2[5]) + 1), 0.47));
          break;
      }
      return arrayList1;
    }

    public double GetYield(double ET)
    {
      if (this.cropname == "Alfalfa")
      {
        ET *= 25.4;
        double num = ET / 25.4 * 0.25;
        return num > 0.0 ? num : 0.0;
      }
      double num1 = ET * this.yieldA + this.yieldB;
      return num1 > 0.0 ? num1 : 0.0;
    }

    public ArrayList GetWeightingFactorStages()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      IEnumerator enumerator = (IEnumerator) this.arrCoefficients.GetEnumerator();
      int num1 = 0;
      while (enumerator.MoveNext())
      {
        int num2 = Convert.ToDateTime(((Measurement) enumerator.Current).Date).DayOfYear;
        if (num2 < num1)
          num2 = 365 - num1 + num1 + num2;
        num1 = num2;
        arrayList2.Add((object) num2);
      }
      switch (this.cropname.ToLower())
      {
        case "corn":
          arrayList1.Add((object) new object[5]
          {
            (object) "Vegetative",
            arrayList2[0],
            (object) ((int) arrayList2[1] - 1),
            (object) "WETFV",
            (object) 36
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Flowering",
            arrayList2[1],
            (object) ((double) (int) arrayList2[1] + 0.15 * (double) ((int) arrayList2[2] - (int) arrayList2[1])),
            (object) "WETFF",
            (object) 33
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Seed Formation",
            (object) ((double) (int) arrayList2[1] + 0.15 * (double) ((int) arrayList2[2] - (int) arrayList2[1])),
            (object) ((double) (int) arrayList2[1] + 0.65 * (double) ((int) arrayList2[2] - (int) arrayList2[1])),
            (object) "WETFFo",
            (object) 25
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Ripening",
            (object) ((double) (int) arrayList2[1] + 0.65 * (double) ((int) arrayList2[2] - (int) arrayList2[1]) + 1.0),
            (object) ((int) arrayList2[2] - 1),
            (object) "WETFR",
            (object) 6
          });
          break;
        case "grain sorghum":
          arrayList1.Add((object) new object[5]
          {
            (object) "Vegetative",
            arrayList2[0],
            (object) (int) arrayList2[1],
            (object) "WETFV",
            (object) 44
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Flowering",
            (object) ((int) arrayList2[1] + 1),
            (object) ((double) ((int) arrayList2[1] + 1) + 19.0 / 54.0 * (double) ((int) arrayList2[2] - (int) arrayList2[1])),
            (object) "WETFF",
            (object) 39
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Seed Formation",
            (object) ((double) ((int) arrayList2[1] + 1) + 19.0 / 54.0 * (double) ((int) arrayList2[2] - (int) arrayList2[1])),
            (object) ((double) ((int) arrayList2[1] + 1) + 7.0 / 9.0 * (double) ((int) arrayList2[2] - (int) arrayList2[1])),
            (object) "WETFFo",
            (object) 14
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Ripening",
            (object) ((double) ((int) arrayList2[1] + 1) + 7.0 / 9.0 * (double) ((int) arrayList2[2] - (int) arrayList2[1]) + 1.0),
            (object) ((int) arrayList2[2] - 1),
            (object) "WETFR",
            (object) 3
          });
          break;
        case "soybean":
          arrayList1.Add((object) new object[5]
          {
            (object) "Vegetative",
            arrayList2[0],
            (object) ((int) arrayList2[1] - 1),
            (object) "WETFV",
            (object) 55
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Flowering",
            (object) (int) arrayList2[1],
            (object) ((int) arrayList2[2] - 1),
            (object) "WETFF",
            (object) 30
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Bean formation",
            (object) (int) arrayList2[2],
            (object) ((int) arrayList2[3] - 1),
            (object) "WETFB",
            (object) 15
          });
          break;
        case "sunflower":
          arrayList1.Add((object) new object[5]
          {
            (object) "Vegetative",
            arrayList2[0],
            (object) (int) arrayList2[2],
            (object) "WETFV",
            (object) 43
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Flowering",
            (object) ((int) arrayList2[2] + 1),
            (object) (int) arrayList2[3],
            (object) "WETFF",
            (object) 33
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Seed Formation",
            (object) ((int) arrayList2[3] + 1),
            (object) ((double) ((int) arrayList2[3] + 1) + 0.7 * (double) ((int) arrayList2[4] - (int) arrayList2[3])),
            (object) "WETFFo",
            (object) 23
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Ripening",
            (object) ((double) ((int) arrayList2[3] + 1) + 0.7 * (double) ((int) arrayList2[4] - (int) arrayList2[3]) + 1.0),
            (object) ((int) arrayList2[4] - 1),
            (object) "WETFR",
            (object) 1
          });
          break;
        case "winter wheat":
          arrayList1.Add((object) new object[5]
          {
            (object) "Vegetative",
            arrayList2[0],
            (object) (int) arrayList2[4],
            (object) "WETFV",
            (object) 49
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Flowering",
            (object) ((int) arrayList2[4] + 1),
            (object) ((double) ((int) arrayList2[4] + 1) + 13.0 / 35.0 * (double) ((int) arrayList2[5] - (int) arrayList2[4])),
            (object) "WETFF",
            (object) 31
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Seed Formation",
            (object) ((double) ((int) arrayList2[4] + 1) + 13.0 / 35.0 * (double) ((int) arrayList2[5] - (int) arrayList2[4]) + 1.0),
            (object) ((double) ((int) arrayList2[4] + 1) + 0.8 * (double) ((int) arrayList2[5] - (int) arrayList2[4])),
            (object) "WETFFo",
            (object) 19
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "Ripening",
            (object) ((double) ((int) arrayList2[4] + 1) + 0.8 * (double) ((int) arrayList2[5] - (int) arrayList2[4]) + 1.0),
            (object) ((int) arrayList2[5] - 1),
            (object) "WETFR",
            (object) 1
          });
          break;
        case "alfalfa":
          arrayList1.Add((object) new object[5]
          {
            (object) "1st Cutting",
            arrayList2[0],
            (object) ((int) arrayList2[1] - 1),
            (object) "1st cutting",
            (object) 0.166
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "2nd Cutting",
            arrayList2[1],
            (object) ((int) arrayList2[2] - 1),
            (object) "2nd Cutting",
            (object) 0.156
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "3rd Cutting",
            arrayList2[2],
            (object) ((int) arrayList2[3] - 1),
            (object) "3rd Cutting",
            (object) 0.112
          });
          arrayList1.Add((object) new object[5]
          {
            (object) "4th Cutting",
            arrayList2[3],
            (object) ((int) arrayList2[4] - 1),
            (object) "4th Cutting",
            (object) 0.127
          });
          if (this.arrCoefficients.Count == 7)
          {
            arrayList1.Add((object) new object[5]
            {
              (object) "5th Cutting",
              arrayList2[4],
              (object) ((int) arrayList2[5] - 1),
              (object) "5th Cutting",
              (object) 0.12
            });
            break;
          }
          break;
      }
      return arrayList1;
    }

    public double EmergenceISWA(double rain, double irrig, Soil soil)
    {
      try
      {
        double[,] numArray;
        switch (soil.SoilName.ToLower())
        {
          case "valentine loamy sand":
            numArray = this.iswa_loamy_sand;
            break;
          default:
            numArray = this.iswa;
            break;
        }
        irrig = Math.Round(irrig);
        rain = Math.Round(rain / 25.4);
        if ((double) numArray.GetUpperBound(0) >= irrig && (double) numArray.GetUpperBound(1) >= rain)
        {
          double num = numArray[Convert.ToInt64(irrig), Convert.ToInt64(rain)];
          return num > 1.0 ? num : 80.0;
        }
        if ((double) numArray.GetUpperBound(0) <= irrig)
          return numArray[numArray.GetUpperBound(0) - 1, 11];
        return numArray[0, 11];
      }
      catch
      {
        return 80.0;
      }
    }

    public double GetRunoffFraction(Soil s, double rain)
    {
      double runoffFactor = s.GetRunoffFactor(rain / 25.4);
      switch (this.cropname.ToLower())
      {
        case "corn":
          runoffFactor += 0.0;
          break;
        case "sorghum":
        case "soybean":
          runoffFactor += 0.01;
          break;
        case "sunflower":
          runoffFactor += 0.03;
          break;
        case "wheat":
        case "alfalfa":
          runoffFactor -= 0.1;
          break;
      }
      if (runoffFactor <= 0.01)
        return 1.0;
      return runoffFactor * 100.0;
    }

    public ArrayList GetCost(InputCost ic)
    {
      ArrayList arrayList = new ArrayList();
      if (ic.Units == "Rs")
      {
        double num1 = ic.Amount;
        double num2;
        if (ic.Factor == "acres")
        {
          num2 = 1.0;
          string factorUnits = ic.FactorUnits;
          if (ic.Name == "swathing" || ic.Name == "baling")
            num2 = ((InputCost) this.GetFactor("cutting_num")).Amount;
        }
        else if (ic.Factor == "yield")
          num2 = this.calcYield;
        else if (ic.Factor == "xtrayield")
        {
          num1 = this.calcYield - ((InputCost) this.GetFactor(ic.Factor)).Amount;
          num2 = ic.Amount;
        }
        else
        {
          InputCost factor = (InputCost) this.GetFactor(ic.Factor);
          num2 = factor.Amount;
          string label = factor.Label;
        }
        arrayList.Add((object) ic.Label);
        arrayList.Add((object) (num1 * num2));
      }
      return arrayList;
    }

    public object GetFactor(string name)
    {
      foreach (InputCost cGeneralCost in (Collection<InputCost>) this.cGeneralCosts)
      {
        if (cGeneralCost.Name == name)
          return (object) cGeneralCost;
      }
      foreach (InputCost cOperationCost in (Collection<InputCost>) this.cOperationCosts)
      {
        if (cOperationCost.Name == name)
          return (object) cOperationCost;
      }
      foreach (InputCost cReturn in (Collection<InputCost>) this.cReturns)
      {
        if (cReturn.Name == name)
          return (object) cReturn;
      }
      return (object) null;
    }

    public static Crop CloneObject(object obj)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      { if (Convert.ToString(obj.GetType()) == "CYP.Crop")
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter((ISurrogateSelector)null, new StreamingContext(StreamingContextStates.Clone));
                    binaryFormatter.Serialize((Stream)memoryStream, obj);
                    memoryStream.Seek(0L, SeekOrigin.Begin);
                    return (Crop)binaryFormatter.Deserialize((Stream)memoryStream);
                }
                else
                    return (Crop)obj;
      }
    }

    public double[] IrrigationCost(CWYModel model)
    {
      double gpm = model.gpm;
      double amount1 = this.cIrrigationCosts[1].Amount;
      double amount2 = this.cIrrigationCosts[2].Amount;
      double fuelprice = model.fuelprice;
      double amount3 = this.cIrrigationCosts[3].Amount;
      double amount4 = this.cIrrigationCosts[4].Amount;
      double num1 = amount1 + amount2 * 2.31;
      double num2 = 1.0 * (1.0 / (gpm / 450.0));
      double num3 = num1 * (gpm / 3960.0) / model.npc * num2 * fuelprice / 1.0;
      return new double[2]{ num2, num3 };
    }
  }
}
