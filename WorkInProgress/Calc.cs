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

    public static List<string> Eiler(double ConcA, double TimeStart, double TimeEnd, double TimeStep, List<string> listA, List<string> listB)
    {
      double y = 0;
      double temp = ConcA;
      double tmp = 0;
      Random random = new Random();
      try
      { 
        for (double i = TimeStart; i < TimeEnd; i = i + TimeStep)
        {
          tmp = random.NextDouble() * (0.009 - 0.000001) + 0.000001; // для первой -5*Са
          
          y = ConcA * Math.Exp(-5*i)+tmp; // для второй получается 5*Са - k2*Cb как для третьей хз 
          tmp =  (100-y) * Math.Exp(-5 * i);
          // https://portal.tpu.ru/SHARED/p/POGADAEVA/Ucheba/Tab/Tab/UchebPosobie.pdf
          //tmp = (0 + ConcA) - y;
          
          listB.Add(Math.Round(Math.Abs(tmp), 6).ToString());
          //list.Add(Math.Round(Math.Abs(y), 6).ToString());
          temp = tmp;
          //temp = y;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      return listB;
    }
  }
}
