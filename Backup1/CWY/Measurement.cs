// Decompiled with JetBrains decompiler
// Type: CWY.Measurement
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System;
using System.ComponentModel;

namespace CWY
{
  [Serializable]
  public class Measurement : INotifyPropertyChanged
  {
    private string date;
    private double amount;
    private string label;

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string name)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(name));
    }

    public string Date
    {
      get
      {
        return this.date;
      }
      set
      {
        this.date = value;
        this.NotifyPropertyChanged(nameof (Date));
      }
    }

    public double Amount
    {
      get
      {
        return this.amount;
      }
      set
      {
        this.amount = value;
        this.NotifyPropertyChanged(nameof (Amount));
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

    public Measurement()
    {
    }

    public Measurement(object TheDate, double TheAmount)
    {
      this.date = Convert.ToString(TheDate);
      this.amount = TheAmount;
    }
  }
}
