namespace WindowsFormsApp7
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSX1 = new System.Windows.Forms.Label();
            this.lblSX2 = new System.Windows.Forms.Label();
            this.lblSX3 = new System.Windows.Forms.Label();
            this.btnROLL = new System.Windows.Forms.Button();
            this.txtTienCuoc = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoTienConLai = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radXIU = new System.Windows.Forms.RadioButton();
            this.radTAI = new System.Windows.Forms.RadioButton();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblHienThiKQ = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(341, 156);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblSX1
            // 
            this.lblSX1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSX1.Location = new System.Drawing.Point(196, 87);
            this.lblSX1.Name = "lblSX1";
            this.lblSX1.Size = new System.Drawing.Size(90, 140);
            this.lblSX1.TabIndex = 0;
            this.lblSX1.Text = "7";
            this.lblSX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSX2
            // 
            this.lblSX2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSX2.Location = new System.Drawing.Point(317, 87);
            this.lblSX2.Name = "lblSX2";
            this.lblSX2.Size = new System.Drawing.Size(90, 140);
            this.lblSX2.TabIndex = 1;
            this.lblSX2.Text = "7";
            this.lblSX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSX3
            // 
            this.lblSX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblSX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSX3.Location = new System.Drawing.Point(438, 87);
            this.lblSX3.Name = "lblSX3";
            this.lblSX3.Size = new System.Drawing.Size(90, 140);
            this.lblSX3.TabIndex = 2;
            this.lblSX3.Text = "7";
            this.lblSX3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSX3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnROLL
            // 
            this.btnROLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnROLL.Location = new System.Drawing.Point(518, 230);
            this.btnROLL.Name = "btnROLL";
            this.btnROLL.Size = new System.Drawing.Size(132, 45);
            this.btnROLL.TabIndex = 2;
            this.btnROLL.Text = "PLAY";
            this.btnROLL.UseVisualStyleBackColor = true;
            this.btnROLL.Click += new System.EventHandler(this.btnROLL_Click);
            // 
            // txtTienCuoc
            // 
            this.txtTienCuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCuoc.Location = new System.Drawing.Point(216, 251);
            this.txtTienCuoc.Name = "txtTienCuoc";
            this.txtTienCuoc.Size = new System.Drawing.Size(253, 27);
            this.txtTienCuoc.TabIndex = 5;
            this.txtTienCuoc.TextChanged += new System.EventHandler(this.txtTienCuoc_TextChanged);
            // 
            // lblKQ
            // 
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(592, 71);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(163, 156);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "KQ";
            this.lblKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTong
            // 
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(29, 71);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(123, 144);
            this.lblTong.TabIndex = 7;
            this.lblTong.Text = "0";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTong.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập tiền cược : ";
            // 
            // lblSoTienConLai
            // 
            this.lblSoTienConLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoTienConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienConLai.Location = new System.Drawing.Point(371, 286);
            this.lblSoTienConLai.Name = "lblSoTienConLai";
            this.lblSoTienConLai.Size = new System.Drawing.Size(173, 20);
            this.lblSoTienConLai.TabIndex = 9;
            this.lblSoTienConLai.Text = "Số tiền còn lại : ";
            this.lblSoTienConLai.Click += new System.EventHandler(this.lblSoTienConLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radXIU);
            this.groupBox1.Controls.Add(this.radTAI);
            this.groupBox1.Location = new System.Drawing.Point(47, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOICE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radXIU
            // 
            this.radXIU.AutoSize = true;
            this.radXIU.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radXIU.Location = new System.Drawing.Point(169, 47);
            this.radXIU.Name = "radXIU";
            this.radXIU.Size = new System.Drawing.Size(110, 50);
            this.radXIU.TabIndex = 1;
            this.radXIU.TabStop = true;
            this.radXIU.Text = "XỈU";
            this.radXIU.UseVisualStyleBackColor = true;
            // 
            // radTAI
            // 
            this.radTAI.AutoSize = true;
            this.radTAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTAI.Location = new System.Drawing.Point(23, 47);
            this.radTAI.Name = "radTAI";
            this.radTAI.Size = new System.Drawing.Size(105, 50);
            this.radTAI.TabIndex = 0;
            this.radTAI.TabStop = true;
            this.radTAI.Text = "TÀI";
            this.radTAI.UseVisualStyleBackColor = true;
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(550, 277);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(100, 36);
            this.lblTien.TabIndex = 11;
            this.lblTien.Text = "10000";
            this.lblTien.Click += new System.EventHandler(this.lblTien_Click);
            // 
            // lblHienThiKQ
            // 
            this.lblHienThiKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiKQ.Location = new System.Drawing.Point(402, 340);
            this.lblHienThiKQ.Name = "lblHienThiKQ";
            this.lblHienThiKQ.Size = new System.Drawing.Size(291, 103);
            this.lblHienThiKQ.TabIndex = 12;
            this.lblHienThiKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(656, 233);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 45);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 466);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblHienThiKQ);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSoTienConLai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtTienCuoc);
            this.Controls.Add(this.lblSX1);
            this.Controls.Add(this.btnROLL);
            this.Controls.Add(this.lblSX2);
            this.Controls.Add(this.lblSX3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSX1;
        private System.Windows.Forms.Label lblSX2;
        private System.Windows.Forms.Label lblSX3;
        private System.Windows.Forms.Button btnROLL;
        private System.Windows.Forms.TextBox txtTienCuoc;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoTienConLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radXIU;
        private System.Windows.Forms.RadioButton radTAI;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblHienThiKQ;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStop;
    }
}

