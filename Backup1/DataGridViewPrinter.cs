// Decompiled with JetBrains decompiler
// Type: DataGridViewPrinter
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

internal class DataGridViewPrinter
{
  private DataGridView TheDataGridView;
  private PrintDocument ThePrintDocument;
  private bool IsCenterOnPage;
  private bool IsWithTitle;
  private string TheTitleText;
  private Font TheTitleFont;
  private Color TheTitleColor;
  private bool IsWithPaging;
  private static int CurrentRow;
  private static int PageNumber;
  private int PageWidth;
  private int PageHeight;
  private int LeftMargin;
  private int TopMargin;
  private int RightMargin;
  private int BottomMargin;
  private float CurrentY;
  private float RowHeaderHeight;
  private List<float> RowsHeight;
  private List<float> ColumnsWidth;
  private float TheDataGridViewWidth;
  private List<int[]> mColumnPoints;
  private List<float> mColumnPointsWidth;
  private int mColumnPoint;

  public DataGridViewPrinter(DataGridView aDataGridView, PrintDocument aPrintDocument, bool CenterOnPage, bool WithTitle, string aTitleText, Font aTitleFont, Color aTitleColor, bool WithPaging)
  {
    this.TheDataGridView = aDataGridView;
    this.ThePrintDocument = aPrintDocument;
    this.IsCenterOnPage = CenterOnPage;
    this.IsWithTitle = WithTitle;
    this.TheTitleText = aTitleText;
    this.TheTitleFont = aTitleFont;
    this.TheTitleColor = aTitleColor;
    this.IsWithPaging = WithPaging;
    DataGridViewPrinter.PageNumber = 0;
    this.RowsHeight = new List<float>();
    this.ColumnsWidth = new List<float>();
    this.mColumnPoints = new List<int[]>();
    this.mColumnPointsWidth = new List<float>();
    if (!this.ThePrintDocument.DefaultPageSettings.Landscape)
    {
      this.PageWidth = this.ThePrintDocument.DefaultPageSettings.PaperSize.Width;
      this.PageHeight = this.ThePrintDocument.DefaultPageSettings.PaperSize.Height;
    }
    else
    {
      this.PageHeight = this.ThePrintDocument.DefaultPageSettings.PaperSize.Width;
      this.PageWidth = this.ThePrintDocument.DefaultPageSettings.PaperSize.Height;
    }
    this.LeftMargin = this.ThePrintDocument.DefaultPageSettings.Margins.Left;
    this.TopMargin = this.ThePrintDocument.DefaultPageSettings.Margins.Top;
    this.RightMargin = this.ThePrintDocument.DefaultPageSettings.Margins.Right;
    this.BottomMargin = this.ThePrintDocument.DefaultPageSettings.Margins.Bottom;
    DataGridViewPrinter.CurrentRow = 0;
  }

  private void Calculate(Graphics g)
  {
    if (DataGridViewPrinter.PageNumber != 0)
      return;
    SizeF sizeF1 = new SizeF();
    this.TheDataGridViewWidth = 0.0f;
    for (int index1 = 0; index1 < this.TheDataGridView.Columns.Count; ++index1)
    {
      Font font1 = this.TheDataGridView.ColumnHeadersDefaultCellStyle.Font ?? this.TheDataGridView.DefaultCellStyle.Font;
      SizeF sizeF2 = g.MeasureString(this.TheDataGridView.Columns[index1].HeaderText, font1);
      float width = sizeF2.Width;
      this.RowHeaderHeight = sizeF2.Height;
      for (int index2 = 0; index2 < this.TheDataGridView.Rows.Count; ++index2)
      {
        Font font2 = this.TheDataGridView.Rows[index2].DefaultCellStyle.Font ?? this.TheDataGridView.DefaultCellStyle.Font;
        sizeF2 = g.MeasureString("Anything", font2);
        this.RowsHeight.Add(sizeF2.Height);
        sizeF2 = g.MeasureString(this.TheDataGridView.Rows[index2].Cells[index1].EditedFormattedValue.ToString(), font2);
        if ((double) sizeF2.Width > (double) width)
          width = sizeF2.Width;
      }
      if (this.TheDataGridView.Columns[index1].Visible)
        this.TheDataGridViewWidth += width;
      this.ColumnsWidth.Add(width);
    }
    int num1 = 0;
    for (int index = 0; index < this.TheDataGridView.Columns.Count; ++index)
    {
      if (this.TheDataGridView.Columns[index].Visible)
      {
        num1 = index;
        break;
      }
    }
    int num2 = this.TheDataGridView.Columns.Count;
    for (int index = this.TheDataGridView.Columns.Count - 1; index >= 0; --index)
    {
      if (this.TheDataGridView.Columns[index].Visible)
      {
        num2 = index + 1;
        break;
      }
    }
    float num3 = this.TheDataGridViewWidth;
    float num4 = (float) this.PageWidth - (float) this.LeftMargin - (float) this.RightMargin;
    if ((double) this.TheDataGridViewWidth > (double) num4)
    {
      num3 = 0.0f;
      for (int index = 0; index < this.TheDataGridView.Columns.Count; ++index)
      {
        if (this.TheDataGridView.Columns[index].Visible)
        {
          num3 += this.ColumnsWidth[index];
          if ((double) num3 > (double) num4)
          {
            float num5 = num3 - this.ColumnsWidth[index];
            this.mColumnPoints.Add(new int[2]{ num1, num2 });
            this.mColumnPointsWidth.Add(num5);
            num1 = index;
            num3 = this.ColumnsWidth[index];
          }
        }
        num2 = index + 1;
      }
    }
    this.mColumnPoints.Add(new int[2]{ num1, num2 });
    this.mColumnPointsWidth.Add(num3);
    this.mColumnPoint = 0;
  }

  private void DrawHeader(Graphics g)
  {
    this.CurrentY = (float) this.TopMargin;
    if (this.IsWithPaging)
    {
      ++DataGridViewPrinter.PageNumber;
      string str = "Page " + DataGridViewPrinter.PageNumber.ToString();
      StringFormat format = new StringFormat();
      format.Trimming = StringTrimming.Word;
      format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
      format.Alignment = StringAlignment.Far;
      Font font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point);
      RectangleF layoutRectangle = new RectangleF((float) this.LeftMargin, this.CurrentY, (float) this.PageWidth - (float) this.RightMargin - (float) this.LeftMargin, g.MeasureString(str, font).Height);
      g.DrawString(str, font, (Brush) new SolidBrush(Color.Black), layoutRectangle, format);
      this.CurrentY += g.MeasureString(str, font).Height;
    }
    if (this.IsWithTitle)
    {
      StringFormat format = new StringFormat();
      format.Trimming = StringTrimming.Word;
      format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
      format.Alignment = !this.IsCenterOnPage ? StringAlignment.Near : StringAlignment.Center;
      RectangleF layoutRectangle = new RectangleF((float) this.LeftMargin, this.CurrentY, (float) this.PageWidth - (float) this.RightMargin - (float) this.LeftMargin, g.MeasureString(this.TheTitleText, this.TheTitleFont).Height);
      g.DrawString(this.TheTitleText, this.TheTitleFont, (Brush) new SolidBrush(this.TheTitleColor), layoutRectangle, format);
      this.CurrentY += g.MeasureString(this.TheTitleText, this.TheTitleFont).Height;
    }
    float leftMargin = (float) this.LeftMargin;
    if (this.IsCenterOnPage)
      leftMargin += (float) (((double) this.PageWidth - (double) this.RightMargin - (double) this.LeftMargin - (double) this.mColumnPointsWidth[this.mColumnPoint]) / 2.0);
    Color foreColor = this.TheDataGridView.ColumnHeadersDefaultCellStyle.ForeColor;
    if (foreColor.IsEmpty)
      foreColor = this.TheDataGridView.DefaultCellStyle.ForeColor;
    SolidBrush solidBrush1 = new SolidBrush(foreColor);
    Color backColor = this.TheDataGridView.ColumnHeadersDefaultCellStyle.BackColor;
    if (backColor.IsEmpty)
      backColor = this.TheDataGridView.DefaultCellStyle.BackColor;
    SolidBrush solidBrush2 = new SolidBrush(backColor);
    Pen pen = new Pen(this.TheDataGridView.GridColor, 1f);
    Font font1 = this.TheDataGridView.ColumnHeadersDefaultCellStyle.Font ?? this.TheDataGridView.DefaultCellStyle.Font;
    RectangleF rect = new RectangleF(leftMargin, this.CurrentY, this.mColumnPointsWidth[this.mColumnPoint], this.RowHeaderHeight);
    g.FillRectangle((Brush) solidBrush2, rect);
    StringFormat format1 = new StringFormat();
    format1.Trimming = StringTrimming.Word;
    format1.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
    for (int index = (int) this.mColumnPoints[this.mColumnPoint].GetValue(0); index < (int) this.mColumnPoints[this.mColumnPoint].GetValue(1); ++index)
    {
      if (this.TheDataGridView.Columns[index].Visible)
      {
        float width = this.ColumnsWidth[index];
        format1.Alignment = !this.TheDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Right") ? (!this.TheDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Center") ? StringAlignment.Near : StringAlignment.Center) : StringAlignment.Far;
        RectangleF layoutRectangle = new RectangleF(leftMargin, this.CurrentY, width, this.RowHeaderHeight);
        g.DrawString(this.TheDataGridView.Columns[index].HeaderText, font1, (Brush) solidBrush1, layoutRectangle, format1);
        if (this.TheDataGridView.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
          g.DrawRectangle(pen, leftMargin, this.CurrentY, width, this.RowHeaderHeight);
        leftMargin += width;
      }
    }
    this.CurrentY += this.RowHeaderHeight;
  }

  private bool DrawRows(Graphics g)
  {
    Pen pen = new Pen(this.TheDataGridView.GridColor, 1f);
    StringFormat format = new StringFormat();
    format.Trimming = StringTrimming.Word;
    format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit;
    for (; DataGridViewPrinter.CurrentRow < this.TheDataGridView.Rows.Count; ++DataGridViewPrinter.CurrentRow)
    {
      if (this.TheDataGridView.Rows[DataGridViewPrinter.CurrentRow].Visible)
      {
        Font font = this.TheDataGridView.Rows[DataGridViewPrinter.CurrentRow].DefaultCellStyle.Font ?? this.TheDataGridView.DefaultCellStyle.Font;
        Color foreColor = this.TheDataGridView.Rows[DataGridViewPrinter.CurrentRow].DefaultCellStyle.ForeColor;
        if (foreColor.IsEmpty)
          foreColor = this.TheDataGridView.DefaultCellStyle.ForeColor;
        SolidBrush solidBrush1 = new SolidBrush(foreColor);
        Color backColor = this.TheDataGridView.Rows[DataGridViewPrinter.CurrentRow].DefaultCellStyle.BackColor;
        SolidBrush solidBrush2;
        if (backColor.IsEmpty)
        {
          solidBrush2 = new SolidBrush(this.TheDataGridView.DefaultCellStyle.BackColor);
          SolidBrush solidBrush3 = new SolidBrush(this.TheDataGridView.AlternatingRowsDefaultCellStyle.BackColor);
        }
        else
        {
          solidBrush2 = new SolidBrush(backColor);
          SolidBrush solidBrush3 = new SolidBrush(backColor);
        }
        float leftMargin = (float) this.LeftMargin;
        if (this.IsCenterOnPage)
          leftMargin += (float) (((double) this.PageWidth - (double) this.RightMargin - (double) this.LeftMargin - (double) this.mColumnPointsWidth[this.mColumnPoint]) / 2.0);
        RectangleF rect = new RectangleF(leftMargin, this.CurrentY, this.mColumnPointsWidth[this.mColumnPoint], this.RowsHeight[DataGridViewPrinter.CurrentRow]);
        SolidBrush solidBrush4 = new SolidBrush(this.TheDataGridView.Rows[DataGridViewPrinter.CurrentRow].Cells[0].Style.BackColor);
        g.FillRectangle((Brush) solidBrush4, rect);
        for (int index = (int) this.mColumnPoints[this.mColumnPoint].GetValue(0); index < (int) this.mColumnPoints[this.mColumnPoint].GetValue(1); ++index)
        {
          if (this.TheDataGridView.Columns[index].Visible)
          {
            SolidBrush solidBrush3 = new SolidBrush(this.TheDataGridView.Rows[DataGridViewPrinter.CurrentRow].Cells[index].Style.ForeColor);
            format.Alignment = !this.TheDataGridView.Columns[index].DefaultCellStyle.Alignment.ToString().Contains("Right") ? (!this.TheDataGridView.Columns[index].DefaultCellStyle.Alignment.ToString().Contains("Center") ? StringAlignment.Near : StringAlignment.Center) : StringAlignment.Far;
            float width = this.ColumnsWidth[index];
            RectangleF layoutRectangle = new RectangleF(leftMargin, this.CurrentY, width, this.RowsHeight[DataGridViewPrinter.CurrentRow]);
            g.DrawString(this.TheDataGridView.Rows[DataGridViewPrinter.CurrentRow].Cells[index].EditedFormattedValue.ToString(), font, (Brush) solidBrush3, layoutRectangle, format);
            if (this.TheDataGridView.CellBorderStyle != DataGridViewCellBorderStyle.None)
              g.DrawRectangle(pen, leftMargin, this.CurrentY, width, this.RowsHeight[DataGridViewPrinter.CurrentRow]);
            leftMargin += width;
          }
        }
        this.CurrentY += this.RowsHeight[DataGridViewPrinter.CurrentRow];
        if ((int) this.CurrentY > this.PageHeight - this.TopMargin - this.BottomMargin)
        {
          ++DataGridViewPrinter.CurrentRow;
          return true;
        }
      }
    }
    DataGridViewPrinter.CurrentRow = 0;
    ++this.mColumnPoint;
    if (this.mColumnPoint != this.mColumnPoints.Count)
      return true;
    this.mColumnPoint = 0;
    return false;
  }

  public bool DrawDataGridView(Graphics g)
  {
    try
    {
      this.Calculate(g);
      this.DrawHeader(g);
      return this.DrawRows(g);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("Operation failed: " + ex.Message.ToString(), Application.ProductName + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      return false;
    }
  }
}
