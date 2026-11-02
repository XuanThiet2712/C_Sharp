using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load event triggered");
        }

   

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            int tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " + " + txtB.Text + " = " + tong;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (exit == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Bạn đã chọn không thoát",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            int hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
            txtA.Text = "";
            txtB.Text = "";
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cl = MessageBox.Show(
                "Ban chac chan muon thoat",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if(cl == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
}
