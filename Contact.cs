using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager8796565
{
    class Contact
    {
        public int contactID
        {
            get { return contactID; }
            set { contactID = value;}
        }

        private string contactFname;
        public string ContactFname 
     
        {
            get { return contactFname; }
            set { contactFname = value;}
        }

        private string contactLname;
        public string ContactLname

        {
            get { return contactLname; }
            set { contactLname = value; }
        }

        private int contactTel;
        public int ContactTel
        {
            get { return contactTel; }
            set { contactTel = value; }
        }

        private string contactEmail;
        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }

        private string contactAddr1;
        public string ContactAddr1

        {
            get { return contactAddr1; }
            set { contactAddr1 = value; }
        } /// <summary>
        /// 
        /// </summary>
        /// hgughyu

        private string contactAddr2;
        public string ContactAddr2
        {
            get { return contactAddr2; }
            set { contactAddr2 = value; }
        }

        private string contactCity;
        public string ContactCity
        {
            get { return contactCity; }
            set { ContactCity = value; }
        }

        private string contactPostcode;
        public string ContactPostcode
        {
            get { return contactPostcode; }
            set { contactPostcode = value; }
        }
    }
}
