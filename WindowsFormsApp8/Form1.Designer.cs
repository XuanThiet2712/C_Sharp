namespace WindowsFormsApp8
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
            this.components = new System.ComponentModel.Container();
            this.dice1 = new System.Windows.Forms.Panel();
            this.dice3 = new System.Windows.Forms.Panel();
            this.dice2 = new System.Windows.Forms.Panel();
            this.panelBat = new System.Windows.Forms.Panel();
            this.btnLac = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelBat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dice1
            // 
            this.dice1.Location = new System.Drawing.Point(36, 54);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(57, 49);
            this.dice1.TabIndex = 0;
            this.dice1.Paint += new System.Windows.Forms.PaintEventHandler(this.dice1_Paint);
            // 
            // dice3
            // 
            this.dice3.Location = new System.Drawing.Point(171, 54);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(57, 49);
            this.dice3.TabIndex = 1;
            this.dice3.Paint += new System.Windows.Forms.PaintEventHandler(this.dice3_Paint);
            // 
            // dice2
            // 
            this.dice2.Location = new System.Drawing.Point(108, 6);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(57, 49);
            this.dice2.TabIndex = 1;
            this.dice2.Paint += new System.Windows.Forms.PaintEventHandler(this.dice2_Paint);
            // 
            // panelBat
            // 
            this.panelBat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBat.Controls.Add(this.dice3);
            this.panelBat.Controls.Add(this.dice2);
            this.panelBat.Controls.Add(this.dice1);
            this.panelBat.Location = new System.Drawing.Point(95, 37);
            this.panelBat.Name = "panelBat";
            this.panelBat.Size = new System.Drawing.Size(278, 127);
            this.panelBat.TabIndex = 2;
            this.panelBat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBat_Paint);
            // 
            // btnLac
            // 
            this.btnLac.Location = new System.Drawing.Point(40, 202);
            this.btnLac.Name = "btnLac";
            this.btnLac.Size = new System.Drawing.Size(91, 67);
            this.btnLac.TabIndex = 3;
            this.btnLac.Text = "button1";
            this.btnLac.UseVisualStyleBackColor = true;
            this.btnLac.Click += new System.EventHandler(this.btnLac_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(234, 211);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(10, 16);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "t";
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerLac_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.TimerMoBat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 310);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnLac);
            this.Controls.Add(this.panelBat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel dice1;
        private System.Windows.Forms.Panel dice3;
        private System.Windows.Forms.Panel dice2;
        private System.Windows.Forms.Panel panelBat;
        private System.Windows.Forms.Button btnLac;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

