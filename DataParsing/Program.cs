using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParsing
{
    internal class Program
    {
        private static Supabase.Client supabase;

        static async Task Main(string[] args)
        {
            await InitDb();
            await FetchData();
            Console.ReadLine();
        }
        public async static Task InitDb()
        {
            var url = "https://hudxrvxnsohtzkjtbihr.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imh1ZHhydnhuc29odHpranRiaWhyIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTU1MjY4NjIsImV4cCI6MjAzMTEwMjg2Mn0.TK38oOK4py_DC0MltY4wO2xHAtMDR-8jMcnwKNom7fo";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };


            supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
            
        }
        public static async Task FetchData()
        {

            var result = await supabase.From<DataModel>().Get();
            var data = result.Models;


            foreach (var item in data)
            {
                await Console.Out.WriteLineAsync(item.ToString());
            }
        }
    }
}
