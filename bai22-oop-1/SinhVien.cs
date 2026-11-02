using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_oop_1
{
    public class SinhVien
    {
        private int maSV;
        private string tenSV;

        // Constructor
        public SinhVien()
        {
            maSV = 0;
            tenSV = "Chưa có tên";
        }
        public SinhVien(int maSV, string tenSV)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
        }

        // Properties
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
    }
}
