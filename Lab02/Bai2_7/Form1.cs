using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Bai2_7
{
    public partial class Form1 : Form
    {
        private int coolDownTime = 0;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void getCoolDownTime()
        {
            int hours, minutes, seconds;
            if (int.TryParse(tBHour.Text, out hours) && int.TryParse(tBMinute.Text, out minutes) && int.TryParse(tBSecond.Text, out seconds))
            {
                coolDownTime = hours * 3600 + minutes * 60 + seconds;
            }
        }

        private void Action()
        {
            if (cBAction.SelectedIndex == 0)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else if (cBAction.SelectedIndex == 1)
            {
                Process.Start("shutdown", "/r /t 0");
            }
            else if (cBAction.SelectedIndex == 2)
            {
                Process.Start("shutdown", "/l");
            }

        }

        void TimerOnTick(object obj, EventArgs ea)
        {
            Timer timer = (Timer)obj;
            if (coolDownTime > 0)
            {
                coolDownTime -= 1;
                int Hour = coolDownTime / 3600;
                int Minute = (coolDownTime % 3600) / 60;
                int Second = coolDownTime % 60;
                tBTimerCount.Text = Convert.ToString(Hour) + ":" + Convert.ToString(Minute) + ":" + Convert.ToString(Second);
            }
            else
            {
                timer.Stop();
                timer.Tick -= new EventHandler(TimerOnTick);
                Action();
            }

        }

        private void ActionTimer()
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Enabled = true;
            timer.Start();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            tBTimerCount.Text = "Timer Action cancel";
            timer.Tick -= new EventHandler(TimerOnTick);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            ActionTimer();
            getCoolDownTime();
        }
    }
}
