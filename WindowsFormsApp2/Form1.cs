using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutPut.Text = txtInput.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblOutPut.ForeColor = radRed.ForeColor;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblOutPut.ForeColor = radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblOutPut.ForeColor = radBlue.ForeColor;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblOutPut.ForeColor = radBlack.ForeColor;
            }
        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
                lblOutPut.Font = new Font(
                    lblOutPut.Font.Name,
                    lblOutPut.Font.Size,
                    lblOutPut.Font.Style^FontStyle.Bold);   
        }

        private void chkInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblOutPut.Font = new Font(
                    lblOutPut.Font.Name,
                    lblOutPut.Font.Size,
                    lblOutPut.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblOutPut.Font = new Font(
                    lblOutPut.Font.Name,
                    lblOutPut.Font.Size,
                    lblOutPut.Font.Style ^ FontStyle.Underline);
        }

        private void grbCheckBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radCanhTrai.Checked)
            lblOutPut.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radCanhPhai_CheckedChanged(object sender, EventArgs e)
        {
            if(radCanhPhai.Checked)
            lblOutPut.TextAlign = ContentAlignment.MiddleRight;
        }

        private void radCanhGiua_CheckedChanged(object sender, EventArgs e)
        {
            if(radCanhGiua.Checked)
            lblOutPut.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
