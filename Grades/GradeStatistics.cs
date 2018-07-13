﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Grades
{
  public class GradeStatistics
  {
    public GradeStatistics()
    {
      HighestGrade = 0;
      LowestGrade = float.MaxValue;
    }

    public string Description
    {
      get
      {
        string result;
        switch (LetterGrade)
        {
          case "A":
            result = "Excellent";
            break;
          case "B":
            result = "Good";
            break;
          case "C":
            result = "Average";
            break;
          case "D":
            result = "Poor";
            break;
          default:
            result = "Failing";
            break;
        }
        return result;
      }
    }
    public string LetterGrade
    {
      get
      {
        string result;
        if (AverageGrade >= 90)
        {
          result = "A";
        }
        else if (AverageGrade >= 80)
        {
          result = "B";
        }
        else if (AverageGrade >= 70)
        {
          result = "C";
        }
        else if (AverageGrade >= 60)
        {
          result = "D";
        }
        else
        {
          result = "F";
        }
        return result;
      }
    }

    public float AverageGrade;
    public float HighestGrade;
    public float LowestGrade;

  }
}
