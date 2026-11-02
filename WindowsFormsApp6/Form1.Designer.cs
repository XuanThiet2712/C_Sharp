namespace WindowsFormsApp6
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
            this.chklbLeft = new System.Windows.Forms.CheckedListBox();
            this.chklbRight = new System.Windows.Forms.CheckedListBox();
            this.btnR = new System.Windows.Forms.Button();
            this.btnRR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbLeft
            // 
            this.chklbLeft.FormattingEnabled = true;
            this.chklbLeft.Items.AddRange(new object[] {
            "Xuyên tường",
            "Chống giật",
            "Aim Bot",
            "Nhảy cao"});
            this.chklbLeft.Location = new System.Drawing.Point(66, 60);
            this.chklbLeft.Name = "chklbLeft";
            this.chklbLeft.Size = new System.Drawing.Size(191, 208);
            this.chklbLeft.TabIndex = 0;
            this.chklbLeft.SelectedIndexChanged += new System.EventHandler(this.chklbLeft_SelectedIndexChanged);
            // 
            // chklbRight
            // 
            this.chklbRight.FormattingEnabled = true;
            this.chklbRight.Location = new System.Drawing.Point(418, 60);
            this.chklbRight.Name = "chklbRight";
            this.chklbRight.Size = new System.Drawing.Size(191, 208);
            this.chklbRight.TabIndex = 1;
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(269, 63);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(134, 32);
            this.btnR.TabIndex = 2;
            this.btnR.Text = ">";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnRR
            // 
            this.btnRR.Location = new System.Drawing.Point(269, 117);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(134, 32);
            this.btnRR.TabIndex = 3;
            this.btnRR.Text = ">>";
            this.btnRR.UseVisualStyleBackColor = true;
            this.btnRR.Click += new System.EventHandler(this.btnRR_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(269, 171);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(134, 32);
            this.btnL.TabIndex = 4;
            this.btnL.Text = "<";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(269, 225);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(134, 32);
            this.btnLL.TabIndex = 5;
            this.btnLL.Text = "<<";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 327);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnRR);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.chklbRight);
            this.Controls.Add(this.chklbLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbLeft;
        private System.Windows.Forms.CheckedListBox chklbRight;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnRR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnLL;
    }
}

