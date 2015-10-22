﻿namespace MemoryGame
{
  partial class ScoreView
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
      this.labelScore = new System.Windows.Forms.Label();
      this.tellerScore = new System.Windows.Forms.Label();
      this.labelHighscore = new System.Windows.Forms.Label();
      this.tellerHighscore = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelScore
      // 
      this.labelScore.AutoSize = true;
      this.labelScore.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelScore.Location = new System.Drawing.Point(17, 20);
      this.labelScore.Name = "labelScore";
      this.labelScore.Size = new System.Drawing.Size(93, 43);
      this.labelScore.TabIndex = 0;
      this.labelScore.Text = "Score:";
      this.labelScore.Click += new System.EventHandler(this.label1_Click);
      // 
      // tellerScore
      // 
      this.tellerScore.AutoSize = true;
      this.tellerScore.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tellerScore.Location = new System.Drawing.Point(105, 20);
      this.tellerScore.Name = "tellerScore";
      this.tellerScore.Size = new System.Drawing.Size(35, 43);
      this.tellerScore.TabIndex = 1;
      this.tellerScore.Text = "0";
      // 
      // labelHighscore
      // 
      this.labelHighscore.AutoSize = true;
      this.labelHighscore.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelHighscore.Location = new System.Drawing.Point(17, 63);
      this.labelHighscore.Name = "labelHighscore";
      this.labelHighscore.Size = new System.Drawing.Size(138, 43);
      this.labelHighscore.TabIndex = 2;
      this.labelHighscore.Text = "Highscore:";
      // 
      // tellerHighscore
      // 
      this.tellerHighscore.AutoSize = true;
      this.tellerHighscore.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tellerHighscore.Location = new System.Drawing.Point(151, 63);
      this.tellerHighscore.Name = "tellerHighscore";
      this.tellerHighscore.Size = new System.Drawing.Size(35, 43);
      this.tellerHighscore.TabIndex = 3;
      this.tellerHighscore.Text = "0";
      // 
      // ScoreView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tellerHighscore);
      this.Controls.Add(this.labelHighscore);
      this.Controls.Add(this.tellerScore);
      this.Controls.Add(this.labelScore);
      this.Name = "ScoreView";
      this.Size = new System.Drawing.Size(245, 131);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelScore;
    private System.Windows.Forms.Label tellerScore;
    private System.Windows.Forms.Label labelHighscore;
    private System.Windows.Forms.Label tellerHighscore;
  }
}
