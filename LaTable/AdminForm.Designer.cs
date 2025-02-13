namespace LaTable
{
    partial class AdminForm
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            clearButton = new Button();
            makeButton = new Button();
            saveButton = new Button();
            backButton = new PictureBox();
            forwardButton = new PictureBox();
            dateLabel = new Label();
            calendarGrid = new DataGridView();
            tabPage2 = new TabPage();
            datePanel = new Panel();
            tabPage3 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exitButton = new Button();
            nameLabel = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forwardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarGrid).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(10, 40);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1013, 515);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(clearButton);
            tabPage1.Controls.Add(makeButton);
            tabPage1.Controls.Add(saveButton);
            tabPage1.Controls.Add(backButton);
            tabPage1.Controls.Add(forwardButton);
            tabPage1.Controls.Add(dateLabel);
            tabPage1.Controls.Add(calendarGrid);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1005, 487);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Расписание";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(262, 4);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(158, 38);
            clearButton.TabIndex = 6;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // makeButton
            // 
            makeButton.Location = new Point(588, 4);
            makeButton.Margin = new Padding(3, 2, 3, 2);
            makeButton.Name = "makeButton";
            makeButton.Size = new Size(158, 38);
            makeButton.TabIndex = 5;
            makeButton.Text = "Составить расписание";
            makeButton.UseVisualStyleBackColor = true;
            makeButton.Click += makeButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(425, 4);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(158, 38);
            saveButton.TabIndex = 4;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // backButton
            // 
            backButton.Image = Resources.backArrow;
            backButton.Location = new Point(912, 8);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(36, 31);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 3;
            backButton.TabStop = false;
            // 
            // forwardButton
            // 
            forwardButton.Image = Resources.forwardArrow;
            forwardButton.Location = new Point(953, 8);
            forwardButton.Margin = new Padding(3, 2, 3, 2);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(36, 31);
            forwardButton.SizeMode = PictureBoxSizeMode.Zoom;
            forwardButton.TabIndex = 2;
            forwardButton.TabStop = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(2, 7);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(65, 32);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Дата";
            // 
            // calendarGrid
            // 
            calendarGrid.AllowUserToAddRows = false;
            calendarGrid.AllowUserToDeleteRows = false;
            calendarGrid.AllowUserToResizeColumns = false;
            calendarGrid.AllowUserToResizeRows = false;
            calendarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            calendarGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            calendarGrid.BackgroundColor = SystemColors.Control;
            calendarGrid.BorderStyle = BorderStyle.None;
            calendarGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calendarGrid.Location = new Point(5, 44);
            calendarGrid.Margin = new Padding(3, 2, 3, 2);
            calendarGrid.Name = "calendarGrid";
            calendarGrid.RowHeadersVisible = false;
            calendarGrid.RowHeadersWidth = 51;
            calendarGrid.RowTemplate.Height = 29;
            calendarGrid.Size = new Size(996, 442);
            calendarGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(datePanel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1005, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Выходные дни";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // datePanel
            // 
            datePanel.AutoScroll = true;
            datePanel.Location = new Point(6, 5);
            datePanel.Name = "datePanel";
            datePanel.Size = new Size(428, 477);
            datePanel.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1005, 487);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Аннотация";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = Color.Magenta;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(392, 323);
            label6.Name = "label6";
            label6.Size = new Size(234, 44);
            label6.TabIndex = 7;
            label6.Text = "RDM - R";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.SpringGreen;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(392, 273);
            label5.Name = "label5";
            label5.Size = new Size(234, 44);
            label5.TabIndex = 6;
            label5.Text = "Выходной - ВХ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Red;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(392, 221);
            label4.Name = "label4";
            label4.Size = new Size(234, 44);
            label4.TabIndex = 5;
            label4.Text = "Промежуток - П";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.CadetBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(392, 170);
            label3.Name = "label3";
            label3.Size = new Size(234, 44);
            label3.TabIndex = 4;
            label3.Text = "Ночь - Н";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Turquoise;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(392, 118);
            label2.Name = "label2";
            label2.Size = new Size(234, 44);
            label2.TabIndex = 3;
            label2.Text = "Вечер - В";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(392, 67);
            label1.Name = "label1";
            label1.Size = new Size(234, 44);
            label1.TabIndex = 2;
            label1.Text = "Утро - У";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(962, 9);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(62, 38);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(821, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(136, 38);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Имя";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AdminForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 565);
            Controls.Add(nameLabel);
            Controls.Add(exitButton);
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)forwardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarGrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private DataGridView calendarGrid;
        private TabPage tabPage2;
        private Label dateLabel;
        private PictureBox forwardButton;
        private PictureBox backButton;
        private Button saveButton;
        private Button exitButton;
        private Label nameLabel;
        private TabPage tabPage3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button clearButton;
        private Button makeButton;
        private Panel datePanel;
    }
}