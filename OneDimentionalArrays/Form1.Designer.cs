
namespace OneDimentionalArrays
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDisplayArrayIndex = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnPassingMarks = new System.Windows.Forms.Button();
            this.BtnMathsAndFrench = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDisplayArrayIndex
            // 
            this.BtnDisplayArrayIndex.Location = new System.Drawing.Point(12, 12);
            this.BtnDisplayArrayIndex.Name = "BtnDisplayArrayIndex";
            this.BtnDisplayArrayIndex.Size = new System.Drawing.Size(148, 50);
            this.BtnDisplayArrayIndex.TabIndex = 0;
            this.BtnDisplayArrayIndex.Text = "Display Array Columns";
            this.BtnDisplayArrayIndex.UseVisualStyleBackColor = true;
            this.BtnDisplayArrayIndex.Click += new System.EventHandler(this.BtnDisplayArrayIndex_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(166, 12);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(265, 253);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnPassingMarks
            // 
            this.BtnPassingMarks.Location = new System.Drawing.Point(12, 68);
            this.BtnPassingMarks.Name = "BtnPassingMarks";
            this.BtnPassingMarks.Size = new System.Drawing.Size(148, 50);
            this.BtnPassingMarks.TabIndex = 2;
            this.BtnPassingMarks.Text = "View Passing Marks";
            this.BtnPassingMarks.UseVisualStyleBackColor = true;
            this.BtnPassingMarks.Click += new System.EventHandler(this.BtnPassingMarks_Click);
            // 
            // BtnMathsAndFrench
            // 
            this.BtnMathsAndFrench.Location = new System.Drawing.Point(12, 124);
            this.BtnMathsAndFrench.Name = "BtnMathsAndFrench";
            this.BtnMathsAndFrench.Size = new System.Drawing.Size(148, 49);
            this.BtnMathsAndFrench.TabIndex = 3;
            this.BtnMathsAndFrench.Text = "View Maths and French";
            this.BtnMathsAndFrench.UseVisualStyleBackColor = true;
            this.BtnMathsAndFrench.Click += new System.EventHandler(this.LoadInMathsAndFrench);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 86);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Maths and French Top Achievers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewTopAchieverTotal);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnMathsAndFrench);
            this.Controls.Add(this.BtnPassingMarks);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDisplayArrayIndex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplayArrayIndex;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnPassingMarks;
        private System.Windows.Forms.Button BtnMathsAndFrench;
        private System.Windows.Forms.Button button1;
    }
}

