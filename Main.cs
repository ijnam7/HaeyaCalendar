using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaeyaCalendar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            DateTime dateToday = DateTime.Today;
            lbDateToday.Text = dateToday.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int working = Convert.ToInt32(nWorking.Value);
            int resting = Convert.ToInt32(nResting.Value);
            Timer timer = new Timer(tbTodoName.Text, working, resting);
            timer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddList addlist = new AddList();
            addlist.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            gbTimer.Visible = checkBox1.Checked;
        }
    }
}
