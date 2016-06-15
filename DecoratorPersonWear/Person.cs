using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPersonWear
{
    public class Person
    {
        public Person(){}

        private string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        
        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",Name);
        }
    }

    public class Finery:Person
    {
        protected Person PersonComponet { get; set; }

        public void Decorate(Person person)
        {
            PersonComponet = person;
        }

        public override void Show()
        {
            if(PersonComponet!=null)
            {
                PersonComponet.Show();
            }
        }
    }



    public class TShits: Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");

            base.Show();
        }
    }

    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤 ");

            base.Show();
        }
    }

}
