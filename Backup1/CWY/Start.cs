// Decompiled with JetBrains decompiler
// Type: CWY.Start
// Assembly: KSWB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99F4CEBB-9EF3-4B2B-95A0-A11E98E61BA0
// Assembly location: C:\Program Files (x86)\CYP\KSWB.exe

using KSWB.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CWY
{
  public class Start : Form
  {
    private IContainer components;
    private PictureBox pictureBox1;
    private Button button1;
    private Label label1;
    private Button button2;
    private Panel panel1;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label6;
    private HelpProvider hp;
    private Label label7;
    private LinkLabel linkLabel1;

    public Start()
    {
      this.InitializeComponent();
      this.linkLabel1.Links.Clear();
      this.linkLabel1.Links.Add(0, this.linkLabel1.Text.Length, (object) "http://www.agmanager.info");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      new frmMain().Show();
      this.Hide();
    }

    private void ShowHelp(string url)
    {
      if (url == "")
        url = "index.htm";
      Help.ShowHelp((Control) this, this.hp.HelpNamespace, HelpNavigator.Topic, (object) url);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.ShowHelp("");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Start));
      this.pictureBox1 = new PictureBox();
      this.button1 = new Button();
      this.label1 = new Label();
      this.button2 = new Button();
      this.panel1 = new Panel();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.hp = new HelpProvider();
      this.label7 = new Label();
      this.linkLabel1 = new LinkLabel();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.pictureBox1.BackColor = Color.Transparent;
      this.pictureBox1.Image = (Image) Resources.cypaboutpng;
      this.pictureBox1.Location = new Point(6, 7);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(242, 80);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.button1.Location = new Point(273, 169);
      this.button1.Name = "button1";
      this.button1.Size = new Size(141, 33);
      this.button1.TabIndex = 1;
      this.button1.Text = "Operating Instructions";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.BackColor = Color.White;
      this.label1.BorderStyle = BorderStyle.FixedSingle;
      this.label1.Location = new Point(12, 95);
      this.label1.Name = "label1";
      this.label1.Padding = new Padding(4);
      this.label1.Size = new Size(393, 65);
      this.label1.TabIndex = 2;
      this.label1.Text = componentResourceManager.GetString("label1.Text");
      this.button2.Location = new Point(12, 169);
      this.button2.Name = "button2";
      this.button2.Size = new Size(236, 33);
      this.button2.TabIndex = 3;
      this.button2.Text = "Start Crop Yield Predictor";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.panel1.BackColor = Color.White;
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Location = new Point(12, 291);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(392, 78);
      this.panel1.TabIndex = 4;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(78, 55);
      this.label6.Name = "label6";
      this.label6.Size = new Size(166, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "620-276-8286  nklocke@ksu.edu";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(78, 39);
      this.label5.Name = "label5";
      this.label5.Size = new Size(180, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "Kansas State University, Garden City";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(78, 22);
      this.label4.Name = "label4";
      this.label4.Size = new Size(245, 15);
      this.label4.TabIndex = 1;
      this.label4.Text = "Norman Klocke, Water Resources Engineer";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(3, 4);
      this.label3.Name = "label3";
      this.label3.Size = new Size(83, 18);
      this.label3.TabIndex = 0;
      this.label3.Text = "Contact Us";
      this.label2.BackColor = Color.White;
      this.label2.BorderStyle = BorderStyle.FixedSingle;
      this.label2.Location = new Point(12, 214);
      this.label2.Name = "label2";
      this.label2.Padding = new Padding(4);
      this.label2.Size = new Size(393, 39);
      this.label2.TabIndex = 6;
      this.label2.Text = "The Crop Yield Predictor was developed by Kansas State University faculty in the Department of Agronomy and the Southwest Research-Extension Center";
      this.hp.HelpNamespace = "CYP.chm";
      this.label7.BackColor = Color.White;
      this.label7.BorderStyle = BorderStyle.FixedSingle;
      this.label7.Location = new Point(12, 258);
      this.label7.Name = "label7";
      this.label7.Padding = new Padding(4);
      this.label7.Size = new Size(393, 26);
      this.label7.TabIndex = 7;
      this.label7.Text = "For additional tools, visit";
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.BackColor = Color.White;
      this.linkLabel1.Location = new Point(134, 263);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(82, 13);
      this.linkLabel1.TabIndex = 8;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "AgManager.info";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) Resources.wheatbg;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.ClientSize = new Size(417, 385);
      this.Controls.Add((Control) this.linkLabel1);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Start);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Welcome to Crop Yield Predictor";
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
