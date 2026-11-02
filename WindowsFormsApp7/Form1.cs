using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnROLL_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblTien.Text) > 0)
            {
                Random rd = new Random();
                int sx1 = rd.Next(1, 7);
                int sx2 = rd.Next(1, 7);
                int sx3 = rd.Next(1, 7);

                lblSX1.Text = sx1 + "";
                lblSX2.Text = sx2 + "";
                lblSX3.Text = sx3 + "";

                lblTong.Text = sx1 + sx2 + sx3 + "";
                if (int.Parse(lblTong.Text) < 10)
                {
                    lblKQ.Text = "XIU";
                    if (radTAI.Checked)
                    {
                        lblTien.Text = int.Parse(lblTien.Text) - int.Parse(txtTienCuoc.Text) + "";
                        lblHienThiKQ.Text = "Ban da thua cuoc ! , bạn bị trừ : " + txtTienCuoc.Text + " VND";
                    }
                    else
                    {
                        lblTien.Text = int.Parse(lblTien.Text) + int.Parse(txtTienCuoc.Text) + "";
                        lblHienThiKQ.Text = "Ban da thang cuoc ! , ban duoc them :" + txtTienCuoc.Text + " VND";
                    }
                }
                else if (int.Parse(lblTong.Text) >= 10)
                {
                    lblKQ.Text = "TAI";
                    if (radTAI.Checked)
                    {
                        lblTien.Text = int.Parse(lblTien.Text) + int.Parse(txtTienCuoc.Text) + "";
                        lblHienThiKQ.Text = "Ban da thang cuoc ! , ban duoc them :" + txtTienCuoc.Text + " VND";
                    }
                    else
                    {
                        lblTien.Text = int.Parse(lblTien.Text) - int.Parse(txtTienCuoc.Text) + "";
                        lblHienThiKQ.Text = "Ban da thua cuoc ! , bạn bị trừ : " + txtTienCuoc.Text + " VND";
                    }
                }
            }
            else
            {
                errorProvider1.SetError(lblTien, "Vui long nap them tien");
            }





        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSoTienConLai_Click(object sender, EventArgs e)
        {
            int money = 100000;
        }

        private void txtTienCuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTien_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radTAI.Checked = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
