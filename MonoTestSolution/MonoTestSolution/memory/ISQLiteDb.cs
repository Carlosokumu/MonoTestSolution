using SQLite;

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
