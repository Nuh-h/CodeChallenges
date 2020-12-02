//Solution in C# for "Permutations" Kata (Kyu 4) from https://www.codewars.com/kata/5254ca2719453dcc0b00027d

using System;
using System.Collections.Generic;
class Permutations
{
    public static List<string> SinglePermutations(string s){
      List<string> results = new List<string>();
      var ss= s.ToCharArray();
      permutes(ss,0,results);
      return results;
    }
    private static void permutes(char[] ss,  int start, List<string> results){
      if(start>=ss.Length){
        var str = new string(ss);
        if(!results.Contains(str)){results.Add(str);}
      }
      else{
        for(int i=start; i<ss.Length;i++){
          swap(ss,start,i);
          permutes(ss,start+1,results);
          swap(ss,start,i);
        }
      }
    }
    private static void swap(char[] ss, int i, int j){
      var temp = ss[i];
      ss[i]=ss[j];
      ss[j]=temp;
    }
  }
