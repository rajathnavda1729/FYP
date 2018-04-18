

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
