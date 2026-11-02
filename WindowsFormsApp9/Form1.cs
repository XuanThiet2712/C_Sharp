using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        double tien = 20000;
        
        int count = 1;
        double numberWin = 0; 
        double numberLose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDice1.Text = rd.Next(1, 7).ToString();
            lblDice2.Text = rd.Next(1, 7).ToString();
            lblDice3.Text = rd.Next(1, 7).ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblCountDown.Text = "5";
            timer1.Start();
            timer2.Start();
            if (tien < int.Parse(txtCuoc.Text))
            {
                MessageBox.Show("Bạn không đủ tiền để đặt cược!");
                timer1.Stop();
                return;
            }
            if (string.IsNullOrEmpty(txtCuoc.Text) || !int.TryParse(txtCuoc.Text, out int cuoc) || cuoc <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền cược hợp lệ!");
                timer1.Stop();
                return;
            }
          
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tiềm năng của bạn là vô hạn, bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            radTai.Checked = true;
        }

        private void txtCuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double tienCuoc = Math.Round(double.Parse(txtCuoc.Text) );
            lblCountDown.Text = (int.Parse(lblCountDown.Text) - 1).ToString();
            if (lblCountDown.Text == "0")
            {
                timer1.Stop();
                timer2.Stop();
                int tong = int.Parse(lblDice1.Text) + int.Parse(lblDice2.Text) + int.Parse(lblDice3.Text);
                lstLichSu.Items.Add(count + ".  " + tong + " - " + (radTai.Checked ? "Tài" : "Xỉu") + " - " + ((radTai.Checked && tong >= 10) ? ("Win    +") : "Lose   -") +  tienCuoc  +"    "+ "(" + lblDice1.Text + lblDice2.Text + lblDice3.Text + ")");
                if (tong >= 10 && radTai.Checked)
                {
                    tien += tienCuoc;
                    MessageBox.Show("Bạn đã thắng! Số tiền hiện tại: " + tien);
                    numberWin++;
                }
                else if (tong < 10 && radXiu.Checked)
                {
                    tien += tienCuoc;
                    MessageBox.Show("Bạn đã thắng! Số tiền hiện tại: " + tien);
                    numberWin++;
                }
                else
                {
                    tien -= tienCuoc;
                    MessageBox.Show("Bạn đã thua! Số tiền hiện tại: " + tien);
                    numberLose++;
                }
                txtTien.Text = tien.ToString();

                lblWin.Text = "WIN : " + numberWin.ToString();
                lblLose.Text = "LOSE : " + numberLose.ToString();
                if (numberLose == 0)
                {
                    lblTiLe.Text = "100%";
                }
                else
                {
                    double tile = numberWin / count * 100;
                    lblTiLe.Text = (Math.Round(tile,2)).ToString() + "%";
                }
                count++;

            }
        }

        private void radTai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
