using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._9
{
    class Program
    {
        static int maxNum = 100; 
        
        static void Main(string[] args)
        {
            //创建空
            List<int> numList = new List<int>(99);

            //初始化
            for(int i=2;i<=100;i++)
            {
                numList.Add(i);
            }

            //遍历判断删除
            for(int j=0;j<numList.Count();j++ )
            {
                for(int i=2;i<Math.Sqrt(maxNum);i++)
                {
                    if(numList[j]%i==0&&numList[j]/i!=1)
                    {
                        numList.RemoveAt(j);
                        j--;
                    }
                }               
            }

        }


    }
}
