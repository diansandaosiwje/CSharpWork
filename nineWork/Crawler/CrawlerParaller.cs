using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
    class CrawlerParaller
    {
        Stopwatch stopwatch = new Stopwatch();
        private int count = 0;
        private int max = 100;
        public ConcurrentBag<String> complated = new ConcurrentBag<string>();
        public ConcurrentQueue<String> pending = new ConcurrentQueue<string>();

        public void Start(String url,int max)
        {
            stopwatch.Start();
            count = 0;
            this.max = max;
            Task.Run(() => DownloadAndParse(url));
            while(count<this.max)
            {
                String u;
                pending.TryDequeue(out u);
                if(u!=null)
                {
                    Task.Run(() => DownloadAndParse(u));
                }
            }
            stopwatch.Stop();
            Console.WriteLine("time cost:" + stopwatch.ElapsedMilliseconds);
        }
               

        public void DownloadAndParse(String url)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                if (count > max) return;
                Console.WriteLine($"{count}:Downlonding {url}");
                String page = client.DownloadString(url);
                File.WriteAllText(count.ToString(), page, Encoding.UTF8);
                count++;
                this.complated.Add(url);
                Console.WriteLine($"Parsing {url}");
                Parse(page);
            }
            catch { }
        }

        private void Parse(string page)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(page);
            foreach (Match match in matches)
            {
                String url = match.Value.Substring(match.Value.IndexOf("=") + 1)
                  .Trim('"', '\"', '#', ',', '>');
                if (url.Length == 0) continue;
                if (!pending.Contains(url) && !complated.Contains(url))
                {
                    pending.Enqueue(url);
                }
            }
        }


    }
}
