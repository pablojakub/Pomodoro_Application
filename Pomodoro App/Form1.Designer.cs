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
            this.greet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quote = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jiraBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.jiraIssues = new System.Windows.Forms.ComboBox();
            this.jira_checkbox = new System.Windows.Forms.CheckBox();
            this.jiraProjects = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.issueLink = new System.Windows.Forms.LinkLabel();
            this.jiraPositiveResult = new System.Windows.Forms.Label();
            this.jiraNegativeResult = new System.Windows.Forms.Label();
            this.jiraWorklogRes = new System.Windows.Forms.Label();
            this.addWorklog = new System.Windows.Forms.LinkLabel();
            this.worklogResult = new System.Windows.Forms.Label();
            this.sendToPR = new System.Windows.Forms.LinkLabel();
            this.sendToPRStatus = new System.Windows.Forms.Label();
            this.statistic = new System.Windows.Forms.RichTextBox();
            this.author = new System.Windows.Forms.RichTextBox();
            this.changeQuote = new System.Windows.Forms.Button();
            this.spotifyBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCounter.Location = new System.Drawing.Point(216, 108);
            this.lbCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(66, 36);
            this.lbCounter.TabIndex = 0;
            this.lbCounter.Text = "000";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Coral;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(167, 228);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.counter.Location = new System.Drawing.Point(221, 176);
            this.counter.Margin = new System.Windows.Forms.Padding(2);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(96, 26);
            this.counter.TabIndex = 2;
            this.counter.Text = "55";
            this.counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(204, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(272, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
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
            this.endTime1.Location = new System.Drawing.Point(164, 289);
            this.endTime1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTime1.Name = "endTime1";
            this.endTime1.Size = new System.Drawing.Size(67, 17);
            this.endTime1.TabIndex = 5;
            this.endTime1.Text = "endTime:";
            // 
            // endtime2
            // 
            this.endtime2.AutoSize = true;
            this.endtime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endtime2.Location = new System.Drawing.Point(282, 289);
            this.endtime2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endtime2.Name = "endtime2";
            this.endtime2.Size = new System.Drawing.Size(0, 17);
            this.endtime2.TabIndex = 6;
            // 
            // endtime3
            // 
            this.endtime3.AutoSize = true;
            this.endtime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endtime3.ForeColor = System.Drawing.Color.Coral;
            this.endtime3.Location = new System.Drawing.Point(227, 289);
            this.endtime3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endtime3.Name = "endtime3";
            this.endtime3.Size = new System.Drawing.Size(0, 17);
            this.endtime3.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(31, 392);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 21);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 429);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 24);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 14, 15, 15, 0, 0);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Red;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.errorLabel.Location = new System.Drawing.Point(386, 15);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Padding = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.errorLabel.Size = new System.Drawing.Size(162, 24);
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
            this.timerCheckbox.Location = new System.Drawing.Point(352, 392);
            this.timerCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.timerCheckbox.Name = "timerCheckbox";
            this.timerCheckbox.Size = new System.Drawing.Size(187, 21);
            this.timerCheckbox.TabIndex = 11;
            this.timerCheckbox.Text = "Show timer after minimize";
            this.timerCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(190, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customization:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Coral;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(275, 228);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(95, 38);
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
            this.musicLabel.Location = new System.Drawing.Point(349, 514);
            this.musicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(101, 17);
            this.musicLabel.TabIndex = 15;
            this.musicLabel.Text = "Nature sounds";
            // 
            // musicSelect
            // 
            this.musicSelect.FormattingEnabled = true;
            this.musicSelect.Items.AddRange(new object[] {
            "Forest",
            "Ocean"});
            this.musicSelect.Location = new System.Drawing.Point(351, 540);
            this.musicSelect.Margin = new System.Windows.Forms.Padding(2);
            this.musicSelect.Name = "musicSelect";
            this.musicSelect.Size = new System.Drawing.Size(170, 21);
            this.musicSelect.TabIndex = 16;
            // 
            // musicBtn_start
            // 
            this.musicBtn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(80)))));
            this.musicBtn_start.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.musicBtn_start.FlatAppearance.BorderSize = 5;
            this.musicBtn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.musicBtn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.musicBtn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicBtn_start.ForeColor = System.Drawing.Color.White;
            this.musicBtn_start.Location = new System.Drawing.Point(351, 579);
            this.musicBtn_start.Margin = new System.Windows.Forms.Padding(2);
            this.musicBtn_start.Name = "musicBtn_start";
            this.musicBtn_start.Size = new System.Drawing.Size(77, 38);
            this.musicBtn_start.TabIndex = 17;
            this.musicBtn_start.Text = "Play";
            this.musicBtn_start.UseVisualStyleBackColor = false;
            this.musicBtn_start.Click += new System.EventHandler(this.musicBtn_start_Click);
            // 
            // musicBtn_stop
            // 
            this.musicBtn_stop.BackColor = System.Drawing.Color.Coral;
            this.musicBtn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicBtn_stop.ForeColor = System.Drawing.Color.White;
            this.musicBtn_stop.Location = new System.Drawing.Point(444, 579);
            this.musicBtn_stop.Margin = new System.Windows.Forms.Padding(2);
            this.musicBtn_stop.Name = "musicBtn_stop";
            this.musicBtn_stop.Size = new System.Drawing.Size(77, 38);
            this.musicBtn_stop.TabIndex = 18;
            this.musicBtn_stop.Text = "Pause";
            this.musicBtn_stop.UseVisualStyleBackColor = false;
            this.musicBtn_stop.Click += new System.EventHandler(this.musicBtn_stop_Click);
            // 
            // facebook_checkbox
            // 
            this.facebook_checkbox.AutoSize = true;
            this.facebook_checkbox.Location = new System.Drawing.Point(37, 532);
            this.facebook_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.facebook_checkbox.Name = "facebook_checkbox";
            this.facebook_checkbox.Size = new System.Drawing.Size(74, 17);
            this.facebook_checkbox.TabIndex = 19;
            this.facebook_checkbox.Text = "Facebook";
            this.facebook_checkbox.UseVisualStyleBackColor = true;
            this.facebook_checkbox.CheckedChanged += new System.EventHandler(this.facebook_checkbox_CheckedChanged);
            // 
            // instagram_checkbox
            // 
            this.instagram_checkbox.AutoSize = true;
            this.instagram_checkbox.Location = new System.Drawing.Point(116, 532);
            this.instagram_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.instagram_checkbox.Name = "instagram_checkbox";
            this.instagram_checkbox.Size = new System.Drawing.Size(72, 17);
            this.instagram_checkbox.TabIndex = 20;
            this.instagram_checkbox.Text = "Instagram";
            this.instagram_checkbox.UseVisualStyleBackColor = true;
            this.instagram_checkbox.CheckedChanged += new System.EventHandler(this.instagram_checkbox_CheckedChanged);
            // 
            // wykop_checkbox
            // 
            this.wykop_checkbox.AutoSize = true;
            this.wykop_checkbox.Location = new System.Drawing.Point(189, 532);
            this.wykop_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.wykop_checkbox.Name = "wykop_checkbox";
            this.wykop_checkbox.Size = new System.Drawing.Size(60, 17);
            this.wykop_checkbox.TabIndex = 21;
            this.wykop_checkbox.Text = "Wykop";
            this.wykop_checkbox.UseVisualStyleBackColor = true;
            this.wykop_checkbox.CheckedChanged += new System.EventHandler(this.wykop_checkbox_CheckedChanged);
            // 
            // youtube_checkbox
            // 
            this.youtube_checkbox.AutoSize = true;
            this.youtube_checkbox.Location = new System.Drawing.Point(250, 532);
            this.youtube_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.youtube_checkbox.Name = "youtube_checkbox";
            this.youtube_checkbox.Size = new System.Drawing.Size(66, 17);
            this.youtube_checkbox.TabIndex = 22;
            this.youtube_checkbox.Text = "Youtube";
            this.youtube_checkbox.UseVisualStyleBackColor = true;
            this.youtube_checkbox.CheckedChanged += new System.EventHandler(this.youtube_checkbox_CheckedChanged);
            // 
            // blockWebsites_btn
            // 
            this.blockWebsites_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(121)))));
            this.blockWebsites_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blockWebsites_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blockWebsites_btn.ForeColor = System.Drawing.Color.White;
            this.blockWebsites_btn.Location = new System.Drawing.Point(37, 564);
            this.blockWebsites_btn.Margin = new System.Windows.Forms.Padding(2);
            this.blockWebsites_btn.Name = "blockWebsites_btn";
            this.blockWebsites_btn.Size = new System.Drawing.Size(77, 32);
            this.blockWebsites_btn.TabIndex = 23;
            this.blockWebsites_btn.Text = "Block";
            this.blockWebsites_btn.UseVisualStyleBackColor = false;
            this.blockWebsites_btn.Click += new System.EventHandler(this.blockWebsites_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(34, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Block websites (require admin rights)";
            // 
            // chatGPT_btn
            // 
            this.chatGPT_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.chatGPT_btn.ForeColor = System.Drawing.Color.Coral;
            this.chatGPT_btn.Location = new System.Drawing.Point(31, 645);
            this.chatGPT_btn.Margin = new System.Windows.Forms.Padding(2);
            this.chatGPT_btn.Name = "chatGPT_btn";
            this.chatGPT_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chatGPT_btn.Size = new System.Drawing.Size(146, 31);
            this.chatGPT_btn.TabIndex = 25;
            this.chatGPT_btn.Text = "Turn on Chat GPT";
            this.chatGPT_btn.UseVisualStyleBackColor = false;
            this.chatGPT_btn.Click += new System.EventHandler(this.chatGPT_btn_Click);
            // 
            // greet
            // 
            this.greet.AutoSize = true;
            this.greet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greet.Location = new System.Drawing.Point(582, 432);
            this.greet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greet.Name = "greet";
            this.greet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.greet.Size = new System.Drawing.Size(0, 20);
            this.greet.TabIndex = 27;
            this.greet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(688, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Statistics:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(711, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 58);
            this.label6.TabIndex = 30;
            this.label6.Text = "\"";
            // 
            // quote
            // 
            this.quote.BackColor = System.Drawing.Color.Gainsboro;
            this.quote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.Location = new System.Drawing.Point(650, 239);
            this.quote.Margin = new System.Windows.Forms.Padding(2);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(179, 27);
            this.quote.TabIndex = 33;
            this.quote.Text = "Testujemy testujemy";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // jiraBtn
            // 
            this.jiraBtn.Location = new System.Drawing.Point(579, 579);
            this.jiraBtn.Margin = new System.Windows.Forms.Padding(2);
            this.jiraBtn.Name = "jiraBtn";
            this.jiraBtn.Size = new System.Drawing.Size(308, 26);
            this.jiraBtn.TabIndex = 35;
            this.jiraBtn.Text = "Get issues from JIRA";
            this.jiraBtn.UseVisualStyleBackColor = true;
            this.jiraBtn.Click += new System.EventHandler(this.jiraBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(716, 477);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "JIRA:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // jiraIssues
            // 
            this.jiraIssues.FormattingEnabled = true;
            this.jiraIssues.Location = new System.Drawing.Point(579, 618);
            this.jiraIssues.Margin = new System.Windows.Forms.Padding(2);
            this.jiraIssues.Name = "jiraIssues";
            this.jiraIssues.Size = new System.Drawing.Size(309, 21);
            this.jiraIssues.TabIndex = 37;
            this.jiraIssues.SelectedIndexChanged += new System.EventHandler(this.jiraIssues_SelectedIndexChanged);
            // 
            // jira_checkbox
            // 
            this.jira_checkbox.AutoSize = true;
            this.jira_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jira_checkbox.Location = new System.Drawing.Point(352, 432);
            this.jira_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.jira_checkbox.Name = "jira_checkbox";
            this.jira_checkbox.Size = new System.Drawing.Size(158, 21);
            this.jira_checkbox.TabIndex = 38;
            this.jira_checkbox.Text = "Register time in JIRA";
            this.jira_checkbox.UseVisualStyleBackColor = true;
            // 
            // jiraProjects
            // 
            this.jiraProjects.FormattingEnabled = true;
            this.jiraProjects.Items.AddRange(new object[] {
            "BeeOffice",
            "Bee-on-Time"});
            this.jiraProjects.Location = new System.Drawing.Point(668, 540);
            this.jiraProjects.Margin = new System.Windows.Forms.Padding(2);
            this.jiraProjects.Name = "jiraProjects";
            this.jiraProjects.Size = new System.Drawing.Size(161, 21);
            this.jiraProjects.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(718, 514);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Projects:";
            // 
            // issueLink
            // 
            this.issueLink.AutoSize = true;
            this.issueLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueLink.LinkColor = System.Drawing.Color.Coral;
            this.issueLink.Location = new System.Drawing.Point(576, 659);
            this.issueLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.issueLink.Name = "issueLink";
            this.issueLink.Size = new System.Drawing.Size(80, 17);
            this.issueLink.TabIndex = 41;
            this.issueLink.TabStop = true;
            this.issueLink.Text = "Go to issue";
            this.issueLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issueLink_LinkClicked);
            // 
            // jiraPositiveResult
            // 
            this.jiraPositiveResult.AutoSize = true;
            this.jiraPositiveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jiraPositiveResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.jiraPositiveResult.Location = new System.Drawing.Point(892, 618);
            this.jiraPositiveResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jiraPositiveResult.Name = "jiraPositiveResult";
            this.jiraPositiveResult.Size = new System.Drawing.Size(25, 20);
            this.jiraPositiveResult.TabIndex = 42;
            this.jiraPositiveResult.Text = "✅";
            this.jiraPositiveResult.Visible = false;
            // 
            // jiraNegativeResult
            // 
            this.jiraNegativeResult.AutoSize = true;
            this.jiraNegativeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jiraNegativeResult.ForeColor = System.Drawing.Color.Red;
            this.jiraNegativeResult.Location = new System.Drawing.Point(892, 618);
            this.jiraNegativeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jiraNegativeResult.Name = "jiraNegativeResult";
            this.jiraNegativeResult.Size = new System.Drawing.Size(25, 20);
            this.jiraNegativeResult.TabIndex = 43;
            this.jiraNegativeResult.Text = "❌";
            this.jiraNegativeResult.Visible = false;
            // 
            // jiraWorklogRes
            // 
            this.jiraWorklogRes.AutoSize = true;
            this.jiraWorklogRes.BackColor = System.Drawing.Color.LimeGreen;
            this.jiraWorklogRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jiraWorklogRes.ForeColor = System.Drawing.Color.White;
            this.jiraWorklogRes.Location = new System.Drawing.Point(406, 19);
            this.jiraWorklogRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jiraWorklogRes.Name = "jiraWorklogRes";
            this.jiraWorklogRes.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.jiraWorklogRes.Size = new System.Drawing.Size(130, 20);
            this.jiraWorklogRes.TabIndex = 44;
            this.jiraWorklogRes.Text = "Added worklog";
            this.jiraWorklogRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jiraWorklogRes.Visible = false;
            this.jiraWorklogRes.Click += new System.EventHandler(this.jiraWorklogRes_Click);
            // 
            // addWorklog
            // 
            this.addWorklog.AutoSize = true;
            this.addWorklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addWorklog.LinkColor = System.Drawing.Color.Coral;
            this.addWorklog.Location = new System.Drawing.Point(692, 658);
            this.addWorklog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addWorklog.Name = "addWorklog";
            this.addWorklog.Size = new System.Drawing.Size(106, 17);
            this.addWorklog.TabIndex = 45;
            this.addWorklog.TabStop = true;
            this.addWorklog.Text = "Add 30 minutes";
            this.addWorklog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addWorklog_LinkClicked);
            // 
            // worklogResult
            // 
            this.worklogResult.AutoSize = true;
            this.worklogResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.worklogResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.worklogResult.Location = new System.Drawing.Point(784, 654);
            this.worklogResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.worklogResult.Name = "worklogResult";
            this.worklogResult.Size = new System.Drawing.Size(25, 20);
            this.worklogResult.TabIndex = 46;
            this.worklogResult.Text = "✅";
            this.worklogResult.Visible = false;
            // 
            // sendToPR
            // 
            this.sendToPR.AutoSize = true;
            this.sendToPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendToPR.LinkColor = System.Drawing.Color.Coral;
            this.sendToPR.LinkVisited = true;
            this.sendToPR.Location = new System.Drawing.Point(817, 658);
            this.sendToPR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendToPR.Name = "sendToPR";
            this.sendToPR.Size = new System.Drawing.Size(80, 17);
            this.sendToPR.TabIndex = 47;
            this.sendToPR.TabStop = true;
            this.sendToPR.Text = "Send to PR";
            this.sendToPR.VisitedLinkColor = System.Drawing.Color.Coral;
            this.sendToPR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendToPR_LinkClicked);
            // 
            // sendToPRStatus
            // 
            this.sendToPRStatus.AutoSize = true;
            this.sendToPRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendToPRStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.sendToPRStatus.Location = new System.Drawing.Point(892, 654);
            this.sendToPRStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendToPRStatus.Name = "sendToPRStatus";
            this.sendToPRStatus.Size = new System.Drawing.Size(25, 20);
            this.sendToPRStatus.TabIndex = 48;
            this.sendToPRStatus.Text = "✅";
            this.sendToPRStatus.Visible = false;
            // 
            // statistic
            // 
            this.statistic.BackColor = System.Drawing.Color.Gainsboro;
            this.statistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistic.Location = new System.Drawing.Point(579, 384);
            this.statistic.Margin = new System.Windows.Forms.Padding(2);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(338, 80);
            this.statistic.TabIndex = 50;
            this.statistic.Text = "";
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.Gainsboro;
            this.author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(604, 96);
            this.author.Margin = new System.Windows.Forms.Padding(2);
            this.author.Name = "author";
            this.author.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.author.Size = new System.Drawing.Size(263, 119);
            this.author.TabIndex = 51;
            this.author.Text = "Testujemy testujemy testujemy";
            // 
            // changeQuote
            // 
            this.changeQuote.BackColor = System.Drawing.Color.Gainsboro;
            this.changeQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeQuote.Location = new System.Drawing.Point(723, 278);
            this.changeQuote.Margin = new System.Windows.Forms.Padding(0);
            this.changeQuote.Name = "changeQuote";
            this.changeQuote.Size = new System.Drawing.Size(34, 35);
            this.changeQuote.TabIndex = 52;
            this.changeQuote.Text = "🔄️";
            this.changeQuote.UseVisualStyleBackColor = false;
            this.changeQuote.Click += new System.EventHandler(this.changeQuote_Click);
            // 
            // spotifyBtn
            // 
            this.spotifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.spotifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.spotifyBtn.FlatAppearance.BorderSize = 5;
            this.spotifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.spotifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.spotifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spotifyBtn.ForeColor = System.Drawing.Color.White;
            this.spotifyBtn.Location = new System.Drawing.Point(352, 637);
            this.spotifyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.spotifyBtn.Name = "spotifyBtn";
            this.spotifyBtn.Size = new System.Drawing.Size(169, 38);
            this.spotifyBtn.TabIndex = 53;
            this.spotifyBtn.Text = "Open Spotify";
            this.spotifyBtn.UseVisualStyleBackColor = false;
            this.spotifyBtn.Click += new System.EventHandler(this.spotifyBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(347, 477);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 26);
            this.label9.TabIndex = 54;
            this.label9.Text = "Music:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(968, 792);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spotifyBtn);
            this.Controls.Add(this.changeQuote);
            this.Controls.Add(this.author);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.sendToPRStatus);
            this.Controls.Add(this.sendToPR);
            this.Controls.Add(this.worklogResult);
            this.Controls.Add(this.addWorklog);
            this.Controls.Add(this.jiraWorklogRes);
            this.Controls.Add(this.jiraNegativeResult);
            this.Controls.Add(this.jiraPositiveResult);
            this.Controls.Add(this.issueLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.jiraProjects);
            this.Controls.Add(this.jira_checkbox);
            this.Controls.Add(this.jiraIssues);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.jiraBtn);
            this.Controls.Add(this.quote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.greet);
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
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label greet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox quote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button jiraBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox jiraIssues;
        private System.Windows.Forms.CheckBox jira_checkbox;
        private System.Windows.Forms.ComboBox jiraProjects;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel issueLink;
        private System.Windows.Forms.Label jiraPositiveResult;
        private System.Windows.Forms.Label jiraNegativeResult;
        private System.Windows.Forms.Label jiraWorklogRes;
        private System.Windows.Forms.LinkLabel addWorklog;
        private System.Windows.Forms.Label worklogResult;
        private System.Windows.Forms.LinkLabel sendToPR;
        private System.Windows.Forms.Label sendToPRStatus;
        private System.Windows.Forms.RichTextBox statistic;
        private System.Windows.Forms.RichTextBox author;
        private System.Windows.Forms.Button changeQuote;
        private System.Windows.Forms.Button spotifyBtn;
        private System.Windows.Forms.Label label9;
    }
}

