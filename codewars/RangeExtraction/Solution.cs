//Solution for "Range Extraction" Kata (Kyu 4) from https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
//By far not the best solution, but for npw...

using System;
using System.Collections.Generic;
public class RangeExtraction
{
    public static string Extract(int[] args)
    {
      int lrange =0; //value for lower bound of range i.e. 1 in 1-3.
      int rrange =0; // range value i.e. 1-4 has range value 3.
      int previous = new int(); 
      bool first = true;
      bool notfirstZero = false;
      string frmatted = "";
      foreach(var i in args){
        if(i==previous+1 && !first){
          rrange+=1;
        }else{
          if(rrange==0 && lrange!=0){frmatted+=lrange+",";}
          else if(rrange==1){frmatted+=lrange+","+(lrange+rrange)+",";}
          else if(rrange!=0){frmatted+=lrange+"-"+(lrange+rrange)+",";}
          else if(lrange==0&&rrange==0&&!first){frmatted+=lrange+",";}
          lrange=0;
          rrange=0;
          notfirstZero=false;
        }
        
        first=false;
        previous=i;
        if(lrange==0&&!notfirstZero){
          lrange=i;
          notfirstZero=true;
        }
        if(args[args.Length-1]==i && rrange==0){frmatted+=lrange;}
        else if(args[args.Length-1]==i && rrange>1){frmatted+=lrange+"-"+(lrange+rrange);}
        else if(args[args.Length-1]==i){frmatted+=lrange+","+(lrange+rrange);}
      }
      return frmatted;
    }
}
