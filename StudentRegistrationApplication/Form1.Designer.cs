namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Title = new Label();
            LNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            LName = new TextBox();
            FName = new TextBox();
            MName = new TextBox();
            GenderLabel = new Label();
            Male = new CheckBox();
            female = new CheckBox();
            BDay = new Label();
            Day = new ComboBox();
            month = new ComboBox();
            year = new ComboBox();
            programLabel = new Label();
            program = new ComboBox();
            register = new Button();
            picButton = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.BackColor = Color.PaleTurquoise;
            Title.Font = new Font("Times New Roman", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Title.Location = new Point(169, 9);
            Title.Name = "Title";
            Title.Size = new Size(314, 31);
            Title.TabIndex = 0;
            Title.Text = "Student Registration Form";
            // 
            // LNameLabel
            // 
            LNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LNameLabel.AutoSize = true;
            LNameLabel.BackColor = Color.PaleTurquoise;
            LNameLabel.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNameLabel.Location = new Point(16, 60);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(88, 19);
            LNameLabel.TabIndex = 1;
            LNameLabel.Text = "Last Name: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 113);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 2;
            label1.Text = "First Name: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 175);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 3;
            label2.Text = "Middle Name: ";
            // 
            // LName
            // 
            LName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LName.BackColor = SystemColors.ActiveCaption;
            LName.Font = new Font("High Tower Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LName.Location = new Point(50, 83);
            LName.Name = "LName";
            LName.Size = new Size(420, 25);
            LName.TabIndex = 4;
            LName.TextChanged += textBox1_TextChanged;
            // 
            // FName
            // 
            FName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FName.BackColor = SystemColors.ActiveCaption;
            FName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FName.Location = new Point(50, 135);
            FName.Name = "FName";
            FName.Size = new Size(420, 27);
            FName.TabIndex = 5;
            FName.TextChanged += FName_TextChanged;
            // 
            // MName
            // 
            MName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MName.BackColor = SystemColors.ActiveCaption;
            MName.Font = new Font("High Tower Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MName.Location = new Point(50, 197);
            MName.Name = "MName";
            MName.Size = new Size(420, 25);
            MName.TabIndex = 6;
            // 
            // GenderLabel
            // 
            GenderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GenderLabel.AutoSize = true;
            GenderLabel.BackColor = Color.PaleTurquoise;
            GenderLabel.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderLabel.Location = new Point(18, 239);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(65, 19);
            GenderLabel.TabIndex = 7;
            GenderLabel.Text = "Gender: ";
            GenderLabel.Click += label3_Click;
            // 
            // Male
            // 
            Male.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Male.AutoSize = true;
            Male.BackColor = SystemColors.ActiveCaption;
            Male.Location = new Point(119, 241);
            Male.Name = "Male";
            Male.Size = new Size(52, 19);
            Male.TabIndex = 8;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = false;
            // 
            // female
            // 
            female.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            female.AutoSize = true;
            female.BackColor = SystemColors.ActiveCaption;
            female.Location = new Point(203, 241);
            female.Name = "female";
            female.Size = new Size(64, 19);
            female.TabIndex = 9;
            female.Text = "Female";
            female.UseVisualStyleBackColor = false;
            female.CheckedChanged += female_CheckedChanged;
            // 
            // BDay
            // 
            BDay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BDay.AutoSize = true;
            BDay.BackColor = Color.PaleTurquoise;
            BDay.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BDay.Location = new Point(18, 273);
            BDay.Name = "BDay";
            BDay.Size = new Size(100, 19);
            BDay.TabIndex = 10;
            BDay.Text = "Date of Birth:";
            // 
            // Day
            // 
            Day.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Day.BackColor = SystemColors.ActiveCaption;
            Day.FormattingEnabled = true;
            Day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            Day.Location = new Point(50, 295);
            Day.Name = "Day";
            Day.Size = new Size(121, 23);
            Day.TabIndex = 11;
            Day.Text = "Day";
            Day.SelectedIndexChanged += Day_SelectedIndexChanged;
            // 
            // month
            // 
            month.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            month.BackColor = SystemColors.ActiveCaption;
            month.FormattingEnabled = true;
            month.Items.AddRange(new object[] { "January", "", "February", "", "March", "", "April", "", "May", "", "June", "", "July", "", "August", "", "September", "", "October", "", "November", "", "December" });
            month.Location = new Point(203, 295);
            month.Name = "month";
            month.Size = new Size(121, 23);
            month.TabIndex = 12;
            month.Text = "Month";
            month.SelectedIndexChanged += month_SelectedIndexChanged;
            // 
            // year
            // 
            year.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            year.BackColor = SystemColors.InactiveCaption;
            year.FormattingEnabled = true;
            year.Items.AddRange(new object[] { "1950  ", "1951  ", "1952  ", "1953  ", "1954  ", "1955  ", "1956  ", "1957  ", "1958  ", "1959  ", "1960  ", "1961  ", "1962  ", "1963  ", "1964  ", "1965  ", "1966  ", "1967  ", "1968  ", "1969  ", "1970  ", "1971  ", "1972  ", "1973  ", "1974  ", "1975  ", "1976  ", "1977  ", "1978  ", "1979  ", "1980  ", "1981  ", "1982  ", "1983  ", "1984  ", "1985  ", "1986  ", "1987  ", "1988  ", "1989  ", "1990  ", "1991  ", "1992  ", "1993  ", "1994  ", "1995  ", "1996  ", "1997  ", "1998  ", "1999  ", "2000  ", "2001  ", "2002  ", "2003  ", "2004  ", "2005  ", "2006  ", "2007  ", "2008  ", "2009  ", "2010  ", "2011  ", "2012  ", "2013  ", "2014  ", "2015  ", "2016  ", "2017  ", "2018  ", "2019  ", "2020  ", "2021  ", "2022  ", "2023  ", "2024 " });
            year.Location = new Point(349, 295);
            year.Name = "year";
            year.Size = new Size(121, 23);
            year.TabIndex = 13;
            year.Text = "Year";
            // 
            // programLabel
            // 
            programLabel.AutoSize = true;
            programLabel.BackColor = Color.PaleTurquoise;
            programLabel.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programLabel.Location = new Point(12, 336);
            programLabel.Name = "programLabel";
            programLabel.Size = new Size(131, 19);
            programLabel.TabIndex = 14;
            programLabel.Text = "Program to apply:";
            // 
            // program
            // 
            program.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            program.BackColor = SystemColors.ActiveCaption;
            program.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            program.FormattingEnabled = true;
            program.Items.AddRange(new object[] { "BS in Information Technology (BSIT)", "BS in Computer Science (BSCS)", "BS in Information Systems (BSIS)", "2-yr. Information Technology (IT)", "2-yr. Associate in Computer Technology (ACT)", "BS in Business Administration (BSBA)", "BS in Accountancy (BSA)", "BS in Accounting Information System (BSAIS)", "BS in Management Accounting (BSMA)", "BS in Retail Technology and Consumer Science (BSRTCS)", "2-yr. Associate in Retail Technology (ART)", "BS in Hospitality Management (BSHM)", "BS in Culinary Management (BSCM)", "3-yr. Hotel and Restaurant Administration (HRA)", "2-yr. Hospitality and Restaurant Services (HRS)", "BS in Tourism Management (BSTM)", "BS in Computer Engineering (BSCpE)", "BA in Communication (BACOMM)", "Bachelor of Multimedia Arts (BMMA)", "Bachelor of Arts in Psychology", "Bachelor of Science in Marine Transportation (BSMT)", "Bachelor of Science in Marine Engineering (BSMarE)", "Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)", "Bachelor of Science in Criminology" });
            program.Location = new Point(50, 364);
            program.Name = "program";
            program.Size = new Size(420, 28);
            program.TabIndex = 15;
            program.Text = "select a program";
            // 
            // register
            // 
            register.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            register.BackColor = SystemColors.ActiveCaption;
            register.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register.Location = new Point(146, 398);
            register.Name = "register";
            register.Size = new Size(165, 40);
            register.TabIndex = 16;
            register.Text = "Register Account";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // picButton
            // 
            picButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picButton.BackColor = SystemColors.ActiveCaption;
            picButton.Location = new Point(582, 332);
            picButton.Name = "picButton";
            picButton.Size = new Size(121, 23);
            picButton.TabIndex = 17;
            picButton.Text = "Select Picture";
            picButton.UseVisualStyleBackColor = false;
            picButton.Click += picButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(525, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(picButton);
            Controls.Add(register);
            Controls.Add(program);
            Controls.Add(programLabel);
            Controls.Add(year);
            Controls.Add(month);
            Controls.Add(Day);
            Controls.Add(BDay);
            Controls.Add(female);
            Controls.Add(Male);
            Controls.Add(GenderLabel);
            Controls.Add(MName);
            Controls.Add(FName);
            Controls.Add(LName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LNameLabel);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label LNameLabel;
        private Label label1;
        private Label label2;
        private TextBox LName;
        private TextBox FName;
        private TextBox MName;
        private Label GenderLabel;
        private CheckBox Male;
        private CheckBox female;
        private Label BDay;
        private ComboBox Day;
        private ComboBox month;
        private ComboBox year;
        private Label programLabel;
        private ComboBox program;
        private Button register;
        private Button picButton;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}
