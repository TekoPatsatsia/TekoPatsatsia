using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TekoPatsatsia.Tasks
{
    public class Task8
    {
        private static readonly Dictionary<string, double> Rates = new();
        public static void CreateDict()
        {
            var xmlString = "";
            const string pattern = @"<td>(.*?)<\/td>";
            var rgx = new Regex(pattern);
            using (var request = new WebClient())
            {
                var requestData = request.DownloadData("http://www.nbg.ge/rss.php");

                xmlString = Encoding.ASCII.GetString(requestData);
            }
            var i = 0;
            var key = "";
            foreach (Match match in rgx.Matches(xmlString))
            {
                var val = match.Value.Substring(4, match.Value.Length - 9);
                if (i % 5 == 2)
                {
                    Rates[key] = Convert.ToDouble(val);
                }
                if (i % 5 == 0)
                {
                    key = val;
                }
                i++;
            }
        }

        public static double ExchangeRate(string from, string to)
        {
            return Rates[from] / Rates[to];
        }
    }
}
