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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.calendarGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 54);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1158, 687);
            this.tabControl.TabIndex = 0;
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
            this.saveButton.Location = new System.Drawing.Point(517, 9);
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
            this.dateLabel.Location = new System.Drawing.Point(2, 9);
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
            this.calendarGrid.RowHeadersVisible = false;
            this.calendarGrid.RowHeadersWidth = 51;
            this.calendarGrid.RowTemplate.Height = 29;
            this.calendarGrid.Size = new System.Drawing.Size(1138, 590);
            this.calendarGrid.TabIndex = 0;
            this.calendarGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarGrid_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выходные дни";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1150, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Аннотация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Magenta;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(448, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 58);
            this.label6.TabIndex = 7;
            this.label6.Text = "RDM - R";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SpringGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(448, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 58);
            this.label5.TabIndex = 6;
            this.label5.Text = "Выходной - ВХ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(448, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 58);
            this.label4.TabIndex = 5;
            this.label4.Text = "Промежуток - П";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(448, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ночь - Н";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(448, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вечер - В";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(448, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Утро - У";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}