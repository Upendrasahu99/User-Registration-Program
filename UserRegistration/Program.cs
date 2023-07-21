using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.CheckEmail("upr.sa3@gami.com");
            Console.ReadLine();
        }
    }
}
