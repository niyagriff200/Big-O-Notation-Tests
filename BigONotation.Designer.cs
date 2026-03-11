namespace Big_O_Notation_Tests
{
    partial class BigONotation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerate = new Button();
            btnLinear = new Button();
            btnBinary = new Button();
            btnMerge = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(79, 109);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(268, 58);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate Data";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnLinear
            // 
            btnLinear.Location = new Point(79, 282);
            btnLinear.Name = "btnLinear";
            btnLinear.Size = new Size(268, 58);
            btnLinear.TabIndex = 1;
            btnLinear.Text = "Run Linear Search";
            btnLinear.UseVisualStyleBackColor = true;
            btnLinear.Click += btnLinear_Click;
            // 
            // btnBinary
            // 
            btnBinary.Location = new Point(79, 376);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(268, 58);
            btnBinary.TabIndex = 2;
            btnBinary.Text = "Run Binary Search";
            btnBinary.UseVisualStyleBackColor = true;
            btnBinary.Click += btnBinary_Click;
            // 
            // btnMerge
            // 
            btnMerge.Location = new Point(79, 196);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(268, 58);
            btnMerge.TabIndex = 3;
            btnMerge.Text = "Run Merge Sort";
            btnMerge.UseVisualStyleBackColor = true;
            btnMerge.Click += btnMerge_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(471, 109);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(677, 345);
            txtResults.TabIndex = 4;
            // 
            // BigONotation
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 529);
            Controls.Add(txtResults);
            Controls.Add(btnMerge);
            Controls.Add(btnBinary);
            Controls.Add(btnLinear);
            Controls.Add(btnGenerate);
            Name = "BigONotation";
            Text = "Big O Notation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Button btnLinear;
        private Button btnBinary;
        private Button btnMerge;
        private TextBox txtResults;
    }
}
