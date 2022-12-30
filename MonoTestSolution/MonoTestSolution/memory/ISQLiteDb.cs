using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.memory
{
    public interface  ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();

        
    }
}
