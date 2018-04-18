// Decompiled with JetBrains decompiler
// Type: CWY.Result
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

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
