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
    public partial class GanntChart : Form
    {
        private Tuple<List<TimeMark>, List<TimeMark>> jobs;
        public GanntChart(Tuple<List<TimeMark>, List<TimeMark>> jobs)
        {
            InitializeComponent();
            this.jobs = jobs;
            ShowGanntChart();
        }

        private void ShowGanntChart()
        {
            int hoursCount = jobs.Item2[jobs.Item2.Count-1].FinishTime;

            for (int i = 1; i <= hoursCount; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Width = 30;
                column.HeaderText = $"{i}";
                ganntChartTable.Columns.Add(column);
            }
            ganntChartTable.Rows.Add();
            ganntChartTable.Rows[0].HeaderCell.Value = "I employee";
            ganntChartTable.Rows.Add();
            ganntChartTable.Rows[1].HeaderCell.Value = "II employee";
            ganntChartTable.RowHeadersWidth = 100;
            for (int j = 0; j < jobs.Item1[0].FinishTime; j++)
            {
                ganntChartTable.Rows[0].Cells[j].Value = jobs.Item1[0].FinishedJob;
            }

            for (int i = 1; i < jobs.Item1.Count; i++)
            {
                for (int j = jobs.Item1[i-1].FinishTime; j < jobs.Item1[i].FinishTime; j++)
                {
                    ganntChartTable.Rows[0].Cells[j].Value = jobs.Item1[i].FinishedJob;
                }
            }
            for (int j = 0; j < jobs.Item2[0].FinishTime; j++)
            {
                ganntChartTable.Rows[1].Cells[j].Value = jobs.Item2[0].FinishedJob;
            }

            for (int i = 1; i < jobs.Item2.Count; i++)
            {
                for (int j = jobs.Item2[i - 1].FinishTime; j < jobs.Item2[i].FinishTime; j++)
                {
                    ganntChartTable.Rows[1].Cells[j].Value = jobs.Item2[i].FinishedJob;
                }
            }

        }
    }
}
