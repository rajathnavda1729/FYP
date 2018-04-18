// Decompiled with JetBrains decompiler
// Type: KSWB.CustomDataGridView
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KSWB
{
  public class CustomDataGridView : DataGridView
  {
    private IContainer components;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.BeginInit();
      this.SuspendLayout();
      this.AllowUserToAddRows = false;
      this.AllowUserToDeleteRows = false;
      this.AllowUserToResizeRows = false;
      this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.ColumnHeadersVisible = false;
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle.BackColor = SystemColors.Window;
      gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle.ForeColor = SystemColors.ControlText;
      gridViewCellStyle.NullValue = (object) "*";
      gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle.WrapMode = DataGridViewTriState.False;
      this.DefaultCellStyle = gridViewCellStyle;
      this.RowHeadersVisible = false;
      this.DataError += new DataGridViewDataErrorEventHandler(this.CustomDataGridView_DataError);
      this.EndInit();
      this.ResumeLayout(false);
    }

    public CustomDataGridView()
    {
      this.InitializeComponent();
    }

    private void CustomDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      int num = (int) MessageBox.Show("Sorry, please reformat");
    }
  }
}
