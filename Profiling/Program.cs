using csFastFloat;
using System;

namespace Profiling
{
  unsafe class Program
  {
    static void Main(string[] args)
    {

      string fileName = @".\canada.txt";
      var lines = System.IO.File.ReadAllLines(fileName);

      foreach (string l in lines)
      {
        fixed (char* p = l)
        {
          FastDoubleParser.ParseDouble(p, p + l.Length);


        }

      }
    }
  }
}
