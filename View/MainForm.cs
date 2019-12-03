using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        private int numberOfJobs = 1;
        public MainForm()
        {
            InitializeComponent();
            UpdateTable(true);
            CalculateButton.Enabled = false;
        }

        private void jobsCounter_ValueChanged(object sender, EventArgs e)
        {
            bool isIncreased = numberOfJobs < (int)jobsCounter.Value;
            numberOfJobs = (int)jobsCounter.Value;
            UpdateTable(isIncreased);
           
        }

        private void UpdateTable(bool isIncreased)
        {
            if (isIncreased)
            {
                jobsTable.Rows.Add();
                jobsTable.Rows[numberOfJobs-1].Cells[0].Value = (char)('A' + numberOfJobs - 1);
            }
            else
            {
                jobsTable.Rows.RemoveAt(jobsTable.Rows.Count - 1);
            }
            CalculateButton.Enabled = CheckTableFill();
        }

        private void jobsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!(jobsTable.CurrentCell.Value != null && int.TryParse(jobsTable.CurrentCell.Value.ToString(), out int n) && n > 0))
            {
                MessageBox.Show("Unable to convert input to positive integer, try again");
                jobsTable.CurrentCell.Value = "";
            }
            CalculateButton.Enabled = CheckTableFill();

        }

        private bool CheckTableFill()
        {
            for (int i = 0; i < jobsTable.Rows.Count; i++)
            {
                if (jobsTable.Rows[i].Cells[1].Value == null || jobsTable.Rows[i].Cells[2].Value == null || jobsTable.Rows[i].Cells[1].Value.ToString() == "" || jobsTable.Rows[i].Cells[2].Value.ToString() == "")
                    return false;
            }
            return true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            List<Tuple<int, int>> jobs = new List<Tuple<int, int>>();
            for (int i = 0; i < jobsTable.Rows.Count; i++)
            {
                jobs.Add(new Tuple<int, int>(int.Parse(jobsTable.Rows[i].Cells[1].Value.ToString()),
                    int.Parse(jobsTable.Rows[i].Cells[2].Value.ToString())));
            }

            GetGanntChart(jobs);
        }

        private void GetGanntChart(List<Tuple<int, int>> jobs)
        {
            Tuple<List<TimeMark>, List<TimeMark>> chart = ScheduleCreator.FromListOfTuples(jobs);
            GanntChart ganntChart = new GanntChart(chart);
            ganntChart.Show();
        }
}
}
