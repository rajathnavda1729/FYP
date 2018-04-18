// Decompiled with JetBrains decompiler
// Type: CWY.LocationData
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System;
using System.Collections;

namespace CWY
{
  [Serializable]
  public class LocationData
  {
    public Hashtable htMaxTemp = new Hashtable();
    public Hashtable htMinTemp = new Hashtable();
    public Hashtable htRad = new Hashtable();
    public Hashtable htPrecipitation = new Hashtable();
    private string locationname;

    public string LocationName
    {
      get
      {
        return this.locationname;
      }
      set
      {
        this.locationname = value;
      }
    }
  }
}
