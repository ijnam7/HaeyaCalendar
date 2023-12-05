namespace HaeyaCalendar
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDateToday = new System.Windows.Forms.Label();
            this.nWorking = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nResting = new System.Windows.Forms.NumericUpDown();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTodoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTimer = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nWorking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nResting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.gbTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDateToday
            // 
            this.lbDateToday.AutoSize = true;
            this.lbDateToday.Location = new System.Drawing.Point(27, 43);
            this.lbDateToday.Name = "lbDateToday";
            this.lbDateToday.Size = new System.Drawing.Size(29, 12);
            this.lbDateToday.TabIndex = 2;
            this.lbDateToday.Text = "날짜";
            // 
            // nWorking
            // 
            this.nWorking.Location = new System.Drawing.Point(15, 31);
            this.nWorking.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWorking.Name = "nWorking";
            this.nWorking.Size = new System.Drawing.Size(72, 21);
            this.nWorking.TabIndex = 5;
            this.nWorking.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 117);
            this.button1.TabIndex = 10;
            this.button1.Text = "시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "집중 시간";
            // 
            // nResting
            // 
            this.nResting.Location = new System.Drawing.Point(97, 31);
            this.nResting.Name = "nResting";
            this.nResting.Size = new System.Drawing.Size(72, 21);
            this.nResting.TabIndex = 13;
            this.nResting.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // dgvAll
            // 
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deadline,
            this.name,
            this.state});
            this.dgvAll.Location = new System.Drawing.Point(336, 43);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.RowHeadersWidth = 62;
            this.dgvAll.RowTemplate.Height = 23;
            this.dgvAll.Size = new System.Drawing.Size(471, 381);
            this.dgvAll.TabIndex = 14;
            // 
            // deadline
            // 
            this.deadline.HeaderText = "마감일";
            this.deadline.MinimumWidth = 8;
            this.deadline.Name = "deadline";
            this.deadline.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "일정";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // state
            // 
            this.state.HeaderText = "상태";
            this.state.MinimumWidth = 8;
            this.state.Name = "state";
            this.state.Width = 150;
            // 
            // tbTodoName
            // 
            this.tbTodoName.Location = new System.Drawing.Point(26, 82);
            this.tbTodoName.Multiline = true;
            this.tbTodoName.Name = "tbTodoName";
            this.tbTodoName.Size = new System.Drawing.Size(200, 22);
            this.tbTodoName.TabIndex = 16;
            this.tbTodoName.Text = "새로운 할일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "쉬는 시간";
            // 
            // gbTimer
            // 
            this.gbTimer.Controls.Add(this.label1);
            this.gbTimer.Controls.Add(this.nWorking);
            this.gbTimer.Controls.Add(this.label12);
            this.gbTimer.Controls.Add(this.nResting);
            this.gbTimer.Location = new System.Drawing.Point(26, 131);
            this.gbTimer.Name = "gbTimer";
            this.gbTimer.Size = new System.Drawing.Size(200, 68);
            this.gbTimer.TabIndex = 20;
            this.gbTimer.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(32, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "시간 설정";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 436);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gbTimer);
            this.Controls.Add(this.tbTodoName);
            this.Controls.Add(this.dgvAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDateToday);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nWorking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nResting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.gbTimer.ResumeLayout(false);
            this.gbTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDateToday;
        private System.Windows.Forms.NumericUpDown nWorking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nResting;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.TextBox tbTodoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTimer;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

