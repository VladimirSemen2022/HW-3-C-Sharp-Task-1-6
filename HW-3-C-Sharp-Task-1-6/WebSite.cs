using System;
using System.Text.RegularExpressions;

namespace HW_3_C_Sharp_Task_1_6
{
    class WebSite
    {
        private string siteName;
        private string sitePath;
        private string ipAddr;
        public string Description { get; set; }

        public WebSite ()
        {
            this.siteName = string.Empty;
            this.sitePath = string.Empty;
            this.ipAddr = string.Empty;
            this.Description = string.Empty;
        }

        public WebSite (string name, string path, string ip, string description)
        {
            this.siteName = name;
            this.sitePath = path;
            SetIp(ip);
            this.Description = description;
        }

        public WebSite(string name, string path, string ip)
        {
            this.siteName = name;
            this.sitePath = path;
            this.ipAddr = ip;
        }

        public void Print()
        {
            Console.Write($"This site has name - {this.siteName}");
            Console.Write($" with path to site - {this.sitePath}");
            Console.Write($" and IP address - {this.ipAddr}\n");
            Console.WriteLine($"The description of the site: {this.Description}");
        }

        public string GetIp()
        {
            return this.ipAddr;
        }

        public void SetIp(string ip)
        {
            string pattern = "^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9]).){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])$";
            Match isMatch = Regex.Match(ip, pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success)
                this.ipAddr = ip;
        }

        public string SiteName
        {
            get { return siteName; }
            set {
                if (value.Length < 50)
                    siteName = value; }
        }

        public string SitePath
        {
            get { return sitePath; }
            set {
                if (value.Length <= 75)
                    sitePath = value; }
        }
    }
}
