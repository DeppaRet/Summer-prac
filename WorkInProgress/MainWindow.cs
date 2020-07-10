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
        Graph.Series[0].Points.Clear();
        Graph.Series[1].Points.Clear();
        Graph.Series[2].Points.Clear();
        Graph2.Series[0].Points.Clear();
        DisplayPointsA.Rows.Clear();
        DisplayPointsB.Rows.Clear();
        DisplayPointsC.Rows.Clear();

        List<string> list = new List<string>();
        List<string> listResA = new List<string>();
        List<string> list2 = new List<string>();
        List<string> listResB = new List<string>();
        List<string> listB = new List<string>();
        List<string> listResC = new List<string>();
        List<string> listC = new List<string>();

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

        Calc.CalculateFirst(concA, left, right, step, listResA);

        int k = 0;
        for (double i = left; i < right; i = i + step)
        {
          tmp = Convert.ToDouble(listResA[k]);
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
          DisplayPointsA.Rows.Add(list[i], listResA[i]);
          temp++;
        }
        k = 0;
        for (double i = left; i < right; i = i + step)
        {
          tmp = Math.Round(Math.Abs(100 - Convert.ToDouble(listResA[k])) * Math.Exp(-5 * i), 6);
          Graph.Series[1].Points.AddXY(i, tmp); //можно вынести на отдельный график но хз
          listResB.Add(tmp.ToString());
          listB.Add(i.ToString());
          DisplayPointsB.Rows.Add(listB[k], tmp);
          k++;
        }

        k = 0;
        for (double i = left; i < right; i = i + step)
        {
          tmp = Math.Round(Math.Abs(100 - Convert.ToDouble(listResA[k]) - Convert.ToDouble(listResB[k])), 6);
          Graph.Series[2].Points.AddXY(i, tmp); //можно вынести на отдельный график но хз
          listResC.Add(tmp.ToString());
          listC.Add(i.ToString());
          DisplayPointsC.Rows.Add(listC[k], tmp); 
          k++;
        }

        //Calc.CalculateSecond(concB, left, right, step, listRes2);
        //Calc.Eiler(concA, left, right, step, listRes2);
        /*k = 0;
        for (double i = left; i < right; i = i + step)
        {
          tmp = Convert.ToDouble(listRes2[k]);
          Graph2.Series[0].Points.AddXY(i, tmp);
          list2.Add(i.ToString());
          k++;
        }
        temp = 0;
        for (int i = temp; i < k; i++)
        {
          if (temp >= list2.Count)
          {
            break;
          }
          DisplayPoints2.Rows.Add(list2[i], listRes2[i]);
          temp++;
        }
        */
        Graph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        Graph.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        Graph.MouseWheel += chart1_MouseWheel;
        Graph2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        Graph2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        Graph2.MouseWheel += chart1_MouseWheel;
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

    private void ChangeValues_Click(object sender, EventArgs e)
    {
      ChangeTip.Visible = true;
      Password.Visible = true;
      CheckPassword.Visible = true;
    }

    private void CheckPassword_Click(object sender, EventArgs e)
    {
      if(Password.Text == "пароль")
      {
        ConcA.ReadOnly = false;
        ConcB.ReadOnly = false;
        ConcC.ReadOnly = false;
        SpeedK1.ReadOnly = false;
        SpeedK2.ReadOnly = false;
        TimeStart.ReadOnly = false;
      }
      else
      {
        MessageBox.Show("Неверный пароль.", "Ошибка");
      }
      ChangeValues.Enabled = false;
      ChangeTip.Visible = false;
      Password.Visible = false;
      CheckPassword.Visible = false;
    }
  }
}
