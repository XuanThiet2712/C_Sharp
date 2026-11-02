using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int so;
            bool check = true;
            errorProvider1.Clear();
            if(txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Vui lòng nhập số điện thoại");
                check = false; 
            }
            else if(txtPhone.Text[0] != '0')
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải bắt đầu bằng số 0");
                check = false;
            }
            else if (txtPhone.Text.Length != 10)
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải có 10 chữ số");
                check = false;
            }
            else if (int.TryParse(txtPhone.Text, out so) == false)
            {
                errorProvider1.SetError(txtPhone, "Vui lòng nhập số điện thoại hợp lệ");
                check = false;
            }

            if(txtAge.Text == "")
            {
                errorProvider1.SetError(txtAge, "Vui lòng nhập tuổi");
                check = false;
            }
            else if (int.TryParse(txtAge.Text, out so) == false)
            {
                errorProvider1.SetError(txtAge, "Vui lòng nhập tuổi hợp lệ");
                check = false;
            }
            else if (int.Parse(txtAge.Text) < 18)
            {
                errorProvider1.SetError(txtAge, "Tuổi phải lớn hơn hoặc bằng 18");
                check = false;
            }
            else if (int.Parse(txtAge.Text) > 100)
            {
                errorProvider1.SetError(txtAge, "Tuổi phải nhỏ hơn hoặc bằng 100");
                check = false;
            }

            if(dtpDangKy.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpDangKy, "Ngày đăng ký không được lớn hơn ngày hiện tại");
                check = false;
            }
            else if (dtpDangKy.Value.DayOfWeek == DayOfWeek.Monday)
            if (check)
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại, vui lòng kiểm tra lại thông tin");

            }

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
