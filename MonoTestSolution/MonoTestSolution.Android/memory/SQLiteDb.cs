using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MonoTestSolution.memory;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Environment = System.Environment;

[assembly: Dependency(typeof(MonoTestSolution.Droid.memory.SQLiteDb))]
namespace MonoTestSolution.Droid.memory
{
    
        public class SQLiteDb : ISQLiteDb
        {
            public SQLiteAsyncConnection GetConnection()
            {
                var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var path = Path.Combine(documentsPath, "MySQLite.db3");
                return new SQLiteAsyncConnection(path);
            }
        }
 }
