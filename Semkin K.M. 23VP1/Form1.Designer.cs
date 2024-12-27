namespace Semkin_K.M._23VP1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel5 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel6 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel7 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel8 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel9 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel10 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel11 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errors = new System.Windows.Forms.Label();
            this.timeTable = new System.Windows.Forms.DataGridView();
            this.percents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.size_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ord_radio = new System.Windows.Forms.RadioButton();
            this.unOrd_radio = new System.Windows.Forms.RadioButton();
            this.rOrd_radio = new System.Windows.Forms.RadioButton();
            this.partOrd_radio = new System.Windows.Forms.RadioButton();
            this.percentage = new System.Windows.Forms.NumericUpDown();
            this.sort_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentage)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_panel
            // 
            this.chart_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chart_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chart_panel.Controls.Add(this.groupBox1);
            this.chart_panel.Controls.Add(this.timeTable);
            this.chart_panel.Controls.Add(this.Time);
            this.chart_panel.Location = new System.Drawing.Point(-4, -5);
            this.chart_panel.Name = "chart_panel";
            this.chart_panel.Size = new System.Drawing.Size(1150, 457);
            this.chart_panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errors);
            this.groupBox1.Location = new System.Drawing.Point(18, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поле вывода ошибок";
            // 
            // errors
            // 
            this.errors.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.errors.ForeColor = System.Drawing.Color.Red;
            this.errors.Location = new System.Drawing.Point(6, 31);
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(220, 147);
            this.errors.TabIndex = 4;
            // 
            // timeTable
            // 
            this.timeTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percents,
            this.first,
            this.mid,
            this.last});
            this.timeTable.Location = new System.Drawing.Point(3, 326);
            this.timeTable.Name = "timeTable";
            this.timeTable.RowHeadersWidth = 51;
            this.timeTable.RowTemplate.Height = 24;
            this.timeTable.Size = new System.Drawing.Size(1142, 131);
            this.timeTable.TabIndex = 2;
            // 
            // percents
            // 
            this.percents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percents.DefaultCellStyle = dataGridViewCellStyle2;
            this.percents.HeaderText = "Процент заполнения массива";
            this.percents.MinimumWidth = 6;
            this.percents.Name = "percents";
            this.percents.Width = 196;
            // 
            // first
            // 
            this.first.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.DefaultCellStyle = dataGridViewCellStyle3;
            this.first.HeaderText = "Время сортировки (первый опроный)";
            this.first.MinimumWidth = 6;
            this.first.Name = "first";
            this.first.Width = 196;
            // 
            // mid
            // 
            this.mid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mid.DefaultCellStyle = dataGridViewCellStyle4;
            this.mid.HeaderText = "Время сортировки (медианный опорный)";
            this.mid.MinimumWidth = 6;
            this.mid.Name = "mid";
            this.mid.Width = 196;
            // 
            // last
            // 
            this.last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last.DefaultCellStyle = dataGridViewCellStyle5;
            this.last.HeaderText = "Вермя сортировки (последний опорный)";
            this.last.MinimumWidth = 6;
            this.last.Name = "last";
            this.last.Width = 196;
            // 
            // Time
            // 
            customLabel1.ForeColor = System.Drawing.Color.Black;
            customLabel1.FromPosition = -1D;
            customLabel1.Text = "0%";
            customLabel1.ToPosition = 10D;
            customLabel2.ForeColor = System.Drawing.Color.Black;
            customLabel2.Text = "10%";
            customLabel2.ToPosition = 20D;
            customLabel3.ForeColor = System.Drawing.Color.Black;
            customLabel3.FromPosition = 10D;
            customLabel3.Text = "20%";
            customLabel3.ToPosition = 30D;
            customLabel4.ForeColor = System.Drawing.Color.Black;
            customLabel4.FromPosition = 20D;
            customLabel4.Text = "30%";
            customLabel4.ToPosition = 40D;
            customLabel5.ForeColor = System.Drawing.Color.Black;
            customLabel5.FromPosition = 30D;
            customLabel5.Text = "40%";
            customLabel5.ToPosition = 50D;
            customLabel6.ForeColor = System.Drawing.Color.Black;
            customLabel6.FromPosition = 40D;
            customLabel6.Text = "50%";
            customLabel6.ToPosition = 60D;
            customLabel7.ForeColor = System.Drawing.Color.Black;
            customLabel7.FromPosition = 50D;
            customLabel7.Text = "60%";
            customLabel7.ToPosition = 70D;
            customLabel8.ForeColor = System.Drawing.Color.Black;
            customLabel8.FromPosition = 60D;
            customLabel8.Text = "70%";
            customLabel8.ToPosition = 80D;
            customLabel9.ForeColor = System.Drawing.Color.Black;
            customLabel9.FromPosition = 70D;
            customLabel9.Text = "80%";
            customLabel9.ToPosition = 90D;
            customLabel10.ForeColor = System.Drawing.Color.Black;
            customLabel10.FromPosition = 80D;
            customLabel10.Text = "90%";
            customLabel10.ToPosition = 100D;
            customLabel11.ForeColor = System.Drawing.Color.Black;
            customLabel11.FromPosition = 90D;
            customLabel11.Text = "100%";
            customLabel11.ToPosition = 110D;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.CustomLabels.Add(customLabel4);
            chartArea1.AxisX.CustomLabels.Add(customLabel5);
            chartArea1.AxisX.CustomLabels.Add(customLabel6);
            chartArea1.AxisX.CustomLabels.Add(customLabel7);
            chartArea1.AxisX.CustomLabels.Add(customLabel8);
            chartArea1.AxisX.CustomLabels.Add(customLabel9);
            chartArea1.AxisX.CustomLabels.Add(customLabel10);
            chartArea1.AxisX.CustomLabels.Add(customLabel11);
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.Time.ChartAreas.Add(chartArea1);
            this.Time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSpacing = 10;
            legend1.Name = "Legend1";
            legend1.ShadowColor = System.Drawing.Color.Transparent;
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.Time.Legends.Add(legend1);
            this.Time.Location = new System.Drawing.Point(3, 3);
            this.Time.Name = "Time";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Первый";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "Медианный";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Последний";
            this.Time.Series.Add(series1);
            this.Time.Series.Add(series2);
            this.Time.Series.Add(series3);
            this.Time.Size = new System.Drawing.Size(1129, 317);
            this.Time.TabIndex = 1;
            this.Time.Text = "Time";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // size_num
            // 
            this.size_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_num.Location = new System.Drawing.Point(15, 494);
            this.size_num.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.size_num.Name = "size_num";
            this.size_num.Size = new System.Drawing.Size(278, 27);
            this.size_num.TabIndex = 1;
            this.size_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер последовательности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(373, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип последовательности";
            // 
            // ord_radio
            // 
            this.ord_radio.AutoSize = true;
            this.ord_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ord_radio.Location = new System.Drawing.Point(377, 497);
            this.ord_radio.Name = "ord_radio";
            this.ord_radio.Size = new System.Drawing.Size(176, 24);
            this.ord_radio.TabIndex = 4;
            this.ord_radio.TabStop = true;
            this.ord_radio.Text = "Упорядоченная";
            this.ord_radio.UseVisualStyleBackColor = true;
            this.ord_radio.CheckedChanged += new System.EventHandler(this.ord_radio_CheckedChanged);
            // 
            // unOrd_radio
            // 
            this.unOrd_radio.AutoSize = true;
            this.unOrd_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unOrd_radio.Location = new System.Drawing.Point(377, 527);
            this.unOrd_radio.Name = "unOrd_radio";
            this.unOrd_radio.Size = new System.Drawing.Size(198, 24);
            this.unOrd_radio.TabIndex = 5;
            this.unOrd_radio.TabStop = true;
            this.unOrd_radio.Text = "Неупорядоченная";
            this.unOrd_radio.UseVisualStyleBackColor = true;
            this.unOrd_radio.CheckedChanged += new System.EventHandler(this.unOrd_radio_CheckedChanged);
            // 
            // rOrd_radio
            // 
            this.rOrd_radio.AutoSize = true;
            this.rOrd_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rOrd_radio.Location = new System.Drawing.Point(610, 494);
            this.rOrd_radio.Name = "rOrd_radio";
            this.rOrd_radio.Size = new System.Drawing.Size(265, 24);
            this.rOrd_radio.TabIndex = 6;
            this.rOrd_radio.TabStop = true;
            this.rOrd_radio.Text = "Обратно упорядоченная ";
            this.rOrd_radio.UseVisualStyleBackColor = true;
            this.rOrd_radio.CheckedChanged += new System.EventHandler(this.rOrd_radio_CheckedChanged);
            // 
            // partOrd_radio
            // 
            this.partOrd_radio.AutoSize = true;
            this.partOrd_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partOrd_radio.Location = new System.Drawing.Point(610, 527);
            this.partOrd_radio.Name = "partOrd_radio";
            this.partOrd_radio.Size = new System.Drawing.Size(269, 24);
            this.partOrd_radio.TabIndex = 7;
            this.partOrd_radio.TabStop = true;
            this.partOrd_radio.Text = "Частично упорядоченная";
            this.partOrd_radio.UseVisualStyleBackColor = true;
            this.partOrd_radio.CheckedChanged += new System.EventHandler(this.partOrd_radio_CheckedChanged);
            // 
            // percentage
            // 
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentage.Location = new System.Drawing.Point(631, 557);
            this.percentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentage.Name = "percentage";
            this.percentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.percentage.Size = new System.Drawing.Size(69, 27);
            this.percentage.TabIndex = 8;
            this.percentage.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // sort_button
            // 
            this.sort_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sort_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sort_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sort_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sort_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sort_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_button.Location = new System.Drawing.Point(964, 471);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(160, 34);
            this.sort_button.TabIndex = 9;
            this.sort_button.Text = "Сортировать";
            this.sort_button.UseVisualStyleBackColor = false;
            this.sort_button.Click += new System.EventHandler(this.start_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(964, 522);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(160, 34);
            this.exit_button.TabIndex = 10;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(701, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "% упорядоченности";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.sort_button);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.partOrd_radio);
            this.Controls.Add(this.rOrd_radio);
            this.Controls.Add(this.unOrd_radio);
            this.Controls.Add(this.ord_radio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size_num);
            this.Controls.Add(this.chart_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Сёмкин К.М. 23ВП1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.chart_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel chart_panel;
        private System.Windows.Forms.NumericUpDown size_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ord_radio;
        private System.Windows.Forms.RadioButton unOrd_radio;
        private System.Windows.Forms.RadioButton rOrd_radio;
        private System.Windows.Forms.RadioButton partOrd_radio;
        private System.Windows.Forms.NumericUpDown percentage;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart Time;
        private System.Windows.Forms.DataGridView timeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn percents;
        private System.Windows.Forms.DataGridViewTextBoxColumn first;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errors;
    }
}

