using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace UserRegistration
{
    public class UserDetail
    {
        public bool CheckFirstName(string firstName)
        {
            string pattern = "[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            return (regex.IsMatch(firstName));
        }
        public bool CheckLastName(string lastName)
        {
            string pattern = "[A-Z]{1}[a-z}";
            Regex regex = new Regex(pattern);
            return (regex.IsMatch(lastName));
        }
        public bool CheckEmail(string email)
        {
            string pattern = "[A-Za-z0-9._]+@[[A-Za-z0-9._]+.[A-Za-z]{2,}";
            Regex regex = new Regex(pattern);
            Console.WriteLine(regex.IsMatch(email));
            return (regex.IsMatch(email));
        }
        
        public bool CheckMobileNumber(string mobileNumber)
        {
            string pattern = "[0-9]{10}";
            Regex regex = new Regex(pattern);
            return (regex.IsMatch(mobileNumber));
        }
        public bool CheckPassword(string password)
        {
            string pattern = "[A-Za-z0-9]{8,}";
            Regex regex = new Regex(pattern);
            return (regex.IsMatch(password));
        }
    }
}