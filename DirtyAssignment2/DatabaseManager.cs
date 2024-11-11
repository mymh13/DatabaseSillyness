using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtyAssignment2
{
    // Defining enum for database types
    internal enum DatabaseType
    {
        MongoDB,
        MySQL,
        SQLite,
        API
    }

    // Factory pattern-like model using switch-case to determine the connection string based on the database type
    // Constructor with a dynamic connection string based on the database type
    internal class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(DatabaseType dbType)
        {
            // Set the connection string based on the database type
            switch (dbType)
            {
                case DatabaseType.MongoDB:
                    _connectionString = "mongodb://localhost:27017";
                    break;
                case DatabaseType.MySQL:
                    _connectionString = "server=localhost;user=youdlovetogetthatright;password=1234hahaha";
                    break;
                case DatabaseType.SQLite:
                    string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\library.db");
                    _connectionString = $"Data Source={databasePath}";
                    break;
                case DatabaseType.API:
                    _connectionString = "https://api.thiscouldbeanexamplemaybe.com";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dbType), dbType, null);
            }
        }
    }
}
