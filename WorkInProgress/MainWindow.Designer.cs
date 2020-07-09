namespace WorkInProgress
{
  partial class MainWindow
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.Close = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
      this.About = new System.Windows.Forms.ToolStripMenuItem();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.ConcA = new System.Windows.Forms.TextBox();
      this.ConcB = new System.Windows.Forms.TextBox();
      this.ConcC = new System.Windows.Forms.TextBox();
      this.Time = new System.Windows.Forms.TrackBar();
      this.CurrentTime = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.TimeStart = new System.Windows.Forms.TextBox();
      this.TimeEnd = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.TimeStep = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.Run = new System.Windows.Forms.Button();
      this.SpeedK1 = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.SpeedK2 = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.DisplayPoints = new System.Windows.Forms.DataGridView();
      this.X_Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Y_Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplayPoints)).BeginInit();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(828, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Close});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
      this.toolStripDropDownButton1.Text = "Файл";
      // 
      // Close
      // 
      this.Close.Name = "Close";
      this.Close.Size = new System.Drawing.Size(120, 22);
      this.Close.Text = "Закрыть";
      this.Close.Click += new System.EventHandler(this.Close_Click);
      // 
      // toolStripDropDownButton2
      // 
      this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
      this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
      this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
      this.toolStripDropDownButton2.Size = new System.Drawing.Size(66, 22);
      this.toolStripDropDownButton2.Text = "Справка";
      // 
      // About
      // 
      this.About.Name = "About";
      this.About.Size = new System.Drawing.Size(149, 22);
      this.About.Text = "О программе";
      this.About.Click += new System.EventHandler(this.About_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(311, 20);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(73, 21);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(293, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Химическая реакция имеет следующий вид:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(621, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(200, 52);
      this.label2.TabIndex = 3;
      this.label2.Text = "Где: A - Исходный продукт\r\nB - Целевой продукт\r\nС - Побочный продукт\r\nk1 и k2 ско" +
    "рости протекания реакций\r\n";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(12, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 16);
      this.label3.TabIndex = 4;
      this.label3.Text = "Концентрация А";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(12, 104);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(114, 16);
      this.label4.TabIndex = 5;
      this.label4.Text = "Концентрация B";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(12, 129);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(114, 16);
      this.label5.TabIndex = 6;
      this.label5.Text = "Концентрация C";
      // 
      // ConcA
      // 
      this.ConcA.Location = new System.Drawing.Point(132, 77);
      this.ConcA.Name = "ConcA";
      this.ConcA.Size = new System.Drawing.Size(48, 20);
      this.ConcA.TabIndex = 7;
      // 
      // ConcB
      // 
      this.ConcB.Location = new System.Drawing.Point(132, 103);
      this.ConcB.Name = "ConcB";
      this.ConcB.Size = new System.Drawing.Size(48, 20);
      this.ConcB.TabIndex = 8;
      // 
      // ConcC
      // 
      this.ConcC.Location = new System.Drawing.Point(132, 128);
      this.ConcC.Name = "ConcC";
      this.ConcC.Size = new System.Drawing.Size(48, 20);
      this.ConcC.TabIndex = 9;
      // 
      // Time
      // 
      this.Time.BackColor = System.Drawing.SystemColors.Control;
      this.Time.Location = new System.Drawing.Point(15, 349);
      this.Time.Maximum = 6;
      this.Time.Name = "Time";
      this.Time.Size = new System.Drawing.Size(111, 45);
      this.Time.TabIndex = 10;
      this.Time.TickFrequency = 10;
      // 
      // CurrentTime
      // 
      this.CurrentTime.Location = new System.Drawing.Point(132, 349);
      this.CurrentTime.Name = "CurrentTime";
      this.CurrentTime.ReadOnly = true;
      this.CurrentTime.Size = new System.Drawing.Size(48, 20);
      this.CurrentTime.TabIndex = 11;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(12, 220);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(159, 16);
      this.label6.TabIndex = 12;
      this.label6.Text = "Интервал для времени";
      // 
      // TimeStart
      // 
      this.TimeStart.Location = new System.Drawing.Point(39, 239);
      this.TimeStart.Name = "TimeStart";
      this.TimeStart.Size = new System.Drawing.Size(48, 20);
      this.TimeStart.TabIndex = 13;
      // 
      // TimeEnd
      // 
      this.TimeEnd.Location = new System.Drawing.Point(132, 239);
      this.TimeEnd.Name = "TimeEnd";
      this.TimeEnd.Size = new System.Drawing.Size(48, 20);
      this.TimeEnd.TabIndex = 14;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(102, 240);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(24, 16);
      this.label7.TabIndex = 15;
      this.label7.Text = "до";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(12, 240);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(25, 16);
      this.label8.TabIndex = 16;
      this.label8.Text = "От";
      // 
      // Graph
      // 
      chartArea1.Name = "ChartArea1";
      this.Graph.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.Graph.Legends.Add(legend1);
      this.Graph.Location = new System.Drawing.Point(390, 75);
      this.Graph.Name = "Graph";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Legend = "Legend1";
      series1.MarkerBorderColor = System.Drawing.Color.Red;
      series1.Name = "Series1";
      this.Graph.Series.Add(series1);
      this.Graph.Size = new System.Drawing.Size(426, 294);
      this.Graph.TabIndex = 18;
      this.Graph.Text = "chart1";
      // 
      // TimeStep
      // 
      this.TimeStep.Location = new System.Drawing.Point(132, 265);
      this.TimeStep.Name = "TimeStep";
      this.TimeStep.Size = new System.Drawing.Size(48, 20);
      this.TimeStep.TabIndex = 19;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(93, 266);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(33, 16);
      this.label9.TabIndex = 20;
      this.label9.Text = "Шаг";
      // 
      // Run
      // 
      this.Run.Location = new System.Drawing.Point(105, 291);
      this.Run.Name = "Run";
      this.Run.Size = new System.Drawing.Size(75, 23);
      this.Run.TabIndex = 21;
      this.Run.Text = "Рассчитать";
      this.Run.UseVisualStyleBackColor = true;
      this.Run.Click += new System.EventHandler(this.Run_Click);
      // 
      // SpeedK1
      // 
      this.SpeedK1.Location = new System.Drawing.Point(132, 154);
      this.SpeedK1.Name = "SpeedK1";
      this.SpeedK1.Size = new System.Drawing.Size(48, 20);
      this.SpeedK1.TabIndex = 23;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(12, 155);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(86, 16);
      this.label10.TabIndex = 22;
      this.label10.Text = "Скорость k1";
      // 
      // SpeedK2
      // 
      this.SpeedK2.Location = new System.Drawing.Point(132, 180);
      this.SpeedK2.Name = "SpeedK2";
      this.SpeedK2.Size = new System.Drawing.Size(48, 20);
      this.SpeedK2.TabIndex = 25;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label11.Location = new System.Drawing.Point(12, 181);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(86, 16);
      this.label11.TabIndex = 24;
      this.label11.Text = "Скорость k2";
      // 
      // DisplayPoints
      // 
      this.DisplayPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DisplayPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_Values,
            this.Y_Values});
      this.DisplayPoints.Location = new System.Drawing.Point(197, 75);
      this.DisplayPoints.Name = "DisplayPoints";
      this.DisplayPoints.Size = new System.Drawing.Size(187, 292);
      this.DisplayPoints.TabIndex = 26;
      // 
      // X_Values
      // 
      this.X_Values.HeaderText = "X";
      this.X_Values.Name = "X_Values";
      this.X_Values.Width = 70;
      // 
      // Y_Values
      // 
      this.Y_Values.HeaderText = "Y";
      this.Y_Values.Name = "Y_Values";
      this.Y_Values.Width = 70;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuBar;
      this.ClientSize = new System.Drawing.Size(828, 396);
      this.Controls.Add(this.DisplayPoints);
      this.Controls.Add(this.SpeedK2);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.SpeedK1);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.Run);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.TimeStep);
      this.Controls.Add(this.Graph);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.TimeEnd);
      this.Controls.Add(this.TimeStart);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.CurrentTime);
      this.Controls.Add(this.Time);
      this.Controls.Add(this.ConcC);
      this.Controls.Add(this.ConcB);
      this.Controls.Add(this.ConcA);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.toolStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "MainWindow";
      this.Text = "Form1";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplayPoints)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Close;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
    private System.Windows.Forms.ToolStripMenuItem About;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox ConcA;
    private System.Windows.Forms.TextBox ConcB;
    private System.Windows.Forms.TextBox ConcC;
    private System.Windows.Forms.TrackBar Time;
    private System.Windows.Forms.TextBox CurrentTime;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox TimeStart;
    private System.Windows.Forms.TextBox TimeEnd;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
    private System.Windows.Forms.TextBox TimeStep;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button Run;
    private System.Windows.Forms.TextBox SpeedK1;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox SpeedK2;
    private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DisplayPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Values;
    }
}

