using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MisterManager
{
    public partial class Worker
    {
        public static string GetLatestMisterDate(string website)
        {
            //Downloading the list
            string response = Worker.GetWeb(website);

            //Finding starting position to find the latest date of release
            int x = response.Length - 12;

            string latest = response.Substring(x, 8);
            return latest;
        }

        public static string GetLatestCoreDate(string website)
        {
            //Downloading the list
            string response = Worker.GetWeb(website);

            //Finding starting position to find the latest date of release
            int x = response.Length - 16;
            string latest = response.Substring(x, 8);

            string regex = @"^\d{4}((0[1-9])|(1[012]))((0[1-9]|[12]\d)|3[01])$";
            int y = 16;

            while (!Regex.IsMatch(latest, regex))
            {
                x = response.Length - y;
                latest = response.Substring(x, 8);
                y++;
                
                //Console.WriteLine(latest + " " + Regex.IsMatch(latest, regex));
            }
            return latest;
        }

        private static string GetWeb (string url)
        {
            //Creating new Webclient to download the list of releases
            WebClient client = new WebClient();
            //Adding a header for Github
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            string response = client.DownloadString(url);

            return response;
        }

        public static void GetFile (string repo, string path)
        {
            //Creating new Webclient to download the list of releases
            WebClient client = new WebClient();
            //Adding a header for Github
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            client.DownloadFile(repo, path);
        }

    }
    
}