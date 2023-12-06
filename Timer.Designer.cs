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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbSet = new System.Windows.Forms.GroupBox();
            this.lbSetResting = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSetWorking = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btState
            // 
            this.btState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btState.Font = new System.Drawing.Font("KoPubWorldDotum Bold", 9F);
            this.btState.ForeColor = System.Drawing.Color.SteelBlue;
            this.btState.Location = new System.Drawing.Point(34, 154);
            this.btState.Name = "btState";
            this.btState.Size = new System.Drawing.Size(209, 37);
            this.btState.TabIndex = 0;
            this.btState.Text = "잠깐 쉬기";
            this.btState.UseVisualStyleBackColor = true;
            this.btState.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("KoPubWorldDotum Bold", 9F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(34, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "끝내기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimer.Font = new System.Drawing.Font("KoPubWorldDotum Bold", 36F);
            this.lbTimer.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTimer.Location = new System.Drawing.Point(107, 86);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(155, 74);
            this.lbTimer.TabIndex = 3;
            this.lbTimer.Text = "nn:nn";
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
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "총 시작 시간";
            // 
            // lbRecStr
            // 
            this.lbRecStr.AutoSize = true;
            this.lbRecStr.Font = new System.Drawing.Font("KoPubWorldDotum Medium", 9F);
            this.lbRecStr.Location = new System.Drawing.Point(151, 41);
            this.lbRecStr.Name = "lbRecStr";
            this.lbRecStr.Size = new System.Drawing.Size(41, 19);
            this.lbRecStr.TabIndex = 9;
            this.lbRecStr.Text = "00:00";
            // 
            // tmRecStr
            // 
            this.tmRecStr.Interval = 1000;
            this.tmRecStr.Tick += new System.EventHandler(this.tmRecStr_Tick);
            // 
            // lbRecWorking
            // 
            this.lbRecWorking.AutoSize = true;
            this.lbRecWorking.Font = new System.Drawing.Font("KoPubWorldDotum Medium", 9F);
            this.lbRecWorking.Location = new System.Drawing.Point(151, 20);
            this.lbRecWorking.Name = "lbRecWorking";
            this.lbRecWorking.Size = new System.Drawing.Size(41, 19);
            this.lbRecWorking.TabIndex = 11;
            this.lbRecWorking.Text = "00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "총 집중 시간";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRecWorking);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbRecStr);
            this.groupBox1.Font = new System.Drawing.Font("KoPubWorldDotum Medium", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(34, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 69);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.BackColor = System.Drawing.Color.SteelBlue;
            this.lbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbState.Font = new System.Drawing.Font("KoPubWorldDotum Medium", 12F);
            this.lbState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbState.Location = new System.Drawing.Point(32, 31);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(59, 25);
            this.lbState.TabIndex = 20;
            this.lbState.Text = "집중 중";
            // 
            // lbName
            // 
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("KoPubWorldDotum Bold", 16F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbName.Location = new System.Drawing.Point(28, 54);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(212, 35);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "할 일 이름";
            // 
            // gbSet
            // 
            this.gbSet.Controls.Add(this.lbSetResting);
            this.gbSet.Controls.Add(this.label12);
            this.gbSet.Controls.Add(this.lbSetWorking);
            this.gbSet.Controls.Add(this.label4);
            this.gbSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSet.Font = new System.Drawing.Font("KoPubWorldDotum Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSet.ForeColor = System.Drawing.Color.DimGray;
            this.gbSet.Location = new System.Drawing.Point(34, 86);
            this.gbSet.Name = "gbSet";
            this.gbSet.Size = new System.Drawing.Size(65, 56);
            this.gbSet.TabIndex = 22;
            this.gbSet.TabStop = false;
            // 
            // lbSetResting
            // 
            this.lbSetResting.AutoSize = true;
            this.lbSetResting.Font = new System.Drawing.Font("KoPubWorldDotum Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSetResting.Location = new System.Drawing.Point(4, 33);
            this.lbSetResting.Name = "lbSetResting";
            this.lbSetResting.Size = new System.Drawing.Size(30, 17);
            this.lbSetResting.TabIndex = 16;
            this.lbSetResting.Text = "nn분";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("KoPubWorldDotum Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(33, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "집중";
            // 
            // lbSetWorking
            // 
            this.lbSetWorking.AutoSize = true;
            this.lbSetWorking.Font = new System.Drawing.Font("KoPubWorldDotum Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSetWorking.Location = new System.Drawing.Point(4, 15);
            this.lbSetWorking.Name = "lbSetWorking";
            this.lbSetWorking.Size = new System.Drawing.Size(30, 17);
            this.lbSetWorking.TabIndex = 14;
            this.lbSetWorking.Text = "nn분";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KoPubWorldDotum Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(33, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "휴식";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 342);
            this.Controls.Add(this.gbSet);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btState);
            this.Controls.Add(this.lbTimer);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbSet;
        private System.Windows.Forms.Label lbSetResting;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSetWorking;
        private System.Windows.Forms.Label label4;
    }
}