

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
