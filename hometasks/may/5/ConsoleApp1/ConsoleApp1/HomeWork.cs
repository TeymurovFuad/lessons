using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HWStudent
    {
        private string lName;
        private string mail;
        private string domain = "gmail.com";

        public HWStudent()
        {

        }

        public string FName { get; set; }

        public string LName
        {
            get
            {
                return this.lName;
            }
            set
            {
                this.lName = value;
            }
        }

        public string Mail
        {
            get
            {
                return GenerateMail();
            }
        }

        private string GenerateMail()
        {
            this.mail = FName.ToLower() + "." + lName.ToLower() + "@" + this.domain;
            return this.mail;
        }
    }
}
