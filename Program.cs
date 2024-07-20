using System.Reflection;
using ReflectionPOC.Models;

namespace ReflectionPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myClassType = typeof(Account);

           
            PropertyInfo[] properties = myClassType.GetProperties();
            Console.WriteLine($"Number of properties: {properties.Length}");



            MethodInfo[] methods = myClassType.GetMethods
                (BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            Console.WriteLine($"Number of methods: {methods.Length}");


            ConstructorInfo[] constructors = myClassType.GetConstructors();
            Console.WriteLine($"Number of constructors: {constructors.Length}");
        }
    }
}
