using System;
using System.Text.RegularExpressions;


namespace HW_3_C_Sharp_Task_1_6
{
    class Shop
    {
        private string name;
        private string address;
        private string profile;
        private string phone;
        private string email;

        public Shop()
        {
            this.name = string.Empty;
            this.address = string.Empty;
            this.profile = string.Empty;
            this.phone = string.Empty;
            this.email = string.Empty;
        }

        public Shop (string name, string address, string profile, string phone, string email)
        {
            this.name = name;
            this.address = address;
            this.profile = profile;
            this.phone = phone;
            this.email = email;
        }

        public Shop (string name, string phone, string address, string email)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {profile}, {address}, {phone}, {email}";
        }

        public void Print()
        {
            Console.WriteLine($"Shop {Name} has profile {profile} and next contact data:");
            Console.WriteLine($"address - {Address}, phone - {phone}, email - {email}");
        }

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { 
                if (value.Length < 13)
                phone = value; }
        }

        public string Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        public string Email
        {
            get { return email; }
            set 
            { 
                string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
                Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
                if(isMatch.Success)
                email = value; 
            }
        }
    }
}
