using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInProgress
{
  class Calc
  {
    public static List<string> Calculate(double ConcA, double ConcB, double ConcC, double TimeStart, double TimeEnd, double TimeStep, List<string> list)
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
      catch { }
      return list;
    }
  }
}
