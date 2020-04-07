using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = DillString.SummaryString(DillString.CreateList());
            Console.WriteLine(result);
        }
    }

    class DillString
    {
        public static List<int> CreateList()
        {
            List<int> arryList = new List<int>();
            int sum = int.Parse(Console.ReadLine());
            if (sum<=0)
            {
                arryList.Add(0);
            }
            else
            {
                for (int i = 0; i < sum; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    arryList.Add(num);
                }
            }
            return arryList;
        }

        public static int SummaryString(List<int> arryList)
        {
            int maxsum = 0, sum = 0;
            bool flag = false;
            foreach (var item in arryList)
            {
                if (item>=0)
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                for (int i = 0; i < arryList.Count; i++)
                {
                    sum = 0;
                    for (int k = i; k < arryList.Count; k++)
                    {
                        sum += arryList[k];
                        if (sum > maxsum)
                        {
                            maxsum = sum;
                        }
                    }
                }
            }
            return maxsum;
        }
    }
}
