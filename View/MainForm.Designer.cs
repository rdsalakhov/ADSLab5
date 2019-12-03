namespace View
{
    partial class MainForm
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
            this.jobsTable = new System.Windows.Forms.DataGridView();
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.jobsCounter = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.jobsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество работ";
            // 
            // jobsTable
            // 
            this.jobsTable.AllowUserToAddRows = false;
            this.jobsTable.AllowUserToDeleteRows = false;
            this.jobsTable.AllowUserToResizeColumns = false;
            this.jobsTable.AllowUserToResizeRows = false;
            this.jobsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobName,
            this.firstStage,
            this.secondStage});
            this.jobsTable.Location = new System.Drawing.Point(122, 194);
            this.jobsTable.Name = "jobsTable";
            this.jobsTable.RowHeadersVisible = false;
            this.jobsTable.RowHeadersWidth = 82;
            this.jobsTable.RowTemplate.Height = 33;
            this.jobsTable.Size = new System.Drawing.Size(518, 358);
            this.jobsTable.TabIndex = 2;
            this.jobsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobsTable_CellEndEdit);
            // 
            // jobName
            // 
            this.jobName.HeaderText = "Имя работы";
            this.jobName.MinimumWidth = 10;
            this.jobName.Name = "jobName";
            this.jobName.ReadOnly = true;
            this.jobName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jobName.Width = 85;
            // 
            // firstStage
            // 
            this.firstStage.HeaderText = "Первая стадия";
            this.firstStage.MinimumWidth = 10;
            this.firstStage.Name = "firstStage";
            this.firstStage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstStage.Width = 85;
            // 
            // secondStage
            // 
            this.secondStage.HeaderText = "Вторая стадия";
            this.secondStage.MinimumWidth = 10;
            this.secondStage.Name = "secondStage";
            this.secondStage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.secondStage.Width = 85;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(235, 614);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(289, 57);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // jobsCounter
            // 
            this.jobsCounter.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsCounter.Location = new System.Drawing.Point(489, 98);
            this.jobsCounter.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.jobsCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jobsCounter.Name = "jobsCounter";
            this.jobsCounter.ReadOnly = true;
            this.jobsCounter.Size = new System.Drawing.Size(120, 50);
            this.jobsCounter.TabIndex = 4;
            this.jobsCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jobsCounter.ValueChanged += new System.EventHandler(this.jobsCounter_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 752);
            this.Controls.Add(this.jobsCounter);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.jobsTable);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.jobsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView jobsTable;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.NumericUpDown jobsCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondStage;
    }
}

