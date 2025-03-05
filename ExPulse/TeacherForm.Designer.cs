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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.examGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SaveGradeButton = new System.Windows.Forms.Button();
            this.gradeGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddExamButton = new System.Windows.Forms.Button();
            this.AuditoriumTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.examGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // examGrid
            // 
            this.examGrid.AllowUserToAddRows = false;
            this.examGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.examGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.examGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examGrid.Location = new System.Drawing.Point(0, 0);
            this.examGrid.Name = "examGrid";
            this.examGrid.ReadOnly = true;
            this.examGrid.RowHeadersVisible = false;
            this.examGrid.RowHeadersWidth = 51;
            this.examGrid.RowTemplate.Height = 29;
            this.examGrid.Size = new System.Drawing.Size(1174, 609);
            this.examGrid.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SaveGradeButton);
            this.tabPage3.Controls.Add(this.gradeGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1174, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оценка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveGradeButton
            // 
            this.SaveGradeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveGradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGradeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveGradeButton.Location = new System.Drawing.Point(0, 550);
            this.SaveGradeButton.Name = "SaveGradeButton";
            this.SaveGradeButton.Size = new System.Drawing.Size(1174, 59);
            this.SaveGradeButton.TabIndex = 9;
            this.SaveGradeButton.Text = "Сохранить";
            this.SaveGradeButton.UseVisualStyleBackColor = false;
            this.SaveGradeButton.Click += new System.EventHandler(this.SaveGradeButton_Click);
            // 
            // gradeGrid
            // 
            this.gradeGrid.AllowUserToAddRows = false;
            this.gradeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gradeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gradeGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gradeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGrid.Location = new System.Drawing.Point(0, 0);
            this.gradeGrid.Name = "gradeGrid";
            this.gradeGrid.RowHeadersVisible = false;
            this.gradeGrid.RowHeadersWidth = 51;
            this.gradeGrid.RowTemplate.Height = 29;
            this.gradeGrid.Size = new System.Drawing.Size(1178, 544);
            this.gradeGrid.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddExamButton);
            this.tabPage2.Controls.Add(this.AuditoriumTextBox);
            this.tabPage2.Controls.Add(this.TimeTextBox);
            this.tabPage2.Controls.Add(this.DateTextBox);
            this.tabPage2.Controls.Add(this.NameTextBox);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Экзамен";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddExamButton
            // 
            this.AddExamButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddExamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExamButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddExamButton.Location = new System.Drawing.Point(492, 333);
            this.AddExamButton.Name = "AddExamButton";
            this.AddExamButton.Size = new System.Drawing.Size(171, 59);
            this.AddExamButton.TabIndex = 9;
            this.AddExamButton.Text = "Добавить";
            this.AddExamButton.UseVisualStyleBackColor = false;
            this.AddExamButton.Click += new System.EventHandler(this.AddExamButton_Click);
            // 
            // AuditoriumTextBox
            // 
            this.AuditoriumTextBox.Location = new System.Drawing.Point(492, 241);
            this.AuditoriumTextBox.Name = "AuditoriumTextBox";
            this.AuditoriumTextBox.PlaceholderText = " Аудитория";
            this.AuditoriumTextBox.Size = new System.Drawing.Size(171, 27);
            this.AuditoriumTextBox.TabIndex = 14;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(492, 195);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.PlaceholderText = " Время (10:30)";
            this.TimeTextBox.Size = new System.Drawing.Size(171, 27);
            this.TimeTextBox.TabIndex = 13;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(492, 150);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.PlaceholderText = " Дата (2024-12-15)";
            this.DateTextBox.Size = new System.Drawing.Size(171, 27);
            this.DateTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(492, 107);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = " Название";
            this.NameTextBox.Size = new System.Drawing.Size(171, 27);
            this.NameTextBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(381, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 376);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(381, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "Запишите данные экзамена";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "Преподаватель: Смагина Анна Владимировна";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1063, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 59);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExPulse";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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