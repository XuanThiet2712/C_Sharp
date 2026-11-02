using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1: Form
    {
        private Random rnd = new Random();
        private Timer timerLac;      // timer để lắc (đổi số liên tục)
        private Timer timerMoBat;    // timer để animate nhấc bát lên
        private int[] giaTri = new int[3];
        private int demLac = 0;
        private const int SoLanLac = 15;   // số lần đổi mặt xúc xắc trước khi dừng
        private int viTriGocBat;           // vị trí Top ban đầu của bát

        public Form1()
        {
            InitializeComponent();
            

            viTriGocBat = panelBat.Top;

            // Vẽ chấm xúc xắc mỗi khi Panel được vẽ lại
            dice1.Paint += (s, e) => VeXucXac(e.Graphics, dice1.Size, giaTri[0]);
            dice2.Paint += (s, e) => VeXucXac(e.Graphics, dice2.Size, giaTri[1]);
            dice3.Paint += (s, e) => VeXucXac(e.Graphics, dice3.Size, giaTri[2]);

            panelBat.BackColor = Color.Firebrick;
            lblKetQua.Text = "";

            btnLac.Click += btnLac_Click;

            // Timer lắc: cứ mỗi 80ms đổi số ngẫu nhiên 1 lần
            timerLac = new Timer { Interval = 80 };
            timerLac.Tick += TimerLac_Tick;

            // Timer nhấc bát: di chuyển bát lên trên dần dần
            timerMoBat = new Timer { Interval = 15 };
            timerMoBat.Tick += TimerMoBat_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void btnLac_Click(object sender, EventArgs e)
        {
            btnLac.Enabled = false;
            lblKetQua.Text = "";
            panelBat.Top = viTriGocBat;   // đưa bát về đúng vị trí che ban đầu
            panelBat.Visible = true;
            demLac = 0;
            timerLac.Start();
        }

        private void dice1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dice2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dice3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBat_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void TimerLac_Tick(object sender, EventArgs e)
        {
            giaTri[0] = rnd.Next(1, 7);
            giaTri[1] = rnd.Next(1, 7);
            giaTri[2] = rnd.Next(1, 7);
            dice1.Invalidate();
            dice2.Invalidate();
            dice3.Invalidate();

            demLac++;
            if (demLac >= SoLanLac)
            {
                timerLac.Stop();
                timerMoBat.Start();   // bắt đầu animate nhấc bát lên
            }
        }
        private void HienThiKetQua()
        {
            int tong = giaTri[0] + giaTri[1] + giaTri[2];
            bool laTai = tong >= 11;

            lblKetQua.Text = $"Tổng: {tong}  ->  {(laTai ? "TÀI" : "XỈU")}";
            lblKetQua.ForeColor = laTai ? Color.Green : Color.Blue;
        }

        private void TimerMoBat_Tick(object sender, EventArgs e)
        {
            panelBat.Top -= 8;  // mỗi lần nhấc lên 8px

            if (panelBat.Top <= viTriGocBat - 150)  // đủ xa thì dừng animate
            {
                timerMoBat.Stop();
                panelBat.Visible = false;
                HienThiKetQua();
                btnLac.Enabled = true;
            }
        }
        private void VeXucXac(Graphics g, Size kichThuoc, int soChamHienTai)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, kichThuoc.Width - 1, kichThuoc.Height - 1);

            if (soChamHienTai < 1) return;

            int w = kichThuoc.Width, h = kichThuoc.Height;
            int r = 6; // bán kính chấm
            Brush b = Brushes.Black;

            Point tam = new Point(w / 2, h / 2);
            Point traTren = new Point(w / 4, h / 4);
            Point phaiTren = new Point(3 * w / 4, h / 4);
            Point traDuoi = new Point(w / 4, 3 * h / 4);
            Point phaiDuoi = new Point(3 * w / 4, 3 * h / 4);
            Point traGiua = new Point(w / 4, h / 2);
            Point phaiGiua = new Point(3 * w / 4, h / 2);

            void Cham(Point p) => g.FillEllipse(b, p.X - r, p.Y - r, r * 2, r * 2);

            switch (soChamHienTai)
            {
                case 1: Cham(tam); break;
                case 2: Cham(traTren); Cham(phaiDuoi); break;
                case 3: Cham(traTren); Cham(tam); Cham(phaiDuoi); break;
                case 4: Cham(traTren); Cham(phaiTren); Cham(traDuoi); Cham(phaiDuoi); break;
                case 5: Cham(traTren); Cham(phaiTren); Cham(tam); Cham(traDuoi); Cham(phaiDuoi); break;
                case 6: Cham(traTren); Cham(phaiTren); Cham(traGiua); Cham(phaiGiua); Cham(traDuoi); Cham(phaiDuoi); break;
            }
        }
    }
}
