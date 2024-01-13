using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public class details
    {
        private string Name;
        private string password;
        private string email;
        private string address;
        private string NIRC;
        private int Phone;
        private int Age;
        private int Security;
        private string answer;
        private bool type;

        public string myName { get => Name; set => Name = value; }
        public string myPassword { get => password; set => password = value; }
        public string myEmail { get => email; set => email = value; }
        public string myAddress { get => address; set => address = value; }
        public int myPhone{ get => Phone; set => Phone = value; }
        public int myAge { get => Age; set => Age = value; }
        public string myNIRC { get => NIRC; set => NIRC = value; }
        public int mySecurity { get => Security; set => Security = value; }
        public string myAnswer { get => answer; set => answer = value; }
        public bool myType { get => type; set => type = value; }

        public details(string Name,string password,string email,string address,int Phone,
            int Age, string NIRC, int Security, string Answer, bool type)
        {
            myName = Name;
            myPassword = password;
            myEmail = email;
            myAddress = address;
            myPhone = Phone;
            myAge = Age;
            myNIRC = NIRC;
            mySecurity = Security;
            myAnswer = Answer;
            myType = type;
        }

        public details(string email, string username, string password) //Overload for Officer
        {
            myEmail = email;
            myName = username;
            myPassword = password;
        }
    }
}
