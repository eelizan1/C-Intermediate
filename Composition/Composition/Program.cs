using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
            Console.Read();
        }
    }

    // logging class - this is used between two classes (Composition relationship)
    public class Logger
    {
        public void Log(string message)
        {
            
            Console.WriteLine(message);
        }
    }

    // class responsible for migrating database 
    public class DbMigrator
    {
        private readonly Logger _logger;

        // in the constructor create an association to the logger class
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating...");
        }
    }

    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger; 
        }

        public void Install()
        {
            _logger.Log("Installing applications");
        }
    }
}
