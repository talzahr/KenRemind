namespace KenRemind
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_AddTask = new System.Windows.Forms.Button();
            this.dataGridView_Reminders = new System.Windows.Forms.DataGridView();
            this.label_Reminders = new System.Windows.Forms.Label();
            this.textBox_Desc = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Hour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Min = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Period = new System.Windows.Forms.ComboBox();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reminders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddTask
            // 
            this.button_AddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_AddTask.Location = new System.Drawing.Point(532, 436);
            this.button_AddTask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_AddTask.Name = "button_AddTask";
            this.button_AddTask.Size = new System.Drawing.Size(171, 55);
            this.button_AddTask.TabIndex = 1;
            this.button_AddTask.Text = "Add Task";
            this.button_AddTask.UseVisualStyleBackColor = true;
            this.button_AddTask.Click += new System.EventHandler(this.button_AddTask_Click);
            // 
            // dataGridView_Reminders
            // 
            this.dataGridView_Reminders.AllowUserToAddRows = false;
            this.dataGridView_Reminders.AllowUserToOrderColumns = true;
            this.dataGridView_Reminders.AllowUserToResizeRows = false;
            this.dataGridView_Reminders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Reminders.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_Reminders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Reminders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Reminders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Reminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Reminders.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Reminders.Location = new System.Drawing.Point(13, 37);
            this.dataGridView_Reminders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_Reminders.MultiSelect = false;
            this.dataGridView_Reminders.Name = "dataGridView_Reminders";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Reminders.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Brown;
            this.dataGridView_Reminders.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Reminders.ShowEditingIcon = false;
            this.dataGridView_Reminders.Size = new System.Drawing.Size(766, 375);
            this.dataGridView_Reminders.TabIndex = 2;
            // 
            // label_Reminders
            // 
            this.label_Reminders.AutoSize = true;
            this.label_Reminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Reminders.Location = new System.Drawing.Point(11, 9);
            this.label_Reminders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Reminders.Name = "label_Reminders";
            this.label_Reminders.Size = new System.Drawing.Size(124, 25);
            this.label_Reminders.TabIndex = 3;
            this.label_Reminders.Text = "Reminders";
            // 
            // textBox_Desc
            // 
            this.textBox_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Desc.Location = new System.Drawing.Point(86, 503);
            this.textBox_Desc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Desc.MaxLength = 64;
            this.textBox_Desc.Name = "textBox_Desc";
            this.textBox_Desc.Size = new System.Drawing.Size(617, 29);
            this.textBox_Desc.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(86, 461);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(158, 30);
            this.dateTimePicker.TabIndex = 5;
            // 
            // numericUpDown_Hour
            // 
            this.numericUpDown_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Hour.Location = new System.Drawing.Point(288, 461);
            this.numericUpDown_Hour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Hour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_Hour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Hour.Name = "numericUpDown_Hour";
            this.numericUpDown_Hour.Size = new System.Drawing.Size(50, 30);
            this.numericUpDown_Hour.TabIndex = 6;
            this.numericUpDown_Hour.Tag = "01";
            this.numericUpDown_Hour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Min
            // 
            this.numericUpDown_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Min.Location = new System.Drawing.Point(346, 461);
            this.numericUpDown_Min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Min.Name = "numericUpDown_Min";
            this.numericUpDown_Min.Size = new System.Drawing.Size(53, 30);
            this.numericUpDown_Min.TabIndex = 7;
            // 
            // comboBox_Period
            // 
            this.comboBox_Period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Period.FormattingEnabled = true;
            this.comboBox_Period.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox_Period.Location = new System.Drawing.Point(406, 459);
            this.comboBox_Period.MaxDropDownItems = 2;
            this.comboBox_Period.Name = "comboBox_Period";
            this.comboBox_Period.Size = new System.Drawing.Size(68, 32);
            this.comboBox_Period.TabIndex = 8;
            // 
            // label_DateTime
            // 
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Location = new System.Drawing.Point(81, 433);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(400, 25);
            this.label_DateTime.TabIndex = 9;
            this.label_DateTime.Text = "Date                          Hour  Min    AM/PM";
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Version.ForeColor = System.Drawing.Color.DimGray;
            this.label_Version.Location = new System.Drawing.Point(738, 516);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(31, 16);
            this.label_Version.TabIndex = 10;
            this.label_Version.Text = "v0.1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(817, 550);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.label_DateTime);
            this.Controls.Add(this.comboBox_Period);
            this.Controls.Add(this.numericUpDown_Min);
            this.Controls.Add(this.numericUpDown_Hour);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox_Desc);
            this.Controls.Add(this.label_Reminders);
            this.Controls.Add(this.dataGridView_Reminders);
            this.Controls.Add(this.button_AddTask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "mainForm";
            this.Text = "Reminders for Ken";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reminders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_AddTask;
        private System.Windows.Forms.DataGridView dataGridView_Reminders;
        private System.Windows.Forms.Label label_Reminders;
        private System.Windows.Forms.TextBox textBox_Desc;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min;
        private System.Windows.Forms.ComboBox comboBox_Period;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.Label label_Version;
    }
}

