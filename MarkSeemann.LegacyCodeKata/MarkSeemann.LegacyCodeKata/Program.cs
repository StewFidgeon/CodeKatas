using System;

namespace MarkSeemann.LegacyCodeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var sm = new SecurityManager(new ConsoleDatapipe(), new PasswordValidator(), new Cypher());
            sm.CreateUser();
            Console.ReadLine();
        }
    }
}
