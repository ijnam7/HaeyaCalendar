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

            DateTime dateToday = DateTime.Now;
            lbDateToday.Text = dateToday.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddList addlist = new AddList();
            addlist.Show();
        }

        private void resetMainList ()
        {
            DataTable dtAll = new DataTable();

        }
    }
}
