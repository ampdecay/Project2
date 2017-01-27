namespace project2_Daigle
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_coin = new System.Windows.Forms.Button();
            this.button_die = new System.Windows.Forms.Button();
            this.button_gaussian = new System.Windows.Forms.Button();
            this.listbox_rngs = new System.Windows.Forms.ListBox();
            this.chart_histo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_rngVal = new System.Windows.Forms.TextBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textBox_high = new System.Windows.Forms.TextBox();
            this.textBox_low = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_histo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_coin
            // 
            this.button_coin.Location = new System.Drawing.Point(707, 12);
            this.button_coin.Name = "button_coin";
            this.button_coin.Size = new System.Drawing.Size(75, 23);
            this.button_coin.TabIndex = 0;
            this.button_coin.Text = "Coin";
            this.button_coin.UseVisualStyleBackColor = true;
            this.button_coin.Click += new System.EventHandler(this.button_coin_Click);
            // 
            // button_die
            // 
            this.button_die.Location = new System.Drawing.Point(707, 41);
            this.button_die.Name = "button_die";
            this.button_die.Size = new System.Drawing.Size(75, 23);
            this.button_die.TabIndex = 1;
            this.button_die.Text = "Die";
            this.button_die.UseVisualStyleBackColor = true;
            this.button_die.Click += new System.EventHandler(this.button_die_Click);
            // 
            // button_gaussian
            // 
            this.button_gaussian.Location = new System.Drawing.Point(707, 70);
            this.button_gaussian.Name = "button_gaussian";
            this.button_gaussian.Size = new System.Drawing.Size(75, 23);
            this.button_gaussian.TabIndex = 2;
            this.button_gaussian.Text = "Gaussian";
            this.button_gaussian.UseVisualStyleBackColor = true;
            this.button_gaussian.Click += new System.EventHandler(this.button_gaussian_Click);
            // 
            // listbox_rngs
            // 
            this.listbox_rngs.FormattingEnabled = true;
            this.listbox_rngs.Location = new System.Drawing.Point(789, 12);
            this.listbox_rngs.Name = "listbox_rngs";
            this.listbox_rngs.Size = new System.Drawing.Size(94, 108);
            this.listbox_rngs.TabIndex = 3;
            this.listbox_rngs.SelectedIndexChanged += new System.EventHandler(this.listbox_rngs_SelectedIndexChanged);
            // 
            // chart_histo
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.chart_histo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_histo.Legends.Add(legend1);
            this.chart_histo.Location = new System.Drawing.Point(0, 0);
            this.chart_histo.Name = "chart_histo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart_histo.Series.Add(series1);
            this.chart_histo.Size = new System.Drawing.Size(701, 300);
            this.chart_histo.TabIndex = 4;
            this.chart_histo.Text = "Histogram";
            // 
            // textBox_seed
            // 
            this.textBox_seed.Location = new System.Drawing.Point(707, 139);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(75, 20);
            this.textBox_seed.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seed";
            // 
            // textBox_rngVal
            // 
            this.textBox_rngVal.Location = new System.Drawing.Point(707, 177);
            this.textBox_rngVal.Name = "textBox_rngVal";
            this.textBox_rngVal.ReadOnly = true;
            this.textBox_rngVal.Size = new System.Drawing.Size(75, 20);
            this.textBox_rngVal.TabIndex = 12;
            this.textBox_rngVal.Visible = false;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(707, 97);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 13;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current Value";
            this.label4.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textBox_high
            // 
            this.textBox_high.Location = new System.Drawing.Point(707, 280);
            this.textBox_high.Name = "textBox_high";
            this.textBox_high.ReadOnly = true;
            this.textBox_high.Size = new System.Drawing.Size(75, 20);
            this.textBox_high.TabIndex = 15;
            this.textBox_high.Visible = false;
            // 
            // textBox_low
            // 
            this.textBox_low.Location = new System.Drawing.Point(707, 241);
            this.textBox_low.Name = "textBox_low";
            this.textBox_low.ReadOnly = true;
            this.textBox_low.Size = new System.Drawing.Size(75, 20);
            this.textBox_low.TabIndex = 16;
            this.textBox_low.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "High";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Low";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_low);
            this.Controls.Add(this.textBox_high);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.textBox_rngVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_seed);
            this.Controls.Add(this.chart_histo);
            this.Controls.Add(this.listbox_rngs);
            this.Controls.Add(this.button_gaussian);
            this.Controls.Add(this.button_die);
            this.Controls.Add(this.button_coin);
            this.Name = "Form1";
            this.Text = "Project 2";
            ((System.ComponentModel.ISupportInitialize)(this.chart_histo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_coin;
        private System.Windows.Forms.Button button_die;
        private System.Windows.Forms.Button button_gaussian;
        private System.Windows.Forms.ListBox listbox_rngs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_histo;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_rngVal;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox textBox_high;
        private System.Windows.Forms.TextBox textBox_low;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

