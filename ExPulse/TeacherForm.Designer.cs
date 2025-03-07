namespace ExPulse
{
    partial class TeacherForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            examGrid = new DataGridView();
            tabPage3 = new TabPage();
            SaveGradeButton = new Button();
            gradeGrid = new DataGridView();
            tabPage2 = new TabPage();
            AddExamButton = new Button();
            AuditoriumTextBox = new TextBox();
            TimeTextBox = new TextBox();
            DateTextBox = new TextBox();
            NameTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            exitButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examGrid).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradeGrid).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 45);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 482);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(examGrid);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1026, 454);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Расписание";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // examGrid
            // 
            examGrid.AllowUserToAddRows = false;
            examGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            examGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            examGrid.BackgroundColor = SystemColors.ControlLight;
            examGrid.BorderStyle = BorderStyle.None;
            examGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examGrid.Dock = DockStyle.Fill;
            examGrid.Location = new Point(3, 2);
            examGrid.Margin = new Padding(3, 2, 3, 2);
            examGrid.Name = "examGrid";
            examGrid.ReadOnly = true;
            examGrid.RowHeadersVisible = false;
            examGrid.RowHeadersWidth = 51;
            examGrid.RowTemplate.Height = 29;
            examGrid.Size = new Size(1020, 450);
            examGrid.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(SaveGradeButton);
            tabPage3.Controls.Add(gradeGrid);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1026, 454);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Оценка";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveGradeButton
            // 
            SaveGradeButton.BackColor = SystemColors.GradientActiveCaption;
            SaveGradeButton.Dock = DockStyle.Bottom;
            SaveGradeButton.FlatStyle = FlatStyle.Flat;
            SaveGradeButton.Font = new Font("Segoe UI", 10.2F);
            SaveGradeButton.Location = new Point(0, 410);
            SaveGradeButton.Margin = new Padding(3, 2, 3, 2);
            SaveGradeButton.Name = "SaveGradeButton";
            SaveGradeButton.Size = new Size(1026, 44);
            SaveGradeButton.TabIndex = 9;
            SaveGradeButton.Text = "Сохранить";
            SaveGradeButton.UseVisualStyleBackColor = false;
            SaveGradeButton.Click += SaveGradeButton_Click;
            // 
            // gradeGrid
            // 
            gradeGrid.AllowUserToAddRows = false;
            gradeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gradeGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gradeGrid.BackgroundColor = SystemColors.ControlLight;
            gradeGrid.BorderStyle = BorderStyle.None;
            gradeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradeGrid.Dock = DockStyle.Fill;
            gradeGrid.Location = new Point(0, 0);
            gradeGrid.Margin = new Padding(3, 2, 3, 2);
            gradeGrid.Name = "gradeGrid";
            gradeGrid.RowHeadersVisible = false;
            gradeGrid.RowHeadersWidth = 51;
            gradeGrid.RowTemplate.Height = 29;
            gradeGrid.Size = new Size(1026, 454);
            gradeGrid.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(AddExamButton);
            tabPage2.Controls.Add(AuditoriumTextBox);
            tabPage2.Controls.Add(TimeTextBox);
            tabPage2.Controls.Add(DateTextBox);
            tabPage2.Controls.Add(NameTextBox);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1026, 454);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Экзамен";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddExamButton
            // 
            AddExamButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddExamButton.BackColor = SystemColors.GradientInactiveCaption;
            AddExamButton.FlatStyle = FlatStyle.Flat;
            AddExamButton.Font = new Font("Segoe UI", 10.2F);
            AddExamButton.Location = new Point(430, 250);
            AddExamButton.Margin = new Padding(3, 2, 3, 2);
            AddExamButton.Name = "AddExamButton";
            AddExamButton.Size = new Size(150, 44);
            AddExamButton.TabIndex = 9;
            AddExamButton.Text = "Добавить";
            AddExamButton.UseVisualStyleBackColor = false;
            AddExamButton.Click += AddExamButton_Click;
            // 
            // AuditoriumTextBox
            // 
            AuditoriumTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AuditoriumTextBox.Location = new Point(430, 181);
            AuditoriumTextBox.Margin = new Padding(3, 2, 3, 2);
            AuditoriumTextBox.Name = "AuditoriumTextBox";
            AuditoriumTextBox.PlaceholderText = " Аудитория";
            AuditoriumTextBox.Size = new Size(150, 23);
            AuditoriumTextBox.TabIndex = 14;
            // 
            // TimeTextBox
            // 
            TimeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TimeTextBox.Location = new Point(430, 146);
            TimeTextBox.Margin = new Padding(3, 2, 3, 2);
            TimeTextBox.Name = "TimeTextBox";
            TimeTextBox.PlaceholderText = " Время (10:30)";
            TimeTextBox.Size = new Size(150, 23);
            TimeTextBox.TabIndex = 13;
            // 
            // DateTextBox
            // 
            DateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DateTextBox.Location = new Point(430, 112);
            DateTextBox.Margin = new Padding(3, 2, 3, 2);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.PlaceholderText = " Дата (2024-12-15)";
            DateTextBox.Size = new Size(150, 23);
            DateTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(430, 80);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = " Название";
            NameTextBox.Size = new Size(150, 23);
            NameTextBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(333, 64);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 282);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(333, 22);
            label1.Name = "label1";
            label1.Size = new Size(348, 42);
            label1.TabIndex = 9;
            label1.Text = "Запишите данные экзамена";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 0);
            label3.Name = "label3";
            label3.Size = new Size(348, 44);
            label3.TabIndex = 5;
            label3.Text = "Преподаватель: Смагина Анна Владимировна";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.BackColor = SystemColors.GradientActiveCaption;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 10.2F);
            exitButton.Location = new Point(930, 9);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 44);
            exitButton.TabIndex = 8;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1034, 527);
            Controls.Add(exitButton);
            Controls.Add(tabControl1);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExPulse";
            Load += TeacherForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examGrid).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradeGrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Button exitButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Button AddExamButton;
        private TextBox AuditoriumTextBox;
        private TextBox TimeTextBox;
        private TextBox DateTextBox;
        private TextBox NameTextBox;
        private TabPage tabPage3;
        private DataGridView gradeGrid;
        private DataGridView examGrid;
        private Button SaveGradeButton;
    }
}