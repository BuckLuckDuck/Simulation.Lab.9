namespace Simulation.Lab._9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_prob1 = new System.Windows.Forms.Label();
            this.nud_prob1 = new System.Windows.Forms.NumericUpDown();
            this.btn_exit = new System.Windows.Forms.Button();
            this.nud_prob2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob2 = new System.Windows.Forms.Label();
            this.nud_prob3 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob3 = new System.Windows.Forms.Label();
            this.nud_prob4 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob4 = new System.Windows.Forms.Label();
            this.nud_prob5 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob5 = new System.Windows.Forms.Label();
            this.lbl_prob1_end = new System.Windows.Forms.Label();
            this.lbl_prob2_end = new System.Windows.Forms.Label();
            this.lbl_prob3_end = new System.Windows.Forms.Label();
            this.lbl_prob4_end = new System.Windows.Forms.Label();
            this.lbl_prob5_end = new System.Windows.Forms.Label();
            this.btn_get_answer = new System.Windows.Forms.Button();
            this.nud_n = new System.Windows.Forms.NumericUpDown();
            this.lbl_n = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.lbl_info4 = new System.Windows.Forms.Label();
            this.lbl_info5 = new System.Windows.Forms.Label();
            this.lbl_average_value = new System.Windows.Forms.Label();
            this.lbl_variance_value = new System.Windows.Forms.Label();
            this.lbl_chi_value = new System.Windows.Forms.Label();
            this.lbl_info7 = new System.Windows.Forms.Label();
            this.lbl_info6 = new System.Windows.Forms.Label();
            this.lbl_variance_error = new System.Windows.Forms.Label();
            this.lbl_average_error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_prob1
            // 
            this.lbl_prob1.AutoSize = true;
            this.lbl_prob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob1.Location = new System.Drawing.Point(12, 47);
            this.lbl_prob1.Name = "lbl_prob1";
            this.lbl_prob1.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob1.TabIndex = 0;
            this.lbl_prob1.Text = "Prob 1";
            // 
            // nud_prob1
            // 
            this.nud_prob1.DecimalPlaces = 3;
            this.nud_prob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob1.Location = new System.Drawing.Point(73, 45);
            this.nud_prob1.Name = "nud_prob1";
            this.nud_prob1.Size = new System.Drawing.Size(128, 26);
            this.nud_prob1.TabIndex = 1;
            this.nud_prob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob1.ValueChanged += new System.EventHandler(this.nud_prob1_ValueChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(813, 330);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 45);
            this.btn_exit.TabIndex = 100;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // nud_prob2
            // 
            this.nud_prob2.DecimalPlaces = 3;
            this.nud_prob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob2.Location = new System.Drawing.Point(73, 77);
            this.nud_prob2.Name = "nud_prob2";
            this.nud_prob2.Size = new System.Drawing.Size(128, 26);
            this.nud_prob2.TabIndex = 2;
            this.nud_prob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob2.ValueChanged += new System.EventHandler(this.nud_prob2_ValueChanged);
            // 
            // lbl_prob2
            // 
            this.lbl_prob2.AutoSize = true;
            this.lbl_prob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob2.Location = new System.Drawing.Point(12, 79);
            this.lbl_prob2.Name = "lbl_prob2";
            this.lbl_prob2.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob2.TabIndex = 101;
            this.lbl_prob2.Text = "Prob 2";
            // 
            // nud_prob3
            // 
            this.nud_prob3.DecimalPlaces = 3;
            this.nud_prob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob3.Location = new System.Drawing.Point(73, 109);
            this.nud_prob3.Name = "nud_prob3";
            this.nud_prob3.Size = new System.Drawing.Size(128, 26);
            this.nud_prob3.TabIndex = 3;
            this.nud_prob3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob3.ValueChanged += new System.EventHandler(this.nud_prob3_ValueChanged);
            // 
            // lbl_prob3
            // 
            this.lbl_prob3.AutoSize = true;
            this.lbl_prob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob3.Location = new System.Drawing.Point(12, 111);
            this.lbl_prob3.Name = "lbl_prob3";
            this.lbl_prob3.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob3.TabIndex = 103;
            this.lbl_prob3.Text = "Prob 3";
            // 
            // nud_prob4
            // 
            this.nud_prob4.DecimalPlaces = 3;
            this.nud_prob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob4.Location = new System.Drawing.Point(73, 141);
            this.nud_prob4.Name = "nud_prob4";
            this.nud_prob4.Size = new System.Drawing.Size(128, 26);
            this.nud_prob4.TabIndex = 4;
            this.nud_prob4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob4.ValueChanged += new System.EventHandler(this.nud_prob4_ValueChanged);
            // 
            // lbl_prob4
            // 
            this.lbl_prob4.AutoSize = true;
            this.lbl_prob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob4.Location = new System.Drawing.Point(12, 143);
            this.lbl_prob4.Name = "lbl_prob4";
            this.lbl_prob4.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob4.TabIndex = 105;
            this.lbl_prob4.Text = "Prob 4";
            // 
            // nud_prob5
            // 
            this.nud_prob5.DecimalPlaces = 3;
            this.nud_prob5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob5.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud_prob5.Location = new System.Drawing.Point(73, 173);
            this.nud_prob5.Name = "nud_prob5";
            this.nud_prob5.ReadOnly = true;
            this.nud_prob5.Size = new System.Drawing.Size(128, 26);
            this.nud_prob5.TabIndex = 5;
            this.nud_prob5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_prob5
            // 
            this.lbl_prob5.AutoSize = true;
            this.lbl_prob5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob5.Location = new System.Drawing.Point(12, 175);
            this.lbl_prob5.Name = "lbl_prob5";
            this.lbl_prob5.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob5.TabIndex = 107;
            this.lbl_prob5.Text = "Prob 5";
            // 
            // lbl_prob1_end
            // 
            this.lbl_prob1_end.AutoSize = true;
            this.lbl_prob1_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob1_end.Location = new System.Drawing.Point(260, 47);
            this.lbl_prob1_end.Name = "lbl_prob1_end";
            this.lbl_prob1_end.Size = new System.Drawing.Size(18, 20);
            this.lbl_prob1_end.TabIndex = 108;
            this.lbl_prob1_end.Text = "0";
            // 
            // lbl_prob2_end
            // 
            this.lbl_prob2_end.AutoSize = true;
            this.lbl_prob2_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob2_end.Location = new System.Drawing.Point(260, 79);
            this.lbl_prob2_end.Name = "lbl_prob2_end";
            this.lbl_prob2_end.Size = new System.Drawing.Size(18, 20);
            this.lbl_prob2_end.TabIndex = 109;
            this.lbl_prob2_end.Text = "0";
            // 
            // lbl_prob3_end
            // 
            this.lbl_prob3_end.AutoSize = true;
            this.lbl_prob3_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob3_end.Location = new System.Drawing.Point(260, 111);
            this.lbl_prob3_end.Name = "lbl_prob3_end";
            this.lbl_prob3_end.Size = new System.Drawing.Size(18, 20);
            this.lbl_prob3_end.TabIndex = 110;
            this.lbl_prob3_end.Text = "0";
            // 
            // lbl_prob4_end
            // 
            this.lbl_prob4_end.AutoSize = true;
            this.lbl_prob4_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob4_end.Location = new System.Drawing.Point(260, 143);
            this.lbl_prob4_end.Name = "lbl_prob4_end";
            this.lbl_prob4_end.Size = new System.Drawing.Size(18, 20);
            this.lbl_prob4_end.TabIndex = 111;
            this.lbl_prob4_end.Text = "0";
            // 
            // lbl_prob5_end
            // 
            this.lbl_prob5_end.AutoSize = true;
            this.lbl_prob5_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob5_end.Location = new System.Drawing.Point(260, 175);
            this.lbl_prob5_end.Name = "lbl_prob5_end";
            this.lbl_prob5_end.Size = new System.Drawing.Size(18, 20);
            this.lbl_prob5_end.TabIndex = 112;
            this.lbl_prob5_end.Text = "0";
            // 
            // btn_get_answer
            // 
            this.btn_get_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_get_answer.Location = new System.Drawing.Point(650, 331);
            this.btn_get_answer.Name = "btn_get_answer";
            this.btn_get_answer.Size = new System.Drawing.Size(157, 42);
            this.btn_get_answer.TabIndex = 7;
            this.btn_get_answer.Text = "Получить ответ";
            this.btn_get_answer.UseVisualStyleBackColor = true;
            this.btn_get_answer.Click += new System.EventHandler(this.btn_get_answer_Click);
            // 
            // nud_n
            // 
            this.nud_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_n.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_n.Location = new System.Drawing.Point(73, 205);
            this.nud_n.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_n.Name = "nud_n";
            this.nud_n.Size = new System.Drawing.Size(128, 26);
            this.nud_n.TabIndex = 6;
            this.nud_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_n.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_n.Location = new System.Drawing.Point(26, 207);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(20, 20);
            this.lbl_n.TabIndex = 115;
            this.lbl_n.Text = "N";
            // 
            // chart1
            // 
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(465, 9);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(393, 301);
            this.chart1.TabIndex = 116;
            this.chart1.Text = "chart1";
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info1.Location = new System.Drawing.Point(12, 9);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(189, 20);
            this.lbl_info1.TabIndex = 117;
            this.lbl_info1.Text = "Заданные вероятности";
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info2.Location = new System.Drawing.Point(242, 9);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(186, 20);
            this.lbl_info2.TabIndex = 118;
            this.lbl_info2.Text = "Конечные вероятности";
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info3.Location = new System.Drawing.Point(12, 270);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(68, 20);
            this.lbl_info3.TabIndex = 119;
            this.lbl_info3.Text = "Average";
            // 
            // lbl_info4
            // 
            this.lbl_info4.AutoSize = true;
            this.lbl_info4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info4.Location = new System.Drawing.Point(12, 301);
            this.lbl_info4.Name = "lbl_info4";
            this.lbl_info4.Size = new System.Drawing.Size(72, 20);
            this.lbl_info4.TabIndex = 120;
            this.lbl_info4.Text = "Variance";
            // 
            // lbl_info5
            // 
            this.lbl_info5.AutoSize = true;
            this.lbl_info5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info5.Location = new System.Drawing.Point(12, 331);
            this.lbl_info5.Name = "lbl_info5";
            this.lbl_info5.Size = new System.Drawing.Size(95, 20);
            this.lbl_info5.TabIndex = 121;
            this.lbl_info5.Text = "Chi-squared";
            // 
            // lbl_average_value
            // 
            this.lbl_average_value.AutoSize = true;
            this.lbl_average_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_average_value.Location = new System.Drawing.Point(138, 270);
            this.lbl_average_value.Name = "lbl_average_value";
            this.lbl_average_value.Size = new System.Drawing.Size(18, 20);
            this.lbl_average_value.TabIndex = 122;
            this.lbl_average_value.Text = "0";
            // 
            // lbl_variance_value
            // 
            this.lbl_variance_value.AutoSize = true;
            this.lbl_variance_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_variance_value.Location = new System.Drawing.Point(138, 301);
            this.lbl_variance_value.Name = "lbl_variance_value";
            this.lbl_variance_value.Size = new System.Drawing.Size(18, 20);
            this.lbl_variance_value.TabIndex = 123;
            this.lbl_variance_value.Text = "0";
            // 
            // lbl_chi_value
            // 
            this.lbl_chi_value.AutoSize = true;
            this.lbl_chi_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_chi_value.Location = new System.Drawing.Point(138, 331);
            this.lbl_chi_value.Name = "lbl_chi_value";
            this.lbl_chi_value.Size = new System.Drawing.Size(18, 20);
            this.lbl_chi_value.TabIndex = 124;
            this.lbl_chi_value.Text = "0";
            // 
            // lbl_info7
            // 
            this.lbl_info7.AutoSize = true;
            this.lbl_info7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info7.Location = new System.Drawing.Point(220, 301);
            this.lbl_info7.Name = "lbl_info7";
            this.lbl_info7.Size = new System.Drawing.Size(42, 20);
            this.lbl_info7.TabIndex = 128;
            this.lbl_info7.Text = "error";
            // 
            // lbl_info6
            // 
            this.lbl_info6.AutoSize = true;
            this.lbl_info6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info6.Location = new System.Drawing.Point(220, 270);
            this.lbl_info6.Name = "lbl_info6";
            this.lbl_info6.Size = new System.Drawing.Size(42, 20);
            this.lbl_info6.TabIndex = 127;
            this.lbl_info6.Text = "error";
            // 
            // lbl_variance_error
            // 
            this.lbl_variance_error.AutoSize = true;
            this.lbl_variance_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_variance_error.Location = new System.Drawing.Point(276, 301);
            this.lbl_variance_error.Name = "lbl_variance_error";
            this.lbl_variance_error.Size = new System.Drawing.Size(32, 20);
            this.lbl_variance_error.TabIndex = 126;
            this.lbl_variance_error.Text = "0%";
            // 
            // lbl_average_error
            // 
            this.lbl_average_error.AutoSize = true;
            this.lbl_average_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_average_error.Location = new System.Drawing.Point(276, 270);
            this.lbl_average_error.Name = "lbl_average_error";
            this.lbl_average_error.Size = new System.Drawing.Size(32, 20);
            this.lbl_average_error.TabIndex = 125;
            this.lbl_average_error.Text = "0%";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(465, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 42);
            this.button1.TabIndex = 129;
            this.button1.Text = "Случайные значния";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_info7);
            this.Controls.Add(this.lbl_info6);
            this.Controls.Add(this.lbl_variance_error);
            this.Controls.Add(this.lbl_average_error);
            this.Controls.Add(this.lbl_chi_value);
            this.Controls.Add(this.lbl_variance_value);
            this.Controls.Add(this.lbl_average_value);
            this.Controls.Add(this.lbl_info5);
            this.Controls.Add(this.lbl_info4);
            this.Controls.Add(this.lbl_info3);
            this.Controls.Add(this.lbl_info2);
            this.Controls.Add(this.lbl_info1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.nud_n);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.btn_get_answer);
            this.Controls.Add(this.lbl_prob5_end);
            this.Controls.Add(this.lbl_prob4_end);
            this.Controls.Add(this.lbl_prob3_end);
            this.Controls.Add(this.lbl_prob2_end);
            this.Controls.Add(this.lbl_prob1_end);
            this.Controls.Add(this.nud_prob5);
            this.Controls.Add(this.lbl_prob5);
            this.Controls.Add(this.nud_prob4);
            this.Controls.Add(this.lbl_prob4);
            this.Controls.Add(this.nud_prob3);
            this.Controls.Add(this.lbl_prob3);
            this.Controls.Add(this.nud_prob2);
            this.Controls.Add(this.lbl_prob2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.nud_prob1);
            this.Controls.Add(this.lbl_prob1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prob1;
        private System.Windows.Forms.NumericUpDown nud_prob1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.NumericUpDown nud_prob2;
        private System.Windows.Forms.Label lbl_prob2;
        private System.Windows.Forms.NumericUpDown nud_prob3;
        private System.Windows.Forms.Label lbl_prob3;
        private System.Windows.Forms.NumericUpDown nud_prob4;
        private System.Windows.Forms.Label lbl_prob4;
        private System.Windows.Forms.NumericUpDown nud_prob5;
        private System.Windows.Forms.Label lbl_prob5;
        private System.Windows.Forms.Label lbl_prob1_end;
        private System.Windows.Forms.Label lbl_prob2_end;
        private System.Windows.Forms.Label lbl_prob3_end;
        private System.Windows.Forms.Label lbl_prob4_end;
        private System.Windows.Forms.Label lbl_prob5_end;
        private System.Windows.Forms.Button btn_get_answer;
        private System.Windows.Forms.NumericUpDown nud_n;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.Label lbl_info4;
        private System.Windows.Forms.Label lbl_info5;
        private System.Windows.Forms.Label lbl_average_value;
        private System.Windows.Forms.Label lbl_variance_value;
        private System.Windows.Forms.Label lbl_chi_value;
        private System.Windows.Forms.Label lbl_info7;
        private System.Windows.Forms.Label lbl_info6;
        private System.Windows.Forms.Label lbl_variance_error;
        private System.Windows.Forms.Label lbl_average_error;
        private System.Windows.Forms.Button button1;
    }
}

