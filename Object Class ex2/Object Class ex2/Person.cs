using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_ex2
{
    class Person
    {
        string fname;
        string lname;
        double payrate;
        double tax;
        double accountnumber;

        public Person(string _fname, string _lname, double _payrate, double _tax, double _accountnumber)
        {
            _fname = fname;
            _lname = lname;
            _payrate = payrate;
            _tax = tax;
            _accountnumber = accountnumber;
        }

        public string FirstName
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public double Payrate
        {
            get
            {
                return payrate;
            }
            set
            {
                payrate = value;
            }
        }

        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        public double AccountNumber
        {
            get
            {
                return accountnumber;
            }
            set
            {
                accountnumber = value;
            }
        }
    }
}
