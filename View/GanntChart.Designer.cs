namespace View
{
    partial class GanntChart
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
            this.label1 = new System.Windows.Forms.Label();
            this.ganntChartTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ganntChartTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаграмма Ганта";
            // 
            // ganntChartTable
            // 
            this.ganntChartTable.AllowUserToAddRows = false;
            this.ganntChartTable.AllowUserToDeleteRows = false;
            this.ganntChartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ganntChartTable.Location = new System.Drawing.Point(99, 160);
            this.ganntChartTable.Name = "ganntChartTable";
            this.ganntChartTable.ReadOnly = true;
            this.ganntChartTable.RowHeadersWidth = 82;
            this.ganntChartTable.RowTemplate.Height = 33;
            this.ganntChartTable.Size = new System.Drawing.Size(840, 172);
            this.ganntChartTable.TabIndex = 1;
            // 
            // GanntChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.ganntChartTable);
            this.Controls.Add(this.label1);
            this.Name = "GanntChart";
            this.Text = "GanntChart";
            ((System.ComponentModel.ISupportInitialize)(this.ganntChartTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ganntChartTable;
    }
}