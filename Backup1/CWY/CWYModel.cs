// Decompiled with JetBrains decompiler
// Type: CWY.CWYModel
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CWY
{
  [Serializable]
  public class CWYModel : ICloneable
  {
    public BindingList<Measurement> mRunoff = new BindingList<Measurement>();
    public BindingList<Measurement> mEmergence = new BindingList<Measurement>();
    public BindingList<Measurement> mASW = new BindingList<Measurement>();
    public Soil cSoil = new Soil();
    public LocationData cLocation = new LocationData();
    public BindingList<Crop> cCrops = new BindingList<Crop>();
    public BindingList<CWYModel> PreviousResults = new BindingList<CWYModel>();
    public DataTable ModelData = new DataTable();
    public DataTable ModelData4x = new DataTable();
    private double _residue;
    private double _gpm;
    private string _fueltype;
    private double _fuelprice;
    private double _npc;
    private string _fuelunits;
    private string _forceunits;
    public string modelunits;
    private string units;
    public bool CustomEmergence;
    public bool CustomRunoff;
    public Crop ActiveCrop;
    private double _dblEfficiency;
    private double DblMeasuredWater;
    public double previousPrecip;
    private double _dblTotalPrecip;
    private double _dblAnnualPrecip;
    private double _acres;
    private double _dblAnnualPrecip_display;
    private double _dblRunoff;
    private bool _measuredDate;
    private DateTime _SoilDate;
    public DateTime start;
    public DateTime endDate;

    public object Clone()
    {
      return CWYModel.CloneObject((object) this);
    }

    public event MajorValueUpdateHandler MajorValueChanged;

    public event UnitsChangedUpdateHandler UnitsChanged;

    protected virtual void OnMajorValueChanged()
    {
      this.MajorValueChanged(0);
    }

    protected virtual void OnUnitsChanged()
    {
    }

    public static object CloneObject(object obj)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        BinaryFormatter binaryFormatter = new BinaryFormatter((ISurrogateSelector) null, new StreamingContext(StreamingContextStates.Clone));
        binaryFormatter.Serialize((Stream) memoryStream, obj);
        memoryStream.Seek(0L, SeekOrigin.Begin);
        return binaryFormatter.Deserialize((Stream) memoryStream);
      }
    }

    public double residue
    {
      get
      {
        return this._residue;
      }
      set
      {
        this._residue = value;
      }
    }

    public double gpm
    {
      get
      {
        return this._gpm;
      }
      set
      {
        this._gpm = value;
      }
    }

    public string fueltype
    {
      get
      {
        return this._fueltype;
      }
      set
      {
        this._fueltype = value;
        switch (this._fueltype.ToLower())
        {
          case "diesel":
            this.npc = 12.5;
            this.fuelunits = "gal";
            break;
          case "propane":
            this.npc = 6.89;
            this.fuelunits = "gal";
            break;
          case "natural gas":
            this.npc = 61.7;
            this.fuelunits = "MCF";
            break;
          case "electricity":
            this.npc = 0.885;
            this.fuelunits = "kWh";
            break;
        }
        double fuelprice = this.fuelprice;
      }
    }

    public double fuelprice
    {
      get
      {
        if (this._fuelprice == 0.0)
          return 0.0;
        return this._fuelprice;
      }
      set
      {
        this._fuelprice = value;
      }
    }

    public double npc
    {
      get
      {
        return this._npc;
      }
      set
      {
        this._npc = value;
      }
    }

    public string fuelunits
    {
      get
      {
        return this._fuelunits;
      }
      set
      {
        this._fuelunits = value;
      }
    }

    public string forceunits
    {
      get
      {
        return this.units;
      }
      set
      {
        this.units = value;
      }
    }

    public string Units
    {
      get
      {
        return this.units;
      }
      set
      {
        this.units = value;
        this.modelunits = this.units;
        this.OnUnitsChanged();
        IEnumerator enumerator = (IEnumerator) this.cCrops.GetEnumerator();
        while (enumerator.MoveNext())
          ((Crop) enumerator.Current).units = value;
        string units;
        if ((units = this.units) == null)
          return;
        int num = units == "english" ? 1 : 0;
      }
    }

    public double dblEfficiency
    {
      get
      {
        return this._dblEfficiency;
      }
      set
      {
        this._dblEfficiency = value;
      }
    }

    public double dblMeasuredWater
    {
      get
      {
        return this.DblMeasuredWater;
      }
      set
      {
        this.DblMeasuredWater = value;
      }
    }

    public double dblTotalPrecip
    {
      get
      {
        return this._dblTotalPrecip;
      }
      set
      {
        this._dblTotalPrecip = value;
      }
    }

    public double dblAnnualPrecip
    {
      get
      {
        return this._dblAnnualPrecip;
      }
      set
      {
        this._dblAnnualPrecip = value;
      }
    }

    public double Acres
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

    public double dblAnnualPrecip_display
    {
      get
      {
        switch (this.units)
        {
          case "english":
            return this._dblAnnualPrecip / 25.4;
          default:
            return this._dblAnnualPrecip;
        }
      }
      set
      {
        this.previousPrecip = this._dblAnnualPrecip;
        switch (this.units)
        {
          case "english":
            this._dblAnnualPrecip = value * 25.4;
            break;
          default:
            this._dblAnnualPrecip = value;
            break;
        }
        if (Convert.ToDouble(this.cCrops[0].GetRunoffFraction(this.cSoil, this.previousPrecip).ToString("0.00")) != this.mRunoff[0].Amount)
          return;
        this.OnMajorValueChanged();
      }
    }

    public double dblRunoff
    {
      get
      {
        return this._dblRunoff;
      }
      set
      {
        this._dblRunoff = value;
      }
    }

    public bool measuredDate
    {
      get
      {
        return this._measuredDate;
      }
      set
      {
        this._measuredDate = value;
      }
    }

    public DateTime SoilDate
    {
      get
      {
        return this._SoilDate;
      }
      set
      {
        DateTime dateTime = Convert.ToDateTime(value);
        this._SoilDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      }
    }

    public void SubmitCropRunoff(Crop c, int index)
    {
      IEnumerator enumerator = (IEnumerator) this.mRunoff.GetEnumerator();
      bool flag = false;
      while (enumerator.MoveNext())
      {
        if (((Measurement) enumerator.Current).Date == c.CropName)
          flag = true;
      }
      if (flag)
        return;
      Measurement measurement = new Measurement((object) c.CropName, Convert.ToDouble(c.GetRunoffFraction(this.cSoil, this.dblAnnualPrecip).ToString("0")));
      double num = this.residue <= 90.0 ? (this.residue >= 10.0 ? -9.0 / 800.0 * this.residue + 89.0 / 80.0 : 1.0) : 0.1;
      measurement.Amount = Convert.ToDouble((measurement.Amount * num).ToString("0.0"));
      if (this.mRunoff.Count - 1 >= index)
        this.mRunoff[index] = measurement;
      else
        this.mRunoff.Add(measurement);
    }

    public void SubmitCropEmergence(Crop c, int index)
    {
      if (index == 0)
      {
        this.mEmergence.Clear();
        this.mEmergence.Add(new Measurement((object) c.CropName, this.RunxFour()));
      }
    }

    public double GetRunoffFraction(string crop)
    {
      IEnumerator enumerator = (IEnumerator) this.mRunoff.GetEnumerator();
      double num = 0.13;
      while (enumerator.MoveNext())
      {
        Measurement current = (Measurement) enumerator.Current;
        if (current.Date == crop)
          num = current.Amount;
      }
      return num;
    }

    public double GetEmergenceSWA(string crop)
    {
      IEnumerator enumerator = (IEnumerator) this.mEmergence.GetEnumerator();
      double num = 50.0;
      while (enumerator.MoveNext())
      {
        Measurement current = (Measurement) enumerator.Current;
        if (current.Date == crop)
          num = current.Amount;
      }
      return num;
    }

    public CWYModel()
    {
      this.Units = "english";
      this.fueltype = "Natural Gas";
      this.dblRunoff = 13.0;
      this.dblEfficiency = 85.0;
      this.dblAnnualPrecip = 381.0;
      this.SoilDate = new DateTime(DateTime.Today.Year, 1, 2);
      this.start = new DateTime(DateTime.Now.Year - 1, 10, 1);
      this.dblMeasuredWater = 50.0;
      this.Acres = 130.0;
      this.gpm = 750.0;
    }

    public string Ready()
    {
      if (this.cLocation.LocationName == null)
        return "Please select a location";
      if (this.SoilDate.Equals(DateTime.MinValue))
        return "false";
      foreach (Crop cCrop in (Collection<Crop>) this.cCrops)
      {
        if (cCrop.CropName == null)
          return "false";
      }
      return "true";
    }

    public DataTable NewTable()
    {
      this.ModelData = new DataTable();
      DataColumn column = new DataColumn();
      column.DataType = Type.GetType("System.DateTime");
      column.ColumnName = "day";
      this.ModelData.Columns.Add(column);
      this.ModelData.PrimaryKey = new DataColumn[1]
      {
        column
      };
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Int32"),
        ColumnName = "doy"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "maxf"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "minf"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "ppt"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "usedppt"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "rad"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "maxc"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "minc"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "meanc"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "etr"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "adv"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "realadv"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "advetr"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "sumadvetr"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "kcn"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "advetrkcn"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "sumadvetrkcn"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "epr"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "swi"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "swo"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "dr"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "asw"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "ka"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "ska"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "ir"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "eir"
      });
      this.ModelData.Columns.Add(new DataColumn()
      {
        DataType = Type.GetType("System.Double"),
        ColumnName = "optimalska"
      });
      return this.ModelData;
    }

    public TimeSpan GetDays()
    {
      Crop cCrop = this.cCrops[this.cCrops.Count - 1];
      DateTime dateTime = Convert.ToDateTime(cCrop.arrCoefficients[cCrop.arrCoefficients.Count - 1].Date);
      return new DateTime(this.start.Year + (this.cCrops.Count - 1), dateTime.Month, dateTime.Day).Subtract(this.start);
    }

    public TimeSpan GetDays(bool full)
    {
      return new DateTime(this.start.Year, 12, 31).Subtract(new DateTime(this.start.Year, 1, 1));
    }

    public double RunxFour()
    {
      this.dblTotalPrecip = 0.0;
      IEnumerator enumerator = (IEnumerator) this.cLocation.htPrecipitation.GetEnumerator();
      while (enumerator.MoveNext())
        this.dblTotalPrecip += (double) ((DictionaryEntry) enumerator.Current).Value;
      this.cCrops.GetEnumerator();
      int num1 = 0;
      int year = DateTime.Today.Year;
      for (int index = 0; index < 4; ++index)
      {
        if (index > 0)
          this.cCrops.Add(Crop.CloneObject((object) this.cCrops[0]));
        Crop cCrop1 = this.cCrops[index];
        int num2 = index;
        if (num2 == 0)
        {
          cCrop1.YeartStart = year;
        }
        else
        {
          Crop cCrop2 = this.cCrops[num2 - 1];
          int month1 = Convert.ToDateTime(cCrop2.arrCoefficients[cCrop2.arrCoefficients.Count - 1].Date).Month;
          int month2 = Convert.ToDateTime(cCrop1.arrCoefficients[0].Date).Month;
          if (month1 < month2)
          {
            cCrop1.YeartStart = cCrop2.YeartStart;
          }
          else
          {
            int num3 = month1 >= Convert.ToDateTime(cCrop2.arrCoefficients[0].Date).Month ? Convert.ToDateTime(cCrop2.arrCoefficients[cCrop2.arrCoefficients.Count - 1].Date).Subtract(Convert.ToDateTime(cCrop2.arrCoefficients[0].Date)).Days : 365 - Convert.ToDateTime(cCrop2.arrCoefficients[0].Date).DayOfYear + Convert.ToDateTime(cCrop2.arrCoefficients[cCrop2.arrCoefficients.Count - 1].Date).DayOfYear;
            DateTime dateTime = new DateTime(cCrop2.YeartStart, Convert.ToDateTime(cCrop2.arrCoefficients[0].Date).Month, Convert.ToDateTime(cCrop2.arrCoefficients[0].Date).Day).AddDays((double) num3);
            cCrop1.YeartStart = dateTime.Year + 1;
          }
          foreach (Measurement measurement in (Collection<Measurement>) cCrop1.cIrrigation)
            ;
        }
        cCrop1.calcDates = cCrop1.CalcDates(cCrop1.ConvertToArrayList(cCrop1.arrCoefficients));
        ++num1;
      }
      this.ActiveCrop = this.cCrops[0];
      DataTable dt = this.NewTable();
      DateTime dateTime1 = this.start;
      Convert.ToDateTime(this.cCrops[this.cCrops.Count - 1].calcDates[this.cCrops[this.cCrops.Count - 1].calcDates.Count - 1]);
      DateTime dateTime2 = this.start.AddYears(4);
      this.endDate = dateTime2;
      if (Convert.ToDateTime(this.ActiveCrop.calcDates[0]).CompareTo(this.start) >= 0)
        ;
      for (; dateTime1.CompareTo(dateTime2) <= 0; dateTime1 = dateTime1.AddDays(1.0))
      {
        this.ActiveCrop = this.SetActiveCrop(dateTime1);
        dt.Rows.Add(this.CalculateRow(dt, dateTime1));
      }
      this.ModelData = dt;
      double num4 = 0.0;
      foreach (DataRow row in (InternalDataCollectionBase) this.ModelData.Rows)
        num4 += Convert.ToDouble(Convert.ToDouble(row["eir"]).ToString("0.0"));
      this.cCrops.RemoveAt(3);
      this.cCrops.RemoveAt(2);
      this.cCrops.RemoveAt(1);
      this.ModelData4x = this.ModelData;
      double num5 = Convert.ToDouble(Convert.ToDouble(this.ModelData.Rows[this.ModelData.Rows.Count - 1]["asw"]).ToString("0.0"));
      this.ModelData4x.Dispose();
      this.ModelData4x = (DataTable) null;
      return num5;
    }

    public bool Run()
    {
      this.dblTotalPrecip = 0.0;
      IEnumerator enumerator1 = (IEnumerator) this.cLocation.htPrecipitation.GetEnumerator();
      while (enumerator1.MoveNext())
        this.dblTotalPrecip += (double) ((DictionaryEntry) enumerator1.Current).Value;
      IEnumerator enumerator2 = (IEnumerator) this.cCrops.GetEnumerator();
      int num1 = 0;
      int year = DateTime.Today.Year;
      while (enumerator2.MoveNext())
      {
        Crop current = (Crop) enumerator2.Current;
        int num2 = this.cCrops.IndexOf(current);
        if (num2 == 0)
        {
          current.YeartStart = !(current.CropName == "Winter Wheat") ? this.start.Year + 1 : this.start.Year;
        }
        else
        {
          this.start = new DateTime(DateTime.Now.Year - 1, 10, 1);
          Crop cCrop = this.cCrops[num2 - 1];
          int month1 = Convert.ToDateTime(cCrop.arrCoefficients[cCrop.arrCoefficients.Count - 1].Date).Month;
          int month2 = Convert.ToDateTime(current.arrCoefficients[0].Date).Month;
          if (month1 < month2)
          {
            current.YeartStart = cCrop.YeartStart;
          }
          else
          {
            int num3 = month1 >= Convert.ToDateTime(cCrop.arrCoefficients[0].Date).Month ? Convert.ToDateTime(cCrop.arrCoefficients[cCrop.arrCoefficients.Count - 1].Date).Subtract(Convert.ToDateTime(cCrop.arrCoefficients[0].Date)).Days : 365 - Convert.ToDateTime(cCrop.arrCoefficients[0].Date).DayOfYear + Convert.ToDateTime(cCrop.arrCoefficients[cCrop.arrCoefficients.Count - 1].Date).DayOfYear;
            DateTime dateTime = new DateTime(cCrop.YeartStart, Convert.ToDateTime(cCrop.arrCoefficients[0].Date).Month, Convert.ToDateTime(cCrop.arrCoefficients[0].Date).Day).AddDays((double) num3);
            current.YeartStart = dateTime.Year + 1;
          }
        }
        current.calcDates = current.CalcDates(current.ConvertToArrayList(current.arrCoefficients));
        ++num1;
      }
      this.ActiveCrop = this.cCrops[0];
      DataTable dt = this.NewTable();
      Convert.ToDateTime(this.cCrops[this.cCrops.Count - 1].calcDates[this.cCrops[this.cCrops.Count - 1].calcDates.Count - 1]);
      this.endDate = this.start.AddYears(1).AddDays(-1.0);
      DateTime calcDate1 = (DateTime) this.ActiveCrop.calcDates[0];
      DateTime calcDate2 = (DateTime) this.ActiveCrop.calcDates[this.ActiveCrop.arrCoefficients.Count - 1];
      this.start = calcDate1.CompareTo(this.start) <= 0 ? calcDate1 : this.start;
      this.endDate = calcDate2.CompareTo(this.endDate) >= 0 ? calcDate2 : this.endDate;
      for (DateTime dateTime = this.start; dateTime.CompareTo(this.endDate) <= 0; dateTime = dateTime.AddDays(1.0))
      {
        this.ActiveCrop = this.SetActiveCrop(dateTime);
        dt.Rows.Add(this.CalculateRow(dt, dateTime));
      }
      this.ModelData = dt;
      return true;
    }

    public Crop SetActiveCrop(DateTime d)
    {
      Crop activeCrop = this.ActiveCrop;
      if (this.cCrops.Count > 1 && this.cCrops.Count >= this.cCrops.IndexOf(this.ActiveCrop) + 2)
      {
        Crop cCrop = this.cCrops[this.cCrops.IndexOf(this.ActiveCrop) + 1];
        if (d.CompareTo(Convert.ToDateTime(activeCrop.calcDates[activeCrop.calcDates.Count - 1])) >= 0)
          return cCrop;
      }
      return activeCrop;
    }

    public double Total(string Column, object start, object end)
    {
      double num1 = 0.0;
      if (start == null)
        start = (object) (DateTime) this.ModelData.Rows[0]["day"];
      if (end == null)
        end = (object) (DateTime) this.ModelData.Rows[this.ModelData.Rows.Count - 1]["day"];
      int num2 = this.ModelData.Rows.IndexOf(this.ModelData.Rows.Find(start));
      int num3 = this.ModelData.Rows.IndexOf(this.ModelData.Rows.Find(end));
      int num4 = num2 < 0 ? 0 : num2;
      int num5 = num3 < 0 ? 0 : num3;
      for (int index = num4; index <= num5; ++index)
      {
        if (this.ModelData.Rows[index][Column].GetType().ToString() != "System.DBNull")
          num1 += Convert.ToDouble(this.ModelData.Rows[index][Column]);
      }
      return num1;
    }

    public DataRow CalculateRow(DataTable dt, DateTime day)
    {
      DataRow prev = this.YesterdayRow(dt, day);
      DataRow dr = dt.NewRow();
      dr[nameof (day)] = (object) day.ToString();
      dr["doy"] = (object) day.DayOfYear;
      dr["maxf"] = this.GetData(this.cLocation.htMaxTemp, day);
      dr["minf"] = this.GetData(this.cLocation.htMinTemp, day);
      dr["ppt"] = this.GetData(this.cLocation.htPrecipitation, day);
      dr["usedppt"] = (object) this.UsedPPT((double) dr["ppt"]);
      dr["rad"] = this.GetData(this.cLocation.htRad, day);
      dr["maxc"] = (object) this.ConvertC((double) dr["maxf"]);
      dr["minc"] = (object) this.ConvertC((double) dr["minf"]);
      dr["meanc"] = (object) (((double) dr["maxc"] + (double) dr["minc"]) / 2.0);
      dr["etr"] = (object) this.GetReferenceET(dr);
      dr["adv"] = (object) this.GetAdvection(dr);
      dr["realadv"] = (object) this.GetRealAdvection(dr);
      dr["advetr"] = (object) ((1.0 + (double) dr["realadv"]) * (double) dr["etr"]);
      dr["sumadvetr"] = (object) this.SumAdvETr(dr, prev);
      dr["kcn"] = (object) this.GetCoefficient(dr);
      dr["advetrkcn"] = (object) ((double) dr["advetr"] * (double) dr["kcn"]);
      dr["sumadvetrkcn"] = (object) this.SumAdvETrKCN(dr, prev);
      dr["epr"] = (object) this.GetEPR(dr);
      dr["swi"] = (object) this.GetSWI(dr, prev);
      dr["dr"] = (object) this.GetDR(dr);
      dr["asw"] = (object) this.GetASW(dr);
      dr["ka"] = (object) this.GetKa(dr);
      dr["ska"] = (object) ((double) dr["advetrkcn"] * (double) dr["ka"]);
      dr["optimalska"] = (object) (double) dr["advetrkcn"];
      dr["eir"] = (object) this.GetEIR(dr);
      dr["swo"] = (object) this.GetSWO(dr);
      return dr;
    }

    public double GetSWO(DataRow dr)
    {
      return (double) dr["swi"] + (double) dr["epr"] - (double) dr[nameof (dr)] - (double) dr["ska"] + (double) dr["eir"];
    }

    public double GetEIR(DataRow dr)
    {
      double num = 0.0;
      foreach (Measurement measurement in (Collection<Measurement>) this.ActiveCrop.cIrrigation)
      {
        DateTime dateTime = Convert.ToDateTime(measurement.Date);
        if ((!(this.ActiveCrop.CropName == "Winter Wheat") ? dateTime.AddYears(this.ActiveCrop.YeartStart - dateTime.Year) : dateTime.AddYears(0)).CompareTo((DateTime) dr["day"]) == 0)
        {
          dr["ir"] = (object) measurement.Amount;
          num += measurement.Amount * (this.dblEfficiency / 100.0);
        }
      }
      return num;
    }

    public double GetKa(DataRow dr)
    {
      double num = Math.Log10((double) dr["asw"] + 1.0) / Math.Log10(101.0);
      if (num < 0.02)
        return 0.02;
      if (num > 1.0)
        return 1.0;
      return num;
    }

    public double GetASW(DataRow dr)
    {
      double num = ((double) dr["swi"] - this.cSoil.dblPermanentWilt) / (this.cSoil.dblFieldCapacity - this.cSoil.dblPermanentWilt) * 100.0;
      if (num < 0.0)
        return 0.0;
      if (num > 100.0)
        return 100.0;
      return num;
    }

    public double GetDR(DataRow dr)
    {
      double num = this.cSoil.dblAFactor * Math.Pow((double) dr["swi"] / this.cSoil.dblBFactor, this.cSoil.dblCFactor);
      if (num > 50.8)
        return 50.8;
      return num;
    }

    public double FindASW(DateTime date)
    {
      foreach (Measurement measurement in (Collection<Measurement>) this.mASW)
      {
        try
        {
          DateTime dateTime1 = Convert.ToDateTime(measurement.Date);
          DateTime dateTime2 = Convert.ToDateTime(this.ActiveCrop.arrCoefficients[0].Date);
          if (this.ActiveCrop.CropName == "Winter Wheat" && dateTime1.Month < dateTime2.Month)
            dateTime1 = dateTime1.AddYears(1);
          if (dateTime1.CompareTo(date) == 0)
            return measurement.Amount;
        }
        catch
        {
        }
      }
      return -1.0;
    }

    public double GetSWI(DataRow dr, DataRow prev)
    {
      double asw = this.FindASW(Convert.ToDateTime(dr["day"]));
      if (asw > -1.0)
        return asw / 100.0 * (this.cSoil.dblFieldCapacity - this.cSoil.dblPermanentWilt) + this.cSoil.dblPermanentWilt;
      if (((DateTime) dr["day"]).CompareTo(this.SoilDate) == 0 && this.measuredDate)
        return this.dblMeasuredWater / 100.0 * (this.cSoil.dblFieldCapacity - this.cSoil.dblPermanentWilt) + this.cSoil.dblPermanentWilt;
      if (((DateTime) dr["day"]).CompareTo(this.start) == 0)
        return this.GetEmergenceSWA(this.ActiveCrop.CropName) / 100.0 * (this.cSoil.dblFieldCapacity - this.cSoil.dblPermanentWilt) + this.cSoil.dblPermanentWilt;
      if ((double) prev["swo"] > this.cSoil.dblMaximumWater)
        return this.cSoil.dblMaximumWater;
      if ((double) prev["swo"] < this.cSoil.dblPermanentWilt)
        return this.cSoil.dblPermanentWilt;
      return (double) prev["swo"];
    }

    public double GetEPR(DataRow dr)
    {
      return (double) dr["usedppt"] * (1.0 - this.GetRunoffFraction(this.ActiveCrop.CropName) / 100.0) * 25.4;
    }

    public double GetCoefficient(DataRow dr)
    {
      ArrayList coefficientCurveArray1 = this.ActiveCrop.GetCoefficientCurveArray();
      int dayOfYear = Convert.ToDateTime(dr["day"]).DayOfYear;
      int index = -1;
      foreach (Measurement measurement in coefficientCurveArray1)
      {
        long result;
        long.TryParse(measurement.Date, out result);
        if (Convert.ToDateTime(dr["day"]).CompareTo(this.ActiveCrop.GetDateFromDOY(Convert.ToInt32(result))) >= 0)
          index = coefficientCurveArray1.IndexOf((object) measurement);
      }
      ArrayList coefficientCurveArray2 = this.ActiveCrop.GetCoefficientCurveArray();
      Convert.ToDateTime(dr["day"]).CompareTo(new DateTime(2009, 5, 1));
      if (index < 0 || index == coefficientCurveArray2.Count - 1)
        return this.BareSoil(dr);
      double amount1 = ((Measurement) coefficientCurveArray2[index + 1]).Amount;
      double amount2 = ((Measurement) coefficientCurveArray2[index]).Amount;
      int int32_1 = Convert.ToInt32(Convert.ToDouble(((Measurement) coefficientCurveArray2[index + 1]).Date));
      int int32_2 = Convert.ToInt32(Convert.ToDouble(((Measurement) coefficientCurveArray2[index]).Date));
      double num = (amount1 - amount2) / (double) (int32_1 - int32_2);
      double amount3 = ((Measurement) coefficientCurveArray2[index]).Amount;
      if (amount3 == 1.06)
        ;
      return amount3 + num * (double) (Convert.ToDateTime(dr["day"]).DayOfYear - int32_2);
    }

    public double BareSoil(DataRow dr)
    {
      return 0.646 - 0.129 * (double) dr["etr"] + (0.0129 * Math.Pow((double) dr["etr"], 2.0) - 0.000491 * Math.Pow((double) dr["etr"], 3.0));
    }

    public DataRow YesterdayRow(DataTable dt, DateTime date)
    {
      return dt.Rows.Find((object) date.AddDays(-1.0));
    }

    public double SumAdvETr(DataRow dr, DataRow prev)
    {
      double num = 0.0;
      if (prev != null)
        num = (double) prev["sumadvetr"];
      return num + (double) dr["advetr"];
    }

    public double SumAdvETrKCN(DataRow dr, DataRow prev)
    {
      double num = 0.0;
      if (prev != null)
        num = (double) prev["sumadvetrkcn"];
      return num + (double) dr["advetrkcn"];
    }

    public double GetRealAdvection(DataRow dr)
    {
      if ((double) dr["adv"] > 0.25)
        return 0.25;
      return (double) dr["adv"];
    }

    public double GetAdvection(DataRow dr)
    {
      if ((double) dr["maxc"] <= 33.0)
        return 0.0;
      return 0.05 * ((double) dr["maxc"] - 33.0);
    }

    public double GetReferenceET(DataRow dr)
    {
      return (0.078 + 0.0252 * (double) dr["meanc"]) * (double) dr["rad"] / (2.493 - 0.00214 * (double) dr["meanc"]);
    }

    public double UsedPPT(double ppt)
    {
      return this.dblAnnualPrecip / 25.4 / this.dblTotalPrecip * ppt;
    }

    public double ConvertC(double tmpF)
    {
      double num = (tmpF - 32.0) * 5.0 / 9.0;
      if (num <= 0.0)
        return 0.0;
      return num;
    }

    public object GetData(Hashtable ht, DateTime theKey)
    {
      if (theKey.ToString("MM/dd") == "02/29")
        theKey = theKey.AddDays(1.0);
      if (ht.ContainsKey((object) theKey.ToString("MM/dd")))
        return ht[(object) theKey.ToString("MM/dd")];
      return (object) false;
    }
  }
}
