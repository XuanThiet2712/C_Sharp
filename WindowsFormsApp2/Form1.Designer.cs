namespace WindowsFormsApp2
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grbRadioButton = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grbCheckBox = new System.Windows.Forms.GroupBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkInNghieng = new System.Windows.Forms.CheckBox();
            this.chkInDam = new System.Windows.Forms.CheckBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCanhTrai = new System.Windows.Forms.RadioButton();
            this.radCanhPhai = new System.Windows.Forms.RadioButton();
            this.radCanhGiua = new System.Windows.Forms.RadioButton();
            this.grbRadioButton.SuspendLayout();
            this.grbCheckBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.Color.Cyan;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(38, 30);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(228, 25);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Nhập văn bản tại đây  ";
            this.lblInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(279, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(474, 30);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // grbRadioButton
            // 
            this.grbRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbRadioButton.Controls.Add(this.radBlack);
            this.grbRadioButton.Controls.Add(this.radBlue);
            this.grbRadioButton.Controls.Add(this.radGreen);
            this.grbRadioButton.Controls.Add(this.radRed);
            this.grbRadioButton.Location = new System.Drawing.Point(41, 79);
            this.grbRadioButton.Name = "grbRadioButton";
            this.grbRadioButton.Size = new System.Drawing.Size(332, 160);
            this.grbRadioButton.TabIndex = 2;
            this.grbRadioButton.TabStop = false;
            this.grbRadioButton.Text = "Color";
            this.grbRadioButton.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(23, 123);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(77, 24);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(23, 89);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(68, 24);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(23, 55);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(81, 24);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(23, 21);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(63, 24);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // grbCheckBox
            // 
            this.grbCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbCheckBox.Controls.Add(this.chkGachChan);
            this.grbCheckBox.Controls.Add(this.chkInNghieng);
            this.grbCheckBox.Controls.Add(this.chkInDam);
            this.grbCheckBox.Location = new System.Drawing.Point(421, 79);
            this.grbCheckBox.Name = "grbCheckBox";
            this.grbCheckBox.Size = new System.Drawing.Size(332, 160);
            this.grbCheckBox.TabIndex = 3;
            this.grbCheckBox.TabStop = false;
            this.grbCheckBox.Text = "Font chữ";
            this.grbCheckBox.Enter += new System.EventHandler(this.grbCheckBox_Enter);
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.Location = new System.Drawing.Point(20, 113);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(198, 24);
            this.chkGachChan.TabIndex = 2;
            this.chkGachChan.Text = "Gạch chân (Underline)";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.chkGachChan_CheckedChanged);
            // 
            // chkInNghieng
            // 
            this.chkInNghieng.AutoSize = true;
            this.chkInNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInNghieng.Location = new System.Drawing.Point(20, 74);
            this.chkInNghieng.Name = "chkInNghieng";
            this.chkInNghieng.Size = new System.Drawing.Size(157, 24);
            this.chkInNghieng.TabIndex = 1;
            this.chkInNghieng.Text = "In nghiêng (Italic)";
            this.chkInNghieng.UseVisualStyleBackColor = true;
            this.chkInNghieng.CheckedChanged += new System.EventHandler(this.chkInNghieng_CheckedChanged);
            // 
            // chkInDam
            // 
            this.chkInDam.AutoSize = true;
            this.chkInDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInDam.Location = new System.Drawing.Point(20, 35);
            this.chkInDam.Name = "chkInDam";
            this.chkInDam.Size = new System.Drawing.Size(143, 24);
            this.chkInDam.TabIndex = 0;
            this.chkInDam.Text = "In đậm (Bold)";
            this.chkInDam.UseVisualStyleBackColor = true;
            this.chkInDam.CheckedChanged += new System.EventHandler(this.chkInDam_CheckedChanged);
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(41, 270);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(109, 29);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.Text = "Hiển thị ";
            // 
            // lblOutPut
            // 
            this.lblOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPut.Location = new System.Drawing.Point(156, 265);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(483, 41);
            this.lblOutPut.TabIndex = 5;
            this.lblOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(654, 265);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.radCanhGiua);
            this.groupBox1.Controls.Add(this.radCanhPhai);
            this.groupBox1.Controls.Add(this.radCanhTrai);
            this.groupBox1.Location = new System.Drawing.Point(780, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canh leef";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // radCanhTrai
            // 
            this.radCanhTrai.AutoSize = true;
            this.radCanhTrai.Location = new System.Drawing.Point(21, 38);
            this.radCanhTrai.Name = "radCanhTrai";
            this.radCanhTrai.Size = new System.Drawing.Size(80, 20);
            this.radCanhTrai.TabIndex = 0;
            this.radCanhTrai.TabStop = true;
            this.radCanhTrai.Text = "Canh trái";
            this.radCanhTrai.UseVisualStyleBackColor = true;
            this.radCanhTrai.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radCanhPhai
            // 
            this.radCanhPhai.AutoSize = true;
            this.radCanhPhai.Location = new System.Drawing.Point(21, 74);
            this.radCanhPhai.Name = "radCanhPhai";
            this.radCanhPhai.Size = new System.Drawing.Size(88, 20);
            this.radCanhPhai.TabIndex = 1;
            this.radCanhPhai.TabStop = true;
            this.radCanhPhai.Text = "Canh phải";
            this.radCanhPhai.UseVisualStyleBackColor = true;
            this.radCanhPhai.CheckedChanged += new System.EventHandler(this.radCanhPhai_CheckedChanged);
            // 
            // radCanhGiua
            // 
            this.radCanhGiua.AutoSize = true;
            this.radCanhGiua.Location = new System.Drawing.Point(22, 117);
            this.radCanhGiua.Name = "radCanhGiua";
            this.radCanhGiua.Size = new System.Drawing.Size(86, 20);
            this.radCanhGiua.TabIndex = 2;
            this.radCanhGiua.TabStop = true;
            this.radCanhGiua.Text = "canh giữa";
            this.radCanhGiua.UseVisualStyleBackColor = true;
            this.radCanhGiua.CheckedChanged += new System.EventHandler(this.radCanhGiua_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.grbCheckBox);
            this.Controls.Add(this.grbRadioButton);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbRadioButton.ResumeLayout(false);
            this.grbRadioButton.PerformLayout();
            this.grbCheckBox.ResumeLayout(false);
            this.grbCheckBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grbRadioButton;
        private System.Windows.Forms.GroupBox grbCheckBox;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkInNghieng;
        private System.Windows.Forms.CheckBox chkInDam;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCanhGiua;
        private System.Windows.Forms.RadioButton radCanhPhai;
        private System.Windows.Forms.RadioButton radCanhTrai;
    }
}

