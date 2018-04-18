// Decompiled with JetBrains decompiler
// Type: KSWB.Properties.Settings
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KSWB.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        return Settings.defaultInstance;
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("Microsoft Sans Serif, 8.25pt")]
    public Font FontSizedefaultUC
    {
      get
      {
        return (Font) this[nameof (FontSizedefaultUC)];
      }
    }

    [DefaultSettingValue("0, 0, 0, 0")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Padding DefaultPadding
    {
      get
      {
        return (Padding) this[nameof (DefaultPadding)];
      }
      set
      {
        this[nameof (DefaultPadding)] = (object) value;
      }
    }

    [DefaultSettingValue("0, 0, 0, 0")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Padding DefaultMargin
    {
      get
      {
        return (Padding) this[nameof (DefaultMargin)];
      }
      set
      {
        this[nameof (DefaultMargin)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("0, 0, 0, 0")]
    [ApplicationScopedSetting]
    public Padding DefaultMargin2
    {
      get
      {
        return (Padding) this[nameof (DefaultMargin2)];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0, 0, 0, 0")]
    public Padding DefaultPadding2
    {
      get
      {
        return (Padding) this[nameof (DefaultPadding2)];
      }
    }
  }
}
