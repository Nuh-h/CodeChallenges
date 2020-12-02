//This is the solution to "The Observed PIN" Kata (4 Kyu) from https://www.codewars.com/kata/5263c6999e0f40dee200059d
// It is a simplistic approach

using System.Collections.Generic;
using System;
using System.Linq;
public class Kata
{
    public static List<string> GetPINs(string observed)
    {
      List<List<string>> sets = new List<List<string>>();
      foreach(var c in observed){
        int digit = (int)char.GetNumericValue(c);
        switch(digit){
            case 0: sets.Add(new List<string>{"0","8"}); break;
            case 1: sets.Add(new List<string>{"1","4","2"}); break;
            case 2: sets.Add(new List<string>{"1","2","3","5"}); break;
            case 3: sets.Add(new List<string>{"2","3","6"}); break;
            case 4: sets.Add(new List<string>{"1","4","5","7"}); break;
            case 5: sets.Add(new List<string>{"2","4","5","6","8"}); break;
            case 6: sets.Add(new List<string>{"3","5","6","9"}); break;
            case 7: sets.Add(new List<string>{"4","7","8"}); break;
            case 8: sets.Add(new List<string>{"0","8","5","7","9"}); break;
            default: sets.Add(new List<string>{"6","8","9"}); break;
        }
      }
      
      //Thanks to stackExchange https://stackoverflow.com/a/61424600
      IEnumerable<string> combos = new[] { "" };

      foreach (var inner in sets)
      {
          combos = combos.SelectMany(r => inner.Select(x => r + x));
      }
  
      return combos.ToList();
    }
}
