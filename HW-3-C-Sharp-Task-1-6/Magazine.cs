using System;
using System.Text.RegularExpressions;


namespace HW_3_C_Sharp_Task_1_6
{
    class Magazine
    {
        public string Name { get; set; }
        private int foundationYear;
        private string phone;
        private string email;
        public string Description { get; set; }

        public int FoundationYear
        {
            get { return foundationYear; }
            set { foundationYear = value >= 1900 || value < 2022? value: 0; }
        }

        public Magazine()
        {
            this.Name = String.Empty;
            this.foundationYear = 0;
            this.phone = string.Empty;
            this.email = string.Empty;
            this.Description = string.Empty;
        }
        public Magazine (String name, int year, string phone, string email, string description)
        {
            this.Name = name;
            this.foundationYear = year;
            this.phone = phone;
            this.email = email;
            this.Description = description;
        }

        public Magazine (String name, int year, string phone, string email)
        {
            this.Name = name;
            this.foundationYear = year;
            this.phone = phone;
            this.email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {foundationYear.ToString()}, {phone}, {email}";
        }

        public void ShowAll()
        {
            Console.WriteLine($"The magazine {Name} was founded in {foundationYear} and has next contacts:");
            Console.WriteLine($"Phone - {phone}, Email - {email}");
            Console.WriteLine($"Short about {Name} - {Description}");
        }

        public void ShowDescription()
        {
            Console.WriteLine($"Description of the magazine {this.Name} - {this.Description}");
        }

        public void ShowPhoneEmail ()
        {
            Console.WriteLine($"The magazine {this.Name} has next phone - {this.phone} and email - {this.email}");
        }

        public void SetPhoneEmail (string phone, string email)
        {
            if (phone.Length < 13)
                this.phone = phone;

            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success)
                this.email = email;
        }

        public string GetPhone ()
        {
            return this.phone;
        }

        public string GetEmail()
        {
            return this.email;
        }
    }
}
