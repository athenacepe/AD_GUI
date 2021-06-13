namespace A1_GUI_Athena
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
            this.UserInput1 = new System.Windows.Forms.TextBox();
            this.UserInput2 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.GetPrime = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserInput1
            // 
            this.UserInput1.Location = new System.Drawing.Point(190, 135);
            this.UserInput1.Name = "UserInput1";
            this.UserInput1.Size = new System.Drawing.Size(119, 22);
            this.UserInput1.TabIndex = 0;
            // 
            // UserInput2
            // 
            this.UserInput2.Location = new System.Drawing.Point(412, 135);
            this.UserInput2.Name = "UserInput2";
            this.UserInput2.Size = new System.Drawing.Size(119, 22);
            this.UserInput2.TabIndex = 1;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(191, 292);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(340, 135);
            this.Output.TabIndex = 2;
            // 
            // GetPrime
            // 
            this.GetPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPrime.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.GetPrime.Location = new System.Drawing.Point(206, 208);
            this.GetPrime.Name = "GetPrime";
            this.GetPrime.Size = new System.Drawing.Size(118, 47);
            this.GetPrime.TabIndex = 3;
            this.GetPrime.Text = "Get Prime";
            this.GetPrime.UseVisualStyleBackColor = true;
            this.GetPrime.Click += new System.EventHandler(this.GetPrime_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Reset.Location = new System.Drawing.Point(396, 208);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(118, 47);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(222, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(439, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(53, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(616, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Find the prime numbers between two numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(725, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.GetPrime);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.UserInput2);
            this.Controls.Add(this.UserInput1);
            this.Name = "Form1";
            this.Text = "Prime Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput1;
        private System.Windows.Forms.TextBox UserInput2;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button GetPrime;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

