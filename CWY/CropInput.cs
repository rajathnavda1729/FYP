

using KSWB;
using KSWB.Properties;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CWY
{
  [Serializable]
  public class CropInput : UserControl
  {
    public CWYModel model = new CWYModel();
    public BindingList<Measurement> cIrrigation = new BindingList<Measurement>();
    private IContainer components;
    private TabControl tcCrops;
    private TabPage tpGeneral;
    public GroupBox groupBox3;
    public DataGridView dgCoefficients;
    public Label label5;
    public GroupBox groupBox2;
    public ListBox lstCrops;
    public Label label10;
    private TabPage tpIrrigation;
    private DataGridView dgIrrigation;
    private GroupBox groupBox8;
    private Button button1;
    public Label label1;
    private TabControl tabControl1;
    private TabPage tpIrrigationEntries;
    private TextBox txtMaxYield;
    private Label label13;
    private Label lblMaxYield;
    private ImageList images;
    private TabPage tabPage1;
    private Label label14;
    private Label lblAuto;
    private TextBox txtAuto;
    private Label lblAutoUnits;
    private GroupBox groupBox1;
    private RadioButton rbNetIrrigation;
    private RadioButton rbGPM;
    private Label label12;
    private Button cmdAuto;
    private TextBox txtAcres;
    private DateTimePicker dteIrrigEnd;
    private Label label9;
    private Label label7;
    private TextBox txtInchesPerApplication;
    private Label label6;
    private Label label4;
    private DateTimePicker dteIrrigStart;
    private Label label3;
    private Label label21;
    private HelpProvider hp;
    private Button button5;
    private Button button2;
    private Button button3;
    private Button btnAlf;
    private Label lblwheat;
    private Label label8;
    private TabPage tpCosts;
    public GroupBox groupBox4;
    public Label label16;
    private TextBox txtPrice;
    private Label label11;
    private Label lblPriceUnits;
    private TabControl tpInputCosts;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private Label label15;
    private TextBox txtAcres2;
    private Label label26;
    private ComboBox cboFuelType;
    private Label label17;
    private Label label2;
    private TextBox txtFuelPrice;
    private Label label18;
    private CustomDataGridView cdgGeneralCosts;
    private CustomDataGridView cdgOperationCosts;
    private CustomDataGridView cdgIrrigationCosts;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private Label label19;
    private Label lblIrrigCost;
    private Button button4;
    private CheckBox checkBox3;
    private Label label22;
    private Label label20;
    private TextBox txtGPM;
    private TabPage tabPage6;
    private CustomDataGridView cdgMiscCosts;
    private CustomDataGridView cdgReturns;
    private Label label23;
    public Label label24;
    private Button button6;
    private Label lblTotalInches;
    private Label lblTotalIrrigationLabel;
    public int index;
    public Crop ActiveCrop;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CropInput));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.tcCrops = new TabControl();
      this.tpGeneral = new TabPage();
      this.label21 = new Label();
      this.groupBox3 = new GroupBox();
      this.btnAlf = new Button();
      this.button2 = new Button();
      this.dgCoefficients = new DataGridView();
      this.label5 = new Label();
      this.groupBox2 = new GroupBox();
      this.button5 = new Button();
      this.txtMaxYield = new TextBox();
      this.label13 = new Label();
      this.lblMaxYield = new Label();
      this.lstCrops = new ListBox();
      this.label10 = new Label();
      this.tpIrrigation = new TabPage();
      this.groupBox8 = new GroupBox();
      this.tabControl1 = new TabControl();
      this.tpIrrigationEntries = new TabPage();
      this.label8 = new Label();
      this.lblwheat = new Label();
      this.dgIrrigation = new DataGridView();
      this.button1 = new Button();
      this.label1 = new Label();
      this.tabPage1 = new TabPage();
      this.label23 = new Label();
      this.button3 = new Button();
      this.label14 = new Label();
      this.lblAuto = new Label();
      this.txtAuto = new TextBox();
      this.lblAutoUnits = new Label();
      this.groupBox1 = new GroupBox();
      this.rbNetIrrigation = new RadioButton();
      this.rbGPM = new RadioButton();
      this.label12 = new Label();
      this.cmdAuto = new Button();
      this.txtAcres = new TextBox();
      this.dteIrrigEnd = new DateTimePicker();
      this.label9 = new Label();
      this.label7 = new Label();
      this.txtInchesPerApplication = new TextBox();
      this.label6 = new Label();
      this.label4 = new Label();
      this.dteIrrigStart = new DateTimePicker();
      this.label3 = new Label();
      this.tpCosts = new TabPage();
      this.groupBox4 = new GroupBox();
      this.button6 = new Button();
      this.label15 = new Label();
      this.txtAcres2 = new TextBox();
      this.label26 = new Label();
      this.tpInputCosts = new TabControl();
      this.tabPage2 = new TabPage();
      this.checkBox3 = new CheckBox();
      this.checkBox2 = new CheckBox();
      this.checkBox1 = new CheckBox();
      this.tabPage3 = new TabPage();
      this.tabPage5 = new TabPage();
      this.label24 = new Label();
      this.label22 = new Label();
      this.label20 = new Label();
      this.txtGPM = new TextBox();
      this.button4 = new Button();
      this.lblIrrigCost = new Label();
      this.label19 = new Label();
      this.label18 = new Label();
      this.label2 = new Label();
      this.txtFuelPrice = new TextBox();
      this.cboFuelType = new ComboBox();
      this.label17 = new Label();
      this.tabPage4 = new TabPage();
      this.tabPage6 = new TabPage();
      this.txtPrice = new TextBox();
      this.label11 = new Label();
      this.lblPriceUnits = new Label();
      this.label16 = new Label();
      this.images = new ImageList(this.components);
      this.hp = new HelpProvider();
      this.lblTotalInches = new Label();
      this.lblTotalIrrigationLabel = new Label();
      this.cdgGeneralCosts = new CustomDataGridView();
      this.cdgOperationCosts = new CustomDataGridView();
      this.cdgIrrigationCosts = new CustomDataGridView();
      this.cdgMiscCosts = new CustomDataGridView();
      this.cdgReturns = new CustomDataGridView();
      this.tcCrops.SuspendLayout();
      this.tpGeneral.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((ISupportInitialize) this.dgCoefficients).BeginInit();
      this.groupBox2.SuspendLayout();
      this.tpIrrigation.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tpIrrigationEntries.SuspendLayout();
      ((ISupportInitialize) this.dgIrrigation).BeginInit();
      this.tabPage1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tpCosts.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.tpInputCosts.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.tabPage6.SuspendLayout();
      //this.cdgGeneralCosts.BeginInit();
      //this.cdgOperationCosts.BeginInit();
      //this.cdgIrrigationCosts.BeginInit();
      //this.cdgMiscCosts.BeginInit();
      //this.cdgReturns.BeginInit();
      this.SuspendLayout();
      this.tcCrops.Controls.Add((Control) this.tpGeneral);
      this.tcCrops.Controls.Add((Control) this.tpIrrigation);
      this.tcCrops.Controls.Add((Control) this.tpCosts);
      this.tcCrops.Dock = DockStyle.Fill;
      this.tcCrops.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tcCrops.ImageList = this.images;
      this.tcCrops.Location = new Point(120, 0);
      this.tcCrops.Name = "tcCrops";
      this.tcCrops.Padding = new Point(0, 0);
      this.tcCrops.SelectedIndex = 0;
      this.tcCrops.Size = new Size(571, 412);
      this.tcCrops.TabIndex = 17;
      this.tcCrops.Selected += new TabControlEventHandler(this.tcCrops_Selected);
      this.tcCrops.Validating += new CancelEventHandler(this.tcCrops_Validating);
      this.tcCrops.SelectedIndexChanged += new EventHandler(this.tcCrops_SelectedIndexChanged);
      this.tpGeneral.AutoScroll = true;
      this.tpGeneral.BackColor = Color.White;
      this.tpGeneral.CausesValidation = false;
      this.tpGeneral.Controls.Add((Control) this.label21);
      this.tpGeneral.Controls.Add((Control) this.groupBox3);
      this.tpGeneral.Controls.Add((Control) this.groupBox2);
      this.tpGeneral.ImageIndex = 0;
      this.tpGeneral.Location = new Point(4, 31);
      this.tpGeneral.Name = "tpGeneral";
      this.tpGeneral.Size = new Size(563, 377);
      this.tpGeneral.TabIndex = 0;
      this.tpGeneral.Text = "Crop Selection";
      this.tpGeneral.UseVisualStyleBackColor = true;
      this.label21.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.ForeColor = Color.Maroon;
      this.label21.Location = new Point(9, 285);
      this.label21.Name = "label21";
      this.label21.Size = new Size(349, 56);
      this.label21.TabIndex = 19;
      this.label21.Text = "Adjusting crops will affect the default Runoff coefficient.  Be sure to visit the Runoff && Soil Water tab if an alternate coefficient is desired.";
      this.groupBox3.Controls.Add((Control) this.btnAlf);
      this.groupBox3.Controls.Add((Control) this.button2);
      this.groupBox3.Controls.Add((Control) this.dgCoefficients);
      this.groupBox3.Controls.Add((Control) this.label5);
      this.groupBox3.ForeColor = Color.SteelBlue;
      this.groupBox3.Location = new Point(3, 117);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(548, 165);
      this.groupBox3.TabIndex = 18;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Growth Stage Dates";
      this.btnAlf.Location = new Point(6, 89);
      this.btnAlf.Name = "btnAlf";
      this.btnAlf.Size = new Size(142, 24);
      this.btnAlf.TabIndex = 25;
      this.btnAlf.Text = "Delete 5th Cutting";
      this.btnAlf.UseVisualStyleBackColor = true;
      this.btnAlf.Visible = false;
      this.btnAlf.Click += new EventHandler(this.button4_Click);
      this.button2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button2, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button2, "");
      this.button2.Location = new Point(220, 15);
      this.button2.Name = "button2";
      this.hp.SetShowHelp((Control) this.button2, true);
      this.button2.Size = new Size(28, 23);
      this.button2.TabIndex = 24;
      this.button2.Text = "?";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click_1);
      this.dgCoefficients.AllowUserToAddRows = false;
      this.dgCoefficients.AllowUserToDeleteRows = false;
      this.dgCoefficients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.dgCoefficients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgCoefficients.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.dgCoefficients.BorderStyle = BorderStyle.None;
      this.dgCoefficients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgCoefficients.Location = new Point(254, 14);
      this.dgCoefficients.Name = "dgCoefficients";
      this.dgCoefficients.Size = new Size(288, 147);
      this.dgCoefficients.TabIndex = 3;
      this.dgCoefficients.UserDeletingRow += new DataGridViewRowCancelEventHandler(this.dgCoefficients_UserDeletingRow);
      this.dgCoefficients.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgCoefficients_RowsRemoved);
      this.dgCoefficients.VisibleChanged += new EventHandler(this.dgCoefficients_VisibleChanged);
      this.label5.BackColor = Color.Transparent;
      this.label5.ForeColor = Color.FromArgb(64, 64, 64);
      this.label5.Location = new Point(6, 18);
      this.label5.Name = "label5";
      this.label5.Size = new Size(184, 82);
      this.label5.TabIndex = 2;
      this.label5.Text = "The growth stage dates are shown in the list on the right.  Select a date from the list to edit it.";
      this.groupBox2.BackColor = Color.White;
      this.groupBox2.Controls.Add((Control) this.button5);
      this.groupBox2.Controls.Add((Control) this.txtMaxYield);
      this.groupBox2.Controls.Add((Control) this.label13);
      this.groupBox2.Controls.Add((Control) this.lblMaxYield);
      this.groupBox2.Controls.Add((Control) this.lstCrops);
      this.groupBox2.Controls.Add((Control) this.label10);
      this.groupBox2.ForeColor = Color.SteelBlue;
      this.groupBox2.Location = new Point(3, 3);
      this.groupBox2.Margin = new Padding(0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = Settings.Default.DefaultPadding2;
      this.groupBox2.Size = new Size(548, 113);
      this.groupBox2.TabIndex = 17;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Crop Type";
      this.button5.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button5.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button5, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button5, "");
      this.button5.Location = new Point(220, 18);
      this.button5.Name = "button5";
      this.hp.SetShowHelp((Control) this.button5, true);
      this.button5.Size = new Size(28, 23);
      this.button5.TabIndex = 23;
      this.button5.Text = "?";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.txtMaxYield.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtMaxYield.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaxYield.Location = new Point(119, 65);
      this.txtMaxYield.Name = "txtMaxYield";
      this.txtMaxYield.Size = new Size(67, 22);
      this.txtMaxYield.TabIndex = 21;
      this.label13.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = Color.FromArgb(64, 64, 64);
      this.label13.Location = new Point(3, 67);
      this.label13.Margin = new Padding(0);
      this.label13.Name = "label13";
      this.label13.Size = new Size(122, 14);
      this.label13.TabIndex = 22;
      this.label13.Text = "Maximum Yield?";
      this.lblMaxYield.AutoSize = true;
      this.lblMaxYield.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaxYield.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblMaxYield.Location = new Point(187, 65);
      this.lblMaxYield.Name = "lblMaxYield";
      this.lblMaxYield.Size = new Size(15, 14);
      this.lblMaxYield.TabIndex = 20;
      this.lblMaxYield.Text = "--";
      this.lstCrops.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.lstCrops.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.lstCrops.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lstCrops.FormattingEnabled = true;
      this.lstCrops.Items.AddRange(new object[1]
      {
        (object) "No crops loaded yet..."
      });
      this.lstCrops.Location = new Point(251, 18);
      this.lstCrops.Name = "lstCrops";
      this.lstCrops.Size = new Size(294, 82);
      this.lstCrops.TabIndex = 10;
      this.lstCrops.SelectedIndexChanged += new EventHandler(this.lstCrops_SelectedIndexChanged);
      this.label10.BackColor = Color.Transparent;
      this.label10.ForeColor = Color.FromArgb(64, 64, 64);
      this.label10.Location = new Point(9, 21);
      this.label10.Margin = new Padding(0);
      this.label10.Name = "label10";
      this.label10.Size = new Size(208, 43);
      this.label10.TabIndex = 1;
      this.label10.Text = "Available crops for the simulation are listed in the box to the right.";
      this.label10.PaddingChanged += new EventHandler(this.label10_PaddingChanged);
      this.tpIrrigation.AutoScroll = true;
      this.tpIrrigation.BackColor = Color.White;
      this.tpIrrigation.Controls.Add((Control) this.groupBox8);
      this.tpIrrigation.ImageIndex = 1;
      this.tpIrrigation.Location = new Point(4, 31);
      this.tpIrrigation.Name = "tpIrrigation";
      this.tpIrrigation.Size = new Size(563, 377);
      this.tpIrrigation.TabIndex = 2;
      this.tpIrrigation.Text = "Irrigation Schedule";
      this.tpIrrigation.UseVisualStyleBackColor = true;
      this.groupBox8.BackColor = Color.White;
      this.groupBox8.Controls.Add((Control) this.tabControl1);
      this.groupBox8.Dock = DockStyle.Fill;
      this.groupBox8.Location = new Point(0, 0);
      this.groupBox8.Margin = new Padding(0);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Padding = new Padding(0);
      this.groupBox8.Size = new Size(563, 377);
      this.groupBox8.TabIndex = 16;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Irrigation Events";
      this.groupBox8.Enter += new EventHandler(this.groupBox8_Enter);
      this.tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tabControl1.Controls.Add((Control) this.tpIrrigationEntries);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Location = new Point(9, 22);
      this.tabControl1.Margin = new Padding(0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.Padding = new Point(0, 0);
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(541, 343);
      this.tabControl1.TabIndex = 5;
      this.tpIrrigationEntries.AutoScroll = true;
      this.tpIrrigationEntries.Controls.Add((Control) this.lblTotalIrrigationLabel);
      this.tpIrrigationEntries.Controls.Add((Control) this.lblTotalInches);
      this.tpIrrigationEntries.Controls.Add((Control) this.label8);
      this.tpIrrigationEntries.Controls.Add((Control) this.lblwheat);
      this.tpIrrigationEntries.Controls.Add((Control) this.dgIrrigation);
      this.tpIrrigationEntries.Controls.Add((Control) this.button1);
      this.tpIrrigationEntries.Controls.Add((Control) this.label1);
      this.tpIrrigationEntries.Location = new Point(4, 25);
      this.tpIrrigationEntries.Margin = new Padding(0);
      this.tpIrrigationEntries.Name = "tpIrrigationEntries";
      this.tpIrrigationEntries.Size = new Size(533, 314);
      this.tpIrrigationEntries.TabIndex = 0;
      this.tpIrrigationEntries.Text = "Manual - Irrigation Entries";
      this.tpIrrigationEntries.UseVisualStyleBackColor = true;
      this.label8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = Color.Maroon;
      this.label8.Location = new Point(3, 118);
      this.label8.Name = "label8";
      this.label8.Size = new Size(219, 82);
      this.label8.TabIndex = 13;
      this.label8.Text = "For each irrigation event no more than 2 inches of net irrigation can infiltrate into the soil. Excess irrigation is considered runoff in the soil water balance. ";
      this.label8.Visible = false;
      this.lblwheat.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblwheat.ForeColor = Color.Maroon;
      this.lblwheat.Location = new Point(3, 200);
      this.lblwheat.Name = "lblwheat";
      this.lblwheat.Size = new Size(219, 53);
      this.lblwheat.TabIndex = 12;
      this.lblwheat.Text = "Gross irrigation amounts entered for Winter Wheat will be applied in the year the crop is harvested.";
      this.lblwheat.Visible = false;
      this.dgIrrigation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.dgIrrigation.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.dgIrrigation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgIrrigation.Location = new Point(227, 72);
      this.dgIrrigation.Name = "dgIrrigation";
      this.dgIrrigation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgIrrigation.ShowCellErrors = false;
      this.dgIrrigation.ShowRowErrors = false;
      this.dgIrrigation.Size = new Size(277, 35);
      this.dgIrrigation.TabIndex = 0;
      this.dgIrrigation.CellValueChanged += new DataGridViewCellEventHandler(this.dgIrrigation_CellValueChanged);
      this.dgIrrigation.CellValuePushed += new DataGridViewCellValueEventHandler(this.dgIrrigation_CellValuePushed);
      this.dgIrrigation.DataError += new DataGridViewDataErrorEventHandler(this.dgIrrigation_DataError);
      this.dgIrrigation.CellContentClick += new DataGridViewCellEventHandler(this.dgIrrigation_CellContentClick);
      this.button1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.Image = (Image) Resources.page_white_excel;
      this.button1.ImageAlign = ContentAlignment.MiddleLeft;
      this.button1.Location = new Point(227, 39);
      this.button1.Name = "button1";
      this.button1.Size = new Size(135, 27);
      this.button1.TabIndex = 1;
      this.button1.Text = "Paste from Excel";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.BackColor = Color.Transparent;
      this.label1.ForeColor = Color.FromArgb(64, 64, 64);
      this.label1.Location = new Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(218, 118);
      this.label1.TabIndex = 2;
      this.label1.Text = "Manually enter irrigation entries into the table.  Entries are added line-by-line, new entries can be added at the bottom of the table.  Dates do not have to be chronological.";
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Controls.Add((Control) this.label23);
      this.tabPage1.Controls.Add((Control) this.button3);
      this.tabPage1.Controls.Add((Control) this.label14);
      this.tabPage1.Controls.Add((Control) this.lblAuto);
      this.tabPage1.Controls.Add((Control) this.txtAuto);
      this.tabPage1.Controls.Add((Control) this.lblAutoUnits);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      this.tabPage1.Controls.Add((Control) this.label12);
      this.tabPage1.Controls.Add((Control) this.cmdAuto);
      this.tabPage1.Controls.Add((Control) this.txtAcres);
      this.tabPage1.Controls.Add((Control) this.dteIrrigEnd);
      this.tabPage1.Controls.Add((Control) this.label9);
      this.tabPage1.Controls.Add((Control) this.label7);
      this.tabPage1.Controls.Add((Control) this.txtInchesPerApplication);
      this.tabPage1.Controls.Add((Control) this.label6);
      this.tabPage1.Controls.Add((Control) this.label4);
      this.tabPage1.Controls.Add((Control) this.dteIrrigStart);
      this.tabPage1.Controls.Add((Control) this.label3);
      this.tabPage1.Location = new Point(4, 25);
      this.tabPage1.Margin = new Padding(0);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Size = new Size(533, 314);
      this.tabPage1.TabIndex = 2;
      this.tabPage1.Text = "Automatic - Irrigation Entries";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.label23.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.FromArgb(64, 64, 64);
      this.label23.Location = new Point(18, 32);
      this.label23.Margin = new Padding(0);
      this.label23.Name = "label23";
      this.label23.Size = new Size(375, 49);
      this.label23.TabIndex = 60;
      this.label23.Text = "Create a uniform frequency irrigation schedule for the growing season between the start and stop dates with the same number of days between each irrigation event";
      this.button3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button3.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button3, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button3, "");
      this.button3.Location = new Point(316, 6);
      this.button3.Margin = new Padding(0);
      this.button3.Name = "button3";
      this.hp.SetShowHelp((Control) this.button3, true);
      this.button3.Size = new Size(28, 23);
      this.button3.TabIndex = 59;
      this.button3.Text = "?";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.label14.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.FromArgb(64, 64, 64);
      this.label14.Location = new Point(81, 209);
      this.label14.Margin = new Padding(0);
      this.label14.Name = "label14";
      this.label14.Size = new Size(158, 14);
      this.label14.TabIndex = 58;
      this.label14.Text = "Acres";
      this.label14.TextAlign = ContentAlignment.TopRight;
      this.lblAuto.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAuto.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblAuto.Location = new Point(70, 183);
      this.lblAuto.Margin = new Padding(0);
      this.lblAuto.Name = "lblAuto";
      this.lblAuto.Size = new Size(169, 14);
      this.lblAuto.TabIndex = 57;
      this.lblAuto.Text = "Pump capacity";
      this.lblAuto.TextAlign = ContentAlignment.TopRight;
      this.txtAuto.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtAuto.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAuto.Location = new Point(246, 181);
      this.txtAuto.Margin = new Padding(0);
      this.txtAuto.Name = "txtAuto";
      this.txtAuto.Size = new Size(60, 24);
      this.txtAuto.TabIndex = 56;
      this.txtAuto.WordWrap = false;
      this.txtAuto.TextChanged += new EventHandler(this.txtAuto_TextChanged);
      this.lblAutoUnits.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAutoUnits.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblAutoUnits.Location = new Point(313, 183);
      this.lblAutoUnits.Margin = new Padding(0);
      this.lblAutoUnits.Name = "lblAutoUnits";
      this.lblAutoUnits.Size = new Size(31, 14);
      this.lblAutoUnits.TabIndex = 55;
      this.lblAutoUnits.Text = "GPM";
      this.lblAutoUnits.TextAlign = ContentAlignment.TopRight;
      this.groupBox1.Controls.Add((Control) this.rbNetIrrigation);
      this.groupBox1.Controls.Add((Control) this.rbGPM);
      this.groupBox1.Location = new Point(30, 112);
      this.groupBox1.Margin = new Padding(0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(387, 66);
      this.groupBox1.TabIndex = 54;
      this.groupBox1.TabStop = false;
      this.rbNetIrrigation.AutoSize = true;
      this.rbNetIrrigation.Location = new Point(7, 39);
      this.rbNetIrrigation.Margin = new Padding(0);
      this.rbNetIrrigation.Name = "rbNetIrrigation";
      this.rbNetIrrigation.Size = new Size(331, 20);
      this.rbNetIrrigation.TabIndex = 33;
      this.rbNetIrrigation.Text = "Create schedule based on the Total Season Irrigation";
      this.rbNetIrrigation.UseVisualStyleBackColor = true;
      this.rbNetIrrigation.CheckedChanged += new EventHandler(this.rbNetIrrigation_CheckedChanged);
      this.rbGPM.AutoSize = true;
      this.rbGPM.Checked = true;
      this.rbGPM.Location = new Point(7, 13);
      this.rbGPM.Margin = new Padding(0);
      this.rbGPM.Name = "rbGPM";
      this.rbGPM.Size = new Size(203, 20);
      this.rbGPM.TabIndex = 32;
      this.rbGPM.TabStop = true;
      this.rbGPM.Text = "Create schedule based on GPM";
      this.rbGPM.UseVisualStyleBackColor = true;
      this.rbGPM.CheckedChanged += new EventHandler(this.rbGPM_CheckedChanged);
      this.label12.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.ForeColor = Color.FromArgb(64, 64, 64);
      this.label12.Location = new Point(314, 233);
      this.label12.Margin = new Padding(0);
      this.label12.Name = "label12";
      this.label12.Size = new Size(76, 14);
      this.label12.TabIndex = 53;
      this.label12.Text = "inches";
      this.cmdAuto.Location = new Point(73, 268);
      this.cmdAuto.Margin = new Padding(0);
      this.cmdAuto.Name = "cmdAuto";
      this.cmdAuto.Size = new Size(310, 24);
      this.cmdAuto.TabIndex = 42;
      this.cmdAuto.Text = "Create gross irrigation events table";
      this.cmdAuto.UseVisualStyleBackColor = true;
      this.cmdAuto.Click += new EventHandler(this.cmdAuto_Click_1);
      this.txtAcres.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtAcres.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAcres.Location = new Point(246, 207);
      this.txtAcres.Margin = new Padding(0);
      this.txtAcres.Name = "txtAcres";
      this.txtAcres.Size = new Size(60, 24);
      this.txtAcres.TabIndex = 50;
      this.dteIrrigEnd.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dteIrrigEnd.Format = DateTimePickerFormat.Short;
      this.dteIrrigEnd.Location = new Point(316, 85);
      this.dteIrrigEnd.Margin = new Padding(0);
      this.dteIrrigEnd.Name = "dteIrrigEnd";
      this.dteIrrigEnd.Size = new Size(101, 24);
      this.dteIrrigEnd.TabIndex = 44;
      this.label9.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = Color.FromArgb(64, 64, 64);
      this.label9.Location = new Point(314, 209);
      this.label9.Margin = new Padding(0);
      this.label9.Name = "label9";
      this.label9.Size = new Size(76, 14);
      this.label9.TabIndex = 49;
      this.label9.Text = "Acres";
      this.label7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = Color.FromArgb(64, 64, 64);
      this.label7.Location = new Point(236, 86);
      this.label7.Margin = new Padding(0);
      this.label7.Name = "label7";
      this.label7.Size = new Size(74, 14);
      this.label7.TabIndex = 45;
      this.label7.Text = "Ending Date";
      this.txtInchesPerApplication.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtInchesPerApplication.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtInchesPerApplication.Location = new Point(246, 233);
      this.txtInchesPerApplication.Margin = new Padding(0);
      this.txtInchesPerApplication.Name = "txtInchesPerApplication";
      this.txtInchesPerApplication.Size = new Size(60, 24);
      this.txtInchesPerApplication.TabIndex = 48;
      this.txtInchesPerApplication.TextChanged += new EventHandler(this.txtInchesPerApplication_TextChanged);
      this.label6.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.Gray;
      this.label6.Location = new Point(16, 7);
      this.label6.Margin = new Padding(0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(278, 18);
      this.label6.TabIndex = 43;
      this.label6.Text = "Create a uniform irrigation schedule";
      this.label4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.FromArgb(64, 64, 64);
      this.label4.Location = new Point(37, 233);
      this.label4.Margin = new Padding(0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(200, 14);
      this.label4.TabIndex = 47;
      this.label4.Text = "Gross Inches per application";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.dteIrrigStart.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dteIrrigStart.Format = DateTimePickerFormat.Short;
      this.dteIrrigStart.Location = new Point(107, 85);
      this.dteIrrigStart.Margin = new Padding(0);
      this.dteIrrigStart.Name = "dteIrrigStart";
      this.dteIrrigStart.Size = new Size(101, 24);
      this.dteIrrigStart.TabIndex = 40;
      this.label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.FromArgb(64, 64, 64);
      this.label3.Location = new Point(18, 86);
      this.label3.Margin = new Padding(0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(80, 14);
      this.label3.TabIndex = 41;
      this.label3.Text = "Starting Date";
      this.tpCosts.AutoScroll = true;
      this.tpCosts.Controls.Add((Control) this.groupBox4);
      this.tpCosts.ImageIndex = 2;
      this.tpCosts.Location = new Point(4, 31);
      this.tpCosts.Name = "tpCosts";
      this.tpCosts.Size = new Size(563, 377);
      this.tpCosts.TabIndex = 3;
      this.tpCosts.Text = "Economic Analysis";
      this.tpCosts.UseVisualStyleBackColor = true;
      this.groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox4.BackColor = Color.White;
      this.groupBox4.Controls.Add((Control) this.button6);
      this.groupBox4.Controls.Add((Control) this.label15);
      this.groupBox4.Controls.Add((Control) this.txtAcres2);
      this.groupBox4.Controls.Add((Control) this.label26);
      this.groupBox4.Controls.Add((Control) this.tpInputCosts);
      this.groupBox4.Controls.Add((Control) this.txtPrice);
      this.groupBox4.Controls.Add((Control) this.label11);
      this.groupBox4.Controls.Add((Control) this.lblPriceUnits);
      this.groupBox4.Controls.Add((Control) this.label16);
      this.groupBox4.ForeColor = Color.SteelBlue;
      this.groupBox4.Location = new Point(6, 3);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new Padding(0);
      this.groupBox4.Size = new Size(554, 374);
      this.groupBox4.TabIndex = 18;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Economic Analysis";
      this.button6.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button6.ForeColor = Color.RoyalBlue;
      this.hp.SetHelpNavigator((Control) this.button6, HelpNavigator.Topic);
      this.hp.SetHelpString((Control) this.button6, "");
      this.button6.Location = new Point(386, 18);
      this.button6.Name = "button6";
      this.hp.SetShowHelp((Control) this.button6, true);
      this.button6.Size = new Size(28, 23);
      this.button6.TabIndex = 74;
      this.button6.Text = "?";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click_2);
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.FromArgb(64, 64, 64);
      this.label15.Location = new Point(274, 53);
      this.label15.Margin = new Padding(0);
      this.label15.Name = "label15";
      this.label15.Size = new Size(47, 14);
      this.label15.TabIndex = 73;
      this.label15.Text = "Acres?";
      this.label15.TextAlign = ContentAlignment.TopRight;
      this.label15.Visible = false;
      this.txtAcres2.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtAcres2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAcres2.Location = new Point(326, 51);
      this.txtAcres2.Margin = new Padding(0);
      this.txtAcres2.Name = "txtAcres2";
      this.txtAcres2.Size = new Size(67, 22);
      this.txtAcres2.TabIndex = 72;
      this.txtAcres2.Visible = false;
      this.label26.AutoSize = true;
      this.label26.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.FromArgb(64, 64, 64);
      this.label26.Location = new Point(399, 53);
      this.label26.Margin = new Padding(0);
      this.label26.Name = "label26";
      this.label26.Size = new Size(37, 14);
      this.label26.TabIndex = 71;
      this.label26.Text = "Acres";
      this.label26.TextAlign = ContentAlignment.TopRight;
      this.label26.Visible = false;
      this.tpInputCosts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.tpInputCosts.Controls.Add((Control) this.tabPage2);
      this.tpInputCosts.Controls.Add((Control) this.tabPage3);
      this.tpInputCosts.Controls.Add((Control) this.tabPage5);
      this.tpInputCosts.Controls.Add((Control) this.tabPage4);
      this.tpInputCosts.Controls.Add((Control) this.tabPage6);
      this.tpInputCosts.Location = new Point(6, 79);
      this.tpInputCosts.Name = "tpInputCosts";
      this.tpInputCosts.SelectedIndex = 0;
      this.tpInputCosts.Size = new Size(545, 286);
      this.tpInputCosts.TabIndex = 27;
      this.tabPage2.Controls.Add((Control) this.checkBox3);
      this.tabPage2.Controls.Add((Control) this.checkBox2);
      this.tabPage2.Controls.Add((Control) this.checkBox1);
      this.tabPage2.Controls.Add((Control) this.cdgGeneralCosts);
      this.tabPage2.Location = new Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Size = new Size(537, 257);
      this.tabPage2.TabIndex = 0;
      this.tabPage2.Text = "Input Costs";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.checkBox3.AutoSize = true;
      this.checkBox3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox3.Location = new Point(305, 49);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(192, 17);
      this.checkBox3.TabIndex = 6;
      this.checkBox3.Text = "Use optimal yield based seed rate?";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new EventHandler(this.checkBox3_CheckedChanged);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox2.Location = new Point(305, 26);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(225, 17);
      this.checkBox2.TabIndex = 5;
      this.checkBox2.Text = "Use optimal yield based phosphorus rate?";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox1.Location = new Point(305, 3);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(209, 17);
      this.checkBox1.TabIndex = 4;
      this.checkBox1.Text = "Use optimal yield based nitrogen rate?";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.tabPage3.Controls.Add((Control) this.cdgOperationCosts);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new Size(537, 260);
      this.tabPage3.TabIndex = 1;
      this.tabPage3.Text = "Operation Costs";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage5.Controls.Add((Control) this.label24);
      this.tabPage5.Controls.Add((Control) this.label22);
      this.tabPage5.Controls.Add((Control) this.label20);
      this.tabPage5.Controls.Add((Control) this.txtGPM);
      this.tabPage5.Controls.Add((Control) this.button4);
      this.tabPage5.Controls.Add((Control) this.lblIrrigCost);
      this.tabPage5.Controls.Add((Control) this.label19);
      this.tabPage5.Controls.Add((Control) this.label18);
      this.tabPage5.Controls.Add((Control) this.label2);
      this.tabPage5.Controls.Add((Control) this.txtFuelPrice);
      this.tabPage5.Controls.Add((Control) this.cboFuelType);
      this.tabPage5.Controls.Add((Control) this.label17);
      this.tabPage5.Controls.Add((Control) this.cdgIrrigationCosts);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Size = new Size(537, 260);
      this.tabPage5.TabIndex = 3;
      this.tabPage5.Text = "Irrigation Costs";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.label24.BackColor = Color.Transparent;
      this.label24.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.FromArgb(64, 64, 64);
      this.label24.Location = new Point(345, 188);
      this.label24.Name = "label24";
      this.label24.Size = new Size(186, 66);
      this.label24.TabIndex = 84;
      this.label24.Text = "Calculated pumping cost does not include labor or repair && maintenance costs.  These costs are added after execution of the scenario.";
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.ForeColor = Color.FromArgb(64, 64, 64);
      this.label22.Location = new Point(472, 17);
      this.label22.Margin = new Padding(0);
      this.label22.Name = "label22";
      this.label22.Size = new Size(27, 13);
      this.label22.TabIndex = 83;
      this.label22.Text = "gpm";
      this.label22.TextAlign = ContentAlignment.TopRight;
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label20.ForeColor = Color.FromArgb(64, 64, 64);
      this.label20.Location = new Point(373, 17);
      this.label20.Margin = new Padding(0);
      this.label20.Name = "label20";
      this.label20.Size = new Size(32, 13);
      this.label20.TabIndex = 82;
      this.label20.Text = "GPM";
      this.label20.TextAlign = ContentAlignment.TopRight;
      this.txtGPM.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtGPM.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtGPM.Location = new Point(405, 13);
      this.txtGPM.Margin = new Padding(0);
      this.txtGPM.Name = "txtGPM";
      this.txtGPM.Size = new Size(67, 22);
      this.txtGPM.TabIndex = 81;
      this.button4.ForeColor = Color.Black;
      this.button4.Image = (Image) Resources.arrow_refresh;
      this.button4.ImageAlign = ContentAlignment.MiddleLeft;
      this.button4.Location = new Point(348, 114);
      this.button4.Name = "button4";
      this.button4.Size = new Size(166, 32);
      this.button4.TabIndex = 80;
      this.button4.Text = "Recalculate Cost";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click_1);
      this.lblIrrigCost.AutoSize = true;
      this.lblIrrigCost.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblIrrigCost.ForeColor = Color.ForestGreen;
      this.lblIrrigCost.Location = new Point(389, 175);
      this.lblIrrigCost.Margin = new Padding(0);
      this.lblIrrigCost.Name = "lblIrrigCost";
      this.lblIrrigCost.Size = new Size(17, 13);
      this.lblIrrigCost.TabIndex = 79;
      this.lblIrrigCost.Text = "--";
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label19.ForeColor = Color.FromArgb(64, 64, 64);
      this.label19.Location = new Point(348, 157);
      this.label19.Margin = new Padding(0);
      this.label19.Name = "label19";
      this.label19.Size = new Size(146, 13);
      this.label19.TabIndex = 78;
      this.label19.Text = "Calculated Pumping Cost";
      this.label19.Click += new EventHandler(this.label19_Click);
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.ForeColor = Color.FromArgb(64, 64, 64);
      this.label18.Location = new Point(472, 85);
      this.label18.Margin = new Padding(0);
      this.label18.Name = "label18";
      this.label18.Size = new Size(56, 13);
      this.label18.TabIndex = 76;
      this.label18.Text = "Rs/fuel unit";
      this.label18.TextAlign = ContentAlignment.TopRight;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.FromArgb(64, 64, 64);
      this.label2.Location = new Point(344, 85);
      this.label2.Margin = new Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(61, 13);
      this.label2.TabIndex = 75;
      this.label2.Text = "Fuel Price";
      this.label2.TextAlign = ContentAlignment.TopRight;
      this.label2.Click += new EventHandler(this.label2_Click);
      this.txtFuelPrice.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtFuelPrice.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFuelPrice.Location = new Point(405, 81);
      this.txtFuelPrice.Margin = new Padding(0);
      this.txtFuelPrice.Name = "txtFuelPrice";
      this.txtFuelPrice.Size = new Size(67, 22);
      this.txtFuelPrice.TabIndex = 74;
      this.txtFuelPrice.TextChanged += new EventHandler(this.txtFuelPrice_TextChanged_1);
      this.txtFuelPrice.Validated += new EventHandler(this.txtFuelPrice_Validated);
      this.txtFuelPrice.Enter += new EventHandler(this.txtFuelPrice_Enter);
      this.cboFuelType.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cboFuelType.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboFuelType.FormattingEnabled = true;
      this.cboFuelType.Items.AddRange(new object[4]
      {
        (object) "Diesel",
        (object) "Electricity",
        (object) "Natural Gas",
        (object) "Propane"
      });
      this.cboFuelType.Location = new Point(405, 46);
      this.cboFuelType.Name = "cboFuelType";
      this.cboFuelType.Size = new Size(94, 21);
      this.cboFuelType.TabIndex = 28;
      this.cboFuelType.SelectedIndexChanged += new EventHandler(this.cboFuelType_SelectedIndexChanged);
      this.cboFuelType.SelectedValueChanged += new EventHandler(this.cboFuelType_SelectedValueChanged);
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.FromArgb(64, 64, 64);
      this.label17.Location = new Point(344, 50);
      this.label17.Margin = new Padding(0);
      this.label17.Name = "label17";
      this.label17.Size = new Size(61, 13);
      this.label17.TabIndex = 27;
      this.label17.Text = "Fuel Type";
      this.label17.TextAlign = ContentAlignment.TopRight;
      this.tabPage4.Controls.Add((Control) this.cdgMiscCosts);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new Size(537, 260);
      this.tabPage4.TabIndex = 2;
      this.tabPage4.Text = "Misc Costs";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.tabPage6.Controls.Add((Control) this.cdgReturns);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Size = new Size(537, 260);
      this.tabPage6.TabIndex = 4;
      this.tabPage6.Text = "Misc Returns";
      this.tabPage6.UseVisualStyleBackColor = true;
      this.txtPrice.BackColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.txtPrice.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPrice.Location = new Point(139, 51);
      this.txtPrice.Name = "txtPrice";
      this.txtPrice.Size = new Size(67, 22);
      this.txtPrice.TabIndex = 24;
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.FromArgb(64, 64, 64);
      this.label11.Location = new Point(3, 53);
      this.label11.Margin = new Padding(0);
      this.label11.Name = "label11";
      this.label11.Size = new Size(129, 14);
      this.label11.TabIndex = 25;
      this.label11.Text = "Crop Price per Unit?";
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.lblPriceUnits.AutoSize = true;
      this.lblPriceUnits.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPriceUnits.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblPriceUnits.Location = new Point(209, 51);
      this.lblPriceUnits.Name = "lblPriceUnits";
      this.lblPriceUnits.Size = new Size(15, 14);
      this.lblPriceUnits.TabIndex = 23;
      this.lblPriceUnits.Text = "--";
      this.label16.BackColor = Color.Transparent;
      this.label16.ForeColor = Color.FromArgb(64, 64, 64);
      this.label16.Location = new Point(6, 21);
      this.label16.Name = "label16";
      this.label16.Size = new Size(452, 18);
      this.label16.TabIndex = 1;
      this.label16.Text = "Provide the following inputs to perform an economic analysis";
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "crops-small.png");
      this.images.Images.SetKeyName(1, "irrigation.png");
      this.images.Images.SetKeyName(2, "dollar.png");
      this.hp.HelpNamespace = "CYP.chm";
      this.lblTotalInches.AutoSize = true;
      this.lblTotalInches.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotalInches.Location = new Point(380, 48);
      this.lblTotalInches.Name = "lblTotalInches";
      this.lblTotalInches.Size = new Size(20, 18);
      this.lblTotalInches.TabIndex = 14;
      this.lblTotalInches.Text = "--";
      this.lblTotalInches.Click += new EventHandler(this.lblTotalInches_Click);
      this.lblTotalIrrigationLabel.AutoSize = true;
      this.lblTotalIrrigationLabel.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTotalIrrigationLabel.Location = new Point(374, 32);
      this.lblTotalIrrigationLabel.Name = "lblTotalIrrigationLabel";
      this.lblTotalIrrigationLabel.Size = new Size(82, 13);
      this.lblTotalIrrigationLabel.TabIndex = 15;
      this.lblTotalIrrigationLabel.Text = "Total Irrigation:";
      this.cdgGeneralCosts.AllowUserToAddRows = false;
      this.cdgGeneralCosts.AllowUserToDeleteRows = false;
      this.cdgGeneralCosts.AllowUserToResizeRows = false;
      this.cdgGeneralCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.cdgGeneralCosts.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.cdgGeneralCosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cdgGeneralCosts.ColumnHeadersVisible = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = SystemColors.Window;
      gridViewCellStyle1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = Color.SteelBlue;
      gridViewCellStyle1.NullValue = (object) "*";
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      this.cdgGeneralCosts.DefaultCellStyle = gridViewCellStyle1;
      this.cdgGeneralCosts.Location = new Point(3, 3);
      this.cdgGeneralCosts.Name = "cdgGeneralCosts";
      this.cdgGeneralCosts.RowHeadersVisible = false;
      this.cdgGeneralCosts.Size = new Size(296, 251);
      this.cdgGeneralCosts.TabIndex = 3;
      this.cdgOperationCosts.AllowUserToAddRows = false;
      this.cdgOperationCosts.AllowUserToDeleteRows = false;
      this.cdgOperationCosts.AllowUserToResizeRows = false;
      this.cdgOperationCosts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cdgOperationCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.cdgOperationCosts.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.cdgOperationCosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cdgOperationCosts.ColumnHeadersVisible = false;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = Color.SteelBlue;
      gridViewCellStyle2.NullValue = (object) "*";
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.cdgOperationCosts.DefaultCellStyle = gridViewCellStyle2;
      this.cdgOperationCosts.Location = new Point(3, 3);
      this.cdgOperationCosts.Name = "cdgOperationCosts";
      this.cdgOperationCosts.RowHeadersVisible = false;
      this.cdgOperationCosts.Size = new Size(531, 251);
      this.cdgOperationCosts.TabIndex = 4;
      this.cdgIrrigationCosts.AllowUserToAddRows = false;
      this.cdgIrrigationCosts.AllowUserToDeleteRows = false;
      this.cdgIrrigationCosts.AllowUserToResizeRows = false;
      this.cdgIrrigationCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.cdgIrrigationCosts.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.cdgIrrigationCosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cdgIrrigationCosts.ColumnHeadersVisible = false;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Window;
      gridViewCellStyle3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle3.ForeColor = Color.SteelBlue;
      gridViewCellStyle3.NullValue = (object) "*";
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
      this.cdgIrrigationCosts.DefaultCellStyle = gridViewCellStyle3;
      this.cdgIrrigationCosts.Location = new Point(3, 3);
      this.cdgIrrigationCosts.Name = "cdgIrrigationCosts";
      this.cdgIrrigationCosts.RowHeadersVisible = false;
      this.cdgIrrigationCosts.Size = new Size(338, 251);
      this.cdgIrrigationCosts.TabIndex = 77;
      this.cdgIrrigationCosts.CellEndEdit += new DataGridViewCellEventHandler(this.cdgIrrigationCosts_CellEndEdit);
      this.cdgIrrigationCosts.DataSourceChanged += new EventHandler(this.cdgIrrigationCosts_DataSourceChanged);
      this.cdgMiscCosts.AllowUserToAddRows = false;
      this.cdgMiscCosts.AllowUserToDeleteRows = false;
      this.cdgMiscCosts.AllowUserToResizeRows = false;
      this.cdgMiscCosts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cdgMiscCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.cdgMiscCosts.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.cdgMiscCosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cdgMiscCosts.ColumnHeadersVisible = false;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle4.BackColor = SystemColors.Window;
      gridViewCellStyle4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle4.ForeColor = Color.SteelBlue;
      gridViewCellStyle4.NullValue = (object) "*";
      gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
      this.cdgMiscCosts.DefaultCellStyle = gridViewCellStyle4;
      this.cdgMiscCosts.Location = new Point(3, 3);
      this.cdgMiscCosts.Name = "cdgMiscCosts";
      this.cdgMiscCosts.RowHeadersVisible = false;
      this.cdgMiscCosts.Size = new Size(531, 251);
      this.cdgMiscCosts.TabIndex = 5;
      this.cdgReturns.AllowUserToAddRows = false;
      this.cdgReturns.AllowUserToDeleteRows = false;
      this.cdgReturns.AllowUserToResizeRows = false;
      this.cdgReturns.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cdgReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.cdgReturns.BackgroundColor = Color.FromArgb(249, 253, (int) byte.MaxValue);
      this.cdgReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cdgReturns.ColumnHeadersVisible = false;
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle5.BackColor = SystemColors.Window;
      gridViewCellStyle5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle5.ForeColor = Color.SteelBlue;
      gridViewCellStyle5.NullValue = (object) "*";
      gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
      this.cdgReturns.DefaultCellStyle = gridViewCellStyle5;
      this.cdgReturns.Location = new Point(3, 3);
      this.cdgReturns.Name = "cdgReturns";
      this.cdgReturns.RowHeadersVisible = false;
      this.cdgReturns.Size = new Size(531, 251);
      this.cdgReturns.TabIndex = 5;
      this.AutoScaleMode = AutoScaleMode.None;
      this.BackColor = Color.DarkGray;
      this.Controls.Add((Control) this.tcCrops);
      this.Margin = new Padding(0);
      this.Name = nameof (CropInput);
      this.Padding = new Padding(120, 0, 0, 0);
      this.Size = new Size(691, 412);
      this.Paint += new PaintEventHandler(this.CropInput_Paint);
      this.PaddingChanged += new EventHandler(this.CropInput_PaddingChanged);
      this.tcCrops.ResumeLayout(false);
      this.tpGeneral.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      ((ISupportInitialize) this.dgCoefficients).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tpIrrigation.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tpIrrigationEntries.ResumeLayout(false);
      this.tpIrrigationEntries.PerformLayout();
      ((ISupportInitialize) this.dgIrrigation).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tpCosts.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.tpInputCosts.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.tabPage6.ResumeLayout(false);
      //this.cdgGeneralCosts.EndInit();
      //his.cdgOperationCosts.EndInit();
      //this.cdgIrrigationCosts.EndInit();
      //this.cdgMiscCosts.EndInit();
      //this.cdgReturns.EndInit();
      this.ResumeLayout(false);
    }

    public CropInput()
    {
      this.InitializeComponent();
    }

    public CropInput(CWYModel m, int theIndex)
    {
      this.InitializeComponent();
      this.model = m;
      this.index = theIndex;
      this.ActiveCrop = new Crop();
      this.LoadIrrigationEvents(new Crop());
    }

    public void UpdateCropUnits()
    {
      if (this.ActiveCrop.CropName == null)
        return;
      this.ActiveCrop.modelunits = this.model.Units;
      foreach (Crop crop in this.lstCrops.Items)
      {
        crop.modelunits = this.model.Units;
        bool flag = crop.modelunits == "metric";
        foreach (InputCost cGeneralCost in (Collection<InputCost>) crop.cGeneralCosts)
          cGeneralCost.IsMetric = flag;
        foreach (InputCost cIrrigationCost in (Collection<InputCost>) crop.cIrrigationCosts)
          cIrrigationCost.IsMetric = flag;
        foreach (InputCost cOperationCost in (Collection<InputCost>) crop.cOperationCosts)
          cOperationCost.IsMetric = flag;
        foreach (InputCost cReturn in (Collection<InputCost>) crop.cReturns)
          cReturn.IsMetric = flag;
        foreach (InputCost cMiscCost in (Collection<InputCost>) crop.cMiscCosts)
          cMiscCost.IsMetric = flag;
      }
      this.CropAction();
      this.label14.Text = this.model.Units == "metric" ? "Hectares" : "Acres";
      this.label9.Text = this.model.Units == "metric" ? "Hectares" : "Acres";
      this.label12.Text = this.model.Units == "metric" ? "mm" : "inches";
      this.label4.Text = this.model.Units == "metric" ? "Gross millimeters per application" : "Gross inches per application";
      this.ActiveCrop.units = this.model.Units;
    }

    public void setModel(CWYModel cm)
    {
    }

    private void DisplayCosts(Crop c)
    {
    }

    public void lstCrops_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!((Control) sender).Enabled)
        return;
      this.CropAction();
    }

    public void SubmitCropHashValues(int method)
    {
      switch (method)
      {
        case 1:
          this.model.SubmitCropRunoff(this.model.cCrops[this.index], this.index);
          break;
        case 2:
          this.model.SubmitCropEmergence(this.model.cCrops[this.index], this.index);
          break;
        default:
          this.model.SubmitCropEmergence(this.model.cCrops[this.index], this.index);
          this.model.SubmitCropRunoff(this.model.cCrops[this.index], this.index);
          break;
      }
    }

    public void c_UnitsChanged()
    {
      this.SetLabels();
    }

    public void SetLabels()
    {
      if (this.dgIrrigation.Columns.Count <= 0)
        return;
      this.dgIrrigation.Columns[1].HeaderText = "Gross Irrig " + (this.model.Units == "english" ? "(in.)" : "(mm.)");
      this.dgIrrigation.Columns[0].HeaderText = "Date (m/d)";
    }

    public void CropAction()
    {
      this.ActiveCrop = (Crop) this.lstCrops.SelectedItem;
      this.ActiveCrop.UnitsChanged += new UnitsChangedHandler(this.c_UnitsChanged);
      this.ActiveCrop.cIrrigation_display.ListChanged += new ListChangedEventHandler(this.c_ResubmitHash);
      this.ActiveCrop.units = this.model.Units;
      this.model.SubmitCropRunoff(this.ActiveCrop, this.index);
      this.DisplayDates(((Crop) this.lstCrops.SelectedItem).arrCoefficients);
      if (this.ActiveCrop.CropName == "Alfalfa")
      {
        this.dgCoefficients.AllowUserToDeleteRows = true;
        this.btnAlf.Visible = true;
      }
      else
      {
        this.dgCoefficients.AllowUserToDeleteRows = false;
        this.btnAlf.Visible = false;
      }
      if (this.ActiveCrop.CropName == "Winter Wheat")
        this.lblwheat.Visible = true;
      else
        this.lblwheat.Visible = false;
      this.model.cCrops[this.index] = this.ActiveCrop;
      if (this.cIrrigation.Count > 0)
        this.ActiveCrop.cIrrigation = this.cIrrigation;
      this.LoadIrrigationEvents(this.ActiveCrop);
      this.LoadInputCosts(this.ActiveCrop);
      int index = 0;
      int num = 0;
      if (this.ActiveCrop.CropName == "Winter Wheat")
      {
        index = 2;
        num = 0;
      }
      this.dteIrrigStart.Value = Convert.ToDateTime(this.ActiveCrop.arrCoefficients[index].Date).AddYears(num);
      this.dteIrrigEnd.Value = Convert.ToDateTime(this.ActiveCrop.arrCoefficients[this.ActiveCrop.arrCoefficients.Count - 1].Date).AddYears(num);
      this.tcCrops.TabPages[1].Text = this.ActiveCrop.CropName + " - Irrigation Schedule";
      this.txtMaxYield.DataBindings.Clear();
      this.txtMaxYield.DataBindings.Add("Text", (object) this.ActiveCrop, "dblMaxYieldDisplay", true, DataSourceUpdateMode.OnPropertyChanged);
      this.txtGPM.DataBindings.Clear();
      this.txtGPM.DataBindings.Add("Text", (object) this.model, "gpm", true, DataSourceUpdateMode.OnPropertyChanged);
      this.txtPrice.DataBindings.Clear();
      this.txtPrice.DataBindings.Add("Text", (object) this.ActiveCrop, "price", true, DataSourceUpdateMode.OnPropertyChanged);
      this.lblMaxYield.Text = this.ActiveCrop.YieldUnits();
      this.lblPriceUnits.Text = "Rs/" + this.ActiveCrop.Units();
      this.txtAcres.DataBindings.Clear();
      this.txtAcres.DataBindings.Add("Text", (object) this.model, "Acres", true, DataSourceUpdateMode.OnPropertyChanged);
      this.lblTotalInches.Text = (this.model.Units == "english" ? (this.ActiveCrop.GetSumIrrigation() * (5.0 / (double) sbyte.MaxValue)).ToString("0.0") : this.ActiveCrop.GetSumIrrigation().ToString("0.0")) + " " + (this.model.Units == "english" ? "inches" : "mm");
      this.txtAcres2.DataBindings.Clear();
      this.txtAcres2.DataBindings.Add("Text", (object) this.model, "Acres", true, DataSourceUpdateMode.OnPropertyChanged);
      this.cboFuelType.DataBindings.Clear();
      this.cboFuelType.DataBindings.Add("Text", (object) this.model, "fueltype", true, DataSourceUpdateMode.OnPropertyChanged);
      this.txtFuelPrice.Text = this.model.fuelprice.ToString();
      this.checkBox1.DataBindings.Clear();
      this.checkBox1.DataBindings.Add("Checked", (object) this.ActiveCrop, "optimalN");
      this.checkBox2.DataBindings.Clear();
      this.checkBox2.DataBindings.Add("Checked", (object) this.ActiveCrop, "optimalP");
      this.checkBox3.DataBindings.Clear();
      this.checkBox3.DataBindings.Add("Checked", (object) this.ActiveCrop, "optimalSeed");
    }

    public void c_ResubmitHash(object sender, ListChangedEventArgs e)
    {
      this.lblTotalInches.Text = (this.model.Units == "english" ? (this.ActiveCrop.GetSumIrrigation() * (5.0 / (double) sbyte.MaxValue)).ToString("0.0") : this.ActiveCrop.GetSumIrrigation().ToString("0.0")) + " " + (this.model.Units == "english" ? "inches" : "mm");
      this.ActiveCrop.UpdateIrrigation();
    }

    public void DisplayDates(BindingList<Measurement> arrDates)
    {
      BindingSource bindingSource = new BindingSource();
      bindingSource.DataSource = (object) arrDates;
      this.dgCoefficients.Columns.Clear();
      this.dgCoefficients.DataSource = (object) bindingSource;
      this.dgCoefficients.Columns[0].DataPropertyName = "Label";
      this.dgCoefficients.Columns[0].HeaderText = "Growth Stage";
      this.dgCoefficients.Columns[1].DataPropertyName = "Date";
      this.dgCoefficients.Columns[1].HeaderText = "Date";
      this.dgCoefficients.Columns[2].Visible = false;
      this.dgCoefficients.Columns.RemoveAt(2);
    }

    public void LoadIrrigationEvents(Crop c)
    {
      this.dgIrrigation.Columns.Clear();
      BindingSource bindingSource = new BindingSource();
      this.ActiveCrop.cIrrigation_display.AllowNew = true;
      bindingSource.DataSource = (object) this.ActiveCrop.cIrrigation_display;
      this.dgIrrigation.AutoGenerateColumns = false;
      DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn1.DataPropertyName = "Date";
      DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn2.DataPropertyName = "Amount";
      this.dgIrrigation.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
      this.dgIrrigation.Columns.Add((DataGridViewColumn) viewTextBoxColumn2);
      this.dgIrrigation.DataSource = (object) bindingSource;
      this.SetLabels();
    }

    public void LoadInputCosts(Crop c)
    {
      try
      {
        this.cdgGeneralCosts.Columns.Clear();
        this.cdgOperationCosts.Columns.Clear();
        this.cdgReturns.Columns.Clear();
        this.cdgIrrigationCosts.Columns.Clear();
        this.cdgMiscCosts.Columns.Clear();
        this.cdgGeneralCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        this.cdgOperationCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        this.cdgReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        this.cdgIrrigationCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        this.cdgMiscCosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        BindingSource bindingSource1 = new BindingSource();
        BindingSource bindingSource2 = new BindingSource();
        BindingSource bindingSource3 = new BindingSource();
        BindingSource bindingSource4 = new BindingSource();
        BindingSource bindingSource5 = new BindingSource();
        this.ActiveCrop.cGeneralCosts.AllowNew = false;
        this.ActiveCrop.cReturns.AllowNew = false;
        this.ActiveCrop.cOperationCosts.AllowNew = false;
        this.ActiveCrop.cIrrigationCosts.AllowNew = false;
        this.ActiveCrop.cMiscCosts.AllowNew = false;
        bindingSource1.DataSource = (object) this.ActiveCrop.cGeneralCosts;
        bindingSource2.DataSource = (object) this.ActiveCrop.cOperationCosts;
        bindingSource3.DataSource = (object) this.ActiveCrop.cReturns;
        bindingSource4.DataSource = (object) this.ActiveCrop.cIrrigationCosts;
        bindingSource5.DataSource = (object) this.ActiveCrop.cMiscCosts;
        this.cdgGeneralCosts.AutoGenerateColumns = false;
        this.cdgOperationCosts.AutoGenerateColumns = false;
        this.cdgReturns.AutoGenerateColumns = false;
        this.cdgIrrigationCosts.AutoGenerateColumns = false;
        this.cdgMiscCosts.AutoGenerateColumns = false;
        DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn1.DataPropertyName = "LabelF";
        viewTextBoxColumn1.Width = 200;
        viewTextBoxColumn1.ReadOnly = true;
        DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn2.DataPropertyName = "LabelF";
        viewTextBoxColumn2.Width = 200;
        viewTextBoxColumn2.ReadOnly = true;
        DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn3.DataPropertyName = "LabelF";
        viewTextBoxColumn3.Width = 200;
        viewTextBoxColumn3.ReadOnly = true;
        DataGridViewTextBoxColumn viewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn4.DataPropertyName = "LabelF";
        viewTextBoxColumn4.Width = 200;
        viewTextBoxColumn4.ReadOnly = true;
        DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn5.DataPropertyName = "LabelF";
        viewTextBoxColumn5.Width = 200;
        viewTextBoxColumn5.ReadOnly = true;
        DataGridViewTextBoxColumn viewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn6.DataPropertyName = "AmountFormatted";
        viewTextBoxColumn6.Width = 100;
        DataGridViewTextBoxColumn viewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn7.DataPropertyName = "AmountFormatted";
        viewTextBoxColumn7.Width = 100;
        DataGridViewTextBoxColumn viewTextBoxColumn8 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn8.DataPropertyName = "AmountFormatted";
        viewTextBoxColumn8.Width = 100;
        DataGridViewTextBoxColumn viewTextBoxColumn9 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn9.DataPropertyName = "AmountFormatted";
        viewTextBoxColumn9.Width = 100;
        DataGridViewTextBoxColumn viewTextBoxColumn10 = new DataGridViewTextBoxColumn();
        viewTextBoxColumn10.DataPropertyName = "AmountFormatted";
        viewTextBoxColumn10.Width = 100;
        this.cdgGeneralCosts.Columns.Insert(0, (DataGridViewColumn) viewTextBoxColumn1);
        this.cdgGeneralCosts.Columns.Add((DataGridViewColumn) viewTextBoxColumn6);
        this.cdgOperationCosts.Columns.Add((DataGridViewColumn) viewTextBoxColumn2);
        this.cdgOperationCosts.Columns.Add((DataGridViewColumn) viewTextBoxColumn7);
        this.cdgReturns.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
        this.cdgReturns.Columns.Add((DataGridViewColumn) viewTextBoxColumn8);
        this.cdgIrrigationCosts.Columns.Add((DataGridViewColumn) viewTextBoxColumn4);
        this.cdgIrrigationCosts.Columns.Add((DataGridViewColumn) viewTextBoxColumn9);
        this.cdgMiscCosts.Columns.Add((DataGridViewColumn) viewTextBoxColumn5);
        this.cdgMiscCosts.Columns.Add((DataGridViewColumn) viewTextBoxColumn10);
        this.cdgGeneralCosts.DataSource = (object) bindingSource1;
        this.cdgOperationCosts.DataSource = (object) bindingSource2;
        this.cdgReturns.DataSource = (object) bindingSource3;
        this.cdgIrrigationCosts.DataSource = (object) bindingSource4;
        this.cdgMiscCosts.DataSource = (object) bindingSource5;
        this.SetLabels();
      }
      catch
      {
      }
    }

    public static string ParseNumbers(string str)
    {
      str = str.Trim();
      return new Regex("^[\\+\\-]?\\d*\\.?[Ee]?[\\+\\-]?\\d*$", RegexOptions.Compiled).Match(str).Value;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string[] strArray1 = Clipboard.GetText().Split('\n');
      int index1 = 0;
      int num1 = 0;
      int num2 = strArray1[strArray1.Length - 1] == "" ? 1 : 0;
      try
      {
        this.dgIrrigation.Rows.Clear();
        foreach (string str in strArray1)
        {
          if (!(str == ""))
          {
            string[] strArray2 = str.Split('\t');
            if (strArray2.Length == 2)
            {
              if (this.dgIrrigation.RowCount <= index1 + 1)
                this.ActiveCrop.cIrrigation_display.Add(new Measurement());
              for (int index2 = 0; index2 < 2; ++index2)
              {
                switch (index2)
                {
                  case 0:
                    strArray2[index2] = Convert.ToDateTime(strArray2[index2]).ToString("M/d");
                    break;
                  case 1:
                    strArray2[index2] = double.Parse(strArray2[index2]).ToString();
                    break;
                }
                this.dgIrrigation[num1 + index2, index1].Value = (object) strArray2[index2];
              }
              ++index1;
            }
            else
            {
              int num3 = (int) MessageBox.Show("Please make sure you've copied both date and irrigation amount values from Excel!", "2 Columns Required", MessageBoxButtons.OK);
              break;
            }
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = (int) MessageBox.Show("Invalid data.  Please make sure your data is valid before pasting." + ex.ToString(), "Error in Copied Data", MessageBoxButtons.OK);
      }
    }

    private void dgCosts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      try
      {
        DataGridView dataGridView = (DataGridView) sender;
        if (e.Value.ToString().Contains("  "))
        {
          dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
          dataGridView.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
          e.Value = (object) e.Value.ToString().Remove(0, 7);
        }
        else
        {
          int columnIndex = e.ColumnIndex;
        }
      }
      catch (Exception ex)
      {
      }
    }

    private double MaxInchPerDay(double gpm)
    {
      return gpm * 0.0530339859459937;
    }

    private void cmdAuto_Click(object sender, EventArgs e)
    {
    }

    private void tcCrops_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void dgIrrigation_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
    }

    private void dgIrrigation_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      int num = (int) MessageBox.Show("Please enter the data in the proper format - only numeric characters and valid date formats");
    }

    private void dgIrrigation_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
    {
    }

    private void dgIrrigation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex != 1 || e.RowIndex <= -1)
        return;
      double num = this.model.Units == "english" ? 2.0 / (this.model.dblEfficiency / 100.0) : 50.8 / (this.model.dblEfficiency / 100.0);
      if (Convert.ToDouble(this.dgIrrigation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) <= num)
        return;
      this.dgIrrigation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) Math.Round(num, 1);
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rbGPM.Checked)
      {
        this.lblAuto.Text = "Well capacity";
        this.lblAutoUnits.Text = "GPM";
      }
      else
      {
        this.lblAuto.Text = "Season Net Irrigation";
        this.lblAutoUnits.Text = this.model.Units == "metric" ? "mm" : "inches";
      }
    }

    private void groupBox8_Enter(object sender, EventArgs e)
    {
    }

    private void cmdAuto_Click_1(object sender, EventArgs e)
    {
      try
      {
        double num1 = 0.0;
        double num2 = 0.0;
        double num3 = Convert.ToDouble(this.txtAcres.Text);
        double num4 = this.model.Units == "metric" ? 5000.0 : 3000.0;
        if (num3 > num4 || num3 < 0.0)
        {
          int num5 = (int) MessageBox.Show((this.model.Units == "metric" ? "Hectares" : "Acres") + " must be between 0 and 3,000");
        }
        else
        {
          double num6 = this.model.Units == "metric" ? num3 * 2.47105381 : num3;
          double num7 = Convert.ToDouble(this.txtInchesPerApplication.Text);
          double num8 = this.model.Units == "metric" ? 1270.0 : 50.0;
          if (num7 > num8 || num7 < 0.0)
          {
            int num9 = (int) MessageBox.Show("Gross " + (this.model.Units == "metric" ? "Millimeters" : "Inches") + " Per Application must be between 0 and " + num8.ToString());
          }
          else
          {
            double num10 = this.model.Units == "metric" ? num7 * (5.0 / (double) sbyte.MaxValue) : num7;
            TimeSpan timeSpan = this.dteIrrigEnd.Value.Subtract(this.dteIrrigStart.Value);
            int days = timeSpan.Days;
            if (this.rbGPM.Checked)
            {
              num1 = Convert.ToDouble(this.txtAuto.Text);
              if (num1 > 3000.0 || num1 < 0.0)
              {
                int num11 = (int) MessageBox.Show("GPM must be between 0 and 3,000");
                return;
              }
              num2 = num1 * (double) days / 130.0 * 0.053 * 0.9;
            }
            if (this.rbNetIrrigation.Checked)
            {
              num2 = Convert.ToDouble(this.txtAuto.Text);
              num1 = num2 * num6 / (double) days * 18.8 / 0.9;
            }
            this.model.gpm = num1;
            double num12 = 2.0 / (this.model.dblEfficiency / 100.0);
            double num13 = num10 > num12 ? num12 : num10;
            double num14 = num1 * 60.0 * 21.6 / num6 / 27154.0;
            double num15 = 1.0 / (num14 * (1.0 / num13));
            double num16 = 1.0 / num14;
            double num17 = num13 * ((double) timeSpan.Days / num2);
            double num18 = (double) timeSpan.Days * (1.0 / num17);
            this.ActiveCrop.cIrrigation_display.Clear();
            DateTime dateTime = this.dteIrrigStart.Value;
            double num19 = this.model.Units == "metric" ? num13 * 25.4 : num13;
            for (int index = 0; (double) index < num18; ++index)
            {
              this.ActiveCrop.cIrrigation_display.Add(new Measurement((object) dateTime.ToString("M/d"), Math.Round(num19, 1)));
              dateTime = dateTime.AddDays(num17);
            }
            this.tabControl1.SelectedTab = this.tpIrrigationEntries;
            this.txtInchesPerApplication.Text = this.model.Units == "metric" ? (num19 / 25.4).ToString() : num19.ToString();
            this.ActiveCrop.UpdateIrrigation();
          }
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Sorry, please make sure all the data is accurate");
      }
    }

    private void rbGPM_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rbGPM.Checked)
      {
        this.lblAuto.Text = "Well capacity";
        this.lblAutoUnits.Text = "GPM";
      }
      else
      {
        this.lblAuto.Text = "Season Gross Irrigation";
        this.lblAutoUnits.Text = "inches";
      }
      this.txtAuto.Text = "";
    }

    private void rbNetIrrigation_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rbGPM.Checked)
      {
        this.lblAuto.Text = "Well capacity";
        this.lblAutoUnits.Text = "GPM";
      }
      else
      {
        this.lblAuto.Text = "Season Gross Irrigation";
        this.lblAutoUnits.Text = "inches";
      }
      this.txtAuto.Text = "";
    }

    private void ShowHelp(string url)
    {
      if (url == "")
        url = "index.htm";
      Help.ShowHelp((Control) this, this.hp.HelpNamespace, HelpNavigator.Topic, (object) url);
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#crop");
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#growthstage");
    }

    private void txtAuto_TextChanged(object sender, EventArgs e)
    {
    }

    private void dgCoefficients_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
    }

    private void dgCoefficients_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      if (e.Row.Index == 6)
        return;
      e.Cancel = true;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (this.dgCoefficients.Rows.Count == 7)
      {
        this.dgCoefficients.Rows.RemoveAt(this.dgCoefficients.Rows.Count - 1);
        this.btnAlf.Text = "Restore 5th Cutting";
      }
      else
      {
        this.ActiveCrop.arrCoefficients.Add(new Measurement()
        {
          Label = "5th cutting",
          Date = "10/28"
        });
        this.DisplayDates(this.ActiveCrop.arrCoefficients);
        this.btnAlf.Text = "Delete 5th Cutting";
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#irrigation_schedule");
    }

    private void txtInchesPerApplication_TextChanged(object sender, EventArgs e)
    {
    }

    private void CropInput_PaddingChanged(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("asdf");
    }

    private void label10_PaddingChanged(object sender, EventArgs e)
    {
    }

    private void CropInput_Paint(object sender, PaintEventArgs e)
    {
    }

    private void tcCrops_Validating(object sender, CancelEventArgs e)
    {
    }

    private void tpGeneral_Validating(object sender, CancelEventArgs e)
    {
    }

    private void tcCrops_Selected(object sender, TabControlEventArgs e)
    {
      if (e.TabPageIndex != 1)
        return;
      if (this.model.cCrops[this.index].CropName == null)
      {
        int num = (int) MessageBox.Show("Sorry, please select a crop before proceeding.");
        ((TabControl) sender).SelectedTab = this.tpGeneral;
      }
      else
      {
        double num1 = 400.0;
        switch (this.ActiveCrop.CropName.ToLower())
        {
          case "alfalfa":
            num1 = this.ActiveCrop.DisplayYield(20.0);
            break;
          case "corn":
            num1 = this.ActiveCrop.DisplayYield(400.0);
            break;
          case "grain sorghum":
            num1 = this.ActiveCrop.DisplayYield(300.0);
            break;
          case "sunflower":
            num1 = this.ActiveCrop.DisplayYield(5000.0);
            break;
          case "soybean":
            num1 = this.ActiveCrop.DisplayYield(100.0);
            break;
          case "winter wheat":
            num1 = this.ActiveCrop.DisplayYield(150.0);
            break;
        }
        if (this.ActiveCrop.dblMaxYield <= num1 && this.ActiveCrop.dblMaxYield > 0.0 || ((TabControl) sender).SelectedIndex <= 0)
          return;
        ((TabControl) sender).SelectedTab = this.tpGeneral;
        int num2 = (int) MessageBox.Show("Sorry, the maximum yield for " + this.ActiveCrop.CropName + " must not exceed " + (object) num1 + " " + this.ActiveCrop.YieldUnits() + ".");
      }
    }

    private void cboFuelType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.label18.Text = "Rs / " + this.model.fuelunits;
      this.txtFuelPrice.Text = "";
      this.model.fuelprice = 0.0;
      this.UpdateCost();
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      this.cdgGeneralCosts.Rows[0].Height = this.checkBox1.Checked ? 0 : this.cdgGeneralCosts.Rows[1].Height;
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      this.cdgGeneralCosts.Rows[2].Height = this.checkBox2.Checked ? 0 : this.cdgGeneralCosts.Rows[3].Height;
    }

    private void label19_Click(object sender, EventArgs e)
    {
    }

    private void cdgIrrigationCosts_DataSourceChanged(object sender, EventArgs e)
    {
      this.UpdateCost();
    }

    private void cdgIrrigationCosts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      this.UpdateCost();
    }

    private void UpdateCost()
    {
      this.lblIrrigCost.Text = "Rs" + this.ActiveCrop.IrrigationCost(this.model)[1].ToString("0.00") + "/acre-inch";
    }

    private void txtFuelPrice_TextChanged(object sender, EventArgs e)
    {
      try
      {
        this.model.fuelprice = Convert.ToDouble(this.txtFuelPrice.Text);
      }
      catch
      {
        this.model.fuelprice = 0.0;
      }
      this.UpdateCost();
    }

    private void txtFuelPrice_TextChanged_1(object sender, EventArgs e)
    {
      try
      {
        this.model.fuelprice = Convert.ToDouble(this.txtFuelPrice.Text);
      }
      catch
      {
        this.model.fuelprice = 0.0;
      }
      this.UpdateCost();
    }

    private void cboFuelType_SelectedValueChanged(object sender, EventArgs e)
    {
      this.UpdateCost();
    }

    private void txtFuelPrice_Validated(object sender, EventArgs e)
    {
      this.UpdateCost();
    }

    private void txtFuelPrice_Enter(object sender, EventArgs e)
    {
      try
      {
        this.model.fuelprice = Convert.ToDouble(this.txtFuelPrice.Text);
      }
      catch
      {
        this.model.fuelprice = 0.0;
      }
      this.UpdateCost();
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
      this.UpdateCost();
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      this.cdgGeneralCosts.Rows[4].Height = this.checkBox3.Checked ? 0 : this.cdgGeneralCosts.Rows[3].Height;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.cdgGeneralCosts.Columns[0].Width = 300;
    }

    private void button6_Click_1(object sender, EventArgs e)
    {
      this.CropAction();
    }

    private void dgCoefficients_VisibleChanged(object sender, EventArgs e)
    {
      if (this.dgCoefficients.Columns.Count <= 2)
        return;
      this.dgCoefficients.Columns.RemoveAt(this.dgCoefficients.Columns["Amount"].Index);
    }

    private void button6_Click_2(object sender, EventArgs e)
    {
      this.ShowHelp("inputs.htm#economicanalysis");
    }

    private void lblTotalInches_Click(object sender, EventArgs e)
    {
    }
  }
}
