namespace calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bSum = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbscreen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bDiv);
            this.groupBox1.Controls.Add(this.bMul);
            this.groupBox1.Controls.Add(this.bSub);
            this.groupBox1.Controls.Add(this.bSum);
            this.groupBox1.Controls.Add(this.bReset);
            this.groupBox1.Controls.Add(this.bEqual);
            this.groupBox1.Controls.Add(this.b0);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbscreen);
            this.groupBox1.Location = new System.Drawing.Point(35, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mini Räknare";
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.Location = new System.Drawing.Point(278, 144);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(62, 42);
            this.bDiv.TabIndex = 16;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bMul
            // 
            this.bMul.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMul.Location = new System.Drawing.Point(278, 84);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(62, 42);
            this.bMul.TabIndex = 15;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // bSub
            // 
            this.bSub.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSub.Location = new System.Drawing.Point(207, 144);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(54, 42);
            this.bSub.TabIndex = 14;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // bSum
            // 
            this.bSum.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSum.Location = new System.Drawing.Point(207, 84);
            this.bSum.Name = "bSum";
            this.bSum.Size = new System.Drawing.Size(54, 42);
            this.bSum.TabIndex = 13;
            this.bSum.Text = "+";
            this.bSum.UseVisualStyleBackColor = true;
            this.bSum.Click += new System.EventHandler(this.bSum_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(78, 260);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(95, 42);
            this.bReset.TabIndex = 12;
            this.bReset.Text = "C";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bEqual
            // 
            this.bEqual.Location = new System.Drawing.Point(207, 203);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(133, 42);
            this.bEqual.TabIndex = 11;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = true;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(23, 260);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(40, 42);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(133, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 42);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(78, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 42);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(133, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 42);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(78, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbscreen
            // 
            this.tbscreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbscreen.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbscreen.Location = new System.Drawing.Point(23, 19);
            this.tbscreen.Multiline = true;
            this.tbscreen.Name = "tbscreen";
            this.tbscreen.Size = new System.Drawing.Size(317, 44);
            this.tbscreen.TabIndex = 0;
            this.tbscreen.Text = "0";
            this.tbscreen.TextChanged += new System.EventHandler(this.tbscreen_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bSum;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbscreen;
    }
}

