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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.calendarGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.requestAcceptButton = new System.Windows.Forms.Button();
            this.requestDateLabel = new System.Windows.Forms.Label();
            this.requestNameLable = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
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
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveButton);
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(517, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(145, 41);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.dateLabel.Location = new System.Drawing.Point(11, 11);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 41);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата";
            // 
            // calendarGrid
            // 
            this.calendarGrid.AllowUserToDeleteRows = false;
            this.calendarGrid.AllowUserToResizeColumns = false;
            this.calendarGrid.AllowUserToResizeRows = false;
            this.calendarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.calendarGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.calendarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarGrid.Location = new System.Drawing.Point(6, 58);
            this.calendarGrid.Name = "calendarGrid";
            this.calendarGrid.RowHeadersVisible = false;
            this.calendarGrid.RowHeadersWidth = 51;
            this.calendarGrid.RowTemplate.Height = 29;
            this.calendarGrid.Size = new System.Drawing.Size(1141, 635);
            this.calendarGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.requestAcceptButton);
            this.tabPage2.Controls.Add(this.requestDateLabel);
            this.tabPage2.Controls.Add(this.requestNameLable);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выходные дни";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Согласовать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(152, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "2024.11.29";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Салима";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requestAcceptButton
            // 
            this.requestAcceptButton.Location = new System.Drawing.Point(278, 20);
            this.requestAcceptButton.Name = "requestAcceptButton";
            this.requestAcceptButton.Size = new System.Drawing.Size(120, 45);
            this.requestAcceptButton.TabIndex = 2;
            this.requestAcceptButton.Text = "Согласовать";
            this.requestAcceptButton.UseVisualStyleBackColor = true;
            // 
            // requestDateLabel
            // 
            this.requestDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestDateLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.requestDateLabel.Location = new System.Drawing.Point(152, 20);
            this.requestDateLabel.Name = "requestDateLabel";
            this.requestDateLabel.Size = new System.Drawing.Size(120, 45);
            this.requestDateLabel.TabIndex = 1;
            this.requestDateLabel.Text = "2024.11.27";
            this.requestDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requestNameLable
            // 
            this.requestNameLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestNameLable.Location = new System.Drawing.Point(26, 20);
            this.requestNameLable.Name = "requestNameLable";
            this.requestNameLable.Size = new System.Drawing.Size(120, 45);
            this.requestNameLable.TabIndex = 0;
            this.requestNameLable.Text = "Надежда";
            this.requestNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1099, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(71, 51);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(938, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(155, 51);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView calendarGrid;
        private TabPage tabPage2;
        private Label requestDateLabel;
        private Label requestNameLable;
        private Label dateLabel;
        private PictureBox forwardButton;
        private PictureBox backButton;
        private Button saveButton;
        private Button exitButton;
        private Label nameLabel;
        private Button requestAcceptButton;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}