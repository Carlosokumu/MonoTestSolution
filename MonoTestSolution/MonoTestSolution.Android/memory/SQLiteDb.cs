using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac;
using AutoMapper;
using MonoTestSolution.BootStrap;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
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

        public SQLiteDb() { }
        

        public override SQLiteAsyncConnection GetConnection()
        {
            
            string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "VehiclesCollections.db");
            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly; 
            Stream embbededDatabaseStream = assembly.GetManifestResourceStream("MonoTestSolution.Cars.db");
            if (embbededDatabaseStream == null )
            {
                return null;
            }
            /*
               * Pre-populate data from the EmbbededDatabaseStream into the file
            */

            if (!File.Exists(DatabasePath))
            {
                FileStream fileStream = File.Create(DatabasePath);
                embbededDatabaseStream.Seek(0, SeekOrigin.Begin);
                embbededDatabaseStream.CopyTo(fileStream);
                fileStream.Close();
            }

            return new SQLiteAsyncConnection(DatabasePath);


        }

    }
 }
