using System;
using Newtonsoft.Json;

namespace ConsumeANugetPackage
{
    public class Account
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public DateTime DOB {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account acount = new Account
            {
                Name = "May Lang Thang",
                Email = "maylangthang@maylangthang.com",
                DOB = new DateTime(1987,8,1,0,0,0, DateTimeKind.Utc)
            };
            string json = JsonConvert.SerializeObject(acount,Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
