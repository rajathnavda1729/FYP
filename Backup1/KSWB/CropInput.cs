// Decompiled with JetBrains decompiler
// Type: KSWB.CropInput
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KSWB
{
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  internal class CropInput
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal CropInput()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) CropInput.resourceMan, (object) null))
          CropInput.resourceMan = new ResourceManager("KSWB.CropInput", typeof (CropInput).Assembly);
        return CropInput.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return CropInput.resourceCulture;
      }
      set
      {
        CropInput.resourceCulture = value;
      }
    }

    internal static Point hp_TrayLocation
    {
      get
      {
        return (Point) CropInput.ResourceManager.GetObject("hp.TrayLocation", CropInput.resourceCulture);
      }
    }

    internal static ImageListStreamer images_ImageStream
    {
      get
      {
        return (ImageListStreamer) CropInput.ResourceManager.GetObject("images.ImageStream", CropInput.resourceCulture);
      }
    }

    internal static Point images_TrayLocation
    {
      get
      {
        return (Point) CropInput.ResourceManager.GetObject("images.TrayLocation", CropInput.resourceCulture);
      }
    }
  }
}
