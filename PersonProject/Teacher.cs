using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProject
{
    public class Teacher : Person
    {
        private string _employeenumber;
        public string EmployeeNumber
        {
            get
            {
                return this._employeenumber;
            }

            set
            {
                this.EmployeeNumber = value;
            }
        }

        public void Teach()
        {
            throw new System.NotImplementedException();
        }
    }
}