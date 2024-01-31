using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ_Sender
{
    public class Person
    {
        //String value to store the name of the person
        public string Name { get; set; }

        //Constructor to initialize the Person object with a name
        public Person(string name)
        {
            Name = name;
        }
    }
}
//-------------------------------------End OF File------------------------------------------//
