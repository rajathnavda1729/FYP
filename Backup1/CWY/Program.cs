// Decompiled with JetBrains decompiler
// Type: CWY.Program
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System;
using System.Windows.Forms;

namespace CWY
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      frmMain frmMain = new frmMain();
      Application.Run((Form) new Start());
    }
  }
}
