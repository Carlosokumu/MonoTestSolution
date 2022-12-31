using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MonoTestSolution.BootStrap;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Environment = System.Environment;

[assembly: Dependency(typeof(MonoTestSolution.Droid.memory.SQLiteDb))]
namespace MonoTestSolution.Droid.memory
{
    
        public class SQLiteDb : AppRuntimeSettings
        {
        

        public override SQLiteAsyncConnection GetConnection()
        {
            //var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //var path = Path.Combine(documentsPath, "MySQLite.db3");
            string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cars.db");
            //Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(AppContext)).Assembly;

            //Stream embbededDatabaseStream = assembly.GetManifestResourceStream("MonoTestSolution.Android.Cars.db");

            //if (!File.Exists(DatabasePath))
            //{
            //    FileStream fileStream = File.Create(DatabasePath);
            //    embbededDatabaseStream.Seek(0, SeekOrigin.Begin);
            //    embbededDatabaseStream.CopyTo(fileStream);
            //    fileStream.Close();
            //}

            return new SQLiteAsyncConnection(DatabasePath);
            
            
            
            
        }

    }
 }
