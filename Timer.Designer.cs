namespace HaeyaCalendar
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            this.btState = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.tmRec = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecStr = new System.Windows.Forms.Label();
            this.tmRecStr = new System.Windows.Forms.Timer(this.components);
            this.lbRecWorking = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSet = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btState
            // 
            this.btState.Location = new System.Drawing.Point(34, 143);
            this.btState.Name = "btState";
            this.btState.Size = new System.Drawing.Size(209, 37);
            this.btState.TabIndex = 0;
            this.btState.Text = "잠깐 쉬기";
            this.btState.UseVisualStyleBackColor = true;
            this.btState.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "끝내기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTimer.Location = new System.Drawing.Point(115, 91);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(127, 32);
            this.lbTimer.TabIndex = 3;
            this.lbTimer.Text = "n분 n초";
            // 
            // tmRec
            // 
            this.tmRec.Interval = 1000;
            this.tmRec.Tick += new System.EventHandler(this.tmRec_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "총 시작 시간";
            // 
            // lbRecStr
            // 
            this.lbRecStr.AutoSize = true;
            this.lbRecStr.Location = new System.Drawing.Point(151, 41);
            this.lbRecStr.Name = "lbRecStr";
            this.lbRecStr.Size = new System.Drawing.Size(47, 12);
            this.lbRecStr.TabIndex = 9;
            this.lbRecStr.Text = "n분 n초";
            // 
            // tmRecStr
            // 
            this.tmRecStr.Interval = 1000;
            this.tmRecStr.Tick += new System.EventHandler(this.tmRecStr_Tick);
            // 
            // lbRecWorking
            // 
            this.lbRecWorking.AutoSize = true;
            this.lbRecWorking.Location = new System.Drawing.Point(151, 20);
            this.lbRecWorking.Name = "lbRecWorking";
            this.lbRecWorking.Size = new System.Drawing.Size(47, 12);
            this.lbRecWorking.TabIndex = 11;
            this.lbRecWorking.Text = "n분 n초";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "총 집중 시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "nn분";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "쉼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "nn분";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRecWorking);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbRecStr);
            this.groupBox1.Location = new System.Drawing.Point(34, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 64);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // gbSet
            // 
            this.gbSet.Controls.Add(this.label5);
            this.gbSet.Controls.Add(this.label12);
            this.gbSet.Controls.Add(this.label2);
            this.gbSet.Controls.Add(this.label4);
            this.gbSet.Location = new System.Drawing.Point(34, 25);
            this.gbSet.Name = "gbSet";
            this.gbSet.Size = new System.Drawing.Size(209, 44);
            this.gbSet.TabIndex = 12;
            this.gbSet.TabStop = false;
            this.gbSet.Text = "할 일 제목";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "집중";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Gulim", 10F);
            this.lbState.Location = new System.Drawing.Point(31, 109);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(54, 14);
            this.lbState.TabIndex = 20;
            this.lbState.Text = "집중 중";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 310);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.gbSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btState);
            this.Name = "Timer";
            this.Text = "Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSet.ResumeLayout(false);
            this.gbSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btState;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer tmRec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmRecStr;
        private System.Windows.Forms.Label lbRecWorking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRecStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbState;
    }
}