using DevExpress.Xpo;
using System;

namespace KFXForms.Properties
{
    public class CustomerClient : XPObject
    {
        public CustomerClient(Session session) : base(session)
        {
            // Constructor used when loading an object from persistent storage.
            // Do not place any code here.
        }

        // test2


        string login;
        [Size(50)]
        public string Login
        {
            get { return login; }
            set { SetPropertyValue(nameof(Login), ref login, value); }
        }

        string password;
        [Size(50)]
        public string Password
        {
            get { return password; }
            set { SetPropertyValue(nameof(Password), ref password, value); }
        }

        DateTime expiryDate;
        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { SetPropertyValue(nameof(ExpiryDate), ref expiryDate, value); }
        }

        bool activate;
        public bool Activate
        {
            get { return activate; }
            set { SetPropertyValue(nameof(Activate), ref activate, value); }
        }

        bool online;
        public bool Online
        {
            get { return online; }
            set { SetPropertyValue(nameof(Online), ref online, value); }
        }

        string host;
        [Size(250)]
        public string Host
        {
            get { return host; }
            set { SetPropertyValue(nameof(Host), ref host, value); }
        }

    }
}
