
using System;

namespace CWY
{
  [Serializable]
  public class Result
  {
    private string label;
    private object value;
    private object details;

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

    public object Value
    {
      get
      {
        return this.value;
      }
      set
      {
        this.Value = value;
      }
    }

    public object Details
    {
      get
      {
        return this.details;
      }
      set
      {
        this.Details = value;
      }
    }

    public Result(string ResultLabel, object ResultValue)
    {
      this.label = ResultLabel;
      this.value = ResultValue;
    }

    public Result(string ResultLabel, object ResultValue, string strDetails)
    {
      this.label = ResultLabel;
      this.value = ResultValue;
      this.details = (object) strDetails;
    }
  }
}
