using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WorkInProgress
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void About_Click(object sender, EventArgs e)
    {
      About about = new About();
      about.Show();
    }

    private void Run_Click(object sender, EventArgs e)
    {
      try
      {
        
        List<string> list = new List<string>();
        List<string> listRes = new List<string>();
        TimeStep.BackColor = Color.White;
        TimeStart.BackColor = Color.White;
        TimeEnd.BackColor = Color.White;
        ConcA.BackColor = Color.White;
        ConcB.BackColor = Color.White;
        ConcC.BackColor = Color.White;
        TimeStep.Text = TimeStep.Text.Replace(".", ",");
        double tmp = 0;
        bool check;
        check = Double.TryParse(TimeStep.Text, out tmp);
        if (!check || Convert.ToDouble(TimeStep.Text) <= 0)
        {
          MessageBox.Show("Неверное значение для шага.", "Ошибка");
          TimeStep.BackColor = Color.Red;
          return;
        }
        else if (Convert.ToDouble(TimeStep.Text) > 1) 
        {
          MessageBox.Show("Шаг слишком большой, уменьшите его и повторите попытку", "Ошибка");
          TimeStep.BackColor = Color.Red;
          return;
        }
        check = Double.TryParse(ConcA.Text, out tmp);
        if (!check || Convert.ToDouble(ConcA.Text) < 0)
        {
          MessageBox.Show("Неверное значение для концентрации в-ва А.", "Ошибка");
          ConcA.BackColor = Color.Red;
          return;
        }
        check = Double.TryParse(ConcB.Text, out tmp);
        if (!check || Convert.ToDouble(ConcB.Text) < 0)
        {
          MessageBox.Show("Неверное значение для концентрации в-ва B.", "Ошибка");
          ConcB.BackColor = Color.Red;
          return;
        }
        check = Double.TryParse(ConcC.Text, out tmp);
        if (!check || Convert.ToDouble(ConcC.Text) < 0)
        {
          MessageBox.Show("Неверное значение для концентрации в-ва C.", "Ошибка");
          ConcC.BackColor = Color.Red;
          return;
        }
        check = Double.TryParse(TimeStart.Text, out tmp);
        if (!check || !Double.TryParse(TimeEnd.Text, out tmp) || Convert.ToDouble(TimeStart.Text) < 0 || Convert.ToDouble(TimeStart.Text) > Convert.ToDouble(TimeEnd.Text))
        {
          MessageBox.Show("Неверное значение для шага.", "Ошибка");
          TimeStep.BackColor = Color.Red;
          return;
        }

        double step = Convert.ToDouble(TimeStep.Text);
        double left = Convert.ToDouble(TimeStart.Text);
        double right = Convert.ToDouble(TimeEnd.Text);
        double concA = Convert.ToDouble(ConcA.Text);
        double concB = Convert.ToDouble(ConcB.Text);
        double concC = Convert.ToDouble(ConcC.Text);

        Calc.Calculate(concA, concB, concC, left, right, step, listRes);

        int k = 0;
        for (double i = left; i < right; i = i + step)
        {
          tmp = Convert.ToDouble(listRes[k]);
          Graph.Series[0].Points.AddXY(i, tmp);
          list.Add(i.ToString());
          k++;
        }
        int temp = 0;
        for (int i = temp; i < k; i++)
        {
          if (temp >= list.Count)
          {
            break;
          }
          DisplayPoints.Rows.Add(list[i], listRes[i]);
          temp++;
        }
        Graph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        Graph.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        Graph.MouseWheel += chart1_MouseWheel;
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    //********************************************************************************
    //*ДЛЯ ТОГО ЧТОБЫ НЕСКОЛЬКО ТОЧЕК Y ДЛЯ ОДНОГО Х НАДО ВКЛЮЧИТЬ В СЕРИИ YYPERPOINT*
    //********************************************************************************
    private void chart1_MouseWheel(object sender, MouseEventArgs e)
    {
      var chart = (Chart)sender;
      var xAxis = Graph.ChartAreas[0].AxisX;
      var yAxis = Graph.ChartAreas[0].AxisY;

      try
      {
        if (e.Delta < 0) // Scrolled down.
        {
          xAxis.ScaleView.ZoomReset();
          yAxis.ScaleView.ZoomReset();
        }
        else if (e.Delta > 0) // Scrolled up.
        {
          var xMin = xAxis.ScaleView.ViewMinimum;
          var xMax = xAxis.ScaleView.ViewMaximum;
          var yMin = yAxis.ScaleView.ViewMinimum;
          var yMax = yAxis.ScaleView.ViewMaximum;

          var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
          var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
          var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
          var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

          xAxis.ScaleView.Zoom(posXStart, posXFinish);
          yAxis.ScaleView.Zoom(posYStart, posYFinish);
        }
      }
      catch { }
    }


    /* private void Time_Scroll(object sender, EventArgs e)
     {
       CurrentTime.Text = Time.Value.ToString();
     }*/
  }
}
