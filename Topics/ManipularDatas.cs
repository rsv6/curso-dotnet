using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TopicsDotNet.Topics;

public class ManipularDatas
{
    
    public static void ExecutarDatas()
    {
        Console.Clear();
        
        // var data = new DateTime(2024, 1, 1);
        // var data = new DateTime(
        //     DateTime.Now.Year, 
        //     DateTime.Now.Month, 
        //     DateTime.Now.Day
        // );
        
        // var data = DateTime.Now;

        // Console.WriteLine(data);
        // Console.WriteLine(data.DayOfWeek);
        // Console.WriteLine((int)data.DayOfWeek);
        // Console.WriteLine(data.DayOfYear);

        DateTime data = DateTime.Now;

        
        // var formatada = String.Format("{0:yyyy}", data);    // 2024
        // var formatada = String.Format("{0:y}", data);    // Janeiro de 2024
        // var formatada = String.Format("{0:M}", data);    // 7 de Janeiro
        // var formatada = String.Format("{0:mm}", data);    // 02
        // var formatada = String.Format("{0:dd-MM-yyyy hh:mm:ss}", data);    // 07-01-2024 05:05:53
        // var formatada = String.Format("{0:t}", data);    // 17:08
        // var formatada = String.Format("{0:d}", data);    // 07/01/2024
        // var formatada = String.Format("{0:T}", data);    // 17:09:54
        // var formatada = String.Format("{0:D}", data);    // domingo, 7 de janeiro de 2024
        // var formatada = String.Format("{0:f}", data);    // domingo, 7 de janeiro de 2024 17:11
        // var formatada = String.Format("{0:g}", data);   // 07/01/2024 17:11
        // var formatada = String.Format("{0:r}", data);   // Sun, 07 Jan 2024 17:12:41 GMT
        // var formatada = String.Format("{0:s}", data);   // 2024-01-07T17:13:27 -> mongodb usa esse tipo para data
        // var formatada = String.Format("{0:u}", data);   //2024-01-07 17:14:04Z
        // Console.WriteLine(formatada);

        // Console.WriteLine(data);
        // Console.WriteLine(data.AddDays(25));
        // Console.WriteLine(data.AddMonths(1));
        // Console.WriteLine(data.AddYears(1));

        // Comparando datas:
        Console.WriteLine(data);

        if (data.Date == DateTime.Now.Date) {
            Console.WriteLine("É igual");
        }

    }
}
