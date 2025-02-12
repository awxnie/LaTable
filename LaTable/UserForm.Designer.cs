namespace LaTable
{
    partial class UserForm
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
            backButton = new PictureBox();
            forwardButton = new PictureBox();
            dateLabel = new Label();
            calendarGrid = new DataGridView();
            tabPage2 = new TabPage();
            inputButton = new Button();
            dateTextBox = new TextBox();
            label1 = new Label();
            nameLabel = new Label();
            exitButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forwardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarGrid).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 40);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1013, 515);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            dateLabel.Location = new Point(-2, 7);
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
            calendarGrid.ReadOnly = true;
            calendarGrid.RowHeadersVisible = false;
            calendarGrid.RowHeadersWidth = 51;
            calendarGrid.RowTemplate.Height = 29;
            calendarGrid.Size = new Size(996, 436);
            calendarGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(inputButton);
            tabPage2.Controls.Add(dateTextBox);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1005, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказать выходные";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // inputButton
            // 
            inputButton.Location = new Point(440, 206);
            inputButton.Margin = new Padding(3, 2, 3, 2);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(148, 42);
            inputButton.TabIndex = 4;
            inputButton.Text = "Ввод";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // dateTextBox
            // 
            dateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTextBox.Location = new Point(440, 160);
            dateTextBox.Margin = new Padding(3, 2, 3, 2);
            dateTextBox.Multiline = true;
            dateTextBox.Name = "dateTextBox";
            dateTextBox.PlaceholderText = "Дата (01.01.2025)";
            dateTextBox.Size = new Size(148, 32);
            dateTextBox.TabIndex = 1;
            dateTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(417, 118);
            label1.Name = "label1";
            label1.Size = new Size(197, 21);
            label1.TabIndex = 0;
            label1.Text = "Выберите дату выходного";
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(821, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(136, 38);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Имя";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(962, 9);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(62, 38);
            exitButton.TabIndex = 3;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 565);
            Controls.Add(exitButton);
            Controls.Add(nameLabel);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)forwardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarGrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox backButton;
        private PictureBox forwardButton;
        private Label dateLabel;
        private DataGridView calendarGrid;
        private TabPage tabPage2;
        private Label label1;
        private Button inputButton;
        private TextBox dateTextBox;
        private Label nameLabel;
        private Button exitButton;
    }
}