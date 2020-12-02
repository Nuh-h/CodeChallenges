//Solution which scores 100% on accuracy but 0% on Time (overall: 50%) link: https://app.codility.com/demo/results/training63CUKE-RXX/

using System;
// using System.Collections.Generic;

class Solution {
    public int solution(int[] H) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] lMax = new int[H.Length];
        int[] rMax = new int[H.Length];
        int max_l=0;
        int max_r=0;
        for(int i=0;i<H.Length;i++){
            lMax[i] = H[i]>=max_l?H[i]:max_l;
            max_l=lMax[i];
            rMax[i] = H[H.Length-i-1]>=max_r?H[H.Length-i-1]:max_r;
            max_r=rMax[i];
            Console.Write(lMax[i]+"-"+rMax[i]+" ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("---");
        int[] leftT = new int[H.Length+1];//leftRunningTotal
        int[] rightT = new int[H.Length+2];//rightRunningTotal
        rightT[H.Length+1]=0; leftT[0]=0;
        for(int k=0; k<H.Length;k++){
            leftT[k+1]=(k+1)*lMax[k];
            rightT[H.Length-k]=(k+1)*rMax[k];
            Console.Write("{"+leftT[k]+" "+rightT[H.Length-k]+"} ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("---");
        //Array.Reverse(leftT);
        int MIN = 2147483647;
        for(int m=0; m<H.Length+1;m++){
            MIN=leftT[m]+rightT[m+1]>=MIN?MIN:leftT[m]+rightT[m+1];
            Console.Write(MIN+$" <{leftT[m]},{rightT[m+1]}> ");
        }
        return MIN;
    }
}
