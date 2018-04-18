
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CWY
{
  public class ResultLine : UserControl
  {
    private IContainer components;
    private Label lblResult;
    private Label lblTitle;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblResult = new Label();
      this.lblTitle = new Label();
      this.SuspendLayout();
      this.lblResult.AutoSize = true;
      this.lblResult.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblResult.ForeColor = Color.DodgerBlue;
      this.lblResult.Location = new Point(165, 1);
      this.lblResult.Margin = new Padding(4, 0, 4, 0);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new Size(18, 16);
      this.lblResult.TabIndex = 4;
      this.lblResult.Text = "--";
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblTitle.Location = new Point(4, 1);
      this.lblTitle.Margin = new Padding(4, 0, 4, 0);
      this.lblTitle.MaximumSize = new Size(160, 0);
      this.lblTitle.MinimumSize = new Size(160, 16);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new Size(160, 16);
      this.lblTitle.TabIndex = 3;
      this.lblTitle.Text = "Crop Season";
      this.lblTitle.TextAlign = ContentAlignment.TopRight;
      this.AutoScaleDimensions = new SizeF(8f, 18f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = Color.White;
      this.Controls.Add((Control) this.lblResult);
      this.Controls.Add((Control) this.lblTitle);
      this.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Margin = new Padding(0);
      this.MaximumSize = new Size(260, 0);
      this.MinimumSize = new Size(260, 21);
      this.Name = nameof (ResultLine);
      this.Size = new Size(260, 21);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public ResultLine(string title, string resultvalue)
    {
      this.InitializeComponent();
      this.lblTitle.Text = title;
      this.lblResult.Text = resultvalue;
    }
  }
}
