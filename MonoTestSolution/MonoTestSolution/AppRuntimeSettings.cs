using MonoTestSolution.memory;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution
{
    public abstract class AppRuntimeSettings : ISQLiteDb
    {
        public abstract SQLiteAsyncConnection GetConnection();
    
    }
}
