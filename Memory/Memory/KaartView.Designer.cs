﻿namespace Memory
{
    partial class KaartView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaartView));
            this.Image1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Image1
            // 
            this.Image1.Image = ((System.Drawing.Image)(resources.GetObject("Image1.Image")));
            this.Image1.Location = new System.Drawing.Point(30, -37);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(412, 526);
            this.Image1.TabIndex = 0;
            this.Image1.Text = "label1";
            this.Image1.Click += new System.EventHandler(this.Image1_Click);
            // 
            // KaartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Image1);
            this.Name = "KaartView";
            this.Size = new System.Drawing.Size(445, 391);
            this.Load += new System.EventHandler(this.KaartView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Image1;
    }
}
