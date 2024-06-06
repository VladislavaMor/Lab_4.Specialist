using System.Reflection;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly lib = Assembly.LoadFrom("ClassLibrary1.dll");

            Type[] cti = lib.GetTypes();

            for(int i = 0; i < cti.Length; i++)
            {
                Console.Write($"{i} класс: " + cti[i].Name);
                PropertyInfo[] fields = cti[i].GetProperties();           
                foreach (var field in fields)
                {
                    Console.Write($"\n\t" + field.Name +$"\t" + field.PropertyType);
                }
                Console.WriteLine();
            }
        }
    }
}
