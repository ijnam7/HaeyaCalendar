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
using MongoDB.Driver;
using MongoDB.Bson;

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

        string todoName;


        MongoClient client = new MongoClient();
        IMongoDatabase db;
        IMongoCollection<ToDo> coll;

        public Timer(string t, int w, int r, bool c)
        {
            InitializeComponent();

            db = client.GetDatabase("HY");
            coll = db.GetCollection<ToDo>("todos");

            if (c == false ) { gbSet.Visible = c; }
            else { lbSetWorking.Text = w.ToString(); lbSetResting.Text = r.ToString(); }

            todoName = t;
            lbName.Text = todoName;
            lbRecWorking.Text = textTimer(recWorking);

            setWorking = w * 60;
            setResting = r * 60;

            lbTimer.Text = textTimer(0);

            tmRec.Start();
            timerState();
            tmRecStr.Start();
        }

        private string textTimer(int s)
        {
            string lm = "00" + (s / 60).ToString();
            string ls = "00" + (s % 60).ToString();
            return string.Format("{0}:{1}", lm.Substring(lm.Length-2), ls.Substring(ls.Length-2));
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
            if (state == true) { message("stop"); }
            else { message("continue"); }
        }

        private void message(string select)
        {
            string msg = "쉬시겠습니까?";
            string lb = "집중 끝";
            if (over == true)
            {
                lbTimer.ForeColor = Color.Red;
            }
            if (select == "continue")
            {
                msg = "집중하시겠습니까?";
                lb = "쉬는 시간 끝";
            }
            else if (select == "end")
            {
                msg = "끝내시겠습니까?";
                lb = "타이머 종료";
            }
            var result = MessageBox.Show(msg, lb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                state = !state;
                if (select == "end")
                {
                    timerState();
                    ToDo td = new ToDo(DateTime.Today, todoName, recWorking);
                    coll.InsertOne(td);
                    this.Close();
                }
                if (over)
                {
                    lbTimer.ForeColor = Color.Black;
                    over = false;
                }
                timerState();
            }
        }

        private void tmRec_Tick_1(object sender, EventArgs e)
        {
            pTimer += 1;
            lbTimer.Text = textTimer(pTimer);

            if (state == true)
            {
                if (pTimer == setWorking) { over = true; message("stop"); }
            }
            else
            {
                if (pTimer == setResting) { over = true; message("continue"); }
            }
        }

        private void tmRecStr_Tick(object sender, EventArgs e)          // 전체 시간 타이머
        {
            tmTimer += 1;
            lbRecStr.Text = textTimer(tmTimer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            message("end");
        }
    }
}
