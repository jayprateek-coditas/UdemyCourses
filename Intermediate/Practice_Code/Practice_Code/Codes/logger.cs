using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Code.Codes
{
    // Create a class object by giving the string 
    public class logger
    {
        public void log(string msg)
        {
            Console.WriteLine(msg);
        }
      
    }

    public class Installer
    {
        private readonly logger _logger;

        public Installer(logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.log("We are installing the application");

        }
    }

    public class DbMigrator
    {
        private readonly logger _logger;
        public DbMigrator(logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.log("We are migrating blah blah blah...");
        }

    }
}


