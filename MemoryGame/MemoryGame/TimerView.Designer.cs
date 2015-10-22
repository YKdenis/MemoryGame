namespace MemoryGame
{
  partial class TimerView
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.labelTime = new System.Windows.Forms.Label();
      this.timerTime = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // labelTime
      // 
      this.labelTime.AutoSize = true;
      this.labelTime.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTime.ForeColor = System.Drawing.Color.DarkRed;
      this.labelTime.Location = new System.Drawing.Point(22, 23);
      this.labelTime.Name = "labelTime";
      this.labelTime.Size = new System.Drawing.Size(94, 43);
      this.labelTime.TabIndex = 0;
      this.labelTime.Text = "Timer:";
      // 
      // timerTime
      // 
      this.timerTime.AutoSize = true;
      this.timerTime.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timerTime.ForeColor = System.Drawing.Color.DarkRed;
      this.timerTime.Location = new System.Drawing.Point(109, 23);
      this.timerTime.Name = "timerTime";
      this.timerTime.Size = new System.Drawing.Size(51, 43);
      this.timerTime.TabIndex = 1;
      this.timerTime.Text = "40";
      this.timerTime.Click += new System.EventHandler(this.label1_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // TimerView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.timerTime);
      this.Controls.Add(this.labelTime);
      this.Name = "TimerView";
      this.Size = new System.Drawing.Size(207, 150);
      this.Load += new System.EventHandler(this.TimerView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelTime;
    private System.Windows.Forms.Label timerTime;
    private System.Windows.Forms.Timer timer1;
  }
}
