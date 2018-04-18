
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
