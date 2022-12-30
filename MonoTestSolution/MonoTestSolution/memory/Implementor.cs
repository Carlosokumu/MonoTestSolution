using MonoTestSolution.BootStrap;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.memory
{
    public class Implementor : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        public string GetConnectionString()
        {
            return AppContainer.ConnectionPath;
        }
    }
}
