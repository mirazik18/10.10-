using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
            new Person
            {
               FullName = "Admin Admin",
               Age = 35
               },

            new Person
            {
               FullName = "Admin Admin",
               Age = 35
               }              
            };


            List<Mother> car = new List<Mother>
            {
            new Mother
            {
               FullName=  "Admin Admin",
               Age = 221
               },

                new Mother
               {
                FullName=  "Admin Admin",
               Age = 221
               }
            };


            List<Father> home = new List<Father>
            {
            new Father
            {
               FullName=  "Admin Admin",
               Age = 132
               },

                new Father
               {
                FullName=  "Admin Admin",
               Age = 132
               }
            };
            Console.ReadKey();
        }
    }
}
