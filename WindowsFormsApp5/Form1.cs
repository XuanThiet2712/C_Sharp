using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0; 
            for(int i = 0; i < lstDanhSachSo.Items.Count; i++)
            {
                int x = (int)lstDanhSachSo.Items[i];
                sum += x;
            }

            MessageBox.Show("Tổng các số được chọn là: " + sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            int so; 
            if(int.TryParse(txtNhapSo.Text , out so ) == false)
                errorProvider1.SetError(txtNhapSo, "Vui lòng nhập số nguyên");
            else
                lstDanhSachSo.Items.Add(so);
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstDanhSachSo.Items.RemoveAt(0);
            lstDanhSachSo.Items.RemoveAt(lstDanhSachSo.Items.Count - 1);
        }

        private void lstDanhSachSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (int i in lstDanhSachSo.SelectedIndices)
            {
                lstDanhSachSo.Items.RemoveAt(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstDanhSachSo.Items.Count; i++)
            {
                lstDanhSachSo.Items[i] = (int)lstDanhSachSo.Items[i] + 2; 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstDanhSachSo.Items.Count; i++)
            {
               lstDanhSachSo.Items[i] = (int)lstDanhSachSo.Items[i] * (int)lstDanhSachSo.Items[i];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // chojn so chan
            for(int i = 0; i < lstDanhSachSo.Items.Count; i++)
            {
                if((int)lstDanhSachSo.Items[i] % 2 == 0)
                    lstDanhSachSo.SetSelected(i, true);
                else
                    lstDanhSachSo.SetSelected(i, false);
                //lstDanhSachSo.SetSelected(i, (int)lstDanhSachSo.Items[i] % 2 == 0);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDanhSachSo.Items.Count; i++)
            {
                if ((int)lstDanhSachSo.Items[i] % 2 != 0)
                    lstDanhSachSo.SetSelected(i, true);
                else
                    lstDanhSachSo.SetSelected(i, false);
                //lstDanhSachSo.SetSelected(i, (int)lstDanhSachSo.Items[i] % 2 == 0);
            }
        }

        private void txtNhapSo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
