using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb(); 
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = web.Load("https://vnexpress.net/du-lich");
        }
    }
}
