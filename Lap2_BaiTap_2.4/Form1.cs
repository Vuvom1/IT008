using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_2._4
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Vẽ chuỗi "Paint Event" tại một vị trí x, y ngẫu nhiên
            int x = random.Next(this.Width);
            int y = random.Next(this.Height);
            g.DrawString("Paint Event", new Font("Arial", 20), Brushes.Black, x, y);
        }
    }
}
