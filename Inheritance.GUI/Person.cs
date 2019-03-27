using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.GUI
{
    class Person
    {
        private String name;
        private String phone;
        private DateTime birthday;
        private int pol;
        private DateTime registration;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Pol { get => pol; set => pol = value > 2 ? 2 : value; }
        public DateTime Registration { get => registration; }

        public Person(string name, string phone, DateTime birthday, int pol)
        {
            this.name = name;
            this.phone = phone;
            this.birthday = birthday;
            Pol = pol;
            registration = DateTime.Now;
        }

        public Person(string name, DateTime birthday, int pol)
        {
            this.name = name;
            this.birthday = birthday;
            Pol = pol;
            registration = DateTime.Now;
        }

        public Person()
        {
            registration = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Person: {this.name}, phone: {(this.phone != null? this.phone : "-")}, birthday: {this.birthday.ToShortDateString()}, {(this.pol == 1 ? "man" : this.pol == 2 ? "woman" : "n/a")}, regdate: {this.registration.ToShortDateString()}";
        }
    }
}
