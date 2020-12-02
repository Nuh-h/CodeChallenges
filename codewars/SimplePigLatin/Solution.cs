//Solution for "Simple Pig Latin" Kata (Kyu 5) from https://www.codewars.com/kata/520b9d2ad5c005041100000f

using System;

public class Kata
{
  public static string PigIt(string str)
  { 
    string[] source = str.Split(" ");
    string str1 = "";
    for(int i=0; i<source.Length;i++){
      if(source[i].Length>=1){
        string p1 = source[i][0].ToString();
        string p2 = source[i].Substring(1,source[i].Length-1);
        str1+=p2+p1+"ay"+" ";
      }
      else{
        str1+=source[i];
      }
    }
    return str1.Trim();
  }
}
