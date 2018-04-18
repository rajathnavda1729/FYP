// Decompiled with JetBrains decompiler
// Type: CWY.CropResults
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using ExcelLibrary.SpreadSheet;
using KSWB.Properties;
using NPlot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CWY
{
  public class CropResults : UserControl
  {
    public BindingList<Result> rsltStandard = new BindingList<Result>();
    public DataTable rsltStandardDT = new DataTable();
    public BindingList<Result> rsltDetailed = new BindingList<Result>();
    public BindingList<Result> rsltInputs = new BindingList<Result>();
    public int intCostsResultsStart = -1;
    private IContainer components;
    public TabControl tcResultPages;
    private TabPage tpResults;
    private TabPage tpGraph;
    public TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private NPlot.Windows.PlotSurface2D npET;
    private TabPage tabPage3;
    private NPlot.Windows.PlotSurface2D npDrainage;
    private TabPage tpExcel;
    private DataGridView dgExcel;
    private PrintDocument pd;
    private ImageList buttons;
    public DataGridView dgStandardResults;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem printToolStripMenuItem;
    private MenuStrip menuStrip3;
    private ToolStripMenuItem printToolStripMenuItem2;
    private MenuStrip menuStrip4;
    private ToolStripMenuItem printToolStripMenuItem3;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem2;
    private ToolStripMenuItem helpToolStripMenuItem3;
    private HelpProvider hp;
    private SaveFileDialog saveResults;
    private ToolStripMenuItem sToolStripMenuItem;
    private ToolStripMenuItem mnuKeep;
    private NPlot.Windows.PlotSurface2D npBalance;
    private MenuStrip menuStrip2;
    private ToolStripMenuItem printToolStripMenuItem1;
    private ToolStripMenuItem helpToolStripMenuItem1;
    private TabPage tpReturns;
    public DataGridView dgCosts;
    private MenuStrip menuStrip5;
    private ToolStripMenuItem printToolStripMenuItem4;
    private ToolStripMenuItem helpToolStripMenuItem4;
    private MenuStrip menuStrip6;
    private ToolStripMenuItem helpToolStripMenuItem5;
    private DataGridViewPrinter dgvPrinter;
    private CWYModel model;
    public int cropIndex;
    public Color outputColor;
    public int ResultNumber;
    public Color headerColor;
    public int intResultsStart;
    public bool stopFormatting;
    private string _title;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CropResults));
      this.tcResultPages = new TabControl();
      this.tpResults = new TabPage();
      this.dgStandardResults = new DataGridView();
      this.menuStrip1 = new MenuStrip();
      this.printToolStripMenuItem = new ToolStripMenuItem();
      this.sToolStripMenuItem = new ToolStripMenuItem();
      this.helpToolStripMenuItem = new ToolStripMenuItem();
      this.mnuKeep = new ToolStripMenuItem();
      this.tpGraph = new TabPage();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.npBalance = new NPlot.Windows.PlotSurface2D();
      this.menuStrip2 = new MenuStrip();
      this.printToolStripMenuItem1 = new ToolStripMenuItem();
      this.helpToolStripMenuItem1 = new ToolStripMenuItem();
      this.tabPage2 = new TabPage();
      this.npET = new NPlot.Windows.PlotSurface2D();
      this.menuStrip3 = new MenuStrip();
      this.printToolStripMenuItem2 = new ToolStripMenuItem();
      this.helpToolStripMenuItem2 = new ToolStripMenuItem();
      this.tabPage3 = new TabPage();
      this.npDrainage = new NPlot.Windows.PlotSurface2D();
      this.menuStrip4 = new MenuStrip();
      this.printToolStripMenuItem3 = new ToolStripMenuItem();
      this.helpToolStripMenuItem3 = new ToolStripMenuItem();
      this.tpExcel = new TabPage();
      this.dgExcel = new DataGridView();
      this.pd = new PrintDocument();
      this.buttons = new ImageList(this.components);
      this.hp = new HelpProvider();
      this.saveResults = new SaveFileDialog();
      this.menuStrip5 = new MenuStrip();
      this.printToolStripMenuItem4 = new ToolStripMenuItem();
      this.dgCosts = new DataGridView();
      this.tpReturns = new TabPage();
      this.helpToolStripMenuItem4 = new ToolStripMenuItem();
      this.menuStrip6 = new MenuStrip();
      this.helpToolStripMenuItem5 = new ToolStripMenuItem();
      this.tcResultPages.SuspendLayout();
      this.tpResults.SuspendLayout();
      ((ISupportInitialize) this.dgStandardResults).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.tpGraph.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.menuStrip2.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.menuStrip3.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.menuStrip4.SuspendLayout();
      this.tpExcel.SuspendLayout();
      ((ISupportInitialize) this.dgExcel).BeginInit();
      this.menuStrip5.SuspendLayout();
      ((ISupportInitialize) this.dgCosts).BeginInit();
      this.tpReturns.SuspendLayout();
      this.menuStrip6.SuspendLayout();
      this.SuspendLayout();
      this.tcResultPages.Controls.Add((Control) this.tpResults);
      this.tcResultPages.Controls.Add((Control) this.tpGraph);
      this.tcResultPages.Controls.Add((Control) this.tpReturns);
      this.tcResultPages.Controls.Add((Control) this.tpExcel);
      this.tcResultPages.Dock = DockStyle.Fill;
      this.tcResultPages.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tcResultPages.Location = new Point(0, 0);
      this.tcResultPages.Margin = new Padding(0);
      this.tcResultPages.Name = "tcResultPages";
      this.tcResultPages.Padding = new Point(20, 5);
      this.tcResultPages.SelectedIndex = 0;
      this.tcResultPages.Size = new Size(400, 400);
      this.tcResultPages.TabIndex = 0;
      this.tcResultPages.Click += new EventHandler(this.tcResultPages_Click);
      this.tcResultPages.SelectedIndexChanged += new EventHandler(this.tcResultPages_SelectedIndexChanged);
      this.tpResults.AutoScroll = true;
      this.tpResults.BackColor = Color.White;
      this.tpResults.Controls.Add((Control) this.dgStandardResults);
      this.tpResults.Controls.Add((Control) this.menuStrip1);
      this.tpResults.Location = new Point(4, 26);
      this.tpResults.Margin = new Padding(0);
      this.tpResults.Name = "tpResults";
      this.tpResults.Size = new Size(392, 370);
      this.tpResults.TabIndex = 0;
      this.tpResults.Text = "Table";
      this.tpResults.UseVisualStyleBackColor = true;
      this.dgStandardResults.AllowUserToAddRows = false;
      this.dgStandardResults.AllowUserToDeleteRows = false;
      this.dgStandardResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dgStandardResults.BackgroundColor = Color.White;
      this.dgStandardResults.BorderStyle = BorderStyle.None;
      this.dgStandardResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgStandardResults.ColumnHeadersVisible = false;
      this.dgStandardResults.Dock = DockStyle.Fill;
      this.dgStandardResults.Location = new Point(0, 24);
      this.dgStandardResults.Margin = new Padding(0);
      this.dgStandardResults.Name = "dgStandardResults";
      this.dgStandardResults.ReadOnly = true;
      this.dgStandardResults.RowHeadersVisible = false;
      this.dgStandardResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgStandardResults.Size = new Size(392, 346);
      this.dgStandardResults.TabIndex = 16;
      this.menuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.printToolStripMenuItem,
        (ToolStripItem) this.sToolStripMenuItem,
        (ToolStripItem) this.helpToolStripMenuItem,
        (ToolStripItem) this.mnuKeep
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(392, 24);
      this.menuStrip1.TabIndex = 17;
      this.menuStrip1.Text = "menuStrip1";
      this.printToolStripMenuItem.Image = (Image) Resources.printer;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.Size = new Size(60, 20);
      this.printToolStripMenuItem.Text = "Print";
      this.printToolStripMenuItem.Click += new EventHandler(this.printToolStripMenuItem_Click);
      this.sToolStripMenuItem.Image = (Image) Resources.page_white_excel;
      this.sToolStripMenuItem.Name = "sToolStripMenuItem";
      this.sToolStripMenuItem.Size = new Size(159, 20);
      this.sToolStripMenuItem.Text = "Save All Results to Excel";
      this.sToolStripMenuItem.Click += new EventHandler(this.sToolStripMenuItem_Click);
      this.helpToolStripMenuItem.Image = (Image) Resources.help;
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new Size(60, 20);
      this.helpToolStripMenuItem.Text = "Help";
      this.helpToolStripMenuItem.Click += new EventHandler(this.helpToolStripMenuItem_Click);
      this.mnuKeep.Name = "mnuKeep";
      this.mnuKeep.Size = new Size(148, 20);
      this.mnuKeep.Text = "Restart with these inputs";
      this.mnuKeep.Click += new EventHandler(this.keepRToolStripMenuItem_Click);
      this.tpGraph.AutoScroll = true;
      this.tpGraph.BackColor = Color.White;
      this.tpGraph.Controls.Add((Control) this.tabControl1);
      this.tpGraph.Location = new Point(4, 26);
      this.tpGraph.Name = "tpGraph";
      this.tpGraph.Size = new Size(392, 370);
      this.tpGraph.TabIndex = 2;
      this.tpGraph.Text = "Graph";
      this.tpGraph.UseVisualStyleBackColor = true;
      this.tpGraph.Click += new EventHandler(this.tpGraph_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(392, 370);
      this.tabControl1.TabIndex = 4;
      this.tabControl1.Click += new EventHandler(this.tabControl1_Click);
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabPage1.Controls.Add((Control) this.npBalance);
      this.tabPage1.Controls.Add((Control) this.menuStrip2);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(384, 344);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Soil Water Balance";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage1.Click += new EventHandler(this.tabPage1_Click);
      this.npBalance.AutoScaleAutoGeneratedAxes = false;
      this.npBalance.AutoScaleTitle = false;
      this.npBalance.BackColor = SystemColors.ControlLightLight;
      this.npBalance.DateTimeToolTip = false;
      this.npBalance.Dock = DockStyle.Fill;
      this.npBalance.Legend = (Legend) null;
      this.npBalance.LegendZOrder = -1;
      this.npBalance.Location = new Point(3, 27);
      this.npBalance.Name = "npBalance";
      this.npBalance.RightMenu = (NPlot.Windows.PlotSurface2D.PlotContextMenu) null;
      this.npBalance.ShowCoordinates = true;
      this.npBalance.Size = new Size(378, 314);
      this.npBalance.SmoothingMode = SmoothingMode.None;
      this.npBalance.TabIndex = 8;
      this.npBalance.Text = "plotSurface2D1";
      this.npBalance.Title = "";
      this.npBalance.TitleFont = new Font("Arial", 14f, FontStyle.Regular, GraphicsUnit.Pixel);
      this.npBalance.XAxis1 = (Axis) null;
      this.npBalance.XAxis2 = (Axis) null;
      this.npBalance.YAxis1 = (Axis) null;
      this.npBalance.YAxis2 = (Axis) null;
      this.menuStrip2.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.printToolStripMenuItem1,
        (ToolStripItem) this.helpToolStripMenuItem1
      });
      this.menuStrip2.Location = new Point(3, 3);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new Size(378, 24);
      this.menuStrip2.TabIndex = 7;
      this.menuStrip2.Text = "menuStrip2";
      this.printToolStripMenuItem1.Image = (Image) Resources.printer;
      this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
      this.printToolStripMenuItem1.Size = new Size(60, 20);
      this.printToolStripMenuItem1.Text = "Print";
      this.printToolStripMenuItem1.Click += new EventHandler(this.printToolStripMenuItem1_Click_1);
      this.helpToolStripMenuItem1.Image = (Image) Resources.help;
      this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
      this.helpToolStripMenuItem1.Size = new Size(60, 20);
      this.helpToolStripMenuItem1.Text = "Help";
      this.helpToolStripMenuItem1.Click += new EventHandler(this.helpToolStripMenuItem1_Click_1);
      this.tabPage2.Controls.Add((Control) this.npET);
      this.tabPage2.Controls.Add((Control) this.menuStrip3);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(384, 344);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Evapotranspiration";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.npET.AutoScaleAutoGeneratedAxes = false;
      this.npET.AutoScaleTitle = false;
      this.npET.BackColor = SystemColors.ControlLightLight;
      this.npET.DateTimeToolTip = false;
      this.npET.Dock = DockStyle.Fill;
      this.npET.Legend = (Legend) null;
      this.npET.LegendZOrder = -1;
      this.npET.Location = new Point(3, 27);
      this.npET.Name = "npET";
      this.npET.RightMenu = (NPlot.Windows.PlotSurface2D.PlotContextMenu) null;
      this.npET.ShowCoordinates = true;
      this.npET.Size = new Size(378, 314);
      this.npET.SmoothingMode = SmoothingMode.None;
      this.npET.TabIndex = 4;
      this.npET.Text = "plotSurface2D1";
      this.npET.Title = "";
      this.npET.TitleFont = new Font("Arial", 14f, FontStyle.Regular, GraphicsUnit.Pixel);
      this.npET.XAxis1 = (Axis) null;
      this.npET.XAxis2 = (Axis) null;
      this.npET.YAxis1 = (Axis) null;
      this.npET.YAxis2 = (Axis) null;
      this.menuStrip3.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.printToolStripMenuItem2,
        (ToolStripItem) this.helpToolStripMenuItem2
      });
      this.menuStrip3.Location = new Point(3, 3);
      this.menuStrip3.Name = "menuStrip3";
      this.menuStrip3.Size = new Size(378, 24);
      this.menuStrip3.TabIndex = 5;
      this.menuStrip3.Text = "menuStrip3";
      this.printToolStripMenuItem2.Image = (Image) Resources.printer;
      this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
      this.printToolStripMenuItem2.Size = new Size(60, 20);
      this.printToolStripMenuItem2.Text = "Print";
      this.printToolStripMenuItem2.Click += new EventHandler(this.printToolStripMenuItem2_Click);
      this.helpToolStripMenuItem2.Image = (Image) Resources.help;
      this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
      this.helpToolStripMenuItem2.Size = new Size(76, 20);
      this.helpToolStripMenuItem2.Text = "ET Help";
      this.helpToolStripMenuItem2.Click += new EventHandler(this.helpToolStripMenuItem2_Click);
      this.tabPage3.Controls.Add((Control) this.npDrainage);
      this.tabPage3.Controls.Add((Control) this.menuStrip4);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(384, 344);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Drainage";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.npDrainage.AutoScaleAutoGeneratedAxes = false;
      this.npDrainage.AutoScaleTitle = false;
      this.npDrainage.BackColor = SystemColors.ControlLightLight;
      this.npDrainage.DateTimeToolTip = false;
      this.npDrainage.Dock = DockStyle.Fill;
      this.npDrainage.Legend = (Legend) null;
      this.npDrainage.LegendZOrder = -1;
      this.npDrainage.Location = new Point(3, 27);
      this.npDrainage.Name = "npDrainage";
      this.npDrainage.RightMenu = (NPlot.Windows.PlotSurface2D.PlotContextMenu) null;
      this.npDrainage.ShowCoordinates = true;
      this.npDrainage.Size = new Size(378, 314);
      this.npDrainage.SmoothingMode = SmoothingMode.None;
      this.npDrainage.TabIndex = 4;
      this.npDrainage.Text = "plotSurface2D1";
      this.npDrainage.Title = "";
      this.npDrainage.TitleFont = new Font("Arial", 14f, FontStyle.Regular, GraphicsUnit.Pixel);
      this.npDrainage.XAxis1 = (Axis) null;
      this.npDrainage.XAxis2 = (Axis) null;
      this.npDrainage.YAxis1 = (Axis) null;
      this.npDrainage.YAxis2 = (Axis) null;
      this.menuStrip4.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.printToolStripMenuItem3,
        (ToolStripItem) this.helpToolStripMenuItem3
      });
      this.menuStrip4.Location = new Point(3, 3);
      this.menuStrip4.Name = "menuStrip4";
      this.menuStrip4.Size = new Size(378, 24);
      this.menuStrip4.TabIndex = 5;
      this.menuStrip4.Text = "menuStrip4";
      this.menuStrip4.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip4_ItemClicked);
      this.printToolStripMenuItem3.Image = (Image) Resources.printer;
      this.printToolStripMenuItem3.Name = "printToolStripMenuItem3";
      this.printToolStripMenuItem3.Size = new Size(60, 20);
      this.printToolStripMenuItem3.Text = "Print";
      this.printToolStripMenuItem3.Click += new EventHandler(this.printToolStripMenuItem3_Click);
      this.helpToolStripMenuItem3.Image = (Image) Resources.help;
      this.helpToolStripMenuItem3.Name = "helpToolStripMenuItem3";
      this.helpToolStripMenuItem3.Size = new Size(60, 20);
      this.helpToolStripMenuItem3.Text = "Help";
      this.helpToolStripMenuItem3.Click += new EventHandler(this.helpToolStripMenuItem3_Click);
      this.tpExcel.Controls.Add((Control) this.dgExcel);
      this.tpExcel.Controls.Add((Control) this.menuStrip6);
      this.tpExcel.Location = new Point(4, 26);
      this.tpExcel.Name = "tpExcel";
      this.tpExcel.Size = new Size(392, 370);
      this.tpExcel.TabIndex = 3;
      this.tpExcel.Text = "Advanced Output";
      this.tpExcel.UseVisualStyleBackColor = true;
      this.dgExcel.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      this.dgExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle.BackColor = SystemColors.Window;
      gridViewCellStyle.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle.ForeColor = SystemColors.ControlText;
      gridViewCellStyle.Format = "N3";
      gridViewCellStyle.NullValue = (object) null;
      gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle.WrapMode = DataGridViewTriState.False;
      this.dgExcel.DefaultCellStyle = gridViewCellStyle;
      this.dgExcel.Dock = DockStyle.Fill;
      this.dgExcel.Location = new Point(0, 24);
      this.dgExcel.Name = "dgExcel";
      this.dgExcel.Size = new Size(392, 346);
      this.dgExcel.TabIndex = 0;
      this.pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
      this.buttons.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("buttons.ImageStream");
      this.buttons.TransparentColor = Color.Transparent;
      this.buttons.Images.SetKeyName(0, "printer.png");
      this.hp.HelpNamespace = "CYP.chm";
      this.saveResults.DefaultExt = "xls";
      this.saveResults.FileName = "CYP Excel Output";
      this.menuStrip5.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.printToolStripMenuItem4,
        (ToolStripItem) this.helpToolStripMenuItem4
      });
      this.menuStrip5.Location = new Point(3, 3);
      this.menuStrip5.Name = "menuStrip5";
      this.menuStrip5.Size = new Size(386, 24);
      this.menuStrip5.TabIndex = 20;
      this.menuStrip5.Text = "menuStrip5";
      this.printToolStripMenuItem4.Image = (Image) Resources.printer;
      this.printToolStripMenuItem4.Name = "printToolStripMenuItem4";
      this.printToolStripMenuItem4.Size = new Size(60, 20);
      this.printToolStripMenuItem4.Text = "Print";
      this.dgCosts.AllowUserToAddRows = false;
      this.dgCosts.AllowUserToDeleteRows = false;
      this.dgCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dgCosts.BackgroundColor = Color.White;
      this.dgCosts.BorderStyle = BorderStyle.None;
      this.dgCosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgCosts.ColumnHeadersVisible = false;
      this.dgCosts.Dock = DockStyle.Fill;
      this.dgCosts.Location = new Point(3, 27);
      this.dgCosts.Name = "dgCosts";
      this.dgCosts.ReadOnly = true;
      this.dgCosts.RowHeadersVisible = false;
      this.dgCosts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgCosts.Size = new Size(386, 340);
      this.dgCosts.TabIndex = 21;
      this.tpReturns.AutoScroll = true;
      this.tpReturns.BackColor = Color.White;
      this.tpReturns.Controls.Add((Control) this.dgCosts);
      this.tpReturns.Controls.Add((Control) this.menuStrip5);
      this.tpReturns.Location = new Point(4, 26);
      this.tpReturns.Name = "tpReturns";
      this.tpReturns.Padding = new Padding(3);
      this.tpReturns.Size = new Size(392, 370);
      this.tpReturns.TabIndex = 1;
      this.tpReturns.Text = "Economic Analysis";
      this.tpReturns.UseVisualStyleBackColor = true;
      this.helpToolStripMenuItem4.Image = (Image) Resources.help;
      this.helpToolStripMenuItem4.Name = "helpToolStripMenuItem4";
      this.helpToolStripMenuItem4.Size = new Size(60, 20);
      this.helpToolStripMenuItem4.Text = "Help";
      this.helpToolStripMenuItem4.Click += new EventHandler(this.helpToolStripMenuItem4_Click_1);
      this.menuStrip6.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.helpToolStripMenuItem5
      });
      this.menuStrip6.Location = new Point(0, 0);
      this.menuStrip6.Name = "menuStrip6";
      this.menuStrip6.Size = new Size(392, 24);
      this.menuStrip6.TabIndex = 1;
      this.menuStrip6.Text = "menuStrip6";
      this.helpToolStripMenuItem5.Image = (Image) Resources.help;
      this.helpToolStripMenuItem5.Name = "helpToolStripMenuItem5";
      this.helpToolStripMenuItem5.Size = new Size(60, 20);
      this.helpToolStripMenuItem5.Text = "Help";
      this.helpToolStripMenuItem5.Click += new EventHandler(this.helpToolStripMenuItem5_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.BackColor = Color.White;
      this.Controls.Add((Control) this.tcResultPages);
      this.Margin = new Padding(0);
      this.Name = nameof (CropResults);
      this.Size = new Size(400, 400);
      this.tcResultPages.ResumeLayout(false);
      this.tpResults.ResumeLayout(false);
      this.tpResults.PerformLayout();
      ((ISupportInitialize) this.dgStandardResults).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tpGraph.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.menuStrip3.ResumeLayout(false);
      this.menuStrip3.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.menuStrip4.ResumeLayout(false);
      this.menuStrip4.PerformLayout();
      this.tpExcel.ResumeLayout(false);
      this.tpExcel.PerformLayout();
      ((ISupportInitialize) this.dgExcel).EndInit();
      this.menuStrip5.ResumeLayout(false);
      this.menuStrip5.PerformLayout();
      ((ISupportInitialize) this.dgCosts).EndInit();
      this.tpReturns.ResumeLayout(false);
      this.tpReturns.PerformLayout();
      this.menuStrip6.ResumeLayout(false);
      this.menuStrip6.PerformLayout();
      this.ResumeLayout(false);
    }

    public string title
    {
      get
      {
        return this._title;
      }
      set
      {
        this._title = value;
      }
    }

    public event RestartWithResultsHandler RestartWithResults;

    protected virtual void OnRestartWithResults()
    {
      this.RestartWithResults(this.model);
    }

    public event TabChangedHandler TabChanged;

    protected virtual void OnTabChanged()
    {
      this.TabChanged((object) this);
    }

    public CropResults(CWYModel m, int cropindex, int resultNumber)
    {
      this.InitializeComponent();
      this.model = (CWYModel) m.Clone();
      this.cropIndex = cropindex;
      this.ResultNumber = resultNumber;
      this.LoadCropResults();
      this.dgStandardResults.SelectAll();
    }

    public DataTable ResultTable()
    {
      return new DataTable()
      {
        Columns = {
          new DataColumn()
          {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "label"
          },
          new DataColumn()
          {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "value"
          }
        }
      };
    }

    public void AddRow(string Label, string Value)
    {
      this.dgStandardResults.Rows.Add();
      this.dgStandardResults.Rows[this.dgStandardResults.Rows.Count - 1].Cells[0].Value = (object) Label;
      this.dgStandardResults.Rows[this.dgStandardResults.Rows.Count - 1].Cells[1].Value = (object) Value;
    }

    public void AddRowCR(string Label, string Value)
    {
      this.dgCosts.Rows.Add();
      this.dgCosts.Rows[this.dgCosts.Rows.Count - 1].Cells[0].Value = (object) Label;
      this.dgCosts.Rows[this.dgCosts.Rows.Count - 1].Cells[1].Value = (object) Value;
    }

    public void LoadCropResults()
    {
      this.dgStandardResults.Columns.Add("Label", "Label");
      this.dgStandardResults.Columns.Add("Value", "Value");
      this.dgCosts.Columns.Add("Label", "Label");
      this.dgCosts.Columns.Add("Value", "Value");
      try
      {
        if (this.model.cCrops.Count <= 0)
          return;
        bool flag = this.model.Units == "english";
        string str1 = this.model.Units == "english" ? "in." : "mm.";
        BindingList<Crop> bindingList = new BindingList<Crop>();
        DateTime start;
        DateTime end;
        if (this.cropIndex == -1)
        {
          bindingList = this.model.cCrops;
          start = this.model.start;
          DateTime dateTime = Convert.ToDateTime(this.model.cCrops[this.model.cCrops.Count - 1].calcDates[this.model.cCrops[this.model.cCrops.Count - 1].calcDates.Count - 1]);
          dateTime = new DateTime(dateTime.Year, 12, 31);
          end = this.model.endDate;
        }
        else
        {
          bindingList.Add(this.model.cCrops[this.cropIndex]);
          start = Convert.ToDateTime(this.model.cCrops[this.cropIndex].calcDates[0]);
          start = new DateTime(bindingList[0].YeartStart, 1, 1);
          end = Convert.ToDateTime(this.model.cCrops[this.cropIndex].calcDates[this.model.cCrops[this.cropIndex].calcDates.Count - 1]);
          end = new DateTime(end.Year, 12, 31);
          end = this.model.endDate;
        }
        this.title = bindingList.Count <= 1 ? bindingList[0].CropName + " Results" : "Entire season";
        this.rsltStandard.Add(new Result("  Inputs", (object) "  "));
        this.AddRow("  Inputs", "  Results #" + this.ResultNumber.ToString());
        this.rsltStandard.Add(new Result("Location", (object) this.model.cLocation.LocationName));
        this.AddRow("Location", this.model.cLocation.LocationName);
        if (bindingList.Count == 1)
        {
          this.rsltStandard.Add(new Result("Crop", (object) bindingList[0].CropName));
          this.AddRow("Crop", bindingList[0].CropName);
        }
        else
          this.AddRow("Crop", "Rotation");
        this.rsltStandard.Add(new Result("Soil type", (object) this.model.cSoil.SoilName));
        this.AddRow("Soil type", this.model.cSoil.SoilName);
        this.AddRow("Available Soil Water on " + start.ToString("MMMM") + " " + start.Day.ToString(), this.model.GetEmergenceSWA(bindingList[0].CropName).ToString("0") + "%");
        this.rsltStandard.Add(new Result("Available Soil Water on " + (this.model.measuredDate ? this.model.SoilDate.ToString("MMMM d") : "Specific Date"), this.model.measuredDate ? (object) (this.model.dblMeasuredWater.ToString("#0") + "%") : (object) "N/A"));
        this.rsltStandard.Add(new Result("Irrigation Application Efficiency", (object) (this.model.dblEfficiency.ToString() + "%")));
        this.AddRow("Irrigation Application Efficiency", this.model.dblEfficiency.ToString() + "%");
        this.rsltStandard.Add(new Result("Runoff Factor", (object) (this.model.GetRunoffFraction(bindingList[0].CropName).ToString("0") + "%")));
        string Label1 = "Runoff Factor";
        double num1 = this.model.GetRunoffFraction(bindingList[0].CropName);
        string str2 = num1.ToString("0") + "%";
        this.AddRow(Label1, str2);
        double num2 = this.model.Units == "metric" ? this.model.dblAnnualPrecip : Convert.ToDouble(this.model.dblAnnualPrecip / 25.4);
        this.rsltStandard.Add(new Result("Annual Precipitation", (object) (num2.ToString("0") + " " + str1)));
        string str3 = num2.ToString("0") + " " + str1;
        this.AddRow("Annual Precipitation", num2.ToString("0") + " " + str1);
        int num3 = 0;
        if (bindingList[0].CropName == "Winter Wheat")
          num3 = 1;
        DateTime dateTime1;
        double num4;
        if (!flag)
        {
          num4 = this.model.Total("epr", (object) start, (object) end);
        }
        else
        {
          CWYModel model = this.model;
          string Column = "epr";
          // ISSUE: variable of a boxed type
          __Boxed<DateTime> dateFromString = (System.ValueType) bindingList[0].GetDateFromString(bindingList[0].arrCoefficients[0].Date);
          dateTime1 = bindingList[0].GetDateFromString(bindingList[0].arrCoefficients[bindingList[0].arrCoefficients.Count - 1].Date);
          // ISSUE: variable of a boxed type
          __Boxed<DateTime> local = (System.ValueType) dateTime1.AddYears(num3);
          num4 = model.Total(Column, (object) dateFromString, (object) local) / 25.4;
        }
        this.AddRow("Cropping Season Effective Precipitation", num4.ToString("###,##0") + " " + str1);
        double num5 = flag ? this.model.Total("ir", (object) start, (object) end) / 25.4 : this.model.Total("ir", (object) start, (object) end);
        double num6 = num5;
        this.rsltStandard.Add(new Result("Total Irrigation " + str1, (object) num5.ToString("0")));
        this.AddRow("Total Irrigation", num5.ToString("###,##0") + " " + str1);
        string str4 = num5.ToString("0") + " " + str1;
        double num7 = flag ? this.model.Total("eir", (object) start, (object) end) / 25.4 : this.model.Total("eir", (object) start, (object) end);
        this.rsltStandard.Add(new Result("Effective Irrigation", (object) num7.ToString("0")));
        this.AddRow("Effective Irrigation", num7.ToString("###,##0") + " " + str1);
        if (this.cropIndex > -1 || bindingList.Count == 1)
        {
          IEnumerator enumerator = (IEnumerator) bindingList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            Crop current = (Crop) enumerator.Current;
            string Label2 = "Maximum Crop Yield from Field";
            num1 = current.DisplayYield(current.dblMaxYield);
            string str5 = num1.ToString("###,##0") + " " + current.YieldUnits();
            this.AddRow(Label2, str5);
          }
        }
        else
          this.AddRow("Maximum Crop Yield from Field", "Rotation - N/A");
        this.rsltStandard.Add(new Result("  Results", (object) "  "));
        this.AddRow("  Results", "  ");
        double num8;
        if (this.cropIndex > -1 || bindingList.Count == 1)
        {
          double num9 = 0.0;
          double num10 = 0.0;
          double num11 = 0.0;
          double num12 = 0.0;
          double num13 = 0.0;
          IEnumerator enumerator = (IEnumerator) bindingList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            Crop current = (Crop) enumerator.Current;
            ArrayList weightingFactorStages = current.GetWeightingFactorStages();
            double num14 = Convert.ToDouble(((object[]) weightingFactorStages[weightingFactorStages.Count - 1])[2]) - Convert.ToDouble(((object[]) weightingFactorStages[0])[1]);
            num13 += num14;
            foreach (object[] objArray in weightingFactorStages)
            {
              dateTime1 = new DateTime(current.YeartStart, 1, 1);
              DateTime dateTime2 = dateTime1.AddDays((double) Convert.ToInt32(objArray[1]));
              DateTime dateTime3 = dateTime2.AddDays((double) (Convert.ToInt32(objArray[2]) - Convert.ToInt32(objArray[1])));
              double num15 = this.model.Total("ska", (object) dateTime2, (object) dateTime3);
              double num16 = this.model.Total("optimalska", (object) dateTime2, (object) dateTime3);
              if (bindingList.Count == 1)
              {
                num8 = flag ? num15 / 25.4 : num15;
                double num17 = this.model.Total("advetrkcn", (object) dateTime2, (object) dateTime3);
                num12 += num17;
                double num18;
                double num19;
                if (current.CropName == "Alfalfa")
                {
                  num18 = num15 * Convert.ToDouble(objArray[4]);
                  num19 = num16 * Convert.ToDouble(objArray[4]);
                }
                else
                {
                  num18 = num15 / num17 * Convert.ToDouble(objArray[4]);
                  num19 = num16 / num17 * Convert.ToDouble(objArray[4]);
                }
                num10 += num18;
                num11 += num19;
              }
              num9 += num15;
            }
            double ET1 = num10 / 100.0 * num12 / 25.4;
            double ET2 = num11 / 100.0 * num12 / 25.4;
            double num20 = current.GetYield(ET2) > current.dblMaxYield ? current.dblMaxYield : current.GetYield(ET2);
            double num21 = current.GetYield(ET1) > current.dblMaxYield ? current.dblMaxYield : current.GetYield(ET1);
            double num22 = num21 > 0.0 ? num21 / num20 : 0.0;
            double y1 = num22 * current.dblMaxYield;
            string Label2 = "Adjusted Crop Yield for Field";
            num1 = current.DisplayYield(y1);
            string str5 = num1.ToString("#0") + " " + current.YieldUnits();
            this.AddRow(Label2, str5);
            Crop crop = bindingList[0];
            crop.calcYield = y1;
            this.AddRowCR("  Inputs", "  Results #" + this.ResultNumber.ToString());
            string Label3 = "Acres";
            num1 = this.model.Acres;
            string str6 = num1.ToString() + " acres";
            this.AddRowCR(Label3, str6);
            double y2 = num22 * crop.dblMaxYield;
            string Label4 = "Adjusted Crop Yield for Field";
            num1 = crop.DisplayYield(y2);
            string str7 = num1.ToString("#0") + " " + crop.YieldUnits();
            this.AddRowCR(Label4, str7);
            this.AddRowCR("Operating Costs", "");
            if (crop.optimalN)
              ((InputCost) crop.GetFactor("n")).Amount = crop.OptimalNutrient("N") * y1;
            if (crop.optimalP)
              ((InputCost) crop.GetFactor("p")).Amount = crop.OptimalNutrient("P") * y1;
            if (crop.optimalSeed)
            {
              double grossIrrig = num8 = this.model.Total("ir", (object) start, (object) end) / 25.4;
              ((InputCost) crop.GetFactor("s")).Amount = crop.OptimalSeed(grossIrrig);
            }
            foreach (InputCost cGeneralCost in (Collection<InputCost>) crop.cGeneralCosts)
              this.AddRowCR(cGeneralCost.Label.ToString(), cGeneralCost.formattedValue());
            foreach (InputCost cOperationCost in (Collection<InputCost>) crop.cOperationCosts)
              this.AddRowCR(cOperationCost.Label.ToString(), cOperationCost.formattedValue());
            this.AddRowCR("Well Discharge Rate", this.model.gpm.ToString("0") + " GPM");
            foreach (InputCost cIrrigationCost in (Collection<InputCost>) crop.cIrrigationCosts)
              this.AddRowCR(cIrrigationCost.Label.ToString(), cIrrigationCost.formattedValue());
            this.AddRowCR("Gross Irrigation", num6.ToString("0.0") + " in.");
            foreach (InputCost cMiscCost in (Collection<InputCost>) crop.cMiscCosts)
              this.AddRowCR(cMiscCost.Label.ToString(), cMiscCost.formattedValue());
            foreach (InputCost cReturn in (Collection<InputCost>) crop.cReturns)
              this.AddRowCR(cReturn.Label.ToString(), cReturn.formattedValue());
            this.AddRowCR("  Results", "  ");
            double num23 = 0.0;
            string str8 = this.model.Units == "metric" ? "ha" : "acre";
            foreach (InputCost cGeneralCost in (Collection<InputCost>) crop.cGeneralCosts)
            {
              ArrayList cost = crop.GetCost(cGeneralCost);
              if (cost.Count > 0)
              {
                num23 += Convert.ToDouble(cost[1]);
                this.AddRowCR(cost[0].ToString(), "$" + ((double) cost[1]).ToString("0.00") + "/" + str8);
              }
            }
            foreach (InputCost cOperationCost in (Collection<InputCost>) crop.cOperationCosts)
            {
              ArrayList cost = crop.GetCost(cOperationCost);
              if (cost.Count > 0)
              {
                num23 += Convert.ToDouble(cost[1]);
                this.AddRowCR(cost[0].ToString(), "$" + ((double) cost[1]).ToString("0.00") + "/" + str8);
              }
            }
            foreach (InputCost cMiscCost in (Collection<InputCost>) crop.cMiscCosts)
            {
              ArrayList cost = crop.GetCost(cMiscCost);
              if (cost.Count > 0)
              {
                num23 += Convert.ToDouble(cost[1]);
                this.AddRowCR(cost[0].ToString(), "$" + ((double) cost[1]).ToString("0.00") + "/" + str8);
              }
            }
            double[] numArray = crop.IrrigationCost(this.model);
            double num24 = num23 + numArray[1] * num6;
            this.AddRowCR("Calculated Hours of Pumping", (numArray[0] * this.model.Acres * num6).ToString("0.00") + " hours");
            string Label5 = "Irrigation Fuel Cost";
            string str9 = "$";
            double num25 = numArray[1] * num6;
            string str10 = num25.ToString("0.00");
            string str11 = "/";
            string str12 = str8;
            string str13 = str9 + str10 + str11 + str12;
            this.AddRowCR(Label5, str13);
            foreach (InputCost cReturn in (Collection<InputCost>) crop.cReturns)
            {
              ArrayList cost = crop.GetCost(cReturn);
              if (cost.Count > 0)
              {
                num24 -= Convert.ToDouble(cost[1]);
                string Label6 = cost[0].ToString();
                string str14 = "$";
                num25 = (double) cost[1];
                string str15 = num25.ToString("0.00");
                string str16 = "/";
                string str17 = str8;
                string str18 = str14 + str15 + str16 + str17;
                this.AddRowCR(Label6, str18);
              }
            }
            double num26 = y1 * crop.price;
            double num27 = num26 - num24;
            this.AddRow("Gross Return", "$" + num26.ToString("0") + "/" + str8);
            this.AddRow("Total Operating Costs", "$" + num24.ToString("0") + "/" + str8);
            this.AddRow("Net Return", "$" + num27.ToString("0") + "/" + str8);
            this.AddRow("Effective Evapotranspiration", (flag ? ET1 : ET1 * 25.4).ToString("0.0") + " " + str1);
            num8 = flag ? (this.model.Total("ska", (object) start, (object) end) - num9) / 25.4 : this.model.Total("ska", (object) start, (object) end) - num9;
            this.rsltStandard.Add(new Result("Evaporation During Non-crop Season " + str1, (object) num8.ToString("0")));
            this.AddRow("Evaporation During Non-crop Season", num8.ToString("0") + " " + str1);
          }
        }
        else
        {
          this.AddRow("Estimated Crop Yield from CYP", "Rotation - N/A");
          this.AddRow("Maximum Crop Yield from CYP", "Rotation - N/A");
          this.AddRow("Relative Crop Yield", "Rotation - N/A");
          this.AddRow("Adjusted Crop Yield for Field", "Rotation - N/A");
          this.AddRow("Effective ETe", "Rotation - N/A");
          this.AddRow("Evaporation During Non-crop Season", "Rotation - N/A");
        }
        IEnumerator enumerator1 = (IEnumerator) bindingList.GetEnumerator();
        double num28 = 0.0;
        while (enumerator1.MoveNext())
        {
          Crop current = (Crop) enumerator1.Current;
          num28 += this.model.Total("dr", (object) Convert.ToDateTime(current.calcDates[0]), (object) Convert.ToDateTime(current.calcDates[current.calcDates.Count - 1]));
        }
        num8 = flag ? num28 / 25.4 : num28;
        this.AddRow("Drainage during crop season", num8.ToString("0.0") + " " + str1);
        num8 = flag ? (this.model.Total("dr", (object) start, (object) end) - num28) / 25.4 : this.model.Total("dr", (object) start, (object) end) - num28;
        this.AddRow("Drainage during non-crop season", num8.ToString("0.0") + " " + str1);
        this.dgStandardResults.AutoGenerateColumns = false;
        DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn1.DataPropertyName = "Label";
        viewTextBoxColumn1.HeaderText = "Label";
        DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn2.DataPropertyName = "Value";
        viewTextBoxColumn2.HeaderText = "Results";
        this.FormatDataGridView(this.dgStandardResults);
        this.FormatDataGridView(this.dgCosts);
        this.FreshGraph(this.npBalance);
        this.npBalance.Add((IDrawable) this.NewLine("#FFB8B8", (object) 50, start, end, "50% Reference Line", false));
        this.npBalance.Add((IDrawable) this.NewLine("#33CC00", (object) 100, start, end, "Field Capacity", false));
        this.npBalance.Add((IDrawable) this.NewLine("#FF9900", (object) 0, start, end, "Permanent Wilt", false));
        this.npBalance.Add((IDrawable) this.NewLine("#0000FF", (object) "asw", start, end, "Available Soil Water (%)", false));
        this.npBalance.YAxis1.WorldMax += 0.1 * (this.npBalance.YAxis1.WorldMax - this.npBalance.YAxis1.WorldMin);
        this.npBalance.YAxis1.Label = "% Available Soil Water";
        this.npBalance.Title = "Available soil water (%) - " + bindingList[0].CropName + " (" + str3 + " Rainfall, " + str4 + " Irrigation)";
        DateTimeAxis dateTimeAxis = new DateTimeAxis(this.npBalance.XAxis1);
        dateTimeAxis.HideTickText = false;
        dateTimeAxis.AutoScaleTicks = true;
        dateTimeAxis.MinPhysicalLargeTickStep = 1;
        StringBuilder stringBuilder = new StringBuilder();
        dateTimeAxis.NumberFormat = "MMM yy";
        this.npBalance.XAxis1 = (Axis) dateTimeAxis;
        this.npBalance.Refresh();
        this.FreshGraph(this.npET);
        this.npET.Add((IDrawable) this.NewLine("#FFDD55", (object) "advetr", start, end, "ETr (" + (this.model.Units == "english" ? "in." : "mm") + "/day)", true));
        this.npET.Add((IDrawable) this.NewLine("#CC3300", (object) "advetrkcn", start, end, "ETm (" + (this.model.Units == "english" ? "in." : "mm") + "/day)", true));
        this.npET.Add((IDrawable) this.NewLine("#0000FF", (object) "ska", start, end, "ETa (" + (this.model.Units == "english" ? "in." : "mm") + "/day)", true));
        this.npET.YAxis1.WorldMax += 0.1 * (this.npET.YAxis1.WorldMax - this.npET.YAxis1.WorldMin);
        this.npET.YAxis1.Label = "Evapotranspiration (" + (this.model.Units == "english" ? "in." : "mm") + "/day)";
        this.npET.Title = "Evapotranspiration - " + bindingList[0].CropName + " (" + str3 + " Rainfall, " + str4 + " Irrigation)";
        this.npET.Refresh();
        this.FreshGraph(this.npDrainage);
        this.npDrainage.Add((IDrawable) this.NewLine("#0000FF", (object) "dr", start, end, "Drainage (" + (this.model.Units == "english" ? "in." : "mm") + "/day)", true));
        this.npDrainage.YAxis1.WorldMax += 0.1 * (this.npDrainage.YAxis1.WorldMax - this.npDrainage.YAxis1.WorldMin);
        this.npDrainage.YAxis1.Label = "Drainage (" + (this.model.Units == "english" ? "in." : "mm") + "/day)";
        this.npDrainage.Title = "Drainage - " + bindingList[0].CropName + " (" + str3 + " Rainfall, " + str4 + " Irrigation)";
        this.npDrainage.Refresh();
        this.dgExcel.DataSource = (object) this.model.ModelData;
        int index1 = 0;
        this.dgExcel.Columns[index1].DefaultCellStyle.Format = "d";
        DataGridViewColumnCollection columns1 = this.dgExcel.Columns;
        int index2 = index1;
        int index3 = index2 + 1;
        columns1[index2].HeaderText = "Day";
        this.dgExcel.Columns[index3].DefaultCellStyle.Format = "N0";
        DataGridViewColumnCollection columns2 = this.dgExcel.Columns;
        int index4 = index3;
        int num29 = index4 + 1;
        columns2[index4].HeaderText = "DOY";
        DataGridViewColumnCollection columns3 = this.dgExcel.Columns;
        int index5 = num29;
        int num30 = index5 + 1;
        columns3[index5].HeaderText = "Max Tf (°F)";
        DataGridViewColumnCollection columns4 = this.dgExcel.Columns;
        int index6 = num30;
        int num31 = index6 + 1;
        columns4[index6].HeaderText = "Min Tf (°F)";
        DataGridViewColumnCollection columns5 = this.dgExcel.Columns;
        int index7 = num31;
        int num32 = index7 + 1;
        columns5[index7].HeaderText = "Precip (inches)";
        DataGridViewColumnCollection columns6 = this.dgExcel.Columns;
        int index8 = num32;
        int num33 = index8 + 1;
        columns6[index8].HeaderText = "Eff Precip (inches)";
        DataGridViewColumnCollection columns7 = this.dgExcel.Columns;
        int index9 = num33;
        int num34 = index9 + 1;
        columns7[index9].HeaderText = "Radiation (MJ/m\x00B2)";
        DataGridViewColumnCollection columns8 = this.dgExcel.Columns;
        int index10 = num34;
        int num35 = index10 + 1;
        columns8[index10].HeaderText = "Max Tc (°C)";
        DataGridViewColumnCollection columns9 = this.dgExcel.Columns;
        int index11 = num35;
        int num36 = index11 + 1;
        columns9[index11].HeaderText = "Min Tc (°C)";
        DataGridViewColumnCollection columns10 = this.dgExcel.Columns;
        int index12 = num36;
        int num37 = index12 + 1;
        columns10[index12].HeaderText = "Mean Tc (°C)";
        DataGridViewColumnCollection columns11 = this.dgExcel.Columns;
        int index13 = num37;
        int num38 = index13 + 1;
        columns11[index13].HeaderText = "ETr (mm)";
        DataGridViewColumnCollection columns12 = this.dgExcel.Columns;
        int index14 = num38;
        int num39 = index14 + 1;
        columns12[index14].HeaderText = "Advection (mm)";
        DataGridViewColumnCollection columns13 = this.dgExcel.Columns;
        int index15 = num39;
        int num40 = index15 + 1;
        columns13[index15].HeaderText = "Real Advection (mm)";
        DataGridViewColumnCollection columns14 = this.dgExcel.Columns;
        int index16 = num40;
        int num41 = index16 + 1;
        columns14[index16].HeaderText = "ETr+Adv (mm)";
        DataGridViewColumnCollection columns15 = this.dgExcel.Columns;
        int index17 = num41;
        int num42 = index17 + 1;
        columns15[index17].HeaderText = "Sum ETr+Adv (mm)";
        DataGridViewColumnCollection columns16 = this.dgExcel.Columns;
        int index18 = num42;
        int num43 = index18 + 1;
        columns16[index18].HeaderText = "Kc";
        DataGridViewColumnCollection columns17 = this.dgExcel.Columns;
        int index19 = num43;
        int num44 = index19 + 1;
        columns17[index19].HeaderText = "ETm (mm)";
        DataGridViewColumnCollection columns18 = this.dgExcel.Columns;
        int index20 = num44;
        int num45 = index20 + 1;
        columns18[index20].HeaderText = "Sum ETm (mm)";
        DataGridViewColumnCollection columns19 = this.dgExcel.Columns;
        int index21 = num45;
        int num46 = index21 + 1;
        columns19[index21].HeaderText = "Eff Precip (mm)";
        DataGridViewColumnCollection columns20 = this.dgExcel.Columns;
        int index22 = num46;
        int num47 = index22 + 1;
        columns20[index22].HeaderText = "TSW in (mm)";
        DataGridViewColumnCollection columns21 = this.dgExcel.Columns;
        int index23 = num47;
        int num48 = index23 + 1;
        columns21[index23].HeaderText = "TSW out (mm)";
        DataGridViewColumnCollection columns22 = this.dgExcel.Columns;
        int index24 = num48;
        int num49 = index24 + 1;
        columns22[index24].HeaderText = "Drainage (mm)";
        DataGridViewColumnCollection columns23 = this.dgExcel.Columns;
        int index25 = num49;
        int num50 = index25 + 1;
        columns23[index25].HeaderText = "ASW (%)";
        DataGridViewColumnCollection columns24 = this.dgExcel.Columns;
        int index26 = num50;
        int num51 = index26 + 1;
        columns24[index26].HeaderText = "Ks";
        DataGridViewColumnCollection columns25 = this.dgExcel.Columns;
        int index27 = num51;
        int num52 = index27 + 1;
        columns25[index27].HeaderText = "ETa (mm)";
        DataGridViewColumnCollection columns26 = this.dgExcel.Columns;
        int index28 = num52;
        int num53 = index28 + 1;
        columns26[index28].HeaderText = "Irrigation (mm)";
        DataGridViewColumnCollection columns27 = this.dgExcel.Columns;
        int index29 = num53;
        int num54 = index29 + 1;
        columns27[index29].HeaderText = "Eff Irr (mm)";
        DataGridViewColumnCollection columns28 = this.dgExcel.Columns;
        int index30 = num54;
        int num55 = index30 + 1;
        columns28[index30].HeaderText = "No-Stress Ks";
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("An error has occurred with your results.  Please double check your inputs and try again." + ex.ToString(), "Error", MessageBoxButtons.OK);
      }
    }

    private void LoadPreviousResultsMenu()
    {
    }

    private DataGridView FormatGrid(DataGridView dg)
    {
      try
      {
        dg.Columns[2].Visible = false;
        dg.Columns[0].DataPropertyName = "Label";
        dg.Columns[0].HeaderText = "Description";
        dg.Columns[1].DataPropertyName = "Value";
        dg.Columns[1].HeaderText = "Value";
        dg.Columns[1].DefaultCellStyle.Format = "0.000";
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
      return dg;
    }

    private DataTable AddResultRow(DataTable dt, string label, object value)
    {
      DataRow row = dt.NewRow();
      row[nameof (label)] = (object) label;
      row[nameof (value)] = (object) Convert.ToString(value);
      dt.Rows.Add(row);
      return dt;
    }

    private void AddResultLines(FlowLayoutPanel fp, BindingList<Result> results)
    {
      IEnumerator enumerator = (IEnumerator) results.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Result current = (Result) enumerator.Current;
        ResultLine resultLine = new ResultLine(current.Label, Convert.ToDouble(current.Value).ToString("##.000"));
        fp.Controls.Add((Control) resultLine);
      }
    }

    public void FreshGraph(NPlot.Windows.PlotSurface2D n)
    {
      n.Clear();
      n.Add((IDrawable) new Grid()
      {
        VerticalGridType = Grid.GridType.Coarse,
        HorizontalGridType = Grid.GridType.Coarse,
        MajorGridPen = new Pen(Color.Lavender, 1f)
      });
      Legend legend = new Legend();
      legend.AttachTo(NPlot.PlotSurface2D.XAxisPosition.Top, NPlot.PlotSurface2D.YAxisPosition.Right);
      legend.BorderStyle = LegendBase.BorderType.Line;
      legend.BackgroundColor = Color.White;
      n.Legend = legend;
    }

    public LinePlot NewLine(string hexColor, object column, DateTime start, DateTime end, string lineLabel, bool convert)
    {
      LinePlot linePlot = new LinePlot();
      linePlot.Pen = new Pen(ColorTranslator.FromHtml(hexColor), 2f);
      List<DateTime> dateTimeList = new List<DateTime>();
      List<Decimal> numList = new List<Decimal>();
      TimeSpan timeSpan = end.Subtract(start);
      for (int index = 0; index < timeSpan.Days; ++index)
      {
        dateTimeList.Add(start.AddDays((double) index));
        DataRow dataRow = this.model.ModelData.Rows.Find((object) start.AddDays((double) index));
        if (dataRow != null)
        {
          double result;
          if (double.TryParse(Convert.ToString(column), out result))
          {
            double num1 = Convert.ToDouble(column);
            double num2 = convert ? (this.model.Units == "english" ? num1 / 25.4 : num1) : num1;
            numList.Add(Convert.ToDecimal(num2));
          }
          else
          {
            double num1 = Convert.ToDouble(dataRow[Convert.ToString(column)]);
            double num2 = convert ? (this.model.Units == "english" ? num1 / 25.4 : num1) : num1;
            numList.Add(Convert.ToDecimal(num2));
          }
        }
      }
      linePlot.AbscissaData = (object) dateTimeList;
      linePlot.DataSource = (object) numList;
      linePlot.Label = lineLabel;
      linePlot.ShowInLegend = true;
      linePlot.Shadow = true;
      return linePlot;
    }

    private void dgStandardResults_DataSourceChanged(object sender, EventArgs e)
    {
    }

    private void tpGraph_Click(object sender, EventArgs e)
    {
    }

    private void dgStandardResults_CellLeave(object sender, DataGridViewCellEventArgs e)
    {
    }

    public void ReFormatGrids()
    {
      this.FormatDataGridView(this.dgStandardResults);
      this.FormatDataGridView(this.dgCosts);
    }

    private void FormatDataGridView(DataGridView dg)
    {
      int num = 0;
      for (int index = 0; index < dg.Rows.Count; ++index)
      {
        if (dg.Rows[index].Cells[0].Value.ToString() == "  Results")
          num = index;
      }
      for (int index1 = 0; index1 < dg.Rows.Count; ++index1)
      {
        for (int index2 = 0; index2 < dg.Columns.Count; ++index2)
        {
          if (index1 >= num)
          {
            this.outputColor = Color.Blue;
            this.headerColor = Color.FromArgb(0, 102, 204);
          }
          else
          {
            this.outputColor = Color.Green;
            this.headerColor = Color.FromArgb(51, 153, 51);
          }
          if (dg.Rows[index1].Cells[index2].Value.ToString().Contains("  "))
          {
            dg.Rows[index1].Cells[index2].Style.BackColor = this.headerColor;
            dg.Rows[index1].Cells[index2].Style.ForeColor = Color.White;
            dg.Rows[index1].Cells[index2].Style.Font = new Font(dg.Rows[index1].Cells[index2].InheritedStyle.Font, FontStyle.Bold);
            dg.Rows[index1].Cells[index2].Style.Padding = new Padding(0, 0, 0, 0);
            dg.Rows[index1].Cells[index2].Style.SelectionBackColor = dg.Rows[index1].Cells[index2].Style.BackColor;
            dg.Rows[index1].Cells[index2].Style.SelectionForeColor = dg.Rows[index1].Cells[index2].Style.ForeColor;
          }
          else
          {
            dg.Rows[index1].Cells[index2].Style.ForeColor = this.outputColor;
            dg.Rows[index1].Cells[index2].Style.SelectionBackColor = dg.Rows[index1].Cells[index2].Style.BackColor;
            dg.Rows[index1].Cells[index2].Style.SelectionForeColor = dg.Rows[index1].Cells[index2].Style.ForeColor;
          }
        }
      }
    }

    private void dgStandardResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
    }

    private void tcResultPages_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void tabControl1_Click(object sender, EventArgs e)
    {
      this.OnTabChanged();
    }

    private void tcResultPages_Click(object sender, EventArgs e)
    {
      this.OnTabChanged();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.dgExcel.SelectAll();
      Clipboard.SetDataObject((object) this.dgExcel.GetClipboardContent(), true);
      this.dgExcel.ClearSelection();
      int num = (int) MessageBox.Show("The table data is now copied to your Clipboard.  You may now paste this data into any program of your choice.", "Data copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void dgCosts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      try
      {
        if (e.Value.ToString().Contains("  Results"))
          this.intCostsResultsStart = e.RowIndex;
        if (e.RowIndex >= this.intCostsResultsStart && this.intCostsResultsStart > -1)
        {
          this.outputColor = Color.Blue;
          this.headerColor = Color.FromArgb(0, 102, 204);
        }
        else
        {
          this.outputColor = Color.Green;
          this.headerColor = Color.FromArgb(51, 153, 51);
        }
        if (e.Value.ToString().Contains("  "))
        {
          e.Value = (object) e.Value.ToString().Remove(0, 7);
          e.CellStyle.BackColor = this.headerColor;
          e.CellStyle.ForeColor = Color.White;
          e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
          e.CellStyle.Padding = new Padding(0, 0, 0, 0);
          e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
          e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
        }
        else
        {
          e.CellStyle.ForeColor = this.outputColor;
          e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
          e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
        }
      }
      catch (Exception ex)
      {
      }
    }

    private void gbStandard_Enter(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
    }

    private bool SetupThePrinting(DataGridView dg, string title)
    {
      PrintDialog printDialog = new PrintDialog();
      printDialog.AllowCurrentPage = false;
      printDialog.AllowPrintToFile = false;
      printDialog.AllowSelection = false;
      printDialog.AllowSomePages = false;
      printDialog.PrintToFile = false;
      printDialog.ShowHelp = false;
      printDialog.ShowNetwork = false;
      if (printDialog.ShowDialog() != DialogResult.OK)
        return false;
      this.pd.DocumentName = title;
      this.pd.PrinterSettings = printDialog.PrinterSettings;
      this.pd.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
      this.pd.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);
      this.dgvPrinter = new DataGridViewPrinter(dg, this.pd, true, true, title, new Font("Tahoma", 18f, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
      return true;
    }

    private void pd_PrintPage(object sender, PrintPageEventArgs e)
    {
      if (!this.dgvPrinter.DrawDataGridView(e.Graphics))
        return;
      e.HasMorePages = true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
    }

    private void printToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!this.SetupThePrinting(this.dgStandardResults, "Crop Yield Predictor - Results Table"))
        return;
      this.pd.Print();
    }

    private void printToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.npBalance.Print(false);
    }

    private void printToolStripMenuItem3_Click(object sender, EventArgs e)
    {
      this.npDrainage.Print(true);
    }

    private void printToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      this.npET.Print(true);
    }

    private void helpToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm");
    }

    private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm");
    }

    private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm#evapgraph");
    }

    private void helpToolStripMenuItem3_Click(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm#drainagegraph");
    }

    private void ShowHelp(string url)
    {
      if (url == "")
        url = "index.htm";
      Help.ShowHelp((Control) this, this.hp.HelpNamespace, HelpNavigator.Topic, (object) url);
    }

    private void printToolStripMenuItem4_Click(object sender, EventArgs e)
    {
      if (!this.SetupThePrinting(this.dgCosts, "Crop Yield Predictor - Economic Analysis"))
        return;
      this.pd.Print();
    }

    private void excelOutputToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DataTable dataTable = this.DataGridViewtoDataTable(this.dgCosts);
      CropResults.CreateWorkbook(Application.StartupPath + "\\blahblahblahblah.xls", new DataSet()
      {
        Tables = {
          dataTable
        }
      });
    }

    private DataTable DataGridViewtoDataTable(DataGridView dg)
    {
      DataTable dataTable = new DataTable();
      for (int index = 0; index < dg.ColumnCount; ++index)
        dataTable.Columns.Add(dg.Columns[index].HeaderText, System.Type.GetType("System.String"));
      for (int index1 = 0; index1 < dg.RowCount; ++index1)
      {
        DataRow row = dataTable.NewRow();
        for (int index2 = 0; index2 < dg.ColumnCount; ++index2)
          row[index2] = dg.Rows[index1].Cells[index2].Value;
        dataTable.Rows.Add(row);
      }
      return dataTable;
    }

    public static void exportToExcel(DataSet source, string fileName)
    {
      StreamWriter streamWriter = new StreamWriter(fileName);
      int num1 = 0;
      int num2 = 1;
      streamWriter.Write("<xml version>\r\n<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n xmlns:x=\"urn:schemas-    microsoft-com:office:excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\">\r\n <Styles>\r\n <Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n <Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>\r\n <Protection/>\r\n </Style>\r\n <Style ss:ID=\"BoldColumn\">\r\n <Font x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n <Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat ss:Format=\"@\"/>\r\n </Style>\r\n <Style ss:ID=\"Decimal\">\r\n <NumberFormat ss:Format=\"0.0000\"/>\r\n </Style>\r\n <Style ss:ID=\"Integer\">\r\n <NumberFormat ss:Format=\"0\"/>\r\n </Style>\r\n <Style ss:ID=\"DateLiteral\">\r\n <NumberFormat ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n </Styles>\r\n ");
      streamWriter.Write("<Worksheet ss:Name=\"Sheet" + (object) num2 + "\">");
      streamWriter.Write("<Table>");
      streamWriter.Write("<Row>");
      for (int index = 0; index < source.Tables[0].Columns.Count; ++index)
      {
        streamWriter.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
        streamWriter.Write(source.Tables[0].Columns[index].ColumnName);
        streamWriter.Write("</Data></Cell>");
      }
      streamWriter.Write("</Row>");
      foreach (DataRow row in (InternalDataCollectionBase) source.Tables[0].Rows)
      {
        ++num1;
        if (num1 == 64000)
        {
          num1 = 0;
          ++num2;
          streamWriter.Write("</Table>");
          streamWriter.Write(" </Worksheet>");
          streamWriter.Write("<Worksheet ss:Name=\"Sheet" + (object) num2 + "\">");
          streamWriter.Write("<Table>");
        }
        streamWriter.Write("<Row>");
        for (int index = 0; index < source.Tables[0].Columns.Count; ++index)
        {
          System.Type type = row[index].GetType();
          switch (type.ToString())
          {
            case "System.String":
              string str1 = row[index].ToString().Trim().Replace("&", "&").Replace(">", ">").Replace("<", "<");
              streamWriter.Write("<Cell ss:StyleID=\"StringLiteral\"><Data ss:Type=\"String\">");
              streamWriter.Write(str1);
              streamWriter.Write("</Data></Cell>");
              break;
            case "System.DateTime":
              DateTime dateTime = (DateTime) row[index];
              string str2 = dateTime.Year.ToString() + "-" + (dateTime.Month < 10 ? "0" + dateTime.Month.ToString() : dateTime.Month.ToString()) + "-" + (dateTime.Day < 10 ? "0" + dateTime.Day.ToString() : dateTime.Day.ToString()) + "T" + (dateTime.Hour < 10 ? "0" + dateTime.Hour.ToString() : dateTime.Hour.ToString()) + ":" + (dateTime.Minute < 10 ? "0" + dateTime.Minute.ToString() : dateTime.Minute.ToString()) + ":" + (dateTime.Second < 10 ? "0" + dateTime.Second.ToString() : dateTime.Second.ToString()) + ".000";
              streamWriter.Write("<Cell ss:StyleID=\"DateLiteral\"><Data ss:Type=\"DateTime\">");
              streamWriter.Write(str2);
              streamWriter.Write("</Data></Cell>");
              break;
            case "System.Boolean":
              streamWriter.Write("<Cell ss:StyleID=\"StringLiteral\"><Data ss:Type=\"String\">");
              streamWriter.Write(row[index].ToString());
              streamWriter.Write("</Data></Cell>");
              break;
            case "System.Int16":
            case "System.Int32":
            case "System.Int64":
            case "System.Byte":
              streamWriter.Write("<Cell ss:StyleID=\"Integer\"><Data ss:Type=\"Number\">");
              streamWriter.Write(row[index].ToString());
              streamWriter.Write("</Data></Cell>");
              break;
            case "System.Decimal":
            case "System.Double":
              streamWriter.Write("<Cell ss:StyleID=\"Decimal\"><Data ss:Type=\"Number\">");
              streamWriter.Write(row[index].ToString());
              streamWriter.Write("</Data></Cell>");
              break;
            case "System.DBNull":
              streamWriter.Write("<Cell ss:StyleID=\"StringLiteral\"><Data ss:Type=\"String\">");
              streamWriter.Write("");
              streamWriter.Write("</Data></Cell>");
              break;
            default:
              throw new Exception(type.ToString() + " not handled.");
          }
        }
        streamWriter.Write("</Row>");
      }
      streamWriter.Write("</Table>");
      streamWriter.Write(" </Worksheet>");
      streamWriter.Write("</Workbook>");
      streamWriter.Close();
    }

    public static void CreateWorkbook(string filePath, DataSet dataset)
    {
      if (dataset.Tables.Count == 0)
        throw new ArgumentException("DataSet needs to have at least one DataTable", nameof (dataset));
      Workbook workbook = new Workbook();
      foreach (DataTable table in (InternalDataCollectionBase) dataset.Tables)
      {
        Worksheet worksheet = new Worksheet(table.TableName);
        for (int index1 = 0; index1 < table.Columns.Count; ++index1)
        {
          ((CellCollection) worksheet.Cells).set_Item(0, index1, new Cell((object) table.Columns[index1].ColumnName));
          for (int index2 = 0; index2 < table.Rows.Count; ++index2)
            ((CellCollection) worksheet.Cells).set_Item(index2 + 1, index1, new Cell((object) table.Rows[index2][index1].ToString()));
        }
        ((List<Worksheet>) workbook.Worksheets).Add(worksheet);
      }
      workbook.Save(filePath);
    }

    private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void exportToExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      this.SaveToExcel();
    }

    private void saveResultsToExcelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.saveResults.ShowDialog() != DialogResult.OK)
        return;
      DataSet dataset = new DataSet();
      DataTable table1 = this.DataGridViewtoDataTable(this.dgStandardResults);
      table1.TableName = "Overall Summary";
      dataset.Tables.Add(table1);
      DataTable table2 = this.DataGridViewtoDataTable(this.dgCosts);
      table2.TableName = "Economic Analysis";
      dataset.Tables.Add(table2);
      DataTable table3 = this.DataGridViewtoDataTable(this.dgExcel);
      table3.TableName = "Advanced Output";
      dataset.Tables.Add(table3);
      CropResults.CreateWorkbook(this.saveResults.FileName, dataset);
      int num = (int) MessageBox.Show(this.saveResults.FileName + " has been created and saved.", "Excel output created");
    }

    private void sToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SaveToExcel();
    }

    public void SaveToExcel()
    {
      if (this.saveResults.ShowDialog() != DialogResult.OK)
        return;
      DataSet dataset = new DataSet();
      DataTable table1 = this.DataGridViewtoDataTable(this.dgStandardResults);
      table1.TableName = "Overall Summary";
      dataset.Tables.Add(table1);
      DataTable table2 = this.DataGridViewtoDataTable(this.dgCosts);
      table2.TableName = "Economic Analysis";
      dataset.Tables.Add(table2);
      DataTable table3 = this.DataGridViewtoDataTable(this.dgExcel);
      table3.TableName = "Advanced Output";
      dataset.Tables.Add(table3);
      CropResults.CreateWorkbook(this.saveResults.FileName, dataset);
      int num = (int) MessageBox.Show(this.saveResults.FileName + " has been created and saved.", "Excel output created");
    }

    private void saveToExcelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SaveToExcel();
    }

    private void keepRToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RestartWithResults(this.model);
    }

    public void SetRestartText(string restartText)
    {
      this.mnuKeep.Text = restartText;
    }

    public void HideRestartButton()
    {
      this.mnuKeep.Visible = false;
    }

    private void menuStrip7_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void helpToolStripMenuItem4_Click(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm");
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {
    }

    private void printToolStripMenuItem1_Click_1(object sender, EventArgs e)
    {
      this.npBalance.Print(true);
    }

    private void helpToolStripMenuItem1_Click_1(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm#asw");
    }

    private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void helpToolStripMenuItem4_Click_1(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm#output");
    }

    private void helpToolStripMenuItem5_Click(object sender, EventArgs e)
    {
      this.ShowHelp("results.htm#output");
    }
  }
}
