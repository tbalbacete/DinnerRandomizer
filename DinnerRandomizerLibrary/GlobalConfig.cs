using DinnerRandomizerLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DinnerRandomizerLibrary
{
    public class GlobalConfig
    {
        public const string RecipeFile = "Recipes.csv";

        public static IDataConnection Connection { get; set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector if needed
            }

            else if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
    }
}
