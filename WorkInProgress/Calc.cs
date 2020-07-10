using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkInProgress
{
  class Calc
  {
    public static List<string> CalculateFirst(double ConcA, double TimeStart, double TimeEnd, double TimeStep, List<string> list)
    {
      double y = 0;
      try
      {
        for (double i = TimeStart; i < TimeEnd; i = i + TimeStep)
        {
          y = ConcA * Math.Exp(-5*i);
          list.Add(Math.Round(Math.Abs(y), 6).ToString());
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      return list;
    }

    public static List<string> CalculateSecond(double ConcB, double TimeStart, double TimeEnd, double TimeStep, List<string> list)
    {
      double y = 0;
      try
      {
        for (double i = TimeStart; i < TimeEnd; i = i + TimeStep)
        {
          y = ConcB * Math.Exp(-5 * i);
          list.Add(Math.Round(Math.Abs(y), 6).ToString());
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      return list;
    }

    public static List<string> Eiler(double ConcA, double TimeStart, double TimeEnd, double TimeStep, List<string> list)
    {
      double y = 0;
      double temp = ConcA;
      try
      { 
        for (double i = TimeStart; i < TimeEnd; i = i + TimeStep)
        {
          y = temp * (-5);
          list.Add(Math.Round(Math.Abs(y), 6).ToString());
          temp = y;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      return list;
    }
  }
}
