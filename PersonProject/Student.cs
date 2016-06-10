using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProject
{
    public class Student : Person
    {
        private string _studentnumber;

        public Student(string name, int age, string studentnumber)
            : base(age,name)
        {
            
        }

        public string StudentNumber
        {
            get
            {
                return this._studentnumber;
            }

            set
            {
            }
        }
        public override string ToString()
        {
            string returnString = String.Format("Name: {0} \nAge: {1)\nStudent Number: {2)", this.Name, this.Age, this.StudentNumber);
            return returnString;
        }
    }
}