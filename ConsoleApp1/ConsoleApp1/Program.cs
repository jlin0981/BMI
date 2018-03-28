using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor =  ConsoleColor.Gray ;
            Console.ForegroundColor =  ConsoleColor.Blue;
            Console.WriteLine( " 請依序打出使用者的身高 ( 公尺 ) 及體重 ( 公斤 ) " ) ;
            double h = double.Parse( Console.ReadLine ( ) ) ;
            double w = double.Parse( Console.ReadLine ( ) ) ;
            double BMI;
            BMI = w / ( h * h ) ;

            if ( BMI < 16.5 ) 
            { Console.WriteLine( " 免役體位 & 體重過輕 " ) ; }
            if (BMI >= 16.5  && BMI < 17)
            { Console.WriteLine( " 替代役體位 & 體重過輕 " ) ; }
            if (BMI >= 17 && BMI < 18.5)
            { Console.WriteLine( " 常備役體位 & 體重過輕 " ) ; }
            if (BMI >= 18.5 && BMI < 24)
            { Console.WriteLine( " 常備役體位 & 體重正常 " ) ; }
            if (BMI >= 24 && BMI < 27)
            { Console.WriteLine( " 常備役體位 & 體重過重 " ); }
            if (BMI >= 27 && BMI < 30)
            { Console.WriteLine( " 常備役體位 & 輕度肥胖 " ); }
            if (BMI >= 30 && BMI < 31)
            { Console.WriteLine( " 常備役體位 & 中度肥胖 " ); }
            if (BMI >= 31 && BMI < 31.5)
            { Console.WriteLine( " 替代役體位 & 中度肥胖 " ); }
            if (BMI >= 31.5 && BMI < 35)
            { Console.WriteLine( " 免役體位 & 中度肥胖 " ); }
            if (BMI >= 35 )
            { Console.WriteLine( " 免役體位 & 重度肥胖 " ); }
            Console.ReadLine();

        }
    }
}
