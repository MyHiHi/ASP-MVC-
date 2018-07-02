using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Pro.Areas.LX02.Models
{
    public class UserInfo
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string userPassword;

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        private string userEmail;

        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        private string userPhone;

        public string UserPhone
        {
            get { return userPhone; }
            set { userPhone = value; }
        }

        private DateTime userBirth;
        public DateTime UserBirth
        {
            get { return userBirth; }
            set { userBirth = value; }
        }

    }
}