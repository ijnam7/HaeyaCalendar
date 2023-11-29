﻿using System;
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
    public partial class AddList : Form
    {
        public AddList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime deadline = dateTimePicker1.Value;
            string name = tbName.Text;

            new ToDo(deadline, name);

            this.Close();
        }
    }
}
