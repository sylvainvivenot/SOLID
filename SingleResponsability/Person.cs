using System;

namespace SingleResponsability
{
    public class Person
    {
        private readonly DatabaseContext context;

        public Person(DatabaseContext context)
        {
            this.context = context;
        }

        public string Name { get; set; }


        public void AddToDatabase()
        {
            this.context.Persons.Add(this);
            this.context.SaveChanges();
            Console.WriteLine("Personne ajoutée");
        }
    }
}