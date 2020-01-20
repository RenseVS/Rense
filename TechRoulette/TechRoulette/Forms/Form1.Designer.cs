namespace TechRoulette
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
            this.ArduinoInterfaceGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ArduinoMessageSent = new System.Windows.Forms.TextBox();
            this.ArduinoChangeValuesButton = new System.Windows.Forms.Button();
            this.ConnectionArduinoGroupbox = new System.Windows.Forms.GroupBox();
            this.DisconnectArduinoButton = new System.Windows.Forms.Button();
            this.ArduinoConnectionTextBox = new System.Windows.Forms.TextBox();
            this.ConnectArduinoButton = new System.Windows.Forms.Button();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.BaudRateTextBox = new System.Windows.Forms.TextBox();
            this.BoardPortLabel = new System.Windows.Forms.Label();
            this.BoardPortTextBox = new System.Windows.Forms.TextBox();
            this.SQLInterfaceGroupbox = new System.Windows.Forms.GroupBox();
            this.ConnectionChangeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasswordSQLTextbox = new System.Windows.Forms.TextBox();
            this.PasswordSQLLabel = new System.Windows.Forms.Label();
            this.UsernameSQLTextbox = new System.Windows.Forms.TextBox();
            this.UsernameSQLLabel = new System.Windows.Forms.Label();
            this.PortSQLTextbox = new System.Windows.Forms.TextBox();
            this.PortSQLLabel = new System.Windows.Forms.Label();
            this.DatasourceSQLTextbox = new System.Windows.Forms.TextBox();
            this.DataSourceSQLLabel = new System.Windows.Forms.Label();
            this.CameraListComboBox = new System.Windows.Forms.ComboBox();
            this.StartCameraButton = new System.Windows.Forms.Button();
            this.StopCameraButton = new System.Windows.Forms.Button();
            this.TimerVideo = new System.Windows.Forms.Timer(this.components);
            this.Refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testbox = new System.Windows.Forms.PictureBox();
            this.MotorStartButton = new System.Windows.Forms.Button();
            this.StopMotorButton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ResultTimer = new System.Windows.Forms.Timer(this.components);
            this.WinnerButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BetaTextBox = new System.Windows.Forms.TextBox();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.StopGameButton = new System.Windows.Forms.Button();
            this.ArduinoInterfaceGroupbox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ConnectionArduinoGroupbox.SuspendLayout();
            this.SQLInterfaceGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArduinoInterfaceGroupbox
            // 
            this.ArduinoInterfaceGroupbox.Controls.Add(this.groupBox4);
            this.ArduinoInterfaceGroupbox.Controls.Add(this.ArduinoChangeValuesButton);
            this.ArduinoInterfaceGroupbox.Controls.Add(this.ConnectionArduinoGroupbox);
            this.ArduinoInterfaceGroupbox.Controls.Add(this.BaudRateLabel);
            this.ArduinoInterfaceGroupbox.Controls.Add(this.BaudRateTextBox);
            this.ArduinoInterfaceGroupbox.Controls.Add(this.BoardPortLabel);
            this.ArduinoInterfaceGroupbox.Controls.Add(this.BoardPortTextBox);
            this.ArduinoInterfaceGroupbox.Location = new System.Drawing.Point(10, 11);
            this.ArduinoInterfaceGroupbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ArduinoInterfaceGroupbox.Name = "ArduinoInterfaceGroupbox";
            this.ArduinoInterfaceGroupbox.Padding = new System.Windows.Forms.Padding(2);
            this.ArduinoInterfaceGroupbox.Size = new System.Drawing.Size(290, 322);
            this.ArduinoInterfaceGroupbox.TabIndex = 0;
            this.ArduinoInterfaceGroupbox.TabStop = false;
            this.ArduinoInterfaceGroupbox.Text = "Arduino Interface";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ArduinoMessageSent);
            this.groupBox4.Location = new System.Drawing.Point(3, 255);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox4.Size = new System.Drawing.Size(250, 60);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message Sent";
            // 
            // ArduinoMessageSent
            // 
            this.ArduinoMessageSent.Location = new System.Drawing.Point(8, 28);
            this.ArduinoMessageSent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ArduinoMessageSent.Name = "ArduinoMessageSent";
            this.ArduinoMessageSent.ReadOnly = true;
            this.ArduinoMessageSent.Size = new System.Drawing.Size(236, 26);
            this.ArduinoMessageSent.TabIndex = 0;
            // 
            // ArduinoChangeValuesButton
            // 
            this.ArduinoChangeValuesButton.Location = new System.Drawing.Point(8, 112);
            this.ArduinoChangeValuesButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ArduinoChangeValuesButton.Name = "ArduinoChangeValuesButton";
            this.ArduinoChangeValuesButton.Size = new System.Drawing.Size(136, 29);
            this.ArduinoChangeValuesButton.TabIndex = 2;
            this.ArduinoChangeValuesButton.Text = "Change Values";
            this.ArduinoChangeValuesButton.UseVisualStyleBackColor = true;
            this.ArduinoChangeValuesButton.Click += new System.EventHandler(this.ArduinoChangeValuesButton_Click);
            // 
            // ConnectionArduinoGroupbox
            // 
            this.ConnectionArduinoGroupbox.Controls.Add(this.DisconnectArduinoButton);
            this.ConnectionArduinoGroupbox.Controls.Add(this.ArduinoConnectionTextBox);
            this.ConnectionArduinoGroupbox.Controls.Add(this.ConnectArduinoButton);
            this.ConnectionArduinoGroupbox.Location = new System.Drawing.Point(0, 149);
            this.ConnectionArduinoGroupbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConnectionArduinoGroupbox.Name = "ConnectionArduinoGroupbox";
            this.ConnectionArduinoGroupbox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConnectionArduinoGroupbox.Size = new System.Drawing.Size(280, 100);
            this.ConnectionArduinoGroupbox.TabIndex = 6;
            this.ConnectionArduinoGroupbox.TabStop = false;
            this.ConnectionArduinoGroupbox.Text = "Connection";
            // 
            // DisconnectArduinoButton
            // 
            this.DisconnectArduinoButton.Location = new System.Drawing.Point(160, 26);
            this.DisconnectArduinoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DisconnectArduinoButton.Name = "DisconnectArduinoButton";
            this.DisconnectArduinoButton.Size = new System.Drawing.Size(100, 29);
            this.DisconnectArduinoButton.TabIndex = 6;
            this.DisconnectArduinoButton.Text = "Disconnect";
            this.DisconnectArduinoButton.UseVisualStyleBackColor = true;
            this.DisconnectArduinoButton.Click += new System.EventHandler(this.DisconnectArduinoButton_Click);
            // 
            // ArduinoConnectionTextBox
            // 
            this.ArduinoConnectionTextBox.BackColor = System.Drawing.Color.White;
            this.ArduinoConnectionTextBox.Location = new System.Drawing.Point(8, 62);
            this.ArduinoConnectionTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ArduinoConnectionTextBox.Name = "ArduinoConnectionTextBox";
            this.ArduinoConnectionTextBox.ReadOnly = true;
            this.ArduinoConnectionTextBox.Size = new System.Drawing.Size(254, 26);
            this.ArduinoConnectionTextBox.TabIndex = 2;
            this.ArduinoConnectionTextBox.Text = "STATUS";
            this.ArduinoConnectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectArduinoButton
            // 
            this.ConnectArduinoButton.Location = new System.Drawing.Point(0, 26);
            this.ConnectArduinoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConnectArduinoButton.Name = "ConnectArduinoButton";
            this.ConnectArduinoButton.Size = new System.Drawing.Size(100, 29);
            this.ConnectArduinoButton.TabIndex = 5;
            this.ConnectArduinoButton.Text = "Connect";
            this.ConnectArduinoButton.UseVisualStyleBackColor = true;
            this.ConnectArduinoButton.Click += new System.EventHandler(this.ConnectArduinoButton_Click);
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(8, 82);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(90, 20);
            this.BaudRateLabel.TabIndex = 4;
            this.BaudRateLabel.Text = "Baud Rate:";
            // 
            // BaudRateTextBox
            // 
            this.BaudRateTextBox.Location = new System.Drawing.Point(116, 78);
            this.BaudRateTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BaudRateTextBox.Name = "BaudRateTextBox";
            this.BaudRateTextBox.Size = new System.Drawing.Size(112, 26);
            this.BaudRateTextBox.TabIndex = 3;
            // 
            // BoardPortLabel
            // 
            this.BoardPortLabel.AutoSize = true;
            this.BoardPortLabel.Location = new System.Drawing.Point(8, 46);
            this.BoardPortLabel.Name = "BoardPortLabel";
            this.BoardPortLabel.Size = new System.Drawing.Size(89, 20);
            this.BoardPortLabel.TabIndex = 2;
            this.BoardPortLabel.Text = "Board Port:";
            // 
            // BoardPortTextBox
            // 
            this.BoardPortTextBox.Location = new System.Drawing.Point(116, 40);
            this.BoardPortTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BoardPortTextBox.Name = "BoardPortTextBox";
            this.BoardPortTextBox.Size = new System.Drawing.Size(112, 26);
            this.BoardPortTextBox.TabIndex = 0;
            // 
            // SQLInterfaceGroupbox
            // 
            this.SQLInterfaceGroupbox.Controls.Add(this.ConnectionChangeButton);
            this.SQLInterfaceGroupbox.Controls.Add(this.textBox1);
            this.SQLInterfaceGroupbox.Controls.Add(this.PasswordSQLTextbox);
            this.SQLInterfaceGroupbox.Controls.Add(this.PasswordSQLLabel);
            this.SQLInterfaceGroupbox.Controls.Add(this.UsernameSQLTextbox);
            this.SQLInterfaceGroupbox.Controls.Add(this.UsernameSQLLabel);
            this.SQLInterfaceGroupbox.Controls.Add(this.PortSQLTextbox);
            this.SQLInterfaceGroupbox.Controls.Add(this.PortSQLLabel);
            this.SQLInterfaceGroupbox.Controls.Add(this.DatasourceSQLTextbox);
            this.SQLInterfaceGroupbox.Controls.Add(this.DataSourceSQLLabel);
            this.SQLInterfaceGroupbox.Location = new System.Drawing.Point(4, 342);
            this.SQLInterfaceGroupbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SQLInterfaceGroupbox.Name = "SQLInterfaceGroupbox";
            this.SQLInterfaceGroupbox.Padding = new System.Windows.Forms.Padding(2);
            this.SQLInterfaceGroupbox.Size = new System.Drawing.Size(296, 218);
            this.SQLInterfaceGroupbox.TabIndex = 1;
            this.SQLInterfaceGroupbox.TabStop = false;
            this.SQLInterfaceGroupbox.Text = "SQL Interface";
            // 
            // ConnectionChangeButton
            // 
            this.ConnectionChangeButton.Location = new System.Drawing.Point(0, 189);
            this.ConnectionChangeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConnectionChangeButton.Name = "ConnectionChangeButton";
            this.ConnectionChangeButton.Size = new System.Drawing.Size(288, 29);
            this.ConnectionChangeButton.TabIndex = 2;
            this.ConnectionChangeButton.Text = "Set As Connection";
            this.ConnectionChangeButton.UseVisualStyleBackColor = true;
            this.ConnectionChangeButton.Click += new System.EventHandler(this.ConnectionChangeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 225);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 8;
            // 
            // PasswordSQLTextbox
            // 
            this.PasswordSQLTextbox.Location = new System.Drawing.Point(100, 140);
            this.PasswordSQLTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PasswordSQLTextbox.Name = "PasswordSQLTextbox";
            this.PasswordSQLTextbox.Size = new System.Drawing.Size(180, 26);
            this.PasswordSQLTextbox.TabIndex = 7;
            // 
            // PasswordSQLLabel
            // 
            this.PasswordSQLLabel.AutoSize = true;
            this.PasswordSQLLabel.Location = new System.Drawing.Point(3, 145);
            this.PasswordSQLLabel.Name = "PasswordSQLLabel";
            this.PasswordSQLLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordSQLLabel.TabIndex = 6;
            this.PasswordSQLLabel.Text = "Password:";
            // 
            // UsernameSQLTextbox
            // 
            this.UsernameSQLTextbox.Location = new System.Drawing.Point(100, 105);
            this.UsernameSQLTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UsernameSQLTextbox.Name = "UsernameSQLTextbox";
            this.UsernameSQLTextbox.Size = new System.Drawing.Size(180, 26);
            this.UsernameSQLTextbox.TabIndex = 5;
            // 
            // UsernameSQLLabel
            // 
            this.UsernameSQLLabel.AutoSize = true;
            this.UsernameSQLLabel.Location = new System.Drawing.Point(3, 109);
            this.UsernameSQLLabel.Name = "UsernameSQLLabel";
            this.UsernameSQLLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameSQLLabel.TabIndex = 4;
            this.UsernameSQLLabel.Text = "Username:";
            // 
            // PortSQLTextbox
            // 
            this.PortSQLTextbox.Location = new System.Drawing.Point(100, 69);
            this.PortSQLTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PortSQLTextbox.Name = "PortSQLTextbox";
            this.PortSQLTextbox.Size = new System.Drawing.Size(180, 26);
            this.PortSQLTextbox.TabIndex = 3;
            // 
            // PortSQLLabel
            // 
            this.PortSQLLabel.AutoSize = true;
            this.PortSQLLabel.Location = new System.Drawing.Point(3, 72);
            this.PortSQLLabel.Name = "PortSQLLabel";
            this.PortSQLLabel.Size = new System.Drawing.Size(42, 20);
            this.PortSQLLabel.TabIndex = 2;
            this.PortSQLLabel.Text = "Port:";
            // 
            // DatasourceSQLTextbox
            // 
            this.DatasourceSQLTextbox.Location = new System.Drawing.Point(100, 35);
            this.DatasourceSQLTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DatasourceSQLTextbox.Name = "DatasourceSQLTextbox";
            this.DatasourceSQLTextbox.Size = new System.Drawing.Size(180, 26);
            this.DatasourceSQLTextbox.TabIndex = 1;
            // 
            // DataSourceSQLLabel
            // 
            this.DataSourceSQLLabel.AutoSize = true;
            this.DataSourceSQLLabel.Location = new System.Drawing.Point(3, 38);
            this.DataSourceSQLLabel.Name = "DataSourceSQLLabel";
            this.DataSourceSQLLabel.Size = new System.Drawing.Size(96, 20);
            this.DataSourceSQLLabel.TabIndex = 0;
            this.DataSourceSQLLabel.Text = "Datasource:";
            // 
            // CameraListComboBox
            // 
            this.CameraListComboBox.FormattingEnabled = true;
            this.CameraListComboBox.Location = new System.Drawing.Point(549, 725);
            this.CameraListComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CameraListComboBox.Name = "CameraListComboBox";
            this.CameraListComboBox.Size = new System.Drawing.Size(330, 28);
            this.CameraListComboBox.TabIndex = 3;
            // 
            // StartCameraButton
            // 
            this.StartCameraButton.Location = new System.Drawing.Point(338, 688);
            this.StartCameraButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartCameraButton.Name = "StartCameraButton";
            this.StartCameraButton.Size = new System.Drawing.Size(84, 31);
            this.StartCameraButton.TabIndex = 4;
            this.StartCameraButton.Text = "Start";
            this.StartCameraButton.UseVisualStyleBackColor = true;
            this.StartCameraButton.Click += new System.EventHandler(this.CameraButtonStart_Click);
            // 
            // StopCameraButton
            // 
            this.StopCameraButton.Location = new System.Drawing.Point(424, 688);
            this.StopCameraButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopCameraButton.Name = "StopCameraButton";
            this.StopCameraButton.Size = new System.Drawing.Size(84, 31);
            this.StopCameraButton.TabIndex = 5;
            this.StopCameraButton.Text = "Stop";
            this.StopCameraButton.UseVisualStyleBackColor = true;
            this.StopCameraButton.Click += new System.EventHandler(this.StopCamera_Click);
            // 
            // TimerVideo
            // 
            this.TimerVideo.Interval = 2000;
            // 
            // Refreshtimer
            // 
            this.Refreshtimer.Interval = 2000;
            this.Refreshtimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1188, 501);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(338, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 663);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // testbox
            // 
            this.testbox.BackColor = System.Drawing.Color.Khaki;
            this.testbox.Location = new System.Drawing.Point(1033, 205);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(104, 90);
            this.testbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testbox.TabIndex = 6;
            this.testbox.TabStop = false;
            // 
            // MotorStartButton
            // 
            this.MotorStartButton.Location = new System.Drawing.Point(444, 725);
            this.MotorStartButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MotorStartButton.Name = "MotorStartButton";
            this.MotorStartButton.Size = new System.Drawing.Size(100, 29);
            this.MotorStartButton.TabIndex = 7;
            this.MotorStartButton.Text = "Motor Start";
            this.MotorStartButton.UseVisualStyleBackColor = true;
            this.MotorStartButton.Click += new System.EventHandler(this.MotorStartButton_Click);
            // 
            // StopMotorButton
            // 
            this.StopMotorButton.Location = new System.Drawing.Point(338, 725);
            this.StopMotorButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.StopMotorButton.Name = "StopMotorButton";
            this.StopMotorButton.Size = new System.Drawing.Size(100, 29);
            this.StopMotorButton.TabIndex = 8;
            this.StopMotorButton.Text = "Motor Stop";
            this.StopMotorButton.UseVisualStyleBackColor = true;
            this.StopMotorButton.Click += new System.EventHandler(this.StopMotorButton_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 120000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ResultTimer
            // 
            this.ResultTimer.Interval = 10000;
            this.ResultTimer.Tick += new System.EventHandler(this.ResultTimer_Tick);
            // 
            // WinnerButton
            // 
            this.WinnerButton.Location = new System.Drawing.Point(10, 605);
            this.WinnerButton.Name = "WinnerButton";
            this.WinnerButton.Size = new System.Drawing.Size(75, 29);
            this.WinnerButton.TabIndex = 10;
            this.WinnerButton.Text = "Winner";
            this.WinnerButton.UseVisualStyleBackColor = true;
            this.WinnerButton.Click += new System.EventHandler(this.Winner_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 605);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 149);
            this.dataGridView1.TabIndex = 11;
            // 
            // BetaTextBox
            // 
            this.BetaTextBox.Location = new System.Drawing.Point(8, 568);
            this.BetaTextBox.Name = "BetaTextBox";
            this.BetaTextBox.Size = new System.Drawing.Size(100, 26);
            this.BetaTextBox.TabIndex = 12;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(10, 640);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(75, 32);
            this.StartGameButton.TabIndex = 13;
            this.StartGameButton.Text = "Start";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // StopGameButton
            // 
            this.StopGameButton.Location = new System.Drawing.Point(10, 678);
            this.StopGameButton.Name = "StopGameButton";
            this.StopGameButton.Size = new System.Drawing.Size(75, 29);
            this.StopGameButton.TabIndex = 14;
            this.StopGameButton.Text = "Stop";
            this.StopGameButton.UseVisualStyleBackColor = true;
            this.StopGameButton.Click += new System.EventHandler(this.StopGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 777);
            this.Controls.Add(this.StopGameButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.BetaTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.WinnerButton);
            this.Controls.Add(this.StopMotorButton);
            this.Controls.Add(this.MotorStartButton);
            this.Controls.Add(this.StopCameraButton);
            this.Controls.Add(this.StartCameraButton);
            this.Controls.Add(this.CameraListComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SQLInterfaceGroupbox);
            this.Controls.Add(this.ArduinoInterfaceGroupbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Command Center";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ArduinoInterfaceGroupbox.ResumeLayout(false);
            this.ArduinoInterfaceGroupbox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ConnectionArduinoGroupbox.ResumeLayout(false);
            this.ConnectionArduinoGroupbox.PerformLayout();
            this.SQLInterfaceGroupbox.ResumeLayout(false);
            this.SQLInterfaceGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ArduinoInterfaceGroupbox;
        private System.Windows.Forms.GroupBox SQLInterfaceGroupbox;
        private System.Windows.Forms.Label BoardPortLabel;
        private System.Windows.Forms.TextBox BoardPortTextBox;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.TextBox BaudRateTextBox;
        private System.Windows.Forms.Button DisconnectArduinoButton;
        private System.Windows.Forms.Button ArduinoChangeValuesButton;
        private System.Windows.Forms.TextBox ArduinoConnectionTextBox;
        private System.Windows.Forms.Button ConnectArduinoButton;
        private System.Windows.Forms.GroupBox ConnectionArduinoGroupbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ArduinoMessageSent;
        private System.Windows.Forms.TextBox PortSQLTextbox;
        private System.Windows.Forms.Label PortSQLLabel;
        private System.Windows.Forms.TextBox DatasourceSQLTextbox;
        private System.Windows.Forms.Label DataSourceSQLLabel;
        private System.Windows.Forms.TextBox PasswordSQLTextbox;
        private System.Windows.Forms.Label PasswordSQLLabel;
        private System.Windows.Forms.TextBox UsernameSQLTextbox;
        private System.Windows.Forms.Label UsernameSQLLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ConnectionChangeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CameraListComboBox;
        private System.Windows.Forms.Button StartCameraButton;
        private System.Windows.Forms.Button StopCameraButton;
        private System.Windows.Forms.Timer TimerVideo;
        private System.Windows.Forms.Timer Refreshtimer;
        private System.Windows.Forms.PictureBox testbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button MotorStartButton;
        private System.Windows.Forms.Button StopMotorButton;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer ResultTimer;
        private System.Windows.Forms.Button WinnerButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox BetaTextBox;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button StopGameButton;
    }
}

