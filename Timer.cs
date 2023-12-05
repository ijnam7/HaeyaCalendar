using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaeyaCalendar
{
    public partial class Timer : Form
    {
        int tmTimer = 0;        // 전체 시작 시간 기록

        int pTimer = 0;         // 해당 구간 타이머 (초)
        bool state = true;      // true: working // false: resting
        bool over = false;

        int recWorking = 0;     // 전체 working 시간 기록

        int setWorking = 0;     // 전체 working 시간 기록
        int setResting = 0;

        public Timer(string todoName, int w, int r)
        {
            InitializeComponent();

            gbSet.Text = todoName;

            setWorking = w;
            setResting = r * 60;

            lbTimer.Text = textTimer(0);

            tmRec.Start();
            timerState();
            tmRecStr.Start();
        }

        private string textTimer(int s)
        {
            return (s / 60).ToString() + "분 " + (s % 60).ToString() + "초";
        }

        private void timerState()           // 화면 상 상태 변화
        {
            if (state == true)
            {
                lbState.Text = "집중 중";
                btState.Text = "잠깐 쉬기";
            }
            else
            {
                lbState.Text = "쉬는 중";
                btState.Text = "다시 집중하기";
                recWorking += pTimer;
                lbRecWorking.Text = textTimer(recWorking);
            }
            pTimer = 0;
            lbTimer.Text = textTimer(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message(state);
        }

        private void message(bool wr)
        {
            string msg = "쉬시겠습니까?";
            string lb = "집중 끝";
            if (over == true)
            {
                lbTimer.ForeColor = Color.Red;
            }
            if (wr == false)
            {
                msg = "집중 하시겠습니까?";
                lb = "쉬는 시간 끝";
            }
            var result = MessageBox.Show(msg, lb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lbTimer.ForeColor = Color.Black;
                state = !state;
                over = false;
                timerState();
            }
        }

        private void tmRec_Tick_1(object sender, EventArgs e)
        {
            pTimer += 1;
            lbTimer.Text = textTimer(pTimer);

            if (state == true)
            {
                if (pTimer == setWorking) { over = true; message(state); }
            }
            else
            {
                if (pTimer == setResting) { over = true; message(state); }
            }
        }

        private void tmRecStr_Tick(object sender, EventArgs e)          // 전체 시간 타이머
        {
            tmTimer += 1;
            lbRecStr.Text = textTimer(tmTimer);
        }
    }
}
