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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.calendarGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inputButton = new System.Windows.Forms.Button();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 687);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.backButton);
            this.tabPage1.Controls.Add(this.forwardButton);
            this.tabPage1.Controls.Add(this.dateLabel);
            this.tabPage1.Controls.Add(this.calendarGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1150, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Image = global::LaTable.Resources.backArrow;
            this.backButton.Location = new System.Drawing.Point(1042, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(41, 41);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 3;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Image = global::LaTable.Resources.forwardArrow;
            this.forwardButton.Location = new System.Drawing.Point(1089, 11);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(41, 41);
            this.forwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forwardButton.TabIndex = 2;
            this.forwardButton.TabStop = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(-2, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 41);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата";
            // 
            // calendarGrid
            // 
            this.calendarGrid.AllowUserToAddRows = false;
            this.calendarGrid.AllowUserToDeleteRows = false;
            this.calendarGrid.AllowUserToResizeColumns = false;
            this.calendarGrid.AllowUserToResizeRows = false;
            this.calendarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.calendarGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.calendarGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.calendarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarGrid.Location = new System.Drawing.Point(6, 58);
            this.calendarGrid.Name = "calendarGrid";
            this.calendarGrid.ReadOnly = true;
            this.calendarGrid.RowHeadersVisible = false;
            this.calendarGrid.RowHeadersWidth = 51;
            this.calendarGrid.RowTemplate.Height = 29;
            this.calendarGrid.Size = new System.Drawing.Size(1138, 581);
            this.calendarGrid.TabIndex = 0;
            this.calendarGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarGrid_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inputButton);
            this.tabPage2.Controls.Add(this.dayTextBox);
            this.tabPage2.Controls.Add(this.monthTextBox);
            this.tabPage2.Controls.Add(this.yearTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказать выходные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(701, 18);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(94, 29);
            this.inputButton.TabIndex = 4;
            this.inputButton.Text = "Ввод";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(547, 20);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.PlaceholderText = "День";
            this.dayTextBox.Size = new System.Drawing.Size(125, 27);
            this.dayTextBox.TabIndex = 3;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(391, 20);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.PlaceholderText = "Месяц (Номер)";
            this.monthTextBox.Size = new System.Drawing.Size(125, 27);
            this.monthTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(239, 20);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.PlaceholderText = "Год (Полный)";
            this.yearTextBox.Size = new System.Drawing.Size(125, 27);
            this.yearTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите дату выходного";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(938, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(155, 51);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1099, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(71, 51);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private TextBox dayTextBox;
        private TextBox monthTextBox;
        private TextBox yearTextBox;
        private Label nameLabel;
        private Button exitButton;
    }
}