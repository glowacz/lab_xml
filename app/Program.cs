using Library;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\glowa\\source\\repos\\ProjOb\\lab2_cs\\lab2_cs\\library.xml";
            typeLib lib = LibraryReader.ReadLibrary(path);
            foreach (var item in lib.book)
            {
                Console.WriteLine(item.title);

                foreach (var aut in item.authorr)
                {
                    foreach (var aut_main in lib.author)
                    {
                        //Console.WriteLine(aut_main.surname + aut_main.surname.Length);
                        if (aut_main.id == aut.id)
                        {
                            Console.WriteLine(string.Join(", ", aut_main.name) + " " + aut_main.surname);
                            //Console.WriteLine(aut_main.surname);
                        }
                    }
                }
            }
        }
    }
}