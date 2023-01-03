using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.memory
{

    /*
       *Interface to Establish  SQLiteConnection 
     */
    public interface  ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();

        
    }
}
