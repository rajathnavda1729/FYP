
using System.Drawing;
using System.Windows.Forms;

namespace CWY
{
  public class TabControlEx : TabControl
  {
    public PreRemoveTab PreRemoveTabPage;

    public TabControlEx()
    {
      this.PreRemoveTabPage = (PreRemoveTab) null;
      this.DrawMode = TabDrawMode.OwnerDrawFixed;
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
      Rectangle bounds = e.Bounds;
      Rectangle tabRect = this.GetTabRect(e.Index);
      tabRect.Offset(2, 2);
      tabRect.Width = 5;
      tabRect.Height = 5;
      Brush brush = (Brush) new SolidBrush(Color.Black);
      Pen pen = new Pen(brush);
      e.Graphics.DrawLine(pen, tabRect.X, tabRect.Y, tabRect.X + tabRect.Width, tabRect.Y + tabRect.Height);
      e.Graphics.DrawLine(pen, tabRect.X + tabRect.Width, tabRect.Y, tabRect.X, tabRect.Y + tabRect.Height);
      string text = this.TabPages[e.Index].Text;
      Font font = this.Font;
      e.Graphics.DrawString(text, font, brush, new PointF((float) (tabRect.X + 5), (float) tabRect.Y));
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
      Point location = e.Location;
      for (int index = 0; index < this.TabCount; ++index)
      {
        Rectangle tabRect = this.GetTabRect(index);
        tabRect.Offset(2, 2);
        tabRect.Width = 5;
        tabRect.Height = 5;
        if (tabRect.Contains(location))
          this.CloseTab(index);
      }
    }

    private void CloseTab(int i)
    {
      if (this.PreRemoveTabPage != null && !this.PreRemoveTabPage(i))
        return;
      this.TabPages.Remove(this.TabPages[i]);
    }
  }
}
