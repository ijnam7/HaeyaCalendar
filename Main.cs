using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace HaeyaCalendar
{
    public partial class Main : Form
    {
        MongoClient client = new MongoClient();
        IMongoDatabase db;
        IMongoCollection<ToDo> coll;

        public Main()
        {
            InitializeComponent();
            
            db = client.GetDatabase("HY");
            coll = db.GetCollection<ToDo>("todos");

            DateTime dateToday = DateTime.Today;
            lbDateToday.Text = dateToday.ToString("d");

            DataTable dt = new DataTable();
            dt.Columns.Add("날짜");
            dt.Columns.Add("시간");
            dt.Rows.Add();

            dateFilter(dateToday.ToString("d"));
        }

        private void searchAll()
        {
            List<ToDo> todoList = coll.AsQueryable().ToList<ToDo>();
            dgvAll.DataSource = todoList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int working = Convert.ToInt32(nWorking.Value);
            int resting = Convert.ToInt32(nResting.Value);
            Timer timer = new Timer(tbTodoName.Text, working, resting, checkBox1.Checked);
            timer.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            gbTimer.Visible = checkBox1.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnDel.Visible = true;
            searchAll();
        }
        private string textTimer(int s)
        {
            string lh = "00" + (s / 3600).ToString();
            string lm = "00" + (s%3600/60).ToString();
            string ls = "00" + (s%60).ToString();
            return string.Format("{0}:{1}:{2}", lh.Substring(lh.Length-2), lm.Substring(lm.Length - 2), ls.Substring(ls.Length - 2));
        }

        private void dateFilter(string date)
        {
            DataTable dtSel = new DataTable();
            dtSel.Columns.Add("한일");
            dtSel.Columns.Add("집중 시간");

            var filter = Builders<ToDo>.Filter.Eq("date", date);
            List<ToDo> todoList = coll.Find<ToDo>(filter).ToList();
            for (int i = 0; i < todoList.Count; i++)
            {
                DataRow row = dtSel.NewRow();
                row["한일"] = todoList[i].name;
                row["집중 시간"] = textTimer(todoList[i].time);
                dtSel.Rows.Add(row);
            }
            dgvAll.DataSource = dtSel;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            btnDel.Visible = false;
            dateFilter(dateTimePicker1.Value.ToString("d"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvAll.CurrentCell.RowIndex;
            ObjectId id = (ObjectId)dgvAll.Rows[rowIndex].Cells[0].Value;
            var filter = Builders<ToDo>.Filter.Eq("_id", id);
            coll.DeleteOne(filter);
            searchAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form addList = new AddList();
            addList.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnDel.Visible=false;
            dateTimePicker1.Value = DateTime.Today;
            dateFilter(DateTime.Today.ToString("d"));
        }
    }
}
