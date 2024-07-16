using System;
using System.Drawing;
using System.Transactions;
using static leinda_said_sun_wed_5pm_C__06.Program;

namespace leinda_said_sun_wed_5pm_C__06
{
    internal class Program
    {
        public struct Person
        {

            public string Name { get; set; }
            public int age { get; set; }
            // function to display data
            public void Display()
            {
                Console.WriteLine("Name: " + this.Name + ", " + "Age: " + this.age);
            }
        }
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        static void Main(string[] args)
        {
            #region Question_1
            //            //create array of person
            //            Person[] persons = new Person[3];
            //            //populate array 
            //            persons[0] = new Person { Name = "leinda", age = 23 };
            //            persons[1] = new Person { Name = "mena", age = 24 };
            //            // display date
            //            foreach (Person person in persons)
            //            {
            //                person.Display();
            //            }

            //        }
            //    }
            //}
            #endregion

            #region  Question_2
            //Console.Write("Enter Number:");
            //Point[] points = new Point[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    if (double.TryParse(Console.ReadLine(), out double X) && double.TryParse(Console.ReadLine(), out double Y))
            //    {

            //        points[i].X = X;
            //        points[i].Y = Y;
            //    }
            //}
            //double distance = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y, 2));
            //Console.WriteLine("distance between 2 point is"  + distance);
            #endregion

            #region Question_3
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter A Number:");
            //    Person person = new Person();

            //    Console.Write("Enter Name:");
            //    person.Name = Console.ReadLine();

            //    Console.Write("Enter Age:");
            //    person.age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Name: " + person.Name + " " + "Age: " + person.age);

            //}
            #endregion
        }
    }
}
    











