//Solution for "Maximum subarray sum" Kata (Kyu 5) from https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c

using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
    if(arr.Length==0){
      return 0;
    }
    var arrList = arr.ToList();
    var arrSubSeqs = Enumerable.Range(0, arrList.Count)
                  .SelectMany(start => Enumerable.Range(1, arrList.Count-start)
                  .Select(count => arrList.GetRange(start, count)));
    var maxSum = (from answer in arrSubSeqs select answer.Sum()).Max();
    var maxSubSeq = (from answer in arrSubSeqs
             where answer.Sum()==maxSum select answer).FirstOrDefault();
    
    return maxSum;
  }
}
