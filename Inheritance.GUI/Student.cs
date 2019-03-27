using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.GUI
{
    class Student : Person
    {
        DateTime income;
        String specialty;

        public DateTime Income { get => income; set => income = value; }
        public string Specialty { get => specialty; set => specialty = value; }

        public Student(string name, string phone, DateTime birthday, int pol, DateTime income, string specialty)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Phone = phone;
            this.Pol = pol;
            this.income = income;
            this.specialty = specialty;
        }

        public override string ToString()
        {
            return $"Student {base.ToString()}, InDate: {this.Income.ToShortDateString()}, specialty: {this.specialty}";
        }
    }
}
