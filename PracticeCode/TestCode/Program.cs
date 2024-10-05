
using System;
using System.Linq;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> lst = recamanSequence(100);
foreach(var v in lst)
{
    Console.Write(v.ToString() + "  ");
}

 static List<int> recamanSequence(int n)
    {
        List<int> result = new List<int>();
        if(n >= 1)
        {
            int[] temp = new int[n];
            int p;
            temp[0] =0;
            for(int i=0; i<n ; i++)
            {
                int prev = temp[i-1];
                int next = prev - i;
                p = temp[i-1] - i;
                if(next>0 && !temp.Contains(next))
                    temp[i] = p;
                else
                    temp[i] = temp[i-1] + i;
            }
            
            foreach(var v in temp)
                result.Add(v);
        }
        return result;
    }
