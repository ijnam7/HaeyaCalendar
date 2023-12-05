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
            lbDateToday.Text = dateToday.ToString();

            searchAll();
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
            ToDo td = new ToDo(tbTodoName.Text);
            coll.InsertOne(td);
            Timer timer = new Timer(tbTodoName.Text, working, resting);
            timer.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            gbTimer.Visible = checkBox1.Checked;
        }
    }
}
