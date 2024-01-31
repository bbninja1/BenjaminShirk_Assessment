using System;
using RabbitMQ_Library;

namespace RabbitMQ_Sender
{
    public class WorkerClass
    {
        /// <summary>
        /// String Method to gether the name from the user
        /// </summary>
        /// <returns></returns>
        public Person GetName()
        {
            string name;

            // Keep prompting the user until a valid name is entered
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Please enter your Name (enter 'exit' to stop):");
                name = Console.ReadLine().Trim();

                if (!isNameValid(name))
                {
                    Console.WriteLine("Invalid input. Please enter a name with only letters and No Spaces");
                }

                if (name.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you!");
                    Environment.Exit(0);
                }

            } while (!isNameValid(name));

            return new Person(name);
        }

        //Method to check if the name is valid 
        public bool isNameValid(string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(char.IsLetter) && !name.Contains(" ");
        }

        //sets the name to the person object and then sends the name to the RabbitMQConnection class.
        public void ProcessName()
        {
            Person person;
            do
            {
                // Sets the variable to the Person object
                person = GetName();

                if (person.Name.ToLower() != "exit")
                {
                    Connection.RabbitMQConnection(person.Name);
                }
            }
            //If the Name entered is exit then it will close the application
            while (person.Name.ToLower() != "exit");
        }
    }
}
//-------------------------------------End OF File------------------------------------------//