namespace Pomodoro_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCounter = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.endTime1 = new System.Windows.Forms.Label();
            this.endtime2 = new System.Windows.Forms.Label();
            this.endtime3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorLabel = new System.Windows.Forms.Label();
            this.timerCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.musicLabel = new System.Windows.Forms.Label();
            this.musicSelect = new System.Windows.Forms.ComboBox();
            this.musicBtn_start = new System.Windows.Forms.Button();
            this.musicBtn_stop = new System.Windows.Forms.Button();
            this.facebook_checkbox = new System.Windows.Forms.CheckBox();
            this.instagram_checkbox = new System.Windows.Forms.CheckBox();
            this.wykop_checkbox = new System.Windows.Forms.CheckBox();
            this.youtube_checkbox = new System.Windows.Forms.CheckBox();
            this.blockWebsites_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chatGPT_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCounter.Location = new System.Drawing.Point(305, 173);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(81, 42);
            this.lbCounter.TabIndex = 0;
            this.lbCounter.Text = "000";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Coral;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(240, 321);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.counter.Location = new System.Drawing.Point(312, 256);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(127, 30);
            this.counter.TabIndex = 2;
            this.counter.Text = "55";
            this.counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(289, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(380, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "seconds";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // endTime1
            // 
            this.endTime1.AutoSize = true;
            this.endTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endTime1.Location = new System.Drawing.Point(236, 396);
            this.endTime1.Name = "endTime1";
            this.endTime1.Size = new System.Drawing.Size(78, 20);
            this.endTime1.TabIndex = 5;
            this.endTime1.Text = "endTime:";
            // 
            // endtime2
            // 
            this.endtime2.AutoSize = true;
            this.endtime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endtime2.Location = new System.Drawing.Point(393, 396);
            this.endtime2.Name = "endtime2";
            this.endtime2.Size = new System.Drawing.Size(0, 20);
            this.endtime2.TabIndex = 6;
            // 
            // endtime3
            // 
            this.endtime3.AutoSize = true;
            this.endtime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endtime3.ForeColor = System.Drawing.Color.Coral;
            this.endtime3.Location = new System.Drawing.Point(320, 396);
            this.endtime3.Name = "endtime3";
            this.endtime3.Size = new System.Drawing.Size(0, 20);
            this.endtime3.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(39, 536);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "End of work notification";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 581);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 28);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 14, 15, 15, 0, 0);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.errorLabel.Location = new System.Drawing.Point(282, 38);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Padding = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.errorLabel.Size = new System.Drawing.Size(203, 29);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "An error occurred";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            this.errorLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // timerCheckbox
            // 
            this.timerCheckbox.AutoSize = true;
            this.timerCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timerCheckbox.Location = new System.Drawing.Point(467, 536);
            this.timerCheckbox.Name = "timerCheckbox";
            this.timerCheckbox.Size = new System.Drawing.Size(226, 24);
            this.timerCheckbox.TabIndex = 11;
            this.timerCheckbox.Text = "Show timer after minimize";
            this.timerCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(251, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customization:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Coral;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(384, 321);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(127, 47);
            this.btn_Stop.TabIndex = 14;
            this.btn_Stop.Text = "Pause";
            this.btn_Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.musicLabel.Location = new System.Drawing.Point(463, 640);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(54, 20);
            this.musicLabel.TabIndex = 15;
            this.musicLabel.Text = "Music";
            // 
            // musicSelect
            // 
            this.musicSelect.FormattingEnabled = true;
            this.musicSelect.Items.AddRange(new object[] {
            "Jazz",
            "Lo-Fi",
            "Chill"});
            this.musicSelect.Location = new System.Drawing.Point(467, 681);
            this.musicSelect.Name = "musicSelect";
            this.musicSelect.Size = new System.Drawing.Size(226, 24);
            this.musicSelect.TabIndex = 16;
            // 
            // musicBtn_start
            // 
            this.musicBtn_start.BackColor = System.Drawing.Color.Green;
            this.musicBtn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicBtn_start.ForeColor = System.Drawing.Color.White;
            this.musicBtn_start.Location = new System.Drawing.Point(467, 718);
            this.musicBtn_start.Name = "musicBtn_start";
            this.musicBtn_start.Size = new System.Drawing.Size(103, 47);
            this.musicBtn_start.TabIndex = 17;
            this.musicBtn_start.Text = "Play";
            this.musicBtn_start.UseVisualStyleBackColor = false;
            this.musicBtn_start.Click += new System.EventHandler(this.musicBtn_start_Click);
            // 
            // musicBtn_stop
            // 
            this.musicBtn_stop.BackColor = System.Drawing.Color.Tomato;
            this.musicBtn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicBtn_stop.ForeColor = System.Drawing.Color.White;
            this.musicBtn_stop.Location = new System.Drawing.Point(590, 718);
            this.musicBtn_stop.Name = "musicBtn_stop";
            this.musicBtn_stop.Size = new System.Drawing.Size(103, 47);
            this.musicBtn_stop.TabIndex = 18;
            this.musicBtn_stop.Text = "Pause";
            this.musicBtn_stop.UseVisualStyleBackColor = false;
            this.musicBtn_stop.Click += new System.EventHandler(this.musicBtn_stop_Click);
            // 
            // facebook_checkbox
            // 
            this.facebook_checkbox.AutoSize = true;
            this.facebook_checkbox.Location = new System.Drawing.Point(39, 685);
            this.facebook_checkbox.Name = "facebook_checkbox";
            this.facebook_checkbox.Size = new System.Drawing.Size(91, 20);
            this.facebook_checkbox.TabIndex = 19;
            this.facebook_checkbox.Text = "Facebook";
            this.facebook_checkbox.UseVisualStyleBackColor = true;
            this.facebook_checkbox.CheckedChanged += new System.EventHandler(this.facebook_checkbox_CheckedChanged);
            // 
            // instagram_checkbox
            // 
            this.instagram_checkbox.AutoSize = true;
            this.instagram_checkbox.Location = new System.Drawing.Point(145, 685);
            this.instagram_checkbox.Name = "instagram_checkbox";
            this.instagram_checkbox.Size = new System.Drawing.Size(88, 20);
            this.instagram_checkbox.TabIndex = 20;
            this.instagram_checkbox.Text = "Instagram";
            this.instagram_checkbox.UseVisualStyleBackColor = true;
            this.instagram_checkbox.CheckedChanged += new System.EventHandler(this.instagram_checkbox_CheckedChanged);
            // 
            // wykop_checkbox
            // 
            this.wykop_checkbox.AutoSize = true;
            this.wykop_checkbox.Location = new System.Drawing.Point(242, 685);
            this.wykop_checkbox.Name = "wykop_checkbox";
            this.wykop_checkbox.Size = new System.Drawing.Size(72, 20);
            this.wykop_checkbox.TabIndex = 21;
            this.wykop_checkbox.Text = "Wykop";
            this.wykop_checkbox.UseVisualStyleBackColor = true;
            this.wykop_checkbox.CheckedChanged += new System.EventHandler(this.wykop_checkbox_CheckedChanged);
            // 
            // youtube_checkbox
            // 
            this.youtube_checkbox.AutoSize = true;
            this.youtube_checkbox.Location = new System.Drawing.Point(324, 685);
            this.youtube_checkbox.Name = "youtube_checkbox";
            this.youtube_checkbox.Size = new System.Drawing.Size(79, 20);
            this.youtube_checkbox.TabIndex = 22;
            this.youtube_checkbox.Text = "Youtube";
            this.youtube_checkbox.UseVisualStyleBackColor = true;
            this.youtube_checkbox.CheckedChanged += new System.EventHandler(this.youtube_checkbox_CheckedChanged);
            // 
            // blockWebsites_btn
            // 
            this.blockWebsites_btn.BackColor = System.Drawing.Color.Red;
            this.blockWebsites_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blockWebsites_btn.ForeColor = System.Drawing.Color.White;
            this.blockWebsites_btn.Location = new System.Drawing.Point(39, 725);
            this.blockWebsites_btn.Name = "blockWebsites_btn";
            this.blockWebsites_btn.Size = new System.Drawing.Size(103, 40);
            this.blockWebsites_btn.TabIndex = 23;
            this.blockWebsites_btn.Text = "Block";
            this.blockWebsites_btn.UseVisualStyleBackColor = false;
            this.blockWebsites_btn.Click += new System.EventHandler(this.blockWebsites_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(39, 640);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Block websites (require admin rights)";
            // 
            // chatGPT_btn
            // 
            this.chatGPT_btn.BackColor = System.Drawing.Color.Tomato;
            this.chatGPT_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.chatGPT_btn.Location = new System.Drawing.Point(39, 807);
            this.chatGPT_btn.Name = "chatGPT_btn";
            this.chatGPT_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chatGPT_btn.Size = new System.Drawing.Size(654, 38);
            this.chatGPT_btn.TabIndex = 25;
            this.chatGPT_btn.Text = "Turn on Chat GPT";
            this.chatGPT_btn.UseVisualStyleBackColor = false;
            this.chatGPT_btn.Click += new System.EventHandler(this.chatGPT_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(745, 883);
            this.Controls.Add(this.chatGPT_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blockWebsites_btn);
            this.Controls.Add(this.youtube_checkbox);
            this.Controls.Add(this.wykop_checkbox);
            this.Controls.Add(this.instagram_checkbox);
            this.Controls.Add(this.facebook_checkbox);
            this.Controls.Add(this.musicBtn_stop);
            this.Controls.Add(this.musicBtn_start);
            this.Controls.Add(this.musicSelect);
            this.Controls.Add(this.musicLabel);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerCheckbox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.endtime3);
            this.Controls.Add(this.endtime2);
            this.Controls.Add(this.endTime1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbCounter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pomodoro App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label endTime1;
        private System.Windows.Forms.Label endtime2;
        private System.Windows.Forms.Label endtime3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.CheckBox timerCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.ComboBox musicSelect;
        private System.Windows.Forms.Button musicBtn_start;
        private System.Windows.Forms.Button musicBtn_stop;
        private System.Windows.Forms.CheckBox facebook_checkbox;
        private System.Windows.Forms.CheckBox instagram_checkbox;
        private System.Windows.Forms.CheckBox wykop_checkbox;
        private System.Windows.Forms.CheckBox youtube_checkbox;
        private System.Windows.Forms.Button blockWebsites_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chatGPT_btn;
    }
}

