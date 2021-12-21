using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
       public Customer()
        {
            this.Id=-1;
            this.Name=string.Empty;
        }
        public void printId()
        {
            Console.WriteLine("Id="+this.Id);
        }
        public void printName()
        {
            Console.WriteLine("Name="+this.Name);
        }
        public void Test()
        {
            Type type = Type.GetType("Customer");
            Console.WriteLine("Full Name:"+type.FullName);
            Console.WriteLine("Full Name:"+type.Name);
            Console.WriteLine("Methods Information");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType+" "+method.Name);
            }
            Console.WriteLine("Properties in customer class...");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType+" "+property.Name);
            }
            Console.WriteLine("Constructor Information");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString);
            }

        }
    }
}
