using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp3
{

    public partial class Form1: Form
    {
        private SoundPlayer choiNhac;
        public Form1()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer(@"C:\\Users\\USER\\Downloads\\pic-nang-ta\\nhactap.wav");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!picNangTa.Visible ) // dang ha ta
            {
                btnClick.Text = txtName.Text + "! Click để nâng tạ đi";
            }
            else
            {
                btnClick.Text = txtName.Text + "! Click để hạ tạ đi";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (!picNangTa.Visible) // dang ha ta
            {
                picNangTa.Visible = true;
                picHaTa.Visible = false;
                btnClick.Text = btnClick.Text.Replace("nâng", "hạ");
                lblCount.Text = int.Parse(lblCount.Text) + 1 + "";
            }
            else
            {
                picNangTa.Visible = false;
                picHaTa.Visible = true;
                btnClick.Text = btnClick.Text.Replace("hạ", "nâng");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHaTa.Visible = true;
            picNangTa.Visible = false;
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMusic.Checked)
            {
                choiNhac.Play();
            }
            else
            {
                choiNhac.Stop();
            }
        }
    }
}
