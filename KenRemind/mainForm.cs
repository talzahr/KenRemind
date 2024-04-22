using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace KenRemind
{
    public partial class mainForm : Form
    {
        DataTable table;

        public mainForm()
        {
            InitializeComponent();

            DataSet dataSet = new DataSet();

            if (File.Exists("Data.xml"))
            {
                dataSet.ReadXml("Data.xml");
                table = dataSet.Tables["Reminders"];
            }
            else
            {
                table = new DataTable("Reminders");
                table.Columns.Add("Date & Time", typeof(DateTime));
                table.Columns.Add("Description", typeof(string));
                dataSet.Tables.Add(table);
            }

            dataGridView_Reminders.DataSource = table;

            dataGridView_Reminders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Reminders.ScrollBars = ScrollBars.Both;
            comboBox_Period.SelectedIndex = 0;

            this.Load += new EventHandler(mainForm_Load);
            this.FormClosing += new FormClosingEventHandler(mainForm_FormClosing);
        }

        private void button_AddTask_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(numericUpDown_Hour.Value);
            int minute = Convert.ToInt32(numericUpDown_Min.Value);

            DateTime date = dateTimePicker.Value.Date;
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0);

            table.Rows.Add(dateTime, textBox_Desc.Text);
            textBox_Desc.Clear();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            dataGridView_Reminders.Columns["Date & Time"].Width = 245;
            dataGridView_Reminders.Sort(dataGridView_Reminders.Columns["Date & Time"], ListSortDirection.Ascending);
            dataGridView_Reminders.ClearSelection();
        }

        void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((DataTable)dataGridView_Reminders.DataSource).DataSet.WriteXml("Data.xml");
        }
    }
}
