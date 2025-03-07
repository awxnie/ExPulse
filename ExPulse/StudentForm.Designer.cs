namespace ExPulse
{
    partial class StudentForm
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
            label3 = new Label();
            exitButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            examGrid = new DataGridView();
            tabPage3 = new TabPage();
            gradeGrid = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examGrid).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradeGrid).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 4);
            label3.Name = "label3";
            label3.Size = new Size(348, 30);
            label3.TabIndex = 6;
            label3.Text = "Студент: Фламберг Алексей Вадимович";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.GradientActiveCaption;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 10.2F);
            exitButton.Location = new Point(930, 9);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 44);
            exitButton.TabIndex = 9;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 40);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 482);
            tabControl1.TabIndex = 10;
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
            tabPage3.Controls.Add(gradeGrid);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1026, 454);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Оценка";
            tabPage3.UseVisualStyleBackColor = true;
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
            gradeGrid.ReadOnly = true;
            gradeGrid.RowHeadersVisible = false;
            gradeGrid.RowHeadersWidth = 51;
            gradeGrid.RowTemplate.Height = 29;
            gradeGrid.Size = new Size(1026, 454);
            gradeGrid.TabIndex = 1;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1034, 527);
            Controls.Add(exitButton);
            Controls.Add(tabControl1);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExPulse";
            Load += StudentForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examGrid).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradeGrid).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Label label3;
        private Button exitButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView examGrid;
        private TabPage tabPage3;
        private DataGridView gradeGrid;
    }
}