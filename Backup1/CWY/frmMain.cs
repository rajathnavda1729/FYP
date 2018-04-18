// Decompiled with JetBrains decompiler
// Type: CWY.frmMain
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using KSWB.Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace CWY
{
  internal class frmMain : Form
  {
    public CWYModel mainCWY = new CWYModel();
    private ArrayList junk = new ArrayList();
    private IContainer components;
    private DataSet dataSet1;
    private DataTable dataTable1;
    private DataColumn dataColumn1;
    private DataColumn dataColumn2;
    private DataGridView dataGridView1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn names;
    private BackgroundWorker backgroundWorker1;
    private TabControl tabControl1;
    private TabPage tpLocation;
    private Label label2;
    private TabPage tpSoil;
    private TabPage tpCrop;
    private Button cmdRun;
    private ListBox lstSoils;
    private Label label9;
    private TabControl tcOverall;
    private TabPage tpGeneral;
    private ListBox lstLocations;
    private GroupBox groupBox5;
    private GroupBox groupBox9;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private TabPage tpResults;
    private Button button6;
    private TabControl tcCrops;
    private Button cmdDeleteCrop;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private GroupBox groupBox3;
    private Label label12;
    private SaveFileDialog saveFile;
    private OpenFileDialog openFile;
    private Label label18;
    private TabControl tcResults;
    private Label lblAnnualPrecip;
    private Label lblAWS;
    private Label label3;
    private ToolStripMenuItem exitToolStripMenuItem;
    private TabPage tpRunoff;
    private GroupBox groupBox2;
    private Label label10;
    private TabPage tpEfficiency;
    private GroupBox groupBox11;
    private Label label23;
    private TextBox txtEfficiency;
    private Label label17;
    private BackgroundWorker backgroundWorker2;
    private BackgroundWorker backgroundWorker3;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem unitsToolStripMenuItem;
    public MenuStrip menuStrip1;
    public ToolStripMenuItem englishToolStripMenuItem;
    public ToolStripMenuItem metricToolStripMenuItem;
    private TextBox txtAnnualPrecip;
    private ImageList ilMain;
    private ImageList ilTabs;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    public DataGridView dgRunoff;
    private GroupBox groupBox6;
    private Label label14;
    private Label label11;
    private GroupBox groupBox1;
    private Label label4;
    private Label label7;
    public DataGridView dgEmergence;
    private Button button7;
    private Button button8;
    private GroupBox gbProbability;
    private Label label6;
    private Label label1;
    private Label label8;
    private Label label15;
    private Label label13;
    private Label lblPWP;
    private Label lblFC;
    private GroupBox groupBox4;
    private CheckBox chkMeasured;
    private DateTimePicker mcStart;
    private Label label5;
    private TextBox txtMeasuredWater;
    private Panel pnlASWSpecific;
    private Label label16;
    private Label label19;
    private Button btn20;
    private Button btn50;
    private Button btn80;
    private Label label20;
    private Label label21;
    private HelpProvider hp;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private Label label22;
    private Button btnMean;
    private Button button5;
    private Button button9;
    private Label label24;
    private Button button10;
    private DataGridView dgASW;
    private Button button11;
    private Button button13;
    private Button button12;
    private Button button14;
    private Button button16;
    private Button button15;
    private Button button21;
    private Button button20;
    private Button button19;
    private Button button18;
    private Button button17;
    private Button button22;
    private LinkLabel linkLabel1;
    private GroupBox grpSoilAdvanced;
    private ToolStripMenuItem resetAllToolStripMenuItem;
    private TrackBar trackBarResidue;
    private Label lblResidueCover;
    private TabPage tpReview;
    private LinkLabel linkPrecipitation;
    private LinkLabel linkLocation;
    private Label label25;
    private LinkLabel linkCosts;
    private Label label32;
    private LinkLabel linkPrice;
    private Label label31;
    private LinkLabel linkIrrigation;
    private Label label30;
    private LinkLabel linkCrop;
    private Label label29;
    private LinkLabel linkEff;
    private Label label28;
    private LinkLabel linkSoil;
    private Label label27;
    private Label label26;
    private LinkLabel linkRunoff;
    private Label label33;
    private GroupBox groupBox7;
    private Label label34;
    private Button button23;
    private TabPage ActiveTab;
    private string tempName;
    private Assembly _assembly;
    private int tabCount;
    private int resultcount;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.dataSet1 = new DataSet();
      this.dataTable1 = new DataTable();
      this.dataColumn1 = new DataColumn();
      this.dataColumn2 = new DataColumn();
      this.dataGridView1 = new DataGridView();
      this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.names = new DataGridViewTextBoxColumn();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.tabControl1 = new TabControl();
      this.tpLocation = new TabPage();
      this.groupBox9 = new GroupBox();
      this.button14 = new Button();
      this.button5 = new Button();
      this.label20 = new Label();
      this.gbProbability = new GroupBox();
      this.btnMean = new Button();
      this.label22 = new Label();
      this.btn20 = new Button();
      this.btn50 = new Button();
      this.btn80 = new Button();
      this.label8 = new Label();
      this.label6 = new Label();
      this.label1 = new Label();
      this.lblAnnualPrecip = new Label();
      this.txtAnnualPrecip = new TextBox();
      this.pictureBox1 = new PictureBox();
      this.lstLocations = new ListBox();
      this.label18 = new Label();
      this.label2 = new Label();
      this.tpSoil = new TabPage();
      this.groupBox5 = new GroupBox();
      this.label21 = new Label();
      this.button9 = new Button();
      this.groupBox3 = new GroupBox();
      this.linkLabel1 = new LinkLabel();
      this.grpSoilAdvanced = new GroupBox();
      this.label13 = new Label();
      this.label19 = new Label();
      this.label15 = new Label();
      this.label16 = new Label();
      this.lblFC = new Label();
      this.lblPWP = new Label();
      this.lblAWS = new Label();
      this.label12 = new Label();
      this.lstSoils = new ListBox();
      this.label9 = new Label();
      this.tpEfficiency = new TabPage();
      this.button22 = new Button();
      this.button21 = new Button();
      this.button20 = new Button();
      this.button19 = new Button();
      this.button18 = new Button();
      this.button17 = new Button();
      this.groupBox11 = new GroupBox();
      this.button16 = new Button();
      this.button15 = new Button();
      this.button10 = new Button();
      this.label24 = new Label();
      this.pictureBox2 = new PictureBox();
      this.label23 = new Label();
      this.txtEfficiency = new TextBox();
      this.label17 = new Label();
      this.tpCrop = new TabPage();
      this.cmdDeleteCrop = new Button();
      this.tcCrops = new TabControl();
      this.button6 = new Button();
      this.tpRunoff = new TabPage();
      this.groupBox1 = new GroupBox();
      this.button13 = new Button();
      this.button7 = new Button();
      this.dgEmergence = new DataGridView();
      this.label4 = new Label();
      this.label7 = new Label();
      this.groupBox6 = new GroupBox();
      this.button12 = new Button();
      this.dgASW = new DataGridView();
      this.groupBox4 = new GroupBox();
      this.pnlASWSpecific = new Panel();
      this.mcStart = new DateTimePicker();
      this.txtMeasuredWater = new TextBox();
      this.label5 = new Label();
      this.chkMeasured = new CheckBox();
      this.label14 = new Label();
      this.label11 = new Label();
      this.groupBox2 = new GroupBox();
      this.lblResidueCover = new Label();
      this.trackBarResidue = new TrackBar();
      this.button11 = new Button();
      this.button8 = new Button();
      this.dgRunoff = new DataGridView();
      this.label10 = new Label();
      this.tpReview = new TabPage();
      this.groupBox7 = new GroupBox();
      this.button23 = new Button();
      this.label34 = new Label();
      this.label26 = new Label();
      this.linkRunoff = new LinkLabel();
      this.label25 = new Label();
      this.label33 = new Label();
      this.linkLocation = new LinkLabel();
      this.linkCosts = new LinkLabel();
      this.linkPrecipitation = new LinkLabel();
      this.label32 = new Label();
      this.label27 = new Label();
      this.linkPrice = new LinkLabel();
      this.linkSoil = new LinkLabel();
      this.label31 = new Label();
      this.label28 = new Label();
      this.linkIrrigation = new LinkLabel();
      this.linkEff = new LinkLabel();
      this.label30 = new Label();
      this.label29 = new Label();
      this.linkCrop = new LinkLabel();
      this.ilTabs = new ImageList(this.components);
      this.backgroundWorker1 = new BackgroundWorker();
      this.tcOverall = new TabControl();
      this.tpGeneral = new TabPage();
      this.tpResults = new TabPage();
      this.tcResults = new TabControl();
      this.ilMain = new ImageList(this.components);
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.saveToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.optionsToolStripMenuItem = new ToolStripMenuItem();
      this.unitsToolStripMenuItem = new ToolStripMenuItem();
      this.englishToolStripMenuItem = new ToolStripMenuItem();
      this.metricToolStripMenuItem = new ToolStripMenuItem();
      this.resetAllToolStripMenuItem = new ToolStripMenuItem();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.saveFile = new SaveFileDialog();
      this.openFile = new OpenFileDialog();
      this.label3 = new Label();
      this.hp = new HelpProvider();
      this.cmdRun = new Button();
      this.pictureBox4 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.dataSet1.BeginInit();
      this.dataTable1.BeginInit();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tpLocation.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.gbProbability.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.tpSoil.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.grpSoilAdvanced.SuspendLayout();
      this.tpEfficiency.SuspendLayout();
      this.groupBox11.SuspendLayout();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.tpCrop.SuspendLayout();
      this.tpRunoff.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgEmergence).BeginInit();
      this.groupBox6.SuspendLayout();
      ((ISupportInitialize) this.dgASW).BeginInit();
      this.groupBox4.SuspendLayout();
      this.pnlASWSpecific.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.trackBarResidue.BeginInit();
      ((ISupportInitialize) this.dgRunoff).BeginInit();
      this.tpReview.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.tcOverall.SuspendLayout();
      this.tpGeneral.SuspendLayout();
      this.tpResults.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      this.SuspendLayout();
      this.dataSet1.DataSetName = "NewDataSet";
      this.dataSet1.Tables.AddRange(new DataTable[1]
      {
        this.dataTable1
      });
      this.dataTable1.Columns.AddRange(new DataColumn[2]
      {
        this.dataColumn1,
        this.dataColumn2
      });
      this.dataTable1.TableName = "people";
      this.dataColumn1.AutoIncrement = true;
      this.dataColumn1.ColumnName = "id";
      this.dataColumn1.DataType = typeof (int);
      this.dataColumn2.ColumnName = "names";
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.idDataGridViewTextBoxColumn, (DataGridViewColumn) this.names);
      this.dataGridView1.DataMember = "people";
      this.dataGridView1.DataSource = (object) this.dataSet1;
      this.dataGridView1.Location = new Point(662, 647);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new Size(248, 52);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.Visible = false;
      this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
      this.idDataGridViewTextBoxColumn.HeaderText = "id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.names.DataPropertyName = "names";
      this.names.HeaderText = "names";
      this.names.Name = "names";
      this.button1.Location = new Point(46, 633);
      this.button1.Name = "button1";
      this.button1.Size = new Size(86, 42);
      this.button1.TabIndex = 4;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(209, 625);
      this.button2.Name = "button2";
      this.button2.Size = new Size(81, 50);
      this.button2.TabIndex = 5;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Visible = false;
      this.button3.Location = new Point(350, 638);
      this.button3.Name = "button3";
      this.button3.Size = new Size(81, 33);
      this.button3.TabIndex = 6;
      this.button3.Text = "Add Date";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Visible = false;
      this.button4.Location = new Point(464, 660);
      this.button4.Name = "button4";
      this.button4.Size = new Size(110, 29);
      this.button4.TabIndex = 7;
      this.button4.Text = "Add String!";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Visible = false;
      this.tabControl1.Controls.Add((Control) this.tpLocation);
      this.tabControl1.Controls.Add((Control) this.tpSoil);
      this.tabControl1.Controls.Add((Control) this.tpEfficiency);
      this.tabControl1.Controls.Add((Control) this.tpCrop);
      this.tabControl1.Controls.Add((Control) this.tpRunoff);
      this.tabControl1.Controls.Add((Control) this.tpReview);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tabControl1.ImageList = this.ilTabs;
      this.tabControl1.ItemSize = new Size(95, 32);
      this.tabControl1.Location = new Point(20, 5);
      this.tabControl1.Margin = new Padding(10, 3, 3, 3);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.Padding = new Point(5, 5);
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(856, 401);
      this.tabControl1.TabIndex = 4;
      this.tabControl1.Selected += new TabControlEventHandler(this.tabControl1_Selected);
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tpLocation.AutoScroll = true;
      this.tpLocation.BackColor = Color.White;
      this.tpLocation.BackgroundImageLayout = ImageLayout.Stretch;
      this.tpLocation.Controls.Add((Control) this.groupBox9);
      this.tpLocation.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tpLocation.ImageIndex = 0;
      this.tpLocation.Location = new Point(4, 36);
      this.tpLocation.Name = "tpLocation";
      this.tpLocation.Padding = new Padding(3);
      this.tpLocation.Size = new Size(848, 361);
      this.tpLocation.TabIndex = 0;
      this.tpLocation.Text = "Location & Rainfall";
      this.tpLocation.UseVisualStyleBackColor = true;
      this.groupBox9.BackColor = Color.White;
      this.groupBox9.Controls.Add((Control) this.button14);
      this.groupBox9.Controls.Add((Control) this.button5);
      this.groupBox9.Controls.Add((Control) this.label20);
      this.groupBox9.Controls.Add((Control) this.gbProbability);
      this.groupBox9.Controls.Add((Control) this.lblAnnualPrecip);
      this.groupBox9.Controls.Add((Control) this.txtAnnualPrecip);
      this.groupBox9.Controls.Add((Control) this.pictureBox1);
      this.groupBox9.Controls.Add((Control) this.lstLocations);
      this.groupBox9.Controls.Add((Control) this.label18);
      this.groupBox9.Controls.Add((Control) this.label2);
      this.groupBox9.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox9.ForeColor = Color.SteelBlue;
      this.groupBox9.Location = new Point(3, 3);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new Size(776, 352);
      this.groupBox9.TabIndex = 5;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Location based data";
      this.button14.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button14.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button14, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button14, "");
      this.button14.Location = new Point(333, 206);
      this.button14.Name = "button14";
      this.hp.SetShowHelp((Control) this.button14, true);
      this.button14.Size = new Size(28, 23);
      this.button14.TabIndex = 22;
      this.button14.Text = "?";
      this.button14.UseVisualStyleBackColor = true;
      this.button14.Click += new EventHandler(this.button14_Click);
      this.button5.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button5.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button5, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button5, "");
      this.button5.Location = new Point(178, 31);
      this.button5.Name = "button5";
      this.hp.SetShowHelp((Control) this.button5, true);
      this.button5.Size = new Size(28, 23);
      this.button5.TabIndex = 21;
      this.button5.Text = "?";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click_2);
      this.label20.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.ForeColor = Color.Maroon;
      this.label20.Location = new Point(26, 267);
      this.label20.Name = "label20";
      this.label20.Size = new Size(180, 88);
      this.label20.TabIndex = 10;
      this.label20.Text = "Adjusting precipitation will affect the default Runoff coefficient.  Be sure to visit the Runoff && Soil Water tab if an alternate coefficient is desired.";
      this.gbProbability.Controls.Add((Control) this.btnMean);
      this.gbProbability.Controls.Add((Control) this.label22);
      this.gbProbability.Controls.Add((Control) this.btn20);
      this.gbProbability.Controls.Add((Control) this.btn50);
      this.gbProbability.Controls.Add((Control) this.btn80);
      this.gbProbability.Controls.Add((Control) this.label8);
      this.gbProbability.Controls.Add((Control) this.label6);
      this.gbProbability.Controls.Add((Control) this.label1);
      this.gbProbability.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gbProbability.Location = new Point(212, 235);
      this.gbProbability.Name = "gbProbability";
      this.gbProbability.Size = new Size(232, 94);
      this.gbProbability.TabIndex = 9;
      this.gbProbability.TabStop = false;
      this.gbProbability.Text = "Rainfall Probability (select a location)";
      this.btnMean.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnMean.ForeColor = Color.RoyalBlue;
      this.btnMean.Location = new Point(112, 64);
      this.btnMean.Name = "btnMean";
      this.btnMean.Size = new Size(113, 23);
      this.btnMean.TabIndex = 20;
      this.btnMean.Text = "--";
      this.btnMean.UseVisualStyleBackColor = true;
      this.btnMean.Click += new EventHandler(this.btnMean_Click);
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.ForeColor = Color.FromArgb(64, 64, 64);
      this.label22.Location = new Point(8, 68);
      this.label22.Name = "label22";
      this.label22.Size = new Size(98, 14);
      this.label22.TabIndex = 19;
      this.label22.Text = "Long term mean";
      this.label22.TextAlign = ContentAlignment.TopCenter;
      this.btn20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btn20.ForeColor = Color.RoyalBlue;
      this.btn20.Location = new Point(171, 33);
      this.btn20.Name = "btn20";
      this.btn20.Size = new Size(54, 23);
      this.btn20.TabIndex = 18;
      this.btn20.Text = "--";
      this.btn20.UseVisualStyleBackColor = true;
      this.btn20.Click += new EventHandler(this.btn20_Click);
      this.btn50.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btn50.ForeColor = Color.RoyalBlue;
      this.btn50.Location = new Point(90, 33);
      this.btn50.Name = "btn50";
      this.btn50.Size = new Size(54, 23);
      this.btn50.TabIndex = 17;
      this.btn50.Text = "--";
      this.btn50.UseVisualStyleBackColor = true;
      this.btn50.Click += new EventHandler(this.btn50_Click);
      this.btn80.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btn80.ForeColor = Color.RoyalBlue;
      this.btn80.Location = new Point(6, 33);
      this.btn80.Name = "btn80";
      this.btn80.Size = new Size(54, 23);
      this.btn80.TabIndex = 16;
      this.btn80.Text = "--";
      this.btn80.UseVisualStyleBackColor = true;
      this.btn80.Click += new EventHandler(this.btn80_Click);
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = Color.FromArgb(64, 64, 64);
      this.label8.Location = new Point(171, 16);
      this.label8.Name = "label8";
      this.label8.Size = new Size(33, 14);
      this.label8.TabIndex = 12;
      this.label8.Text = "20%";
      this.label8.TextAlign = ContentAlignment.TopCenter;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.FromArgb(64, 64, 64);
      this.label6.Location = new Point(99, 16);
      this.label6.Name = "label6";
      this.label6.Size = new Size(33, 14);
      this.label6.TabIndex = 11;
      this.label6.Text = "50%";
      this.label6.TextAlign = ContentAlignment.TopCenter;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.FromArgb(64, 64, 64);
      this.label1.Location = new Point(27, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(33, 14);
      this.label1.TabIndex = 10;
      this.label1.Text = "80%";
      this.label1.TextAlign = ContentAlignment.TopCenter;
      this.lblAnnualPrecip.AutoSize = true;
      this.lblAnnualPrecip.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAnnualPrecip.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblAnnualPrecip.Location = new Point(265, 212);
      this.lblAnnualPrecip.Name = "lblAnnualPrecip";
      this.lblAnnualPrecip.Size = new Size(41, 14);
      this.lblAnnualPrecip.TabIndex = 7;
      this.lblAnnualPrecip.Text = "inches";
      this.txtAnnualPrecip.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtAnnualPrecip.CausesValidation = false;
      this.txtAnnualPrecip.Location = new Point(212, 203);
      this.txtAnnualPrecip.Name = "txtAnnualPrecip";
      this.txtAnnualPrecip.Size = new Size(52, 26);
      this.txtAnnualPrecip.TabIndex = 8;
      this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox1.Image = (Image) Resources.map2;
      this.pictureBox1.Location = new Point(460, 31);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(304, 233);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      this.lstLocations.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.lstLocations.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lstLocations.FormattingEnabled = true;
      this.lstLocations.ItemHeight = 16;
      this.lstLocations.Items.AddRange(new object[1]
      {
        (object) "No items loaded yet..."
      });
      this.lstLocations.Location = new Point(212, 31);
      this.lstLocations.Name = "lstLocations";
      this.lstLocations.Size = new Size(196, 164);
      this.lstLocations.TabIndex = 4;
      this.lstLocations.SelectedIndexChanged += new EventHandler(this.lstLocations_SelectedIndexChanged);
      this.label18.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.ForeColor = Color.FromArgb(64, 64, 64);
      this.label18.Location = new Point(26, 203);
      this.label18.Name = "label18";
      this.label18.Size = new Size(169, 64);
      this.label18.TabIndex = 4;
      this.label18.Text = "Provide the annual precipitation for your location.";
      this.label2.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.FromArgb(64, 64, 64);
      this.label2.Location = new Point(26, 31);
      this.label2.Name = "label2";
      this.label2.Size = new Size(126, 143);
      this.label2.TabIndex = 3;
      this.label2.Text = "Select the nearest location from the list to load default weather data for that location";
      this.tpSoil.AutoScroll = true;
      this.tpSoil.BackColor = Color.White;
      this.tpSoil.Controls.Add((Control) this.groupBox5);
      this.tpSoil.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tpSoil.ImageIndex = 1;
      this.tpSoil.Location = new Point(4, 36);
      this.tpSoil.Name = "tpSoil";
      this.tpSoil.Padding = new Padding(3);
      this.tpSoil.Size = new Size(848, 361);
      this.tpSoil.TabIndex = 1;
      this.tpSoil.Text = "Soil Information";
      this.tpSoil.UseVisualStyleBackColor = true;
      this.groupBox5.Controls.Add((Control) this.label21);
      this.groupBox5.Controls.Add((Control) this.button9);
      this.groupBox5.Controls.Add((Control) this.groupBox3);
      this.groupBox5.Controls.Add((Control) this.lstSoils);
      this.groupBox5.Controls.Add((Control) this.label9);
      this.groupBox5.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox5.ForeColor = Color.SteelBlue;
      this.groupBox5.Location = new Point(3, 3);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(839, 158);
      this.groupBox5.TabIndex = 6;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Soil Type";
      this.label21.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.ForeColor = Color.Maroon;
      this.label21.Location = new Point(33, 60);
      this.label21.Name = "label21";
      this.label21.Size = new Size(219, 62);
      this.label21.TabIndex = 11;
      this.label21.Text = "Adjusting soil type will affect the default Runoff coefficient.  Be sure to visit the Runoff && Soil Water tab if an alternate coefficient is desired.";
      this.button9.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button9.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button9, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button9, "");
      this.button9.Location = new Point(224, 18);
      this.button9.Name = "button9";
      this.hp.SetShowHelp((Control) this.button9, true);
      this.button9.Size = new Size(28, 23);
      this.button9.TabIndex = 22;
      this.button9.Text = "?";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new EventHandler(this.button9_Click_1);
      this.groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox3.Controls.Add((Control) this.linkLabel1);
      this.groupBox3.Controls.Add((Control) this.grpSoilAdvanced);
      this.groupBox3.Controls.Add((Control) this.lblAWS);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox3.ForeColor = Color.LightSlateGray;
      this.groupBox3.Location = new Point(520, 19);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(313, 130);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Soil Factors";
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkLabel1.Location = new Point(221, 14);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(84, 13);
      this.linkLabel1.TabIndex = 16;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Show Advanced";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.grpSoilAdvanced.Controls.Add((Control) this.label13);
      this.grpSoilAdvanced.Controls.Add((Control) this.label19);
      this.grpSoilAdvanced.Controls.Add((Control) this.label15);
      this.grpSoilAdvanced.Controls.Add((Control) this.label16);
      this.grpSoilAdvanced.Controls.Add((Control) this.lblFC);
      this.grpSoilAdvanced.Controls.Add((Control) this.lblPWP);
      this.grpSoilAdvanced.Location = new Point(6, 46);
      this.grpSoilAdvanced.Name = "grpSoilAdvanced";
      this.grpSoilAdvanced.Size = new Size(301, 78);
      this.grpSoilAdvanced.TabIndex = 7;
      this.grpSoilAdvanced.TabStop = false;
      this.grpSoilAdvanced.Visible = false;
      this.label13.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = Color.DimGray;
      this.label13.Location = new Point(6, 12);
      this.label13.Name = "label13";
      this.label13.Size = new Size(158, 15);
      this.label13.TabIndex = 10;
      this.label13.Text = "Soil Water at Field Capacity";
      this.label13.TextAlign = ContentAlignment.TopRight;
      this.label19.AutoSize = true;
      this.label19.BackColor = Color.Transparent;
      this.label19.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.ForeColor = Color.DimGray;
      this.label19.Location = new Point(111, 59);
      this.label19.Name = "label19";
      this.label19.Size = new Size(54, 11);
      this.label19.TabIndex = 15;
      this.label19.Text = "(volumetric)";
      this.label19.TextAlign = ContentAlignment.TopRight;
      this.label15.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.DimGray;
      this.label15.Location = new Point(9, 46);
      this.label15.Name = "label15";
      this.label15.Size = new Size(155, 18);
      this.label15.TabIndex = 11;
      this.label15.Text = "Soil Water at Wilting Point";
      this.label15.TextAlign = ContentAlignment.TopRight;
      this.label16.AutoSize = true;
      this.label16.BackColor = Color.Transparent;
      this.label16.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = Color.DimGray;
      this.label16.Location = new Point(111, 28);
      this.label16.Name = "label16";
      this.label16.Size = new Size(54, 11);
      this.label16.TabIndex = 14;
      this.label16.Text = "(volumetric)";
      this.label16.TextAlign = ContentAlignment.TopRight;
      this.lblFC.AutoSize = true;
      this.lblFC.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFC.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblFC.Location = new Point(168, 13);
      this.lblFC.Name = "lblFC";
      this.lblFC.Size = new Size(27, 14);
      this.lblFC.TabIndex = 12;
      this.lblFC.Text = "mm";
      this.lblPWP.AutoSize = true;
      this.lblPWP.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPWP.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblPWP.Location = new Point(168, 46);
      this.lblPWP.Name = "lblPWP";
      this.lblPWP.Size = new Size(27, 14);
      this.lblPWP.TabIndex = 13;
      this.lblPWP.Text = "mm";
      this.lblAWS.AutoSize = true;
      this.lblAWS.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAWS.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblAWS.Location = new Point(169, 32);
      this.lblAWS.Name = "lblAWS";
      this.lblAWS.Size = new Size(27, 14);
      this.lblAWS.TabIndex = 9;
      this.lblAWS.Text = "mm";
      this.label12.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.ForeColor = Color.DimGray;
      this.label12.Location = new Point(27, 31);
      this.label12.Name = "label12";
      this.label12.Size = new Size(138, 14);
      this.label12.TabIndex = 3;
      this.label12.Text = "Available Water Storage";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.lstSoils.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.lstSoils.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lstSoils.FormattingEnabled = true;
      this.lstSoils.ItemHeight = 16;
      this.lstSoils.Items.AddRange(new object[1]
      {
        (object) "Soil not yet loaded..."
      });
      this.lstSoils.Location = new Point(258, 19);
      this.lstSoils.Name = "lstSoils";
      this.lstSoils.Size = new Size(256, 116);
      this.lstSoils.TabIndex = 5;
      this.lstSoils.SelectedIndexChanged += new EventHandler(this.lstSoils_SelectedIndexChanged);
      this.label9.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = Color.FromArgb(64, 64, 64);
      this.label9.Location = new Point(18, 19);
      this.label9.Name = "label9";
      this.label9.Size = new Size(200, 109);
      this.label9.TabIndex = 4;
      this.label9.Text = "Select your soil type from the list.";
      this.tpEfficiency.AutoScroll = true;
      this.tpEfficiency.Controls.Add((Control) this.button22);
      this.tpEfficiency.Controls.Add((Control) this.button21);
      this.tpEfficiency.Controls.Add((Control) this.button20);
      this.tpEfficiency.Controls.Add((Control) this.button19);
      this.tpEfficiency.Controls.Add((Control) this.button18);
      this.tpEfficiency.Controls.Add((Control) this.button17);
      this.tpEfficiency.Controls.Add((Control) this.groupBox11);
      this.tpEfficiency.ImageIndex = 4;
      this.tpEfficiency.Location = new Point(4, 36);
      this.tpEfficiency.Name = "tpEfficiency";
      this.tpEfficiency.Size = new Size(848, 361);
      this.tpEfficiency.TabIndex = 11;
      this.tpEfficiency.Text = "Irrigation Efficiency";
      this.tpEfficiency.UseVisualStyleBackColor = true;
      this.button22.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button22.ForeColor = Color.RoyalBlue;
      this.button22.Location = new Point(712, 193);
      this.button22.Name = "button22";
      this.button22.Size = new Size(61, 19);
      this.button22.TabIndex = 31;
      this.button22.Text = "95%";
      this.button22.UseVisualStyleBackColor = true;
      this.button22.Click += new EventHandler(this.button22_Click_1);
      this.button21.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button21.ForeColor = Color.RoyalBlue;
      this.button21.Location = new Point(711, 113);
      this.button21.Name = "button21";
      this.button21.Size = new Size(61, 19);
      this.button21.TabIndex = 30;
      this.button21.Text = "80%";
      this.button21.UseVisualStyleBackColor = true;
      this.button21.Click += new EventHandler(this.button21_Click_1);
      this.button20.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button20.ForeColor = Color.RoyalBlue;
      this.button20.Location = new Point(712, 133);
      this.button20.Name = "button20";
      this.button20.Size = new Size(61, 19);
      this.button20.TabIndex = 29;
      this.button20.Text = "85%";
      this.button20.UseVisualStyleBackColor = true;
      this.button20.Click += new EventHandler(this.button20_Click);
      this.button19.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button19.ForeColor = Color.RoyalBlue;
      this.button19.Location = new Point(712, 153);
      this.button19.Name = "button19";
      this.button19.Size = new Size(61, 19);
      this.button19.TabIndex = 28;
      this.button19.Text = "88%";
      this.button19.UseVisualStyleBackColor = true;
      this.button19.Click += new EventHandler(this.button19_Click);
      this.button18.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button18.ForeColor = Color.RoyalBlue;
      this.button18.Location = new Point(712, 172);
      this.button18.Name = "button18";
      this.button18.Size = new Size(61, 19);
      this.button18.TabIndex = 27;
      this.button18.Text = "90%";
      this.button18.UseVisualStyleBackColor = true;
      this.button18.Click += new EventHandler(this.button18_Click);
      this.button17.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button17.ForeColor = Color.RoyalBlue;
      this.button17.Location = new Point(712, 93);
      this.button17.Name = "button17";
      this.button17.Size = new Size(61, 19);
      this.button17.TabIndex = 26;
      this.button17.Text = "70%";
      this.button17.UseVisualStyleBackColor = true;
      this.button17.Click += new EventHandler(this.button17_Click);
      this.groupBox11.Controls.Add((Control) this.button16);
      this.groupBox11.Controls.Add((Control) this.button15);
      this.groupBox11.Controls.Add((Control) this.button10);
      this.groupBox11.Controls.Add((Control) this.label24);
      this.groupBox11.Controls.Add((Control) this.pictureBox2);
      this.groupBox11.Controls.Add((Control) this.label23);
      this.groupBox11.Controls.Add((Control) this.txtEfficiency);
      this.groupBox11.Controls.Add((Control) this.label17);
      this.groupBox11.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox11.Location = new Point(3, 3);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new Size(787, 228);
      this.groupBox11.TabIndex = 17;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "Irrigation Application Efficiency";
      this.button16.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button16.ForeColor = Color.RoyalBlue;
      this.button16.Location = new Point(709, 70);
      this.button16.Name = "button16";
      this.button16.Size = new Size(61, 19);
      this.button16.TabIndex = 25;
      this.button16.Text = "60%";
      this.button16.UseVisualStyleBackColor = true;
      this.button16.Click += new EventHandler(this.button16_Click);
      this.button15.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button15.ForeColor = Color.RoyalBlue;
      this.button15.Location = new Point(709, 50);
      this.button15.Name = "button15";
      this.button15.Size = new Size(61, 19);
      this.button15.TabIndex = 24;
      this.button15.Text = "50%";
      this.button15.UseVisualStyleBackColor = true;
      this.button15.Click += new EventHandler(this.button15_Click);
      this.button10.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button10.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button10, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button10, "");
      this.button10.Location = new Point(400, 25);
      this.button10.Name = "button10";
      this.hp.SetShowHelp((Control) this.button10, true);
      this.button10.Size = new Size(28, 23);
      this.button10.TabIndex = 23;
      this.button10.Text = "?";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.label24.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.FromArgb(64, 64, 64);
      this.label24.Location = new Point(15, 65);
      this.label24.Name = "label24";
      this.label24.Size = new Size(271, 148);
      this.label24.TabIndex = 9;
      this.label24.Text = componentResourceManager.GetString("label24.Text");
      this.pictureBox2.Image = (Image) Resources.irrig;
      this.pictureBox2.Location = new Point(434, 25);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(341, 188);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 8;
      this.pictureBox2.TabStop = false;
      this.label23.AutoSize = true;
      this.label23.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.FromArgb(64, 64, 64);
      this.label23.Location = new Point(360, 30);
      this.label23.Name = "label23";
      this.label23.Size = new Size(23, 18);
      this.label23.TabIndex = 7;
      this.label23.Text = "%";
      this.txtEfficiency.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtEfficiency.CausesValidation = false;
      this.txtEfficiency.Location = new Point(307, 25);
      this.txtEfficiency.Name = "txtEfficiency";
      this.txtEfficiency.Size = new Size(47, 26);
      this.txtEfficiency.TabIndex = 3;
      this.label17.BackColor = Color.Transparent;
      this.label17.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.FromArgb(64, 64, 64);
      this.label17.Location = new Point(15, 28);
      this.label17.Name = "label17";
      this.label17.Size = new Size(286, 49);
      this.label17.TabIndex = 2;
      this.label17.Text = "Enter the Irrigation Application Efficiency";
      this.tpCrop.AutoScroll = true;
      this.tpCrop.BackColor = Color.Gray;
      this.tpCrop.Controls.Add((Control) this.cmdDeleteCrop);
      this.tpCrop.Controls.Add((Control) this.tcCrops);
      this.tpCrop.Controls.Add((Control) this.button6);
      this.tpCrop.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tpCrop.ImageIndex = 2;
      this.tpCrop.Location = new Point(4, 36);
      this.tpCrop.Margin = new Padding(0);
      this.tpCrop.Name = "tpCrop";
      this.tpCrop.Size = new Size(848, 361);
      this.tpCrop.TabIndex = 4;
      this.tpCrop.Text = "Crop Selection & Irrigation Schedule";
      this.tpCrop.UseVisualStyleBackColor = true;
      this.cmdDeleteCrop.BackColor = Color.Gainsboro;
      this.cmdDeleteCrop.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdDeleteCrop.ForeColor = Color.DarkRed;
      this.cmdDeleteCrop.Location = new Point(96, 3);
      this.cmdDeleteCrop.Name = "cmdDeleteCrop";
      this.cmdDeleteCrop.Size = new Size(87, 23);
      this.cmdDeleteCrop.TabIndex = 2;
      this.cmdDeleteCrop.Text = "Delete crop";
      this.cmdDeleteCrop.UseVisualStyleBackColor = false;
      this.cmdDeleteCrop.Visible = false;
      this.cmdDeleteCrop.Click += new EventHandler(this.cmdDeleteCrop_Click);
      this.tcCrops.Dock = DockStyle.Fill;
      this.tcCrops.ItemSize = new Size(0, 1);
      this.tcCrops.Location = new Point(0, 0);
      this.tcCrops.Margin = new Padding(0);
      this.tcCrops.Name = "tcCrops";
      this.tcCrops.Padding = new Point(0, 0);
      this.tcCrops.SelectedIndex = 0;
      this.tcCrops.Size = new Size(848, 361);
      this.tcCrops.TabIndex = 1;
      this.tcCrops.SelectedIndexChanged += new EventHandler(this.tcCrops_SelectedIndexChanged);
      this.button6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button6.Location = new Point(3, 3);
      this.button6.Name = "button6";
      this.button6.Size = new Size(87, 23);
      this.button6.TabIndex = 1;
      this.button6.Text = "Add crop";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Visible = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.tpRunoff.AutoScroll = true;
      this.tpRunoff.Controls.Add((Control) this.groupBox1);
      this.tpRunoff.Controls.Add((Control) this.groupBox6);
      this.tpRunoff.Controls.Add((Control) this.groupBox2);
      this.tpRunoff.ImageIndex = 5;
      this.tpRunoff.Location = new Point(4, 36);
      this.tpRunoff.Name = "tpRunoff";
      this.tpRunoff.Size = new Size(848, 361);
      this.tpRunoff.TabIndex = 10;
      this.tpRunoff.Text = "Runoff & Soil Water";
      this.tpRunoff.UseVisualStyleBackColor = true;
      this.groupBox1.BackgroundImageLayout = ImageLayout.None;
      this.groupBox1.Controls.Add((Control) this.button13);
      this.groupBox1.Controls.Add((Control) this.button7);
      this.groupBox1.Controls.Add((Control) this.dgEmergence);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.ForeColor = Color.SteelBlue;
      this.groupBox1.Location = new Point(6, 194);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(772, 101);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Initial Available Soil Water";
      this.button13.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button13.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button13, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button13, "");
      this.button13.Location = new Point(346, 14);
      this.button13.Name = "button13";
      this.hp.SetShowHelp((Control) this.button13, true);
      this.button13.Size = new Size(28, 23);
      this.button13.TabIndex = 26;
      this.button13.Text = "?";
      this.button13.UseVisualStyleBackColor = true;
      this.button13.Click += new EventHandler(this.button13_Click);
      this.button7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button7.ForeColor = Color.Black;
      this.button7.Location = new Point(657, 70);
      this.button7.Name = "button7";
      this.button7.Size = new Size(105, 25);
      this.button7.TabIndex = 8;
      this.button7.Text = "Reload Defaults";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click_1);
      this.dgEmergence.AllowUserToAddRows = false;
      this.dgEmergence.AllowUserToDeleteRows = false;
      this.dgEmergence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgEmergence.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.dgEmergence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgEmergence.Location = new Point(380, 14);
      this.dgEmergence.Name = "dgEmergence";
      gridViewCellStyle1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dgEmergence.RowsDefaultCellStyle = gridViewCellStyle1;
      this.dgEmergence.ScrollBars = ScrollBars.Vertical;
      this.dgEmergence.Size = new Size(271, 81);
      this.dgEmergence.TabIndex = 9;
      this.dgEmergence.CellEndEdit += new DataGridViewCellEventHandler(this.dgEmergence_CellEndEdit);
      this.label4.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.FromArgb(64, 64, 64);
      this.label4.Location = new Point(6, 29);
      this.label4.Name = "label4";
      this.label4.Size = new Size(302, 56);
      this.label4.TabIndex = 8;
      this.label4.Text = "Enter a value for available soil water at the start of the evaluation (October 1) for your selected crop.";
      this.label7.ForeColor = Color.FromArgb(64, 64, 64);
      this.label7.Location = new Point(15, 29);
      this.label7.Name = "label7";
      this.label7.Size = new Size(302, 33);
      this.label7.TabIndex = 5;
      this.label7.Text = "Enter the initial available water amount in the 1.8m profile";
      this.groupBox6.BackgroundImageLayout = ImageLayout.None;
      this.groupBox6.Controls.Add((Control) this.button12);
      this.groupBox6.Controls.Add((Control) this.dgASW);
      this.groupBox6.Controls.Add((Control) this.groupBox4);
      this.groupBox6.Controls.Add((Control) this.label14);
      this.groupBox6.Controls.Add((Control) this.label11);
      this.groupBox6.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox6.ForeColor = Color.SteelBlue;
      this.groupBox6.Location = new Point(6, 301);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(772, 182);
      this.groupBox6.TabIndex = 10;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Available Soil Water on Specific Date";
      this.button12.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button12.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button12, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button12, "");
      this.button12.Location = new Point(346, 29);
      this.button12.Name = "button12";
      this.hp.SetShowHelp((Control) this.button12, true);
      this.button12.Size = new Size(28, 23);
      this.button12.TabIndex = 25;
      this.button12.Text = "?";
      this.button12.UseVisualStyleBackColor = true;
      this.button12.Click += new EventHandler(this.button12_Click);
      this.dgASW.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.dgASW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgASW.Location = new Point(380, 25);
      this.dgASW.MultiSelect = false;
      this.dgASW.Name = "dgASW";
      this.dgASW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgASW.ShowCellErrors = false;
      this.dgASW.ShowRowErrors = false;
      this.dgASW.Size = new Size(271, 151);
      this.dgASW.TabIndex = 11;
      this.groupBox4.Controls.Add((Control) this.pnlASWSpecific);
      this.groupBox4.Controls.Add((Control) this.chkMeasured);
      this.groupBox4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox4.Location = new Point(9, 129);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(319, 69);
      this.groupBox4.TabIndex = 10;
      this.groupBox4.TabStop = false;
      this.groupBox4.Visible = false;
      this.pnlASWSpecific.Controls.Add((Control) this.mcStart);
      this.pnlASWSpecific.Controls.Add((Control) this.txtMeasuredWater);
      this.pnlASWSpecific.Controls.Add((Control) this.label5);
      this.pnlASWSpecific.Enabled = false;
      this.pnlASWSpecific.Location = new Point(22, 26);
      this.pnlASWSpecific.Name = "pnlASWSpecific";
      this.pnlASWSpecific.Size = new Size(281, 32);
      this.pnlASWSpecific.TabIndex = 14;
      this.mcStart.Checked = false;
      this.mcStart.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mcStart.Format = DateTimePickerFormat.Custom;
      this.mcStart.Location = new Point(128, 3);
      this.mcStart.Name = "mcStart";
      this.mcStart.Size = new Size(136, 26);
      this.mcStart.TabIndex = 12;
      this.txtMeasuredWater.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtMeasuredWater.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMeasuredWater.Location = new Point(14, 4);
      this.txtMeasuredWater.Name = "txtMeasuredWater";
      this.txtMeasuredWater.Size = new Size(36, 26);
      this.txtMeasuredWater.TabIndex = 10;
      this.txtMeasuredWater.Text = "100";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.FromArgb(64, 64, 64);
      this.label5.Location = new Point(49, 8);
      this.label5.Name = "label5";
      this.label5.Size = new Size(80, 18);
      this.label5.TabIndex = 11;
      this.label5.Text = "% ASW on";
      this.chkMeasured.AutoSize = true;
      this.chkMeasured.Location = new Point(9, 12);
      this.chkMeasured.Name = "chkMeasured";
      this.chkMeasured.Size = new Size(205, 18);
      this.chkMeasured.TabIndex = 13;
      this.chkMeasured.Text = "Use ASW and Date values below";
      this.chkMeasured.UseVisualStyleBackColor = true;
      this.label14.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.FromArgb(64, 64, 64);
      this.label14.Location = new Point(6, 29);
      this.label14.Name = "label14";
      this.label14.Size = new Size(302, 109);
      this.label14.TabIndex = 8;
      this.label14.Text = componentResourceManager.GetString("label14.Text");
      this.label11.ForeColor = Color.FromArgb(64, 64, 64);
      this.label11.Location = new Point(15, 29);
      this.label11.Name = "label11";
      this.label11.Size = new Size(302, 33);
      this.label11.TabIndex = 5;
      this.label11.Text = "Enter the initial available water amount in the 1.8m profile";
      this.groupBox2.Controls.Add((Control) this.lblResidueCover);
      this.groupBox2.Controls.Add((Control) this.trackBarResidue);
      this.groupBox2.Controls.Add((Control) this.button11);
      this.groupBox2.Controls.Add((Control) this.button8);
      this.groupBox2.Controls.Add((Control) this.dgRunoff);
      this.groupBox2.Controls.Add((Control) this.label10);
      this.groupBox2.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.ForeColor = Color.SteelBlue;
      this.groupBox2.Location = new Point(6, 46);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(772, 146);
      this.groupBox2.TabIndex = 9;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Runoff Fraction";
      this.groupBox2.Enter += new EventHandler(this.groupBox2_Enter);
      this.lblResidueCover.AutoSize = true;
      this.lblResidueCover.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblResidueCover.Location = new Point(616, 17);
      this.lblResidueCover.Name = "lblResidueCover";
      this.lblResidueCover.Size = new Size(107, 14);
      this.lblResidueCover.TabIndex = 26;
      this.lblResidueCover.Text = "0% Residue Cover";
      this.trackBarResidue.BackColor = Color.White;
      this.trackBarResidue.LargeChange = 10;
      this.trackBarResidue.Location = new Point(602, 40);
      this.trackBarResidue.Maximum = 100;
      this.trackBarResidue.Name = "trackBarResidue";
      this.trackBarResidue.Size = new Size(160, 45);
      this.trackBarResidue.SmallChange = 10;
      this.trackBarResidue.TabIndex = 25;
      this.trackBarResidue.TickFrequency = 10;
      this.trackBarResidue.ValueChanged += new EventHandler(this.trackBarResidue_ValueChanged);
      this.button11.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button11.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button11, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button11, "");
      this.button11.Location = new Point(346, 17);
      this.button11.Name = "button11";
      this.hp.SetShowHelp((Control) this.button11, true);
      this.button11.Size = new Size(28, 23);
      this.button11.TabIndex = 24;
      this.button11.Text = "?";
      this.button11.UseVisualStyleBackColor = true;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.button8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button8.ForeColor = Color.Black;
      this.button8.Location = new Point(657, 99);
      this.button8.Name = "button8";
      this.button8.Size = new Size(105, 25);
      this.button8.TabIndex = 10;
      this.button8.Text = "Reload Defaults";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.dgRunoff.AllowUserToAddRows = false;
      this.dgRunoff.AllowUserToDeleteRows = false;
      this.dgRunoff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgRunoff.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.dgRunoff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgRunoff.Location = new Point(380, 17);
      this.dgRunoff.Name = "dgRunoff";
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dgRunoff.RowsDefaultCellStyle = gridViewCellStyle2;
      this.dgRunoff.ScrollBars = ScrollBars.Vertical;
      this.dgRunoff.Size = new Size(195, 83);
      this.dgRunoff.TabIndex = 7;
      this.dgRunoff.CellEndEdit += new DataGridViewCellEventHandler(this.dgRunoff_CellEndEdit);
      this.label10.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = Color.FromArgb(64, 64, 64);
      this.label10.Location = new Point(15, 29);
      this.label10.Name = "label10";
      this.label10.Size = new Size(302, 56);
      this.label10.TabIndex = 5;
      this.label10.Text = "Use default values or enter an alternate runoff coefficient for the program to use.  This is a percentage of annual precipitation.";
      this.tpReview.Controls.Add((Control) this.groupBox7);
      this.tpReview.ImageIndex = 6;
      this.tpReview.Location = new Point(4, 36);
      this.tpReview.Name = "tpReview";
      this.tpReview.Padding = new Padding(3);
      this.tpReview.Size = new Size(848, 361);
      this.tpReview.TabIndex = 12;
      this.tpReview.Text = "Review Inputs";
      this.tpReview.UseVisualStyleBackColor = true;
      this.groupBox7.Controls.Add((Control) this.button23);
      this.groupBox7.Controls.Add((Control) this.label34);
      this.groupBox7.Controls.Add((Control) this.label26);
      this.groupBox7.Controls.Add((Control) this.linkRunoff);
      this.groupBox7.Controls.Add((Control) this.label25);
      this.groupBox7.Controls.Add((Control) this.label33);
      this.groupBox7.Controls.Add((Control) this.linkLocation);
      this.groupBox7.Controls.Add((Control) this.linkCosts);
      this.groupBox7.Controls.Add((Control) this.linkPrecipitation);
      this.groupBox7.Controls.Add((Control) this.label32);
      this.groupBox7.Controls.Add((Control) this.label27);
      this.groupBox7.Controls.Add((Control) this.linkPrice);
      this.groupBox7.Controls.Add((Control) this.linkSoil);
      this.groupBox7.Controls.Add((Control) this.label31);
      this.groupBox7.Controls.Add((Control) this.label28);
      this.groupBox7.Controls.Add((Control) this.linkIrrigation);
      this.groupBox7.Controls.Add((Control) this.linkEff);
      this.groupBox7.Controls.Add((Control) this.label30);
      this.groupBox7.Controls.Add((Control) this.label29);
      this.groupBox7.Controls.Add((Control) this.linkCrop);
      this.groupBox7.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox7.Location = new Point(6, 6);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(836, 332);
      this.groupBox7.TabIndex = 22;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Review Inputs";
      this.button23.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button23.ForeColor = Color.SteelBlue;
      this.button23.Location = new Point(565, 30);
      this.button23.Name = "button23";
      this.button23.Size = new Size(34, 23);
      this.button23.TabIndex = 23;
      this.button23.Text = "?";
      this.button23.UseVisualStyleBackColor = true;
      this.button23.Click += new EventHandler(this.button23_Click_1);
      this.label34.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label34.ForeColor = Color.FromArgb(64, 64, 64);
      this.label34.Location = new Point(22, 30);
      this.label34.Name = "label34";
      this.label34.Size = new Size(603, 28);
      this.label34.TabIndex = 22;
      this.label34.Text = "Inputs used in the model are listed below.  Click on the underlined values to edit.";
      this.label26.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.DimGray;
      this.label26.Location = new Point(63, 83);
      this.label26.Name = "label26";
      this.label26.Size = new Size(121, 16);
      this.label26.TabIndex = 7;
      this.label26.Text = "Location";
      this.label26.TextAlign = ContentAlignment.TopRight;
      this.linkRunoff.AutoSize = true;
      this.linkRunoff.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkRunoff.Location = new Point(190, 301);
      this.linkRunoff.Name = "linkRunoff";
      this.linkRunoff.Size = new Size(18, 16);
      this.linkRunoff.TabIndex = 21;
      this.linkRunoff.TabStop = true;
      this.linkRunoff.Text = "--";
      this.linkRunoff.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkRunoff_LinkClicked);
      this.label25.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label25.ForeColor = Color.DimGray;
      this.label25.Location = new Point(63, 108);
      this.label25.Name = "label25";
      this.label25.Size = new Size(121, 16);
      this.label25.TabIndex = 0;
      this.label25.Text = "Annual Precipitation";
      this.label25.TextAlign = ContentAlignment.TopRight;
      this.label33.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label33.ForeColor = Color.DimGray;
      this.label33.Location = new Point(20, 301);
      this.label33.Name = "label33";
      this.label33.Size = new Size(164, 24);
      this.label33.TabIndex = 20;
      this.label33.Text = "Runoff Fraction";
      this.label33.TextAlign = ContentAlignment.TopRight;
      this.linkLocation.AutoSize = true;
      this.linkLocation.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkLocation.Location = new Point(190, 83);
      this.linkLocation.Name = "linkLocation";
      this.linkLocation.Size = new Size(18, 16);
      this.linkLocation.TabIndex = 2;
      this.linkLocation.TabStop = true;
      this.linkLocation.Text = "--";
      this.linkLocation.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLocation_LinkClicked);
      this.linkCosts.AutoSize = true;
      this.linkCosts.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkCosts.Location = new Point(190, 271);
      this.linkCosts.Name = "linkCosts";
      this.linkCosts.Size = new Size(79, 16);
      this.linkCosts.TabIndex = 19;
      this.linkCosts.TabStop = true;
      this.linkCosts.Text = "Click to view";
      this.linkCosts.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCosts_LinkClicked);
      this.linkPrecipitation.AutoSize = true;
      this.linkPrecipitation.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkPrecipitation.Location = new Point(190, 108);
      this.linkPrecipitation.Name = "linkPrecipitation";
      this.linkPrecipitation.Size = new Size(18, 16);
      this.linkPrecipitation.TabIndex = 3;
      this.linkPrecipitation.TabStop = true;
      this.linkPrecipitation.Text = "--";
      this.linkPrecipitation.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkPrecipitation_LinkClicked);
      this.label32.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label32.ForeColor = Color.DimGray;
      this.label32.Location = new Point(33, 271);
      this.label32.Name = "label32";
      this.label32.Size = new Size(151, 16);
      this.label32.TabIndex = 18;
      this.label32.Text = "Costs and Returns";
      this.label32.TextAlign = ContentAlignment.TopRight;
      this.label27.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label27.ForeColor = Color.DimGray;
      this.label27.Location = new Point(63, 138);
      this.label27.Name = "label27";
      this.label27.Size = new Size(121, 16);
      this.label27.TabIndex = 8;
      this.label27.Text = "Soil";
      this.label27.TextAlign = ContentAlignment.TopRight;
      this.linkPrice.AutoSize = true;
      this.linkPrice.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkPrice.Location = new Point(190, 245);
      this.linkPrice.Name = "linkPrice";
      this.linkPrice.Size = new Size(18, 16);
      this.linkPrice.TabIndex = 17;
      this.linkPrice.TabStop = true;
      this.linkPrice.Text = "--";
      this.linkPrice.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkPrice_LinkClicked);
      this.linkSoil.AutoEllipsis = true;
      this.linkSoil.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkSoil.Location = new Point(190, 138);
      this.linkSoil.Name = "linkSoil";
      this.linkSoil.Size = new Size(150, 16);
      this.linkSoil.TabIndex = 9;
      this.linkSoil.TabStop = true;
      this.linkSoil.Text = "--";
      this.linkSoil.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkSoil_LinkClicked);
      this.label31.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label31.ForeColor = Color.DimGray;
      this.label31.Location = new Point(63, 245);
      this.label31.Name = "label31";
      this.label31.Size = new Size(121, 26);
      this.label31.TabIndex = 16;
      this.label31.Text = "Crop Price";
      this.label31.TextAlign = ContentAlignment.TopRight;
      this.label28.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label28.ForeColor = Color.DimGray;
      this.label28.Location = new Point(6, 164);
      this.label28.Name = "label28";
      this.label28.Size = new Size(178, 26);
      this.label28.TabIndex = 10;
      this.label28.Text = "Irrigation Efficiency";
      this.label28.TextAlign = ContentAlignment.TopRight;
      this.linkIrrigation.AutoSize = true;
      this.linkIrrigation.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkIrrigation.Location = new Point(190, 215);
      this.linkIrrigation.Name = "linkIrrigation";
      this.linkIrrigation.Size = new Size(18, 16);
      this.linkIrrigation.TabIndex = 15;
      this.linkIrrigation.TabStop = true;
      this.linkIrrigation.Text = "--";
      this.linkIrrigation.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkIrrigation_LinkClicked);
      this.linkEff.AutoSize = true;
      this.linkEff.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkEff.Location = new Point(190, 164);
      this.linkEff.Name = "linkEff";
      this.linkEff.Size = new Size(18, 16);
      this.linkEff.TabIndex = 11;
      this.linkEff.TabStop = true;
      this.linkEff.Text = "--";
      this.linkEff.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkEff_LinkClicked);
      this.label30.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label30.ForeColor = Color.DimGray;
      this.label30.Location = new Point(17, 215);
      this.label30.Name = "label30";
      this.label30.Size = new Size(167, 30);
      this.label30.TabIndex = 14;
      this.label30.Text = "Total Irrigation";
      this.label30.TextAlign = ContentAlignment.TopRight;
      this.label29.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label29.ForeColor = Color.DimGray;
      this.label29.Location = new Point(63, 190);
      this.label29.Name = "label29";
      this.label29.Size = new Size(121, 25);
      this.label29.TabIndex = 12;
      this.label29.Text = "Crop type";
      this.label29.TextAlign = ContentAlignment.TopRight;
      this.linkCrop.AutoSize = true;
      this.linkCrop.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkCrop.Location = new Point(190, 190);
      this.linkCrop.Name = "linkCrop";
      this.linkCrop.Size = new Size(18, 16);
      this.linkCrop.TabIndex = 13;
      this.linkCrop.TabStop = true;
      this.linkCrop.Text = "--";
      this.linkCrop.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCrop_LinkClicked);
      this.ilTabs.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ilTabs.ImageStream");
      this.ilTabs.TransparentColor = Color.Transparent;
      this.ilTabs.Images.SetKeyName(0, "globe.png");
      this.ilTabs.Images.SetKeyName(1, "soil.png");
      this.ilTabs.Images.SetKeyName(2, "crops.png");
      this.ilTabs.Images.SetKeyName(3, "rotation.png");
      this.ilTabs.Images.SetKeyName(4, "gears 28.png");
      this.ilTabs.Images.SetKeyName(5, "runoff.png");
      this.ilTabs.Images.SetKeyName(6, "review.png");
      this.tcOverall.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tcOverall.Controls.Add((Control) this.tpGeneral);
      this.tcOverall.Controls.Add((Control) this.tpResults);
      this.tcOverall.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tcOverall.ImageList = this.ilMain;
      this.tcOverall.ItemSize = new Size(120, 24);
      this.tcOverall.Location = new Point(7, 99);
      this.tcOverall.Margin = new Padding(10);
      this.tcOverall.Name = "tcOverall";
      this.tcOverall.Padding = new Point(10, 4);
      this.tcOverall.SelectedIndex = 0;
      this.tcOverall.Size = new Size(889, 443);
      this.tcOverall.TabIndex = 10;
      this.tcOverall.DrawItem += new DrawItemEventHandler(this.tabControl2_DrawItem);
      this.tpGeneral.BackColor = Color.FromArgb(224, 224, 224);
      this.tpGeneral.Controls.Add((Control) this.tabControl1);
      this.tpGeneral.ImageIndex = 1;
      this.tpGeneral.Location = new Point(4, 28);
      this.tpGeneral.Margin = new Padding(5);
      this.tpGeneral.Name = "tpGeneral";
      this.tpGeneral.Padding = new Padding(20, 5, 5, 5);
      this.tpGeneral.Size = new Size(881, 411);
      this.tpGeneral.TabIndex = 0;
      this.tpGeneral.Text = "General Input";
      this.tpGeneral.UseVisualStyleBackColor = true;
      this.tpResults.BackColor = Color.White;
      this.tpResults.Controls.Add((Control) this.tcResults);
      this.tpResults.ImageIndex = 0;
      this.tpResults.Location = new Point(4, 28);
      this.tpResults.Name = "tpResults";
      this.tpResults.Size = new Size(881, 411);
      this.tpResults.TabIndex = 3;
      this.tpResults.Text = "Results";
      this.tpResults.UseVisualStyleBackColor = true;
      this.tcResults.Dock = DockStyle.Fill;
      this.tcResults.ItemSize = new Size(0, 30);
      this.tcResults.Location = new Point(0, 0);
      this.tcResults.Name = "tcResults";
      this.tcResults.SelectedIndex = 0;
      this.tcResults.Size = new Size(881, 411);
      this.tcResults.TabIndex = 0;
      this.ilMain.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ilMain.ImageStream");
      this.ilMain.TransparentColor = Color.Transparent;
      this.ilMain.Images.SetKeyName(0, "results.png");
      this.ilMain.Images.SetKeyName(1, "input.png");
      this.menuStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.fileToolStripMenuItem,
        (ToolStripItem) this.optionsToolStripMenuItem,
        (ToolStripItem) this.aboutToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(909, 24);
      this.menuStrip1.TabIndex = 11;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.saveToolStripMenuItem,
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new Size(103, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new EventHandler(this.saveToolStripMenuItem_Click);
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new Size(103, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(103, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.unitsToolStripMenuItem,
        (ToolStripItem) this.resetAllToolStripMenuItem
      });
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new Size(61, 20);
      this.optionsToolStripMenuItem.Text = "Options";
      this.unitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.englishToolStripMenuItem,
        (ToolStripItem) this.metricToolStripMenuItem
      });
      this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
      this.unitsToolStripMenuItem.Size = new Size(119, 22);
      this.unitsToolStripMenuItem.Text = "Units";
      this.englishToolStripMenuItem.Checked = true;
      this.englishToolStripMenuItem.CheckState = CheckState.Checked;
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new Size(112, 22);
      this.englishToolStripMenuItem.Text = "English";
      this.englishToolStripMenuItem.Click += new EventHandler(this.englishToolStripMenuItem_Click);
      this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
      this.metricToolStripMenuItem.Size = new Size(112, 22);
      this.metricToolStripMenuItem.Text = "Metric";
      this.metricToolStripMenuItem.Click += new EventHandler(this.metricToolStripMenuItem_Click);
      this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
      this.resetAllToolStripMenuItem.Size = new Size(119, 22);
      this.resetAllToolStripMenuItem.Text = "Reset All";
      this.resetAllToolStripMenuItem.Click += new EventHandler(this.resetAllToolStripMenuItem_Click);
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(44, 20);
      this.aboutToolStripMenuItem.Text = "Help";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click_1);
      this.saveFile.DefaultExt = "cyp";
      this.saveFile.Title = "Save you CYP File";
      this.openFile.FileName = "Open a CYP File";
      this.openFile.Filter = "\"CYP Files|*.cyp|All Files|*.*\"";
      this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.FromArgb(64, 64, 64);
      this.label3.Location = new Point(826, 64);
      this.label3.Name = "label3";
      this.label3.Size = new Size(71, 13);
      this.label3.TabIndex = 17;
      this.label3.Text = "version 1.5.3";
      this.label3.TextAlign = ContentAlignment.TopRight;
      this.hp.HelpNamespace = "CYP.chm";
      this.cmdRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdRun.BackgroundImage = (Image) Resources.RunIcon;
      this.cmdRun.BackgroundImageLayout = ImageLayout.None;
      this.cmdRun.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdRun.Location = new Point(660, 546);
      this.cmdRun.Name = "cmdRun";
      this.cmdRun.Size = new Size(236, 40);
      this.cmdRun.TabIndex = 8;
      this.cmdRun.Text = "Run Simulation";
      this.cmdRun.UseVisualStyleBackColor = true;
      this.cmdRun.Click += new EventHandler(this.button5_Click);
      this.pictureBox4.Image = (Image) Resources.cyplogo3;
      this.pictureBox4.Location = new Point(9, 27);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(287, 50);
      this.pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox4.TabIndex = 16;
      this.pictureBox4.TabStop = false;
      this.pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.pictureBox3.BackColor = Color.FromArgb((int) byte.MaxValue, 109, 6);
      this.pictureBox3.Location = new Point(0, 80);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(909, 6);
      this.pictureBox3.TabIndex = 13;
      this.pictureBox3.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.ClientSize = new Size(909, 594);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.cmdRun);
      this.Controls.Add((Control) this.pictureBox4);
      this.Controls.Add((Control) this.tcOverall);
      this.Controls.Add((Control) this.pictureBox3);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (frmMain);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Crop Yield Predictor";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
      this.dataSet1.EndInit();
      this.dataTable1.EndInit();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tpLocation.ResumeLayout(false);
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.gbProbability.ResumeLayout(false);
      this.gbProbability.PerformLayout();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.tpSoil.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.grpSoilAdvanced.ResumeLayout(false);
      this.grpSoilAdvanced.PerformLayout();
      this.tpEfficiency.ResumeLayout(false);
      this.groupBox11.ResumeLayout(false);
      this.groupBox11.PerformLayout();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.tpCrop.ResumeLayout(false);
      this.tpRunoff.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgEmergence).EndInit();
      this.groupBox6.ResumeLayout(false);
      ((ISupportInitialize) this.dgASW).EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.pnlASWSpecific.ResumeLayout(false);
      this.pnlASWSpecific.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.trackBarResidue.EndInit();
      ((ISupportInitialize) this.dgRunoff).EndInit();
      this.tpReview.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.tcOverall.ResumeLayout(false);
      this.tpGeneral.ResumeLayout(false);
      this.tpResults.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public frmMain()
    {
      this._assembly = Assembly.GetExecutingAssembly();
      this.InitializeComponent();
      this.tempName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CYPTemp";
      if (this.LoadDefaults())
      {
        if (File.Exists(this.tempName))
          this.OpenFromFile(this.tempName);
        else
          this.LoadCWYModel(this.mainCWY);
      }
      IntPtr handle = this.tcResults.Handle;
      this.mainCWY.MajorValueChanged += new MajorValueUpdateHandler(this.RebuildHashtables);
      this.ActiveTab = this.tpLocation;
    }

    public event SaveOutputToExcelHander SaveOutputToExcel;

    protected virtual void OnSaveOutputToExcel()
    {
    }

    public void updateText()
    {
      this.Text += "dd";
    }

    private CropInput GetCropInput(int index)
    {
      if (this.tcCrops.TabPages.Count <= index - 1)
        this.AddCropInput(index);
      IEnumerator enumerator = this.tcCrops.TabPages[index].Controls.GetEnumerator();
      while (enumerator.MoveNext())
      {
        if (((Control) enumerator.Current).Name == "cropInput" + (object) (index + 1))
          return (CropInput) enumerator.Current;
      }
      return (CropInput) null;
    }

    private void LoadCWYModel(CWYModel c)
    {
      this.mcStart.MinDate = new DateTime(DateTime.Now.Year, 1, 2);
      c.cCrops.GetEnumerator();
      int index1 = 0;
      ArrayList arrayList = new ArrayList();
      for (int index2 = 0; index2 < c.cCrops.Count; ++index2)
      {
        Crop cCrop = c.cCrops[index2];
        CropInput cropInput = this.GetCropInput(index1);
        ArrayList dataSource = (ArrayList) cropInput.lstCrops.DataSource;
        for (int index3 = 0; index3 < dataSource.Count; ++index3)
        {
          if (((Crop) dataSource[index3]).CropName == cCrop.CropName)
          {
            cropInput.model = c;
            cropInput.lstCrops.Enabled = false;
            cropInput.lstCrops.DataSource = (object) null;
            dataSource[index3] = (object) cCrop;
            cropInput.lstCrops.DataSource = (object) dataSource;
            cropInput.lstCrops.DisplayMember = "CropName";
            cropInput.lstCrops.SelectedIndex = index3;
            cropInput.lstCrops.Enabled = true;
            cropInput.DisplayDates(cCrop.arrCoefficients);
            cropInput.CropAction();
          }
        }
        ++index1;
      }
      ArrayList dataSource1 = (ArrayList) this.lstLocations.DataSource;
      for (int index2 = 0; index2 < dataSource1.Count; ++index2)
      {
        if (((LocationData) dataSource1[index2]).LocationName == c.cLocation.LocationName)
        {
          this.lstLocations.Enabled = false;
          this.lstLocations.DataSource = (object) null;
          dataSource1[index2] = (object) c.cLocation;
          this.lstLocations.DataSource = (object) dataSource1;
          this.lstLocations.DisplayMember = "LocationName";
          this.lstLocations.SelectedIndex = index2;
          this.ListActions("location");
          this.lstLocations.Enabled = true;
        }
      }
      ArrayList dataSource2 = (ArrayList) this.lstSoils.DataSource;
      for (int index2 = 0; index2 < dataSource2.Count; ++index2)
      {
        if (((Soil) dataSource2[index2]).SoilName == c.cSoil.SoilName)
        {
          this.lstSoils.Enabled = false;
          this.lstSoils.DataSource = (object) null;
          dataSource2[index2] = (object) c.cSoil;
          this.lstSoils.DataSource = (object) dataSource2;
          this.lstSoils.DisplayMember = "SoilName";
          this.lstSoils.SelectedIndex = index2;
          this.ListActions("soil");
          this.lstSoils.Enabled = true;
        }
      }
      if (c.Units == "metric")
      {
        this.metricToolStripMenuItem.Checked = true;
        this.metricToolStripMenuItem_Click((object) this, new EventArgs());
        this.englishToolStripMenuItem.Checked = false;
      }
      else
      {
        this.englishToolStripMenuItem.Checked = true;
        this.englishToolStripMenuItem_Click((object) this, new EventArgs());
        this.metricToolStripMenuItem.Checked = false;
      }
      this.LoadRunoffGrid();
      this.LoadEmergenceGrid();
      this.RefreshBound();
    }

    public void SerializeNow()
    {
      Stream serializationStream = (Stream) File.Open("c:\\serialized.txt", FileMode.Create);
      new BinaryFormatter().Serialize(serializationStream, (object) this.junk);
      serializationStream.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.SerializeNow();
    }

    private void RunSimulation()
    {
      if (this.mainCWY.Ready() != "true")
      {
        int num = (int) MessageBox.Show("Check all of your inputs before running the simulation!");
      }
      else
      {
        if (!this.mainCWY.CustomEmergence)
          this.RebuildHashtables(2);
        if (!this.mainCWY.CustomRunoff)
          this.RebuildHashtables(1);
        bool flag = false;
        if (this.tcResults.TabPages.Count > 0)
        {
          if (MessageBox.Show("Keep previous results for comparison?", "Compare results", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            flag = true;
          else
            this.resultcount = 0;
        }
        if (this.tcResults.TabPages.Count > 7 && flag)
        {
          if (MessageBox.Show("Only 8 results can be retained for comparison.  The oldest result will be dropped.  Continue?", "Maximum results reached", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            return;
          this.tcResults.TabPages.RemoveAt(this.tcResults.TabPages.Count - 1);
        }
        TabControl tabControl = this.ModelResultsTabControl(this.mainCWY, flag ? this.tcResults.TabCount + 1 : 1);
        tabControl.Click += new EventHandler(this.ResultsTC_TabIndexChanged);
        if (!flag)
        {
          this.tcResults.TabPages.Clear();
          this.mainCWY.PreviousResults.Clear();
        }
        else
        {
          ((CropResults) tabControl.TabPages[0].Controls[0]).dgStandardResults.DataSource = (object) null;
          int count = this.tcResults.TabPages.Count;
          for (int index1 = 0; index1 < this.tcResults.TabPages.Count; ++index1)
          {
            ((CropResults) tabControl.TabPages[0].Controls[0]).dgStandardResults.Columns[1].HeaderText = "Results #" + (object) (this.tcResults.TabPages.Count + 1);
            CropResults control1 = (CropResults) this.tcResults.TabPages[index1].Controls[0].Controls[0].Controls[0];
            ((CropResults) tabControl.TabPages[0].Controls[0]).dgStandardResults.Columns.Add("results" + count.ToString(), "Results #" + Convert.ToString(count));
            for (int index2 = 0; index2 < ((CropResults) tabControl.TabPages[0].Controls[0]).dgStandardResults.Rows.Count; ++index2)
            {
              object obj1 = ((CropResults) tabControl.TabPages[0].Controls[0]).dgStandardResults.Rows[index2].Cells[1].Value;
              object obj2 = control1.dgStandardResults.Rows[index2].Cells[1].Value;
              ((CropResults) tabControl.TabPages[0].Controls[0]).dgStandardResults.Rows[index2].Cells[2 + index1].Value = obj2;
            }
            ((CropResults) tabControl.TabPages[0].Controls[0]).dgCosts.Columns[1].HeaderText = "Results #" + (object) (this.tcResults.TabPages.Count + 1);
            CropResults control2 = (CropResults) this.tcResults.TabPages[index1].Controls[0].Controls[0].Controls[0];
            ((CropResults) tabControl.TabPages[0].Controls[0]).dgCosts.Columns.Add("results" + count.ToString(), "Results #" + Convert.ToString(count));
            for (int index2 = 0; index2 < ((CropResults) tabControl.TabPages[0].Controls[0]).dgCosts.Rows.Count; ++index2)
            {
              object obj1 = ((CropResults) tabControl.TabPages[0].Controls[0]).dgCosts.Rows[index2].Cells[1].Value;
              object obj2 = control2.dgCosts.Rows[index2].Cells[1].Value;
              ((CropResults) tabControl.TabPages[0].Controls[0]).dgCosts.Rows[index2].Cells[2 + index1].Value = obj2;
            }
            ((CropResults) tabControl.TabPages[0].Controls[0]).ReFormatGrids();
            --count;
          }
        }
        ++this.resultcount;
        TabPage tabPage = new TabPage("Results #" + this.resultcount.ToString());
        tabPage.Controls.Add((Control) tabControl);
        tabControl.Dock = DockStyle.Fill;
        tabPage.BackColor = Color.White;
        tabPage.Padding = new Padding(15, 0, 0, 0);
        this.tcResults.TabPages.Insert(0, tabPage);
        this.tcOverall.SelectedTab = this.tpResults;
        this.tcResults.SelectedTab = tabPage;
        if (flag)
        {
          CWYModel cwyModel = (CWYModel) this.mainCWY.Clone();
          cwyModel.PreviousResults.Clear();
          this.mainCWY.PreviousResults.Add(cwyModel);
        }
        this.SaveAsFile(this.tempName);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.RunSimulation();
    }

    private void ResultsTC_TabIndexChanged(object sender, EventArgs e)
    {
      this.SelectTabsSeason(sender);
    }

    public void RerunResults()
    {
      this.tcResults.TabPages[0].Controls.Clear();
      TabControl tabControl1 = this.ModelResultsTabControl(this.mainCWY, 0);
      tabControl1.Dock = DockStyle.Fill;
      this.tcResults.TabPages[0].Controls.Add((Control) tabControl1);
      for (int index = 0; index < this.mainCWY.PreviousResults.Count; ++index)
      {
        CWYModel previousResult = this.mainCWY.PreviousResults[index];
        previousResult.forceunits = this.mainCWY.Units;
        TabControl tabControl2 = this.ModelResultsTabControl(previousResult, 0);
        tabControl2.Dock = DockStyle.Fill;
        this.tcResults.TabPages[index + 1].Controls.Clear();
        this.tcResults.TabPages[index + 1].Controls.Add((Control) tabControl2);
      }
    }

    public TabControl ModelResultsTabControl(CWYModel model, int ResultsNumber)
    {
      TabControl tc = new TabControl();
      tc.ItemSize = new Size(1, 1);
      if (model.Run())
      {
        tc = this.AddCropResult(tc, "", -1, ResultsNumber, model);
        if (model.cCrops.Count > 1)
        {
          int order = 1;
          IEnumerator enumerator = (IEnumerator) model.cCrops.GetEnumerator();
          while (enumerator.MoveNext())
          {
            tc = this.AddCropResult(tc, order.ToString() + ". " + ((Crop) enumerator.Current).CropName, order - 1, order, model);
            ++order;
          }
        }
      }
      return tc;
    }

    public void SelectTabsSeason(object sender)
    {
      int selectedIndex = ((TabControl) sender).SelectedIndex;
      foreach (Control tabPage in this.tcResults.TabPages)
      {
        foreach (TabControl control in (ArrangedElementCollection) tabPage.Controls)
          control.SelectedIndex = selectedIndex;
      }
    }

    public void SelectTabs(object sender)
    {
      CropResults cropResults = (CropResults) sender;
      int selectedIndex1 = cropResults.tcResultPages.SelectedIndex;
      int selectedIndex2 = cropResults.tabControl1.SelectedIndex;
      foreach (Control tabPage in this.tcResults.TabPages)
      {
        foreach (Control control1 in (ArrangedElementCollection) tabPage.Controls)
        {
          foreach (Control control2 in (ArrangedElementCollection) control1.Controls)
          {
            foreach (Control control3 in (ArrangedElementCollection) control2.Controls)
            {
              ((CropResults) control3).tcResultPages.SelectedIndex = selectedIndex1;
              ((CropResults) control3).tabControl1.SelectedIndex = selectedIndex2;
            }
          }
        }
      }
    }

    public void RestartWithModel(CWYModel keepModel)
    {
      this.mainCWY = keepModel;
      this.mainCWY.PreviousResults.Clear();
      this.LoadCWYModel(this.mainCWY);
      this.tcOverall.SelectedTab = this.tpGeneral;
      this.tcResults.TabPages.Clear();
      this.RunSimulation();
    }

    public TabControl AddCropResult(TabControl tc, string title, int cropIndex, int order, CWYModel model)
    {
      CropResults cropResults = new CropResults(model, cropIndex, order);
      cropResults.SetRestartText("Start over with #" + order.ToString());
      cropResults.RestartWithResults += new RestartWithResultsHandler(this.RestartWithModel);
      cropResults.TabChanged += new TabChangedHandler(this.SelectTabs);
      TabPage tabPage = new TabPage(title);
      tabPage.Controls.Add((Control) cropResults);
      cropResults.Dock = DockStyle.Fill;
      tc.TabPages.Add(tabPage);
      return tc;
    }

    private void tc_TabIndexChanged(object sender, EventArgs e)
    {
    }

    private void AddComparison()
    {
    }

    private void lstSoils_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!((Control) sender).Enabled)
        return;
      this.ListActions("soil");
    }

    private void ShowAvailableWater()
    {
      double num1 = this.mainCWY.cSoil.dblFieldCapacity - this.mainCWY.cSoil.dblPermanentWilt;
      double num2 = this.mainCWY.cSoil.dblFieldCapacity / 1828.8;
      double num3 = this.mainCWY.cSoil.dblPermanentWilt / 1828.8;
      this.lblAWS.Text = (this.mainCWY.Units == "english" ? num1 / 25.4 / 6.0 : num1 / (1143.0 / 625.0)).ToString("#.0") + (this.mainCWY.Units == "english" ? " inches/ft" : " mm/meter");
      this.lblFC.Text = num2.ToString("0%");
      this.lblPWP.Text = num3.ToString("0%");
    }

    private void ListActions(string listname)
    {
      switch (listname)
      {
        case "soil":
          this.mainCWY.cSoil = (Soil) this.lstSoils.SelectedItem;
          this.ShowAvailableWater();
          break;
        case "location":
          this.mainCWY.cLocation = (LocationData) this.lstLocations.SelectedItem;
          this.ShowProbability();
          break;
      }
    }

    private void ShowProbability()
    {
      try
      {
        string lower = this.mainCWY.cLocation.LocationName.ToLower();
        double[] numArray = new double[4];
        switch (lower)
        {
          case "burlington, co":
            numArray[0] = 13.0;
            numArray[1] = 15.0;
            numArray[2] = 20.0;
            numArray[3] = 16.0;
            break;
          case "colby, ks":
            numArray[0] = 15.0;
            numArray[1] = 19.0;
            numArray[2] = 24.0;
            numArray[3] = 18.0;
            break;
          case "phillipsburg, ks":
            numArray[0] = 18.0;
            numArray[1] = 23.0;
            numArray[2] = 27.0;
            numArray[3] = 23.0;
            break;
          case "tribune, ks":
            numArray[0] = 12.0;
            numArray[1] = 16.0;
            numArray[2] = 19.0;
            numArray[3] = 17.0;
            break;
          case "garden city, ks":
            numArray[0] = 16.0;
            numArray[1] = 19.0;
            numArray[2] = 22.0;
            numArray[3] = 19.0;
            break;
          case "dodge city, ks":
            numArray[0] = 17.0;
            numArray[1] = 21.0;
            numArray[2] = 25.0;
            numArray[3] = 21.0;
            break;
          case "ulysses, ks":
            numArray[0] = 13.0;
            numArray[1] = 17.0;
            numArray[2] = 22.0;
            numArray[3] = 17.0;
            break;
          case "russell, ks":
            numArray[0] = 20.0;
            numArray[1] = 27.0;
            numArray[2] = 33.0;
            numArray[3] = 26.0;
            break;
          default:
            numArray[0] = 15.0;
            numArray[1] = 18.0;
            numArray[2] = 22.0;
            break;
        }
        string str = " in.";
        if (this.mainCWY.Units == "metric")
        {
          numArray[0] = Math.Round(numArray[0] * 25.4);
          numArray[1] = Math.Round(numArray[1] * 25.4);
          numArray[2] = Math.Round(numArray[2] * 25.4);
          numArray[3] = Math.Round(numArray[3] * 25.4);
          str = " mm.";
        }
        this.txtAnnualPrecip.Text = numArray[1].ToString();
        this.gbProbability.Text = this.mainCWY.cLocation.LocationName + " Rainfall Probability";
        this.btn80.Text = numArray[0].ToString() + str;
        this.btn50.Text = numArray[1].ToString() + str;
        this.btn20.Text = numArray[2].ToString() + str;
        this.btnMean.Text = numArray[3].ToString() + str;
      }
      catch
      {
      }
    }

    private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!((Control) sender).Enabled)
        return;
      this.ListActions("location");
    }

    private bool LoadDefaults()
    {
      this.AddCrop();
      this.AddCropInput(0);
      bool flag = true;
      flag = this.LoadSoils();
      return this.LoadDefaultLocations();
    }

    private bool LoadSoils()
    {
      this.lstSoils.Enabled = false;
      this.lstSoils.DataSource = (object) (ArrayList) this.LoadDefaultData("Resources.soils", "soils");
      this.lstSoils.DisplayMember = "SoilName";
      this.lstSoils.SelectedIndex = -1;
      this.lstSoils.Enabled = true;
      return true;
    }

    private void GetInputCosts(Crop crop, string cropname)
    {
      Crop crop1 = (Crop) this.LoadDefaultData("Resources.inputs." + cropname, "inputs");
      if (crop1 == null)
        return;
      crop.cGeneralCosts = crop1.cGeneralCosts;
      crop.cOperationCosts = crop1.cOperationCosts;
      crop.cReturns = crop1.cReturns;
      crop.cIrrigationCosts = crop1.cIrrigationCosts;
      crop.cMiscCosts = crop1.cMiscCosts;
    }

    private bool LoadDefaultCrops(CropInput tempCropInput)
    {
      ArrayList arrayList = new ArrayList();
      Crop crop1 = (Crop) this.LoadDefaultData("Resources.crops.alfalfa", "crop");
      crop1.CropName = "Alfalfa";
      this.GetInputCosts(crop1, "alfalfa");
      crop1.yieldA = 0.0;
      crop1.yieldB = 0.0;
      arrayList.Add((object) crop1);
      Crop crop2 = (Crop) this.LoadDefaultData("Resources.crops.corn", "crop");
      crop2.CropName = "Corn";
      this.GetInputCosts(crop2, "corn");
      crop2.yieldA = 16.84;
      crop2.yieldB = -184.0;
      arrayList.Add((object) crop2);
      Crop crop3 = (Crop) this.LoadDefaultData("Resources.crops.sorghum", "crop");
      crop3.CropName = "Grain Sorghum";
      this.GetInputCosts(crop3, "sorghum");
      crop3.yieldA = 12.2;
      crop3.yieldB = -84.7;
      arrayList.Add((object) crop3);
      Crop crop4 = (Crop) this.LoadDefaultData("Resources.crops.sunflower", "crop");
      crop4.CropName = "Sunflower";
      this.GetInputCosts(crop4, "sunflower");
      crop4.yieldA = 218.4;
      crop4.yieldB = -1189.0;
      arrayList.Add((object) crop4);
      Crop crop5 = (Crop) this.LoadDefaultData("Resources.crops.soybean", "crop");
      crop5.CropName = "Soybean";
      this.GetInputCosts(crop5, "soybean");
      crop5.yieldA = 4.5735;
      crop5.yieldB = -35.686;
      arrayList.Add((object) crop5);
      Crop crop6 = (Crop) this.LoadDefaultData("Resources.crops.wheat", "crop");
      crop6.CropName = "Winter Wheat";
      this.GetInputCosts(crop6, "wheat");
      crop6.yieldA = 6.02;
      crop6.yieldB = -60.4;
      arrayList.Add((object) crop6);
      tempCropInput.lstCrops.Enabled = false;
      tempCropInput.lstCrops.DataSource = (object) arrayList;
      tempCropInput.lstCrops.DisplayMember = "CropName";
      tempCropInput.lstCrops.SelectedIndex = -1;
      tempCropInput.lstCrops.Enabled = true;
      return true;
    }

    private object LoadDefaultData(string filename, string classType)
    {
      object obj = (object) null;
      try
      {
        StreamReader streamReader = new StreamReader(this._assembly.GetManifestResourceStream("KSWB." + filename + ".csv"));
        string str1 = "";
        switch (classType)
        {
          case "location":
            streamReader.ReadLine();
            LocationData locationData = new LocationData();
            while (streamReader.Peek() > 0)
            {
              string[] strArray = streamReader.ReadLine().Split(',');
              if (strArray.Length > 0)
              {
                string str2 = Convert.ToDateTime(strArray[0]).ToString("MM/dd");
                locationData.htMaxTemp.Add((object) str2, (object) Convert.ToDouble(strArray[1]));
                locationData.htMinTemp.Add((object) str2, (object) Convert.ToDouble(strArray[2]));
                locationData.htPrecipitation.Add((object) str2, (object) Convert.ToDouble(strArray[3]));
                locationData.htRad.Add((object) str2, (object) Convert.ToDouble(strArray[4]));
              }
            }
            return (object) locationData;
          case "crop":
            Crop crop1 = new Crop();
            double[,] numArray1 = new double[31, 36];
            int index1 = 11;
            double[,] numArray2 = new double[31, 36];
            int index2 = 11;
            while (streamReader.Peek() > 0)
            {
              string[] strArray = streamReader.ReadLine().Split(',');
              if (strArray[0].IndexOf("[") > -1)
              {
                str1 = strArray[0];
                strArray = streamReader.ReadLine().Split(',');
              }
              if (strArray.Length > 0)
              {
                switch (str1)
                {
                  case "[dates]":
                    IEnumerator enumerator1 = strArray.GetEnumerator();
                    int index3 = 0;
                    Measurement measurement1 = new Measurement();
                    Measurement measurement2 = new Measurement();
                    while (enumerator1.MoveNext())
                    {
                      if (strArray[index3] != "")
                      {
                        switch (index3)
                        {
                          case 0:
                            string str2 = Convert.ToDateTime(strArray[0]).ToString("MM/dd");
                            measurement1.Date = str2;
                            break;
                          case 1:
                            measurement1.Label = strArray[1];
                            break;
                        }
                      }
                      ++index3;
                    }
                    crop1.arrWF.Add(measurement2);
                    crop1.arrCoefficients.Add(measurement1);
                    continue;
                  case "[iswa]":
                    IEnumerator enumerator2 = strArray.GetEnumerator();
                    int index4 = strArray.Length - 1;
                    while (enumerator2.MoveNext())
                    {
                      numArray1[index4, index1] = Convert.ToDouble(enumerator2.Current);
                      --index4;
                    }
                    ++index1;
                    continue;
                  case "[iswa-loamy-sand]":
                    IEnumerator enumerator3 = strArray.GetEnumerator();
                    int index5 = strArray.Length - 1;
                    while (enumerator3.MoveNext())
                    {
                      numArray2[index5, index2] = Convert.ToDouble(enumerator3.Current);
                      --index5;
                    }
                    ++index2;
                    continue;
                  default:
                    continue;
                }
              }
            }
            crop1.iswa = numArray1;
            crop1.iswa_loamy_sand = numArray2;
            return (object) crop1;
          case "soils":
            ArrayList arrayList = new ArrayList();
            streamReader.ReadLine();
            while (streamReader.Peek() > 0)
            {
              Soil soil = new Soil();
              string[] strArray = streamReader.ReadLine().Split(',');
              if (strArray.Length > 0)
              {
                soil.SoilName = strArray[0];
                soil.dblFieldCapacity = Convert.ToDouble(strArray[1]);
                soil.dblPermanentWilt = Convert.ToDouble(strArray[2]);
                soil.dblMaximumWater = Convert.ToDouble(strArray[3]);
                soil.dblAFactor = Convert.ToDouble(strArray[4]);
                soil.dblBFactor = Convert.ToDouble(strArray[5]);
                soil.dblCFactor = Convert.ToDouble(strArray[6]);
                arrayList.Add((object) soil);
              }
            }
            return (object) arrayList;
          case "inputs":
            streamReader.ReadLine();
            Crop crop2 = new Crop();
            BindingList<InputCost> bindingList = new BindingList<InputCost>();
            string str3 = "";
            while (streamReader.Peek() > 0)
            {
              string[] strArray = streamReader.ReadLine().Split(',');
              if (strArray.Length == 1)
              {
                str3 = strArray[0];
              }
              else
              {
                InputCost inputCost = new InputCost(strArray[0], strArray[1], strArray[2], strArray[3], strArray[4], strArray[5]);
                switch (str3)
                {
                  case "__General":
                    crop2.cGeneralCosts.Add(inputCost);
                    continue;
                  case "__Operation":
                    crop2.cOperationCosts.Add(inputCost);
                    continue;
                  case "__Returns":
                    crop2.cReturns.Add(inputCost);
                    continue;
                  case "__Irrigation":
                    crop2.cIrrigationCosts.Add(inputCost);
                    continue;
                  case "__Costs":
                    crop2.cMiscCosts.Add(inputCost);
                    continue;
                  default:
                    continue;
                }
              }
            }
            return (object) crop2;
          default:
            return obj;
        }
      }
      catch
      {
        return (object) null;
      }
    }

    private bool LoadDefaultLocations()
    {
      this.lstLocations.Enabled = false;
      ArrayList arrayList = new ArrayList();
      LocationData locationData1 = (LocationData) this.LoadDefaultData("Resources.locations.burlington", "location");
      locationData1.LocationName = "Burlington, CO";
      arrayList.Add((object) locationData1);
      LocationData locationData2 = (LocationData) this.LoadDefaultData("Resources.locations.colby", "location");
      locationData2.LocationName = "Colby, KS";
      arrayList.Add((object) locationData2);
      LocationData locationData3 = (LocationData) this.LoadDefaultData("Resources.locations.dodgecity", "location");
      locationData3.LocationName = "Dodge City, KS";
      arrayList.Add((object) locationData3);
      LocationData locationData4 = (LocationData) this.LoadDefaultData("Resources.locations.gardencity", "location");
      locationData4.LocationName = "Garden City, KS";
      arrayList.Add((object) locationData4);
      LocationData locationData5 = (LocationData) this.LoadDefaultData("Resources.locations.tribune", "location");
      locationData5.LocationName = "Tribune, KS";
      arrayList.Add((object) locationData5);
      LocationData locationData6 = (LocationData) this.LoadDefaultData("Resources.locations.ulysses", "location");
      locationData6.LocationName = "Ulysses, KS";
      arrayList.Add((object) locationData6);
      this.lstLocations.DataSource = (object) arrayList;
      this.lstLocations.DisplayMember = "LocationName";
      this.lstLocations.SelectedIndex = -1;
      this.lstLocations.Enabled = true;
      return true;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.saveFile.ShowDialog() != DialogResult.OK)
        return;
      this.SaveAsFile(this.saveFile.FileName);
    }

    private void SaveAsFile(string filename)
    {
      Stream serializationStream = (Stream) File.Open(filename, FileMode.Create);
      new BinaryFormatter().Serialize(serializationStream, (object) this.mainCWY);
      serializationStream.Close();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.openFile.ShowDialog() != DialogResult.OK)
        return;
      this.OpenFromFile(this.openFile.FileName);
    }

    private void OpenFromFile(string filename)
    {
      Stream serializationStream = (Stream) File.Open(filename, FileMode.Open);
      this.mainCWY = (CWYModel) new BinaryFormatter().Deserialize(serializationStream);
      serializationStream.Close();
      this.LoadCWYModel(this.mainCWY);
    }

    private void txtInitialWater_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtAnnualPrecip_TextChanged(object sender, EventArgs e)
    {
    }

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dgCMY_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    public void AddCrop()
    {
      this.mainCWY.cCrops.Add(new Crop());
    }

    public void AddCropInput(int cropindex)
    {
      int theIndex = cropindex;
      TabPage tabPage = new TabPage();
      tabPage.Name = "tpCrop" + (object) (theIndex + 1);
      tabPage.Padding = new Padding(0);
      tabPage.Margin = new Padding(0);
      tabPage.Text = "";
      tabPage.Font = new Font(tabPage.Font.FontFamily, 1f);
      CropInput tempCropInput = new CropInput(this.mainCWY, theIndex);
      tempCropInput.Name = "cropInput" + (object) (theIndex + 1);
      tabPage.Controls.Add((Control) tempCropInput);
      tempCropInput.Dock = DockStyle.Fill;
      this.tcCrops.Controls.Add((Control) tabPage);
      this.tcCrops.SelectedIndex = this.tcCrops.TabPages.Count - 1;
      this.LoadDefaultCrops(tempCropInput);
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.AddCrop();
      this.AddCropInput(this.mainCWY.cCrops.Count - 1);
    }

    private void FadeBG(Control control, Color top, Color bottom)
    {
      Control control1 = control;
      LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, control1.Height), top, bottom);
      Bitmap bitmap = new Bitmap(control1.Width, control1.Height);
      Graphics.FromImage((Image) bitmap).FillRectangle((Brush) linearGradientBrush, new Rectangle(0, 0, control1.Width, control1.Height));
      control1.BackgroundImage = (Image) bitmap;
      control1.BackgroundImageLayout = ImageLayout.Stretch;
    }

    private void button7_Click(object sender, EventArgs e)
    {
    }

    private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
    {
      TabControl tabControl = (TabControl) sender;
      float num = 0.0f;
      for (int index = 0; index < tabControl.TabPages.Count; ++index)
        num += (float) tabControl.GetTabRect(index).Width;
      tabControl.CreateGraphics();
      ++this.tabCount;
      Color controlText = SystemColors.ControlText;
      string text = tabControl.TabPages[e.Index].Text;
      if (text.IndexOf("*") <= 0)
        return;
      Color red = Color.Red;
      text.TrimEnd('*');
    }

    public static void DrawTabText(TabControl tabControl, DrawItemEventArgs e, string caption)
    {
      Color control = SystemColors.Control;
      Color controlText = SystemColors.ControlText;
      frmMain.DrawTabText(tabControl, e, control, controlText, caption);
    }

    public static void DrawTabText(TabControl tabControl, DrawItemEventArgs e, Color foreColor, string caption)
    {
      Color control = SystemColors.Control;
      frmMain.DrawTabText(tabControl, e, control, foreColor, caption);
    }

    public static void DrawTabText(TabControl tabControl, DrawItemEventArgs e, Color backColor, Color foreColor, string caption)
    {
      backColor = Color.Wheat;
      Brush brush1 = (Brush) new SolidBrush(foreColor);
      Rectangle rect = e.Bounds;
      Brush brush2 = (Brush) new SolidBrush(Color.Red);
      string text = tabControl.TabPages[e.Index].Text;
      StringFormat format = new StringFormat();
      format.Alignment = StringAlignment.Center;
      e.Graphics.FillRectangle(brush2, rect);
      rect = new Rectangle(rect.X, rect.Y + 3, rect.Width, rect.Height - 3);
      Font font = e.Index != tabControl.SelectedIndex ? e.Font : new Font(new Font(e.Font, FontStyle.Italic), FontStyle.Bold);
      e.Graphics.DrawString(caption, font, brush1, (RectangleF) rect, format);
      format.Dispose();
      if (e.Index == tabControl.SelectedIndex)
      {
        font.Dispose();
        brush2.Dispose();
      }
      else
      {
        brush2.Dispose();
        brush1.Dispose();
      }
    }

    private void tabControl2x_DrawItem(object sender, DrawItemEventArgs e)
    {
      TabControl tabControl = (TabControl) sender;
      Font font1;
      Brush brush1;
      Brush brush2;
      if (e.Index == tabControl.SelectedIndex)
      {
        Font font2 = new Font(e.Font, FontStyle.Bold);
        font1 = new Font(e.Font, FontStyle.Bold);
        brush1 = (Brush) new SolidBrush(Color.DarkGray);
        brush2 = Brushes.White;
      }
      else
      {
        font1 = e.Font;
        brush1 = (Brush) new SolidBrush(e.BackColor);
        brush2 = (Brush) new SolidBrush(e.ForeColor);
      }
      string text = tabControl.TabPages[e.Index].Text;
      StringFormat format = new StringFormat();
      format.Alignment = StringAlignment.Center;
      e.Graphics.FillRectangle(brush1, e.Bounds);
      Rectangle rectangle = e.Bounds;
      rectangle = new Rectangle(rectangle.X, rectangle.Y + 3, rectangle.Width, rectangle.Height - 3);
      e.Graphics.DrawString(text, font1, brush2, (RectangleF) rectangle, format);
      format.Dispose();
      if (e.Index == tabControl.SelectedIndex)
      {
        font1.Dispose();
        brush1.Dispose();
      }
      else
      {
        brush1.Dispose();
        brush2.Dispose();
      }
    }

    private void RemoveCrop(int index)
    {
      try
      {
        this.tcCrops.TabPages.RemoveAt(index);
        this.mainCWY.cCrops.RemoveAt(index + 1);
        for (int index1 = index; index1 < this.tcCrops.TabPages.Count; ++index1)
        {
          this.tcCrops.TabPages[index1].Text = "Crop #" + (object) (index1 + 2);
          ((CropInput) this.tcCrops.TabPages[index1].Controls[0]).index = index1 + 1;
        }
      }
      catch
      {
      }
    }

    private void cmdDeleteCrop_Click(object sender, EventArgs e)
    {
      if (this.tcCrops.SelectedIndex == 0)
      {
        int num = (int) MessageBox.Show("You must have at least 1 crop in the rotation");
      }
      else
      {
        if (MessageBox.Show("Are you sure you want to delete Crop #" + (object) (this.tcCrops.SelectedIndex + 1) + "?", "Delete Crop?", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
          return;
        this.RemoveCrop(this.tcCrops.SelectedIndex);
      }
    }

    public void FormatGrid(DataGridView dg)
    {
      foreach (DataGridViewColumn column in (BaseCollection) dg.Columns)
      {
        DataGridViewCell dataGridViewCell = (DataGridViewCell) new DataGridViewTextBoxCell();
        dataGridViewCell.Style.BackColor = Color.AliceBlue;
        column.CellTemplate = dataGridViewCell;
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      int num = ((Control) sender).Enabled ? 1 : 0;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void cropInput1_Load(object sender, EventArgs e)
    {
    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.mainCWY.Units = "english";
      this.GetCropInput(0).UpdateCropUnits();
      this.englishToolStripMenuItem.Checked = true;
      this.metricToolStripMenuItem.Checked = false;
      this.ShowProbability();
      if (this.tcResults.TabPages.Count > 0)
        this.RerunResults();
      this.RefreshBound();
    }

    private void metricToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.mainCWY.Units = "metric";
      this.GetCropInput(0).UpdateCropUnits();
      this.englishToolStripMenuItem.Checked = false;
      this.metricToolStripMenuItem.Checked = true;
      this.ShowProbability();
      if (this.tcResults.TabPages.Count > 0)
        this.RerunResults();
      this.RefreshBound();
    }

    private void RefreshBound()
    {
      this.txtMeasuredWater.DataBindings.Clear();
      this.txtMeasuredWater.DataBindings.Add("Text", (object) this.mainCWY, "dblMeasuredWater");
      this.mcStart.DataBindings.Clear();
      this.chkMeasured.DataBindings.Clear();
      this.chkMeasured.DataBindings.Add("Checked", (object) this.mainCWY, "measuredDate");
      this.mcStart.DataBindings.Add("Value", (object) this.mainCWY, "SoilDate");
      this.txtAnnualPrecip.DataBindings.Clear();
      this.txtAnnualPrecip.DataBindings.Add("Text", (object) this.mainCWY, "dblAnnualPrecip_display", true, DataSourceUpdateMode.OnPropertyChanged);
      this.lblAnnualPrecip.Text = this.mainCWY.Units == "english" ? "inches" : "millimeters";
      this.txtEfficiency.DataBindings.Clear();
      this.txtEfficiency.DataBindings.Add("Text", (object) this.mainCWY, "dblEfficiency", true, DataSourceUpdateMode.OnPropertyChanged);
      this.trackBarResidue.Value = (int) this.mainCWY.residue;
      this.ShowAvailableWater();
      if (this.mainCWY.ActiveCrop == null)
        return;
      this.linkLocation.Text = this.mainCWY.cLocation.LocationName;
      this.linkPrecipitation.Text = this.mainCWY.dblAnnualPrecip_display.ToString() + " " + (this.mainCWY.Units == "english" ? "inches" : "millimeters");
      this.linkSoil.Text = this.mainCWY.cSoil.SoilName;
      this.linkEff.Text = this.mainCWY.dblEfficiency.ToString() + "%";
      this.linkCrop.Text = this.mainCWY.ActiveCrop != null ? this.mainCWY.ActiveCrop.CropName : "";
      double num = this.mainCWY.ActiveCrop != null ? this.mainCWY.ActiveCrop.GetSumIrrigation() : 0.0;
      this.linkIrrigation.Text = (this.mainCWY.Units == "english" ? (num * (5.0 / (double) sbyte.MaxValue)).ToString("0.0") : num.ToString("0.0")) + " " + (this.mainCWY.Units == "english" ? "inches" : "millimeters");
      this.linkPrice.Text = this.mainCWY.ActiveCrop != null ? "$" + this.mainCWY.ActiveCrop.price.ToString() + "/" + this.mainCWY.ActiveCrop.Units() : "";
      this.linkRunoff.Text = this.mainCWY.mRunoff[0].Amount.ToString("0.0") + "%";
    }

    public void RebuildHashtables(int method)
    {
      switch (method)
      {
        case 1:
          if (this.mainCWY.CustomRunoff)
            return;
          this.mainCWY.mRunoff.Clear();
          break;
        case 2:
          if (this.mainCWY.CustomEmergence)
            return;
          this.mainCWY.mEmergence.Clear();
          break;
        default:
          this.mainCWY.mRunoff.Clear();
          this.mainCWY.mEmergence.Clear();
          break;
      }
      for (int index = 0; index < this.mainCWY.cCrops.Count; ++index)
      {
        if (this.mainCWY.cCrops[index].CropName != null)
          ((CropInput) this.tcCrops.TabPages[index].Controls[0]).SubmitCropHashValues(method);
      }
    }

    public void LoadRunoffGrid()
    {
      this.dgRunoff.Columns.Clear();
      BindingSource bindingSource = new BindingSource();
      bindingSource.DataSource = (object) this.mainCWY.mRunoff;
      this.dgRunoff.AutoGenerateColumns = false;
      DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn1.DataPropertyName = "Date";
      viewTextBoxColumn1.HeaderText = "Crop";
      viewTextBoxColumn1.ReadOnly = true;
      DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn2.DataPropertyName = "Amount";
      viewTextBoxColumn2.HeaderText = "Runoff Coefficient (%)";
      viewTextBoxColumn2.ReadOnly = false;
      this.dgRunoff.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
      this.dgRunoff.Columns.Add((DataGridViewColumn) viewTextBoxColumn2);
      this.dgRunoff.DataSource = (object) bindingSource;
    }

    public void LoadEmergenceGrid()
    {
      this.dgEmergence.Columns.Clear();
      BindingSource bindingSource = new BindingSource();
      bindingSource.DataSource = (object) this.mainCWY.mEmergence;
      this.dgEmergence.AutoGenerateColumns = false;
      DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn1.DataPropertyName = "Date";
      viewTextBoxColumn1.HeaderText = "Crop";
      viewTextBoxColumn1.ReadOnly = true;
      DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn2.DataPropertyName = "Amount";
      viewTextBoxColumn2.HeaderText = "Oct. 1 ASW (%)";
      viewTextBoxColumn2.ReadOnly = false;
      this.dgEmergence.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
      this.dgEmergence.Columns.Add((DataGridViewColumn) viewTextBoxColumn2);
      this.dgEmergence.DataSource = (object) bindingSource;
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void mcStart_ValueChanged(object sender, EventArgs e)
    {
    }

    private void button8_Click(object sender, EventArgs e)
    {
      this.mainCWY.CustomRunoff = false;
      this.RebuildHashtables(1);
    }

    private void button7_Click_1(object sender, EventArgs e)
    {
      this.mainCWY.CustomEmergence = false;
      this.RebuildHashtables(2);
    }

    private void mcStart_ValueChanged_1(object sender, EventArgs e)
    {
      if (this.mcStart.Value.Month == 1 && this.mcStart.Value.Day == 1)
      {
        int num = (int) MessageBox.Show("Sorry, January 1 cannot be used as a measured soil water date.  Please select a later date or use the Calculate soil water entry above for January 1 readings", "Select another date");
      }
      else
      {
        this.mainCWY.measuredDate = this.mcStart.Checked;
        this.mainCWY.SoilDate = this.mcStart.Value;
      }
    }

    private void mcStart_BindingContextChanged(object sender, EventArgs e)
    {
    }

    private void tcOverall_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.tcOverall.SelectedIndex != 1 || this.tcResults.TabPages.Count != 0)
        return;
      this.tcOverall.SelectedIndex = 0;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      this.pnlASWSpecific.Enabled = this.chkMeasured.Checked;
    }

    private void btn80_Click(object sender, EventArgs e)
    {
      Control btn80 = (Control) this.btn80;
      if (!(btn80.Text != "--"))
        return;
      this.txtAnnualPrecip.Text = btn80.Text.Remove(btn80.Text.IndexOf(" "));
    }

    private void btn50_Click(object sender, EventArgs e)
    {
      Control btn50 = (Control) this.btn50;
      if (!(btn50.Text != "--"))
        return;
      this.txtAnnualPrecip.Text = btn50.Text.Remove(btn50.Text.IndexOf(" "));
    }

    private void btn20_Click(object sender, EventArgs e)
    {
      Control btn20 = (Control) this.btn20;
      if (!(btn20.Text != "--"))
        return;
      this.txtAnnualPrecip.Text = btn20.Text.Remove(btn20.Text.IndexOf(" "));
    }

    private void dgRunoff_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      int num = (int) MessageBox.Show("Please enter the data in the proper format - only numeric characters and crop names");
    }

    private void dgEmergence_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      int num = (int) MessageBox.Show("Please enter the data in the proper format - only numeric characters and crop names");
    }

    private void frmMain_ForeColorChanged(object sender, EventArgs e)
    {
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ShowHelp("");
    }

    private void txtAnnualPrecip_TextChanged_1(object sender, EventArgs e)
    {
    }

    private void btnMean_Click(object sender, EventArgs e)
    {
      Control btnMean = (Control) this.btnMean;
      if (!(btnMean.Text != "--"))
        return;
      this.txtAnnualPrecip.Text = btnMean.Text.Remove(btnMean.Text.IndexOf(" "));
    }

    private void ShowHelp(string url)
    {
      if (url == "")
        url = "index.htm";
      Help.ShowHelp((Control) this, this.hp.HelpNamespace, HelpNavigator.Topic, (object) url);
    }

    private void button5_Click_2(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#location");
    }

    private void button9_Click_1(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#soil");
    }

    private void button10_Click(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#irrigation");
    }

    public void DisplayASWDates(BindingList<Measurement> arrDates)
    {
      BindingSource bindingSource = new BindingSource();
      bindingSource.DataSource = (object) arrDates;
      this.dgASW.Columns.Clear();
      this.dgASW.DataSource = (object) bindingSource;
      this.dgASW.Columns[0].DataPropertyName = "Date";
      this.dgASW.Columns[0].HeaderText = "Date";
      this.dgASW.Columns[1].DataPropertyName = "Amount";
      this.dgASW.Columns[1].HeaderText = "ASW%";
      this.dgASW.Columns[2].Visible = false;
      for (int index = 2; index < this.dgASW.Columns.Count; ++index)
        this.dgASW.Columns[index].Visible = false;
    }

    private void dgASW_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      int num = (int) MessageBox.Show("Please enter the data in the proper format - only numeric characters and valid date formats");
      this.dgASW[e.ColumnIndex, e.RowIndex].Value = (object) 50;
    }

    private void button14_Click(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#rainfall");
    }

    private void button13_Click(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#asw");
    }

    private void button12_Click(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#asw");
    }

    private void dgASW_CurrentCellChanged(object sender, EventArgs e)
    {
    }

    private void dgASW_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 1)
      {
        double num1 = Convert.ToDouble(this.dgASW[e.ColumnIndex, e.RowIndex].Value);
        if (num1 > 0.0 && num1 <= 100.0)
          return;
        this.dgASW[1, e.RowIndex].Value = (object) 50;
        int num2 = (int) MessageBox.Show("Value must be between 0 and 100%");
      }
      else
      {
        if (Convert.ToDouble(this.dgASW[1, e.RowIndex].Value) != 0.0)
          return;
        this.dgASW[1, e.RowIndex].Value = (object) 50;
      }
    }

    private void dgEmergence_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      this.mainCWY.CustomEmergence = true;
    }

    private void tabControl1_Selected(object sender, TabControlEventArgs e)
    {
      string str = "";
      if (!this.tabControl1.Enabled)
        return;
      if (this.tabControl1.TabPages.IndexOf(this.ActiveTab) > this.tabControl1.SelectedIndex)
      {
        this.ActiveTab = this.tabControl1.SelectedTab;
      }
      else
      {
        bool flag = true;
        foreach (TabPage tabPage in this.tabControl1.TabPages)
        {
          if (flag)
          {
            this.ActiveTab = tabPage;
            switch (tabPage.Name)
            {
              case "tpLocation":
                if (this.mainCWY.cLocation.LocationName == null)
                  flag = false;
                if (this.mainCWY.dblAnnualPrecip <= 0.0 || this.mainCWY.dblAnnualPrecip > 711.0)
                {
                  str = str + "The annual precipitation must be greater than 0 and less than " + (this.mainCWY.Units == "english" ? "28 inches" : "711 mm");
                  flag = false;
                  continue;
                }
                continue;
              case "tpSoil":
                if (this.mainCWY.cSoil.SoilName == null)
                {
                  flag = false;
                  continue;
                }
                continue;
              case "tpEfficiency":
                if (this.mainCWY.dblEfficiency <= 0.0 || this.mainCWY.dblEfficiency > 100.0)
                {
                  flag = false;
                  str += "The irrigation system efficiency must be between 0 and 100%";
                  continue;
                }
                continue;
              case "tpCrop":
                if (this.mainCWY.cCrops[0].CropName == null)
                  flag = false;
                CropInput cropInput = this.GetCropInput(0);
                if (cropInput.dgCoefficients.Columns.Count > 2)
                {
                  cropInput.dgCoefficients.Columns.RemoveAt(2);
                  continue;
                }
                continue;
              case "tpRunoff":
                this.DisplayASWDates(this.mainCWY.mASW);
                this.RebuildHashtables(1);
                this.RebuildHashtables(2);
                continue;
              case "tpReview":
                this.RefreshBound();
                continue;
              default:
                continue;
            }
          }
        }
        if (!flag && this.tabControl1.TabPages.IndexOf(this.ActiveTab) < this.tabControl1.SelectedIndex)
        {
          this.tabControl1.Enabled = false;
          this.tabControl1.SelectedTab = this.ActiveTab;
          this.tabControl1.Enabled = true;
          int num = (int) MessageBox.Show("Please check all of your " + this.ActiveTab.Text + " inputs before proceeding\n" + str, "Enter all inputs");
        }
        else
        {
          this.ActiveTab = this.tabControl1.SelectedTab;
          switch (this.ActiveTab.Name)
          {
            case "tpRunoff":
              this.LoadRunoffGrid();
              this.LoadEmergenceGrid();
              break;
          }
        }
      }
    }

    private void button11_Click(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#runoff");
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void dgRunoff_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      this.mainCWY.CustomRunoff = true;
    }

    private void button17_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "70";
    }

    private void button15_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "50";
    }

    private void button16_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "60";
    }

    private void button21_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "80";
    }

    private void button20_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "85";
    }

    private void button19_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "88";
    }

    private void button18_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "90";
    }

    private void button22_Click(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "95";
    }

    private void button21_Click_1(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "80";
    }

    private void button22_Click_1(object sender, EventArgs e)
    {
      this.txtEfficiency.Text = "95";
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.linkLabel1.Text = this.grpSoilAdvanced.Visible ? "Hide Advanced" : "Show Advanced";
      this.grpSoilAdvanced.Visible = !this.grpSoilAdvanced.Visible;
    }

    private void button23_Click(object sender, EventArgs e)
    {
    }

    private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      File.Delete(this.tempName);
      Application.Restart();
    }

    private void trackBarResidue_ValueChanged(object sender, EventArgs e)
    {
      this.lblResidueCover.Text = this.trackBarResidue.Value.ToString() + "% Residue Cover";
      this.mainCWY.residue = (double) this.trackBarResidue.Value;
      this.RebuildHashtables(1);
    }

    private void linkLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpLocation;
    }

    private void linkPrecipitation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpLocation;
    }

    private void linkSoil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpSoil;
    }

    private void linkEff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpEfficiency;
    }

    private void linkCrop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpCrop;
    }

    private void linkIrrigation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpCrop;
      ((TabControl) this.tpCrop.Controls[1].Controls[0].Controls[0].Controls[0]).SelectedIndex = 1;
    }

    private void linkPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpCrop;
      ((TabControl) this.tpCrop.Controls[1].Controls[0].Controls[0].Controls[0]).SelectedIndex = 2;
    }

    private void linkCosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpCrop;
      ((TabControl) this.tpCrop.Controls[1].Controls[0].Controls[0].Controls[0]).SelectedIndex = 2;
    }

    private void linkRunoff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.tabControl1.SelectedTab = this.tpRunoff;
    }

    private void tcCrops_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button23_Click_1(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#review");
    }

    private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm");
    }
  }
}
