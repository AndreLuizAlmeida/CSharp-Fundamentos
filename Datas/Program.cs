using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            // var data = new DateTime();
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.DayOfYear);
            Console.WriteLine(data.Kind);

            // var data = DateTime.Now;
            // var dataFormatada = string.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            // var dataFormatada = string.Format("{0:f}", data);
            // Console.WriteLine(dataFormatada);

            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(10));
            Console.WriteLine(data.ToUniversalTime());
            Console.WriteLine(data.AddMonths(2));
            Console.WriteLine(data.AddYears(1));
            Console.WriteLine(data);   

            var pt = new System.Globalization.CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;
            
            Console.WriteLine(DateTime.Now.ToString("D",br));
            Console.WriteLine(DateTime.Now.ToString("D",en));
            Console.WriteLine(DateTime.Now.ToString("D",de));
            Console.WriteLine(DateTime.Now.ToString("D",atual));

            var dataUtc = DateTime.UtcNow;
            Console.WriteLine(dataUtc);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(dataUtc.ToLocalTime());
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezoneAustralia);
            Console.WriteLine(horaAustralia);
            var timezoneHawaii = TimeZoneInfo.FindSystemTimeZoneById("Hawaiian Standard Time");
            Console.WriteLine(timezoneHawaii);
            var horaHawaii = TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezoneHawaii);
            Console.WriteLine(horaHawaii);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezone));
                Console.WriteLine("--------");

                var timeSpan = new TimeSpan(3, 1, 10, 12, 300);
                Console.WriteLine(timeSpan);
                Console.WriteLine(timeSpan.Days);
            }
        }
    }
}

