using MonoTestSolution.memory;
using SQLite;

namespace MonoTestSolution
{
    public abstract class AppRuntimeSettings : ISQLiteDb
    {
        public abstract SQLiteAsyncConnection GetConnection();
    
    }
}
