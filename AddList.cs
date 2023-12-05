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

    public partial class AddList : Form
    {
        MongoClient client = new MongoClient();
        IMongoDatabase db;
        IMongoCollection<ToDo> coll;
        public AddList()
        {
            InitializeComponent();

            db = client.GetDatabase("HY");
            coll = db.GetCollection<ToDo>("todos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;

            int timeM = Convert.ToInt32(numTime.Value);

            ToDo td = new ToDo(dateTimePicker1.Value, name, timeM*60);
            coll.InsertOne(td);

            this.Close();
        }
    }
}
